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
    public partial class DodajSobu : Form
    {
        public DodajSobu()
        {
            InitializeComponent();
        }

        private void DodajSobu_Load(object sender, EventArgs e)
        {
         
            dodajSobuLabel.BackColor = System.Drawing.Color.Transparent;
            brojSobeLabel.BackColor = System.Drawing.Color.Transparent;
            oibHotelLabel.BackColor = System.Drawing.Color.Transparent;
            velicinaSobeLabel.BackColor = System.Drawing.Color.Transparent;
            kapacitetLabel.BackColor = System.Drawing.Color.Transparent;
            sadrzajSobeLabel.BackColor = System.Drawing.Color.Transparent;
            sadrzajKupaoniceLabel.BackColor = System.Drawing.Color.Transparent;
            napomeneLabel.BackColor = System.Drawing.Color.Transparent;
            cijenaLabel.BackColor = System.Drawing.Color.Transparent;
          
        }

        private void dodajSobubutton_Click(object sender, EventArgs e)
        {
            string brojSobe = brojSobeTextBox.Text;
            string velicina = velicinaSobeTextBox.Text;
            string kapacitet = kapacitetTextBox.Text;
            string sadrzaj = sadrzajSobeTextBox.Text;
            string napomena = napomeneTextBox.Text;
            string cijena = cijenaTextBox.Text;
           
            
            
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
