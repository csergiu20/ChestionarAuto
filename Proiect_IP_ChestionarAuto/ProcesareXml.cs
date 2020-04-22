using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Proiect_IP_ChestionarAuto
{
    class ProcesareXml
    {
        private const string PathImagini = "$(SolutionDir)\\..\\..\\..\\resurse\\imagini\\";
        private const string PathIntrebari = "$(SolutionDir)\\..\\..\\..\\resurse\\intrebari.xml";

        public int ExtragereTotalIntrebariXml()
        {
            var document = new XmlDocument();
            document.Load(PathIntrebari);

            return document.DocumentElement.Cast<XmlNode>().Count();
        }

        public List<Intrebare> ExtragereIntrebariXml(List<int> nrExtraseRandom)
        {
            var document = new XmlDocument();
            document.Load(PathIntrebari);

            var intrebari = new List<Intrebare>();

            foreach (var nr in nrExtraseRandom)
            {
                foreach (XmlNode node in document.DocumentElement)
                {
                    var id = int.Parse(node.Attributes[0].InnerText);

                    if (id != nr) continue;
                    var titlu = node.ChildNodes[0].InnerText;
                    var optiuneA = node.ChildNodes[1].InnerText;
                    var optiuneB = node.ChildNodes[2].InnerText;
                    var optiuneC = node.ChildNodes[3].InnerText;
                    var raspuns = int.Parse(node.ChildNodes[4].InnerText);
                    var imagine = PathImagini + node.ChildNodes[5].InnerText;

                    intrebari.Add(new Intrebare(id, titlu, optiuneA, optiuneB, optiuneC, raspuns, imagine));
                }
            }

            return intrebari;
        }
    }
}
