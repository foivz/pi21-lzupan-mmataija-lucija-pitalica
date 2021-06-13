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
    public partial class AzurirajSobu : Form
    {
        public Klase.SobaKlasa SobaProsljedjena { get; set; }
        public Klase.HotelKlasa HotelProslijedeni { get; set; }
        public AzurirajSobu(Klase.SobaKlasa soba, HotelKlasa hotelKlasa)
        {
            InitializeComponent();
            SobaProsljedjena = soba;
            HotelProslijedeni = hotelKlasa;
        }

        private void dodajSobubutton_Click(object sender, EventArgs e)
        {
            
            string broj = brojSobetextBox.Text;
            string nazivHotela = textBoxHotel.Text;
            string velicina = velicinaSobeTextBox.Text;
            string kapacitet = kapacitetTextBox.Text;
            string sadrzaj = sadrzajSobeTextBox.Text;
            string sadrzajKupaonice = sadrzajKupaoniceTextBox.Text;
            string napomena = textBoxNapomene.Text;
            decimal cijena = decimal.Parse(textBoxCijena.Text);
            if (ProvjeraKorisnickogUnosa.ProvjeriIzmjenuSobe(SobaProsljedjena.ID_soba, SobaProsljedjena.Broj_sobe, HotelProslijedeni, broj, velicina, kapacitet, sadrzaj, napomena, nazivHotela, sadrzajKupaonice) == "")
            {

                SobaKlasa soba = new SobaKlasa();
                soba.ID_soba = SobaProsljedjena.ID_soba;
                soba.Broj_sobe = broj;
                soba.VelicinaSobe = int.Parse(velicina);
                soba.Kapacitet = int.Parse(kapacitet);
                soba.Sadrzaj_sobe = sadrzaj;
                soba.Sadrzaj_kupaonice = sadrzajKupaonice;
                soba.Napomene = napomena;
                soba.OIB_hotela = nazivHotela;
                soba.Cijena = cijena;
                RepozitorijSoba.IzmijeniSobu(soba);
                if (UlogiraniKorisnik.Uloga_id == 1)
                {
                    this.Hide();
                    PregledSobaAdmin pregled = new PregledSobaAdmin(HotelProslijedeni);
                    pregled.ShowDialog();
                }

                if (UlogiraniKorisnik.Uloga_id == 2)
                {
                    this.Hide();
                    PregledSoba pregled = new PregledSoba(HotelProslijedeni);
                    pregled.ShowDialog();
                }
            }
            else
            {
                FrmUpozorenje frmUpozorenje = new FrmUpozorenje(ProvjeraKorisnickogUnosa.ProvjeriIzmjenuSobe(SobaProsljedjena.ID_soba, SobaProsljedjena.Broj_sobe, HotelProslijedeni, broj, velicina, kapacitet, sadrzaj, napomena, nazivHotela, sadrzajKupaonice));
                frmUpozorenje.ShowDialog();
            }




        }

        private void AzurirajSobu_Load(object sender, EventArgs e)
        {
            brojSobetextBox.Text = SobaProsljedjena.ID_soba.ToString();
            brojSobetextBox.Enabled = false;
            textBoxHotel.Text = SobaProsljedjena.OIB_hotela.ToString();
            textBoxHotel.Enabled = false;
            velicinaSobeTextBox.Text = SobaProsljedjena.VelicinaSobe.ToString();
            kapacitetTextBox.Text = SobaProsljedjena.Kapacitet.ToString();
            sadrzajSobeTextBox.Text = SobaProsljedjena.Sadrzaj_sobe;
            sadrzajKupaoniceTextBox.Text = SobaProsljedjena.Sadrzaj_kupaonice;
            textBoxNapomene.Text = SobaProsljedjena.Napomene;
            textBoxCijena.Text = SobaProsljedjena.Cijena.ToString();
            dodajSobuLabel.BackColor = System.Drawing.Color.Transparent;
            brojSobeLabel.BackColor = System.Drawing.Color.Transparent;
            oibHotelLabel.BackColor = System.Drawing.Color.Transparent;
            velicinaSobeLabel.BackColor = System.Drawing.Color.Transparent;
            kapacitetLabel.BackColor = System.Drawing.Color.Transparent;
            sadrzajSobeLabel.BackColor = System.Drawing.Color.Transparent;
            sadrzajKupaoniceLabel.BackColor = System.Drawing.Color.Transparent;
            label1.BackColor = System.Drawing.Color.Transparent;
        }

        private void odustaniButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void roundButtonNatrag_Click(object sender, EventArgs e)
        {
            if (UlogiraniKorisnik.Uloga_id == 1)
            {
                this.Hide();
                PregledSobaAdmin pregled = new PregledSobaAdmin(HotelProslijedeni);
                pregled.ShowDialog();
            }

            if (UlogiraniKorisnik.Uloga_id == 2)
            {
                this.Hide();
                PregledSoba pregled = new PregledSoba(HotelProslijedeni);
                pregled.ShowDialog();
            }
        }
    }
}
