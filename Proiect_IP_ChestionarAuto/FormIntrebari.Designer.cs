namespace Proiect_IP_ChestionarAuto
{
    partial class FormIntrebari
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
            this.pictureBoxIntrebari = new System.Windows.Forms.PictureBox();
            this.labelIntrebari = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button_Back = new System.Windows.Forms.Button();
            this.button_Next = new System.Windows.Forms.Button();
            this.label_A = new System.Windows.Forms.Label();
            this.label_B = new System.Windows.Forms.Label();
            this.label_C = new System.Windows.Forms.Label();
            this.label_lrc = new System.Windows.Forms.Label();
            this.label_rasp_corecte = new System.Windows.Forms.Label();
            this.label_lrg = new System.Windows.Forms.Label();
            this.label_rasp_gresite = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIntrebari)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxIntrebari
            // 
            this.pictureBoxIntrebari.Location = new System.Drawing.Point(382, 104);
            this.pictureBoxIntrebari.Name = "pictureBoxIntrebari";
            this.pictureBoxIntrebari.Size = new System.Drawing.Size(757, 391);
            this.pictureBoxIntrebari.TabIndex = 0;
            this.pictureBoxIntrebari.TabStop = false;
            // 
            // labelIntrebari
            // 
            this.labelIntrebari.Location = new System.Drawing.Point(79, 557);
            this.labelIntrebari.Name = "labelIntrebari";
            this.labelIntrebari.Size = new System.Drawing.Size(768, 79);
            this.labelIntrebari.TabIndex = 1;
            this.labelIntrebari.Text = "intrebare";
            this.labelIntrebari.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(79, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(260, 79);
            this.button1.TabIndex = 2;
            this.button1.Tag = "1";
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.verficaIntrebareEvent);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(79, 258);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(260, 79);
            this.button2.TabIndex = 3;
            this.button2.Tag = "2";
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.verficaIntrebareEvent);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(79, 416);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(260, 79);
            this.button3.TabIndex = 4;
            this.button3.Tag = "3";
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.verficaIntrebareEvent);
            // 
            // button_Back
            // 
            this.button_Back.Enabled = false;
            this.button_Back.Location = new System.Drawing.Point(891, 557);
            this.button_Back.Name = "button_Back";
            this.button_Back.Size = new System.Drawing.Size(121, 79);
            this.button_Back.TabIndex = 5;
            this.button_Back.Text = "< Inapoi";
            this.button_Back.UseVisualStyleBackColor = true;
            this.button_Back.Click += new System.EventHandler(this.button_Back_Click);
            // 
            // button_Next
            // 
            this.button_Next.Enabled = false;
            this.button_Next.Location = new System.Drawing.Point(1018, 557);
            this.button_Next.Name = "button_Next";
            this.button_Next.Size = new System.Drawing.Size(121, 79);
            this.button_Next.TabIndex = 6;
            this.button_Next.Text = "Inainte >";
            this.button_Next.UseVisualStyleBackColor = true;
            this.button_Next.Click += new System.EventHandler(this.button_Next_Click);
            // 
            // label_A
            // 
            this.label_A.AutoSize = true;
            this.label_A.Location = new System.Drawing.Point(31, 135);
            this.label_A.Name = "label_A";
            this.label_A.Size = new System.Drawing.Size(17, 17);
            this.label_A.TabIndex = 7;
            this.label_A.Text = "A";
            // 
            // label_B
            // 
            this.label_B.AutoSize = true;
            this.label_B.Location = new System.Drawing.Point(31, 289);
            this.label_B.Name = "label_B";
            this.label_B.Size = new System.Drawing.Size(17, 17);
            this.label_B.TabIndex = 8;
            this.label_B.Text = "B";
            // 
            // label_C
            // 
            this.label_C.AutoSize = true;
            this.label_C.Location = new System.Drawing.Point(31, 447);
            this.label_C.Name = "label_C";
            this.label_C.Size = new System.Drawing.Size(17, 17);
            this.label_C.TabIndex = 9;
            this.label_C.Text = "C";
            // 
            // label_lrc
            // 
            this.label_lrc.AutoSize = true;
            this.label_lrc.Location = new System.Drawing.Point(597, 41);
            this.label_lrc.Name = "label_lrc";
            this.label_lrc.Size = new System.Drawing.Size(137, 17);
            this.label_lrc.TabIndex = 10;
            this.label_lrc.Text = "Raspunsuri Corecte:";
            // 
            // label_rasp_corecte
            // 
            this.label_rasp_corecte.AutoSize = true;
            this.label_rasp_corecte.Location = new System.Drawing.Point(752, 41);
            this.label_rasp_corecte.Name = "label_rasp_corecte";
            this.label_rasp_corecte.Size = new System.Drawing.Size(16, 17);
            this.label_rasp_corecte.TabIndex = 11;
            this.label_rasp_corecte.Text = "0";
            // 
            // label_lrg
            // 
            this.label_lrg.AutoSize = true;
            this.label_lrg.Location = new System.Drawing.Point(800, 41);
            this.label_lrg.Name = "label_lrg";
            this.label_lrg.Size = new System.Drawing.Size(134, 17);
            this.label_lrg.TabIndex = 12;
            this.label_lrg.Text = "Raspunsuri Gresite:";
            // 
            // label_rasp_gresite
            // 
            this.label_rasp_gresite.AutoSize = true;
            this.label_rasp_gresite.Location = new System.Drawing.Point(941, 41);
            this.label_rasp_gresite.Name = "label_rasp_gresite";
            this.label_rasp_gresite.Size = new System.Drawing.Size(16, 17);
            this.label_rasp_gresite.TabIndex = 13;
            this.label_rasp_gresite.Text = "0";
            // 
            // FormIntrebari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 690);
            this.Controls.Add(this.label_rasp_gresite);
            this.Controls.Add(this.label_lrg);
            this.Controls.Add(this.label_rasp_corecte);
            this.Controls.Add(this.label_lrc);
            this.Controls.Add(this.label_C);
            this.Controls.Add(this.label_B);
            this.Controls.Add(this.label_A);
            this.Controls.Add(this.button_Next);
            this.Controls.Add(this.button_Back);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelIntrebari);
            this.Controls.Add(this.pictureBoxIntrebari);
            this.Name = "FormIntrebari";
            this.Text = "Intrebari";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIntrebari)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxIntrebari;
        private System.Windows.Forms.Label labelIntrebari;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button_Back;
        private System.Windows.Forms.Button button_Next;
        private System.Windows.Forms.Label label_A;
        private System.Windows.Forms.Label label_B;
        private System.Windows.Forms.Label label_C;
        private System.Windows.Forms.Label label_lrc;
        private System.Windows.Forms.Label label_rasp_corecte;
        private System.Windows.Forms.Label label_lrg;
        private System.Windows.Forms.Label label_rasp_gresite;
    }
}