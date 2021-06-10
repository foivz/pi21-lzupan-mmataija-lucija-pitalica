using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotekeVanjske
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
        public static string ProvjeriSadrzaj(string naziv)
        {
            string povratnaPoruka = "";

            if (naziv.All(c => Char.IsLetterOrDigit(c) || c == ' ' || c == ':' || c == '.' || c == '!' || c == '?' || c == ',') == false)
            {
                povratnaPoruka += "Sadržaj može sadržavati samo slova,brojeve i neke specijalne znakove (?!:.,)!\n";
            }
            if (naziv == "")
            {
                povratnaPoruka += "Sadržaj mora biti unesen!\n";
            }
            return povratnaPoruka;
        }
        public static string ProvjeriNapomenu(string naziv)
        {
            string povratnaPoruka = "";

            if (naziv.All(c => Char.IsLetterOrDigit(c) || c == ' ' || c == ':' || c == '.' || c == '!' || c == '?' || c == ',') == false)
            {
                povratnaPoruka += "Napomena može sadržavati samo slova,brojeve i neke specijalne znakove (?!:.,)!\n";
            }
            if (naziv == "")
            {
                povratnaPoruka += "Napomena mora biti unesen!\n";
            }
            return povratnaPoruka;
        }
        public static string ProvjeriKupaonicu(string naziv)
        {
            string povratnaPoruka = "";

            if (naziv.All(c => Char.IsLetterOrDigit(c) || c == ' ' || c == ':' || c == '.' || c == '!' || c == '?' || c == ',') == false)
            {
                povratnaPoruka += "Kupaonica može sadržavati samo slova,brojeve i neke specijalne znakove (?!:.,)!\n";
            }
            if (naziv == "")
            {
                povratnaPoruka += "Kupaonica mora biti unesena!\n";
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

        public static string ProvjeriOIB(string OIB)
        {
            string povratnaPoruka = "";
            if (OIB.All(Char.IsDigit) == false)
            {
                povratnaPoruka += "OIB može sadržavati samo brojeve!\n";
            }
            if (OIB == "")
            {
                povratnaPoruka += "OIB mora biti unesen!\n";
            }
            return povratnaPoruka;
        }
        public static string ProvjeriBrojSobe(string OIB)
        {
            string povratnaPoruka = "";
            if (OIB.All(Char.IsDigit) == false)
            {
                povratnaPoruka += "Broj sobe može sadržavati samo brojeve!\n";
            }
            if (OIB == "")
            {
                povratnaPoruka += "Broj sobe mora biti unesen!\n";
            }
            return povratnaPoruka;
        }
        public static string ProvjeriVelicinu(string OIB)
        {
            string povratnaPoruka = "";
            if (OIB.All(Char.IsDigit) == false)
            {
                povratnaPoruka += "Veličina može sadržavati samo brojeve!\n";
            }
            if (OIB == "")
            {
                povratnaPoruka += "Veličina mora biti unesena!\n";
            }
            return povratnaPoruka;
        }
        public static string ProvjeriKapacitet(string OIB)
        {
            string povratnaPoruka = "";
            if (OIB.All(Char.IsDigit) == false)
            {
                povratnaPoruka += "Kapacitet sobe može sadržavati samo brojeve!\n";
            }
            if (OIB == "")
            {
                povratnaPoruka += "Kapacitet sobe mora biti unesen!\n";
            }
            return povratnaPoruka;
        }
        public static string ProvjeriIBAN(string IBAN)
        {
            string povratnaPoruka = "";
            if (IBAN.All(Char.IsLetterOrDigit) == false)
            {
                povratnaPoruka += "IBAN može sadržavati samo slova i brojeve!\n";
            }
            if (IBAN == "")
            {
                povratnaPoruka += "IBAN mora biti unesen!\n";
            }
            return povratnaPoruka;
        }

        public static string ProvjeriNaziv(string redatelj)
        {
            string povratnaPoruka = "";

            if (redatelj.All(c => Char.IsLetter(c) || c == ' ') == false)
            {
                povratnaPoruka += "Naziv hotela može sadržavati samo slova!\n";
            }
            if (redatelj == "")
            {
                povratnaPoruka += "Naziv hotela mora biti unesen!\n";
            }
            return povratnaPoruka;
        }
        public static string ProvjeriAdresu(string adresa)
        {
            string povratnaPoruka = "";

            if (adresa.All(c => Char.IsLetterOrDigit(c) || c == ' ' || c == ',') == false)
            {
                povratnaPoruka += "Adresa može sadržavati samo slova i brojeve!\n";
            }
            if (adresa == "")
            {
                povratnaPoruka += "Adresa mora biti unesena!\n";
            }
            return povratnaPoruka;
        }
        public static string ProvjeriTelefon(string naziv)
        {
            string povratnaPoruka = "";

            if (naziv.All(c => Char.IsLetterOrDigit(c) || c == '-' || c == '+' ) == false)
            {
                povratnaPoruka += "Telefon može sadržavati samo brojeve i  znakove (+ i -)!\n";
            }
            if (naziv == "")
            {
                povratnaPoruka += "Telefon mora biti unesen!\n";
            }
            return povratnaPoruka;
        }
        public static string ProvjeriEmail(string email)
        {
            string povratnaPoruka = "";

            if (new EmailAddressAttribute().IsValid(email) == false)
            {
                povratnaPoruka += "Email nije ispravnog formata!\n";
            }
            if (email == "")
            {
                povratnaPoruka += "Email mora biti unesen!\n";
            }
            return povratnaPoruka;
        }

        public static string ProvjeriBrojcanuVrijednost(string OIB)
        {
            string povratnaPoruka = "";
            if (OIB.All(Char.IsDigit) == false)
            {
                povratnaPoruka += "Ovo polje mora sadrzavati brojacnu vrijednost!\n";
            }
            if (OIB == "")
            {
                povratnaPoruka += "Niste popunili sva polja!\n";
            }
            return povratnaPoruka;
        }

        public static string ProvjeriPrezime(string prezime)
        {
            string povratnaPoruka = "";

            if (prezime.All(Char.IsLetter) == false)
            {
                povratnaPoruka += "Prezime može sadržavati samo slova!\n";
            }
            if (prezime == "")
            {
                povratnaPoruka += "Prezime mora biti uneseno!\n";
            }
            return povratnaPoruka;
        }

        public static string ProvjeriIme(string ime)
        {
            string povratnaPoruka = "";
            if (ime.All(Char.IsLetter) == false)
            {
                povratnaPoruka += "Ime može sadržavati samo slova!\n";
            }
            if (ime == "")
            {
                povratnaPoruka += "Ime mora biti uneseno!\n";
            }
            return povratnaPoruka;
        }

        //Gost
        public static string ProvjeriDrzavljanstvo(string drzavljanstvo)
        {
            string povratnaPoruka = "";
            if (drzavljanstvo == "")
            {
                povratnaPoruka += "Drzavljanstvo mora biti uneseno!\n";
            }
            return povratnaPoruka;
        }
        public static string ProvjeriCovidTest(string covidTest)
        {
            string povratnaPoruka = "";
            if (covidTest == "")
            {
                povratnaPoruka += "Covid test mora biti unesen!\n";
            }
            return povratnaPoruka;
        }

        public static string ProvjeriDatumRodjenja(string covidTest)
        {
            string povratnaPoruka = "";
            if (covidTest == "")
            {
                povratnaPoruka += "Datum rodjenja mora biti unesen!\n";
            }
            return povratnaPoruka;
        }
    }
}
