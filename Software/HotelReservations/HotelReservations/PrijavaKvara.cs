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
    public partial class PrijavaKvara : Form
    {
        public PrijavaKvara()
        {
            InitializeComponent();
        }

        private void naslovLabel_Click(object sender, EventArgs e)
        {

        }

        private void odustaniButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPosalji_Click(object sender, EventArgs e)
        {
            string opis = opisTextBox.Text;
            HotelKlasa hotel = comboBoxHotel.SelectedItem as HotelKlasa;
            string OIB_hotela = hotel.OIB_Hotela;

            if (ProvjeraKorisnickogUnosa.ProvjeriPrijavuKvara(textBoxOIB.Text, textBoxBrojSobe.Text, opis, hotel) == "")
            {
                int OIBgosta = int.Parse(textBoxOIB.Text);
                int brojSobe = int.Parse(textBoxBrojSobe.Text);
                PrijavaKvaraKlasa prijavaKvara = new PrijavaKvaraKlasa();
                prijavaKvara.OIB_gosta = OIBgosta;
                prijavaKvara.Broj_sobe = brojSobe;
                prijavaKvara.Datum_prijave_kvara = DateTime.Now;
                prijavaKvara.Opis = opis;
                prijavaKvara.OIB_hotela = OIB_hotela;


                Klase.RepozitorijPrijavaKvara.DodajPrijavuKvara(prijavaKvara);
            }
            else {
                FrmUpozorenje frmUpozorenje = new FrmUpozorenje(ProvjeraKorisnickogUnosa.ProvjeriPrijavuKvara(textBoxOIB.Text, textBoxBrojSobe.Text, opis, hotel));
                frmUpozorenje.ShowDialog();
            }

            }

        private void roundButtonNatrag_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmGlavnaFormaGost glavna = new FrmGlavnaFormaGost();
            glavna.ShowDialog();
        }

        private void PrijavaKvara_Load(object sender, EventArgs e)
        {
            comboBoxHotel.DataSource = HotelRepozitorij.DohvatiHotele();
            pictureBox1.BackColor = System.Drawing.Color.Transparent;
            naslovLabel.BackColor = System.Drawing.Color.Transparent;
            labelOIBGosta.BackColor = System.Drawing.Color.Transparent;
            labelHotel.BackColor = System.Drawing.Color.Transparent;
            labelBrojSobe.BackColor = System.Drawing.Color.Transparent;
            labelOpis.BackColor = System.Drawing.Color.Transparent;
        }

        private void comboBoxHotel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
