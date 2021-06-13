using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.ComponentModel.DataAnnotations;
using Projekt_faza_1.Klase;

namespace Projekt_faza_1
{
    public static class ProvjeraKorisnickogUnosa
    {
        public static string ProvjeriPrijavu(List<TextBox> lista)
        {
            string korIme = "";
            string lozinka = "";
            string povratnaPoruka = "";
            foreach (TextBox unos in lista)
            {
                if (unos.Name == "textBoxKorisnickoIme")
                {
                    korIme = unos.Text;
                    povratnaPoruka += BibliotekeVanjske.ValidacijaUnosa.ProvjeriKorisnickoIme(unos.Text);
                }
                if (unos.Name == "textBoxLozinka")
                {
                    lozinka = unos.Text;
                    povratnaPoruka += BibliotekeVanjske.ValidacijaUnosa.ProvjeriLozinku(unos.Text);
                }
            }
            if (povratnaPoruka == "")
            {

                if (BazaProvjeriPrijavu(korIme, lozinka) == false)
                {
                    povratnaPoruka += "Pogrešno korisničko ime ili lozinka!\n";
                }

            }
            return povratnaPoruka;
        }

        public static bool BazaProvjeriPrijavu(string korIme, string lozinka)
        {
            bool postojiKorisnik = false;
            List<KorisnikKlasa> lista = new List<KorisnikKlasa>();
            string sqlUpit = $"SELECT * FROM Korisnik ";
            SqlDataReader dr = DB.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                KorisnikKlasa korisnik = KorisnikRepozitorij.DohvatiKorisnika(dr);
                lista.Add(korisnik);
            }
            dr.Close();
            foreach (KorisnikKlasa korisnik in lista)
            {
                if (korisnik.Korisnicko_ime == korIme && korisnik.Lozinka == lozinka)
                {
                    postojiKorisnik = true;
                    UlogiraniKorisnik.Uloga_id = korisnik.Uloga_id;
                    UlogiraniKorisnik.Korisnicko_ime = korisnik.Korisnicko_ime;
                    UlogiraniKorisnik.Lozinka = korisnik.Lozinka;
                    UlogiraniKorisnik.Korisnik_id = korisnik.Korisnik_id;

                }
            }
            return postojiKorisnik;
        }


        public static string ProvjeriDodavanjeIzmjenuHotela(List<TextBox> lista)
        {
            string naziv_hotela = "";
            string adresa = "";
            string telefon = "";
            string email = "";
            string IBAN = "";
            string OIB = "";
            string povratnaPoruka = "";

            foreach (TextBox unos in lista)
            {
                if (unos.Name == "nazivtextBox")
                {
                    naziv_hotela = unos.Text;
                    povratnaPoruka += BibliotekeVanjske.ValidacijaUnosa.ProvjeriNaziv(unos.Text);
                }
                if (unos.Name == "adresaTextBox")
                {
                    adresa = unos.Text;
                    povratnaPoruka += BibliotekeVanjske.ValidacijaUnosa.ProvjeriAdresu(unos.Text);
                }
                if (unos.Name == "telefonTextBox")
                {
                    telefon = unos.Text;
                    povratnaPoruka += BibliotekeVanjske.ValidacijaUnosa.ProvjeriTelefon(unos.Text);
                }
                if (unos.Name == "emailTextBox")
                {
                    email = unos.Text;
                    povratnaPoruka += BibliotekeVanjske.ValidacijaUnosa.ProvjeriEmail(unos.Text);
                }
                if (unos.Name == "ibantextBox")
                {
                    IBAN = unos.Text;
                    povratnaPoruka += BibliotekeVanjske.ValidacijaUnosa.ProvjeriIBAN(unos.Text);
                }
                if (unos.Name == "oibtextBox")
                {
                    OIB = unos.Text;
                    povratnaPoruka += BibliotekeVanjske.ValidacijaUnosa.ProvjeriOIB(unos.Text);
                }
            }
            if (povratnaPoruka == "")
            {
                if (BazaProvjeriDodavanjeIzmjenuHotela(naziv_hotela, adresa, telefon, email, IBAN, OIB) == true)
                {
                    povratnaPoruka += "Postoji zapis sa istim podacima!\n";
                }
            }
            return povratnaPoruka;
        }
        public static bool BazaProvjeriDodavanjeIzmjenuHotela(string naziv_hotela, string adresa, string telefon, string email, string IBAN, string OIB)
        {
            bool postojiHotel = false;
            List<HotelKlasa> lista = new List<HotelKlasa>();
            string sqlUpit = $"SELECT * FROM Hotel";
            SqlDataReader dr = DB.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                HotelKlasa hotel = HotelRepozitorij.DohvatiHotel(dr);
                lista.Add(hotel);
            }
            dr.Close();
            foreach (HotelKlasa hotel in lista)
            {
                if (hotel.Naziv_hotel == naziv_hotela || hotel.Telefon == telefon || hotel.Adresa == adresa || hotel.Email == email)
                {
                    postojiHotel = true;
                }
            }
            return postojiHotel;
        }
        public static string ProvjeriIzmjenuHotela(List<TextBox> lista)
        {
            string naziv_hotela = "";
            string adresa = "";
            string telefon = "";
            string email = "";
            string IBAN = "";
            string OIB = "";
            string povratnaPoruka = "";

            foreach (TextBox unos in lista)
            {
                if (unos.Name == "nazivtextBox")
                {
                    naziv_hotela = unos.Text;
                    povratnaPoruka += BibliotekeVanjske.ValidacijaUnosa.ProvjeriNaziv(unos.Text);
                }
                if (unos.Name == "adresaTextBox")
                {
                    adresa = unos.Text;
                    povratnaPoruka += BibliotekeVanjske.ValidacijaUnosa.ProvjeriAdresu(unos.Text);
                }
                if (unos.Name == "telefonTextBox")
                {
                    telefon = unos.Text;
                    povratnaPoruka += BibliotekeVanjske.ValidacijaUnosa.ProvjeriTelefon(unos.Text);
                }
                if (unos.Name == "emailTextBox")
                {
                    email = unos.Text;
                    povratnaPoruka += BibliotekeVanjske.ValidacijaUnosa.ProvjeriEmail(unos.Text);
                }
                if (unos.Name == "ibantextBox")
                {
                    IBAN = unos.Text;
                    povratnaPoruka += BibliotekeVanjske.ValidacijaUnosa.ProvjeriIBAN(unos.Text);
                }

            }
            if (povratnaPoruka == "")
            {
                if (BazaProvjeriIzmjenuHotela(naziv_hotela, adresa, telefon, email, IBAN, OIB) == true)
                {
                    povratnaPoruka += "Postoji zapis sa istim podacima!\n";
                }
            }
            return povratnaPoruka;
        }
        public static bool BazaProvjeriIzmjenuHotela(string naziv_hotela, string adresa, string telefon, string email, string IBAN, string OIB)
        {
            bool postojiHotel = false;
            List<HotelKlasa> lista = new List<HotelKlasa>();
            string sqlUpit = $"SELECT * FROM Hotel";
            SqlDataReader dr = DB.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                HotelKlasa hotel = HotelRepozitorij.DohvatiHotel(dr);
                lista.Add(hotel);
            }
            dr.Close();

            return postojiHotel;
        }




    }
}
