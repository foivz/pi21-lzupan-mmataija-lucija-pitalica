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
    public partial class PregledHotelaGost : Form
    {
      
       
        public PregledHotelaGost()
        {
            InitializeComponent();
            
        }
        
 
        private void PregledHotelaGost_Load(object sender, EventArgs e)
        {
            dataGridViewHoteli.DataSource = null;
            popisHotelaLabel.BackColor = System.Drawing.Color.Transparent;
           
        }

        private void dataGridViewHoteli_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonPregledSobe_Click(object sender, EventArgs e)
        {
           

        }

        private void roundButtonNatrag_Click(object sender, EventArgs e)
        {
            this.Hide();
            RezervirajSobuKaoGost rezervirajKaoGost = new RezervirajSobuKaoGost();
            rezervirajKaoGost.ShowDialog();
        }

        private void buttonPostaviUpit_Click(object sender, EventArgs e)
        {
           
        }
    }
}
