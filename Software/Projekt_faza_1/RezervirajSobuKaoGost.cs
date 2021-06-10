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
            PregledHotelaGost formaPregledHotela = new PregledHotelaGost(datumDolaskadateTimePicker.Value,datumOdlaskadateTimePicker.Value);
            formaPregledHotela.ShowDialog();

        }

        private void rezervirajSobuButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void buttonPrikazi_Click(object sender, EventArgs e)
        {
            //ponuda
        }

        private void odustaniButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void roundButtonNatrag_Click(object sender, EventArgs e)
        {
             this.Hide();
            FrmGlavnaForma glavna = new FrmGlavnaForma();
            glavna.ShowDialog();
        }
    }
}
