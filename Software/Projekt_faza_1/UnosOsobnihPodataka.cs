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
    public partial class UnosOsobnihPodataka : Form
    {
        public UnosOsobnihPodataka()
        {
            InitializeComponent();
            
        }

        private void UnosOsobnihPodataka_Load(object sender, EventArgs e)
        {
            UcitajComboBox();
        }

        private void UcitajComboBox()
        {
            List<string> lista = new List<string>();
            lista.Add("DA");
            lista.Add("NE");
            comboBoxCovidTest.DataSource = lista;
        }

       

        private void odustaniButton_Click(object sender, EventArgs e)
        {
            this.Close();
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
            if (ProvjeraKorisnickogUnosa.ProvjeriDodavanjeIzmjenuGosta(OIB_gosta, ime, prezime, IBAN, telefon, email, adresa, drzavljanstvo, covid_test, datum_rodjenja) == "")
            {
                GostKlasa gost = new GostKlasa();
               SobaKlasa soba = new SobaKlasa();
                soba.ID_soba = ApstraktnaKlasaRezervacija.ID_soba;
                gost.OIB_gost = int.Parse(OIB_gosta);
                gost.Ime = ime;
                gost.Prezime = prezime;
                gost.IBAN = IBAN;
                gost.Telefon = telefon;
                gost.Email = email;
                gost.Adresa = adresa;
                gost.Drzavljanstvo = drzavljanstvo;
                gost.Covid_test = covid_test;
                gost.Datum_rodjenja = datum;
                GostRepozitorij.DodajGosta(gost);
                RezervacijaKlasa rezervacija = new RezervacijaKlasa();
                rezervacija.Id_soba = ApstraktnaKlasaRezervacija.ID_soba;
                rezervacija.Cijena = ApstraktnaKlasaRezervacija.Cijena;
                rezervacija.Datum_dolaska = ApstraktnaKlasaRezervacija.Datum_dolaska;
                rezervacija.Datum_odlaska = ApstraktnaKlasaRezervacija.Datum_odlaska;
                rezervacija.Datum_rezervacije = ApstraktnaKlasaRezervacija.Datum_rezervacije;
                rezervacija.OIB_gosta = gost.OIB_gost;
        
                RezervacijaRepozitorij.DodajRezervaciju(rezervacija);
              RepozitorijSoba.PromijeniStatus(soba);

                this.Hide();
            }
            else
            {
                FrmUpozorenje frmUpozorenje = new FrmUpozorenje(ProvjeraKorisnickogUnosa.ProvjeriDodavanjeIzmjenuGosta(OIB_gosta, ime, prezime, IBAN, telefon, email, adresa, drzavljanstvo, covid_test, datum_rodjenja));
                frmUpozorenje.ShowDialog();
            }

        }

        private void roundButtonNatrag_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmGlavnaForma glavna = new FrmGlavnaForma();
            glavna.ShowDialog();
        }
    }
}
