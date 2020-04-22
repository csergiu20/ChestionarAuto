using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
namespace Proiect_IP_ChestionarAuto
{
    public partial class FormIntrebari : Form
    {
        int id_intrebare = 1;
        int total_intrebari = 3;

        string path_imagini = "$(SolutionDir)\\..\\..\\..\\resurse\\imagini\\";
        string path_intrebari = "$(SolutionDir)\\..\\..\\..\\resurse\\intrebari.xml";

        int raspunsuri_corecte = 0;
        int raspunsuri_gresite = 0;
        int procentaj = 0;

        int raspuns_corect;

        public FormIntrebari()
        {
            InitializeComponent();
            intreabaIntrebare(id_intrebare);
        }

        private void verficaIntrebareEvent(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;
            int buttontag = Convert.ToInt32(senderObject.Tag);
            
            if(buttontag == raspuns_corect)
            {
                raspunsuri_corecte++;
                label_rasp_corecte.Text = raspunsuri_corecte.ToString();
            }
            else
            {
                raspunsuri_gresite++;
                label_rasp_gresite.Text = raspunsuri_gresite.ToString();
            }

            if(id_intrebare == total_intrebari)
            {
                procentaj = (int)Math.Round((double)(raspunsuri_corecte * 100) / total_intrebari);
            }

            id_intrebare++;
            intreabaIntrebare(id_intrebare);
        }

        private void intreabaIntrebare(int id_intrebare)
        {
            XmlDocument document = new XmlDocument();
            document.Load(path_intrebari);
         
            foreach (XmlNode node in document.DocumentElement)
            {
                int id_intrebare_xml = Int32.Parse(node.Attributes[0].InnerText);
                if(id_intrebare_xml == id_intrebare)

                {
                    labelIntrebari.Text = node.ChildNodes[0].InnerText;
                    button1.Text = node.ChildNodes[1].InnerText;
                    button2.Text = node.ChildNodes[2].InnerText;
                    button3.Text = node.ChildNodes[3].InnerText;
                    raspuns_corect = Int32.Parse(node.ChildNodes[4].InnerText);
                    pictureBoxIntrebari.Image = Image.FromFile(path_imagini + node.ChildNodes[5].InnerText);
                }
            }

            if (id_intrebare == total_intrebari)
            {
                button_Next.Enabled = false;
                button_Back.Enabled = true;
            }
            else if(id_intrebare == 1)
            {
                button_Next.Enabled = true;
                button_Back.Enabled = false;
            }
            else
            {
                button_Next.Enabled = true;
                button_Back.Enabled = true;
            }
        }

        private void button_Next_Click(object sender, EventArgs e)
        {
            id_intrebare++;
            intreabaIntrebare(id_intrebare);
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            id_intrebare--;
            intreabaIntrebare(id_intrebare);
        }
    }
}
