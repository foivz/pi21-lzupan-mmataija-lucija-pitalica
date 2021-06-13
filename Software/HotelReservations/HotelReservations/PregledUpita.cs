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
    public partial class PregledUpita : Form
    {
        public PregledUpita()
        {
            InitializeComponent();

        }

        private void OsvjeziOdgovorene()
        {
            int zaposlenik = ZaposlenikRepozitorij.DohvatiZaposlenikaPoImenu(UlogiraniKorisnik.Korisnicko_ime, UlogiraniKorisnik.Lozinka).ID_zaposlenik;
            List<UpitKlasa> listaUpita = RepozitorijUpit.DohvatiOdgovoreneUpite(zaposlenik);
            if (listaUpita.Count != 0)
            {
                dataGridViewUpiti.DataSource = null;
                dataGridViewUpiti.DataSource = listaUpita;
                dataGridViewUpiti.Columns[0].Visible = false;
                dataGridViewUpiti.Columns[3].Visible = false;
            }
        }
        private void OsvjeziNeodgovorene()
        {
            int zaposlenik = ZaposlenikRepozitorij.DohvatiZaposlenikaPoImenu(UlogiraniKorisnik.Korisnicko_ime, UlogiraniKorisnik.Lozinka).ID_zaposlenik;
            List<UpitKlasa> listaUpita = RepozitorijUpit.DohvatiNeodgovoreneUpite(zaposlenik);
            if (listaUpita.Count != 0)
            {
                dataGridViewUpiti.DataSource = null;
                dataGridViewUpiti.DataSource = listaUpita;
                dataGridViewUpiti.Columns[0].Visible = false;
                dataGridViewUpiti.Columns[3].Visible = false;
                dataGridViewUpiti.Columns[5].Visible = false;
                dataGridViewUpiti.Columns[6].Visible = false;
                dataGridViewUpiti.Columns[7].Visible = false;
                dataGridViewUpiti.Columns[8].Visible = false;
                buttonOdgovori.Show();
            }

        }
        private void buttonOdgovori_Click(object sender, EventArgs e)
        {
            ZaposlenikKlasa zaposlenik = ZaposlenikRepozitorij.DohvatiZaposlenikaPoImenu(UlogiraniKorisnik.Korisnicko_ime, UlogiraniKorisnik.Lozinka);
            UpitKlasa odabraniUpit = dataGridViewUpiti.CurrentRow.DataBoundItem as UpitKlasa;
            if (odabraniUpit != null)
            {
                OdgovorNaUpit odgovorNaUpit = new OdgovorNaUpit(zaposlenik, odabraniUpit);
                odgovorNaUpit.ShowDialog();
                OsvjeziNeodgovorene();
            }
        }

        private void buttonNeodgovoreni_Click(object sender, EventArgs e)
        {
            OsvjeziNeodgovorene();
        }

        private void PregledUpita_Load(object sender, EventArgs e)
        {
            buttonOdgovori.Hide();
            labelUpiti.BackColor = System.Drawing.Color.Transparent;
        }

        private void buttonOdgovoreniUpiti_Click(object sender, EventArgs e)
        {
            buttonOdgovori.Hide();
            OsvjeziOdgovorene();
        }

        private void roundButtonNatrag_Click(object sender, EventArgs e)
        {

            this.Hide();
            FrmGlavnaFormaZaposlenik glavna = new FrmGlavnaFormaZaposlenik();
            glavna.ShowDialog();
        }
    }
}
