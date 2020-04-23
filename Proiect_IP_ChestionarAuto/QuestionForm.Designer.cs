namespace Proiect_IP_ChestionarAuto
{
    partial class QuestionForm
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
            this.picBoxQImage = new System.Windows.Forms.PictureBox();
            this.lblQTitle = new System.Windows.Forms.Label();
            this.btnA = new System.Windows.Forms.Button();
            this.btnB = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.lblCA = new System.Windows.Forms.Label();
            this.lblCorrectAnswers = new System.Windows.Forms.Label();
            this.lblWA = new System.Windows.Forms.Label();
            this.lblWrongAnswers = new System.Windows.Forms.Label();
            this.btnExitQForm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxQImage)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxQImage
            // 
            this.picBoxQImage.Location = new System.Drawing.Point(704, 115);
            this.picBoxQImage.Name = "picBoxQImage";
            this.picBoxQImage.Size = new System.Drawing.Size(500, 500);
            this.picBoxQImage.TabIndex = 0;
            this.picBoxQImage.TabStop = false;
            // 
            // lblQTitle
            // 
            this.lblQTitle.Location = new System.Drawing.Point(79, 115);
            this.lblQTitle.Name = "lblQTitle";
            this.lblQTitle.Size = new System.Drawing.Size(567, 167);
            this.lblQTitle.TabIndex = 1;
            this.lblQTitle.Text = "intrebare";
            this.lblQTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnA
            // 
            this.btnA.Location = new System.Drawing.Point(79, 322);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(567, 79);
            this.btnA.TabIndex = 2;
            this.btnA.Tag = "1";
            this.btnA.Text = "button1";
            this.btnA.UseVisualStyleBackColor = true;
            this.btnA.Click += new System.EventHandler(this.CheckAnswerEvent);
            // 
            // btnB
            // 
            this.btnB.Location = new System.Drawing.Point(79, 428);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(567, 79);
            this.btnB.TabIndex = 3;
            this.btnB.Tag = "2";
            this.btnB.Text = "button2";
            this.btnB.UseVisualStyleBackColor = true;
            this.btnB.Click += new System.EventHandler(this.CheckAnswerEvent);
            // 
            // btnC
            // 
            this.btnC.Location = new System.Drawing.Point(79, 536);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(567, 79);
            this.btnC.TabIndex = 4;
            this.btnC.Tag = "3";
            this.btnC.Text = "button3";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.CheckAnswerEvent);
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(31, 353);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(17, 17);
            this.lblA.TabIndex = 7;
            this.lblA.Text = "A";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(31, 459);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(17, 17);
            this.lblB.TabIndex = 8;
            this.lblB.Text = "B";
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Location = new System.Drawing.Point(31, 567);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(17, 17);
            this.lblC.TabIndex = 9;
            this.lblC.Text = "C";
            // 
            // lblCA
            // 
            this.lblCA.AutoSize = true;
            this.lblCA.Location = new System.Drawing.Point(701, 48);
            this.lblCA.Name = "lblCA";
            this.lblCA.Size = new System.Drawing.Size(137, 17);
            this.lblCA.TabIndex = 10;
            this.lblCA.Text = "Raspunsuri Corecte:";
            // 
            // lblCorrectAnswers
            // 
            this.lblCorrectAnswers.AutoSize = true;
            this.lblCorrectAnswers.Location = new System.Drawing.Point(844, 48);
            this.lblCorrectAnswers.Name = "lblCorrectAnswers";
            this.lblCorrectAnswers.Size = new System.Drawing.Size(16, 17);
            this.lblCorrectAnswers.TabIndex = 11;
            this.lblCorrectAnswers.Text = "0";
            // 
            // lblWA
            // 
            this.lblWA.AutoSize = true;
            this.lblWA.Location = new System.Drawing.Point(910, 48);
            this.lblWA.Name = "lblWA";
            this.lblWA.Size = new System.Drawing.Size(134, 17);
            this.lblWA.TabIndex = 12;
            this.lblWA.Text = "Raspunsuri Gresite:";
            // 
            // lblWrongAnswers
            // 
            this.lblWrongAnswers.AutoSize = true;
            this.lblWrongAnswers.Location = new System.Drawing.Point(1050, 48);
            this.lblWrongAnswers.Name = "lblWrongAnswers";
            this.lblWrongAnswers.Size = new System.Drawing.Size(16, 17);
            this.lblWrongAnswers.TabIndex = 13;
            this.lblWrongAnswers.Text = "0";
            // 
            // btnExitQForm
            // 
            this.btnExitQForm.Location = new System.Drawing.Point(79, 36);
            this.btnExitQForm.Name = "btnExitQForm";
            this.btnExitQForm.Size = new System.Drawing.Size(88, 40);
            this.btnExitQForm.TabIndex = 14;
            this.btnExitQForm.Text = "Iesire";
            this.btnExitQForm.UseVisualStyleBackColor = true;
            this.btnExitQForm.Click += new System.EventHandler(this.btnExitQForm_Click);
            // 
            // QuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.btnExitQForm);
            this.Controls.Add(this.lblWrongAnswers);
            this.Controls.Add(this.lblWA);
            this.Controls.Add(this.lblCorrectAnswers);
            this.Controls.Add(this.lblCA);
            this.Controls.Add(this.lblC);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnB);
            this.Controls.Add(this.btnA);
            this.Controls.Add(this.lblQTitle);
            this.Controls.Add(this.picBoxQImage);
            this.Name = "QuestionForm";
            this.Text = "Intrebari";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxQImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxQImage;
        private System.Windows.Forms.Label lblQTitle;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Button btnB;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.Label lblCA;
        private System.Windows.Forms.Label lblCorrectAnswers;
        private System.Windows.Forms.Label lblWA;
        private System.Windows.Forms.Label lblWrongAnswers;
        private System.Windows.Forms.Button btnExitQForm;
    }
}