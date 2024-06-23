namespace YGN.Store.Management.Sys.MailSetting
{
    partial class MailSettingsForm
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
            this.btnStopMailService = new System.Windows.Forms.Button();
            this.btnStartMailService = new System.Windows.Forms.Button();
            this.btnUninstallMailService = new System.Windows.Forms.Button();
            this.btnSendMailReports = new System.Windows.Forms.Button();
            this.btnInstallMailService = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtSmtpServer = new System.Windows.Forms.TextBox();
            this.lblSmtpServer = new System.Windows.Forms.Label();
            this.sslCheckBox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtMailPassword = new System.Windows.Forms.TextBox();
            this.txtMailAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblServiceStatus = new System.Windows.Forms.Label();
            this.groupBoxMailServiceStatuses = new System.Windows.Forms.GroupBox();
            this.lblServiceStatusDescription = new System.Windows.Forms.Label();
            this.groupBoxInformation = new System.Windows.Forms.GroupBox();
            this.lblMailServiceImportantInformation = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBoxMailServiceStatuses.SuspendLayout();
            this.groupBoxInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnStopMailService);
            this.panel1.Controls.Add(this.btnStartMailService);
            this.panel1.Controls.Add(this.btnUninstallMailService);
            this.panel1.Controls.Add(this.btnSendMailReports);
            this.panel1.Controls.Add(this.btnInstallMailService);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(878, 85);
            this.panel1.TabIndex = 0;
            // 
            // btnStopMailService
            // 
            this.btnStopMailService.Location = new System.Drawing.Point(772, 5);
            this.btnStopMailService.Name = "btnStopMailService";
            this.btnStopMailService.Size = new System.Drawing.Size(76, 76);
            this.btnStopMailService.TabIndex = 11;
            this.btnStopMailService.Text = "Mail Servisi Durdur";
            this.btnStopMailService.UseVisualStyleBackColor = true;
            this.btnStopMailService.Click += new System.EventHandler(this.btnStopMailService_Click);
            // 
            // btnStartMailService
            // 
            this.btnStartMailService.Location = new System.Drawing.Point(690, 5);
            this.btnStartMailService.Name = "btnStartMailService";
            this.btnStartMailService.Size = new System.Drawing.Size(76, 76);
            this.btnStartMailService.TabIndex = 10;
            this.btnStartMailService.Text = "Mail Servisi Başlat";
            this.btnStartMailService.UseVisualStyleBackColor = true;
            this.btnStartMailService.Click += new System.EventHandler(this.btnStartMailService_Click);
            // 
            // btnUninstallMailService
            // 
            this.btnUninstallMailService.Location = new System.Drawing.Point(529, 5);
            this.btnUninstallMailService.Name = "btnUninstallMailService";
            this.btnUninstallMailService.Size = new System.Drawing.Size(86, 76);
            this.btnUninstallMailService.TabIndex = 9;
            this.btnUninstallMailService.Text = "Mail Servis Kaldır";
            this.btnUninstallMailService.UseVisualStyleBackColor = true;
            this.btnUninstallMailService.Click += new System.EventHandler(this.btnUninstallMailService_Click);
            // 
            // btnSendMailReports
            // 
            this.btnSendMailReports.Location = new System.Drawing.Point(223, 5);
            this.btnSendMailReports.Name = "btnSendMailReports";
            this.btnSendMailReports.Size = new System.Drawing.Size(86, 77);
            this.btnSendMailReports.TabIndex = 9;
            this.btnSendMailReports.Text = "Raporlar";
            this.btnSendMailReports.UseVisualStyleBackColor = true;
            this.btnSendMailReports.Click += new System.EventHandler(this.btnSendMailReports_Click);
            // 
            // btnInstallMailService
            // 
            this.btnInstallMailService.Location = new System.Drawing.Point(437, 5);
            this.btnInstallMailService.Name = "btnInstallMailService";
            this.btnInstallMailService.Size = new System.Drawing.Size(86, 77);
            this.btnInstallMailService.TabIndex = 8;
            this.btnInstallMailService.Text = "Mail Servis Kur";
            this.btnInstallMailService.UseVisualStyleBackColor = true;
            this.btnInstallMailService.Click += new System.EventHandler(this.btnInstallMailService_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(4, 4);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 77);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtSmtpServer);
            this.panel2.Controls.Add(this.lblSmtpServer);
            this.panel2.Controls.Add(this.sslCheckBox);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtPort);
            this.panel2.Controls.Add(this.txtMailPassword);
            this.panel2.Controls.Add(this.txtMailAddress);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(13, 105);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(417, 215);
            this.panel2.TabIndex = 1;
            // 
            // txtSmtpServer
            // 
            this.txtSmtpServer.Location = new System.Drawing.Point(126, 26);
            this.txtSmtpServer.Name = "txtSmtpServer";
            this.txtSmtpServer.Size = new System.Drawing.Size(268, 23);
            this.txtSmtpServer.TabIndex = 1;
            // 
            // lblSmtpServer
            // 
            this.lblSmtpServer.AutoSize = true;
            this.lblSmtpServer.Location = new System.Drawing.Point(14, 29);
            this.lblSmtpServer.Name = "lblSmtpServer";
            this.lblSmtpServer.Size = new System.Drawing.Size(99, 17);
            this.lblSmtpServer.TabIndex = 8;
            this.lblSmtpServer.Text = "Smtp Sunucusu:";
            // 
            // sslCheckBox
            // 
            this.sslCheckBox.AutoSize = true;
            this.sslCheckBox.Location = new System.Drawing.Point(126, 178);
            this.sslCheckBox.Name = "sslCheckBox";
            this.sslCheckBox.Size = new System.Drawing.Size(15, 14);
            this.sslCheckBox.TabIndex = 5;
            this.sslCheckBox.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "SSL:";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(126, 135);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(72, 23);
            this.txtPort.TabIndex = 4;
            // 
            // txtMailPassword
            // 
            this.txtMailPassword.Location = new System.Drawing.Point(126, 100);
            this.txtMailPassword.Name = "txtMailPassword";
            this.txtMailPassword.PasswordChar = '*';
            this.txtMailPassword.Size = new System.Drawing.Size(268, 23);
            this.txtMailPassword.TabIndex = 3;
            // 
            // txtMailAddress
            // 
            this.txtMailAddress.Location = new System.Drawing.Point(126, 62);
            this.txtMailAddress.Name = "txtMailAddress";
            this.txtMailAddress.Size = new System.Drawing.Size(268, 23);
            this.txtMailAddress.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Port:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mail Adresi:";
            // 
            // lblServiceStatus
            // 
            this.lblServiceStatus.AutoSize = true;
            this.lblServiceStatus.Location = new System.Drawing.Point(11, 32);
            this.lblServiceStatus.Name = "lblServiceStatus";
            this.lblServiceStatus.Size = new System.Drawing.Size(95, 17);
            this.lblServiceStatus.TabIndex = 9;
            this.lblServiceStatus.Text = "Servis Durumu:";
            // 
            // groupBoxMailServiceStatuses
            // 
            this.groupBoxMailServiceStatuses.Controls.Add(this.lblServiceStatusDescription);
            this.groupBoxMailServiceStatuses.Controls.Add(this.lblServiceStatus);
            this.groupBoxMailServiceStatuses.Location = new System.Drawing.Point(436, 105);
            this.groupBoxMailServiceStatuses.Name = "groupBoxMailServiceStatuses";
            this.groupBoxMailServiceStatuses.Size = new System.Drawing.Size(284, 65);
            this.groupBoxMailServiceStatuses.TabIndex = 10;
            this.groupBoxMailServiceStatuses.TabStop = false;
            this.groupBoxMailServiceStatuses.Text = "Mail Servis Durum";
            // 
            // lblServiceStatusDescription
            // 
            this.lblServiceStatusDescription.AutoSize = true;
            this.lblServiceStatusDescription.Location = new System.Drawing.Point(121, 32);
            this.lblServiceStatusDescription.Name = "lblServiceStatusDescription";
            this.lblServiceStatusDescription.Size = new System.Drawing.Size(20, 17);
            this.lblServiceStatusDescription.TabIndex = 10;
            this.lblServiceStatusDescription.Text = "??";
            // 
            // groupBoxInformation
            // 
            this.groupBoxInformation.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxInformation.Controls.Add(this.lblMailServiceImportantInformation);
            this.groupBoxInformation.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBoxInformation.Location = new System.Drawing.Point(436, 263);
            this.groupBoxInformation.Name = "groupBoxInformation";
            this.groupBoxInformation.Size = new System.Drawing.Size(508, 57);
            this.groupBoxInformation.TabIndex = 11;
            this.groupBoxInformation.TabStop = false;
            this.groupBoxInformation.Text = "ÖNEMLİ BİLGİ";
            // 
            // lblMailServiceImportantInformation
            // 
            this.lblMailServiceImportantInformation.AutoSize = true;
            this.lblMailServiceImportantInformation.Location = new System.Drawing.Point(11, 26);
            this.lblMailServiceImportantInformation.Name = "lblMailServiceImportantInformation";
            this.lblMailServiceImportantInformation.Size = new System.Drawing.Size(478, 17);
            this.lblMailServiceImportantInformation.TabIndex = 0;
            this.lblMailServiceImportantInformation.Text = "* Mail Servis\'in kurulabilmesi için Sys\'nin yönetici olarak çalışması gerekmekted" +
    "ir.";
            // 
            // MailSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 332);
            this.Controls.Add(this.groupBoxInformation);
            this.Controls.Add(this.groupBoxMailServiceStatuses);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MailSettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mail - Ayarlar";
            this.Load += new System.EventHandler(this.MailSettingsForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBoxMailServiceStatuses.ResumeLayout(false);
            this.groupBoxMailServiceStatuses.PerformLayout();
            this.groupBoxInformation.ResumeLayout(false);
            this.groupBoxInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtMailPassword;
        private System.Windows.Forms.TextBox txtMailAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox sslCheckBox;
        private System.Windows.Forms.Button btnInstallMailService;
        private System.Windows.Forms.TextBox txtSmtpServer;
        private System.Windows.Forms.Label lblSmtpServer;
        private System.Windows.Forms.Button btnSendMailReports;
        private System.Windows.Forms.Button btnUninstallMailService;
        private System.Windows.Forms.Label lblServiceStatus;
        private System.Windows.Forms.GroupBox groupBoxMailServiceStatuses;
        private System.Windows.Forms.Label lblServiceStatusDescription;
        private System.Windows.Forms.Button btnStopMailService;
        private System.Windows.Forms.Button btnStartMailService;
        private System.Windows.Forms.GroupBox groupBoxInformation;
        private System.Windows.Forms.Label lblMailServiceImportantInformation;
    }
}