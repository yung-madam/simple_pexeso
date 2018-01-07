using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace MemoryGame
{
    public static class Databaze //databaze hracu spojena s tridou hrac pomoci binding listu, v budoucnu muze fungovat pro vkladani hracu manualne
    {
        public static BindingList<Hrac> Hraci { get; set; } = new BindingList<Hrac>(); 

        public static void Inicializuj()
        {
            Hraci.Add(new Hrac("Pokusny", "Kralik", "Těžká", "50 sekund","4", "50 sekund"));
            Hraci.Add(new Hrac("Neexistujici", "Typek", "Lehká", "150 sekund","6", "75 sekund"));
        }
    }
}
