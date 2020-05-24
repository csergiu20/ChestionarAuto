using System;
using System.Drawing;
using System.Windows.Forms;

namespace Proiect_IP_ChestionarAuto
{
    public partial class MainForm : Form
    {
        private const int MaxQuestions = 26;
        private const int MaxWrongAnswers = 5;

        private const string ImagesPath = "resources\\images\\";
        private const string DefaultImagePath = "resources\\images\\default.jpg";
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
            var category = GetCategory();

            try
            {
                var defImage = Image.FromFile(DefaultImagePath);
            }
            catch (System.IO.FileNotFoundException)
            {
                var message = "Imaginea default.jpg nu a fost gasita!";
                MessageBox.Show(message, "Eroare");
                return;
            }

            try
            {
                var jMan = new JsonManager(category, QuestionsPath);
            }
            catch (System.IO.DirectoryNotFoundException)
            {
                var message = "Folderul de intrebari nu a fost gasit!";
                MessageBox.Show(message, "Eroare!");
                return;
            }
            catch (System.IO.FileNotFoundException)
            {
                var message = "Fisierul " + "cat" + category + ".json nu a fost gasit sau categoria nu a fost implementata!";
                MessageBox.Show(message, "Eroare");
                return;
            }
            catch (Newtonsoft.Json.JsonReaderException)
            {
                var message = "Fisierul " + "cat" + category + ".json este invalid!";
                MessageBox.Show(message, "Eroare!");
                return;
            }
            catch (Exception exception)
            {
                var message = "Eroare neasteptata: " + exception;
                MessageBox.Show(message, "Eroare!");
                return;
            }

            Hide();

            var questionForm = new QuestionForm(category, MaxQuestions, MaxWrongAnswers, ImagesPath, DefaultImagePath, QuestionsPath);
            questionForm.ShowDialog();

            Show();
        }

        private string GetCategory()
        {
            if (rbCatA.Checked)
            {
                return "A";
            }
            if (rbCatB.Checked)
            {
                return "B";
            }
            if (rbCatC.Checked)
            {
                return "C";
            }
            if (rbCatD.Checked)
            {
                return "D";
            }
            if (rbCatTr.Checked)
            {
                return "T";
            }

            return "ERROR";
        }
    }
}
