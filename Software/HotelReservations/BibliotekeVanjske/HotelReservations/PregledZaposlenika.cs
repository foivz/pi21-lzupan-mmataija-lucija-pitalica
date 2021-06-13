using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projekt_faza_1.Klase;

namespace Projekt_faza_1
{
    public partial class PregledZaposlenika : Form
    {
        public PregledZaposlenika()
        {
                InitializeComponent();
        }

        private void PregledZaposlenika_Load(object sender, EventArgs e)
        {
            DohvatiZaposlenikeUDataGrid();
            pregledZaposlenikaLabel.BackColor = System.Drawing.Color.Transparent;
        }

        private void DohvatiZaposlenikeUDataGrid()
        {
            dataGridViewZaposlenik.DataSource = null;
           
        }

        private void buttonOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonDodajZaposlenika_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dataGridViewSoba_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void azurirajPodatkeButton_Click(object sender, EventArgs e)
        {
         
        }

        private void obrisiZaposlenikaButton_Click(object sender, EventArgs e)
        {
          
        }

        private void roundButtonNatrag_Click(object sender, EventArgs e)
        {
            this.Hide();
            PregledHotela pregled = new PregledHotela();
            pregled.ShowDialog();
            

        }
    }
}
