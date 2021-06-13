using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_faza_1.Klase
{
    public class UpitKlasa
    {
        public int ID_upit { get; set; }
        public DateTime Datum_i_vrijeme_postavljanja_upita { get; set; }
        public string Opis { get; set; }
        public string OIB_hotela { get; set; }
        public string Kontakt { get; set; }
        public int Zaposlenik_OIB { get; set; }
        public string Zaposlenik_Ime { get; set; }
        public string Zaposlenik_Prezime { get; set; }
        public string Datum_odgovora { get; set; }
        public UpitKlasa()
        {

        }
    }
}
