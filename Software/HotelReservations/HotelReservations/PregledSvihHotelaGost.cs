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
    public partial class PregledSvihHotelaGost : Form
    {
        public PregledSvihHotelaGost()
        {
            InitializeComponent();
        }

        private void PregledSvihHotelaGost_Load(object sender, EventArgs e)
        {
            dataGridViewHoteli.DataSource = HotelRepozitorij.DohvatiHotele();
        }

        private void buttonPregledSobe_Click(object sender, EventArgs e)
        {
            if (dataGridViewHoteli.SelectedRows.Count == 1)
            {
                this.Hide();
                HotelKlasa hotel = dataGridViewHoteli.CurrentRow.DataBoundItem as HotelKlasa;
                PregledSoba formaPregledSoba = new PregledSoba(hotel);
                formaPregledSoba.ShowDialog();
            }
        }

        private void roundButtonNatrag_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmGlavnaFormaGost glavna = new FrmGlavnaFormaGost();
            glavna.ShowDialog();
        }

        private void buttonPostaviUpit_Click(object sender, EventArgs e)
        {
            this.Hide();
            HotelKlasa selektiraniHotel = dataGridViewHoteli.CurrentRow.DataBoundItem as HotelKlasa;
            PostaviUpit postaviUpit = new PostaviUpit(selektiraniHotel);
            postaviUpit.ShowDialog();
        }
    }
}
