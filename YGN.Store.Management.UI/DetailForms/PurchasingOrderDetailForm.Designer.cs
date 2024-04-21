namespace YGN.Store.Management.UI.DetailForms
{
    partial class PurchasingOrderDetailForm
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
            this.btnDeleteLine = new System.Windows.Forms.Button();
            this.txtLastPrice = new System.Windows.Forms.TextBox();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.selectedItemsGroupBox = new System.Windows.Forms.GroupBox();
            this.selectedItemsDataGridView = new System.Windows.Forms.DataGridView();
            this.itemsGroupBox = new System.Windows.Forms.GroupBox();
            this.itemsDataGridView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UniPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxClient = new System.Windows.Forms.GroupBox();
            this.clientsComboBox = new System.Windows.Forms.ComboBox();
            this.lblClient = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.selectedItemsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectedItemsDataGridView)).BeginInit();
            this.itemsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsDataGridView)).BeginInit();
            this.groupBoxClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1197, 77);
            this.panel1.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnClose.Location = new System.Drawing.Point(84, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 68);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Kapat";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSave.Location = new System.Drawing.Point(3, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 68);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnDeleteLine);
            this.panel2.Controls.Add(this.txtLastPrice);
            this.panel2.Controls.Add(this.lblTotalPrice);
            this.panel2.Controls.Add(this.selectedItemsGroupBox);
            this.panel2.Controls.Add(this.itemsGroupBox);
            this.panel2.Controls.Add(this.groupBoxClient);
            this.panel2.Location = new System.Drawing.Point(12, 107);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1197, 590);
            this.panel2.TabIndex = 1;
            // 
            // btnDeleteLine
            // 
            this.btnDeleteLine.BackColor = System.Drawing.Color.Red;
            this.btnDeleteLine.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDeleteLine.Location = new System.Drawing.Point(1083, 71);
            this.btnDeleteLine.Name = "btnDeleteLine";
            this.btnDeleteLine.Size = new System.Drawing.Size(54, 31);
            this.btnDeleteLine.TabIndex = 8;
            this.btnDeleteLine.Text = "Sil";
            this.btnDeleteLine.UseVisualStyleBackColor = false;
            this.btnDeleteLine.Click += new System.EventHandler(this.btnDeleteLine_Click);
            // 
            // txtLastPrice
            // 
            this.txtLastPrice.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtLastPrice.Location = new System.Drawing.Point(410, 54);
            this.txtLastPrice.Name = "txtLastPrice";
            this.txtLastPrice.ReadOnly = true;
            this.txtLastPrice.Size = new System.Drawing.Size(120, 25);
            this.txtLastPrice.TabIndex = 4;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotalPrice.Location = new System.Drawing.Point(423, 32);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(95, 19);
            this.lblTotalPrice.TabIndex = 3;
            this.lblTotalPrice.Text = "Toplam Fiyat";
            // 
            // selectedItemsGroupBox
            // 
            this.selectedItemsGroupBox.Controls.Add(this.selectedItemsDataGridView);
            this.selectedItemsGroupBox.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.selectedItemsGroupBox.Location = new System.Drawing.Point(556, 98);
            this.selectedItemsGroupBox.Name = "selectedItemsGroupBox";
            this.selectedItemsGroupBox.Size = new System.Drawing.Size(587, 492);
            this.selectedItemsGroupBox.TabIndex = 2;
            this.selectedItemsGroupBox.TabStop = false;
            this.selectedItemsGroupBox.Text = "Seçilen  Ürünler";
            // 
            // selectedItemsDataGridView
            // 
            this.selectedItemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.selectedItemsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectedItemsDataGridView.Location = new System.Drawing.Point(3, 19);
            this.selectedItemsDataGridView.Name = "selectedItemsDataGridView";
            this.selectedItemsDataGridView.Size = new System.Drawing.Size(581, 470);
            this.selectedItemsDataGridView.TabIndex = 0;
            this.selectedItemsDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.selectedItemsDataGridView_CellEndEdit);
            // 
            // itemsGroupBox
            // 
            this.itemsGroupBox.Controls.Add(this.itemsDataGridView);
            this.itemsGroupBox.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.itemsGroupBox.Location = new System.Drawing.Point(12, 95);
            this.itemsGroupBox.Name = "itemsGroupBox";
            this.itemsGroupBox.Size = new System.Drawing.Size(538, 492);
            this.itemsGroupBox.TabIndex = 1;
            this.itemsGroupBox.TabStop = false;
            this.itemsGroupBox.Text = "Ürün - Seç";
            // 
            // itemsDataGridView
            // 
            this.itemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.ItemCode,
            this.ItemName,
            this.UniPrice,
            this.Brand,
            this.Amount});
            this.itemsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemsDataGridView.Location = new System.Drawing.Point(3, 19);
            this.itemsDataGridView.Name = "itemsDataGridView";
            this.itemsDataGridView.ReadOnly = true;
            this.itemsDataGridView.Size = new System.Drawing.Size(532, 470);
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
            // UniPrice
            // 
            this.UniPrice.DataPropertyName = "UnitPrice";
            this.UniPrice.HeaderText = "Birim Fiyat";
            this.UniPrice.Name = "UniPrice";
            this.UniPrice.ReadOnly = true;
            // 
            // Brand
            // 
            this.Brand.DataPropertyName = "Brand";
            this.Brand.HeaderText = "Marka";
            this.Brand.Name = "Brand";
            this.Brand.ReadOnly = true;
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "Amount";
            this.Amount.HeaderText = "Miktar";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // groupBoxClient
            // 
            this.groupBoxClient.Controls.Add(this.clientsComboBox);
            this.groupBoxClient.Controls.Add(this.lblClient);
            this.groupBoxClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxClient.Location = new System.Drawing.Point(12, 12);
            this.groupBoxClient.Name = "groupBoxClient";
            this.groupBoxClient.Size = new System.Drawing.Size(372, 77);
            this.groupBoxClient.TabIndex = 0;
            this.groupBoxClient.TabStop = false;
            this.groupBoxClient.Text = "Cari - Seç";
            // 
            // clientsComboBox
            // 
            this.clientsComboBox.FormattingEnabled = true;
            this.clientsComboBox.Location = new System.Drawing.Point(72, 34);
            this.clientsComboBox.Name = "clientsComboBox";
            this.clientsComboBox.Size = new System.Drawing.Size(286, 24);
            this.clientsComboBox.TabIndex = 1;
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Location = new System.Drawing.Point(22, 37);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(37, 16);
            this.lblClient.TabIndex = 0;
            this.lblClient.Text = "Cari: ";
            // 
            // PurchasingOrderDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 709);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "PurchasingOrderDetailForm";
            this.Text = "Satınalma";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PurchasingOrderDetailForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.selectedItemsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.selectedItemsDataGridView)).EndInit();
            this.itemsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.itemsDataGridView)).EndInit();
            this.groupBoxClient.ResumeLayout(false);
            this.groupBoxClient.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBoxClient;
        private System.Windows.Forms.ComboBox clientsComboBox;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.GroupBox selectedItemsGroupBox;
        private System.Windows.Forms.GroupBox itemsGroupBox;
        private System.Windows.Forms.TextBox txtLastPrice;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.DataGridView selectedItemsDataGridView;
        private System.Windows.Forms.DataGridView itemsDataGridView;
        private System.Windows.Forms.Button btnDeleteLine;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UniPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
    }
}