﻿namespace YGN.Store.Management.UI.Forms
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
            this.btnClients = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnQuickSales = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPurchasing = new System.Windows.Forms.Button();
            this.groupBoxLastTransactions = new System.Windows.Forms.GroupBox();
            this.lastTransactionDataGridView = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnCreateOrderSlip = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirmDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Module = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBoxLastTransactions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lastTransactionDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClients
            // 
            this.btnClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnClients.Location = new System.Drawing.Point(20, 19);
            this.btnClients.Name = "btnClients";
            this.btnClients.Size = new System.Drawing.Size(62, 48);
            this.btnClients.TabIndex = 0;
            this.btnClients.Text = "Cariler";
            this.btnClients.UseVisualStyleBackColor = true;
            this.btnClients.Click += new System.EventHandler(this.btnClients_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnProducts.Location = new System.Drawing.Point(88, 19);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(62, 48);
            this.btnProducts.TabIndex = 1;
            this.btnProducts.Text = "Ürünler";
            this.btnProducts.UseVisualStyleBackColor = true;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // btnQuickSales
            // 
            this.btnQuickSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnQuickSales.Location = new System.Drawing.Point(156, 20);
            this.btnQuickSales.Name = "btnQuickSales";
            this.btnQuickSales.Size = new System.Drawing.Size(78, 48);
            this.btnQuickSales.TabIndex = 2;
            this.btnQuickSales.Text = "Hızlı Satış";
            this.btnQuickSales.UseVisualStyleBackColor = true;
            this.btnQuickSales.Click += new System.EventHandler(this.btnQuickSales_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPurchasing);
            this.groupBox1.Controls.Add(this.btnQuickSales);
            this.groupBox1.Controls.Add(this.btnClients);
            this.groupBox1.Controls.Add(this.btnProducts);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(105, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 84);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İşlemler";
            // 
            // btnPurchasing
            // 
            this.btnPurchasing.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPurchasing.Location = new System.Drawing.Point(240, 20);
            this.btnPurchasing.Name = "btnPurchasing";
            this.btnPurchasing.Size = new System.Drawing.Size(78, 48);
            this.btnPurchasing.TabIndex = 3;
            this.btnPurchasing.Text = "Satınalma";
            this.btnPurchasing.UseVisualStyleBackColor = true;
            this.btnPurchasing.Click += new System.EventHandler(this.btnPurchasing_Click);
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
            this.lastTransactionDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.lastTransactionDataGridView_CellDoubleClick);
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
            // btnCreateOrderSlip
            // 
            this.btnCreateOrderSlip.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCreateOrderSlip.Location = new System.Drawing.Point(575, 132);
            this.btnCreateOrderSlip.Name = "btnCreateOrderSlip";
            this.btnCreateOrderSlip.Size = new System.Drawing.Size(261, 46);
            this.btnCreateOrderSlip.TabIndex = 7;
            this.btnCreateOrderSlip.Text = "Sipariş Fişi Yazdır";
            this.btnCreateOrderSlip.UseVisualStyleBackColor = true;
            this.btnCreateOrderSlip.Click += new System.EventHandler(this.btnCreateOrderSlip_Click);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 638);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCreateOrderSlip);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.groupBoxLastTransactions);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Sayfa";
            this.groupBox1.ResumeLayout(false);
            this.groupBoxLastTransactions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lastTransactionDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClients;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnQuickSales;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPurchasing;
        private System.Windows.Forms.GroupBox groupBoxLastTransactions;
        private System.Windows.Forms.DataGridView lastTransactionDataGridView;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnCreateOrderSlip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirmDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Module;
    }
}