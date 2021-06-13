using Projekt_faza_1.Klase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

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
            unesiOsobnePodatkeLabel.BackColor = System.Drawing.Color.Transparent;
            pictureBox1.BackColor = System.Drawing.Color.Transparent;
            OIBGostaLabel.BackColor = System.Drawing.Color.Transparent;
            imeLabel.BackColor = System.Drawing.Color.Transparent;
            prezimeLabel.BackColor = System.Drawing.Color.Transparent;
            IBANlabel.BackColor = System.Drawing.Color.Transparent;
            telefonLabel.BackColor = System.Drawing.Color.Transparent;
            emailLabel.BackColor = System.Drawing.Color.Transparent;
            adresaLabel.BackColor = System.Drawing.Color.Transparent;
            drzavljanstvoLabel.BackColor = System.Drawing.Color.Transparent;
            covidTestLabel.BackColor = System.Drawing.Color.Transparent;
            datumRodjenjaLabel.BackColor = System.Drawing.Color.Transparent;
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
                RezervacijaRepozitorij.DodajPodatkeURezervacijaGost();
                RepozitorijSoba.PromijeniStatus(soba);

                try
                {
                    HotelKlasa hotel = HotelRepozitorij.DohvatiHotelPoRezervaciji();
                    SmtpClient posiljateljDetalji = new SmtpClient();
                    //smisli kako prosljedit
                    string primatelj = "zaposlenikhotela@gmail.com";
                    string posiljatelj = "reservationsdreamteam@gmail.com";
                    string posiljateljLozinka = "dreamteam1234";

                    string naslov = "Nova rezervacija";
                    string sadrzaj = "Imate novu rezervaciju!";
                    string brojPorta = "587";
                    string server = "smtp.gmail.com";
                    posiljateljDetalji.Port = Convert.ToInt32(brojPorta.Trim());
                    posiljateljDetalji.Host = server.Trim();
                    posiljateljDetalji.DeliveryMethod = SmtpDeliveryMethod.Network;
                    posiljateljDetalji.UseDefaultCredentials = false;
                    posiljateljDetalji.Credentials = new NetworkCredential(posiljatelj.Trim(), posiljateljLozinka.Trim());
                    posiljateljDetalji.EnableSsl = true;

                    MailMessage mailDetalji = new MailMessage();
                    mailDetalji.From = new MailAddress(posiljatelj.Trim());
                    mailDetalji.To.Add(primatelj.Trim());
                    mailDetalji.Subject = naslov.Trim();
                    mailDetalji.Body = sadrzaj.Trim();


                    posiljateljDetalji.Send(mailDetalji);
                    MessageBox.Show("Uspješno!");
                    this.Hide();
                    FrmGlavnaFormaGost frmGlavnaFormaGost = new FrmGlavnaFormaGost();
                    frmGlavnaFormaGost.ShowDialog();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                PopupNotifier popup = new PopupNotifier();
                popup.ImageSize = new Size(100, 100);
                popup.Image = Properties.Resources.recenzija;
                popup.TitleText = "Rezervacija";
                popup.ContentText = "Nova rezervacija!";
                popup.Popup();
                //gost dobiva poruku o uspješnoj rezervaciji
                try
                {
                    SmtpClient posiljateljDetalji = new SmtpClient();


                    string posiljatelj = "reservationsdreamteam@gmail.com";
                    string posiljateljLozinka = "dreamteam1234";
                    string naslov = "Uspješna rezervacija";
                    string sadrzaj = "Čestitamo! Uspješno ste rezervirali sobu za željeni termin!";
                    string brojPorta = "587";
                    string server = "smtp.gmail.com";
                    posiljateljDetalji.Port = Convert.ToInt32(brojPorta.Trim());
                    posiljateljDetalji.Host = server.Trim();
                    posiljateljDetalji.DeliveryMethod = SmtpDeliveryMethod.Network;
                    posiljateljDetalji.UseDefaultCredentials = false;
                    posiljateljDetalji.Credentials = new NetworkCredential(posiljatelj.Trim(), posiljateljLozinka.Trim());
                    posiljateljDetalji.EnableSsl = true;

                    MailMessage mailDetalji = new MailMessage();
                    mailDetalji.From = new MailAddress(posiljatelj.Trim());
                    mailDetalji.To.Add(emailTextBox.Text.Trim());
                    mailDetalji.Subject = naslov.Trim();
                    mailDetalji.Body = sadrzaj.Trim();


                    posiljateljDetalji.Send(mailDetalji);
                    MessageBox.Show("Uspješno!");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

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
            FrmGlavnaFormaAdmin glavna = new FrmGlavnaFormaAdmin();
            glavna.ShowDialog();
        }

        private void comboBoxCovidTest_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void OIBGostaTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void OIBGostaLabel_Click(object sender, EventArgs e)
        {

        }

        private void prezimeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void prezimeLabel_Click(object sender, EventArgs e)
        {

        }

        private void imeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void imeLabel_Click(object sender, EventArgs e)
        {

        }

        private void IBANTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void IBANlabel_Click(object sender, EventArgs e)
        {

        }

        private void telefonTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void telefonLabel_Click(object sender, EventArgs e)
        {

        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void emailLabel_Click(object sender, EventArgs e)
        {

        }

        private void adresaLabel_Click(object sender, EventArgs e)
        {

        }

        private void adresaTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void drzavljanstvoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void drzavljanstvoLabel_Click(object sender, EventArgs e)
        {

        }

        private void covidTestLabel_Click(object sender, EventArgs e)
        {

        }

        private void datumRodjenjaDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void datumRodjenjaLabel_Click(object sender, EventArgs e)
        {

        }

        private void unesiOsobnePodatkeLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
