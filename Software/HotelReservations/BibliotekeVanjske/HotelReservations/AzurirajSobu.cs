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
    public partial class AzurirajSobu : Form
    {
    
        public AzurirajSobu()
        {
            InitializeComponent();
    
        }

        private void dodajSobubutton_Click(object sender, EventArgs e)
        {
            
            string broj = brojSobetextBox.Text;
            string nazivHotela = textBoxHotel.Text;
            string velicina = velicinaSobeTextBox.Text;
            string kapacitet = kapacitetTextBox.Text;
            string sadrzaj = sadrzajSobeTextBox.Text;
            string sadrzajKupaonice = sadrzajKupaoniceTextBox.Text;
            string napomena = textBoxNapomene.Text;
            

         

            
        }

        private void AzurirajSobu_Load(object sender, EventArgs e)
        {
      
        }

        private void odustaniButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void roundButtonNatrag_Click(object sender, EventArgs e)
        {
            
        }
    }
}
