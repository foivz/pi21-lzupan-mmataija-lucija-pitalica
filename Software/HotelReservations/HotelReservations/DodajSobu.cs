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
    public partial class DodajSobu : Form
    {
        public DodajSobu()
        {
            InitializeComponent();
        }

        private void DodajSobu_Load(object sender, EventArgs e)
        {
            nazivHotelComboBox.DataSource = null;
            nazivHotelComboBox.DataSource = HotelRepozitorij.DohvatiHotele().ToList();
            dodajSobuLabel.BackColor = System.Drawing.Color.Transparent;
            brojSobeLabel.BackColor = System.Drawing.Color.Transparent;
            oibHotelLabel.BackColor = System.Drawing.Color.Transparent;
            velicinaSobeLabel.BackColor = System.Drawing.Color.Transparent;
            kapacitetLabel.BackColor = System.Drawing.Color.Transparent;
            sadrzajSobeLabel.BackColor = System.Drawing.Color.Transparent;
            sadrzajKupaoniceLabel.BackColor = System.Drawing.Color.Transparent;
            napomeneLabel.BackColor = System.Drawing.Color.Transparent;
            cijenaLabel.BackColor = System.Drawing.Color.Transparent;
          
        }

        private void dodajSobubutton_Click(object sender, EventArgs e)
        {
            string brojSobe = brojSobeTextBox.Text;
            string velicina = velicinaSobeTextBox.Text;
            string kapacitet = kapacitetTextBox.Text;
            string sadrzaj = sadrzajSobeTextBox.Text;
            string napomena = napomeneTextBox.Text;
            string cijena = cijenaTextBox.Text;
            HotelKlasa hotel = nazivHotelComboBox.SelectedItem as HotelKlasa;
            string nazivHotela = hotel.OIB_Hotela;
            string sadrzajKupaonice = sadrzajKupaoniceTextBox.Text;
            if (ProvjeraKorisnickogUnosa.ProvjeriDodavanjeIzmjenuSobe(brojSobe, velicina, kapacitet, sadrzaj, napomena, nazivHotela, sadrzajKupaonice) == "")
            {
                SobaKlasa soba = new SobaKlasa();
                soba.Broj_sobe = brojSobe;
                soba.VelicinaSobe = int.Parse(velicina);
                soba.Kapacitet = int.Parse(kapacitet);
                soba.Sadrzaj_sobe = sadrzaj;
                soba.Sadrzaj_kupaonice = sadrzajKupaonice;
                soba.Napomene = napomena;
                soba.OIB_hotela = nazivHotela;
                soba.Slobodna = 0;
                soba.Cijena = decimal.Parse(cijena);
                RepozitorijSoba.DodajSobu(soba);
                if (UlogiraniKorisnik.Uloga_id == 1)
                {
                    this.Hide();
                    PregledSobaAdmin pregled = new PregledSobaAdmin(hotel);
                    pregled.ShowDialog();
                }
                if (UlogiraniKorisnik.Uloga_id == 2)
                {
                    this.Hide();
                    PregledSoba pregled = new PregledSoba(hotel);
                    pregled.ShowDialog();
                }
            }
            else
            {
                FrmUpozorenje frmUpozorenje = new FrmUpozorenje(ProvjeraKorisnickogUnosa.ProvjeriDodavanjeIzmjenuSobe(brojSobe, velicina, kapacitet, sadrzaj, napomena, nazivHotela, sadrzajKupaonice));
                frmUpozorenje.ShowDialog();
            }



        }

        private void odustaniButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void roundButtonNatrag_Click(object sender, EventArgs e)
        {
            this.Hide();
            HotelKlasa hotel = nazivHotelComboBox.SelectedItem as HotelKlasa;
            PregledSobaAdmin pregled = new PregledSobaAdmin(hotel);
            pregled.ShowDialog();
        }
    }
}
