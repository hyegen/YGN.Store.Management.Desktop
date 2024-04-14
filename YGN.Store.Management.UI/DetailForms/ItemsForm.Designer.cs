namespace YGN.Store.Management.UI.DetailForms
{
    partial class ItemsForm
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
            this.lblCountOfItems = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.itemsDataGridView = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBrand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearchItem = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtItemCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.txtItemDescription = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.itemsGroupBox = new System.Windows.Forms.GroupBox();
            this.btnDeleteItem = new System.Windows.Forms.Button();
            this.btnUpdateItem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.itemsDataGridView)).BeginInit();
            this.itemsGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCountOfItems
            // 
            this.lblCountOfItems.AutoSize = true;
            this.lblCountOfItems.Location = new System.Drawing.Point(1015, 16);
            this.lblCountOfItems.Name = "lblCountOfItems";
            this.lblCountOfItems.Size = new System.Drawing.Size(19, 13);
            this.lblCountOfItems.TabIndex = 37;
            this.lblCountOfItems.Text = "??";
            this.lblCountOfItems.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(84, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Ürün Ara:";
            // 
            // itemsDataGridView
            // 
            this.itemsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.itemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colItemCode,
            this.colItemName,
            this.colUnitPrice,
            this.colBrand,
            this.colAmount});
            this.itemsDataGridView.Location = new System.Drawing.Point(6, 45);
            this.itemsDataGridView.Name = "itemsDataGridView";
            this.itemsDataGridView.ReadOnly = true;
            this.itemsDataGridView.Size = new System.Drawing.Size(1028, 386);
            this.itemsDataGridView.TabIndex = 10;
            this.itemsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.itemsDataGridView_CellClick);
            // 
            // colId
            // 
            this.colId.DataPropertyName = "Id";
            this.colId.HeaderText = "Id";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            // 
            // colItemCode
            // 
            this.colItemCode.DataPropertyName = "ItemCode";
            this.colItemCode.HeaderText = "Ürün Kodu";
            this.colItemCode.Name = "colItemCode";
            this.colItemCode.ReadOnly = true;
            // 
            // colItemName
            // 
            this.colItemName.DataPropertyName = "ItemName";
            this.colItemName.HeaderText = "Malzeme Açıklaması";
            this.colItemName.Name = "colItemName";
            this.colItemName.ReadOnly = true;
            // 
            // colUnitPrice
            // 
            this.colUnitPrice.DataPropertyName = "UnitPrice";
            this.colUnitPrice.HeaderText = "Birim Fiyat";
            this.colUnitPrice.Name = "colUnitPrice";
            this.colUnitPrice.ReadOnly = true;
            // 
            // colBrand
            // 
            this.colBrand.DataPropertyName = "Brand";
            this.colBrand.HeaderText = "Marka";
            this.colBrand.Name = "colBrand";
            this.colBrand.ReadOnly = true;
            // 
            // colAmount
            // 
            this.colAmount.DataPropertyName = "Amount";
            this.colAmount.HeaderText = "colAmount";
            this.colAmount.Name = "colAmount";
            this.colAmount.ReadOnly = true;
            // 
            // txtSearchItem
            // 
            this.txtSearchItem.Location = new System.Drawing.Point(137, 19);
            this.txtSearchItem.Name = "txtSearchItem";
            this.txtSearchItem.Size = new System.Drawing.Size(200, 20);
            this.txtSearchItem.TabIndex = 12;
            this.txtSearchItem.TextChanged += new System.EventHandler(this.txtSearchItem_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ürün Kodu";
            // 
            // txtItemCode
            // 
            this.txtItemCode.Location = new System.Drawing.Point(137, 24);
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.Size = new System.Drawing.Size(289, 20);
            this.txtItemCode.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Açıklaması";
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(467, 96);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(71, 44);
            this.btnAddItem.TabIndex = 34;
            this.btnAddItem.Text = "Ekle";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // txtItemDescription
            // 
            this.txtItemDescription.Location = new System.Drawing.Point(137, 54);
            this.txtItemDescription.Name = "txtItemDescription";
            this.txtItemDescription.Size = new System.Drawing.Size(289, 20);
            this.txtItemDescription.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(951, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "Ürün Sayısı:";
            // 
            // itemsGroupBox
            // 
            this.itemsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.itemsGroupBox.Controls.Add(this.label7);
            this.itemsGroupBox.Controls.Add(this.lblCountOfItems);
            this.itemsGroupBox.Controls.Add(this.txtSearchItem);
            this.itemsGroupBox.Controls.Add(this.label6);
            this.itemsGroupBox.Controls.Add(this.itemsDataGridView);
            this.itemsGroupBox.Location = new System.Drawing.Point(8, 336);
            this.itemsGroupBox.Name = "itemsGroupBox";
            this.itemsGroupBox.Size = new System.Drawing.Size(1040, 454);
            this.itemsGroupBox.TabIndex = 29;
            this.itemsGroupBox.TabStop = false;
            this.itemsGroupBox.Text = "Ürünler";
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.Location = new System.Drawing.Point(467, 184);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(71, 37);
            this.btnDeleteItem.TabIndex = 33;
            this.btnDeleteItem.Text = "Sil";
            this.btnDeleteItem.UseVisualStyleBackColor = true;
            this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
            // 
            // btnUpdateItem
            // 
            this.btnUpdateItem.Location = new System.Drawing.Point(467, 144);
            this.btnUpdateItem.Name = "btnUpdateItem";
            this.btnUpdateItem.Size = new System.Drawing.Size(71, 38);
            this.btnUpdateItem.TabIndex = 32;
            this.btnUpdateItem.Text = "Güncelle";
            this.btnUpdateItem.UseVisualStyleBackColor = true;
            this.btnUpdateItem.Click += new System.EventHandler(this.btnUpdateItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtUnitPrice);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtItemCode);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtItemDescription);
            this.groupBox1.Location = new System.Drawing.Point(8, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(453, 238);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ekle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Birim Fiyat";
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(137, 80);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(289, 20);
            this.txtUnitPrice.TabIndex = 11;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(3, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(54, 69);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Yenile";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(63, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(54, 69);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Kapat";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Location = new System.Drawing.Point(5, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1054, 75);
            this.panel1.TabIndex = 27;
            // 
            // ItemsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 801);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.itemsGroupBox);
            this.Controls.Add(this.btnDeleteItem);
            this.Controls.Add(this.btnUpdateItem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "ItemsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün";
            this.Load += new System.EventHandler(this.ItemsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.itemsDataGridView)).EndInit();
            this.itemsGroupBox.ResumeLayout(false);
            this.itemsGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCountOfItems;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView itemsDataGridView;
        private System.Windows.Forms.TextBox txtSearchItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtItemCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.TextBox txtItemDescription;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox itemsGroupBox;
        private System.Windows.Forms.Button btnDeleteItem;
        private System.Windows.Forms.Button btnUpdateItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBrand;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
    }
}