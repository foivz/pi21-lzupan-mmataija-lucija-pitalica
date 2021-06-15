using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_faza_1.Klase
{
    public class GostKlasa
    {
        public int ID_gost { get; set; }
        public int OIB_gost { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string IBAN { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public string Adresa { get; set; }
        public string Drzavljanstvo { get; set; }
        public string Covid_test { get; set; }
        public DateTime Datum_rodjenja { get; set; }
        public GostKlasa()
        {

        }
    }
}
