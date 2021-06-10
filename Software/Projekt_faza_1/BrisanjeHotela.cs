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
    public partial class BrisanjeHotela : Form
    {
        public Klase.HotelKlasa HotelProslijedjeni { get; set; }
        public BrisanjeHotela(Klase.HotelKlasa hotel)
        {
            InitializeComponent();
            HotelProslijedjeni = hotel;
        }

        private void odustaniButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BrisanjeHotela_Load(object sender, EventArgs e)
        {
            oibtextBox.Text = HotelProslijedjeni.OIB_Hotela;
            oibtextBox.Enabled = false;
            ibantextBox.Text = HotelProslijedjeni.IBAN;
            ibantextBox.Enabled = false;
            nazivtextBox.Text = HotelProslijedjeni.Naziv_hotel;
            nazivtextBox.Enabled = false;
            telefonTextBox.Text = HotelProslijedjeni.Telefon;
            telefonTextBox.Enabled = false;
            adresaTextBox.Text = HotelProslijedjeni.Adresa;
            adresaTextBox.Enabled = false;
            emailTextBox.Text = HotelProslijedjeni.Email;
            emailTextBox.Enabled = false;
            kapacitetTextBox.Text = HotelProslijedjeni.Kapacitet.ToString();
            kapacitetTextBox.Enabled = false;
        }

        private void buttonObrišiHotel_Click(object sender, EventArgs e)
        {
            TextBox textbox = new TextBox();

            List<TextBox> lista = new List<TextBox>();
            lista.Remove(oibtextBox);
            lista.Remove(ibantextBox);
            lista.Remove(nazivtextBox);
            lista.Remove(telefonTextBox);
            lista.Remove(adresaTextBox);
            lista.Remove(emailTextBox);
            lista.Remove(kapacitetTextBox);
            int korisnik_id = UlogiraniKorisnik.Korisnik_id;
            if (ProvjeraKorisnickogUnosa.ProvjeriDodavanjeIzmjenuHotela(lista) == "")
            {
                Klase.HotelKlasa hotel = new Klase.HotelKlasa();
                hotel.OIB_Hotela = oibtextBox.Text;
                hotel.IBAN = ibantextBox.Text;
                hotel.Naziv_hotel = nazivtextBox.Text;
                hotel.Telefon = telefonTextBox.Text;
                hotel.Adresa = adresaTextBox.Text;
                hotel.Email = emailTextBox.Text;
                hotel.Kapacitet = int.Parse(kapacitetTextBox.Text);
                Klase.HotelRepozitorij.ObrisiHotel(hotel, korisnik_id);
                //this.ParentForm.Close();
            }
            else
            {
                FrmUpozorenje frmUpozorenje = new FrmUpozorenje(ProvjeraKorisnickogUnosa.ProvjeriDodavanjeIzmjenuHotela(lista));
                frmUpozorenje.ShowDialog();
            }
            this.Hide();
        }

        private void roundButtonNatrag_Click(object sender, EventArgs e)
        {
            this.Hide();
            PregledHotela pregled = new PregledHotela();
            pregled.ShowDialog();
        }
    }
}
