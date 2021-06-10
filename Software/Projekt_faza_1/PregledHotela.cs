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
            PregledSoba pregledaj = new PregledSoba(hotel);
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
        //TU SE VRATIT
        private void buttonPregledajZaposlenika_Click(object sender, EventArgs e)
        {
            this.Hide();
            HotelKlasa hotel = dataGridViewHoteli.CurrentRow.DataBoundItem as HotelKlasa;
            PregledZaposlenika pregledaj = new PregledZaposlenika(hotel);
            pregledaj.ShowDialog();
        }

        private void roundButtonNatrag_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmGlavnaForma glavna = new FrmGlavnaForma();
            glavna.ShowDialog();
        }
    }
}
