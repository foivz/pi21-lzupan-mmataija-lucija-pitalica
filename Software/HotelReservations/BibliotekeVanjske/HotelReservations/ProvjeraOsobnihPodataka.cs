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
    public partial class ProvjeraOsobnihPodataka : Form
    {
      
        public ProvjeraOsobnihPodataka()
        {
            InitializeComponent();

        }
        private void ProvjeraOsobnihPodataka_Load(object sender, EventArgs e)
        {
         
            buttonDodajPrviButton.Hide();
            UcitajComboBox();
        }

        private void UcitajComboBox()
        {
            List<string> lista = new List<string>();
            lista.Add("DA");
            lista.Add("NE");
            comboBoxCovidTest.DataSource = lista;
        }
        private void posaljiRezervacijuButton_Click(object sender, EventArgs e)
        {
            string OIB_gosta = OIBGostaTextBox.Text;
            string ime = imeTextBox.Text;
            string prezime = prezimeTextBox.Text;
            string IBAN = IBANTextBox.Text;
            string telefon = telefonTextBox.Text;
            string email = emailTextBox.Text;
            string adresa = adresaTextBox.Text;
            string drzavljanstvo = drzavljanstvoTextBox.Text;
            string covid_test = comboBoxCovidTest.SelectedItem.ToString();
            string datum_rodjenja = datumRodjenjaDateTimePicker.ToString();

            DateTime datum = DateTime.Parse(datumRodjenjaDateTimePicker.Text);

          
           
        }

        private void buttonDodajJosGostiju_Click(object sender, EventArgs e)
        {
          
        }
       
        private void roundButtonNatrag_Click(object sender, EventArgs e)
        {
            this.Hide();
           PregledRezervacija glavna = new PregledRezervacija();
            glavna.ShowDialog();
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            PregledSobaZaposlenik pregled = new PregledSobaZaposlenik();
            pregled.ShowDialog();
        }

        private void datumRodjenjaLabel_Click(object sender, EventArgs e)
        {

        }

        private void buttonDodajPrviButton_Click(object sender, EventArgs e)
        {
          
  
        }
    }
}
