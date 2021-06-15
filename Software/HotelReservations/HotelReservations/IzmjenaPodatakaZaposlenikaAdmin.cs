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
    public partial class IzmjenaPodatakaZaposlenikaAdmin : Form
    {
        public ZaposlenikKlasa ZaposlenikProsljedeni { get; set; }
        public IzmjenaPodatakaZaposlenikaAdmin(ZaposlenikKlasa zaposlenik)
        {
            InitializeComponent();
            ZaposlenikProsljedeni = zaposlenik;
        }

        private void spremiButton_Click(object sender, EventArgs e)
        {
            string adresa = textBoxAdresa.Text;
            string email = textBoxEmail.Text;
            string iban = textBoxIBAN.Text;
            string telefon = textBoxTelefon.Text;
            string prezime = textBoxPrezime.Text;
            string lozinka = textBoxLozinka.Text;
            string korisnickoIme = textBoxKorisnickoIme.Text;
            if (ProvjeraKorisnickogUnosa.ProvjeriIzmjenuZaposlenika(adresa, email, iban, telefon, prezime, lozinka) == "")
            {
                ZaposlenikKlasa zaposlenikNovi = ZaposlenikRepozitorij.DohvatiZaposlenikaPoImenu(ZaposlenikProsljedeni.Korisnicko_ime, ZaposlenikProsljedeni.Lozinka);
                zaposlenikNovi.Adresa = adresa;
                zaposlenikNovi.Email = email;
                zaposlenikNovi.IBAN = iban;
                zaposlenikNovi.Telefon = telefon;
                zaposlenikNovi.Prezime = prezime;
                zaposlenikNovi.Lozinka = lozinka;
                ZaposlenikRepozitorij.IzmijeniZaposlenika(zaposlenikNovi);
                ZaposlenikRepozitorij.IzmijeniLozinkuZaposlenikovu(zaposlenikNovi);
                MessageBox.Show("Uspješne promjene!");
                Osvjezi();
            }
            else
            {
                FrmUpozorenje frmUpozorenje = new FrmUpozorenje(ProvjeraKorisnickogUnosa.ProvjeriIzmjenuZaposlenika(adresa, email, iban, telefon, prezime, lozinka));
                frmUpozorenje.ShowDialog();
            }
        }

        private void IzmjenaPodatakaZaposlenikaAdmin_Load(object sender, EventArgs e)
        {
            Osvjezi();
        }
        private void Osvjezi()
        {

            textBoxIme.Enabled = false;
            textBoxKorisnickoIme.Enabled = false;
            textBoxDatumRodjenja.Enabled = false;
            textBoxOIB.Enabled = false;
            comboBoxTip.Enabled = false;
            ZaposlenikKlasa zaposlenikPodatci = ZaposlenikRepozitorij.DohvatiZaposlenikaPoImenu(ZaposlenikProsljedeni.Korisnicko_ime);
            textBoxAdresa.Text = zaposlenikPodatci.Adresa;
            textBoxEmail.Text = zaposlenikPodatci.Email;
            textBoxIBAN.Text = zaposlenikPodatci.IBAN;
            textBoxIme.Text = zaposlenikPodatci.Ime;
            textBoxTelefon.Text = zaposlenikPodatci.Telefon;
            textBoxPrezime.Text = zaposlenikPodatci.Prezime;
            textBoxKorisnickoIme.Text = zaposlenikPodatci.Korisnicko_ime;
            textBoxDatumRodjenja.Text = zaposlenikPodatci.Datum_rodjenja.ToString();
            textBoxOIB.Text = zaposlenikPodatci.OIB_zaposlenika.ToString();
            textBoxLozinka.Text = zaposlenikPodatci.Lozinka;
            comboBoxTip.Text = ZaposlenikRepozitorij.DohvatiNazivTipaPoZaposleniku(zaposlenikPodatci.ID_tip);
            List<TipZaposlenikaKlasa> lista = new List<TipZaposlenikaKlasa>();
            lista = ZaposlenikRepozitorij.DohvatiTipZaposlenika();
            comboBoxTip.DataSource = lista;
            comboBoxHotel.Text = HotelRepozitorij.DohvatiHotelPoZaposlenikovomImenu(zaposlenikPodatci.Korisnicko_ime).Naziv_hotel;
            comboBoxHotel.Enabled = false;
        }

        private void checkBoxPrikaziStaru_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPrikaziStaru.Checked == true)
            {
                textBoxLozinka.UseSystemPasswordChar = false;
            }
            else
            {
                textBoxLozinka.UseSystemPasswordChar = true;
            }
        }

        private void roundButtonNatrag_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            HotelKlasa hotel = HotelRepozitorij.DohvatiHotelPoZaposlenikovomImenu(ZaposlenikProsljedeni.Korisnicko_ime);
            PregledZaposlenika pregledZaposlenika = new PregledZaposlenika(hotel);
            pregledZaposlenika.ShowDialog();
        }
    }
}
