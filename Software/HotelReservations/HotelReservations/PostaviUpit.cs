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
    public partial class PostaviUpit : Form
    {
        public Klase.HotelKlasa ProsljeđeniHotel { get; set; }
        public PostaviUpit(Klase.HotelKlasa hotel)
        {
            InitializeComponent();
            ProsljeđeniHotel = hotel;
        }

        private void odustaniButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPosalji_Click(object sender, EventArgs e)
        {
            string opis = upitTextBox.Text;
            string kontakt = textBoxEmail.Text;
            if (ProvjeraKorisnickogUnosa.ProvjeriDodavanjeUpita(opis, kontakt) == "")
            {
                UpitKlasa upit = new UpitKlasa();
                upit.Opis = opis;
                upit.Datum_i_vrijeme_postavljanja_upita = DateTime.Now;
                upit.OIB_hotela = ProsljeđeniHotel.OIB_Hotela;
                upit.Kontakt = kontakt;
                Klase.RepozitorijUpit.DodajUpit(upit);
                this.Hide();
                FrmGlavnaFormaGost glavna = new FrmGlavnaFormaGost();
                glavna.ShowDialog();
            }
            else
            {
                FrmUpozorenje frmUpozorenje = new FrmUpozorenje(ProvjeraKorisnickogUnosa.ProvjeriDodavanjeUpita(opis, kontakt));
                frmUpozorenje.ShowDialog();
            }
        }
        private void roundButtonNatrag_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmGlavnaFormaGost pregled = new FrmGlavnaFormaGost();
            pregled.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
