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
            int OIBgosta = int.Parse(textBoxOIB.Text);
            int brojSobe = int.Parse(textBoxBrojSobe.Text);
            string opis = opisTextBox.Text;
            HotelKlasa hotel = comboBoxHotel.SelectedItem as HotelKlasa;

            if (ProvjeraKorisnickogUnosa.ProvjeriPrijavuKvara(OIBgosta,brojSobe,opis,hotel) == "")
            {
                PrijavaKvaraKlasa prijavaKvara = new PrijavaKvaraKlasa();
                prijavaKvara.OIB_gosta = OIBgosta;
                prijavaKvara.Broj_sobe = brojSobe;
                prijavaKvara.Datum_prijave_kvara = DateTime.Now;
                prijavaKvara.Opis = opis;
                

                Klase.RepozitorijPrijavaKvara.DodajPrijavuKvara(prijavaKvara);


                this.Hide();
            }
            else
            {
                FrmUpozorenje frmUpozorenje = new FrmUpozorenje(ProvjeraKorisnickogUnosa.ProvjeriPrijavuKvara(OIBgosta, brojSobe, opis, hotel));
                frmUpozorenje.ShowDialog();
            }

        }

        private void roundButtonNatrag_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmGlavnaForma glavna = new FrmGlavnaForma();
            glavna.ShowDialog();
        }

        private void PrijavaKvara_Load(object sender, EventArgs e)
        {
            comboBoxHotel.DataSource = HotelRepozitorij.DohvatiHotele();
        }
    }
}
