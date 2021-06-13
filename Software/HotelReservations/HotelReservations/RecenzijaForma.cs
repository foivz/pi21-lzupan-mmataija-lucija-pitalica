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
    public partial class RecenzijaForma : Form
    {
        public RecenzijaForma()
        {
            InitializeComponent();
        }

        private void odustaniButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPosalji_Click(object sender, EventArgs e)
        {

            string opis = opisTextBox.Text;
            int ocjena = (int)numericUpDownOcjena.Value;
            string datum = DateTime.Now.ToString();
            HotelKlasa hotel = comboBoxAdresaiNaziv.SelectedItem as HotelKlasa;



            if (ProvjeraKorisnickogUnosa.ProvjeriRecenziju(textBoxOIB.Text, textBoxBrojSobe.Text, opis, ocjena, hotel) == "")
            {
                int OIBgosta = int.Parse(textBoxOIB.Text);
                int brojSobe = int.Parse(textBoxBrojSobe.Text);
                RecenzijaKlasa recenzija = new RecenzijaKlasa();
                recenzija.OIB_gosta = OIBgosta;
                recenzija.Broj_sobe = brojSobe;
                recenzija.Datum_recenzije = DateTime.Now;
                recenzija.Opis = opis;
                recenzija.Ocjena = ocjena;
                recenzija.OIB_hotela = hotel.OIB_Hotela;



                Klase.RepozitorjRecenzija.DodajRecenziju(recenzija);
                SmtpClient posiljateljDetalji = new SmtpClient();

                string primatelj = "zaposlenikhotela@gmail.com";
                string email = hotel.Email.ToString();
                string posiljatelj = email;
                string lozinka = hotel.Lozinka.ToString();
                string posiljateljLozinka = lozinka;
                string naslov = "Recenzija";
                string sadrzaj = "Gost je ostavio novu recenziju!";
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
                PopupNotifier popup = new PopupNotifier();
                popup.Image = Properties.Resources.recenzija;
                popup.ImageSize = new Size(100, 100);
                popup.TitleText = "Recenzija";
                popup.ContentText = "Nova recenzija!";
                popup.Popup();

                this.Hide();
            }
            else
            {
                FrmUpozorenje frmUpozorenje = new FrmUpozorenje(ProvjeraKorisnickogUnosa.ProvjeriRecenziju(textBoxOIB.Text, textBoxBrojSobe.Text, opis, ocjena, hotel));
                frmUpozorenje.ShowDialog();
            }

        }

        private void roundButtonNatrag_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmGlavnaFormaGost glavna = new FrmGlavnaFormaGost();
            glavna.ShowDialog();
        }

        private void RecenzijaForma_Load(object sender, EventArgs e)
        {
            comboBoxAdresaiNaziv.DataSource = HotelRepozitorij.DohvatiHotele();
            pictureBox1.BackColor = System.Drawing.Color.Transparent;
            naslovLabel.BackColor = System.Drawing.Color.Transparent;
            labelOib.BackColor = System.Drawing.Color.Transparent;
            labelBrojSobe.BackColor = System.Drawing.Color.Transparent;
            labelOpis.BackColor = System.Drawing.Color.Transparent;
            labelNazivHotela.BackColor = System.Drawing.Color.Transparent;
            labelOcjena.BackColor = System.Drawing.Color.Transparent;
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmGlavnaFormaGost glavna = new FrmGlavnaFormaGost();
            glavna.ShowDialog();
        }
    }
}
