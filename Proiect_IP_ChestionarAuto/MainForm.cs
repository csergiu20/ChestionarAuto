using System;
using System.Windows.Forms;

namespace Proiect_IP_ChestionarAuto
{
    public partial class MainForm : Form
    {
        private const string AdminPassword = "112";

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
            Hide();

            var category = rbCatB.Checked ? "B" : "C";

            var questionForm = new QuestionForm(category);
            questionForm.ShowDialog();

            Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textBoxPassword.Text == AdminPassword ? "Login Succesful!" : "Login error!", "Login");
        }
    }
}
