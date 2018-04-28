namespace BitFlyerOrderApp
{
    partial class OrderListForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.OrderGridView = new System.Windows.Forms.DataGridView();
            this.OrderType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderAcceptTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Side = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RemainingSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpireDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cancel = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ChildOrderAcceptanceId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderCheckTimer = new System.Windows.Forms.Timer(this.components);
            this.PositionGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceBand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderLabel = new System.Windows.Forms.Label();
            this.PositionLabel = new System.Windows.Forms.Label();
            this.CancelResultTimer = new System.Windows.Forms.Timer(this.components);
            this.CancelResultValueLabel = new System.Windows.Forms.Label();
            this.OrderListCloseButton = new System.Windows.Forms.Button();
            this.CancelAllButton = new System.Windows.Forms.Button();
            this.dummy = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.OrderGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PositionGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // OrderGridView
            // 
            this.OrderGridView.AllowUserToAddRows = false;
            this.OrderGridView.AllowUserToDeleteRows = false;
            this.OrderGridView.AllowUserToResizeColumns = false;
            this.OrderGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.OrderGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.OrderGridView.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.OrderGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OrderGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.OrderGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OrderGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.OrderGridView.ColumnHeadersHeight = 20;
            this.OrderGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.OrderGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderType,
            this.OrderDateTime,
            this.OrderAcceptTime,
            this.Side,
            this.OrderPrice,
            this.OrderSize,
            this.RemainingSize,
            this.ExpireDate,
            this.Cancel,
            this.ChildOrderAcceptanceId});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("メイリオ", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.OrderGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.OrderGridView.EnableHeadersVisualStyles = false;
            this.OrderGridView.Location = new System.Drawing.Point(0, 30);
            this.OrderGridView.MultiSelect = false;
            this.OrderGridView.Name = "OrderGridView";
            this.OrderGridView.ReadOnly = true;
            this.OrderGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OrderGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.OrderGridView.RowHeadersVisible = false;
            this.OrderGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("メイリオ", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.OrderGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.OrderGridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.ControlDark;
            this.OrderGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("メイリオ", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.OrderGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.OrderGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightGray;
            this.OrderGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.OrderGridView.RowTemplate.Height = 21;
            this.OrderGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.OrderGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OrderGridView.ShowCellErrors = false;
            this.OrderGridView.ShowCellToolTips = false;
            this.OrderGridView.ShowEditingIcon = false;
            this.OrderGridView.ShowRowErrors = false;
            this.OrderGridView.Size = new System.Drawing.Size(600, 120);
            this.OrderGridView.TabIndex = 0;
            this.OrderGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrderGridView_CellClick);
            // 
            // OrderType
            // 
            this.OrderType.DataPropertyName = "OrderType";
            this.OrderType.HeaderText = "種別";
            this.OrderType.MaxInputLength = 3;
            this.OrderType.Name = "OrderType";
            this.OrderType.ReadOnly = true;
            this.OrderType.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.OrderType.Width = 50;
            // 
            // OrderDateTime
            // 
            this.OrderDateTime.DataPropertyName = "OrderDateTime";
            this.OrderDateTime.HeaderText = "注文時間";
            this.OrderDateTime.MaxInputLength = 15;
            this.OrderDateTime.Name = "OrderDateTime";
            this.OrderDateTime.ReadOnly = true;
            this.OrderDateTime.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // OrderAcceptTime
            // 
            this.OrderAcceptTime.DataPropertyName = "OrderAcceptTime";
            this.OrderAcceptTime.HeaderText = "承認時間";
            this.OrderAcceptTime.MaxInputLength = 15;
            this.OrderAcceptTime.Name = "OrderAcceptTime";
            this.OrderAcceptTime.ReadOnly = true;
            this.OrderAcceptTime.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Side
            // 
            this.Side.DataPropertyName = "Side";
            this.Side.HeaderText = "売買";
            this.Side.MaxInputLength = 3;
            this.Side.Name = "Side";
            this.Side.ReadOnly = true;
            this.Side.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Side.Width = 40;
            // 
            // OrderPrice
            // 
            this.OrderPrice.DataPropertyName = "OrderPrice";
            this.OrderPrice.HeaderText = "発注価格";
            this.OrderPrice.MaxInputLength = 15;
            this.OrderPrice.Name = "OrderPrice";
            this.OrderPrice.ReadOnly = true;
            this.OrderPrice.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.OrderPrice.Width = 70;
            // 
            // OrderSize
            // 
            this.OrderSize.DataPropertyName = "OrderSize";
            this.OrderSize.HeaderText = "数量";
            this.OrderSize.MaxInputLength = 10;
            this.OrderSize.Name = "OrderSize";
            this.OrderSize.ReadOnly = true;
            this.OrderSize.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.OrderSize.Width = 40;
            // 
            // RemainingSize
            // 
            this.RemainingSize.DataPropertyName = "RemainingSize";
            this.RemainingSize.HeaderText = "残数量";
            this.RemainingSize.MaxInputLength = 10;
            this.RemainingSize.Name = "RemainingSize";
            this.RemainingSize.ReadOnly = true;
            this.RemainingSize.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.RemainingSize.Width = 40;
            // 
            // ExpireDate
            // 
            this.ExpireDate.DataPropertyName = "ExpireDate";
            this.ExpireDate.HeaderText = "注文期限";
            this.ExpireDate.Name = "ExpireDate";
            this.ExpireDate.ReadOnly = true;
            this.ExpireDate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Cancel
            // 
            this.Cancel.DataPropertyName = "Cancel";
            this.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel.HeaderText = "取消";
            this.Cancel.Name = "Cancel";
            this.Cancel.ReadOnly = true;
            this.Cancel.Width = 40;
            // 
            // ChildOrderAcceptanceId
            // 
            this.ChildOrderAcceptanceId.DataPropertyName = "ChildOrderAcceptanceId";
            this.ChildOrderAcceptanceId.HeaderText = "子注文ID";
            this.ChildOrderAcceptanceId.Name = "ChildOrderAcceptanceId";
            this.ChildOrderAcceptanceId.ReadOnly = true;
            this.ChildOrderAcceptanceId.Visible = false;
            // 
            // OrderCheckTimer
            // 
            this.OrderCheckTimer.Enabled = true;
            this.OrderCheckTimer.Interval = 500;
            this.OrderCheckTimer.Tick += new System.EventHandler(this.OrderGridView_Timer);
            // 
            // PositionGridView
            // 
            this.PositionGridView.AllowUserToAddRows = false;
            this.PositionGridView.AllowUserToDeleteRows = false;
            this.PositionGridView.AllowUserToResizeColumns = false;
            this.PositionGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.PositionGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.PositionGridView.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PositionGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PositionGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.PositionGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PositionGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.PositionGridView.ColumnHeadersHeight = 20;
            this.PositionGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.PositionGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.PriceBand});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("メイリオ", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PositionGridView.DefaultCellStyle = dataGridViewCellStyle8;
            this.PositionGridView.EnableHeadersVisualStyles = false;
            this.PositionGridView.Location = new System.Drawing.Point(0, 191);
            this.PositionGridView.Name = "PositionGridView";
            this.PositionGridView.ReadOnly = true;
            this.PositionGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PositionGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.PositionGridView.RowHeadersVisible = false;
            this.PositionGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("メイリオ", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            this.PositionGridView.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.PositionGridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.ControlDark;
            this.PositionGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("メイリオ", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.PositionGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.PositionGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightGray;
            this.PositionGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.PositionGridView.RowTemplate.Height = 21;
            this.PositionGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.PositionGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PositionGridView.ShowCellErrors = false;
            this.PositionGridView.ShowEditingIcon = false;
            this.PositionGridView.ShowRowErrors = false;
            this.PositionGridView.Size = new System.Drawing.Size(600, 101);
            this.PositionGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "OrderDateTime";
            this.dataGridViewTextBoxColumn2.HeaderText = "日時";
            this.dataGridViewTextBoxColumn2.MaxInputLength = 15;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Side";
            this.dataGridViewTextBoxColumn4.HeaderText = "売買";
            this.dataGridViewTextBoxColumn4.MaxInputLength = 3;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn4.Width = 40;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "OrderAcceptTime";
            this.dataGridViewTextBoxColumn3.HeaderText = "平均価格";
            this.dataGridViewTextBoxColumn3.MaxInputLength = 15;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "OrderSize";
            this.dataGridViewTextBoxColumn6.HeaderText = "数量";
            this.dataGridViewTextBoxColumn6.MaxInputLength = 10;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn6.Width = 40;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "RemainingSize";
            this.dataGridViewTextBoxColumn7.HeaderText = "評価額";
            this.dataGridViewTextBoxColumn7.MaxInputLength = 10;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn7.Width = 70;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "ExpireDate";
            this.dataGridViewTextBoxColumn8.HeaderText = "取引証拠金";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // PriceBand
            // 
            this.PriceBand.DataPropertyName = "PriceBand";
            this.PriceBand.HeaderText = "獲得値幅";
            this.PriceBand.Name = "PriceBand";
            this.PriceBand.ReadOnly = true;
            this.PriceBand.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.PriceBand.Width = 70;
            // 
            // OrderLabel
            // 
            this.OrderLabel.AutoSize = true;
            this.OrderLabel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.OrderLabel.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.OrderLabel.Location = new System.Drawing.Point(30, 0);
            this.OrderLabel.Name = "OrderLabel";
            this.OrderLabel.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.OrderLabel.Size = new System.Drawing.Size(60, 30);
            this.OrderLabel.TabIndex = 2;
            this.OrderLabel.Text = "注文";
            // 
            // PositionLabel
            // 
            this.PositionLabel.AutoSize = true;
            this.PositionLabel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.PositionLabel.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.PositionLabel.Location = new System.Drawing.Point(30, 161);
            this.PositionLabel.Name = "PositionLabel";
            this.PositionLabel.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.PositionLabel.Size = new System.Drawing.Size(60, 30);
            this.PositionLabel.TabIndex = 3;
            this.PositionLabel.Text = "建玉";
            // 
            // CancelResultTimer
            // 
            this.CancelResultTimer.Interval = 1500;
            // 
            // CancelResultValueLabel
            // 
            this.CancelResultValueLabel.AutoSize = true;
            this.CancelResultValueLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelResultValueLabel.ForeColor = System.Drawing.Color.Lime;
            this.CancelResultValueLabel.Location = new System.Drawing.Point(460, 9);
            this.CancelResultValueLabel.Name = "CancelResultValueLabel";
            this.CancelResultValueLabel.Size = new System.Drawing.Size(0, 12);
            this.CancelResultValueLabel.TabIndex = 4;
            // 
            // OrderListCloseButton
            // 
            this.OrderListCloseButton.BackgroundImage = global::BitFlyerOrderApp.Properties.Resources.close_16x16;
            this.OrderListCloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.OrderListCloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OrderListCloseButton.FlatAppearance.BorderSize = 0;
            this.OrderListCloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OrderListCloseButton.ForeColor = System.Drawing.Color.Firebrick;
            this.OrderListCloseButton.Location = new System.Drawing.Point(2, 1);
            this.OrderListCloseButton.Name = "OrderListCloseButton";
            this.OrderListCloseButton.Size = new System.Drawing.Size(28, 28);
            this.OrderListCloseButton.TabIndex = 104;
            this.OrderListCloseButton.UseVisualStyleBackColor = true;
            this.OrderListCloseButton.Click += new System.EventHandler(this.OrderListCloseButton_Click);
            // 
            // CancelAllButton
            // 
            this.CancelAllButton.BackColor = System.Drawing.Color.DarkOrange;
            this.CancelAllButton.FlatAppearance.BorderSize = 0;
            this.CancelAllButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelAllButton.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.CancelAllButton.Location = new System.Drawing.Point(540, 0);
            this.CancelAllButton.Name = "CancelAllButton";
            this.CancelAllButton.Size = new System.Drawing.Size(60, 30);
            this.CancelAllButton.TabIndex = 105;
            this.CancelAllButton.Text = "全取消";
            this.CancelAllButton.UseVisualStyleBackColor = false;
            this.CancelAllButton.Click += new System.EventHandler(this.CancelAllButton_Click);
            // 
            // dummy
            // 
            this.dummy.AutoSize = true;
            this.dummy.BackColor = System.Drawing.Color.DarkGray;
            this.dummy.Location = new System.Drawing.Point(580, 30);
            this.dummy.Name = "dummy";
            this.dummy.Padding = new System.Windows.Forms.Padding(10, 8, 10, 0);
            this.dummy.Size = new System.Drawing.Size(20, 20);
            this.dummy.TabIndex = 106;
            // 
            // OrderListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.dummy);
            this.Controls.Add(this.CancelAllButton);
            this.Controls.Add(this.OrderListCloseButton);
            this.Controls.Add(this.CancelResultValueLabel);
            this.Controls.Add(this.PositionLabel);
            this.Controls.Add(this.OrderLabel);
            this.Controls.Add(this.PositionGridView);
            this.Controls.Add(this.OrderGridView);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrderListForm";
            this.Text = "OrderListForm";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.OrderListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OrderGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PositionGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView OrderGridView;
        private System.Windows.Forms.Timer OrderCheckTimer;
        private System.Windows.Forms.DataGridView PositionGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceBand;
        private System.Windows.Forms.Label OrderLabel;
        private System.Windows.Forms.Label PositionLabel;
        private System.Windows.Forms.Timer CancelResultTimer;
        private System.Windows.Forms.Label CancelResultValueLabel;
        private System.Windows.Forms.Button OrderListCloseButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderType;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderDateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderAcceptTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Side;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn RemainingSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpireDate;
        private System.Windows.Forms.DataGridViewButtonColumn Cancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChildOrderAcceptanceId;
        private System.Windows.Forms.Button CancelAllButton;
        private System.Windows.Forms.Label dummy;
    }
}