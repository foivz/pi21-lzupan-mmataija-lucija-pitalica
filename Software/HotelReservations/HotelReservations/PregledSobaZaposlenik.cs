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
            HotelKlasa hotel = HotelRepozitorij.DohvatiHotelPoZaposlenikovomImenu(UlogiraniKorisnik.Lozinka, UlogiraniKorisnik.Korisnicko_ime);

            dataGridViewSoba.DataSource = RepozitorijSoba.DohvatiSobePoHotelu(hotel);
            popisSobaLabel.BackColor = System.Drawing.Color.Transparent;
            labelNazivHotela.BackColor = System.Drawing.Color.Transparent;
            comboBoxHotel.Text = hotel.Naziv_hotel;
            comboBoxHotel.Enabled = false;
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

            if (dataGridViewSoba.SelectedRows.Count == 1)
            {
                SobaKlasa soba = dataGridViewSoba.CurrentRow.DataBoundItem as SobaKlasa;
                HotelKlasa hotel = HotelRepozitorij.DohvatiHotelPoZaposlenikovomImenu(UlogiraniKorisnik.Lozinka, UlogiraniKorisnik.Korisnicko_ime);
                AzurirajSobu azurirajSobu = new AzurirajSobu(soba, hotel);
                this.Hide();
                azurirajSobu.ShowDialog();
            }
        }

        private void dodajSobuButton_Click(object sender, EventArgs e)
        {
            DodajSobu dodajSobu = new DodajSobu();
            this.Hide();
            dodajSobu.ShowDialog();
        }

        private void obrisiSobuButton_Click(object sender, EventArgs e)
        {
            if (dataGridViewSoba.SelectedRows.Count == 1)
            {
                SobaKlasa soba = dataGridViewSoba.CurrentRow.DataBoundItem as SobaKlasa;
                ObrisiSobu obrisiSobu = new ObrisiSobu(soba);
                this.Hide();
                obrisiSobu.ShowDialog();
            }
        }
    }
}
