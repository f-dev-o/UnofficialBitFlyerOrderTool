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

        Dictionary<string, int> bsMap = new Dictionary<string, int>();
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
            var list = await BitFlyerApiModel.GetOrderList();
            if (list != null)
            {
                // TODO 新規追加と、存在しなくなったデータの除去に対応できていない
                // null以外の場合で結果が空の場合、child_id以外のデータが空のレコードを取り除く処理が必要
                list.ForEach(info =>
                {
                    var orderInfo = new OrderInfo()
                    {
                        //OrderDateTime
                        //ServerResponsedTime
                        //ElapsedTime
                        OrderType = info.child_order_type,
                        OrderAcceptTime = (DateTime.Parse(info.child_order_date, null, System.Globalization.DateTimeStyles.RoundtripKind)).ToString("MM/dd HH:mm:ss"),
                        ExpireDate = (DateTime.Parse(info.expire_date, null, System.Globalization.DateTimeStyles.RoundtripKind)).ToString("MM/dd HH:mm:ss"),
                        Side = info.side,
                        OrderPrice = info.price,
                        OrderSize = info.size,
                        RemainingSize = info.outstanding_size,
                        AveragePrice = info.average_price,
                        Canncel = "×",
                        ChildOrderId = info.child_order_id,
                    };
                    if (bsMap.ContainsKey(info.child_order_id))
                    {
                        bs.List[bsMap[info.child_order_id]] = orderInfo;
                    }
                    else
                    {
                        bsMap.Add(info.child_order_id, bs.Add(orderInfo));
                    }
                });
            }
        }

        public void AddOrderInfo(string orderType,
                string orderDateTime,
                string serverResponsedTime,
                string side,
                decimal size,
                string childOrderId)
        {
            bs.Add(new OrderInfo(orderType, orderDateTime, serverResponsedTime, side, size, childOrderId));
        }

        /**
         * DataGridView用
         **/
        public class OrderInfo
        {
            public OrderInfo(
                string orderType,
                string orderDateTime, 
                string serverResponsedTime, 
                string side, 
                decimal orderSize,
                string childOrderId)
            {
                OrderType = orderType;
                OrderDateTime = orderDateTime;
                ServerResponsedTime = serverResponsedTime;
                Side = side;
                OrderSize = orderSize;
                ChildOrderId = childOrderId;
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
            public string Canncel { get; set; }
            public string ChildOrderId { get; set; }
        }
    }
}
