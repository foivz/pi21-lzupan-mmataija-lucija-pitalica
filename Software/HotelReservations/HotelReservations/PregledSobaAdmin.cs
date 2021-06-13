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
    public partial class PregledSobaAdmin : Form
    {
        public Klase.HotelKlasa HotelProslijedeni { get; set; }
        public PregledSobaAdmin(Klase.HotelKlasa hotel)
        {
            InitializeComponent();
            HotelProslijedeni = hotel;
        }

        private void PregledSobaAdmin_Load(object sender, EventArgs e)
        {
            OsvjeziSobe();

        }

        private void OsvjeziSobe()
        {
            dataGridViewSoba.DataSource = null;
            dataGridViewSoba.DataSource = RepozitorijSoba.DohvatiSobePoHotelu(HotelProslijedeni);
        }

        private void azurirajSobuButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SobaKlasa soba = dataGridViewSoba.CurrentRow.DataBoundItem as SobaKlasa;
            AzurirajSobu azuriraj = new AzurirajSobu(soba, HotelProslijedeni);
            azuriraj.ShowDialog();

        }

        private void obrisiSobuButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SobaKlasa soba = dataGridViewSoba.CurrentRow.DataBoundItem as SobaKlasa;
            ObrisiSobu obrisi = new ObrisiSobu(soba);
            obrisi.ShowDialog();
        }

        private void dodajSobuButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            DodajSobu dodajSobuForma = new DodajSobu();
            dodajSobuForma.ShowDialog();
        }

        private void roundButtonNatrag_Click(object sender, EventArgs e)
        {
            this.Hide();
            PregledHotela pregled = new PregledHotela();
            pregled.ShowDialog();
        }
    }
}
