using Projekt_faza_1.Klase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_faza_1
{
    public partial class PregledSobaGost : Form
    {
       
        public PregledSobaGost()
        {
            InitializeComponent();
        }
       
        private void PregledSobaGost_Load(object sender, EventArgs e)
        {
            buttonRezerviraj.Enabled = false;
            popisSobaLabel.BackColor = System.Drawing.Color.Transparent;
            labelKapacitet.BackColor = System.Drawing.Color.Transparent;
        }

        private void buttonFiltriraj_Click(object sender, EventArgs e)
        {
        
        }

        private void buttonRezerviraj_Click(object sender, EventArgs e)
        {
        }

        private void buttonUpit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void roundButtonNatrag_Click(object sender, EventArgs e)
        {
            this.Hide();
            PregledSvihHotelaGost pregled = new PregledSvihHotelaGost();
            pregled.ShowDialog();
        }

        private void buttonPostaviUpit_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
