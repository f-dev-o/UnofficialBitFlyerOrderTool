namespace BitFlyerOrderApp
{
    partial class OrderForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
            this.PriceInputBox = new System.Windows.Forms.NumericUpDown();
            this.SizeInputBox = new System.Windows.Forms.NumericUpDown();
            this.BuyButton = new System.Windows.Forms.Button();
            this.SellButton = new System.Windows.Forms.Button();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.SizeLabel = new System.Windows.Forms.Label();
            this.SFDTimer = new System.Windows.Forms.Timer(this.components);
            this.PriceSepalationLabel = new System.Windows.Forms.Label();
            this.PriceSepalationValueLabel = new System.Windows.Forms.Label();
            this.CalcPriceValue = new System.Windows.Forms.Label();
            this.CalcPriceLabel = new System.Windows.Forms.Label();
            this.OrderExpireLabel = new System.Windows.Forms.Label();
            this.OrderExpire1 = new System.Windows.Forms.RadioButton();
            this.OrderExpire5 = new System.Windows.Forms.RadioButton();
            this.OrderExpire30 = new System.Windows.Forms.RadioButton();
            this.OrderExpire60 = new System.Windows.Forms.RadioButton();
            this.OrderExpirePanel = new System.Windows.Forms.Panel();
            this.SFDRateLabel = new System.Windows.Forms.Label();
            this.ServerStatusValueLabel = new System.Windows.Forms.Label();
            this.ServerStatusLabel = new System.Windows.Forms.Label();
            this.AppCloseButton = new System.Windows.Forms.Button();
            this.OrderListButton = new System.Windows.Forms.Button();
            this.SettingButton = new System.Windows.Forms.Button();
            this.loadPriceButton = new System.Windows.Forms.Button();
            this.OrderResultValueLabel = new System.Windows.Forms.Label();
            this.OrderResultTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PriceInputBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SizeInputBox)).BeginInit();
            this.SuspendLayout();
            // 
            // PriceInputBox
            // 
            this.PriceInputBox.BackColor = System.Drawing.Color.IndianRed;
            this.PriceInputBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PriceInputBox.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.PriceInputBox.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.PriceInputBox.Location = new System.Drawing.Point(86, 36);
            this.PriceInputBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.PriceInputBox.Maximum = new decimal(new int[] {
            2000000,
            0,
            0,
            0});
            this.PriceInputBox.Name = "PriceInputBox";
            this.PriceInputBox.Size = new System.Drawing.Size(143, 23);
            this.PriceInputBox.TabIndex = 0;
            this.PriceInputBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.PriceInputBox.ThousandsSeparator = true;
            this.PriceInputBox.ValueChanged += new System.EventHandler(this.UpdateCalcPrice);
            // 
            // SizeInputBox
            // 
            this.SizeInputBox.BackColor = System.Drawing.Color.IndianRed;
            this.SizeInputBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SizeInputBox.DecimalPlaces = 3;
            this.SizeInputBox.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.SizeInputBox.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.SizeInputBox.Location = new System.Drawing.Point(143, 73);
            this.SizeInputBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.SizeInputBox.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.SizeInputBox.Name = "SizeInputBox";
            this.SizeInputBox.Size = new System.Drawing.Size(86, 23);
            this.SizeInputBox.TabIndex = 1;
            this.SizeInputBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.SizeInputBox.ThousandsSeparator = true;
            this.SizeInputBox.ValueChanged += new System.EventHandler(this.UpdateCalcPrice);
            // 
            // BuyButton
            // 
            this.BuyButton.BackColor = System.Drawing.Color.Yellow;
            this.BuyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BuyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BuyButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BuyButton.FlatAppearance.BorderSize = 0;
            this.BuyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BuyButton.Font = new System.Drawing.Font("メイリオ", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BuyButton.ForeColor = System.Drawing.Color.White;
            this.BuyButton.Location = new System.Drawing.Point(135, 236);
            this.BuyButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BuyButton.Name = "BuyButton";
            this.BuyButton.Size = new System.Drawing.Size(135, 60);
            this.BuyButton.TabIndex = 7;
            this.BuyButton.Text = "買い";
            this.BuyButton.UseVisualStyleBackColor = false;
            this.BuyButton.Click += new System.EventHandler(this.OrderButton_Click);
            // 
            // SellButton
            // 
            this.SellButton.BackColor = System.Drawing.Color.Red;
            this.SellButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SellButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SellButton.FlatAppearance.BorderSize = 0;
            this.SellButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SellButton.Font = new System.Drawing.Font("メイリオ", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.SellButton.ForeColor = System.Drawing.Color.White;
            this.SellButton.Location = new System.Drawing.Point(0, 236);
            this.SellButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.SellButton.Name = "SellButton";
            this.SellButton.Size = new System.Drawing.Size(135, 60);
            this.SellButton.TabIndex = 6;
            this.SellButton.Text = "売り";
            this.SellButton.UseVisualStyleBackColor = false;
            this.SellButton.Click += new System.EventHandler(this.OrderButton_Click);
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.ForeColor = System.Drawing.Color.White;
            this.PriceLabel.Location = new System.Drawing.Point(12, 39);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(35, 20);
            this.PriceLabel.TabIndex = 4;
            this.PriceLabel.Text = "価格";
            // 
            // SizeLabel
            // 
            this.SizeLabel.AutoSize = true;
            this.SizeLabel.ForeColor = System.Drawing.Color.White;
            this.SizeLabel.Location = new System.Drawing.Point(12, 76);
            this.SizeLabel.Name = "SizeLabel";
            this.SizeLabel.Size = new System.Drawing.Size(35, 20);
            this.SizeLabel.TabIndex = 5;
            this.SizeLabel.Text = "数量";
            // 
            // SFDTimer
            // 
            this.SFDTimer.Enabled = true;
            this.SFDTimer.Interval = 1000;
            this.SFDTimer.Tick += new System.EventHandler(this.UpdateInfoAsync);
            // 
            // PriceSepalationLabel
            // 
            this.PriceSepalationLabel.AutoSize = true;
            this.PriceSepalationLabel.ForeColor = System.Drawing.Color.White;
            this.PriceSepalationLabel.Location = new System.Drawing.Point(12, 188);
            this.PriceSepalationLabel.Name = "PriceSepalationLabel";
            this.PriceSepalationLabel.Size = new System.Drawing.Size(74, 20);
            this.PriceSepalationLabel.TabIndex = 99;
            this.PriceSepalationLabel.Text = "価格乖離率";
            // 
            // PriceSepalationValueLabel
            // 
            this.PriceSepalationValueLabel.AutoSize = true;
            this.PriceSepalationValueLabel.ForeColor = System.Drawing.Color.White;
            this.PriceSepalationValueLabel.Location = new System.Drawing.Point(106, 188);
            this.PriceSepalationValueLabel.Name = "PriceSepalationValueLabel";
            this.PriceSepalationValueLabel.Size = new System.Drawing.Size(0, 20);
            this.PriceSepalationValueLabel.TabIndex = 7;
            // 
            // CalcPriceValue
            // 
            this.CalcPriceValue.AutoSize = true;
            this.CalcPriceValue.ForeColor = System.Drawing.Color.White;
            this.CalcPriceValue.Location = new System.Drawing.Point(106, 168);
            this.CalcPriceValue.Name = "CalcPriceValue";
            this.CalcPriceValue.Size = new System.Drawing.Size(0, 20);
            this.CalcPriceValue.TabIndex = 10;
            // 
            // CalcPriceLabel
            // 
            this.CalcPriceLabel.AutoSize = true;
            this.CalcPriceLabel.ForeColor = System.Drawing.Color.White;
            this.CalcPriceLabel.Location = new System.Drawing.Point(12, 168);
            this.CalcPriceLabel.Name = "CalcPriceLabel";
            this.CalcPriceLabel.Size = new System.Drawing.Size(61, 20);
            this.CalcPriceLabel.TabIndex = 99;
            this.CalcPriceLabel.Text = "予想価格";
            // 
            // OrderExpireLabel
            // 
            this.OrderExpireLabel.AutoSize = true;
            this.OrderExpireLabel.ForeColor = System.Drawing.Color.White;
            this.OrderExpireLabel.Location = new System.Drawing.Point(12, 107);
            this.OrderExpireLabel.Name = "OrderExpireLabel";
            this.OrderExpireLabel.Size = new System.Drawing.Size(87, 20);
            this.OrderExpireLabel.TabIndex = 9;
            this.OrderExpireLabel.Text = "注文有効期間";
            // 
            // OrderExpire1
            // 
            this.OrderExpire1.AutoSize = true;
            this.OrderExpire1.Checked = true;
            this.OrderExpire1.ForeColor = System.Drawing.Color.White;
            this.OrderExpire1.Location = new System.Drawing.Point(25, 130);
            this.OrderExpire1.Name = "OrderExpire1";
            this.OrderExpire1.Size = new System.Drawing.Size(48, 24);
            this.OrderExpire1.TabIndex = 2;
            this.OrderExpire1.TabStop = true;
            this.OrderExpire1.Text = "1分";
            this.OrderExpire1.UseVisualStyleBackColor = true;
            // 
            // OrderExpire5
            // 
            this.OrderExpire5.AutoSize = true;
            this.OrderExpire5.ForeColor = System.Drawing.Color.White;
            this.OrderExpire5.Location = new System.Drawing.Point(79, 130);
            this.OrderExpire5.Name = "OrderExpire5";
            this.OrderExpire5.Size = new System.Drawing.Size(48, 24);
            this.OrderExpire5.TabIndex = 3;
            this.OrderExpire5.Text = "5分";
            this.OrderExpire5.UseVisualStyleBackColor = true;
            // 
            // OrderExpire30
            // 
            this.OrderExpire30.AutoSize = true;
            this.OrderExpire30.ForeColor = System.Drawing.Color.White;
            this.OrderExpire30.Location = new System.Drawing.Point(133, 130);
            this.OrderExpire30.Name = "OrderExpire30";
            this.OrderExpire30.Size = new System.Drawing.Size(56, 24);
            this.OrderExpire30.TabIndex = 4;
            this.OrderExpire30.Text = "30分";
            this.OrderExpire30.UseVisualStyleBackColor = true;
            // 
            // OrderExpire60
            // 
            this.OrderExpire60.AutoSize = true;
            this.OrderExpire60.ForeColor = System.Drawing.Color.White;
            this.OrderExpire60.Location = new System.Drawing.Point(195, 130);
            this.OrderExpire60.Name = "OrderExpire60";
            this.OrderExpire60.Size = new System.Drawing.Size(56, 24);
            this.OrderExpire60.TabIndex = 5;
            this.OrderExpire60.Text = "60分";
            this.OrderExpire60.UseVisualStyleBackColor = true;
            // 
            // OrderExpirePanel
            // 
            this.OrderExpirePanel.Location = new System.Drawing.Point(0, 108);
            this.OrderExpirePanel.Name = "OrderExpirePanel";
            this.OrderExpirePanel.Size = new System.Drawing.Size(270, 57);
            this.OrderExpirePanel.TabIndex = 99;
            // 
            // SFDRateLabel
            // 
            this.SFDRateLabel.AutoSize = true;
            this.SFDRateLabel.ForeColor = System.Drawing.Color.Magenta;
            this.SFDRateLabel.Location = new System.Drawing.Point(172, 188);
            this.SFDRateLabel.Name = "SFDRateLabel";
            this.SFDRateLabel.Size = new System.Drawing.Size(0, 20);
            this.SFDRateLabel.TabIndex = 100;
            // 
            // ServerStatusValueLabel
            // 
            this.ServerStatusValueLabel.AutoSize = true;
            this.ServerStatusValueLabel.ForeColor = System.Drawing.Color.White;
            this.ServerStatusValueLabel.Location = new System.Drawing.Point(106, 208);
            this.ServerStatusValueLabel.Name = "ServerStatusValueLabel";
            this.ServerStatusValueLabel.Size = new System.Drawing.Size(0, 20);
            this.ServerStatusValueLabel.TabIndex = 101;
            // 
            // ServerStatusLabel
            // 
            this.ServerStatusLabel.AutoSize = true;
            this.ServerStatusLabel.ForeColor = System.Drawing.Color.White;
            this.ServerStatusLabel.Location = new System.Drawing.Point(12, 208);
            this.ServerStatusLabel.Name = "ServerStatusLabel";
            this.ServerStatusLabel.Size = new System.Drawing.Size(74, 20);
            this.ServerStatusLabel.TabIndex = 102;
            this.ServerStatusLabel.Text = "サーバ状態";
            // 
            // AppCloseButton
            // 
            this.AppCloseButton.BackgroundImage = global::BitFlyerOrderApp.Properties.Resources.close_16x16;
            this.AppCloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.AppCloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AppCloseButton.FlatAppearance.BorderSize = 0;
            this.AppCloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AppCloseButton.ForeColor = System.Drawing.Color.Firebrick;
            this.AppCloseButton.Location = new System.Drawing.Point(0, 0);
            this.AppCloseButton.Name = "AppCloseButton";
            this.AppCloseButton.Size = new System.Drawing.Size(28, 28);
            this.AppCloseButton.TabIndex = 103;
            this.AppCloseButton.UseVisualStyleBackColor = true;
            this.AppCloseButton.Click += new System.EventHandler(this.AppCloseButton_Click);
            // 
            // OrderListButton
            // 
            this.OrderListButton.BackgroundImage = global::BitFlyerOrderApp.Properties.Resources.report_16x16;
            this.OrderListButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.OrderListButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OrderListButton.FlatAppearance.BorderSize = 0;
            this.OrderListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OrderListButton.ForeColor = System.Drawing.Color.Firebrick;
            this.OrderListButton.Location = new System.Drawing.Point(214, 0);
            this.OrderListButton.Name = "OrderListButton";
            this.OrderListButton.Size = new System.Drawing.Size(28, 28);
            this.OrderListButton.TabIndex = 98;
            this.OrderListButton.UseVisualStyleBackColor = true;
            this.OrderListButton.Click += new System.EventHandler(this.OrderListButton_Click);
            // 
            // SettingButton
            // 
            this.SettingButton.BackgroundImage = global::BitFlyerOrderApp.Properties.Resources.setting_16x16;
            this.SettingButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.SettingButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SettingButton.FlatAppearance.BorderSize = 0;
            this.SettingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingButton.ForeColor = System.Drawing.Color.Firebrick;
            this.SettingButton.Location = new System.Drawing.Point(242, 0);
            this.SettingButton.Name = "SettingButton";
            this.SettingButton.Size = new System.Drawing.Size(28, 28);
            this.SettingButton.TabIndex = 99;
            this.SettingButton.UseVisualStyleBackColor = true;
            this.SettingButton.Click += new System.EventHandler(this.SettingButton_Click);
            // 
            // loadPriceButton
            // 
            this.loadPriceButton.BackgroundImage = global::BitFlyerOrderApp.Properties.Resources.reload_16x16;
            this.loadPriceButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.loadPriceButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loadPriceButton.FlatAppearance.BorderSize = 0;
            this.loadPriceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadPriceButton.Location = new System.Drawing.Point(232, 33);
            this.loadPriceButton.Name = "loadPriceButton";
            this.loadPriceButton.Size = new System.Drawing.Size(28, 28);
            this.loadPriceButton.TabIndex = 8;
            this.loadPriceButton.UseVisualStyleBackColor = true;
            this.loadPriceButton.Click += new System.EventHandler(this.LoadPriceButton_Click);
            // 
            // OrderResultValueLabel
            // 
            this.OrderResultValueLabel.AutoSize = true;
            this.OrderResultValueLabel.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.OrderResultValueLabel.ForeColor = System.Drawing.Color.Lime;
            this.OrderResultValueLabel.Location = new System.Drawing.Point(189, 208);
            this.OrderResultValueLabel.Name = "OrderResultValueLabel";
            this.OrderResultValueLabel.Size = new System.Drawing.Size(0, 20);
            this.OrderResultValueLabel.TabIndex = 104;
            // 
            // OrderResultTimer
            // 
            this.OrderResultTimer.Interval = 1500;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(269, 296);
            this.Controls.Add(this.OrderResultValueLabel);
            this.Controls.Add(this.AppCloseButton);
            this.Controls.Add(this.ServerStatusValueLabel);
            this.Controls.Add(this.ServerStatusLabel);
            this.Controls.Add(this.SFDRateLabel);
            this.Controls.Add(this.OrderListButton);
            this.Controls.Add(this.SettingButton);
            this.Controls.Add(this.OrderExpire60);
            this.Controls.Add(this.OrderExpire30);
            this.Controls.Add(this.OrderExpire5);
            this.Controls.Add(this.OrderExpire1);
            this.Controls.Add(this.CalcPriceValue);
            this.Controls.Add(this.OrderExpireLabel);
            this.Controls.Add(this.CalcPriceLabel);
            this.Controls.Add(this.loadPriceButton);
            this.Controls.Add(this.PriceSepalationValueLabel);
            this.Controls.Add(this.PriceSepalationLabel);
            this.Controls.Add(this.SizeLabel);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.SellButton);
            this.Controls.Add(this.BuyButton);
            this.Controls.Add(this.SizeInputBox);
            this.Controls.Add(this.PriceInputBox);
            this.Controls.Add(this.OrderExpirePanel);
            this.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "OrderForm";
            this.Text = "BitFlyerOrder";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.OrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PriceInputBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SizeInputBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown PriceInputBox;
        private System.Windows.Forms.NumericUpDown SizeInputBox;
        private System.Windows.Forms.Button BuyButton;
        private System.Windows.Forms.Button SellButton;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label SizeLabel;
        private System.Windows.Forms.Timer SFDTimer;
        private System.Windows.Forms.Label PriceSepalationLabel;
        private System.Windows.Forms.Label PriceSepalationValueLabel;
        private System.Windows.Forms.Button loadPriceButton;
        private System.Windows.Forms.Label CalcPriceValue;
        private System.Windows.Forms.Label CalcPriceLabel;
        private System.Windows.Forms.Label OrderExpireLabel;
        private System.Windows.Forms.RadioButton OrderExpire1;
        private System.Windows.Forms.RadioButton OrderExpire5;
        private System.Windows.Forms.RadioButton OrderExpire30;
        private System.Windows.Forms.RadioButton OrderExpire60;
        private System.Windows.Forms.Panel OrderExpirePanel;
        private System.Windows.Forms.Button SettingButton;
        private System.Windows.Forms.Button OrderListButton;
        private System.Windows.Forms.Label SFDRateLabel;
        private System.Windows.Forms.Label ServerStatusValueLabel;
        private System.Windows.Forms.Label ServerStatusLabel;
        private System.Windows.Forms.Button AppCloseButton;
        private System.Windows.Forms.Label OrderResultValueLabel;
        private System.Windows.Forms.Timer OrderResultTimer;
    }
}

