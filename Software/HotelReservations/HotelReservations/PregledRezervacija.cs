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
    public partial class PregledRezervacija : Form
    {
        public HotelKlasa HotelTrenutni { get; set; }
        public PregledRezervacija()
        {
            InitializeComponent();
            HotelTrenutni = HotelRepozitorij.DohvatiHotelPoZaposlenikovomImenu(UlogiraniKorisnik.Lozinka, UlogiraniKorisnik.Korisnicko_ime);
        }

        private void PregledRezervacija_Load(object sender, EventArgs e)
        {
            HotelKlasa hotel = HotelRepozitorij.DohvatiHotelPoZaposlenikovomImenu(UlogiraniKorisnik.Lozinka, UlogiraniKorisnik.Korisnicko_ime);
            buttonPrijaviGosta.Hide();
            buttonOdjaviGosta.Hide();
            labelPopisRezervacija.BackColor = System.Drawing.Color.Transparent;
        }

        private void buttonPrijaviGosta_Click(object sender, EventArgs e)
        {
            RezervacijaKlasa rezervacija = dataGridViewRezervacije.CurrentRow.DataBoundItem as RezervacijaKlasa;

            if (rezervacija != null)
            {
                rezervacija.Check_in = DateTime.Now.ToString();

                ProvjeraOsobnihPodataka provjeraOsobnihPodataka = new ProvjeraOsobnihPodataka(rezervacija);
                provjeraOsobnihPodataka.ShowDialog();
                OsvjeziNeprijavljene();
            }

        }
        private void OsvjeziNeprijavljene()
        {
            dataGridViewRezervacije.DataSource = null;
            List<RezervacijaKlasa> listaNeprijavljenihGostiju = RezervacijaRepozitorij.DohvatiRezervacijeZaDanasnjiDatumNeprijavljeneGoste(HotelTrenutni);
            if (listaNeprijavljenihGostiju.Count == 0)
            {
                buttonOdjaviGosta.Hide();
                buttonPrijaviGosta.Hide();

            }
            else if (listaNeprijavljenihGostiju.Count != 0)
            {
                dataGridViewRezervacije.DataSource = RezervacijaRepozitorij.DohvatiRezervacijeZaDanasnjiDatumNeprijavljeneGoste(HotelTrenutni);
                dataGridViewRezervacije.Columns[0].Visible = false;
                dataGridViewRezervacije.Columns[1].Visible = false;
                dataGridViewRezervacije.Columns[3].Visible = false;
                dataGridViewRezervacije.Columns[7].Visible = false;
                dataGridViewRezervacije.Columns[8].Visible = false;
                dataGridViewRezervacije.Columns[9].Visible = false;
                dataGridViewRezervacije.Columns[10].Visible = false;
                dataGridViewRezervacije.Columns[11].Visible = false;
                dataGridViewRezervacije.Columns[12].Visible = false;
                buttonPrijaviGosta.Show();
                buttonOdjaviGosta.Hide();

            }
        }
        private void OsvjeziPrijavljene()
        {

            dataGridViewRezervacije.DataSource = null;
            List<RezervacijaKlasa> listaPrijavljenihGostiju = RezervacijaRepozitorij.DohvatiPrijavljeneGoste(HotelTrenutni);
            if (listaPrijavljenihGostiju.Count == 0)
            {
                buttonOdjaviGosta.Hide();
                buttonPrijaviGosta.Hide();

            }
            else if (listaPrijavljenihGostiju.Count != 0)
            {
                dataGridViewRezervacije.DataSource = RezervacijaRepozitorij.DohvatiPrijavljeneGoste(HotelTrenutni);
                dataGridViewRezervacije.Columns[0].Visible = false;
                dataGridViewRezervacije.Columns[3].Visible = false;
                dataGridViewRezervacije.Columns[1].Visible = false;
                dataGridViewRezervacije.Columns[6].Visible = false;
                dataGridViewRezervacije.Columns[8].Visible = false;
                dataGridViewRezervacije.Columns[10].Visible = false;
                dataGridViewRezervacije.Columns[14].Visible = false;
                dataGridViewRezervacije.Columns[15].Visible = false;
                buttonOdjaviGosta.Show();
                buttonPrijaviGosta.Hide();
            }

        }

        private void buttonPregledNeprijavljenih_Click(object sender, EventArgs e)
        {
            OsvjeziNeprijavljene();
        }

        private void buttonPrijavljeniGosti_Click(object sender, EventArgs e)
        {
            OsvjeziPrijavljene();
        }

        private void buttonOdjaviGosta_Click(object sender, EventArgs e)
        {
            RezervacijaKlasa rezervacija = dataGridViewRezervacije.CurrentRow.DataBoundItem as RezervacijaKlasa;

            if (rezervacija != null)
            {
                rezervacija.Check_out = DateTime.Now.ToString();
                rezervacija.Zaposlenik_odjavio = ZaposlenikRepozitorij.DohvatiZaposlenikaPoImenu(UlogiraniKorisnik.Korisnicko_ime, UlogiraniKorisnik.Lozinka).ID_zaposlenik;
                RezervacijaRepozitorij.OdjaviGosta(rezervacija);
                OsvjeziPrijavljene();
            }
        }

        private void roundButtonNatrag_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmGlavnaFormaZaposlenik glavna = new FrmGlavnaFormaZaposlenik();
            glavna.ShowDialog();
        }
    }
}
