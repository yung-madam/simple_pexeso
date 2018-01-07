using MemoryGame.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace MemoryGame
{
    public partial class PlochaHry : Form
    {
        private PictureBox _minuly; //picturebox, ktery dale pouziva pri klikani na karty a jejich porovnavani.
        private Random _nahodne = new Random(); //random cislo pro generovani tagu.
        private int _oznaceni = 0; //promenna, ktera se dale pouziva pri klikani na karty a jejich porovnavani.

        public PlochaHry()
        {
            InitializeComponent();
                InicializaceDB(); //po naloadovani hry nahraje databazi
        }

        private void InicializaceDB() //inicializuje hrace z databaze
        {
            Databaze.Inicializuj();
            hraciGrid.DataSource = Databaze.Hraci;
        }

        private void PlochaHry_Load(object sender, EventArgs e)     
        {
            startTlacitko(); //zobrazi start tlacitko a aktivuje ho
            timer1.Stop(); //zastavi timer pokud je potreba (pri pouziti resetu hry).
            ZobrazitKarty(); //zobrazi obazky karet po restartu. vyhnuti se zmizeni rubu.
            skoreCislo.Text = "0"; //resetuje skore na nulu, pokud potreba (pri pouziti resetu hry).
            SkryjKarty(); //otoci karty na rub.
            Nacitac(); //nacte do labelu hodnoty z tabulky predane ze zacatku/noveho hrace.
            Deaktivovat(); //deaktibuje klikani na karty.
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string odpocet = new string(odpocetLabel.Text.ToCharArray().Where(c => char.IsDigit(c)).ToArray()); //vezme pouze cisla ze stringu predaneho ze zacatku/hrace
            int casovac = Convert.ToInt32(odpocet); //prevede stringova cisla do intovych
            casovac = casovac-1; //casovac se bude odecitat po jedne
            odpocetLabel.Text = Convert.ToString(casovac) +" sekund"; //label bude ukazovat ubyhajici cisla se sekundami za

            if(casovac==0) //pokud vyprsi cas, delej...
            {
                hraciGrid.Rows[0].Cells[5].Value = Convert.ToString(casovac) + " sekund"; //dolni do tabulky cas, za kterou byla hra splnena, v tomto pripade 150
                hraciGrid.Rows[0].Cells[4].Value = skoreCislo.Text; //vyplni do tabulky skore hry
                timer1.Stop(); //zastavi timer
                DialogResult vysledekvolby = MessageBox.Show("Chceš hrát znovu?", "Čas vypršel", MessageBoxButtons.YesNo, MessageBoxIcon.Question); //zepta se uzivatele, zda chce hrat znovu, pokud ano je presmerovan do Novy hrac, jinak je aplikace ukoncena
                if (vysledekvolby == DialogResult.Yes)
                {
                    this.Hide();
                    (new Zacatek(true)).Show();
                }
                else
                {
                    Application.Exit();
                }
            }
        }

        private void startButton_Click(object sender, EventArgs e) //po kliknuti na tlacitko start...
        {
            NastaveniTagu(); //nastavi kartam nahodne tagy
            ZobrazitKarty(); //zobrazi karty
            SkryjKarty(); //ukaze ruby karet.
            timer1.Start(); //aktivuje casovac.
            resetTlacitko(); //skryje a deaktivuje start tlacitko. ukaze restart tlacitko.
            Aktivovat(); //aktivuje klikani na karty.

        }

        private void resetTlacitko() //skryje a deaktivuje Start tlacitko, ukaze a aktivuje reset tlacitko. po odstartovani hry.
        {
            startButton.Enabled = false;
            startButton.Visible = false;
            resetButton.Visible = true;
            resetButton.Enabled = true;
        }
        
        private void startTlacitko() //skryje a deaktivuje Reset tlacitko, ukaze a aktivuje start tlacitko. pred odstartovani hry.
        {
            startButton.Enabled = true;
            startButton.Visible = true;
            resetButton.Visible = false;
            resetButton.Enabled = false;
        }

        public void Nacitac() //nacte do labelu hodnoty z tabulky, ktere byly predane ze Zacatku/noveho hrace
        {
            odpocetLabel.Text = hraciGrid.Rows[0].Cells[3].Value.ToString();
            obtiznostTextLabel.Text = hraciGrid.Rows[0].Cells[2].Value.ToString();
        }

        private void SkryjKarty() //otoci karty rubem vzhuru
        {
            foreach (PictureBox karticky in Karty.Controls)
            {
                karticky.Image = Resources.back;
            }
        }

        private void NahrajObrazky (PictureBox obrazek) //do jednotlivych pictureboxu podle tagu nahraje obrazky z Resources
        {
            switch (Convert.ToInt32(obrazek.Tag))
            {
                case 1:
                    obrazek.Image = Resources.card1;
                    break;
                case 2:
                    obrazek.Image = Resources.card2;
                    break;
                case 3:
                    obrazek.Image = Resources.card3;
                    break;
                case 4:
                    obrazek.Image = Resources.card4;
                    break;
                case 5:
                    obrazek.Image = Resources.card5;
                    break;
                case 6:
                    obrazek.Image = Resources.card6;
                    break;
                default:
                    obrazek.Image = Resources.back;
                    break;
            }
        }

        private void NastaveniTagu() //nahodne nastavuje tag obrazkum
        {
            int[] pole = new int[12]; //pole 12ti, mame 12 karet
            int pocetobrazku = 0;  //spise nez pocet obrazku cislo obrazku
            int r;
            while (pocetobrazku < 12) 
            {
                r = _nahodne.Next(1, 13);
                if (Array.IndexOf(pole, r) == -1)
                {
                    pole[pocetobrazku] = r;
                    pocetobrazku++;
                }
            }
            for (pocetobrazku = 0; pocetobrazku < 12; pocetobrazku++) //jelikoz mame jen 6 obrazku, ale 12 ruznych karet, musime z pole odecitat, aby doslo k duplikaci karet.
            {
                if (pole[pocetobrazku] > 6)
                {
                    pole[pocetobrazku] -= 6;
                }
            }
            pocetobrazku = 0;

            foreach (Control x in Karty.Controls) //nastavi kartam nahodny tag ve stringu.
            {
                if (x is PictureBox)
                {
                    (x as PictureBox).Tag = pole[pocetobrazku].ToString();
                    pocetobrazku++;
                }
            }
        }

        private void ZobrazitKarty() //zobrazi karty pro nasledne klikani
        {
            foreach (Control x in Karty.Controls)
            {
                if(x is PictureBox)
                {
                    (x as PictureBox).Visible = true;
                }
            }
        }

        private void Porovnavani(PictureBox prvni, PictureBox druhy) //porovnava tagy pictureboxu.
        {
            if(prvni.Tag.ToString()==druhy.Tag.ToString()) //pokud se tagy rovnaji...
            {
                Application.DoEvents();
                System.Threading.Thread.Sleep(1000); //vyckej sekundu
                prvni.Visible = false; //schovej prvni kartu
                druhy.Visible = false; //schovej druhou kartu
                skoreCislo.Text = Convert.ToString((int.Parse(skoreCislo.Text) + 1)); //pricitej skore o 1

                if (Convert.ToInt32(skoreCislo.Text) == 6) //pokud se skore rovna 6, tzn. vyhra
                {
                    string zbyvajiciCas = new string(odpocetLabel.Text.ToCharArray().Where(c => char.IsDigit(c)).ToArray()); //vem pouze cisla ze zbyvajiciho casu
                    int zbyvajiciCasVIntu = Convert.ToInt32(zbyvajiciCas); //preved do intu
                    string celkovyCas = new string(hraciGrid.Rows[0].Cells[3].Value.ToString().ToCharArray().Where(c => char.IsDigit(c)).ToArray()); //vem pouze cisla z celkoveho casu
                    int celkovyCasVIntu = Convert.ToInt32(celkovyCas); //preved do intu
                    hraciGrid.Rows[0].Cells[5].Value = Convert.ToString(celkovyCasVIntu-zbyvajiciCasVIntu) + " sekund"; //do tabulky zaved za jak dlouho byla hra splnena
                    hraciGrid.Rows[0].Cells[4].Value = skoreCislo.Text; //do tabulky zaved skore hry, v tomto pripade 6
                    timer1.Stop(); //zastavi timer
                    DialogResult vysledekvolby = MessageBox.Show("Chceš hrát znovu?", "Gratulace, vyhrál jsi!", MessageBoxButtons.YesNo, MessageBoxIcon.Question); //zepta se hrace, zda chce hrat znovu. pokud ano, novy hrac, pokud ne, ukonci aplikaci.
                    if (vysledekvolby == DialogResult.Yes)
                    {
                        this.Hide();
                        (new Zacatek(true)).Show();
                    }
                    else
                    {
                        Application.Exit();
                    }
                }

            }
            else //tagy se nerovnaji
            {
                Application.DoEvents();
                System.Threading.Thread.Sleep(1000); //vyckej sekundu, at si to hraci mohou zapamatovat
                prvni.Image = Resources.back; //otoc prvni na rub
                druhy.Image = Resources.back; //otoc druhou na rub
            }
        }

        private void klikNaKartu(object sender, EventArgs e) //event handler pro klikani na karty
        {
            {
                PictureBox nyni = (PictureBox)sender; //karta, ktera byla nyni odhalena
                NahrajObrazky((PictureBox)sender); //nahraje obrazky z funkce, budou se ukazovat po kliknuti
                if (_oznaceni == 0)  
                {
                    _minuly = nyni;
                    _oznaceni = 1;
                }
                if (_minuly != nyni)
                {
                    Porovnavani(_minuly, nyni); //zajistuje porovnavani mezi kartami, zda jsou shodne
                    _oznaceni = 0;
                }

            }
        }

        private void Deaktivovat() //deaktivuje klikani na karty, aby na ne nebylo mozne klikat pred spustenim hry
        {
            foreach (Control x in Karty.Controls)
            {
                if (x is PictureBox)
                {
                    (x as PictureBox).Enabled = false;
                }
            }
        }

        private void Aktivovat() //aktivuje klikani na karty, aby na ne nylo mozne klikat po spustenim hry
        {
            foreach (Control x in Karty.Controls)
            {
                if (x is PictureBox)
                {
                    (x as PictureBox).Enabled = true;
                }
            }
        }
    }
}
