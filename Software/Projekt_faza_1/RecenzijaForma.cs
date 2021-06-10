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
    public partial class RecenzijaForma : Form
    {
        public RecenzijaForma()
        {
            InitializeComponent();
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
            int ocjena = (int)numericUpDownOcjena.Value;
            string datum = DateTime.Now.ToString();
            HotelKlasa hotel = comboBoxAdresaiNaziv.SelectedItem as HotelKlasa;
           


            if (ProvjeraKorisnickogUnosa.ProvjeriRecenziju(OIBgosta, brojSobe, opis, ocjena, hotel) == "")
            {
                RecenzijaKlasa recenzija = new RecenzijaKlasa();
                recenzija.OIB_gosta = OIBgosta;
                recenzija.Broj_sobe = brojSobe;
                recenzija.Datum_recenzije = DateTime.Now;
                recenzija.Opis = opis;
                recenzija.Ocjena = ocjena;
                

                Klase.RepozitorjRecenzija.DodajRecenziju(recenzija);


                this.Hide();
            }
            else
            {
                FrmUpozorenje frmUpozorenje = new FrmUpozorenje(ProvjeraKorisnickogUnosa.ProvjeriRecenziju(OIBgosta, brojSobe, opis, ocjena, hotel));
                frmUpozorenje.ShowDialog();
            }

        }

        private void roundButtonNatrag_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmGlavnaForma glavna = new FrmGlavnaForma();
            glavna.ShowDialog();
        }

        private void RecenzijaForma_Load(object sender, EventArgs e)
        {
            comboBoxAdresaiNaziv.DataSource = HotelRepozitorij.DohvatiHotele();
        }
    }
}
