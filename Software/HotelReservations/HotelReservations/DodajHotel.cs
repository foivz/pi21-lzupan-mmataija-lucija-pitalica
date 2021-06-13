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
    public partial class DodajHotel : Form
    {
        public DodajHotel()
        {
            InitializeComponent();
        }

        private void odustaniButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DodajHotel_Load(object sender, EventArgs e)
        {
            oibLabel.BackColor = System.Drawing.Color.Transparent;
            ibanLabel.BackColor = System.Drawing.Color.Transparent;
            labelNaziv.BackColor = System.Drawing.Color.Transparent;
            telefonLabel.BackColor = System.Drawing.Color.Transparent;
            adresaLabel.BackColor = System.Drawing.Color.Transparent;
            emailLabel.BackColor = System.Drawing.Color.Transparent;
            kapacitetLabel.BackColor = System.Drawing.Color.Transparent;
            labelDodajHotel.BackColor = System.Drawing.Color.Transparent;
            pictureBox2.BackColor = System.Drawing.Color.Transparent;
        }

        private void dodajHotelButton_Click(object sender, EventArgs e)
        {
            

        }

        private void roundButton_Click(object sender, EventArgs e)
        {
         
        }
    }
}
