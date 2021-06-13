using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using Projekt_faza_1.Klase;

namespace Projekt_faza_1
{
    public partial class OdgovorNaUpit : Form
    {
        OpenFileDialog ofdPrivitak;
        string imeDatoteke = "";
        public ZaposlenikKlasa ZaposlenikUlogirani { get; set; }
        public UpitKlasa OdabraniUpit { get; set; }
        public OdgovorNaUpit(ZaposlenikKlasa zaposlenik, UpitKlasa odabraniUpit)
        {
            InitializeComponent();
            ZaposlenikUlogirani = zaposlenik;
            OdabraniUpit = odabraniUpit;
        }

        private void buttonIzaberi_Click(object sender, EventArgs e)
        {
            try
            {
                ofdPrivitak = new OpenFileDialog();
                ofdPrivitak.Filter = "Image Files(*.jpg; *.png)| *.jpg; *.png;|Pdf Files|*.pdf";
                if (ofdPrivitak.ShowDialog() == DialogResult.OK)
                {
                    imeDatoteke = ofdPrivitak.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonPosalji_Click(object sender, EventArgs e)
        {
            try
            {
                SmtpClient posiljateljDetalji = new SmtpClient();
                string brojPorta = "587";
                string smtpServer = "smtp.gmail.com";
                posiljateljDetalji.Port = Convert.ToInt32(brojPorta.Trim());
                posiljateljDetalji.Host = smtpServer.Trim();
                posiljateljDetalji.EnableSsl = true;
                posiljateljDetalji.DeliveryMethod = SmtpDeliveryMethod.Network;
                posiljateljDetalji.UseDefaultCredentials = false;
                posiljateljDetalji.Credentials = new NetworkCredential(textBoxPosiljateljMail.Text.Trim(), textBoxLozinka.Text.Trim());

                MailMessage mailDetalji = new MailMessage();
                mailDetalji.From = new MailAddress(textBoxPosiljateljMail.Text.Trim());
                mailDetalji.To.Add(textBoxPrimateljMail.Text.Trim());
                mailDetalji.Subject = textBoxNaslov.Text.Trim();
                //  mailDetalji.IsBodyHtml = checkBoxHTML.Checked;
                mailDetalji.Body = textBoxSadrzaj.Text.Trim();

                if (imeDatoteke.Length > 0)
                {
                    Attachment privitak = new Attachment(imeDatoteke);
                    mailDetalji.Attachments.Add(privitak);
                }
                posiljateljDetalji.Send(mailDetalji);
                OdabraniUpit.Datum_odgovora = DateTime.Now.ToString();
                RepozitorijUpit.IzmijeniUpit(OdabraniUpit, ZaposlenikUlogirani);
                MessageBox.Show("Uspješno poslan e-mail!");

                imeDatoteke = "";
                this.Hide();
                PregledUpita pregledUpita = new PregledUpita();
                pregledUpita.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void OdgovorNaUpit_Load(object sender, EventArgs e)
        {
            string primatelj = OdabraniUpit.Kontakt;
            textBoxPrimateljMail.Text = primatelj;
            textBoxPrimateljMail.Enabled = false;
            textBoxPosiljateljMail.Text = HotelRepozitorij.DohvatiHotelPoZaposlenikovomImenu(ZaposlenikUlogirani.Lozinka, ZaposlenikUlogirani.Korisnicko_ime).Email;
            textBoxPitanje.Text = OdabraniUpit.Opis;
            textBoxPitanje.Enabled = false;

            groupBoxPodatciPoslijatelj.BackColor = System.Drawing.Color.Transparent;
            groupBoxPodaciPrimatelj.BackColor = System.Drawing.Color.Transparent;
            groupBoxEmailDetalji.BackColor = System.Drawing.Color.Transparent;
            groupBoxPitanje.BackColor = System.Drawing.Color.Transparent;
            groupBox1.BackColor = System.Drawing.Color.Transparent;
        }

        private void groupBoxPodatciPoslijatelj_Enter(object sender, EventArgs e)
        {

        }

        private void checkBoxPrikaziLozinku_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBoxPrikaziLozinku.Checked == true)
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
            PregledUpita pregled = new PregledUpita();
            pregled.ShowDialog();
        }
    }
}
