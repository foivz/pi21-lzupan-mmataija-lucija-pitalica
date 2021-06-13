using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_faza_1.Klase
{
    public class PrijavaKvaraKlasa
    {
        public int ID_prijava { get; set; }
        public int OIB_gosta { get; set; }
        public int Broj_sobe { get; set; }
        public DateTime Datum_prijave_kvara { get; set; }
        public string Opis { get; set; }
        public string OIB_hotela { get; set; }
        public PrijavaKvaraKlasa()
        {

        }
    }
}
