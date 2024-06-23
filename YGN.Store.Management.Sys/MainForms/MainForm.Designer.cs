namespace YGN.Store.Management.Sys.MainForms
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDatabaseSettings = new System.Windows.Forms.Button();
            this.btnMailSettings = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtServerDescription = new System.Windows.Forms.TextBox();
            this.lblServer = new System.Windows.Forms.Label();
            this.txtDatabaseUserName = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtIpAddress = new System.Windows.Forms.TextBox();
            this.txtDatabasePassword = new System.Windows.Forms.TextBox();
            this.txtDatabaseName = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblIpAddress = new System.Windows.Forms.Label();
            this.lblDatabaseDescription = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDatabaseSettings);
            this.panel1.Controls.Add(this.btnMailSettings);
            this.panel1.Location = new System.Drawing.Point(14, 14);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(484, 76);
            this.panel1.TabIndex = 0;
            // 
            // btnDatabaseSettings
            // 
            this.btnDatabaseSettings.Location = new System.Drawing.Point(4, 3);
            this.btnDatabaseSettings.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDatabaseSettings.Name = "btnDatabaseSettings";
            this.btnDatabaseSettings.Size = new System.Drawing.Size(88, 69);
            this.btnDatabaseSettings.TabIndex = 1;
            this.btnDatabaseSettings.Text = "Veritabanı Yapılandırma";
            this.btnDatabaseSettings.UseVisualStyleBackColor = true;
            this.btnDatabaseSettings.Click += new System.EventHandler(this.btnDatabaseSettings_Click);
            // 
            // btnMailSettings
            // 
            this.btnMailSettings.Location = new System.Drawing.Point(98, 3);
            this.btnMailSettings.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnMailSettings.Name = "btnMailSettings";
            this.btnMailSettings.Size = new System.Drawing.Size(88, 69);
            this.btnMailSettings.TabIndex = 0;
            this.btnMailSettings.Text = "Mail Ayarları";
            this.btnMailSettings.UseVisualStyleBackColor = true;
            this.btnMailSettings.Click += new System.EventHandler(this.btnMailSettings_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtServerDescription);
            this.groupBox1.Controls.Add(this.lblServer);
            this.groupBox1.Controls.Add(this.txtDatabaseUserName);
            this.groupBox1.Controls.Add(this.lblUserName);
            this.groupBox1.Controls.Add(this.txtIpAddress);
            this.groupBox1.Controls.Add(this.txtDatabasePassword);
            this.groupBox1.Controls.Add(this.txtDatabaseName);
            this.groupBox1.Controls.Add(this.lblPassword);
            this.groupBox1.Controls.Add(this.lblIpAddress);
            this.groupBox1.Controls.Add(this.lblDatabaseDescription);
            this.groupBox1.Location = new System.Drawing.Point(14, 96);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(484, 197);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bilgiler";
            // 
            // txtServerDescription
            // 
            this.txtServerDescription.Enabled = false;
            this.txtServerDescription.Location = new System.Drawing.Point(189, 20);
            this.txtServerDescription.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtServerDescription.Name = "txtServerDescription";
            this.txtServerDescription.ReadOnly = true;
            this.txtServerDescription.Size = new System.Drawing.Size(261, 21);
            this.txtServerDescription.TabIndex = 13;
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.Location = new System.Drawing.Point(21, 23);
            this.lblServer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(52, 15);
            this.lblServer.TabIndex = 12;
            this.lblServer.Text = "Sunucu:";
            // 
            // txtDatabaseUserName
            // 
            this.txtDatabaseUserName.BackColor = System.Drawing.SystemColors.Control;
            this.txtDatabaseUserName.Enabled = false;
            this.txtDatabaseUserName.Location = new System.Drawing.Point(189, 56);
            this.txtDatabaseUserName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDatabaseUserName.Name = "txtDatabaseUserName";
            this.txtDatabaseUserName.ReadOnly = true;
            this.txtDatabaseUserName.Size = new System.Drawing.Size(261, 21);
            this.txtDatabaseUserName.TabIndex = 9;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(21, 59);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(135, 15);
            this.lblUserName.TabIndex = 6;
            this.lblUserName.Text = "Veritabanı Kullanıcı Adı:";
            // 
            // txtIpAddress
            // 
            this.txtIpAddress.Enabled = false;
            this.txtIpAddress.Location = new System.Drawing.Point(189, 164);
            this.txtIpAddress.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtIpAddress.Name = "txtIpAddress";
            this.txtIpAddress.ReadOnly = true;
            this.txtIpAddress.Size = new System.Drawing.Size(261, 21);
            this.txtIpAddress.TabIndex = 11;
            // 
            // txtDatabasePassword
            // 
            this.txtDatabasePassword.Enabled = false;
            this.txtDatabasePassword.Location = new System.Drawing.Point(189, 92);
            this.txtDatabasePassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDatabasePassword.Name = "txtDatabasePassword";
            this.txtDatabasePassword.PasswordChar = '*';
            this.txtDatabasePassword.ReadOnly = true;
            this.txtDatabasePassword.Size = new System.Drawing.Size(261, 21);
            this.txtDatabasePassword.TabIndex = 10;
            // 
            // txtDatabaseName
            // 
            this.txtDatabaseName.Enabled = false;
            this.txtDatabaseName.Location = new System.Drawing.Point(189, 128);
            this.txtDatabaseName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDatabaseName.Name = "txtDatabaseName";
            this.txtDatabaseName.ReadOnly = true;
            this.txtDatabaseName.Size = new System.Drawing.Size(261, 21);
            this.txtDatabaseName.TabIndex = 8;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(21, 95);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(102, 15);
            this.lblPassword.TabIndex = 7;
            this.lblPassword.Text = "Veritabanı Şifresi:";
            // 
            // lblIpAddress
            // 
            this.lblIpAddress.AutoSize = true;
            this.lblIpAddress.Location = new System.Drawing.Point(21, 167);
            this.lblIpAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIpAddress.Name = "lblIpAddress";
            this.lblIpAddress.Size = new System.Drawing.Size(97, 15);
            this.lblIpAddress.TabIndex = 5;
            this.lblIpAddress.Text = "Mevcut IP Adres:";
            // 
            // lblDatabaseDescription
            // 
            this.lblDatabaseDescription.AutoSize = true;
            this.lblDatabaseDescription.Location = new System.Drawing.Point(21, 131);
            this.lblDatabaseDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDatabaseDescription.Name = "lblDatabaseDescription";
            this.lblDatabaseDescription.Size = new System.Drawing.Size(65, 15);
            this.lblDatabaseDescription.TabIndex = 4;
            this.lblDatabaseDescription.Text = "Veritabanı:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 304);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ayarlar";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDatabaseSettings;
        private System.Windows.Forms.Button btnMailSettings;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblIpAddress;
        private System.Windows.Forms.Label lblDatabaseDescription;
        private System.Windows.Forms.TextBox txtIpAddress;
        private System.Windows.Forms.TextBox txtDatabasePassword;
        private System.Windows.Forms.TextBox txtDatabaseUserName;
        private System.Windows.Forms.TextBox txtDatabaseName;
        private System.Windows.Forms.TextBox txtServerDescription;
        private System.Windows.Forms.Label lblServer;
    }
}