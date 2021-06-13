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
    public partial class FrmGlavnaFormaGost : Form
    {
        public FrmGlavnaFormaGost()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Prijava prijava = new Prijava();
            prijava.ShowDialog();
        }

        private void ButtonPretraziHotele_Click(object sender, EventArgs e)
        {
            this.Hide();
            PregledSvihHotelaGost pregled = new PregledSvihHotelaGost();
            pregled.ShowDialog();

        }

        private void buttonNapraviRezervaciju_Click(object sender, EventArgs e)
        {
            this.Hide();
            RezervirajSobuKaoGost rezerviraj = new RezervirajSobuKaoGost();
            rezerviraj.ShowDialog();

        }

        private void buttonPrikazRecenzija_Click(object sender, EventArgs e)
        {
         
        }

        private void buttonPregledKvarova_Click(object sender, EventArgs e)
        {
           
        }

        private void FrmGlavnaFormaGost_Load(object sender, EventArgs e)
        {

        }
    }
}
