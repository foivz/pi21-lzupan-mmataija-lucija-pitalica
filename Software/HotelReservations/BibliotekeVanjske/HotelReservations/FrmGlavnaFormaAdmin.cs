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
    public partial class FrmGlavnaFormaAdmin : Form
    {
        public FrmGlavnaFormaAdmin()
        {
            InitializeComponent();
        }

        private void buttonDodajHotel_Click(object sender, EventArgs e)
        {
            this.Hide();
            DodajHotel dodajHotelForma = new DodajHotel();
            dodajHotelForma.ShowDialog();

        }

        private void buttonDodajSobu_Click(object sender, EventArgs e)
        {
        
        }

        private void buttonDodajGosta_Click(object sender, EventArgs e)
        {
          
        }

        private void pretraziButton_Click(object sender, EventArgs e)
        {
          
        }

        private void buttonPrijaviKvar_Click(object sender, EventArgs e)
        {
          
        }

        private void buttonOstaviRecenziju_Click(object sender, EventArgs e)
        {
           
        }

        private void buttonNapraviRezervaciju_Click(object sender, EventArgs e)
        {
           
        }

        private void buttonDodajZaposlenika_Click(object sender, EventArgs e)
        {

        }

        private void buttonPregledRezervacija_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void buttonPrijaviSe_Click(object sender, EventArgs e)
        {
            UlogiraniKorisnik.Odjava();
            this.Hide();
            FrmGlavnaFormaGost glavna = new FrmGlavnaFormaGost();
            glavna.ShowDialog();
        }

        private void FrmGlavnaFormaAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
