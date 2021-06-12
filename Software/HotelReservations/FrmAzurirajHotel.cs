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
    public partial class FrmAzurirajHotel : Form
    {
      

        public FrmAzurirajHotel()
        {
            InitializeComponent();
       
        }

        private void FrmAzurirajHotel_Load(object sender, EventArgs e)
        {
         
            labelDodajHotel.BackColor = System.Drawing.Color.Transparent;
            oiblabel.BackColor = System.Drawing.Color.Transparent;
            ibanlabel.BackColor = System.Drawing.Color.Transparent;
            labelNaziv.BackColor = System.Drawing.Color.Transparent;
            telefonLabel.BackColor = System.Drawing.Color.Transparent;
            adresaLabel.BackColor = System.Drawing.Color.Transparent;
            emailLabel.BackColor = System.Drawing.Color.Transparent;
            kapacitetLabel.BackColor = System.Drawing.Color.Transparent;
            pictureBox2.BackColor = System.Drawing.Color.Transparent;

        }

        private void buttonAzurirajHotel_Click(object sender, EventArgs e)
        {
          
        }

        private void roundButtonNatrag_Click(object sender, EventArgs e)
        {
        
        }
    }
    }
