namespace YGN.Store.Management.Sys.MailSetting
{
    partial class ReportsForm
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
            this.checkedListBoxReports = new System.Windows.Forms.CheckedListBox();
            this.txtParameters = new System.Windows.Forms.TextBox();
            this.groupBoxParameters = new System.Windows.Forms.GroupBox();
            this.lblParameter = new System.Windows.Forms.Label();
            this.reportsDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBoxParameters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reportsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(395, 87);
            this.panel1.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(88, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(79, 81);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Kapat";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(3, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(79, 81);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.checkedListBoxReports);
            this.panel2.Location = new System.Drawing.Point(12, 105);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(395, 327);
            this.panel2.TabIndex = 1;
            // 
            // checkedListBoxReports
            // 
            this.checkedListBoxReports.FormattingEnabled = true;
            this.checkedListBoxReports.Location = new System.Drawing.Point(3, 3);
            this.checkedListBoxReports.Name = "checkedListBoxReports";
            this.checkedListBoxReports.Size = new System.Drawing.Size(389, 319);
            this.checkedListBoxReports.TabIndex = 0;
            // 
            // txtParameters
            // 
            this.txtParameters.Location = new System.Drawing.Point(114, 19);
            this.txtParameters.Name = "txtParameters";
            this.txtParameters.Size = new System.Drawing.Size(412, 20);
            this.txtParameters.TabIndex = 2;
            // 
            // groupBoxParameters
            // 
            this.groupBoxParameters.Controls.Add(this.lblParameter);
            this.groupBoxParameters.Controls.Add(this.txtParameters);
            this.groupBoxParameters.Location = new System.Drawing.Point(15, 438);
            this.groupBoxParameters.Name = "groupBoxParameters";
            this.groupBoxParameters.Size = new System.Drawing.Size(544, 124);
            this.groupBoxParameters.TabIndex = 3;
            this.groupBoxParameters.TabStop = false;
            this.groupBoxParameters.Text = "Parametre - Oluştur";
            // 
            // lblParameter
            // 
            this.lblParameter.AutoSize = true;
            this.lblParameter.Location = new System.Drawing.Point(36, 22);
            this.lblParameter.Name = "lblParameter";
            this.lblParameter.Size = new System.Drawing.Size(58, 13);
            this.lblParameter.TabIndex = 3;
            this.lblParameter.Text = "Parametre:";
            // 
            // reportsDataGridView
            // 
            this.reportsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reportsDataGridView.Location = new System.Drawing.Point(413, 105);
            this.reportsDataGridView.Name = "reportsDataGridView";
            this.reportsDataGridView.Size = new System.Drawing.Size(388, 327);
            this.reportsDataGridView.TabIndex = 4;
            // 
            // ReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 590);
            this.Controls.Add(this.reportsDataGridView);
            this.Controls.Add(this.groupBoxParameters);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ReportsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Raporlar";
            this.Load += new System.EventHandler(this.ReportsForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBoxParameters.ResumeLayout(false);
            this.groupBoxParameters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reportsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckedListBox checkedListBoxReports;
        private System.Windows.Forms.TextBox txtParameters;
        private System.Windows.Forms.GroupBox groupBoxParameters;
        private System.Windows.Forms.Label lblParameter;
        private System.Windows.Forms.DataGridView reportsDataGridView;
    }
}