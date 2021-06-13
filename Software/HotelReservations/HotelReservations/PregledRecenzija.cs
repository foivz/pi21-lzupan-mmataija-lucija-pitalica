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
    public partial class PregledRecenzija : Form
    {
        public PregledRecenzija()
        {
            InitializeComponent();
        }

        private void PregledRecenzija_Load(object sender, EventArgs e)
        {

            ZaposlenikKlasa zaposlenik = ZaposlenikRepozitorij.DohvatiZaposlenikaPoImenu(UlogiraniKorisnik.Korisnicko_ime, UlogiraniKorisnik.Lozinka);
            HotelKlasa hotel = HotelRepozitorij.DohvatiHotelPoZaposlenikovomImenu(UlogiraniKorisnik.Lozinka, UlogiraniKorisnik.Korisnicko_ime);
            dataGridViewRecenzije.DataSource = null;
            dataGridViewRecenzije.DataSource = RepozitorjRecenzija.DohvatiRecenzijePoHotelu(hotel);
            labelRecenzije.BackColor = System.Drawing.Color.Transparent;
        }

        private void roundButtonNatrag_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmGlavnaFormaZaposlenik glavna = new FrmGlavnaFormaZaposlenik();
            glavna.ShowDialog();
        }
    }
}
