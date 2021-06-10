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
    public partial class ObrisiSobu : Form
    {
        public Klase.SobaKlasa SobaProsljeđena { get; set; }
        public ObrisiSobu(Klase.SobaKlasa soba)
        {
            InitializeComponent();
            SobaProsljeđena = soba;
        }

        private void ObrisiSobu_Load(object sender, EventArgs e)
        {
            brojSobetextBox.Text = SobaProsljeđena.ID_soba.ToString();
            brojSobetextBox.Enabled = false;
            textBoxHotel.Text = SobaProsljeđena.OIB_hotela.ToString();
            textBoxHotel.Enabled = false;
            velicinaSobeTextBox.Text = SobaProsljeđena.VelicinaSobe.ToString();
            velicinaSobeTextBox.Enabled = false;
            kapacitetTextBox.Text = SobaProsljeđena.Kapacitet.ToString();
            kapacitetTextBox.Enabled = false;
            sadrzajSobeTextBox.Text = SobaProsljeđena.Sadrzaj_sobe;
            sadrzajSobeTextBox.Enabled = false;
            sadrzajKupaoniceTextBox.Text = SobaProsljeđena.Sadrzaj_kupaonice;
            sadrzajKupaoniceTextBox.Enabled = false;
            textBoxNapomene.Text = SobaProsljeđena.Napomene;
            textBoxNapomene.Enabled = false;


        }

        private void odustaniButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void obrisiSobubutton_Click(object sender, EventArgs e)
        {
            string brojSobe = brojSobetextBox.Text;
            string nazivHotela = textBoxHotel.Text;
            string velicina = velicinaSobeTextBox.Text;
            string kapacitet = kapacitetTextBox.Text;
            string sadrzaj = sadrzajSobeTextBox.Text;
            string sadrzajKupaonice = sadrzajKupaoniceTextBox.Text;
            string napomena = textBoxNapomene.Text;

            if (ProvjeraKorisnickogUnosa.ProvjeriIzmjenuSobe(velicina, kapacitet, sadrzaj, napomena, nazivHotela, sadrzajKupaonice) == "")
            {
                SobaKlasa soba = new SobaKlasa();
                soba.ID_soba = int.Parse(brojSobe);
                soba.VelicinaSobe = int.Parse(velicina);
                soba.Kapacitet = int.Parse(kapacitet);
                soba.Sadrzaj_sobe = sadrzaj;
                soba.Sadrzaj_kupaonice = sadrzajKupaonice;
                soba.Napomene = napomena;
                soba.OIB_hotela = nazivHotela;
                RepozitorijSoba.ObrisiSobu(soba);
                this.Hide();
            }
            else
            {
                FrmUpozorenje frmUpozorenje = new FrmUpozorenje(ProvjeraKorisnickogUnosa.ProvjeriIzmjenuSobe(velicina, kapacitet, sadrzaj, napomena, nazivHotela, sadrzajKupaonice));
                frmUpozorenje.ShowDialog();
            }
        }
    }
}
