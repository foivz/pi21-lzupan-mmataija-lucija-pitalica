using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_faza_1.Klase
{
    public class TipZaposlenikaKlasa
    {
        public string ID_tip { get; set; }
        public string Naziv { get; set; }
        public TipZaposlenikaKlasa()
        {

        }
        public override string ToString()
        {
            return this.Naziv;
        }
    }
}
