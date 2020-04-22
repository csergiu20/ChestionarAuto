using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_IP_ChestionarAuto
{
    class Intrebare
    {
        public Intrebare(int id, string titlu, string optiuneA, string optiuneB, string optiuneC, int raspuns, string imagine)
        {
            Id = id;
            Titlu = titlu;
            OptiuneA = optiuneA;
            OptiuneB = optiuneB;
            OptiuneC = optiuneC;
            Raspuns = raspuns;
            Imagine = imagine;
        }

        public int Id { get; set; }
        public string Titlu { get; set; }
        public string OptiuneA { get; set; }
        public string OptiuneB { get; set; }
        public string OptiuneC { get; set; }
        public int Raspuns { get; set; }
        public string Imagine { get; set; }
    }
}
