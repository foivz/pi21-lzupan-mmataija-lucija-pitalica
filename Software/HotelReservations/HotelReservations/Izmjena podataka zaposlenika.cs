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
    public partial class IzmjenaPodatakaZaposlenika : Form
    {
        public IzmjenaPodatakaZaposlenika()
        {
            InitializeComponent();
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
                ZaposlenikKlasa zaposlenik = ZaposlenikRepozitorij.DohvatiZaposlenikaPoImenu(UlogiraniKorisnik.Korisnicko_ime, UlogiraniKorisnik.Lozinka);
                zaposlenik.Adresa = adresa;
                zaposlenik.Email = email;
                zaposlenik.IBAN = iban;
                zaposlenik.Telefon = telefon;
                zaposlenik.Prezime = prezime;
                zaposlenik.Lozinka = lozinka;
                ZaposlenikRepozitorij.IzmijeniZaposlenika(zaposlenik);

                Osvjezi();
                MessageBox.Show("Uspješne promjene!");

            }
            else
            {
                FrmUpozorenje frmUpozorenje = new FrmUpozorenje(ProvjeraKorisnickogUnosa.ProvjeriIzmjenuZaposlenika(adresa, email, iban, telefon, prezime, lozinka));
                frmUpozorenje.ShowDialog();
            }


        }
        private void roundButtonNatrag_Click(object sender, EventArgs e)
        {
            
            if (UlogiraniKorisnik.Uloga_id == 2)
            {
                this.Hide();
                FrmGlavnaFormaZaposlenik pregled = new FrmGlavnaFormaZaposlenik();
                pregled.ShowDialog();
            }
        }

        private void IzmjenaPodatakaZaposlenika_Load(object sender, EventArgs e)
        {
            labelKorisnickiRacun.BackColor = System.Drawing.Color.Transparent;
            labelOIB.BackColor = System.Drawing.Color.Transparent;
            labelIme.BackColor = System.Drawing.Color.Transparent;
            labelPrezime.BackColor = System.Drawing.Color.Transparent;
            labelDatumRodjenja.BackColor = System.Drawing.Color.Transparent;
            labelEmail.BackColor = System.Drawing.Color.Transparent;
            labelAdresa.BackColor = System.Drawing.Color.Transparent;
            labelTelefon.BackColor = System.Drawing.Color.Transparent;
            labelKorisnickoIme.BackColor = System.Drawing.Color.Transparent;
            labelLozinka.BackColor = System.Drawing.Color.Transparent;
            labelIBAN.BackColor = System.Drawing.Color.Transparent;
            labelTipZaposlenika.BackColor = System.Drawing.Color.Transparent;
            labelHotel.BackColor = System.Drawing.Color.Transparent;
            pictureBox2.BackColor = System.Drawing.Color.Transparent;
            Osvjezi();

        }
        private void Osvjezi()
        {

            textBoxIme.Enabled = false;
            textBoxKorisnickoIme.Enabled = false;
            textBoxDatumRodjenja.Enabled = false;
            textBoxOIB.Enabled = false;
            comboBoxTip.Enabled = false;
            textBoxLozinka.Enabled = false;

            ZaposlenikKlasa zaposlenik = ZaposlenikRepozitorij.DohvatiZaposlenikaPoImenu(UlogiraniKorisnik.Korisnicko_ime, UlogiraniKorisnik.Lozinka);
            textBoxAdresa.Text = zaposlenik.Adresa;
            textBoxEmail.Text = zaposlenik.Email;
            textBoxIBAN.Text = zaposlenik.IBAN;
            textBoxIme.Text = zaposlenik.Ime;
            textBoxTelefon.Text = zaposlenik.Telefon;
            textBoxPrezime.Text = zaposlenik.Prezime;
            textBoxKorisnickoIme.Text = zaposlenik.Korisnicko_ime;
            textBoxDatumRodjenja.Text = zaposlenik.Datum_rodjenja.ToString();
            textBoxOIB.Text = zaposlenik.OIB_zaposlenika.ToString();
            textBoxLozinka.Text = zaposlenik.Lozinka;
            comboBoxTip.Text = ZaposlenikRepozitorij.DohvatiNazivTipaPoZaposleniku(zaposlenik.ID_tip);
            List<TipZaposlenikaKlasa> lista = new List<TipZaposlenikaKlasa>();
            lista = ZaposlenikRepozitorij.DohvatiTipZaposlenika();
            comboBoxTip.DataSource = lista;
            comboBoxHotel.Text = HotelRepozitorij.DohvatiHotelPoZaposlenikovomImenu(UlogiraniKorisnik.Lozinka, UlogiraniKorisnik.Korisnicko_ime).OIB_Hotela;
            comboBoxHotel.Enabled = false;
        }
        private void textBoxLozinka_TextChanged(object sender, EventArgs e)
        {

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

    }
}
