using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

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

        public static void Serializuj()
        {
            using (Stream s = File.Open("hraci.bin", FileMode.Create))
            {
                BinaryFormatter bin = new BinaryFormatter();
                bin.Serialize(s, Hraci);
            }
        }

        public static void Deserializuj()
        {

            if (File.Exists("hraci.bin")) //jestlize soubor existuje
            {
                using (Stream s = File.Open("hraci.bin", FileMode.Open))
                {
                    BinaryFormatter bin = new BinaryFormatter();

                    foreach (Hrac h in (BindingList<Hrac>)bin.Deserialize(s)) //pridej do Hraci vsechny hrace ze souboru
                    {
                        Hraci.Add(h);
                    }

                    Hraci.Remove(Hraci.Last()); //workaround
                }
            }
        }
    }
}
