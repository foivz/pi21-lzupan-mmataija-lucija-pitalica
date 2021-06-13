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
    public partial class BrisanjeHotela : Form
    {
     
        public BrisanjeHotela()
        {
            InitializeComponent();
          
        }

        private void odustaniButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BrisanjeHotela_Load(object sender, EventArgs e)
        {
            labelObrisiHotel.BackColor = System.Drawing.Color.Transparent;
            oibLabel.BackColor = System.Drawing.Color.Transparent;
            ibanLabel.BackColor = System.Drawing.Color.Transparent;
            labelNaziv.BackColor = System.Drawing.Color.Transparent;
            telefonLabel.BackColor = System.Drawing.Color.Transparent;
            adresaLabel.BackColor = System.Drawing.Color.Transparent;
            emailLabel.BackColor = System.Drawing.Color.Transparent;
            kapacitetLabel.BackColor = System.Drawing.Color.Transparent;
        }

        private void buttonObrišiHotel_Click(object sender, EventArgs e)
        {
            
        }

        private void roundButtonNatrag_Click(object sender, EventArgs e)
        {
          
        }
    }
}
