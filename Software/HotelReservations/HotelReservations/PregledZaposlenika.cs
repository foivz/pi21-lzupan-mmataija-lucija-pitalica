using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projekt_faza_1.Klase;

namespace Projekt_faza_1
{
    public partial class PregledZaposlenika : Form
    {
        public Klase.HotelKlasa ProsljeđeniHotel { get; set; }
        public PregledZaposlenika(Klase.HotelKlasa hotel)
        {
                InitializeComponent();
                ProsljeđeniHotel = hotel;
        }

        private void PregledZaposlenika_Load(object sender, EventArgs e)
        {
            DohvatiZaposlenikeUDataGrid();
            pregledZaposlenikaLabel.BackColor = System.Drawing.Color.Transparent;
        }

        private void DohvatiZaposlenikeUDataGrid()
        {
            dataGridViewZaposlenik.DataSource = null;
            dataGridViewZaposlenik.DataSource = ZaposlenikRepozitorij.DohvatiZaposlenikePoHotelu(ProsljeđeniHotel).ToList();

        }

        private void buttonOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonDodajZaposlenika_Click(object sender, EventArgs e)
        {
            this.Hide();
            DodavanjeZaposlenika dodajZaposlenika = new DodavanjeZaposlenika(ProsljeđeniHotel);
            dodajZaposlenika.ShowDialog();
        }

        private void dataGridViewSoba_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void azurirajPodatkeButton_Click(object sender, EventArgs e)
        {
            if (dataGridViewZaposlenik.CurrentRow.DataBoundItem as ZaposlenikKlasa != null)
            {
                this.Hide();
                IzmjenaPodatakaZaposlenikaAdmin formaIzmjena = new IzmjenaPodatakaZaposlenikaAdmin(dataGridViewZaposlenik.CurrentRow.DataBoundItem as ZaposlenikKlasa);
                formaIzmjena.ShowDialog();
            }
        }

        private void obrisiZaposlenikaButton_Click(object sender, EventArgs e)
        {
          
        }

        private void roundButtonNatrag_Click(object sender, EventArgs e)
        {
            this.Hide();
            PregledHotela pregled = new PregledHotela();
            pregled.ShowDialog();
            

        }
    }
}
