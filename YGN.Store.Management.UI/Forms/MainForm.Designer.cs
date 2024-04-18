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
            this.btnClients = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnQuickSales = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPurchasing = new System.Windows.Forms.Button();
            this.groupBoxLastTransactions = new System.Windows.Forms.GroupBox();
            this.lastTransactionDataGridView = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBoxLastTransactions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lastTransactionDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClients
            // 
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
            this.btnQuickSales.Location = new System.Drawing.Point(156, 19);
            this.btnQuickSales.Name = "btnQuickSales";
            this.btnQuickSales.Size = new System.Drawing.Size(62, 48);
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
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 84);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İşlemler";
            // 
            // btnPurchasing
            // 
            this.btnPurchasing.Location = new System.Drawing.Point(224, 19);
            this.btnPurchasing.Name = "btnPurchasing";
            this.btnPurchasing.Size = new System.Drawing.Size(62, 48);
            this.btnPurchasing.TabIndex = 3;
            this.btnPurchasing.Text = "Satınalma";
            this.btnPurchasing.UseVisualStyleBackColor = true;
            // 
            // groupBoxLastTransactions
            // 
            this.groupBoxLastTransactions.Controls.Add(this.lastTransactionDataGridView);
            this.groupBoxLastTransactions.Location = new System.Drawing.Point(12, 102);
            this.groupBoxLastTransactions.Name = "groupBoxLastTransactions";
            this.groupBoxLastTransactions.Size = new System.Drawing.Size(1072, 426);
            this.groupBoxLastTransactions.TabIndex = 5;
            this.groupBoxLastTransactions.TabStop = false;
            this.groupBoxLastTransactions.Text = "Son Hareketler";
            // 
            // lastTransactionDataGridView
            // 
            this.lastTransactionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lastTransactionDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lastTransactionDataGridView.Location = new System.Drawing.Point(3, 16);
            this.lastTransactionDataGridView.Name = "lastTransactionDataGridView";
            this.lastTransactionDataGridView.Size = new System.Drawing.Size(1066, 407);
            this.lastTransactionDataGridView.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(321, 73);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Yenile";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 540);
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
    }
}