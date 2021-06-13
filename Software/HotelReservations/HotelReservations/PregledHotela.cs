using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projekt_faza_1.Klase;

namespace Projekt_faza_1
{
    public partial class PregledHotela : Form
    {
       

        public PregledHotela()
        {
            InitializeComponent();
            
        }

        private void PregledHotela_Load(object sender, EventArgs e)
        {
           
            popisHotelaLabel.BackColor = System.Drawing.Color.Transparent;
        }
        private void OsvjeziHotele()
        {

            
      
        }

        private void azurirajHotelButton_Click(object sender, EventArgs e)
        {
           

        }

        private void buttonPregledSobe_Click(object sender, EventArgs e)
        {
           

        }

        private void dodajHotelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            DodajHotel dodajHotelForma = new DodajHotel();
            dodajHotelForma.ShowDialog();
        }

        private void obrisiHotelButton_Click(object sender, EventArgs e)
        {
           
        }

        private void buttonOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void buttonPregledajZaposlenika_Click(object sender, EventArgs e)
        {
          
        }

        private void roundButtonNatrag_Click(object sender, EventArgs e)
        {
            if (UlogiraniKorisnik.Uloga_id == 1) {
                this.Hide();
                FrmGlavnaFormaAdmin glavna = new FrmGlavnaFormaAdmin();
                glavna.ShowDialog();
            }
            else if (UlogiraniKorisnik.Uloga_id != 1)
            {
                this.Hide();
                FrmGlavnaFormaGost glavna = new FrmGlavnaFormaGost();
                glavna.ShowDialog();
            }

        }
    }
}
