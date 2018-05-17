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

    public partial class SettingsForm : AppForm
    {
        private static SettingsForm _instance;
        public static SettingsForm Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                {
                    _instance = new SettingsForm();
                }
                return _instance;
            }
        }
        public SettingsForm() : base ()
        {
            InitializeComponent();
            ApplyMouseMove<Label>(this);
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            ActiveControl = APIInfoPanel;
            APIKeyInputBox.Text = Properties.Settings.Default.API_KEY;
            APISecretInputBox.Text = Properties.Settings.Default.API_SECRET;
            SaftyLimitInputBox.Value = Properties.Settings.Default.DEFAULT_ORDER_SAFTY_LIMIT;
            SizeInputBox.Value = Properties.Settings.Default.DEFAULT_ORDER_SIZE;
            SetOrderExpire(Properties.Settings.Default.DEFAULT_EXPIRE_TIME);
            TimeInForceBox.SelectedItem = Properties.Settings.Default.DEFAULT_TIME_IN_FORCE;
            OrderRetryInputBox.Value = Properties.Settings.Default.DEFAULT_ORDER_RETRY;
            InputPriceFixBox.ValueMember = Properties.Settings.Default.DEFAULT_INPUT_PRICE_FIX;
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.API_KEY = APIKeyInputBox.Text;
            Properties.Settings.Default.API_SECRET = APISecretInputBox.Text;
            Properties.Settings.Default.DEFAULT_ORDER_SAFTY_LIMIT = SaftyLimitInputBox.Value;
            Properties.Settings.Default.DEFAULT_ORDER_SIZE = SizeInputBox.Value;
            Properties.Settings.Default.DEFAULT_EXPIRE_TIME = GetOrderExpireValue();
            Properties.Settings.Default.DEFAULT_TIME_IN_FORCE = TimeInForceBox.SelectedItem.ToString();
            Properties.Settings.Default.DEFAULT_ORDER_RETRY = OrderRetryInputBox.Value;
            Properties.Settings.Default.DEFAULT_INPUT_PRICE_FIX = InputPriceFixBox.SelectedItem.ToString();
            Properties.Settings.Default.Save();
            Close();
        }

        private void SettingCloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

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
            switch(expire)
            {
                case 1: OrderExpire1.Checked = true; break;
                case 5: OrderExpire5.Checked = true; break;
                case 30: OrderExpire30.Checked = true; break;
                case 60: OrderExpire60.Checked = true; break;
                default: OrderExpire1.Checked = true; break;
            }
        }

        /**
         * ComboBoxの表示名称マッピング
         **/
        private void TimeInForceBox_format(object sender, ListControlConvertEventArgs e)
        {
            switch(e.ListItem)
            {
                case BitFlyerApiModel.TIME_IN_FORCE_GTC : e.Value = "Good Til Cancelled"; break;
                case BitFlyerApiModel.TIME_IN_FORCE_IOC : e.Value = "Immediate or Cancel"; break;
                case BitFlyerApiModel.TIME_IN_FORCE_FOK : e.Value = "Fill or Kill"; break;
            }
        }

    }
}
