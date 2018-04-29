using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BitFlyerOrderApp
{
    public partial class OrderListForm : AppForm
    {
        private static OrderListForm _instance;
        public static OrderListForm Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                {
                    _instance = new OrderListForm();
                }
                return _instance;
            }
        }

        Dictionary<string, OrderInfo> bsMap = new Dictionary<string, OrderInfo>();
        // 2箇所でしか使わないので雑処理m(__)m
        Object orderListLock = new object();
        bool orderTimerLockFlg = false;

        Object positionListLock = new object();
        bool positionTimerLockFlg = false;

        private BindingSource orderBs, positionSumBs, positionBs;
        public OrderListForm() : base()
        {
            InitializeComponent();

            ApplyMouseMove<System.Windows.Forms.Label>(this);
            ApplyMouseMove<DataGridView>(this);

            orderBs = new BindingSource
            {
                AllowNew = true,
                DataSource = new BindingList<OrderInfo>()
            };
            OrderGridView.AutoGenerateColumns = false;
            OrderGridView.DataSource = orderBs;

            positionBs = new BindingSource
            {
                AllowNew = true,
                DataSource = new BindingList<PositionInfoResponseJson>()
            };
            PositionGridView.AutoGenerateColumns = false;
            PositionGridView.DataSource = positionBs;

            positionSumBs = new BindingSource
            {
                AllowNew = true,
                DataSource = new BindingList<PositionSummaryInfo>()
            };
            PositionSummaryGridView.AutoGenerateColumns = false;
            PositionSummaryGridView.DataSource = positionSumBs;
        }

        private void OrderListForm_Load(object sender, EventArgs e)
        {
        }

        private async void OrderGridView_Timer(object sender, EventArgs e)
        {
            lock(orderListLock)
            {
                if (orderTimerLockFlg) return;
                orderTimerLockFlg = true;
            }
            OrderCheckTimer.Stop();

            /**
             * DataGridに表示したいもの 
             * 注文命令を出して、child_ochild_order_acceptance_idが発行されたが、注文一覧に未反映の物
             * 注文一覧に反映済みのもの
             * 注文処理が終わったものは消去
             **/
            var list = await BitFlyerApiModel.GetOrderList();

            if (list != null)
            {
                // 最新のchild_order_listを保存
                var orderRecodeSet = new HashSet<string>();

                list.ForEach(info =>
                {
                    // 注文情報を生成
                    var orderInfo = new OrderInfo()
                    {
                        //OrderDateTime
                        //ServerResponsedTime
                        //ElapsedTime
                        OrderType = info.child_order_type,
                        OrderAcceptTime = Util.FormatDateIsoToLocal(info.child_order_date, Util.DATETIME_FORMAT_MDHMS),
                        ExpireDate = Util.FormatDateIsoToLocal(info.expire_date, Util.DATETIME_FORMAT_MDHMS),
                        Side = info.side,
                        OrderPrice = info.price,
                        OrderSize = info.size,
                        RemainingSize = info.outstanding_size,
                        AveragePrice = info.average_price,
                        Cancel = "×",
                        ChildOrderAcceptanceId = info.child_order_acceptance_id,
                        ChildOrderId = info.child_order_id
                    };

                    orderRecodeSet.Add(info.child_order_acceptance_id);

                    lock (bsMap)
                    {
                        if (bsMap.ContainsKey(info.child_order_acceptance_id))
                        {
                            // 既にGridに追加されていれば上書きする
                            // 未承認データの場合は、その項目を追加してから上書きする
                            var index = orderBs.List.IndexOf(bsMap[info.child_order_acceptance_id]);
                            if (!orderInfo.Equals(orderBs.List[index]))
                            {
                                // このデータだけは注文時の物を利用するので引き継ぐ
                                orderInfo.OrderDateTime = ((OrderInfo)orderBs.List[index]).OrderDateTime;
                                orderBs.List[index] = orderInfo;
                                bsMap[info.child_order_acceptance_id] = orderInfo;
                            }
                        }
                        else
                        {
                            // bsMapとGridに追加する
                            orderBs.Add(orderInfo);
                            bsMap.Add(info.child_order_acceptance_id, orderInfo);
                        }
                    }
                });

                lock (bsMap)
                {
                    // 保有済みのデータをチェックし古いデータを取り除く
                    foreach (var childId in bsMap.Keys.Reverse())
                    {
                        // 最新情報にあるのでスルー
                        if (orderRecodeSet.Contains(childId)) continue;

                        var orderInfo = bsMap[childId];
                        // 今回の確認リストにないが、既に承認済みのレコードは消去
                        // 注文確定待ち(childOrderIdが未発行の物は残したい)
                        if (orderInfo.ChildOrderId != null
                            || orderInfo.CheckCounter++ > 15)
                        {
                            orderBs.List.Remove(bsMap[childId]);
                            bsMap.Remove(childId);
                        }
                    }
                    // タイミングが悪いと、orderBsだけ残る場合がある
                    // Lockを増やすより、上書きした方がコストがかからない
                    if (bsMap.Count() == 0) orderBs.Clear();
                }
            }
            OrderCheckTimer.Start();
            lock (orderListLock) orderTimerLockFlg = false;
        }

        public void AddOrderInfo(string orderType,
                string orderDateTime,
                string side,
                decimal price,
                decimal size,
                string childOrderAcceptanceId)
        {
            var info = new OrderInfo(orderType, Util.FormatDateIsoToLocal(orderDateTime, Util.DATETIME_FORMAT_MDHMS), side, price, size, childOrderAcceptanceId);
            lock (bsMap)
            {
                bsMap[childOrderAcceptanceId] = info;
                orderBs.Add(info);
            }
        }

        private async void OrderGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView grid = (DataGridView)sender;
            if (grid.Columns[e.ColumnIndex].Name == "Cancel")
            {
                OrderCheckTimer.Stop();
                SetCancelResult("Waiting");
                var id = grid["ChildOrderAcceptanceId", e.RowIndex].Value.ToString();
                var result = await BitFlyerApiModel.CancelChildOrder(id);
                SetCancelResult(result ? "SUCCESS" : "FAILED");
                
                // 成功時、リスト更新を呼んでおく
                if (result) OrderGridView_Timer(null, null);
                OrderCheckTimer.Start();
            }
        }

        /**
         * キャンセル成否表示タイマー実行
         **/
        private void SetCancelResult(string text)
        {
            CancelResultValueLabel.Text = text;
            var Timer = CancelResultTimer;
            Timer.Start();
            Timer.Tick += (semder, e) => {
                CancelResultValueLabel.Text = "";
                ((System.Windows.Forms.Timer)semder).Stop();
            };
        }

        private async void PositionGridView_Timer(object sender, EventArgs e)
        {
            lock (positionListLock)
            {
                if (positionTimerLockFlg) return;
                positionTimerLockFlg = true;
            }
            var list = await BitFlyerApiModel.GetPositionList();
            var ltp = BitFlyerApiModel.getLastFxLtp();
            if (list != null)
            {
                decimal wAvePrice = 0, sizeSum = 0, pnlSum = 0, collateralSum = 0;
                string side = "";
                list.ForEach(row =>
                {
                    side = row.side;
                    // ltpが取得できていたら値幅を計算
                    if (ltp > 0) row.PriceBand = (side == BitFlyerApiModel.SIDE_BUY ? ltp - row.price : row.price - ltp);
                    wAvePrice += row.price * row.size;
                    sizeSum += row.size;
                    pnlSum += row.pnl;
                    collateralSum += row.require_collateral;

                    // 既にGridに追加されていれば上書きする
                    var index = positionBs.List.IndexOf(row);
                    if (index >= 0)
                    {
                        positionBs.List[index] = row;
                    }
                    else
                    {
                        positionBs.Add(row);
                    }
                });

                if (list.Count == 0)
                {
                    positionBs.Clear();
                    positionSumBs.Clear();
                } else {
                    wAvePrice = (wAvePrice / sizeSum);
                    var info = new PositionSummaryInfo(
                        wAvePrice,
                        sizeSum,
                        pnlSum,
                        collateralSum,
                        (ltp > 0 && wAvePrice > 0 ? (side == BitFlyerApiModel.SIDE_BUY ? ltp - wAvePrice : wAvePrice - ltp) : 0)
                    );
                    if (positionSumBs.Count == 0) positionSumBs.Add(info);
                    else positionSumBs.List[0] = info;
                }
            }
            lock (positionListLock) positionTimerLockFlg = false;
        }

        public class PositionSummaryInfo
        {
            public decimal wAvePrice { get; set; }
            public decimal sizeSum { get; set;}
            public decimal pnlSum  { get; set;}
            public decimal collateralSum { get; set; }
            public decimal priceBand {get;set;}

            public PositionSummaryInfo() { }
            public PositionSummaryInfo(decimal wAvePrice, decimal sizeSum, decimal pnlSum, decimal collateralSum, decimal priceBand)
            {
                this.wAvePrice = wAvePrice;
                this.sizeSum = sizeSum;
                this.pnlSum = pnlSum;
                this.collateralSum = collateralSum;
                this.priceBand = priceBand;
            }
        }
        
        /**
         * DataGridView用
         **/
        public class OrderInfo
        {
            public OrderInfo(
                string orderType,
                string orderDateTime, 
                string side,
                decimal orderPrice,
                decimal orderSize,
                string childOrderAcceptanceId)
            {
                OrderType = orderType;
                OrderDateTime = orderDateTime;
                Side = side;
                OrderPrice = orderPrice;
                OrderSize = orderSize;
                ChildOrderAcceptanceId = childOrderAcceptanceId;
            }
            public OrderInfo() { }

            public string OrderType { get; set; }
            public string OrderDateTime { get; set; }
            public string OrderAcceptTime { get; set; }
            public string Side { get; set; }
            public string ElapsedTime { get; set; }
            public string ExpireDate { get; set; }
            public decimal OrderPrice { get; set; }
            public decimal OrderSize { get; set; }
            public decimal RemainingSize { get; set; }
            public decimal AveragePrice { get; set; }
            public string Cancel { get; set; }
            public string ChildOrderAcceptanceId { get; set; }
            public string ChildOrderId { get; set; }
            public int CheckCounter { get; set; }

            public override bool Equals(object obj)
            {
                if (obj == null || this.GetType() != obj.GetType()) return false;

                OrderInfo c = (OrderInfo)obj;
                if (ChildOrderAcceptanceId == c.ChildOrderAcceptanceId
                    && ChildOrderId == c.ChildOrderId
                    && RemainingSize == c.RemainingSize
                    && AveragePrice == c.AveragePrice) return true;
                return false;
            }

            int hashCode = 0;
            public override int GetHashCode()
            {
                int hash = 0;
                if (hashCode > 0)
                {
                    hash = hashCode;
                }
                else
                {
                    hash =
                    (ChildOrderAcceptanceId.GetHashCode() * 2)
                    + ((ChildOrderId == null ? 1 : ChildOrderId.GetHashCode()) * 3)
                    + (RemainingSize.GetHashCode() * 5)
                    + (AveragePrice.GetHashCode() * 7);
                }
                return hash;
            }
        }

        private void OrderListCloseButton_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private async void CancelAllButton_Click(object sender, EventArgs e)
        {
            OrderCheckTimer.Stop();
            SetCancelResult("Waiting");
            var result = await BitFlyerApiModel.CancelAllChildOrder();
            SetCancelResult(result ? "SUCCESS" : "FAILED");
            if (result) OrderGridView_Timer(null, null);
            OrderCheckTimer.Start();
        }

        public void StartTimer() => OrderCheckTimer.Start();

        private void PositionGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void StopTimer() => OrderCheckTimer.Stop();
    }
}
