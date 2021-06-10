using Bogus.DataSets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_faza_1.Klase
{
    public class SobaKlasa
    {
        public int ID_soba { get; set; }
        public string OIB_hotela { get; set; }
        public int VelicinaSobe { get; set; }
        public int Kapacitet { get; set; }
        public string Sadrzaj_sobe { get; set; }
        public string Sadrzaj_kupaonice { get; set; }
        public string Napomene { get; set; }
        public int Slobodna { get; set; }
        public string Broj_sobe { get; set; }
        public decimal Cijena { get; set; }

        public SobaKlasa()
        {

        }
    }
}
