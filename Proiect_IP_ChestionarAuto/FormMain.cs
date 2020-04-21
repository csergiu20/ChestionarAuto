using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Proiect IP
// Chestionar Auto
// Corban Sergiu-Stefan
// Velovici Florin-Cristian
// 1309B

namespace Proiect_IP_ChestionarAuto
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_About_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Proiect IP\nCorban Sergiu-Stefan\nVelovici Florin-Cristian\n1309B", "Despre");
        }
    }
}
