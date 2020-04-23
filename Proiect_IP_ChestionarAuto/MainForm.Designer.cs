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
            this.lblPassword = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.groupBoxAdmin = new System.Windows.Forms.GroupBox();
            this.groupBoxCategory = new System.Windows.Forms.GroupBox();
            this.rbCatB = new System.Windows.Forms.RadioButton();
            this.rbCatC = new System.Windows.Forms.RadioButton();
            this.groupBoxAdmin.SuspendLayout();
            this.groupBoxCategory.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(70, 373);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(230, 112);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Incepe";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(70, 514);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(230, 110);
            this.btnAbout.TabIndex = 1;
            this.btnAbout.Text = "Despre";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(949, 514);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(230, 110);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Iesire";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(6, 30);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Padding = new System.Windows.Forms.Padding(10);
            this.lblPassword.Size = new System.Drawing.Size(93, 37);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password:";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(105, 39);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(101, 22);
            this.textBoxPassword.TabIndex = 2;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(105, 100);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(101, 40);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // groupBoxAdmin
            // 
            this.groupBoxAdmin.Controls.Add(this.lblPassword);
            this.groupBoxAdmin.Controls.Add(this.btnLogin);
            this.groupBoxAdmin.Controls.Add(this.textBoxPassword);
            this.groupBoxAdmin.Location = new System.Drawing.Point(70, 59);
            this.groupBoxAdmin.Name = "groupBoxAdmin";
            this.groupBoxAdmin.Size = new System.Drawing.Size(230, 164);
            this.groupBoxAdmin.TabIndex = 4;
            this.groupBoxAdmin.TabStop = false;
            this.groupBoxAdmin.Text = "Admin Zone";
            // 
            // groupBoxCategory
            // 
            this.groupBoxCategory.Controls.Add(this.rbCatC);
            this.groupBoxCategory.Controls.Add(this.rbCatB);
            this.groupBoxCategory.Location = new System.Drawing.Point(70, 250);
            this.groupBoxCategory.Name = "groupBoxCategory";
            this.groupBoxCategory.Size = new System.Drawing.Size(237, 93);
            this.groupBoxCategory.TabIndex = 5;
            this.groupBoxCategory.TabStop = false;
            this.groupBoxCategory.Text = "Categorie";
            // 
            // rbCatB
            // 
            this.rbCatB.AutoSize = true;
            this.rbCatB.Checked = true;
            this.rbCatB.Location = new System.Drawing.Point(7, 22);
            this.rbCatB.Name = "rbCatB";
            this.rbCatB.Size = new System.Drawing.Size(103, 21);
            this.rbCatB.TabIndex = 0;
            this.rbCatB.TabStop = true;
            this.rbCatB.Text = "Categoria B";
            this.rbCatB.UseVisualStyleBackColor = true;
            // 
            // rbCatC
            // 
            this.rbCatC.AutoSize = true;
            this.rbCatC.Enabled = false;
            this.rbCatC.Location = new System.Drawing.Point(7, 55);
            this.rbCatC.Name = "rbCatC";
            this.rbCatC.Size = new System.Drawing.Size(103, 21);
            this.rbCatC.TabIndex = 1;
            this.rbCatC.Text = "Categoria C";
            this.rbCatC.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.groupBoxCategory);
            this.Controls.Add(this.groupBoxAdmin);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnStart);
            this.Name = "MainForm";
            this.Text = "Chestionar Auto";
            this.groupBoxAdmin.ResumeLayout(false);
            this.groupBoxAdmin.PerformLayout();
            this.groupBoxCategory.ResumeLayout(false);
            this.groupBoxCategory.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.GroupBox groupBoxAdmin;
        private System.Windows.Forms.GroupBox groupBoxCategory;
        private System.Windows.Forms.RadioButton rbCatC;
        private System.Windows.Forms.RadioButton rbCatB;
    }
}

