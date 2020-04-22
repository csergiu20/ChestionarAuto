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
        int raspuns_corect_curent = -1;
        int NUMARATORINTREBARI = 0;

        const int total_intrebari = 3;
        const int total_intrebari_xml = 6;

        List<int> numere_extrase_random = new List<int>();
        int list_index = 0;

        const string path_imagini = "$(SolutionDir)\\..\\..\\..\\resurse\\imagini\\";
        const string path_intrebari = "$(SolutionDir)\\..\\..\\..\\resurse\\intrebari.xml";

        int raspunsuri_corecte = 0;
        int raspunsuri_gresite = 0;
        int procentaj = 0;

        public FormIntrebari()
        {
            InitializeComponent();
            ExtragereIntrebariRandom();
            ExtragereIntrebariXml();
            InitializareButoaneBackNext();
        }

        private void verficaIntrebareEvent(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;
            int buttontag = Convert.ToInt32(senderObject.Tag);

            if (buttontag == raspuns_corect_curent)
            {
                raspunsuri_corecte++;
                label_rasp_corecte.Text = raspunsuri_corecte.ToString();
            }
            else
            {
                raspunsuri_gresite++;
                label_rasp_gresite.Text = raspunsuri_gresite.ToString();
            }
           
            procentaj = (int)Math.Round((double)(raspunsuri_corecte * 100) / total_intrebari);
        
            list_index++;
            if (NUMARATORINTREBARI < 3)
            {
                ExtragereIntrebariXml();
            }
            InitializareButoaneBackNext();
        }

        private void ExtragereIntrebariRandom()
        {
            Random rnd = new Random();

            for (int i = 0; i < total_intrebari; i++)
            {
                int temp = 0;
                temp = rnd.Next(1, total_intrebari_xml + 1);

                while (numere_extrase_random.Contains(temp))
                {
                    temp = rnd.Next(1, total_intrebari_xml + 1);
                }

                numere_extrase_random.Add(temp);
            }
        }

        private void ExtragereIntrebariXml()
        {
            XmlDocument document = new XmlDocument();
            document.Load(path_intrebari);

            foreach (XmlNode node in document.DocumentElement)
            {
                int id_intrebare_xml = Int32.Parse(node.Attributes[0].InnerText);

                if (id_intrebare_xml == numere_extrase_random[list_index])
                {
                    NUMARATORINTREBARI++;
                    id_intrebare_xml = 1;
                    labelIntrebari.Text = node.ChildNodes[0].InnerText;
                    button1.Text = node.ChildNodes[1].InnerText;
                    button2.Text = node.ChildNodes[2].InnerText;
                    button3.Text = node.ChildNodes[3].InnerText;
                    pictureBoxIntrebari.Image = Image.FromFile(path_imagini + node.ChildNodes[5].InnerText);

                    raspuns_corect_curent = Int32.Parse(node.ChildNodes[4].InnerText);
                }

            }
        }

        private void InitializareButoaneBackNext()
        {
            //if (id_intrebare_curenta == total_intrebari)
            //{
            //    button_Next.Enabled = false;
            //    button_Back.Enabled = true;
            //}
            //else if (id_intrebare_curenta == 1)
            //{
            //    button_Next.Enabled = true;
            //    button_Back.Enabled = false;
            //}
            //else
            //{
            //    button_Next.Enabled = true;
            //    button_Back.Enabled = true;
            //}
        }

        private void button_Next_Click(object sender, EventArgs e)
        {
            
            //if (NUMARATORINTREBARI < 3 && NUMARATORINTREBARI >= 0)
            //{
            //    list_index++;
            //    ExtragereIntrebariXml();
            //    InitializareButoaneBackNext();
                

            //}
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            //if (NUMARATORINTREBARI > 2)
            //{
            //    NUMARATORINTREBARI--;
            //}
            //if (NUMARATORINTREBARI < 3 && NUMARATORINTREBARI >= 0)
            //{
            //    if (NUMARATORINTREBARI != 0)
            //    {
            //        list_index--;
            //    }
            //    ExtragereIntrebariXml();
            //    InitializareButoaneBackNext();
            //}
        }
    }
}
