using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_faza_1.Klase
{
    public class KorisnikKlasa
    {
        public int Korisnik_id { get; set; }
        private string Korisnicko_ime { get; set; }
        private string Lozinka { get; set; }
        public int Uloga_id { get; set; }
        public KorisnikKlasa korisnikKlasa { get; set; }
        public KorisnikKlasa()
        {

        }
        public KorisnikKlasa( string korisnicko_ime, string lozinka)
        {
            Korisnik_id = 0;
            Korisnicko_ime = korisnicko_ime;
            Lozinka = lozinka;
            Uloga_id = 1;
        }
    }
}
