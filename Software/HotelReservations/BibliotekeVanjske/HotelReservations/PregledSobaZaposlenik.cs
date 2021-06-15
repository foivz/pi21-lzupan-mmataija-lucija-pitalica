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
    public partial class PregledSobaZaposlenik : Form
    {
        public PregledSobaZaposlenik()
        {
            InitializeComponent();

        }

        private void PregledSobaZaposlenik_Load(object sender, EventArgs e)
        {
     
            popisSobaLabel.BackColor = System.Drawing.Color.Transparent;
            labelKapacitet.BackColor = System.Drawing.Color.Transparent;
            labelNazivHotela.BackColor = System.Drawing.Color.Transparent;
    
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void roundButtonNatrag_Click(object sender, EventArgs e)
        {

            this.Hide();
            FrmGlavnaFormaZaposlenik pregled = new FrmGlavnaFormaZaposlenik();
            pregled.ShowDialog();
        }

        private void buttonFiltriraj_Click(object sender, EventArgs e)
        {

        }

        private void azurirajSobuButton_Click(object sender, EventArgs e)
        {
          
        }

        private void dodajSobuButton_Click(object sender, EventArgs e)
        {
            DodajSobu dodajSobu = new DodajSobu();
            this.Hide();
            dodajSobu.ShowDialog();
        }

        private void obrisiSobuButton_Click(object sender, EventArgs e)
        {
         
        }
    }
}
