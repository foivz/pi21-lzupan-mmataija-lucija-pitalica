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
    public partial class FrmUpozorenje : Form
    {
        public FrmUpozorenje(string text)
        {
            InitializeComponent();
            upozorenjeTextBox.SelectionAlignment = HorizontalAlignment.Center;
            upozorenjeTextBox.Text = text;
        }

     
    }
}
