namespace YGN.Store.Management.UI.DetailForms
{
    partial class QuickSalesOrderDetailForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblLastPrice = new System.Windows.Forms.Label();
            this.txtLastPrice = new System.Windows.Forms.TextBox();
            this.btnDeleteLine = new System.Windows.Forms.Button();
            this.groupBoxClient = new System.Windows.Forms.GroupBox();
            this.comboBoxClients = new System.Windows.Forms.ComboBox();
            this.lblClient = new System.Windows.Forms.Label();
            this.selectedItemsGroupBox = new System.Windows.Forms.GroupBox();
            this.selectedItemsDataGridView = new System.Windows.Forms.DataGridView();
            this.selectItemGroupBox = new System.Windows.Forms.GroupBox();
            this.itemsDataGridView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentGroupBox = new System.Windows.Forms.GroupBox();
            this.lblPaymentType = new System.Windows.Forms.Label();
            this.comboBoxPaymentType = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBoxClient.SuspendLayout();
            this.selectedItemsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectedItemsDataGridView)).BeginInit();
            this.selectItemGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsDataGridView)).BeginInit();
            this.paymentGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1271, 64);
            this.panel1.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnClose.Location = new System.Drawing.Point(68, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(59, 57);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Kapat";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSave.Location = new System.Drawing.Point(3, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(59, 57);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.paymentGroupBox);
            this.panel2.Controls.Add(this.lblLastPrice);
            this.panel2.Controls.Add(this.txtLastPrice);
            this.panel2.Controls.Add(this.btnDeleteLine);
            this.panel2.Controls.Add(this.groupBoxClient);
            this.panel2.Controls.Add(this.selectedItemsGroupBox);
            this.panel2.Controls.Add(this.selectItemGroupBox);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panel2.Location = new System.Drawing.Point(12, 82);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1271, 722);
            this.panel2.TabIndex = 1;
            // 
            // lblLastPrice
            // 
            this.lblLastPrice.AutoSize = true;
            this.lblLastPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLastPrice.Location = new System.Drawing.Point(820, 17);
            this.lblLastPrice.Name = "lblLastPrice";
            this.lblLastPrice.Size = new System.Drawing.Size(130, 24);
            this.lblLastPrice.TabIndex = 9;
            this.lblLastPrice.Text = "Toplam Fiyat";
            // 
            // txtLastPrice
            // 
            this.txtLastPrice.Enabled = false;
            this.txtLastPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtLastPrice.Location = new System.Drawing.Point(808, 44);
            this.txtLastPrice.Name = "txtLastPrice";
            this.txtLastPrice.ReadOnly = true;
            this.txtLastPrice.Size = new System.Drawing.Size(155, 29);
            this.txtLastPrice.TabIndex = 8;
            // 
            // btnDeleteLine
            // 
            this.btnDeleteLine.BackColor = System.Drawing.Color.Red;
            this.btnDeleteLine.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDeleteLine.Location = new System.Drawing.Point(1032, 60);
            this.btnDeleteLine.Name = "btnDeleteLine";
            this.btnDeleteLine.Size = new System.Drawing.Size(54, 31);
            this.btnDeleteLine.TabIndex = 7;
            this.btnDeleteLine.Text = "Sil";
            this.btnDeleteLine.UseVisualStyleBackColor = false;
            this.btnDeleteLine.Click += new System.EventHandler(this.btnDeleteLine_Click);
            // 
            // groupBoxClient
            // 
            this.groupBoxClient.Controls.Add(this.comboBoxClients);
            this.groupBoxClient.Controls.Add(this.lblClient);
            this.groupBoxClient.Location = new System.Drawing.Point(6, 3);
            this.groupBoxClient.Name = "groupBoxClient";
            this.groupBoxClient.Size = new System.Drawing.Size(359, 77);
            this.groupBoxClient.TabIndex = 4;
            this.groupBoxClient.TabStop = false;
            this.groupBoxClient.Text = "Cari - Seç";
            // 
            // comboBoxClients
            // 
            this.comboBoxClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxClients.FormattingEnabled = true;
            this.comboBoxClients.Location = new System.Drawing.Point(74, 31);
            this.comboBoxClients.Name = "comboBoxClients";
            this.comboBoxClients.Size = new System.Drawing.Size(279, 24);
            this.comboBoxClients.TabIndex = 1;
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Location = new System.Drawing.Point(16, 34);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(49, 16);
            this.lblClient.TabIndex = 0;
            this.lblClient.Text = "Cariler:";
            // 
            // selectedItemsGroupBox
            // 
            this.selectedItemsGroupBox.Controls.Add(this.selectedItemsDataGridView);
            this.selectedItemsGroupBox.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.selectedItemsGroupBox.Location = new System.Drawing.Point(574, 86);
            this.selectedItemsGroupBox.Name = "selectedItemsGroupBox";
            this.selectedItemsGroupBox.Size = new System.Drawing.Size(686, 622);
            this.selectedItemsGroupBox.TabIndex = 1;
            this.selectedItemsGroupBox.TabStop = false;
            this.selectedItemsGroupBox.Text = "Seçilen Ürünler";
            // 
            // selectedItemsDataGridView
            // 
            this.selectedItemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.selectedItemsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectedItemsDataGridView.Location = new System.Drawing.Point(3, 21);
            this.selectedItemsDataGridView.Name = "selectedItemsDataGridView";
            this.selectedItemsDataGridView.Size = new System.Drawing.Size(680, 598);
            this.selectedItemsDataGridView.TabIndex = 0;
            this.selectedItemsDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.selectedItemsDataGridView_CellEndEdit);
            // 
            // selectItemGroupBox
            // 
            this.selectItemGroupBox.Controls.Add(this.itemsDataGridView);
            this.selectItemGroupBox.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.selectItemGroupBox.Location = new System.Drawing.Point(3, 86);
            this.selectItemGroupBox.Name = "selectItemGroupBox";
            this.selectItemGroupBox.Size = new System.Drawing.Size(562, 622);
            this.selectItemGroupBox.TabIndex = 0;
            this.selectItemGroupBox.TabStop = false;
            this.selectItemGroupBox.Text = "Ürün - Seç";
            // 
            // itemsDataGridView
            // 
            this.itemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.ItemCode,
            this.ItemName,
            this.UnitPrice,
            this.Brand});
            this.itemsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemsDataGridView.Location = new System.Drawing.Point(3, 21);
            this.itemsDataGridView.Name = "itemsDataGridView";
            this.itemsDataGridView.ReadOnly = true;
            this.itemsDataGridView.Size = new System.Drawing.Size(556, 598);
            this.itemsDataGridView.TabIndex = 0;
            this.itemsDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.itemsDataGridView_CellDoubleClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // ItemCode
            // 
            this.ItemCode.DataPropertyName = "ItemCode";
            this.ItemCode.HeaderText = "Malzeme Kodu";
            this.ItemCode.Name = "ItemCode";
            this.ItemCode.ReadOnly = true;
            // 
            // ItemName
            // 
            this.ItemName.DataPropertyName = "ItemName";
            this.ItemName.HeaderText = "Malzeme Açıklaması";
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            // 
            // UnitPrice
            // 
            this.UnitPrice.DataPropertyName = "UnitPrice";
            this.UnitPrice.HeaderText = "Birim Fiyat";
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.ReadOnly = true;
            // 
            // Brand
            // 
            this.Brand.DataPropertyName = "Brand";
            this.Brand.HeaderText = "Marka";
            this.Brand.Name = "Brand";
            this.Brand.ReadOnly = true;
            // 
            // paymentGroupBox
            // 
            this.paymentGroupBox.Controls.Add(this.comboBoxPaymentType);
            this.paymentGroupBox.Controls.Add(this.lblPaymentType);
            this.paymentGroupBox.Location = new System.Drawing.Point(371, 3);
            this.paymentGroupBox.Name = "paymentGroupBox";
            this.paymentGroupBox.Size = new System.Drawing.Size(315, 77);
            this.paymentGroupBox.TabIndex = 10;
            this.paymentGroupBox.TabStop = false;
            this.paymentGroupBox.Text = "Ödeme";
            // 
            // lblPaymentType
            // 
            this.lblPaymentType.AutoSize = true;
            this.lblPaymentType.Location = new System.Drawing.Point(20, 39);
            this.lblPaymentType.Name = "lblPaymentType";
            this.lblPaymentType.Size = new System.Drawing.Size(81, 16);
            this.lblPaymentType.TabIndex = 0;
            this.lblPaymentType.Text = "Ödeme Tipi:";
            // 
            // comboBoxPaymentType
            // 
            this.comboBoxPaymentType.FormattingEnabled = true;
            this.comboBoxPaymentType.Location = new System.Drawing.Point(117, 34);
            this.comboBoxPaymentType.Name = "comboBoxPaymentType";
            this.comboBoxPaymentType.Size = new System.Drawing.Size(192, 24);
            this.comboBoxPaymentType.TabIndex = 1;
            // 
            // QuickSalesOrderDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1297, 816);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "QuickSalesOrderDetailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hızlı Satış";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.QuickSalesOrderDetailForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBoxClient.ResumeLayout(false);
            this.groupBoxClient.PerformLayout();
            this.selectedItemsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.selectedItemsDataGridView)).EndInit();
            this.selectItemGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.itemsDataGridView)).EndInit();
            this.paymentGroupBox.ResumeLayout(false);
            this.paymentGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox selectItemGroupBox;
        private System.Windows.Forms.GroupBox selectedItemsGroupBox;
        private System.Windows.Forms.DataGridView itemsDataGridView;
        private System.Windows.Forms.DataGridView selectedItemsDataGridView;
        private System.Windows.Forms.GroupBox groupBoxClient;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.ComboBox comboBoxClients;
        private System.Windows.Forms.Button btnDeleteLine;
        private System.Windows.Forms.Label lblLastPrice;
        private System.Windows.Forms.TextBox txtLastPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brand;
        private System.Windows.Forms.GroupBox paymentGroupBox;
        private System.Windows.Forms.Label lblPaymentType;
        private System.Windows.Forms.ComboBox comboBoxPaymentType;
    }
}