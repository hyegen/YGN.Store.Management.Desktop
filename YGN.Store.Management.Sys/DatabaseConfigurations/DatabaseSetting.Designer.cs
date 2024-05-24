namespace YGN.Store.Management.Sys.DatabaseConfigurations
{
    partial class DatabaseSetting
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtDatabaseName = new System.Windows.Forms.TextBox();
            this.txtDatabaseUsername = new System.Windows.Forms.TextBox();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.lblDatabaseName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblDatabaseUsername = new System.Windows.Forms.Label();
            this.lblServer = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(490, 67);
            this.panel1.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(92, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(83, 61);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Kapat";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(3, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(83, 61);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.txtDatabaseName);
            this.groupBox1.Controls.Add(this.txtDatabaseUsername);
            this.groupBox1.Controls.Add(this.txtServer);
            this.groupBox1.Controls.Add(this.lblDatabaseName);
            this.groupBox1.Controls.Add(this.lblPassword);
            this.groupBox1.Controls.Add(this.lblDatabaseUsername);
            this.groupBox1.Controls.Add(this.lblServer);
            this.groupBox1.Location = new System.Drawing.Point(12, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(490, 144);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Veritabanı Ayarla";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(169, 82);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(281, 20);
            this.txtPassword.TabIndex = 7;
            // 
            // txtDatabaseName
            // 
            this.txtDatabaseName.Location = new System.Drawing.Point(169, 110);
            this.txtDatabaseName.Name = "txtDatabaseName";
            this.txtDatabaseName.Size = new System.Drawing.Size(281, 20);
            this.txtDatabaseName.TabIndex = 6;
            // 
            // txtDatabaseUsername
            // 
            this.txtDatabaseUsername.Location = new System.Drawing.Point(169, 54);
            this.txtDatabaseUsername.Name = "txtDatabaseUsername";
            this.txtDatabaseUsername.Size = new System.Drawing.Size(281, 20);
            this.txtDatabaseUsername.TabIndex = 5;
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(169, 26);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(281, 20);
            this.txtServer.TabIndex = 4;
            // 
            // lblDatabaseName
            // 
            this.lblDatabaseName.AutoSize = true;
            this.lblDatabaseName.Location = new System.Drawing.Point(18, 113);
            this.lblDatabaseName.Name = "lblDatabaseName";
            this.lblDatabaseName.Size = new System.Drawing.Size(57, 13);
            this.lblDatabaseName.TabIndex = 3;
            this.lblDatabaseName.Text = "Veritabanı:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(18, 85);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(88, 13);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Veritabanı Şifresi:";
            // 
            // lblDatabaseUsername
            // 
            this.lblDatabaseUsername.AutoSize = true;
            this.lblDatabaseUsername.Location = new System.Drawing.Point(18, 57);
            this.lblDatabaseUsername.Name = "lblDatabaseUsername";
            this.lblDatabaseUsername.Size = new System.Drawing.Size(117, 13);
            this.lblDatabaseUsername.TabIndex = 1;
            this.lblDatabaseUsername.Text = "Veritabanı Kullanıcı Adı:";
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.Location = new System.Drawing.Point(18, 29);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(47, 13);
            this.lblServer.TabIndex = 0;
            this.lblServer.Text = "Sunucu:";
            // 
            // DatabaseSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 249);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "DatabaseSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Veritabanı Ayarları";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtDatabaseName;
        private System.Windows.Forms.TextBox txtDatabaseUsername;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.Label lblDatabaseName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblDatabaseUsername;
        private System.Windows.Forms.Label lblServer;
    }
}