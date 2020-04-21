namespace Proiect_IP_ChestionarAuto
{
    partial class FormMain
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
            this.button_Start = new System.Windows.Forms.Button();
            this.button_About = new System.Windows.Forms.Button();
            this.button_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Start
            // 
            this.button_Start.Location = new System.Drawing.Point(451, 181);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(154, 69);
            this.button_Start.TabIndex = 0;
            this.button_Start.Text = "Incepe";
            this.button_Start.UseVisualStyleBackColor = true;
            // 
            // button_About
            // 
            this.button_About.Location = new System.Drawing.Point(451, 275);
            this.button_About.Name = "button_About";
            this.button_About.Size = new System.Drawing.Size(154, 71);
            this.button_About.TabIndex = 1;
            this.button_About.Text = "Despre";
            this.button_About.UseVisualStyleBackColor = true;
            this.button_About.Click += new System.EventHandler(this.button_About_Click);
            // 
            // button_Exit
            // 
            this.button_Exit.Location = new System.Drawing.Point(451, 375);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(154, 77);
            this.button_Exit.TabIndex = 2;
            this.button_Exit.Text = "Iesire";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 630);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.button_About);
            this.Controls.Add(this.button_Start);
            this.Name = "FormMain";
            this.Text = "Chestionar Auto";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Start;
        private System.Windows.Forms.Button button_About;
        private System.Windows.Forms.Button button_Exit;
    }
}

