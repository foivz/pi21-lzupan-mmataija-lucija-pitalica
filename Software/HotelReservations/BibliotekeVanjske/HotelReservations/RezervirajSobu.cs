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
    public partial class RezervirajSobu : Form
    {
      
        public RezervirajSobu()
        {
            InitializeComponent();
           
        }

        private void velicinaSobeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void cijenaLabel_Click(object sender, EventArgs e)
        {

        }

        private void RezervirajSobu_Load(object sender, EventArgs e)
        {
           
            rezervirajSobuLabel.BackColor = System.Drawing.Color.Transparent;
            brojSobeLabel.BackColor = System.Drawing.Color.Transparent;
            datumDolaskaLabel.BackColor = System.Drawing.Color.Transparent;
            datumOdlaskaLabel.BackColor = System.Drawing.Color.Transparent;
            cijenaLabel.BackColor = System.Drawing.Color.Transparent;
            pictureBox1.BackColor = System.Drawing.Color.Transparent;
        }
        TimeSpan dohvatiBrojDana(DateTime datumDolaska, DateTime datumOdlaska)
        {
            TimeSpan ts = datumOdlaska - datumDolaska;
            return ts;
        }
        
        private void rezervirajSobuButton_Click(object sender, EventArgs e)
        {
          
          
        }
        private void odustaniButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void buttonPrikazi_Click(object sender, EventArgs e)
        {
            
            DateTime datumDolaska = datumDolaskadateTimePicker.Value;
            DateTime datumOdlaska = datumOdlaskadateTimePicker.Value;
            TimeSpan razlika = dohvatiBrojDana(datumDolaska, datumOdlaska);
            int razlikaUDanima = razlika.Days;
            decimal dani = decimal.Parse(razlikaUDanima.ToString());



        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void roundButtonNatrag_Click(object sender, EventArgs e)
        {

            this.Hide();
            FrmGlavnaFormaAdmin glavna = new FrmGlavnaFormaAdmin();
            glavna.ShowDialog();
        }
    }
}
