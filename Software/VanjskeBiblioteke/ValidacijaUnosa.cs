using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VanjskeBiblioteke
{
    public static class ValidacijaUnosa
    {
        public static string ProvjeriKorisnickoIme(string korisnickoIme)
        {
            string povratnaPoruka = "";
            if (korisnickoIme.All(Char.IsLetterOrDigit) == false)
            {
                povratnaPoruka += "Korisničko ime može sadržavati samo slova i brojeve!\n";
            }
            if (korisnickoIme == "")
            {
                povratnaPoruka += "Korisničko ime mora biti uneseno!\n";
            }
            return povratnaPoruka;
        }

        public static string ProvjeriLozinku(string lozinka)
        {
            string povratnaPoruka = "";
            if (lozinka.All(Char.IsLetterOrDigit) == false)
            {
                povratnaPoruka += "Lozinka može sadržavati samo slova i brojeve!\n";
            }
            if (lozinka == "")
            {
                povratnaPoruka += "Lozinka mora biti unesena!\n";
            }
            return povratnaPoruka;
        }

    }
}
