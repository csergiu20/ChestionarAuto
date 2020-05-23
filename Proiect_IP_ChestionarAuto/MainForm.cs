using System;
using System.Windows.Forms;

namespace Proiect_IP_ChestionarAuto
{
    public partial class MainForm : Form
    {
        private const int MaxQuestions = 3;
        private const int MaxWrongAnswers = 5;

        private const string ImagesPath = "resources\\images\\";
        private const string DefaultImagePath = "resources\\images\\0.jpg";
        private const string QuestionsPath = "resources\\questions\\";

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            const string message = "Proiect IP\nCorban Sergiu-Stefan\nVelovici Florin-Cristian\n1309B";
            const string title = "Despre";

            MessageBox.Show(message, title);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            var category = rbCatB.Checked ? "B" : "C";
            
            Hide();
            
            var questionForm = new QuestionForm(category, MaxQuestions, MaxWrongAnswers, ImagesPath, DefaultImagePath, QuestionsPath);
            questionForm.ShowDialog();
            
            Show();
        }
    }
}
