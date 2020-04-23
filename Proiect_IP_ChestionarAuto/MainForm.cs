using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            var questionForm = new QuestionForm();
            questionForm.ShowDialog();
            Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == AdminPassword)
            {
                MessageBox.Show("Login Succesful!", "Login");
            }
            else
            {
                MessageBox.Show("Login error!", "Login");
            }
        }
    }
}
