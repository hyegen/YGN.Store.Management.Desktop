namespace YGN.Store.Management.UI.Report
{
    partial class PrintOrderSlip
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.txtOrderId = new System.Windows.Forms.TextBox();
            this.btnPrintOrderDetail = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "YGN.Store.Management.UI.Report.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 77);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(853, 689);
            this.reportViewer1.TabIndex = 0;
            // 
            // txtOrderId
            // 
            this.txtOrderId.Location = new System.Drawing.Point(203, 30);
            this.txtOrderId.Name = "txtOrderId";
            this.txtOrderId.Size = new System.Drawing.Size(115, 20);
            this.txtOrderId.TabIndex = 1;
            this.txtOrderId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtOrderId_KeyDown);
            // 
            // btnPrintOrderDetail
            // 
            this.btnPrintOrderDetail.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPrintOrderDetail.Location = new System.Drawing.Point(346, 27);
            this.btnPrintOrderDetail.Name = "btnPrintOrderDetail";
            this.btnPrintOrderDetail.Size = new System.Drawing.Size(124, 26);
            this.btnPrintOrderDetail.TabIndex = 2;
            this.btnPrintOrderDetail.Text = "Yazdır";
            this.btnPrintOrderDetail.UseVisualStyleBackColor = true;
            this.btnPrintOrderDetail.Click += new System.EventHandler(this.btnPrintOrderDetail_Click);
            // 
            // PrintOrderSlip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 748);
            this.Controls.Add(this.btnPrintOrderDetail);
            this.Controls.Add(this.txtOrderId);
            this.Controls.Add(this.reportViewer1);
            this.Name = "PrintOrderSlip";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sipariş Fişi - Yazdır";
            this.Load += new System.EventHandler(this.PrintOrderSlip_Load);
            this.Shown += new System.EventHandler(this.PrintOrderSlip_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.TextBox txtOrderId;
        private System.Windows.Forms.Button btnPrintOrderDetail;
    }
}