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
            if(korisnickoIme.Count()<3 || korisnickoIme.Count()>20)
            {
                povratnaPoruka += "Korisničko ime mora imati između 3 i 20 znakova!\n";
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
                povratnaPoruka += "Napomena mora biti unesena!\n";
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
            if (lozinka.Count()<5 || lozinka.Count()>16)
            {
                povratnaPoruka += "Lozinka mora imati najmanje 5 znakova!\n";
            }
            if (lozinka.Count() > 16)
            {
                povratnaPoruka += "Lozinka može imati najviše 16 znakova!\n";
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
            if (OIB.Count() >5 || OIB.Count()<5)
            {
                povratnaPoruka += "OIB mora imati 5 znakova!\n";
            }
            return povratnaPoruka;
        }
        public static string ProvjeriBrojSobe(string broj)
        {
            string povratnaPoruka = "";
            if (broj.All(Char.IsDigit) == false)
            {
                povratnaPoruka += "Broj sobe može sadržavati samo brojeve!\n";
            }
            if (broj == "")
            {
                povratnaPoruka += "Broj sobe mora biti unesen!\n";
            }
            if (broj.Count() > 6)
            {
                povratnaPoruka += "Broj sobe ne može imati više od 6 znakova!\n";
            }
            return povratnaPoruka;
        }
        public static string ProvjeriVelicinu(string velicina)
        {
            string povratnaPoruka = "";
            if (velicina.All(Char.IsDigit) == false)
            {
                povratnaPoruka += "Veličina može sadržavati samo brojeve!\n";
            }
            if (velicina == "")
            {
                povratnaPoruka += "Veličina mora biti unesena!\n";
            }
            if (velicina.Count() > 7)
            {
                povratnaPoruka += "Veličina ne može imati više od 7 znakova!\n";
            }
            return povratnaPoruka;
        }
        public static string ProvjeriKapacitet(string kapacitet)
        {
            string povratnaPoruka = "";
            if (kapacitet.All(Char.IsDigit) == false)
            {
                povratnaPoruka += "Kapacitet sobe može sadržavati samo brojeve!\n";
            }
            if (kapacitet == "")
            {
                povratnaPoruka += "Kapacitet sobe mora biti unesen!\n";
            }
            if (kapacitet.Count()==0)
            {
                povratnaPoruka += "Kapacitet sobe ne može biti nula!\n";
            }
            if (kapacitet.Count() > 2)
            {
                povratnaPoruka += "Kapacitet sobe ne može imati više od 2 znaka!\n";
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
            if(IBAN.Count() < 21)
            {
                povratnaPoruka += "IBAN mora sadržavati 21 znak!\n";
            }
            if (IBAN == "")
            {
                povratnaPoruka += "IBAN mora biti unesen!\n";
            }
            if (IBAN.Count() > 21)
            {
                povratnaPoruka += "IBAN mora sadržavati 21 znak, a ne više od 21!\n";
            }
            return povratnaPoruka;
        }

        public static string ProvjeriNaziv(string naziv)
        {
            string povratnaPoruka = "";

            if (naziv.All(c => Char.IsLetter(c) || c == ' ') == false)
            {
                povratnaPoruka += "Naziv hotela može sadržavati samo slova!\n";
            }
            if (naziv == "")
            {
                povratnaPoruka += "Naziv hotela mora biti unesen!\n";
            }
            if (naziv.Count() <3)
            {
                povratnaPoruka += "Naziv hotela ne može imati manje od 3 slova!\n";
            }
            if (naziv.Count() > 15)
            {
                povratnaPoruka += "Naziv hotela ne može imati više od 15 slova!\n";
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
            if (adresa.Count()<10)
            {
                povratnaPoruka += "Adresa ne može imati manje od 10 znakova!\n";
            }
            if (adresa.Count() > 50)
            {
                povratnaPoruka += "Adresa ne može imati više od 50 znakova!\n";
            }
            return povratnaPoruka;
        }
        public static string ProvjeriTelefon(string telefon)
        {
            string povratnaPoruka = "";

            if (telefon.All(c => Char.IsDigit(c) || c == '-' || c == '+' ) == false)
            {
                povratnaPoruka += "Telefon može sadržavati samo brojeve i  znakove (+ i -)!\n";
            }
            if (telefon == "")
            {
                povratnaPoruka += "Telefon mora biti unesen!\n";
            }
            if (telefon.Count()<6)
            {
                povratnaPoruka += "Telefon ne može imati manje od 6 znakova!\n";
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

        public static string ProvjeriBrojcanuVrijednost(string broj)
        {
            string povratnaPoruka = "";
            if (broj.All(Char.IsDigit) == false)
            {
                povratnaPoruka += "Ovo polje mora sadrzavati brojacnu vrijednost!\n";
            }
            if (broj == "")
            {
                povratnaPoruka += "Niste popunili sva polja!\n";
            }
            if (broj.Count()>11)
            {
                povratnaPoruka += "Brojcana vrijednost ne može imati više od 11 znakova!\n";
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
            if (prezime.Count()>20)
            {
                povratnaPoruka += "Prezime ne može imati više od 20 slova!\n";
            }
            if (prezime.Count() < 3)
            {
                povratnaPoruka += "Prezime ne može imati manje od 3 slova!\n";
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
            if (ime.Count() <3)
            {
                povratnaPoruka += "Ime ne može imati manje od 3 slova!\n";
            }
            if (ime.Count() > 15)
            {
                povratnaPoruka += "Ime ne može imati više od 15 slova!\n";
            }
            return povratnaPoruka;
        }

        public static string ProvjeriDrzavljanstvo(string drzavljanstvo)
        {
            string povratnaPoruka = "";
            if (drzavljanstvo.All(Char.IsLetter) == false)
            {
                povratnaPoruka += "Državljanstvo može sadržavati samo slova!\n";
            }
            if (drzavljanstvo == "")
            {
                povratnaPoruka += "Drzavljanstvo mora biti uneseno!\n";
            }
            if (drzavljanstvo.Count()<5)
            {
                povratnaPoruka += "Drzavljanstvo ne može imati manje od 5 slova!\n";
            }
            if (drzavljanstvo.Count() > 15)
            {
                povratnaPoruka += "Drzavljanstvo ne može imati više od 15 slova!\n";
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
            if (covidTest.Count()>3)
            {
                povratnaPoruka += "Covid test ne može imati više od 3 slova!\n";
            }
            if (covidTest.Count() < 2)
            {
                povratnaPoruka += "Covid test ne može imati manje od 2 slova!\n";
            }
            return povratnaPoruka;
        }

        public static string ProvjeriDatumRodjenja(string datumRodjenja)
        {
            string povratnaPoruka = "";
            if (datumRodjenja == "")
            {
                povratnaPoruka += "Datum rodjenja mora biti unesen!\n";
            }

            return povratnaPoruka;
        }
    }
}
