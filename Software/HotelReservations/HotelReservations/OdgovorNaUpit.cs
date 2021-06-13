using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using Projekt_faza_1.Klase;

namespace Projekt_faza_1
{
    public partial class OdgovorNaUpit : Form
    {
        
        public OdgovorNaUpit()
        {
            InitializeComponent();
           
        }

        private void buttonIzaberi_Click(object sender, EventArgs e)
        {
         
        }

        private void buttonPosalji_Click(object sender, EventArgs e)
        {

          
        }

        private void OdgovorNaUpit_Load(object sender, EventArgs e)
        {
          
           
            groupBoxPodatciPoslijatelj.BackColor = System.Drawing.Color.Transparent;
            groupBoxPodaciPrimatelj.BackColor = System.Drawing.Color.Transparent;
            groupBoxEmailDetalji.BackColor = System.Drawing.Color.Transparent;
            groupBoxPitanje.BackColor = System.Drawing.Color.Transparent;
            groupBox1.BackColor = System.Drawing.Color.Transparent;
        }

        private void groupBoxPodatciPoslijatelj_Enter(object sender, EventArgs e)
        {

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

        private void roundButtonNatrag_Click(object sender, EventArgs e)
        {
            this.Hide();
            PregledUpita pregled = new PregledUpita();
            pregled.ShowDialog();
        }
    }
}
