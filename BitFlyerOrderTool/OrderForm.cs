using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web.UI.WebControls;
using System.Timers;

namespace BitFlyerOrderApp
{
    public partial class OrderForm : AppForm
    {
        static private decimal OrderSaftyLimit { get { return BitFlyerOrderApp.Properties.Settings.Default.DEFAULT_ORDER_SAFTY_LIMIT; } }
        static private string FixInputPrice { get { return BitFlyerOrderApp.Properties.Settings.Default.DEFAULT_INPUT_PRICE_FIX; } }

        public OrderForm() : base()
        {
            InitializeComponent();
            // 追加画面移動設定
            ApplyMouseMove<System.Windows.Forms.Label>(this);
            ApplyMouseMove<System.Windows.Forms.Panel>(this);
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            // 起動時に最新価格をセット
            LoadPriceButton_Click(null, null);
            // プロパティを反映
            SizeInputBox.Value = Properties.Settings.Default.DEFAULT_ORDER_SIZE;
            SetOrderExpire(Properties.Settings.Default.DEFAULT_EXPIRE_TIME);
        }

        /**
         * 入札処理を実行
         **/
        private async void OrderButton_Click(object sender, EventArgs e)
        {
            var button = (System.Windows.Forms.Button)sender;
            var inputPrice = PriceInputBox.Value;
            var ltp = BitFlyerApiModel.getLastFxLtp();
            var side = (button.Name == "BuyButton") ? BitFlyerApiModel.SIDE_BUY : BitFlyerApiModel.SIDE_SELL;
            if (FixInputPrice == "ExceptPopularPrice")
            {
                // 50で割り切れる数字はNG
                if(inputPrice % 50 == 0)
                {
                    inputPrice = inputPrice + (side == BitFlyerApiModel.SIDE_BUY ? 3 : -3);
                }
                // 1は避ける 99も避ける
                if(inputPrice % 10 == 1 || inputPrice % 100 == 99)
                {
                    inputPrice = inputPrice + (side == BitFlyerApiModel.SIDE_BUY ? 3 : -3);
                }
            }

            if (ltp < 0)
            {
                SetOrderResult("GetLtpError");
                return;
            } else
            {
                // 不利な方向のミス注文を防ぎたい
                // 価格よりN%以上高い買い注文を拒否
                // 価格よりN%以上低い売り注文を拒否
                if(side == BitFlyerApiModel.SIDE_BUY)
                {
                    if(ltp * (OrderSaftyLimit / 100m + 1) < inputPrice)
                    {
                        SetOrderResult("SaftyLimit");
                        return;
                    }
                }
                else
                {
                    if (ltp * (1 - (OrderSaftyLimit / 100m)) > inputPrice)
                    {
                        SetOrderResult("SaftyLimit");
                        return;
                    }
                }
            }
            
            if (button.Enabled)
            {
                var listForm = OrderListForm.Instance;

                SetOrderResult("Waiting");
                
                button.Enabled = false;

                var result = await BitFlyerApiModel.Order(side, inputPrice, SizeInputBox.Value, GetOrderExpireValue());
                var acceptId = result;
                bool isSuccess = acceptId != null && acceptId.Length > 0 ? true : false;

                if(isSuccess) {
                    OrderListForm.Instance.AddOrderInfo(
                        BitFlyerApiModel.CHILD_ORDER_TYPE_LIMIT
                        , DateTime.UtcNow.ToString()
                        , side
                        , inputPrice
                        , SizeInputBox.Value
                        , acceptId);
                }
                SetOrderResult(isSuccess ? "SUCCESS" : "ERROR");
                button.Enabled = true;
            }
        }

        /**
         * 最新価格を入札価格に設定
         **/
        private async void LoadPriceButton_Click(object sender, EventArgs e)
        {
            var price = await BitFlyerApiModel.GetFxLastPrice();
            if (price > 0) {
                 PriceInputBox.Value = price;
            }
        }

        /**
         * 価格乖離 + SFD表示
         */
        private async void UpdateInfoAsync(object sender, EventArgs e)
        {
            var statusInfo = await BitFlyerApiModel.GetServerStatus();
            if (statusInfo != null)
            {
                ServerStatusValueLabel.Text = statusInfo.health;
            }

            var sepalationPriceRate = await BitFlyerApiModel.GetPriceSepalationRate();
            if (sepalationPriceRate > 0)
            {
                PriceSepalationValueLabel.Text = sepalationPriceRate + "%";
                SFDRateLabel.Text =
                    (sepalationPriceRate >= 20 ? " (SFD:2.00%)"
                    : sepalationPriceRate >= 15 ? " (SFD:1.00%)"
                    : sepalationPriceRate >= 10 ? " (SFD:0.50%)"
                    : sepalationPriceRate >= 5 ? " (SFD:0.25%)"
                    : "");
            }

            // Bitflyerは現在価格の50％未満200%以上の金額はエラーになる
            // 入力制限してしまった方が楽なので制限する
            var ltp = BitFlyerApiModel.getLastFxLtp();
            if (ltp > 0) {
                PriceInputBox.Minimum = ltp * 0.5m;
                PriceInputBox.Maximum = ltp * 2;
            }
        }

        /**
         * 予想価格表示
         **/
        private void UpdateCalcPrice(object sender, EventArgs e) => CalcPriceValue.Text = String.Format("{0:#,0} 円", Math.Round(PriceInputBox.Value * SizeInputBox.Value));


        private int GetOrderExpireValue()
        {
            return
                OrderExpire1.Checked ? 1
                : OrderExpire5.Checked ? 5
                : OrderExpire30.Checked ? 30
                : OrderExpire60.Checked ? 60
                : 1;
        }
        private void SetOrderExpire(int expire)
        {
            switch (expire)
            {
                case 1: OrderExpire1.Checked = true; break;
                case 5: OrderExpire5.Checked = true; break;
                case 30: OrderExpire30.Checked = true; break;
                case 60: OrderExpire60.Checked = true; break;
                default: OrderExpire1.Checked = true; break;
            }
        }
        
        /**
         * オーダー一覧表示
         **/
        private void OrderListButton_Click(object sender, EventArgs e)
        {
            OrderListForm form = OrderListForm.Instance;
            if (form.IsOpen()) { form.Hide(); }
            else { form.Show(); }
        }

        /**
         * 設定画面表示
         **/
        private void SettingButton_Click(object sender, EventArgs e)
        {
            SettingsForm settingForm = SettingsForm.Instance;
            if (settingForm.IsOpen()) { settingForm.Close(); }
            else { settingForm.Show(); }
        }

        /**
         * アプリ終了ボタン
         */
        private void AppCloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        /**
         * オーダー時成否表示タイマー実行
         **/
        private void SetOrderResult(string text)
        {
            OrderResultValueLabel.Text = text;
            var Timer = OrderResultTimer;
            Timer.Start();
            Timer.Tick += (semder, e) =>
            {
                OrderResultValueLabel.Text = "";
                ((System.Windows.Forms.Timer)semder).Stop();
            };
        }
    }
}