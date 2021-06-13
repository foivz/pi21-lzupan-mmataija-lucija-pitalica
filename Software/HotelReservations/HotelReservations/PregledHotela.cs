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
            OsvjeziHotele();
            popisHotelaLabel.BackColor = System.Drawing.Color.Transparent;
        }
        private void OsvjeziHotele()
        {

            dataGridViewHoteli.DataSource = HotelRepozitorij.DohvatiHotele();

        }

        private void azurirajHotelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            HotelKlasa hotel = dataGridViewHoteli.CurrentRow.DataBoundItem as HotelKlasa;
            FrmAzurirajHotel azuriraj = new FrmAzurirajHotel(hotel);
            azuriraj.ShowDialog();

        }

        private void buttonPregledSobe_Click(object sender, EventArgs e)
        {
            this.Hide();
            HotelKlasa hotel = dataGridViewHoteli.CurrentRow.DataBoundItem as HotelKlasa;
            PregledSobaAdmin pregledaj = new PregledSobaAdmin(hotel);
            pregledaj.ShowDialog();

        }

        private void dodajHotelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            DodajHotel dodajHotelForma = new DodajHotel();
            dodajHotelForma.ShowDialog();
        }

        private void obrisiHotelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            HotelKlasa hotel = dataGridViewHoteli.CurrentRow.DataBoundItem as HotelKlasa;
            BrisanjeHotela obrisi = new BrisanjeHotela(hotel);
            obrisi.ShowDialog();
        }

        private void buttonOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void buttonPregledajZaposlenika_Click(object sender, EventArgs e)
        {
            this.Hide();
            HotelKlasa hotel = dataGridViewHoteli.CurrentRow.DataBoundItem as HotelKlasa;
            PregledZaposlenika pregledaj = new PregledZaposlenika(hotel);
            pregledaj.ShowDialog();
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
