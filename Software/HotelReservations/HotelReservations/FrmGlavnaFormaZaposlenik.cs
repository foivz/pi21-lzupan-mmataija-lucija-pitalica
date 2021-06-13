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
    public partial class FrmGlavnaFormaZaposlenik : Form
    {
        public FrmGlavnaFormaZaposlenik()
        {
            InitializeComponent();
        }

        private void buttonPrikazRecenzija_Click(object sender, EventArgs e)
        {
            PregledRecenzija pregledRecenzija = new PregledRecenzija();
            pregledRecenzija.ShowDialog();
        }

        private void buttonPregledRezervacija_Click(object sender, EventArgs e)
        {
            this.Hide();
            PregledRezervacija pregledRezervacija = new PregledRezervacija();
            pregledRezervacija.ShowDialog();

        }

     
       

        private void buttonPrikazHotela_Click(object sender, EventArgs e)
        {

        }

        private void FrmGlavnaFormaZaposlenik_Load(object sender, EventArgs e)
        {
            
         
        }

        private void prikazSobaButton_Click(object sender, EventArgs e)
        {
           
        }

        private void buttonOdjaviSe_Click(object sender, EventArgs e)
        {
            UlogiraniKorisnik.Odjava();
            this.Hide();
            FrmGlavnaFormaGost glavna = new FrmGlavnaFormaGost();
            glavna.ShowDialog();
        }

        private void buttonPregledUpita_Click(object sender, EventArgs e)
        {
            this.Hide();
            PregledUpita pregledUpita = new PregledUpita();
            pregledUpita.ShowDialog();
        }

        private void buttonPregledKvarova_Click(object sender, EventArgs e)
        {
            this.Hide();
            PregledPrijavaKvarova pregledKvarova = new PregledPrijavaKvarova();
            pregledKvarova.ShowDialog();

        }

        private void buttonMojProfil_Click(object sender, EventArgs e)
        {
            this.Close();
            IzmjenaPodatakaZaposlenika formaIzmjena = new IzmjenaPodatakaZaposlenika();
            formaIzmjena.ShowDialog();

        }
    }
}
