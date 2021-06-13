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
   
    public partial class RezervirajSobuKaoGost : Form
    {
      

        public RezervirajSobuKaoGost()
        {
            InitializeComponent();
  
        }


        private void buttonPrikaziHotele_Click(object sender, EventArgs e)
        {
            this.Hide();
          
        }

        private void rezervirajSobuButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void buttonPrikazi_Click(object sender, EventArgs e)
        {
        }

        private void odustaniButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void roundButtonNatrag_Click(object sender, EventArgs e)
        {
            if (UlogiraniKorisnik.Uloga_id == 2)
            {
                this.Hide();
                FrmGlavnaFormaZaposlenik glavnaZaposlenik = new FrmGlavnaFormaZaposlenik();
                glavnaZaposlenik.ShowDialog();
            }
            else if (UlogiraniKorisnik.Uloga_id != 2) {
                this.Hide();
                FrmGlavnaFormaGost glavna = new FrmGlavnaFormaGost();
                glavna.ShowDialog();
            }
             
        }

        private void buttonPostaviUpit_Click(object sender, EventArgs e)
        {
            this.Hide();
         
        }

        private void RezervirajSobuKaoGost_Load(object sender, EventArgs e)
        {
            rezervirajSobuLabel.BackColor = System.Drawing.Color.Transparent;
            datumDolaskaLabel.BackColor = System.Drawing.Color.Transparent;
            datumOdlaskaLabel.BackColor = System.Drawing.Color.Transparent;
        }
    }
}
