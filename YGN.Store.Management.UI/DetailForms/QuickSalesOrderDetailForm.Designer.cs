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
            this.txtLastPrice = new System.Windows.Forms.TextBox();
            this.selectedItemsGroupBox = new System.Windows.Forms.GroupBox();
            this.selectedItemsDataGridView = new System.Windows.Forms.DataGridView();
            this.selectItemGroupBox = new System.Windows.Forms.GroupBox();
            this.itemsDataGridView = new System.Windows.Forms.DataGridView();
            this.lblLastPrice = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.selectedItemsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectedItemsDataGridView)).BeginInit();
            this.selectItemGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1680, 64);
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
            this.panel2.Controls.Add(this.lblLastPrice);
            this.panel2.Controls.Add(this.txtLastPrice);
            this.panel2.Controls.Add(this.selectedItemsGroupBox);
            this.panel2.Controls.Add(this.selectItemGroupBox);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panel2.Location = new System.Drawing.Point(12, 82);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1680, 706);
            this.panel2.TabIndex = 1;
            // 
            // txtLastPrice
            // 
            this.txtLastPrice.Enabled = false;
            this.txtLastPrice.Location = new System.Drawing.Point(1549, 218);
            this.txtLastPrice.Name = "txtLastPrice";
            this.txtLastPrice.Size = new System.Drawing.Size(100, 22);
            this.txtLastPrice.TabIndex = 2;
            // 
            // selectedItemsGroupBox
            // 
            this.selectedItemsGroupBox.Controls.Add(this.selectedItemsDataGridView);
            this.selectedItemsGroupBox.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.selectedItemsGroupBox.Location = new System.Drawing.Point(733, 199);
            this.selectedItemsGroupBox.Name = "selectedItemsGroupBox";
            this.selectedItemsGroupBox.Size = new System.Drawing.Size(803, 507);
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
            this.selectedItemsDataGridView.Size = new System.Drawing.Size(797, 483);
            this.selectedItemsDataGridView.TabIndex = 0;
            this.selectedItemsDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.selectedItemsDataGridView_CellEndEdit);
            // 
            // selectItemGroupBox
            // 
            this.selectItemGroupBox.Controls.Add(this.itemsDataGridView);
            this.selectItemGroupBox.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.selectItemGroupBox.Location = new System.Drawing.Point(3, 199);
            this.selectItemGroupBox.Name = "selectItemGroupBox";
            this.selectItemGroupBox.Size = new System.Drawing.Size(708, 501);
            this.selectItemGroupBox.TabIndex = 0;
            this.selectItemGroupBox.TabStop = false;
            this.selectItemGroupBox.Text = "Ürün - Seç";
            // 
            // itemsDataGridView
            // 
            this.itemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemsDataGridView.Location = new System.Drawing.Point(3, 21);
            this.itemsDataGridView.Name = "itemsDataGridView";
            this.itemsDataGridView.Size = new System.Drawing.Size(702, 477);
            this.itemsDataGridView.TabIndex = 0;
            this.itemsDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.itemsDataGridView_CellDoubleClick);
            // 
            // lblLastPrice
            // 
            this.lblLastPrice.AutoSize = true;
            this.lblLastPrice.Location = new System.Drawing.Point(1556, 190);
            this.lblLastPrice.Name = "lblLastPrice";
            this.lblLastPrice.Size = new System.Drawing.Size(86, 16);
            this.lblLastPrice.TabIndex = 3;
            this.lblLastPrice.Text = "Toplam Fiyat";
            // 
            // QuickSalesOrderDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1704, 816);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "QuickSalesOrderDetailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hızlı Satış";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.selectedItemsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.selectedItemsDataGridView)).EndInit();
            this.selectItemGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.itemsDataGridView)).EndInit();
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
        private System.Windows.Forms.TextBox txtLastPrice;
        private System.Windows.Forms.Label lblLastPrice;
    }
}