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
    public partial class PostaviUpit : Form
    {
        public Klase.HotelKlasa ProsljeđeniHotel { get; set; }
        public PostaviUpit(Klase.HotelKlasa hotel)
        {
            InitializeComponent();
            hotel = ProsljeđeniHotel;
        }

        private void odustaniButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPosalji_Click(object sender, EventArgs e)
        {/*
            string upit1 = upitTextBox.Text;
         
            if (ProvjeraKorisnickogUnosa.ProvjeriDodavanjeUpita(upit1) == "")
            {
                UpitKlasa upit = new UpitKlasa();
                upit.Opis = upit1;
                upit.Datum_i_vrijeme = DateTime.Now;
             
              
                UpitRepozitorij.DodajUpit(upit);
                

                this.Hide();
            }
            else
            {
                FrmUpozorenje frmUpozorenje = new FrmUpozorenje(ProvjeraKorisnickogUnosa.ProvjeriDodavanjeIzmjenuGosta(OIB_gosta, ime, prezime, IBAN, telefon, email, adresa, drzavljanstvo, covid_test, datum_rodjenja));
                frmUpozorenje.ShowDialog();
            }*/
        }
    }
}
