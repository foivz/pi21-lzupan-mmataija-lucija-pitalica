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
    public partial class DodavanjeZaposlenika : Form
    {
       
        public DodavanjeZaposlenika()
        {
            InitializeComponent();

        }
        

        private void buttonDodajZaposlenika_Click(object sender, EventArgs e)
        {
            string OIB_zaposlenika = txtOIB.Text;
            string ime = txtIme.Text;
            string prezime = txtPrezime.Text;
            string datum_rodjenja = dtDatumRodjenja.ToString();
            string email = txtEmail.Text;
            string adresa = txtAdresa.Text;
            string telefon = txtTelefon.Text;
            string korisnicko_ime = textBoxKorisnickoIme.Text;
            string lozinka = txtLozinka.Text;
            string IBAN = txtIBAN.Text;
          
            
            
            
        }

        private void buttonOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DodavanjeZaposlenika_Load(object sender, EventArgs e)
        {
            cbTipZaposlenika.DataSource = null;
            lblOIB.BackColor = System.Drawing.Color.Transparent;
            lblIme.BackColor = System.Drawing.Color.Transparent;
            lblPrezime.BackColor = System.Drawing.Color.Transparent;
            lblDatumRodjenja.BackColor = System.Drawing.Color.Transparent;
            labelEmail.BackColor = System.Drawing.Color.Transparent;
            lblAdresa.BackColor = System.Drawing.Color.Transparent;
            lblTelefon.BackColor = System.Drawing.Color.Transparent;
            lblKorisnickoIme.BackColor = System.Drawing.Color.Transparent;
            lblLozinka.BackColor = System.Drawing.Color.Transparent;
            lbIIBAN.BackColor = System.Drawing.Color.Transparent;
            lblTipZaposlenika.BackColor = System.Drawing.Color.Transparent;
            labelSlika.BackColor = System.Drawing.Color.Transparent;
            labelKorisnickiRacun.BackColor = System.Drawing.Color.Transparent;
            pictureBox2.BackColor= System.Drawing.Color.Transparent;
        }

        private void roundButtonNatrag_Click(object sender, EventArgs e)
        {
          

        }
    }
}
