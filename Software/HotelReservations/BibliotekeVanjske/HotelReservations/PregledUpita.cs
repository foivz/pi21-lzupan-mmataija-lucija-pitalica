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
    public partial class PregledUpita : Form
    {
        public PregledUpita()
        {
            InitializeComponent();

        }

     
        private void buttonOdgovori_Click(object sender, EventArgs e)
        {
           
        }

        private void buttonNeodgovoreni_Click(object sender, EventArgs e)
        {
           
        }

        private void PregledUpita_Load(object sender, EventArgs e)
        {
            buttonOdgovori.Hide();
            labelUpiti.BackColor = System.Drawing.Color.Transparent;
        }

        private void buttonOdgovoreniUpiti_Click(object sender, EventArgs e)
        {
            buttonOdgovori.Hide();
         
        }

        private void roundButtonNatrag_Click(object sender, EventArgs e)
        {

            this.Hide();
            FrmGlavnaFormaZaposlenik glavna = new FrmGlavnaFormaZaposlenik();
            glavna.ShowDialog();
        }
    }
}
