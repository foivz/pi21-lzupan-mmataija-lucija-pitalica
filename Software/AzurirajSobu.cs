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
        public Klase.SobaKlasa SobaProsljedjena { get; set; }
        public AzurirajSobu(Klase.SobaKlasa soba)
        {
            InitializeComponent();
            SobaProsljedjena = soba;
        }

        private void dodajSobubutton_Click(object sender, EventArgs e)
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
                RepozitorijSoba.IzmijeniSobu(soba);
                //this.ParentForm.Close();
            }
            else
            {
                FrmUpozorenje frmUpozorenje = new FrmUpozorenje(ProvjeraKorisnickogUnosa.ProvjeriIzmjenuSobe( velicina, kapacitet, sadrzaj, napomena, nazivHotela, sadrzajKupaonice));
                frmUpozorenje.ShowDialog();
            }
            this.Hide();
            
        }

        private void AzurirajSobu_Load(object sender, EventArgs e)
        {
            brojSobetextBox.Text = SobaProsljedjena.ID_soba.ToString();
            brojSobetextBox.Enabled = false;
            textBoxHotel.Text = SobaProsljedjena.OIB_hotela.ToString();
            textBoxHotel.Enabled = false;
            velicinaSobeTextBox.Text = SobaProsljedjena.VelicinaSobe.ToString();
            kapacitetTextBox.Text = SobaProsljedjena.Kapacitet.ToString();
            sadrzajSobeTextBox.Text = SobaProsljedjena.Sadrzaj_sobe;
            sadrzajKupaoniceTextBox.Text = SobaProsljedjena.Sadrzaj_kupaonice;
            textBoxNapomene.Text = SobaProsljedjena.Napomene;
            dodajSobuLabel.BackColor= System.Drawing.Color.Transparent;
            brojSobeLabel.BackColor= System.Drawing.Color.Transparent;
            oibHotelLabel.BackColor= System.Drawing.Color.Transparent;
            velicinaSobeLabel.BackColor= System.Drawing.Color.Transparent;
            kapacitetLabel.BackColor= System.Drawing.Color.Transparent;
            sadrzajSobeLabel.BackColor= System.Drawing.Color.Transparent;
            sadrzajKupaoniceLabel.BackColor= System.Drawing.Color.Transparent;
            label1.BackColor= System.Drawing.Color.Transparent;
            slikaLabel.BackColor= System.Drawing.Color.Transparent;

        }

        private void odustaniButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void roundButtonNatrag_Click(object sender, EventArgs e)
        {
            this.Hide();
            PregledHotela pregled = new PregledHotela();
            pregled.ShowDialog();
        }
    }
}
