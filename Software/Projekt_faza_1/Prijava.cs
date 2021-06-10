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
        }

        private void checkBoxPrikaziLozinku_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPrikaziLozinku.Checked == false)
            {
                textBoxLozinka.UseSystemPasswordChar = true;
            }
            else
            {
                textBoxLozinka.UseSystemPasswordChar = false;
            }
        }

        private void odustaniButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
                FrmGlavnaForma frmPocetna = new FrmGlavnaForma();
                frmPocetna.ShowDialog();
                this.Hide();
            }
            else
            {
                FrmUpozorenje frmUpozorenje = new FrmUpozorenje(ProvjeraKorisnickogUnosa.ProvjeriPrijavu(lista));
                frmUpozorenje.ShowDialog();
            }
        }
    }
}
