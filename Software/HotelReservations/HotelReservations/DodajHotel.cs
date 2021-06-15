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
    public partial class DodajHotel : Form
    {
        public DodajHotel()
        {
            InitializeComponent();
        }

        private void odustaniButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DodajHotel_Load(object sender, EventArgs e)
        {
            oibLabel.BackColor = System.Drawing.Color.Transparent;
            ibanLabel.BackColor = System.Drawing.Color.Transparent;
            labelNaziv.BackColor = System.Drawing.Color.Transparent;
            telefonLabel.BackColor = System.Drawing.Color.Transparent;
            adresaLabel.BackColor = System.Drawing.Color.Transparent;
            emailLabel.BackColor = System.Drawing.Color.Transparent;
            kapacitetLabel.BackColor = System.Drawing.Color.Transparent;
            labelDodajHotel.BackColor = System.Drawing.Color.Transparent;
            pictureBox2.BackColor = System.Drawing.Color.Transparent;
        }

        private void dodajHotelButton_Click(object sender, EventArgs e)
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
                HotelKlasa hotel = new HotelKlasa();
                hotel.OIB_Hotela = oibtextBox.Text;
                hotel.IBAN = ibantextBox.Text;
                hotel.Naziv_hotel = nazivtextBox.Text;
                hotel.Telefon = telefonTextBox.Text;
                hotel.Adresa = adresaTextBox.Text;
                hotel.Email = emailTextBox.Text;
                hotel.Kapacitet = int.Parse(kapacitetTextBox.Text);
                HotelRepozitorij.DodajHotel(hotel);
                this.Hide();
                PregledHotela pregled = new PregledHotela();
                pregled.ShowDialog();
            }
            else
            {
                FrmUpozorenje frmUpozorenje = new FrmUpozorenje(ProvjeraKorisnickogUnosa.ProvjeriDodavanjeIzmjenuHotela(lista));
                frmUpozorenje.ShowDialog();
            }

        }

        private void roundButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmGlavnaFormaAdmin glavna = new FrmGlavnaFormaAdmin();
            glavna.ShowDialog();
        }
    }
}
