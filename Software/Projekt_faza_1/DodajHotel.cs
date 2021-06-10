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

        private void buttonDodajHotel_Click(object sender, EventArgs e)
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
            }
            else
            {
                FrmUpozorenje frmUpozorenje = new FrmUpozorenje(ProvjeraKorisnickogUnosa.ProvjeriDodavanjeIzmjenuHotela(lista));
                frmUpozorenje.ShowDialog();
            }
            
        }

        private void odustaniButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DodajHotel_Load(object sender, EventArgs e)
        {

        }

        private void roundButtonNatrag_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmGlavnaForma glavna = new FrmGlavnaForma();
            glavna.ShowDialog();
        }
    }
}
