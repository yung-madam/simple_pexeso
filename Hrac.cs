using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryGame
{
    public class Hrac 
    {
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public string Obtiznost { get; set; }
        public string CasNaHru { get; set; }
        public string Skore { get; set; }
        public string CasNaSplneni { get; set; }

        public Hrac(string j, string p, string o, string c, string s, string z) //konstruktor hrace, obsahuje jmeno, prijmeni, obtiznost, cas na hrzu, skore a zbyvajici cas. prvni 4 bere z tvorby noveho hrace, posledni dve se vyplnuji na konci hry.
        {
            Jmeno = j;
            Prijmeni = p;
            Obtiznost = o;
            CasNaHru = c;
            Skore = s;
            CasNaSplneni = z;
        }
    }
}
