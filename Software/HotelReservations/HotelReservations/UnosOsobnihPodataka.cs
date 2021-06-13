using Projekt_faza_1.Klase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

namespace Projekt_faza_1
{
    public partial class UnosOsobnihPodataka : Form
    {
        public UnosOsobnihPodataka()
        {
            InitializeComponent();
            
        }

        private void UnosOsobnihPodataka_Load(object sender, EventArgs e)
        {
            UcitajComboBox();
            unesiOsobnePodatkeLabel.BackColor = System.Drawing.Color.Transparent;
            pictureBox1.BackColor = System.Drawing.Color.Transparent;
            OIBGostaLabel.BackColor = System.Drawing.Color.Transparent;
            imeLabel.BackColor = System.Drawing.Color.Transparent;
            prezimeLabel.BackColor = System.Drawing.Color.Transparent;
            IBANlabel.BackColor = System.Drawing.Color.Transparent;
            telefonLabel.BackColor = System.Drawing.Color.Transparent;
            emailLabel.BackColor = System.Drawing.Color.Transparent;
            adresaLabel.BackColor = System.Drawing.Color.Transparent;
            drzavljanstvoLabel.BackColor = System.Drawing.Color.Transparent;
            covidTestLabel.BackColor = System.Drawing.Color.Transparent;
            datumRodjenjaLabel.BackColor = System.Drawing.Color.Transparent;
        }

        private void UcitajComboBox()
        {
            List<string> lista = new List<string>();
            lista.Add("DA");
            lista.Add("NE");
            comboBoxCovidTest.DataSource = lista;
        }

       

        private void odustaniButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void posaljiRezervacijuButton_Click(object sender, EventArgs e)
        {
            string OIB_gosta = OIBGostaTextBox.Text;
            string ime = imeTextBox.Text;
            string prezime = prezimeTextBox.Text;
            string IBAN = IBANTextBox.Text;
            string telefon = telefonTextBox.Text;
            string email = emailTextBox.Text;
            string adresa = adresaTextBox.Text;
            string drzavljanstvo = drzavljanstvoTextBox.Text;
            string covid_test = comboBoxCovidTest.SelectedItem.ToString();
            string datum_rodjenja = datumRodjenjaDateTimePicker.ToString();

            DateTime datum = DateTime.Parse(datumRodjenjaDateTimePicker.Text);
          

        }

        private void roundButtonNatrag_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmGlavnaFormaAdmin glavna = new FrmGlavnaFormaAdmin();
            glavna.ShowDialog();
        }

        private void comboBoxCovidTest_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void OIBGostaTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void OIBGostaLabel_Click(object sender, EventArgs e)
        {

        }

        private void prezimeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void prezimeLabel_Click(object sender, EventArgs e)
        {

        }

        private void imeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void imeLabel_Click(object sender, EventArgs e)
        {

        }

        private void IBANTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void IBANlabel_Click(object sender, EventArgs e)
        {

        }

        private void telefonTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void telefonLabel_Click(object sender, EventArgs e)
        {

        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void emailLabel_Click(object sender, EventArgs e)
        {

        }

        private void adresaLabel_Click(object sender, EventArgs e)
        {

        }

        private void adresaTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void drzavljanstvoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void drzavljanstvoLabel_Click(object sender, EventArgs e)
        {

        }

        private void covidTestLabel_Click(object sender, EventArgs e)
        {

        }

        private void datumRodjenjaDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void datumRodjenjaLabel_Click(object sender, EventArgs e)
        {

        }

        private void unesiOsobnePodatkeLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
