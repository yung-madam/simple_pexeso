using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryGame
{
    public partial class NovyHrac : Form //chova se prakticky stejne jakozto zacatek, neni zde tlacitko ukoncit hru
    {
        bool inicializovano = false;

        public NovyHrac()
        {
            InitializeComponent();
        }

        private void NovyHrac_Load(object sender, EventArgs e)
        {
            List<string> seznamObtiznosti = new List<string> { "Lehká", "Střední", "Těžká" };
            novyObtiznostDomainUpDown.Items.Clear();
            novyObtiznostDomainUpDown.Items.AddRange(seznamObtiznosti);
            novyObtiznostDomainUpDown.SelectedIndex = 0;
            novyObtiznostDomainUpDown.ReadOnly = true;
        }

        private void novyHrajButton_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(novyJmenoTextBox.Text))
            {
                MessageBox.Show("Prosim, zadej jmeno.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (string.IsNullOrWhiteSpace(novyPrijmeniTextBox.Text))
            {
                MessageBox.Show("Prosim, zadej prijmeni.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Databaze.Hraci.Insert(0, new Hrac(novyJmenoTextBox.Text, novyPrijmeniTextBox.Text, novyObtiznostDomainUpDown.Text, novyCasNaHruLabel.Text,"",""));
                this.Hide();
                (new PlochaHry()).Show();

                inicializovano = true;
            }
        }

        private void novyObtiznostDomainUpDown_SelectedItemChanged(object sender, EventArgs e)
        {
            int o1;

            if (novyObtiznostDomainUpDown.Text.Contains("Lehká"))
            {
                o1 = 150;
            }
            else if (novyObtiznostDomainUpDown.Text.Contains("Střední"))
            {
                o1 = 100;
            }
            else
            {
                o1 = 50;
            }

            novyCasNaHruLabel.Text = o1.ToString() + " sekund";
        }
    }
}
