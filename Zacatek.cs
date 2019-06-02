using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace MemoryGame
{
    public partial class Zacatek : Form
    {

        private bool prvniHra = true; //rika, zda je program spusten poprve.

        public Zacatek(bool prvniHra)
        {
            this.prvniHra = prvniHra;
            InitializeComponent();

            if (!prvniHra) //pokud neni hra prvni, vola tuto metodu
                opustitHruButtonSchovej();
        }

        private void opustitHruButton_Click(object sender, EventArgs e) //ukonci hru
        {
            Application.Exit();
        }

        private void hrajButton_Click(object sender, EventArgs e) /*pokud je zmacknuto hraj, program zkontrolue, zda bylo zadane jmeno a prijmeni, pokud ano, vytvori noveho hrace s hodnotami jmeno, prijmeni, obtiznost, cas, a dalsimi dvema prazdnymi, ktere jsou vyplneny pozdeji*/
        {
            if (string.IsNullOrWhiteSpace(jmenoTextBox.Text))
            {
                MessageBox.Show("Prosim, zadej jmeno.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (string.IsNullOrWhiteSpace(prijmeniTextBox.Text))
            {
                MessageBox.Show("Prosim, zadej prijmeni.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Databaze.Hraci.Insert(0, new Hrac(jmenoTextBox.Text, prijmeniTextBox.Text, obtiznostDomainUpDown.Text, casLabel.Text,"",""));
                this.Hide();
                (new PlochaHry(prvniHra)).Show();
            }
        }

        public void obtiznostDomainUpDown_SelectedItemChanged(object sender, EventArgs e) //kontroluje obtiznost z listu, vraci string se sekundami
        {
            int cas;

            if (obtiznostDomainUpDown.Text.Contains("Lehká"))
            {
                cas = 80;
            }
            else if (obtiznostDomainUpDown.Text.Contains("Střední"))
            {
                cas = 60;
            }
            else
            {
                cas = 40;
            }

            casLabel.Text = cas.ToString() +" sekund";
        }

       private void Zacatek_Load(object sender, EventArgs e) //list obtiznosti ukazany v domainupdown
        {
            
            List<string> seznamObtiznosti = new List<string> { "Lehká", "Střední", "Těžká" };
            obtiznostDomainUpDown.Items.Clear();
            obtiznostDomainUpDown.Items.AddRange(seznamObtiznosti);
            obtiznostDomainUpDown.SelectedIndex = 0;

            obtiznostDomainUpDown.ReadOnly = true;
        }

        private void opustitHruButtonSchovej() //schova opustit hru tlacitko, pohne se start tlacitkem
        {
            opustitHruButton.Enabled = false;
            opustitHruButton.Visible = false;
            hrajButton.Location = new Point(99, 188);
        }
    }
}
