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
        string path_imagini = "$(SolutionDir)\\..\\..\\..\\resurse\\imagini\\";

        public FormIntrebari()
        {
            InitializeComponent();


        }

        private void verficaIntrebareEvent(object sender, EventArgs e)
        {
            intreabaIntrebare(1);
        }

        private void intreabaIntrebare(int qnum)
        {
            XmlDocument document = new XmlDocument();
            document.Load("$(SolutionDir)\\..\\..\\..\\resurse\\intrebari.xml");
         
            foreach (XmlNode node in document.DocumentElement)
            {
                int numar = Int32.Parse(node.Attributes[0].InnerText);
                if(numar == qnum)

                {
                    labelIntrebari.Text = node.ChildNodes[0].InnerText;
                    button1.Text = node.ChildNodes[1].InnerText;
                    button2.Text = node.ChildNodes[2].InnerText;
                    button3.Text = node.ChildNodes[3].InnerText;
                    button4.Text = node.ChildNodes[4].InnerText;
                    String raspuns_corect = node.ChildNodes[5].InnerText;
                    pictureBoxIntrebari.Image = Image.FromFile(path_imagini + node.ChildNodes[6].InnerText);
                }
            }
        }
    }
}
