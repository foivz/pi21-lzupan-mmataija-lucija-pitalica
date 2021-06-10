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
    public partial class FrmGlavnaForma : Form
    {
        public FrmGlavnaForma()
        {
            InitializeComponent();
        }

        private void buttonDodajHotel_Click(object sender, EventArgs e)
        {
            this.Hide();
            DodajHotel dodajHotelForma = new DodajHotel();
            dodajHotelForma.ShowDialog();
            
        }

        private void buttonDodajSobu_Click(object sender, EventArgs e)
        {
            this.Hide();
            DodajSobu dodajSobuForma = new DodajSobu();
            dodajSobuForma.ShowDialog();
        }

        private void buttonDodajGosta_Click(object sender, EventArgs e)
        {
            this.Hide();
            UnosOsobnihPodataka forma = new UnosOsobnihPodataka();
            forma.ShowDialog();
        }

        private void pretraziButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            PregledHotela pregled = new PregledHotela();
            pregled.ShowDialog();
        }

        private void buttonPrijaviKvar_Click(object sender, EventArgs e)
        {
            this.Hide();
            PrijavaKvara prijavaKvara = new PrijavaKvara();
            prijavaKvara.ShowDialog();
        }

        private void buttonOstaviRecenziju_Click(object sender, EventArgs e)
        {
            this.Hide();
            RecenzijaForma recenzija = new RecenzijaForma();
            recenzija.ShowDialog();
        }

        private void buttonNapraviRezervaciju_Click(object sender, EventArgs e)
        {
            this.Hide();
            RezervirajSobuKaoGost formaRezervacija = new RezervirajSobuKaoGost();
            formaRezervacija.ShowDialog();
        }

        private void buttonDodajZaposlenika_Click(object sender, EventArgs e)
        {

        }
    }
}
