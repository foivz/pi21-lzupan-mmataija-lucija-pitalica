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
    public partial class DodavanjeZaposlenika : Form
    {
        public Klase.HotelKlasa ProsljeđeniHotel { get; set; }
        public DodavanjeZaposlenika(Klase.HotelKlasa hotel)
        {
            InitializeComponent();
            ProsljeđeniHotel = hotel;
        }
        

        private void buttonDodajZaposlenika_Click(object sender, EventArgs e)
        {
            string OIB_zaposlenika = txtOIB.Text;
            string ime = txtIme.Text;
            string prezime = txtPrezime.Text;
            string datum_rodjenja = dtDatumRodjenja.ToString();
            string email = txtEmail.Text;
            string adresa = txtAdresa.Text;
            string telefon = txtTelefon.Text;
            string korisnicko_ime = textBoxKorisnickoIme.Text;
            string lozinka = txtLozinka.Text;
            string IBAN = txtIBAN.Text;
            string hotel = ProsljeđeniHotel.OIB_Hotela;

            TipZaposlenikaKlasa tz = cbTipZaposlenika.SelectedItem as TipZaposlenikaKlasa;
            string tip_zaposlenika = tz.ID_tip;
            DateTime datum = DateTime.Parse(dtDatumRodjenja.Text);
            if (ProvjeraKorisnickogUnosa.ProvjeriDodavanjeIzmjenuZaposlenikaDodavanje(OIB_zaposlenika, ime, prezime, datum_rodjenja, email, adresa, telefon, korisnicko_ime, lozinka, IBAN, tip_zaposlenika) == "")
            {
                ZaposlenikKlasa zaposlenik = new ZaposlenikKlasa();
                zaposlenik.OIB_zaposlenika = int.Parse(OIB_zaposlenika);
                zaposlenik.OIB_hotela = hotel;
                zaposlenik.Ime = ime;
                zaposlenik.Prezime = prezime;
                zaposlenik.Datum_rodjenja = datum;
                zaposlenik.Email = email;
                zaposlenik.Adresa = adresa;
                zaposlenik.Telefon = telefon;
                zaposlenik.Korisnicko_ime = korisnicko_ime;
                zaposlenik.Lozinka = lozinka;
                zaposlenik.IBAN = IBAN;
                zaposlenik.ID_tip = tip_zaposlenika;
                zaposlenik.Korisnik_id = UlogiraniKorisnik.Korisnik_id;
                ZaposlenikRepozitorij.DodajZaposlenika(zaposlenik);
                this.Hide();
            }
            else
            {
                FrmUpozorenje frmUpozorenje = new FrmUpozorenje(ProvjeraKorisnickogUnosa.ProvjeriDodavanjeIzmjenuZaposlenikaDodavanje(OIB_zaposlenika, ime, prezime, datum_rodjenja, email, adresa, telefon, korisnicko_ime, lozinka, IBAN, tip_zaposlenika));
                frmUpozorenje.ShowDialog();
            }
            
        }

        private void buttonOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DodavanjeZaposlenika_Load(object sender, EventArgs e)
        {
            cbTipZaposlenika.DataSource = null;
            cbTipZaposlenika.DataSource = ZaposlenikRepozitorij.DohvatiTipZaposlenika().ToList();
        }
    }
}
