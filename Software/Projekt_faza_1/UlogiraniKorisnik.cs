using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_faza_1
{
   public abstract class UlogiraniKorisnik
    {
        public static int Uloga_id { get; set; }
        public static int Korisnik_id { get; set; }
        public static string Korisnicko_ime { get; set; }
        public static string Lozinka { get; set; }



        public static void Odjava()
        {
            Uloga_id = 0;
            Korisnik_id = 0;
            Korisnicko_ime = null;
            Lozinka = null;
 
        }
    }
}
