namespace BitFlyerOrderApp
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.APIKeyLabel = new System.Windows.Forms.Label();
            this.APIKeyInputBox = new System.Windows.Forms.TextBox();
            this.APISecretLabel = new System.Windows.Forms.Label();
            this.APISecretInputBox = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.APIInfoPanel = new System.Windows.Forms.Panel();
            this.OrderExpire60 = new System.Windows.Forms.RadioButton();
            this.OrderExpire30 = new System.Windows.Forms.RadioButton();
            this.OrderExpire5 = new System.Windows.Forms.RadioButton();
            this.OrderExpire1 = new System.Windows.Forms.RadioButton();
            this.OrderExpireLabel = new System.Windows.Forms.Label();
            this.OrderExpirePanel = new System.Windows.Forms.Panel();
            this.SizeLabel = new System.Windows.Forms.Label();
            this.SizeInputBox = new System.Windows.Forms.NumericUpDown();
            this.TimeInForceLabel = new System.Windows.Forms.Label();
            this.TimeInForceBox = new System.Windows.Forms.ComboBox();
            this.RetryCountLabel = new System.Windows.Forms.Label();
            this.OrderRetryInputBox = new System.Windows.Forms.NumericUpDown();
            this.SettingCloseButton = new System.Windows.Forms.Button();
            this.OrderSaftyLabel = new System.Windows.Forms.Label();
            this.SaftyLimitInputBox = new System.Windows.Forms.NumericUpDown();
            this.OrderSaftySuffixLabel = new System.Windows.Forms.Label();
            this.InputPriceFixBox = new System.Windows.Forms.ComboBox();
            this.InputPriceFixLabel = new System.Windows.Forms.Label();
            this.OrderExpirePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SizeInputBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderRetryInputBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaftyLimitInputBox)).BeginInit();
            this.SuspendLayout();
            // 
            // APIKeyLabel
            // 
            this.APIKeyLabel.AutoSize = true;
            this.APIKeyLabel.ForeColor = System.Drawing.Color.White;
            this.APIKeyLabel.Location = new System.Drawing.Point(12, 35);
            this.APIKeyLabel.Name = "APIKeyLabel";
            this.APIKeyLabel.Size = new System.Drawing.Size(61, 20);
            this.APIKeyLabel.TabIndex = 99;
            this.APIKeyLabel.Text = "API-Key";
            // 
            // APIKeyInputBox
            // 
            this.APIKeyInputBox.BackColor = System.Drawing.Color.DarkGray;
            this.APIKeyInputBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.APIKeyInputBox.CausesValidation = false;
            this.APIKeyInputBox.Font = new System.Drawing.Font("メイリオ", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.APIKeyInputBox.ForeColor = System.Drawing.Color.White;
            this.APIKeyInputBox.Location = new System.Drawing.Point(101, 37);
            this.APIKeyInputBox.Name = "APIKeyInputBox";
            this.APIKeyInputBox.Size = new System.Drawing.Size(202, 17);
            this.APIKeyInputBox.TabIndex = 1;
            // 
            // APISecretLabel
            // 
            this.APISecretLabel.AutoSize = true;
            this.APISecretLabel.ForeColor = System.Drawing.Color.White;
            this.APISecretLabel.Location = new System.Drawing.Point(12, 58);
            this.APISecretLabel.Name = "APISecretLabel";
            this.APISecretLabel.Size = new System.Drawing.Size(78, 20);
            this.APISecretLabel.TabIndex = 99;
            this.APISecretLabel.Text = "API-Secret";
            // 
            // APISecretInputBox
            // 
            this.APISecretInputBox.BackColor = System.Drawing.Color.DarkGray;
            this.APISecretInputBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.APISecretInputBox.CausesValidation = false;
            this.APISecretInputBox.Font = new System.Drawing.Font("メイリオ", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.APISecretInputBox.ForeColor = System.Drawing.Color.White;
            this.APISecretInputBox.Location = new System.Drawing.Point(101, 61);
            this.APISecretInputBox.Name = "APISecretInputBox";
            this.APISecretInputBox.Size = new System.Drawing.Size(202, 17);
            this.APISecretInputBox.TabIndex = 2;
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SaveButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SaveButton.BackgroundImage")));
            this.SaveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.SaveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveButton.FlatAppearance.BorderSize = 0;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SaveButton.Location = new System.Drawing.Point(296, 3);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(24, 24);
            this.SaveButton.TabIndex = 50;
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // APIInfoPanel
            // 
            this.APIInfoPanel.Location = new System.Drawing.Point(13, 35);
            this.APIInfoPanel.Name = "APIInfoPanel";
            this.APIInfoPanel.Size = new System.Drawing.Size(300, 43);
            this.APIInfoPanel.TabIndex = 99;
            // 
            // OrderExpire60
            // 
            this.OrderExpire60.AutoSize = true;
            this.OrderExpire60.ForeColor = System.Drawing.Color.White;
            this.OrderExpire60.Location = new System.Drawing.Point(195, 195);
            this.OrderExpire60.Name = "OrderExpire60";
            this.OrderExpire60.Size = new System.Drawing.Size(56, 24);
            this.OrderExpire60.TabIndex = 7;
            this.OrderExpire60.Text = "60分";
            this.OrderExpire60.UseVisualStyleBackColor = true;
            // 
            // OrderExpire30
            // 
            this.OrderExpire30.AutoSize = true;
            this.OrderExpire30.ForeColor = System.Drawing.Color.White;
            this.OrderExpire30.Location = new System.Drawing.Point(133, 195);
            this.OrderExpire30.Name = "OrderExpire30";
            this.OrderExpire30.Size = new System.Drawing.Size(56, 24);
            this.OrderExpire30.TabIndex = 6;
            this.OrderExpire30.Text = "30分";
            this.OrderExpire30.UseVisualStyleBackColor = true;
            // 
            // OrderExpire5
            // 
            this.OrderExpire5.AutoSize = true;
            this.OrderExpire5.ForeColor = System.Drawing.Color.White;
            this.OrderExpire5.Location = new System.Drawing.Point(79, 195);
            this.OrderExpire5.Name = "OrderExpire5";
            this.OrderExpire5.Size = new System.Drawing.Size(48, 24);
            this.OrderExpire5.TabIndex = 5;
            this.OrderExpire5.Text = "5分";
            this.OrderExpire5.UseVisualStyleBackColor = true;
            // 
            // OrderExpire1
            // 
            this.OrderExpire1.AutoSize = true;
            this.OrderExpire1.Checked = true;
            this.OrderExpire1.ForeColor = System.Drawing.Color.White;
            this.OrderExpire1.Location = new System.Drawing.Point(25, 195);
            this.OrderExpire1.Name = "OrderExpire1";
            this.OrderExpire1.Size = new System.Drawing.Size(48, 24);
            this.OrderExpire1.TabIndex = 4;
            this.OrderExpire1.TabStop = true;
            this.OrderExpire1.Text = "1分";
            this.OrderExpire1.UseVisualStyleBackColor = true;
            // 
            // OrderExpireLabel
            // 
            this.OrderExpireLabel.AutoSize = true;
            this.OrderExpireLabel.ForeColor = System.Drawing.Color.White;
            this.OrderExpireLabel.Location = new System.Drawing.Point(12, -1);
            this.OrderExpireLabel.Name = "OrderExpireLabel";
            this.OrderExpireLabel.Size = new System.Drawing.Size(87, 20);
            this.OrderExpireLabel.TabIndex = 99;
            this.OrderExpireLabel.Text = "注文有効期間";
            // 
            // OrderExpirePanel
            // 
            this.OrderExpirePanel.Controls.Add(this.OrderExpireLabel);
            this.OrderExpirePanel.Location = new System.Drawing.Point(0, 173);
            this.OrderExpirePanel.Name = "OrderExpirePanel";
            this.OrderExpirePanel.Size = new System.Drawing.Size(270, 57);
            this.OrderExpirePanel.TabIndex = 99;
            // 
            // SizeLabel
            // 
            this.SizeLabel.AutoSize = true;
            this.SizeLabel.ForeColor = System.Drawing.Color.White;
            this.SizeLabel.Location = new System.Drawing.Point(12, 137);
            this.SizeLabel.Name = "SizeLabel";
            this.SizeLabel.Size = new System.Drawing.Size(35, 20);
            this.SizeLabel.TabIndex = 99;
            this.SizeLabel.Text = "数量";
            // 
            // SizeInputBox
            // 
            this.SizeInputBox.BackColor = System.Drawing.Color.DarkGray;
            this.SizeInputBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SizeInputBox.DecimalPlaces = 3;
            this.SizeInputBox.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.SizeInputBox.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.SizeInputBox.Location = new System.Drawing.Point(101, 134);
            this.SizeInputBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.SizeInputBox.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.SizeInputBox.Name = "SizeInputBox";
            this.SizeInputBox.Size = new System.Drawing.Size(86, 23);
            this.SizeInputBox.TabIndex = 3;
            this.SizeInputBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.SizeInputBox.ThousandsSeparator = true;
            // 
            // TimeInForceLabel
            // 
            this.TimeInForceLabel.AutoSize = true;
            this.TimeInForceLabel.ForeColor = System.Drawing.Color.White;
            this.TimeInForceLabel.Location = new System.Drawing.Point(12, 250);
            this.TimeInForceLabel.Name = "TimeInForceLabel";
            this.TimeInForceLabel.Size = new System.Drawing.Size(83, 20);
            this.TimeInForceLabel.TabIndex = 99;
            this.TimeInForceLabel.Text = "TimeInFoce";
            // 
            // TimeInForceBox
            // 
            this.TimeInForceBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.TimeInForceBox.BackColor = System.Drawing.Color.DarkGray;
            this.TimeInForceBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TimeInForceBox.ForeColor = System.Drawing.Color.White;
            this.TimeInForceBox.FormattingEnabled = true;
            this.TimeInForceBox.ItemHeight = 20;
            this.TimeInForceBox.Items.AddRange(new object[] {
            "GTC",
            "IOC",
            "FOK"});
            this.TimeInForceBox.Location = new System.Drawing.Point(101, 247);
            this.TimeInForceBox.Name = "TimeInForceBox";
            this.TimeInForceBox.Size = new System.Drawing.Size(169, 28);
            this.TimeInForceBox.TabIndex = 8;
            this.TimeInForceBox.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.TimeInForceBox_format);
            // 
            // RetryCountLabel
            // 
            this.RetryCountLabel.AutoSize = true;
            this.RetryCountLabel.ForeColor = System.Drawing.Color.White;
            this.RetryCountLabel.Location = new System.Drawing.Point(12, 292);
            this.RetryCountLabel.Name = "RetryCountLabel";
            this.RetryCountLabel.Size = new System.Drawing.Size(113, 20);
            this.RetryCountLabel.TabIndex = 99;
            this.RetryCountLabel.Text = "注文リトライ回数";
            // 
            // OrderRetryInputBox
            // 
            this.OrderRetryInputBox.BackColor = System.Drawing.Color.DarkGray;
            this.OrderRetryInputBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OrderRetryInputBox.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.OrderRetryInputBox.Location = new System.Drawing.Point(184, 292);
            this.OrderRetryInputBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.OrderRetryInputBox.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.OrderRetryInputBox.Name = "OrderRetryInputBox";
            this.OrderRetryInputBox.Size = new System.Drawing.Size(86, 23);
            this.OrderRetryInputBox.TabIndex = 9;
            this.OrderRetryInputBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.OrderRetryInputBox.ThousandsSeparator = true;
            // 
            // SettingCloseButton
            // 
            this.SettingCloseButton.BackgroundImage = global::BitFlyerOrderApp.Properties.Resources.close_16x16;
            this.SettingCloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.SettingCloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SettingCloseButton.FlatAppearance.BorderSize = 0;
            this.SettingCloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingCloseButton.ForeColor = System.Drawing.Color.Firebrick;
            this.SettingCloseButton.Location = new System.Drawing.Point(0, 0);
            this.SettingCloseButton.Name = "SettingCloseButton";
            this.SettingCloseButton.Size = new System.Drawing.Size(28, 28);
            this.SettingCloseButton.TabIndex = 104;
            this.SettingCloseButton.UseVisualStyleBackColor = true;
            this.SettingCloseButton.Click += new System.EventHandler(this.SettingCloseButton_Click);
            // 
            // OrderSaftyLabel
            // 
            this.OrderSaftyLabel.AutoSize = true;
            this.OrderSaftyLabel.ForeColor = System.Drawing.Color.White;
            this.OrderSaftyLabel.Location = new System.Drawing.Point(12, 104);
            this.OrderSaftyLabel.Name = "OrderSaftyLabel";
            this.OrderSaftyLabel.Size = new System.Drawing.Size(61, 20);
            this.OrderSaftyLabel.TabIndex = 106;
            this.OrderSaftyLabel.Text = "注文制限";
            // 
            // SaftyLimitInputBox
            // 
            this.SaftyLimitInputBox.BackColor = System.Drawing.Color.DarkGray;
            this.SaftyLimitInputBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SaftyLimitInputBox.DecimalPlaces = 2;
            this.SaftyLimitInputBox.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.SaftyLimitInputBox.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.SaftyLimitInputBox.Location = new System.Drawing.Point(101, 101);
            this.SaftyLimitInputBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.SaftyLimitInputBox.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.SaftyLimitInputBox.Name = "SaftyLimitInputBox";
            this.SaftyLimitInputBox.Size = new System.Drawing.Size(86, 23);
            this.SaftyLimitInputBox.TabIndex = 105;
            this.SaftyLimitInputBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.SaftyLimitInputBox.ThousandsSeparator = true;
            // 
            // OrderSaftySuffixLabel
            // 
            this.OrderSaftySuffixLabel.AutoSize = true;
            this.OrderSaftySuffixLabel.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.OrderSaftySuffixLabel.ForeColor = System.Drawing.Color.White;
            this.OrderSaftySuffixLabel.Location = new System.Drawing.Point(191, 101);
            this.OrderSaftySuffixLabel.Name = "OrderSaftySuffixLabel";
            this.OrderSaftySuffixLabel.Size = new System.Drawing.Size(25, 23);
            this.OrderSaftySuffixLabel.TabIndex = 107;
            this.OrderSaftySuffixLabel.Text = "%";
            // 
            // InputPriceFixBox
            // 
            this.InputPriceFixBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.InputPriceFixBox.BackColor = System.Drawing.Color.DarkGray;
            this.InputPriceFixBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InputPriceFixBox.ForeColor = System.Drawing.Color.White;
            this.InputPriceFixBox.FormattingEnabled = true;
            this.InputPriceFixBox.ItemHeight = 20;
            this.InputPriceFixBox.Items.AddRange(new object[] {
            "NONE",
            "ExceptPopularPrice"});
            this.InputPriceFixBox.Location = new System.Drawing.Point(101, 323);
            this.InputPriceFixBox.Name = "InputPriceFixBox";
            this.InputPriceFixBox.Size = new System.Drawing.Size(169, 28);
            this.InputPriceFixBox.TabIndex = 108;
            // 
            // InputPriceFixLabel
            // 
            this.InputPriceFixLabel.AutoSize = true;
            this.InputPriceFixLabel.ForeColor = System.Drawing.Color.White;
            this.InputPriceFixLabel.Location = new System.Drawing.Point(12, 326);
            this.InputPriceFixLabel.Name = "InputPriceFixLabel";
            this.InputPriceFixLabel.Size = new System.Drawing.Size(87, 20);
            this.InputPriceFixLabel.TabIndex = 109;
            this.InputPriceFixLabel.Text = "入札価格補正";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(325, 360);
            this.Controls.Add(this.InputPriceFixBox);
            this.Controls.Add(this.InputPriceFixLabel);
            this.Controls.Add(this.OrderSaftySuffixLabel);
            this.Controls.Add(this.OrderSaftyLabel);
            this.Controls.Add(this.SaftyLimitInputBox);
            this.Controls.Add(this.SettingCloseButton);
            this.Controls.Add(this.OrderRetryInputBox);
            this.Controls.Add(this.RetryCountLabel);
            this.Controls.Add(this.TimeInForceBox);
            this.Controls.Add(this.TimeInForceLabel);
            this.Controls.Add(this.SizeLabel);
            this.Controls.Add(this.SizeInputBox);
            this.Controls.Add(this.OrderExpire60);
            this.Controls.Add(this.OrderExpire30);
            this.Controls.Add(this.OrderExpire5);
            this.Controls.Add(this.OrderExpire1);
            this.Controls.Add(this.OrderExpirePanel);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.APISecretInputBox);
            this.Controls.Add(this.APIKeyInputBox);
            this.Controls.Add(this.APISecretLabel);
            this.Controls.Add(this.APIKeyLabel);
            this.Controls.Add(this.APIInfoPanel);
            this.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "SettingsForm";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.OrderExpirePanel.ResumeLayout(false);
            this.OrderExpirePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SizeInputBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderRetryInputBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaftyLimitInputBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label APIKeyLabel;
        private System.Windows.Forms.TextBox APIKeyInputBox;
        private System.Windows.Forms.Label APISecretLabel;
        private System.Windows.Forms.TextBox APISecretInputBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Panel APIInfoPanel;
        private System.Windows.Forms.RadioButton OrderExpire60;
        private System.Windows.Forms.RadioButton OrderExpire30;
        private System.Windows.Forms.RadioButton OrderExpire5;
        private System.Windows.Forms.RadioButton OrderExpire1;
        private System.Windows.Forms.Label OrderExpireLabel;
        private System.Windows.Forms.Panel OrderExpirePanel;
        private System.Windows.Forms.Label SizeLabel;
        private System.Windows.Forms.NumericUpDown SizeInputBox;
        private System.Windows.Forms.Label TimeInForceLabel;
        private System.Windows.Forms.ComboBox TimeInForceBox;
        private System.Windows.Forms.Label RetryCountLabel;
        private System.Windows.Forms.NumericUpDown OrderRetryInputBox;
        private System.Windows.Forms.Button SettingCloseButton;
        private System.Windows.Forms.Label OrderSaftyLabel;
        private System.Windows.Forms.NumericUpDown SaftyLimitInputBox;
        private System.Windows.Forms.Label OrderSaftySuffixLabel;
        private System.Windows.Forms.ComboBox InputPriceFixBox;
        private System.Windows.Forms.Label InputPriceFixLabel;
    }
}