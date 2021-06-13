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
        public Klase.SobaKlasa Soba { get; set; }
        public DateTime DatumDolaska { get; set; }
        public DateTime DatumOdlaska { get; set; }
        public RezervirajSobu(SobaKlasa soba, DateTime datumDolaska, DateTime datumOdlaska)
        {
            InitializeComponent();
            Soba = soba;
            DatumOdlaska = datumOdlaska;
            DatumDolaska = datumDolaska;
        }

        private void velicinaSobeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void cijenaLabel_Click(object sender, EventArgs e)
        {

        }

        private void RezervirajSobu_Load(object sender, EventArgs e)
        {
            brojSobeTextBox.Text = Soba.Broj_sobe;
            rezervirajSobuButton.Enabled = false;
            datumDolaskadateTimePicker.Value = DatumDolaska;
            datumDolaskadateTimePicker.Enabled = false;
            datumOdlaskadateTimePicker.Value = DatumOdlaska;
            datumOdlaskadateTimePicker.Enabled = false;
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

            ApstraktnaKlasaRezervacija.ID_soba = Soba.ID_soba;
            ApstraktnaKlasaRezervacija.OIB_gosta = 0;
            ApstraktnaKlasaRezervacija.Datum_rezervacije = DateTime.Now;
            ApstraktnaKlasaRezervacija.Datum_dolaska = datumDolaskadateTimePicker.Value;
            ApstraktnaKlasaRezervacija.Datum_odlaska = datumOdlaskadateTimePicker.Value;
            ApstraktnaKlasaRezervacija.Cijena = decimal.Parse(labelCijena.Text);
            UnosOsobnihPodataka unosForma = new UnosOsobnihPodataka();

            unosForma.ShowDialog();
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

            decimal ukupno = Soba.Cijena * dani;
            labelCijena.Visible = true;
            labelCijena.Text = (Soba.Cijena * dani).ToString();
            rezervirajSobuButton.Enabled = true;

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
