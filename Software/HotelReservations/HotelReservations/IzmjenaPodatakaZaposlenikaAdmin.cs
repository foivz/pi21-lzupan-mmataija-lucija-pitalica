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
    public partial class IzmjenaPodatakaZaposlenikaAdmin : Form
    {
      
        public IzmjenaPodatakaZaposlenikaAdmin()
        {
            InitializeComponent();
           
        }

        private void spremiButton_Click(object sender, EventArgs e)
        {
          
        }

        private void IzmjenaPodatakaZaposlenikaAdmin_Load(object sender, EventArgs e)
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

        private void roundButtonNatrag_Click(object sender, EventArgs e)
        {
            
        }
    }
}
