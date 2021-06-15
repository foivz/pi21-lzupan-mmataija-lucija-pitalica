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
    public partial class PregledSobaGost : Form
    {
        public Klase.HotelKlasa ProsljedeniHotel { get; set; }
        public DateTime DatumDolaska { get; set; }
        public DateTime DatumOdlaska { get; set; }
        public PregledSobaGost(Klase.HotelKlasa hotel, DateTime datumDolaska, DateTime datumOdlaska)
        {
            InitializeComponent();
            ProsljedeniHotel = hotel;
            DatumDolaska = datumDolaska;
            DatumOdlaska = datumOdlaska;
        }
       
        private void PregledSobaGost_Load(object sender, EventArgs e)
        {
            buttonRezerviraj.Enabled = false;
            popisSobaLabel.BackColor = System.Drawing.Color.Transparent;
            labelKapacitet.BackColor = System.Drawing.Color.Transparent;
        }

        private void buttonFiltriraj_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxKapacitet.Text))
            {
                buttonRezerviraj.Enabled = true;
                string uvjet = "Kapacitet";
                dataGridViewSoba.DataSource = null;
                dataGridViewSoba.DataSource = RepozitorijSoba.DohvatiSlobodneSobePoDatumu(DatumDolaska, DatumOdlaska, uvjet, textBoxKapacitet.Text, ProsljedeniHotel);
            }
        }

        private void buttonRezerviraj_Click(object sender, EventArgs e)
        {
            SobaKlasa sobaIzabrana = dataGridViewSoba.CurrentRow.DataBoundItem as SobaKlasa;
            this.Hide();
            RezervirajSobu pregled = new RezervirajSobu(sobaIzabrana, DatumDolaska, DatumOdlaska);
            pregled.ShowDialog();
        }
    

        private void buttonUpit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void roundButtonNatrag_Click(object sender, EventArgs e)
        {
            this.Hide();
            PregledSvihHotelaGost pregled = new PregledSvihHotelaGost();
            pregled.ShowDialog();
        }

        private void buttonPostaviUpit_Click(object sender, EventArgs e)
        {
            this.Hide();
            PostaviUpit postaviUpit = new PostaviUpit(ProsljedeniHotel);
            postaviUpit.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
