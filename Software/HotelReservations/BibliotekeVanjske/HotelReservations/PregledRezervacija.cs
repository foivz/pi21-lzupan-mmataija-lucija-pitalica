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
    public partial class PregledRezervacija : Form
    {
       
        public PregledRezervacija()
        {
            InitializeComponent();
          

        }

        private void PregledRezervacija_Load(object sender, EventArgs e)
        {
          
            buttonPrijaviGosta.Hide();
            buttonOdjaviGosta.Hide();
            labelPopisRezervacija.BackColor = System.Drawing.Color.Transparent;
        }

        private void buttonPrijaviGosta_Click(object sender, EventArgs e)
        {
          
        
        }
        private void OsvjeziNeprijavljene()
        {
           
        }
        private void OsvjeziPrijavljene()
        {

            

        }

        private void buttonPregledNeprijavljenih_Click(object sender, EventArgs e)
        {
          

        }

        private void buttonPrijavljeniGosti_Click(object sender, EventArgs e)
        {
          
        }

        private void buttonOdjaviGosta_Click(object sender, EventArgs e)
        {
            
        }

        private void roundButtonNatrag_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmGlavnaFormaZaposlenik glavna = new FrmGlavnaFormaZaposlenik();
            glavna.ShowDialog();
        }
    }
}
