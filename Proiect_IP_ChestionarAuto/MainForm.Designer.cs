namespace Proiect_IP_ChestionarAuto
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
            this.btnStart = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panelAdmin = new System.Windows.Forms.Panel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblAdminZone = new System.Windows.Forms.Label();
            this.panelAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(451, 99);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(193, 112);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Incepe";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(451, 217);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(193, 110);
            this.btnAbout.TabIndex = 1;
            this.btnAbout.Text = "Despre";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(451, 333);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(193, 110);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Iesire";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panelAdmin
            // 
            this.panelAdmin.Controls.Add(this.btnLogin);
            this.panelAdmin.Controls.Add(this.textBoxPassword);
            this.panelAdmin.Controls.Add(this.lblPassword);
            this.panelAdmin.Controls.Add(this.lblAdminZone);
            this.panelAdmin.Location = new System.Drawing.Point(766, 99);
            this.panelAdmin.Name = "panelAdmin";
            this.panelAdmin.Size = new System.Drawing.Size(220, 153);
            this.panelAdmin.TabIndex = 3;
            // 
            // btnLogin
            // 
            this.btnLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogin.Location = new System.Drawing.Point(0, 76);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(220, 50);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxPassword.Location = new System.Drawing.Point(0, 54);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(220, 22);
            this.textBoxPassword.TabIndex = 2;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPassword.Location = new System.Drawing.Point(0, 17);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Padding = new System.Windows.Forms.Padding(10);
            this.lblPassword.Size = new System.Drawing.Size(93, 37);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password:";
            // 
            // lblAdminZone
            // 
            this.lblAdminZone.AutoSize = true;
            this.lblAdminZone.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAdminZone.Location = new System.Drawing.Point(0, 0);
            this.lblAdminZone.Name = "lblAdminZone";
            this.lblAdminZone.Size = new System.Drawing.Size(84, 17);
            this.lblAdminZone.TabIndex = 0;
            this.lblAdminZone.Text = "Admin Zone";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 630);
            this.Controls.Add(this.panelAdmin);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnStart);
            this.Name = "MainForm";
            this.Text = "Chestionar Auto";
            this.panelAdmin.ResumeLayout(false);
            this.panelAdmin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panelAdmin;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblAdminZone;
    }
}

