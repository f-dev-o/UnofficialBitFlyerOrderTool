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
        private BindingSource bs;
        public OrderListForm() : base()
        {
            InitializeComponent();

            ApplyMouseMove<System.Windows.Forms.Label>(this);
            ApplyMouseMove<DataGridView>(this);

            bs = new BindingSource
            {
                AllowNew = true,
                DataSource = new BindingList<OrderInfo>()
            };
            
            OrderGridView.AutoGenerateColumns = false;
            OrderGridView.DataSource = bs;            
        }

        private void OrderListForm_Load(object sender, EventArgs e)
        {
        }

        private async void OrderGridView_Timer(object sender, EventArgs e)
        {
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
                        OrderAcceptTime = formatDateIsoToLocal(info.child_order_date, "MM/dd HH:mm:ss"),
                        ExpireDate = formatDateIsoToLocal(info.expire_date, "MM/dd HH:mm:ss"),
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

                    if (bsMap.ContainsKey(info.child_order_acceptance_id))
                    {
                        // 既にGridに追加されていれば上書きする
                        // 未承認データの場合は、その項目を追加してから上書きする
                        var index = bs.List.IndexOf(bsMap[info.child_order_acceptance_id]);
                        if (!orderInfo.Equals(bs.List[index]))
                        {
                            bs.List[index] = orderInfo;
                            bsMap[info.child_order_acceptance_id] = orderInfo;
                        }
                    }
                    else
                    {
                        // bsMapとGridに追加する
                        bs.Add(orderInfo);
                        bsMap.Add(info.child_order_acceptance_id, orderInfo);
                    }
                });

                // 保有済みのデータをチェックし古いデータを取り除く
                foreach (var childId in bsMap.Keys.Reverse())
                {
                    // 最新情報にあるのでスルー
                    if (orderRecodeSet.Contains(childId)) continue;

                    var orderInfo = bsMap[childId];
                    // 今回の確認リストにないが、既に承認済みのレコードは消去
                    // 注文確定待ち(childOrderIdが未発行の物は残したい)
                    if (orderInfo.OrderDateTime != "") {
                        bs.List.Remove(bsMap[childId]);
                        bsMap.Remove(childId);
                    }
                }
            
            }
        }

        public void AddOrderInfo(string orderType,
                string orderDateTime,
                string serverResponsedTime,
                string side,
                decimal size,
                string childOrderAcceptanceId)
        {
            bs.Add(new OrderInfo(orderType, orderDateTime, serverResponsedTime, side, size, childOrderAcceptanceId));
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


        /**
         * LocalTime表示への変換
         **/
        public string formatDateIsoToLocal(string datetime, string format)
        {
            var srcDateTime = DateTime.Parse(datetime, null, System.Globalization.DateTimeStyles.RoundtripKind);
            return srcDateTime.ToLocalTime().ToString(format);
        }


        /**
         * DataGridView用
         **/
#pragma warning disable CS0659 // 型は Object.Equals(object o) をオーバーライドしますが、Object.GetHashCode() をオーバーライドしません
        public class OrderInfo
#pragma warning restore CS0659 // 型は Object.Equals(object o) をオーバーライドしますが、Object.GetHashCode() をオーバーライドしません
        {
            public OrderInfo(
                string orderType,
                string orderDateTime, 
                string serverResponsedTime, 
                string side, 
                decimal orderSize,
                string childOrderAcceptanceId)
            {
                OrderType = orderType;
                OrderDateTime = orderDateTime;
                ServerResponsedTime = serverResponsedTime;
                Side = side;
                OrderSize = orderSize;
                ChildOrderAcceptanceId = childOrderAcceptanceId;
            }
            public OrderInfo() { }

            public string OrderType { get; set; }
            public string OrderDateTime { get; set; }
            public string ServerResponsedTime { get; set; }
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
    }
}
