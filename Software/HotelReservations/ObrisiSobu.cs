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
    public partial class ObrisiSobu : Form
    {
       
        public ObrisiSobu()
        {
            InitializeComponent();
          
        }

        private void ObrisiSobu_Load(object sender, EventArgs e)
        {
        
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

        private void obrisiSobubutton_Click(object sender, EventArgs e)
        {
            string brojSobe = brojSobetextBox.Text;
            string nazivHotela = textBoxHotel.Text;
            string velicina = velicinaSobeTextBox.Text;
            string kapacitet = kapacitetTextBox.Text;
            string sadrzaj = sadrzajSobeTextBox.Text;
            string sadrzajKupaonice = sadrzajKupaoniceTextBox.Text;
            string napomena = textBoxNapomene.Text;

           
            if (UlogiraniKorisnik.Uloga_id == 2)
            {
                this.Hide();
                FrmGlavnaFormaZaposlenik pregled = new FrmGlavnaFormaZaposlenik();
                pregled.ShowDialog();
            }

            if (UlogiraniKorisnik.Uloga_id == 1)
            {
                this.Hide();
                PregledHotela pregled = new PregledHotela();
                pregled.ShowDialog();
            }

        }

        private void roundButtonNatrag_Click(object sender, EventArgs e)
        {
            if (UlogiraniKorisnik.Uloga_id == 1)
            {
                this.Hide();
                PregledHotela pregled = new PregledHotela();
                pregled.ShowDialog();
            }
            if (UlogiraniKorisnik.Uloga_id == 2)
            {
                this.Hide();
                PregledSobaZaposlenik pregled = new PregledSobaZaposlenik();
                pregled.ShowDialog();
            }
        }
    }
}
