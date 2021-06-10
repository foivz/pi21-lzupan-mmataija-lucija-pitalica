using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_faza_1.Klase
{
    public class Izvjesca
    {
        public int ID_izvjesca { get; set; }
        public int OIB_zaposlenika { get; set; }
        public DateTime Vrijeme_od { get; set; }
        public DateTime Vrijeme_do { get; set; }
        public Izvjesca()
        {

        }
    }
}
