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
        public Klase.HotelKlasa ProsljeđeniHotel { get; set; }
        public PregledSoba(Klase.HotelKlasa hotel)
        {
            InitializeComponent();
            ProsljeđeniHotel = hotel;
        }

        private void PregledSoba_Load(object sender, EventArgs e)
        {
            OsvjeziSobe();
        


        }
        
        private void OsvjeziSobe()
        {
         dataGridViewSoba.DataSource = RepozitorijSoba.DohvatiSobePoHotelu(ProsljeđeniHotel);
           dataGridViewSoba.Columns[0].Visible = false;
        }

        private void azurirajSobuButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SobaKlasa soba = dataGridViewSoba.CurrentRow.DataBoundItem as SobaKlasa;
            AzurirajSobu azuriraj = new AzurirajSobu(soba);
            azuriraj.ShowDialog();


        }

        private void dodajSobuButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            DodajSobu dodajSobuForma = new DodajSobu();
            dodajSobuForma.ShowDialog();
        }

        private void obrisiSobuButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SobaKlasa soba = dataGridViewSoba.CurrentRow.DataBoundItem as SobaKlasa;
            ObrisiSobu obrisi = new ObrisiSobu(soba);
            obrisi.ShowDialog();
        }

        private void buttonOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonRezerviraj_Click(object sender, EventArgs e)
        {
            this.Hide();
            SobaKlasa soba = dataGridViewSoba.CurrentRow.DataBoundItem as SobaKlasa;
            RezervirajSobu rezervirajSobuForma = new RezervirajSobu(soba);
            rezervirajSobuForma.ShowDialog();
        }

        private void buttonFiltriraj_Click(object sender, EventArgs e)
        {
           
            if (datumDolaskadateTimePicker.Value != datumOdlaskadateTimePicker.Value && !string.IsNullOrEmpty(textBoxKapacitet.Text)) {
                string uvjet = "Kapacitet";
                dataGridViewSoba.DataSource = null;
                dataGridViewSoba.DataSource = RepozitorijSoba.DohvatiSlobodneSobePoDatumu(datumDolaskadateTimePicker.Value, datumOdlaskadateTimePicker.Value,uvjet, textBoxKapacitet.Text, ProsljeđeniHotel);
            }
        }

        private void buttonUpit_Click(object sender, EventArgs e)
        {
            this.Hide();
            PostaviUpit postaviUpitForma = new PostaviUpit(ProsljeđeniHotel);
            postaviUpitForma.ShowDialog();
        }

        private void roundButtonNatrag_Click(object sender, EventArgs e)
        {
            this.Hide();
            PregledHotela pregled = new PregledHotela();
            pregled.ShowDialog();
        }
    }
    
}
