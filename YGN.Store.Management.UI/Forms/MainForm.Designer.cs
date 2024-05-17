namespace YGN.Store.Management.UI.Forms
{
    partial class MainForm
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
            this.btnQuickSales = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPurchasing = new System.Windows.Forms.Button();
            this.btnStockAmount = new System.Windows.Forms.Button();
            this.groupBoxLastTransactions = new System.Windows.Forms.GroupBox();
            this.lastTransactionDataGridView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirmDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Module = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnClients = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lastTransactionGridViewContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backuoGroupBox = new System.Windows.Forms.GroupBox();
            this.btnBackup = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBoxLastTransactions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lastTransactionDataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.lastTransactionGridViewContextMenuStrip.SuspendLayout();
            this.backuoGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnQuickSales
            // 
            this.btnQuickSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnQuickSales.Location = new System.Drawing.Point(6, 19);
            this.btnQuickSales.Name = "btnQuickSales";
            this.btnQuickSales.Size = new System.Drawing.Size(72, 59);
            this.btnQuickSales.TabIndex = 2;
            this.btnQuickSales.Text = "Hızlı Satış";
            this.btnQuickSales.UseVisualStyleBackColor = true;
            this.btnQuickSales.Click += new System.EventHandler(this.btnQuickSales_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPurchasing);
            this.groupBox1.Controls.Add(this.btnQuickSales);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(268, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(178, 84);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İşlemler";
            // 
            // btnPurchasing
            // 
            this.btnPurchasing.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPurchasing.Location = new System.Drawing.Point(84, 19);
            this.btnPurchasing.Name = "btnPurchasing";
            this.btnPurchasing.Size = new System.Drawing.Size(88, 59);
            this.btnPurchasing.TabIndex = 3;
            this.btnPurchasing.Text = "Satınalma";
            this.btnPurchasing.UseVisualStyleBackColor = true;
            this.btnPurchasing.Click += new System.EventHandler(this.btnPurchasing_Click);
            // 
            // btnStockAmount
            // 
            this.btnStockAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStockAmount.Location = new System.Drawing.Point(6, 18);
            this.btnStockAmount.Name = "btnStockAmount";
            this.btnStockAmount.Size = new System.Drawing.Size(72, 59);
            this.btnStockAmount.TabIndex = 9;
            this.btnStockAmount.Text = "Stok Miktar Raporu";
            this.btnStockAmount.UseVisualStyleBackColor = true;
            this.btnStockAmount.Click += new System.EventHandler(this.btnStockAmount_Click);
            // 
            // groupBoxLastTransactions
            // 
            this.groupBoxLastTransactions.Controls.Add(this.lastTransactionDataGridView);
            this.groupBoxLastTransactions.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxLastTransactions.Location = new System.Drawing.Point(102, 200);
            this.groupBoxLastTransactions.Name = "groupBoxLastTransactions";
            this.groupBoxLastTransactions.Size = new System.Drawing.Size(1072, 426);
            this.groupBoxLastTransactions.TabIndex = 5;
            this.groupBoxLastTransactions.TabStop = false;
            this.groupBoxLastTransactions.Text = "Son Hareketler";
            // 
            // lastTransactionDataGridView
            // 
            this.lastTransactionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lastTransactionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.ClientCode,
            this.ClientName,
            this.ClientSurname,
            this.FirmDescription,
            this.Date_,
            this.TotalPrice,
            this.Module});
            this.lastTransactionDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lastTransactionDataGridView.Location = new System.Drawing.Point(3, 23);
            this.lastTransactionDataGridView.Name = "lastTransactionDataGridView";
            this.lastTransactionDataGridView.ReadOnly = true;
            this.lastTransactionDataGridView.Size = new System.Drawing.Size(1066, 400);
            this.lastTransactionDataGridView.TabIndex = 0;
            this.lastTransactionDataGridView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lastTransactionDataGridView_MouseClick);
            this.lastTransactionDataGridView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lastTransactionDataGridView_MouseDown);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // ClientCode
            // 
            this.ClientCode.DataPropertyName = "ClientCode";
            this.ClientCode.HeaderText = "Cari Kodu";
            this.ClientCode.Name = "ClientCode";
            this.ClientCode.ReadOnly = true;
            // 
            // ClientName
            // 
            this.ClientName.DataPropertyName = "ClientName";
            this.ClientName.HeaderText = "Cari Adı";
            this.ClientName.Name = "ClientName";
            this.ClientName.ReadOnly = true;
            // 
            // ClientSurname
            // 
            this.ClientSurname.DataPropertyName = "ClientSurname";
            this.ClientSurname.HeaderText = "Cari Soyad";
            this.ClientSurname.Name = "ClientSurname";
            this.ClientSurname.ReadOnly = true;
            // 
            // FirmDescription
            // 
            this.FirmDescription.DataPropertyName = "FirmDescription";
            this.FirmDescription.HeaderText = "Firma";
            this.FirmDescription.Name = "FirmDescription";
            this.FirmDescription.ReadOnly = true;
            // 
            // Date_
            // 
            this.Date_.DataPropertyName = "Date_";
            this.Date_.HeaderText = "Tarih";
            this.Date_.Name = "Date_";
            this.Date_.ReadOnly = true;
            // 
            // TotalPrice
            // 
            this.TotalPrice.DataPropertyName = "TotalPrice";
            this.TotalPrice.HeaderText = "Toplam Fiyat";
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.ReadOnly = true;
            // 
            // Module
            // 
            this.Module.DataPropertyName = "Module";
            this.Module.HeaderText = "Modül";
            this.Module.Name = "Module";
            this.Module.ReadOnly = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRefresh.Location = new System.Drawing.Point(1094, 132);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(77, 48);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Yenile";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(459, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 28);
            this.label1.TabIndex = 8;
            this.label1.Text = "BAHAR TOPTAN TEKSTIL";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnClients);
            this.groupBox2.Controls.Add(this.btnProducts);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(105, 96);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(144, 84);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tanımlar";
            // 
            // btnClients
            // 
            this.btnClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnClients.Location = new System.Drawing.Point(6, 19);
            this.btnClients.Name = "btnClients";
            this.btnClients.Size = new System.Drawing.Size(62, 59);
            this.btnClients.TabIndex = 2;
            this.btnClients.Text = "Cariler";
            this.btnClients.UseVisualStyleBackColor = true;
            this.btnClients.Click += new System.EventHandler(this.btnClients_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnProducts.Location = new System.Drawing.Point(74, 19);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(62, 59);
            this.btnProducts.TabIndex = 3;
            this.btnProducts.Text = "Ürünler";
            this.btnProducts.UseVisualStyleBackColor = true;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnStockAmount);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(464, 96);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(90, 84);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Raporlar";
            // 
            // lastTransactionGridViewContextMenuStrip
            // 
            this.lastTransactionGridViewContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem,
            this.modifyToolStripMenuItem,
            this.printToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.lastTransactionGridViewContextMenuStrip.Name = "contextMenuStrip1";
            this.lastTransactionGridViewContextMenuStrip.Size = new System.Drawing.Size(115, 92);
            this.lastTransactionGridViewContextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.lastTransactionGridViewContextMenuStrip_Opening);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.viewToolStripMenuItem.Text = "İncele";
            this.viewToolStripMenuItem.Click += new System.EventHandler(this.viewToolStripMenuItem_Click);
            // 
            // modifyToolStripMenuItem
            // 
            this.modifyToolStripMenuItem.Name = "modifyToolStripMenuItem";
            this.modifyToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.modifyToolStripMenuItem.Text = "Değiştir";
            this.modifyToolStripMenuItem.Click += new System.EventHandler(this.modifyToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.printToolStripMenuItem.Text = "Yazdır";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.deleteToolStripMenuItem.Text = "Sil";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // backuoGroupBox
            // 
            this.backuoGroupBox.Controls.Add(this.btnBackup);
            this.backuoGroupBox.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.backuoGroupBox.Location = new System.Drawing.Point(560, 96);
            this.backuoGroupBox.Name = "backuoGroupBox";
            this.backuoGroupBox.Size = new System.Drawing.Size(105, 84);
            this.backuoGroupBox.TabIndex = 12;
            this.backuoGroupBox.TabStop = false;
            this.backuoGroupBox.Text = "Yedekleme";
            // 
            // btnBackup
            // 
            this.btnBackup.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBackup.Location = new System.Drawing.Point(7, 19);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(92, 58);
            this.btnBackup.TabIndex = 0;
            this.btnBackup.Text = "Yedek Al";
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 638);
            this.Controls.Add(this.backuoGroupBox);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.groupBoxLastTransactions);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Sayfa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBoxLastTransactions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lastTransactionDataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.lastTransactionGridViewContextMenuStrip.ResumeLayout(false);
            this.backuoGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnQuickSales;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPurchasing;
        private System.Windows.Forms.GroupBox groupBoxLastTransactions;
        private System.Windows.Forms.DataGridView lastTransactionDataGridView;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStockAmount;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnClients;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ContextMenuStrip lastTransactionGridViewContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirmDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Module;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.GroupBox backuoGroupBox;
        private System.Windows.Forms.Button btnBackup;
    }
}