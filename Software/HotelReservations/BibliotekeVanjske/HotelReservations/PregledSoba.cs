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
    public partial class PregledSoba : Form
    {
       
        public PregledSoba()
        {
            InitializeComponent();
         
        }

        private void PregledSoba_Load(object sender, EventArgs e)
        {
           
           
            popisSobaLabel.BackColor = System.Drawing.Color.Transparent;
            label1.BackColor= System.Drawing.Color.Transparent; 
            datumDolaskaLabel.BackColor= System.Drawing.Color.Transparent; 
            datumOdlaskaLabel.BackColor= System.Drawing.Color.Transparent;

            if ( UlogiraniKorisnik.Uloga_id != 1) {
                azurirajSobuButton.Hide();
                obrisiSobuButton.Hide();
                dodajSobuButton.Hide();
            }
          


        }
        
        private void OsvjeziSobe()
        {
            dataGridViewSoba.DataSource = null;
           
        }

        private void azurirajSobuButton_Click(object sender, EventArgs e)
        {
           


        }

        private void dodajSobuButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            DodajSobu dodajSobuForma = new DodajSobu();
            dodajSobuForma.ShowDialog();
        }

        private void obrisiSobuButton_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonRezerviraj_Click(object sender, EventArgs e)
        {
           
          
        }

        private void buttonFiltriraj_Click(object sender, EventArgs e)
        {
          
        }

        private void buttonUpit_Click(object sender, EventArgs e)
        {
            
        }

        private void roundButtonNatrag_Click(object sender, EventArgs e)
        {
            if (UlogiraniKorisnik.Uloga_id != 2) {
                this.Hide();
                PregledSvihHotelaGost pregled = new PregledSvihHotelaGost();
                pregled.ShowDialog();
            }
            if (UlogiraniKorisnik.Uloga_id == 2)
            {
                this.Hide();
                PregledHotela pregled = new PregledHotela();
                pregled.ShowDialog();
            }


        }
    }
    
}
