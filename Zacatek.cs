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

        //bool inicializovano = false;

        public Zacatek(bool schovejOpustitButton)
        {
            InitializeComponent();
            if (schovejOpustitButton)
                opustitHruTuplik();
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
                (new PlochaHry()).Show();

                //inicializovano = true;
            }
        }

        public void obtiznostDomainUpDown_SelectedItemChanged(object sender, EventArgs e) //checkuje obtiznost z listu, vraci string se sekundami
        {
            int o1;

            if (obtiznostDomainUpDown.Text.Contains("Lehká"))
            {
                o1 = 150;
            }
            else if (obtiznostDomainUpDown.Text.Contains("Střední"))
            {
                o1 = 100;
            }
            else
            {
                o1 = 50;
            }

            casLabel.Text = o1.ToString() +" sekund";
        }

       private void Zacatek_Load(object sender, EventArgs e) //list obtiznosti ukazany v domainupdown
        {
            
            List<string> seznamObtiznosti = new List<string> { "Lehká", "Střední", "Těžká" };
            obtiznostDomainUpDown.Items.Clear();
            obtiznostDomainUpDown.Items.AddRange(seznamObtiznosti);
            obtiznostDomainUpDown.SelectedIndex = 0;

            obtiznostDomainUpDown.ReadOnly = true;

        }

        private void opustitHruTuplik()
        {
            opustitHruButton.Enabled = false;
            opustitHruButton.Visible = false;
            this.hrajButton.Location = new System.Drawing.Point(99, 188);
        }
    }
}
