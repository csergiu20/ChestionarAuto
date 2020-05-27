using System;
using System.Windows.Forms;
using ChestionarAuto.Properties;

namespace ChestionarAuto
{
    public partial class MainForm : Form
    {
        private const int MaxQuestions = 26;
        private const int MaxWrongAnswers = 5;

        private const string ImagesPath = "resources\\images\\";
        private const string QuestionsPath = "resources\\questions\\";

        public MainForm()
        {
            InitializeComponent();
            Icon = Resources.icon;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            const string message = "Proiect IP\nCorban Sergiu-Stefan\nVelovici Florin-Cristian\n1309B";

            MessageBox.Show(message, "Despre", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Resources.help, "Ajutor", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            var category = GetCategory();

            try
            {
                var jMan = new JsonManager(category, QuestionsPath);
            }
            catch (System.IO.DirectoryNotFoundException)
            {
                var message = "Folderul de intrebari nu a fost gasit!";
                MessageBox.Show(message, "Eroare!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (System.IO.FileNotFoundException)
            {
                var message = "Fisierul " + "cat" + category + ".json nu a fost gasit sau categoria nu a fost implementata!";
                MessageBox.Show(message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            catch (Newtonsoft.Json.JsonReaderException)
            {
                var message = "Fisierul " + "cat" + category + ".json este invalid!";
                MessageBox.Show(message, "Eroare!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (Exception exception)
            {
                var message = "Eroare neasteptata: " + exception;
                MessageBox.Show(message, "Eroare!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Hide();

            var questionForm = new QuestionForm(category, MaxQuestions, MaxWrongAnswers, ImagesPath, QuestionsPath);
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

            return "Error";
        }
    }
}
