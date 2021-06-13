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
    public partial class IzmjenaPodatakaZaposlenika : Form
    {
        public IzmjenaPodatakaZaposlenika()
        {
            InitializeComponent();
        }

        private void spremiButton_Click(object sender, EventArgs e)
        {
           
          

        }
        private void roundButtonNatrag_Click(object sender, EventArgs e)
        {
            
            if (UlogiraniKorisnik.Uloga_id == 2)
            {
                this.Hide();
                FrmGlavnaFormaZaposlenik pregled = new FrmGlavnaFormaZaposlenik();
                pregled.ShowDialog();
            }
        }

        private void IzmjenaPodatakaZaposlenika_Load(object sender, EventArgs e)
        {
            labelKorisnickiRacun.BackColor = System.Drawing.Color.Transparent;
            labelOIB.BackColor = System.Drawing.Color.Transparent;
            labelIme.BackColor = System.Drawing.Color.Transparent;
            labelPrezime.BackColor = System.Drawing.Color.Transparent;
            labelDatumRodjenja.BackColor = System.Drawing.Color.Transparent;
            labelEmail.BackColor = System.Drawing.Color.Transparent;
            labelAdresa.BackColor = System.Drawing.Color.Transparent;
            labelTelefon.BackColor = System.Drawing.Color.Transparent;
            labelKorisnickoIme.BackColor = System.Drawing.Color.Transparent;
            labelLozinka.BackColor = System.Drawing.Color.Transparent;
            labelIBAN.BackColor = System.Drawing.Color.Transparent;
            labelTipZaposlenika.BackColor = System.Drawing.Color.Transparent;
            labelHotel.BackColor = System.Drawing.Color.Transparent;
            pictureBox2.BackColor = System.Drawing.Color.Transparent;
        
        }
       
        private void textBoxLozinka_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxPrikaziStaru_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPrikaziStaru.Checked == true)
            {
                textBoxLozinka.UseSystemPasswordChar = false;
            }
            else
            {
                textBoxLozinka.UseSystemPasswordChar = true;
            }
        }

    }
}
