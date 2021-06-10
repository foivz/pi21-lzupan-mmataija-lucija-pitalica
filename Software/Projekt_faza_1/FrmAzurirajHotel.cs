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
    public partial class FrmAzurirajHotel : Form
    {
        public Klase.HotelKlasa HotelProslijedjeni { get; set; }

        public FrmAzurirajHotel(Klase.HotelKlasa hotel)
        {
            InitializeComponent();
            HotelProslijedjeni = hotel;
        }

        private void FrmAzurirajHotel_Load(object sender, EventArgs e)
        {
            oibtextBox.Text = HotelProslijedjeni.OIB_Hotela;
            oibtextBox.Enabled = false;
            ibantextBox.Text = HotelProslijedjeni.IBAN;
            ibantextBox.Enabled = false;
            nazivtextBox.Text = HotelProslijedjeni.Naziv_hotel;
            telefonTextBox.Text = HotelProslijedjeni.Telefon;
            adresaTextBox.Text = HotelProslijedjeni.Adresa;
            emailTextBox.Text = HotelProslijedjeni.Email;
            kapacitetTextBox.Text = HotelProslijedjeni.Kapacitet.ToString();

        }

        private void buttonAzurirajHotel_Click(object sender, EventArgs e)
        {
            TextBox textbox = new TextBox();

            List<TextBox> lista = new List<TextBox>();
            lista.Add(oibtextBox);
            lista.Add(ibantextBox);
            lista.Add(nazivtextBox);
            lista.Add(telefonTextBox);
            lista.Add(adresaTextBox);
            lista.Add(emailTextBox);
            lista.Add(kapacitetTextBox);
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
                Klase.HotelRepozitorij.IzmijeniHotel(hotel);
                this.Hide();
            }
            else
            {
                FrmUpozorenje frmUpozorenje = new FrmUpozorenje(ProvjeraKorisnickogUnosa.ProvjeriDodavanjeIzmjenuHotela(lista));
                frmUpozorenje.ShowDialog();
            }
        }

        private void roundButtonNatrag_Click(object sender, EventArgs e)
        {
            this.Hide();
            PregledHotela pregled = new PregledHotela();
            pregled.ShowDialog();
        }
    }
    }
