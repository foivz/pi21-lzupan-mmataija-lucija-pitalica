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
    public partial class Prijava : Form
    {
        public Prijava()
        {
            InitializeComponent();
        }

        private void Prijava_Load(object sender, EventArgs e)
        {
            textBoxKorisnickoIme.Select();
            checkBoxPrikaziLozinku.BackColor= System.Drawing.Color.Transparent;
            labelKorisnickoIme.BackColor= System.Drawing.Color.Transparent;
            labelLozinka.BackColor= System.Drawing.Color.Transparent;
            pictureBox2.BackColor = System.Drawing.Color.Transparent;

        }

        private void checkBoxPrikaziLozinku_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBoxPrikaziLozinku.Checked == true)
            {
                textBoxLozinka.UseSystemPasswordChar = false;
            }
            else
            {
                textBoxLozinka.UseSystemPasswordChar = true;
            }
        }

        private void odustaniButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmGlavnaFormaGost glavnaFormaGost =new FrmGlavnaFormaGost();
            glavnaFormaGost.ShowDialog();
        }

        private void buttonPrijava_Click_1(object sender, EventArgs e)
        {
            
            List<TextBox> lista = new List<TextBox>();
            lista.Add(textBoxLozinka);
            lista.Add(textBoxKorisnickoIme);
            string korisnickoIme = this.textBoxKorisnickoIme.Text;
            string lozinka = this.textBoxLozinka.Text;
            
            if (ProvjeraKorisnickogUnosa.ProvjeriPrijavu(lista) == "")
            {
                this.Hide();
                if (UlogiraniKorisnik.Uloga_id == 1)
                {
                    FrmGlavnaFormaAdmin frmPocetna = new FrmGlavnaFormaAdmin();
                    frmPocetna.ShowDialog();
                    
                }
                if (UlogiraniKorisnik.Uloga_id == 2)
                {
                    FrmGlavnaFormaZaposlenik frmPocetna = new FrmGlavnaFormaZaposlenik();
                    frmPocetna.ShowDialog();
                    
                }

            }
            else
            {
                FrmUpozorenje frmUpozorenje = new FrmUpozorenje(ProvjeraKorisnickogUnosa.ProvjeriPrijavu(lista));
                frmUpozorenje.ShowDialog();
            }
        }

     
    }
}
