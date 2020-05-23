using System;
using System.IO;
using System.Windows.Forms;

namespace Proiect_IP_ChestionarAuto
{
    public partial class MainForm : Form
    {
        private const int MaxQuestions = 3;
        private const int MaxWrongAnswers = 5;

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
            var xmlManager = new XmlManager(category);

            if (xmlManager.IsXmlValid(MaxQuestions))
            {
                Hide();

                var questionForm = new QuestionForm(category, MaxQuestions, MaxWrongAnswers);
                questionForm.ShowDialog();

                Show();
            }
            else
            {
                MessageBox.Show("Eroare! Exista fisiere lipsa sau invalide!", "Eroare");
            }
        }
    }
}
