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
    public partial class PregledHotelaGost : Form
    {
        public Klase.HotelKlasa ProsljeđeniHotel { get; set; }
        public DateTime DatumDolaska { get; set; }

        public DateTime DatumOdlaska { get; set; }

        public PregledHotelaGost(DateTime datumDolaska, DateTime datumOdlaska)
        {
            InitializeComponent();
            DatumDolaska = datumDolaska;
            DatumOdlaska = datumOdlaska;
        }
        public PregledHotelaGost(Klase.HotelKlasa hotel)
        {
            InitializeComponent();
            ProsljeđeniHotel = hotel;
        }


        private void PregledHotelaGost_Load(object sender, EventArgs e)
        {
            dataGridViewHoteli.DataSource = null;
            popisHotelaLabel.BackColor = System.Drawing.Color.Transparent;
            List<SobaKlasa> slobodneSobe = RepozitorijSoba.DohvatiSlobodneSobePoDatumuGost(DatumDolaska, DatumOdlaska);
            dataGridViewHoteli.DataSource = HotelRepozitorij.DohvatiHotelePoGostu(slobodneSobe);
        }

        private void dataGridViewHoteli_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonPregledSobe_Click(object sender, EventArgs e)
        {
            this.Hide();
            HotelKlasa hotel = dataGridViewHoteli.CurrentRow.DataBoundItem as HotelKlasa;
            PregledSobaGost formaPregledSoba = new PregledSobaGost(hotel, DatumDolaska, DatumOdlaska);
            formaPregledSoba.ShowDialog();
        }

        private void roundButtonNatrag_Click(object sender, EventArgs e)
        {
            this.Hide();
            RezervirajSobuKaoGost rezervirajKaoGost = new RezervirajSobuKaoGost();
            rezervirajKaoGost.ShowDialog();
        }

        private void buttonPostaviUpit_Click(object sender, EventArgs e)
        {
           
        }
    }
}
