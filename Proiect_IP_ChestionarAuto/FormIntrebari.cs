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
        private const int TotalIntrebariForm = 3;

        private readonly List<Intrebare> _intrebari;
        private int _indexIntrebare = 0;

        private int _raspunsCorectCurent = 0;

        private int _raspunsuriCorecte = 0;
        private int _raspunsuriGresite = 0;
        private int _procentaj = 0;

        public FormIntrebari()
        {
            InitializeComponent();

            var qXml = new ProcesareXml();
            var _totalIntrebariXml = qXml.ExtragereTotalIntrebariXml();
            var _numereExtraseRandom = RandGenerator.ExtragereNumereRandom(_totalIntrebariXml, TotalIntrebariForm);
            _intrebari = qXml.ExtragereIntrebariXml(_numereExtraseRandom);

            AfisareIntrebariForm();
        }

        private void verficaRaspunsEvent(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;
            int buttonTag = Convert.ToInt32(senderObject.Tag);

            if (buttonTag == _raspunsCorectCurent)
            {
                _raspunsuriCorecte++;
                label_rasp_corecte.Text = _raspunsuriCorecte.ToString();
            }
            else
            {
                _raspunsuriGresite++;
                label_rasp_gresite.Text = _raspunsuriGresite.ToString();
            }

            _procentaj = (int)Math.Round((double)(_raspunsuriCorecte * 100) / TotalIntrebariForm);

            _indexIntrebare++;

            if (_indexIntrebare < TotalIntrebariForm)
            {
                AfisareIntrebariForm();
            }
            else
            {
                Hide();
                MessageBox.Show(_procentaj.ToString() + "% Corecte!", "Scor");
                Close();
            }
        }

        private void AfisareIntrebariForm()
        {
            labelIntrebari.Text = _intrebari[_indexIntrebare].Titlu;
            button1.Text = _intrebari[_indexIntrebare].OptiuneA;
            button2.Text = _intrebari[_indexIntrebare].OptiuneB;
            button3.Text = _intrebari[_indexIntrebare].OptiuneC;
            _raspunsCorectCurent = _intrebari[_indexIntrebare].Raspuns;
            pictureBoxIntrebari.Image = Image.FromFile(_intrebari[_indexIntrebare].Imagine);
        }
    }
}
