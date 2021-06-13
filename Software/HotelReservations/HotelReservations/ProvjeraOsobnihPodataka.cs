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
        public Klase.RezervacijaKlasa RezervacijaKlasaProsljedene { get; set; }
        public ProvjeraOsobnihPodataka(Klase.RezervacijaKlasa rezervacijaKlasa)
        {
            InitializeComponent();
            RezervacijaKlasaProsljedene = rezervacijaKlasa;
        }
        public ProvjeraOsobnihPodataka()
        {
            InitializeComponent();
        }
        private void ProvjeraOsobnihPodataka_Load(object sender, EventArgs e)
        {
            buttonDodajJosGostiju.Hide();
            GostKlasa gostKlasa = GostRepozitorij.DohvatiGostaPoID(RezervacijaKlasaProsljedene.OIB_gosta);
            telefonTextBox.Text = gostKlasa.Telefon;
            imeTextBox.Text = gostKlasa.Ime;
            prezimeTextBox.Text = gostKlasa.Prezime;
            adresaTextBox.Text = gostKlasa.Adresa;
            IBANTextBox.Text = gostKlasa.IBAN;
            drzavljanstvoTextBox.Text = gostKlasa.Drzavljanstvo;
            comboBoxCovidTest.Text = gostKlasa.Covid_test;
            datumRodjenjaDateTimePicker.Value = gostKlasa.Datum_rodjenja;
            OIBGostaTextBox.Text = gostKlasa.OIB_gost.ToString();
            emailTextBox.Text = gostKlasa.Email;
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

            if (ProvjeraKorisnickogUnosa.ProvjeriDodavanjeIzmjenuGosta(OIB_gosta, ime, prezime, IBAN, telefon, email, adresa, drzavljanstvo, covid_test, datum_rodjenja) == "")
            {
                GostKlasa noviGost = new GostKlasa();

                int rezervacija_id = RezervacijaKlasaProsljedene.Rezervacija_ID;
                noviGost.ID_gost = RepozitorijRezervacijaGost.DohvatiIdGosta(RezervacijaKlasaProsljedene.Rezervacija_ID);
                noviGost.OIB_gost = int.Parse(OIBGostaTextBox.Text);
                noviGost.Ime = imeTextBox.Text;
                noviGost.Prezime = prezimeTextBox.Text;
                noviGost.IBAN = IBANTextBox.Text;
                noviGost.Telefon = telefonTextBox.Text;
                noviGost.Email = emailTextBox.Text;
                noviGost.Adresa = adresaTextBox.Text;
                noviGost.Drzavljanstvo = drzavljanstvoTextBox.Text;
                noviGost.Covid_test = comboBoxCovidTest.Text;
                noviGost.Datum_rodjenja = datumRodjenjaDateTimePicker.Value;
                GostRepozitorij.IzmijeniGosta(noviGost);


                posaljiRezervacijuButton.Enabled = false;
                buttonDodajJosGostiju.Show();
                RezervacijaKlasaProsljedene.Check_out = DateTime.Now.ToString();
                ZaposlenikKlasa zaposlenik = ZaposlenikRepozitorij.DohvatiZaposlenikaPoImenu(UlogiraniKorisnik.Korisnicko_ime, UlogiraniKorisnik.Lozinka);
                RezervacijaKlasaProsljedene.Zaposlenik_OIB = zaposlenik.ID_zaposlenik;

                RezervacijaRepozitorij.PrijaviGosta(RezervacijaKlasaProsljedene);
                telefonTextBox.Text = "";
                OIBGostaTextBox.Text = "";
                imeTextBox.Text = "";
                prezimeTextBox.Text = "";
                IBANTextBox.Text = "";
                telefonTextBox.Text = "";
                emailTextBox.Text = "";
                adresaTextBox.Text = "";
                drzavljanstvoTextBox.Text = "";
                comboBoxCovidTest.Text = "";
                datumRodjenjaDateTimePicker.Text = "";
                posaljiRezervacijuButton.Hide();
            }



        }

        private void buttonDodajJosGostiju_Click(object sender, EventArgs e)
        {
            if (ProvjeraKapaciteta() == false)
            {

                buttonDodajJosGostiju.Hide();

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
                    GostKlasa noviGost = new GostKlasa();

                    int rezervacija_id = RezervacijaKlasaProsljedene.Rezervacija_ID;
                    noviGost.OIB_gost = int.Parse(OIBGostaTextBox.Text);
                    noviGost.Ime = imeTextBox.Text;
                    noviGost.Prezime = prezimeTextBox.Text;
                    noviGost.IBAN = IBANTextBox.Text;
                    noviGost.Telefon = telefonTextBox.Text;
                    noviGost.Email = emailTextBox.Text;
                    noviGost.Adresa = adresaTextBox.Text;
                    noviGost.Drzavljanstvo = drzavljanstvoTextBox.Text;
                    noviGost.Covid_test = comboBoxCovidTest.Text;
                    noviGost.Datum_rodjenja = datumRodjenjaDateTimePicker.Value;
                    GostRepozitorij.DodajGosta(noviGost);
                    RezervacijaRepozitorij.DodajPodatkeVecPostojecuRezervaciju(rezervacija_id);
                    RezervacijaRepozitorij.PrijaviGosta(RezervacijaKlasaProsljedene);
                    telefonTextBox.Text = "";
                    OIBGostaTextBox.Text = "";
                    imeTextBox.Text = "";
                    prezimeTextBox.Text = "";
                    IBANTextBox.Text = "";
                    telefonTextBox.Text = "";
                    emailTextBox.Text = "";
                    adresaTextBox.Text = "";
                    drzavljanstvoTextBox.Text = "";
                    comboBoxCovidTest.Text = "";
                    datumRodjenjaDateTimePicker.Text = "";
                    buttonDodajPrviButton.Show();
                }
                else
                {
                    FrmUpozorenje frmUpozorenje = new FrmUpozorenje(ProvjeraKorisnickogUnosa.ProvjeriDodavanjeIzmjenuGosta(OIB_gosta, ime, prezime, IBAN, telefon, email, adresa, drzavljanstvo, covid_test, datum_rodjenja));
                    frmUpozorenje.ShowDialog();
                    buttonDodajJosGostiju.Show();
                }
            }
        }
        private bool ProvjeraKapaciteta()
        {
            if (ProvjeraKorisnickogUnosa.ProvjeriKapcitet(RezervacijaKlasaProsljedene.Rezervacija_ID, RezervacijaKlasaProsljedene.Id_soba) != "")
            {
                FrmUpozorenje frmUpozorenje = new FrmUpozorenje(ProvjeraKorisnickogUnosa.ProvjeriKapcitet(RezervacijaKlasaProsljedene.Rezervacija_ID, RezervacijaKlasaProsljedene.Id_soba));
                frmUpozorenje.ShowDialog();

                buttonDodajPrviButton.Hide();
                buttonDodajJosGostiju.Hide();
                return true;
            }
            else
            {
                return false;
            }
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
            if (ProvjeraKapaciteta() == false)
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


                    GostKlasa noviGost = new GostKlasa();

                    int rezervacija_id = RezervacijaKlasaProsljedene.Rezervacija_ID;
                    noviGost.OIB_gost = int.Parse(OIBGostaTextBox.Text);
                    noviGost.Ime = imeTextBox.Text;
                    noviGost.Prezime = prezimeTextBox.Text;
                    noviGost.IBAN = IBANTextBox.Text;
                    noviGost.Telefon = telefonTextBox.Text;
                    noviGost.Email = emailTextBox.Text;
                    noviGost.Adresa = adresaTextBox.Text;
                    noviGost.Drzavljanstvo = drzavljanstvoTextBox.Text;
                    noviGost.Covid_test = comboBoxCovidTest.Text;
                    noviGost.Datum_rodjenja = datumRodjenjaDateTimePicker.Value;
                    GostRepozitorij.DodajGosta(noviGost);
                    RezervacijaRepozitorij.DodajPodatkeVecPostojecuRezervaciju(rezervacija_id);
                    RezervacijaRepozitorij.PrijaviGosta(RezervacijaKlasaProsljedene);
                    telefonTextBox.Text = "";
                    OIBGostaTextBox.Text = "";
                    imeTextBox.Text = "";
                    prezimeTextBox.Text = "";
                    IBANTextBox.Text = "";
                    telefonTextBox.Text = "";
                    emailTextBox.Text = "";
                    adresaTextBox.Text = "";
                    drzavljanstvoTextBox.Text = "";
                    comboBoxCovidTest.Text = "";
                    datumRodjenjaDateTimePicker.Text = "";
                    buttonDodajJosGostiju.Show();
                    buttonDodajPrviButton.Hide();
                }
                else
                {
                    FrmUpozorenje frmUpozorenje = new FrmUpozorenje(ProvjeraKorisnickogUnosa.ProvjeriDodavanjeIzmjenuGosta(OIB_gosta, ime, prezime, IBAN, telefon, email, adresa, drzavljanstvo, covid_test, datum_rodjenja));
                    frmUpozorenje.ShowDialog();
                    buttonDodajPrviButton.Show();
                }
            }

        }
    }
}
