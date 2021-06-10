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
            List<Korisnik> lista = new List<Korisnik>();
            string sqlUpit = $"SELECT * FROM Korisnik ";
            SqlDataReader dr = DB.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                Korisnik korisnik = KorisnikRepozitorij.DohvatiKorisnika(dr);
                lista.Add(korisnik);
            }
            dr.Close();
            foreach (Korisnik korisnik in lista)
            {
                if (korisnik.korisnicko_ime == korIme && korisnik.lozinka == lozinka)
                {
                    postojiKorisnik = true;
                    UlogiraniKorisnik.Uloga_id = korisnik.uloga_id;
                    UlogiraniKorisnik.Korisnicko_ime = korisnik.korisnicko_ime;
                    UlogiraniKorisnik.Lozinka = korisnik.lozinka;
                    UlogiraniKorisnik.Korisnik_id = korisnik.korisnik_id;

                }
            }
            return postojiKorisnik;
        }
        public static string ProvjeriDodavanjeIzmjenuZaposlenikaDodavanje(string OIB_zaposlenika, string ime, string prezime, string datum_rodjenja, string email,string adresa, string telefon,string  korisnicko_ime, string lozinka, string IBAN,string tip_zaposlenika)
        {

            string povratnaPoruka = "";
            povratnaPoruka += BibliotekeVanjske.ValidacijaUnosa.ProvjeriOIB(OIB_zaposlenika);
            povratnaPoruka += BibliotekeVanjske.ValidacijaUnosa.ProvjeriIme(ime);
            povratnaPoruka += BibliotekeVanjske.ValidacijaUnosa.ProvjeriPrezime(prezime);
            povratnaPoruka += BibliotekeVanjske.ValidacijaUnosa.ProvjeriDatumRodjenja(datum_rodjenja);
            povratnaPoruka += BibliotekeVanjske.ValidacijaUnosa.ProvjeriEmail(email);
            povratnaPoruka += BibliotekeVanjske.ValidacijaUnosa.ProvjeriAdresu(adresa);
            povratnaPoruka += BibliotekeVanjske.ValidacijaUnosa.ProvjeriTelefon(telefon);
            povratnaPoruka += BibliotekeVanjske.ValidacijaUnosa.ProvjeriKorisnickoIme(korisnicko_ime);
            povratnaPoruka += BibliotekeVanjske.ValidacijaUnosa.ProvjeriLozinku(lozinka);
            povratnaPoruka += BibliotekeVanjske.ValidacijaUnosa.ProvjeriIBAN(IBAN);
            
           
            
            
            if (povratnaPoruka == "")
            {
                /*if (BazaProvjeriDodavanjeIzmjenuZaposlenika(OIB_zaposlenika, IBAN) == true)
                {
                    povratnaPoruka += "Postoji zapis sa istim podacima!\n";
                }*/
            }
            return povratnaPoruka;
        }
        public static string ProvjeriDodavanjeIzmjenuZaposlenika(List<TextBox> lista)
        {
            string IBAN = "";
            int OIB_zaposlenika = 0;
            string povratnaPoruka = "";

            foreach (TextBox unos in lista)
            {
                if (unos.Name == "txtIBAN")
                {
                    IBAN = unos.Text;
                    povratnaPoruka += BibliotekeVanjske.ValidacijaUnosa.ProvjeriIBAN(unos.Text);
                }
                if (unos.Name == "txtOIB")
                {
                    OIB_zaposlenika = int.Parse(unos.Text);
                    povratnaPoruka += BibliotekeVanjske.ValidacijaUnosa.ProvjeriOIB(unos.Text);
                }

            }
            if (povratnaPoruka == "")
            {
                /*if (BazaProvjeriDodavanjeIzmjenuZaposlenika(OIB_zaposlenika, IBAN) == true)
                {
                    povratnaPoruka += "Postoji zapis sa istim podacima!\n";
                }*/
            }
            return povratnaPoruka;
        }
        public static bool BazaProvjeriDodavanjeIzmjenuZaposlenika(int OIB_zaposlenika, string IBAN)
        {
            bool postojiZaposlenik = false;
            List<ZaposlenikKlasa> lista = new List<ZaposlenikKlasa>();
            string sqlUpit = $"SELECT * FROM Zaposlenik";
            SqlDataReader dr = DB.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                ZaposlenikKlasa zaposlenik = ZaposlenikRepozitorij.DohvatiZaposlenika(dr);
                lista.Add(zaposlenik);
            }
            dr.Close();
            foreach (ZaposlenikKlasa zaposlenik in lista)
            {
                if (zaposlenik.OIB_zaposlenika == OIB_zaposlenika || zaposlenik.IBAN == IBAN)
                {
                    postojiZaposlenik = true;
                }
            }
            return postojiZaposlenik;
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
                if (hotel.Naziv_hotel == naziv_hotela ||  hotel.Telefon == telefon || hotel.Adresa == adresa || hotel.Email == email)
                {
                    postojiHotel = true;
                }
            }
            return postojiHotel;
        }


        ///soba
        public static string ProvjeriDodavanjeIzmjenuSobe(string brojSobe, string velicina, string kapacitet, string sadrzaj, string napomena, string nazivHotela, string sadrzajKupaonice)
        {

            string povratnaPoruka = "";
            povratnaPoruka += BibliotekeVanjske.ValidacijaUnosa.ProvjeriBrojSobe(brojSobe);
            povratnaPoruka += BibliotekeVanjske.ValidacijaUnosa.ProvjeriVelicinu(velicina);
            povratnaPoruka += BibliotekeVanjske.ValidacijaUnosa.ProvjeriKapacitet(kapacitet);
            povratnaPoruka += BibliotekeVanjske.ValidacijaUnosa.ProvjeriSadrzaj(sadrzaj);
            povratnaPoruka += BibliotekeVanjske.ValidacijaUnosa.ProvjeriNapomenu(napomena);

            povratnaPoruka += BibliotekeVanjske.ValidacijaUnosa.ProvjeriKupaonicu(sadrzajKupaonice);
            if (povratnaPoruka == "")
            {
                if (BazaProvjeriDodavanjeIzmjenuSobe(brojSobe, velicina, kapacitet, sadrzaj, napomena, nazivHotela, sadrzajKupaonice) == true)
                {
                    povratnaPoruka += "Postoji zapis sa istim podacima!\n";
                }
            }
            return povratnaPoruka;
        }
        public static string ProvjeriIzmjenuSobe(string velicina, string kapacitet, string sadrzaj, string napomena, string nazivHotela, string sadrzajKupaonice)
        {

            string povratnaPoruka = "";
            
            povratnaPoruka += BibliotekeVanjske.ValidacijaUnosa.ProvjeriVelicinu(velicina);
            povratnaPoruka += BibliotekeVanjske.ValidacijaUnosa.ProvjeriKapacitet(kapacitet);
            povratnaPoruka += BibliotekeVanjske.ValidacijaUnosa.ProvjeriSadrzaj(sadrzaj);
            povratnaPoruka += BibliotekeVanjske.ValidacijaUnosa.ProvjeriNapomenu(napomena);

            povratnaPoruka += BibliotekeVanjske.ValidacijaUnosa.ProvjeriKupaonicu(sadrzajKupaonice);
          
            return povratnaPoruka;
        }
        public static bool BazaProvjeriDodavanjeIzmjenuSobe(string brojSobe, string velicina, string kapacitet, string sadrzaj, string napomena, string nazivHotela, string sadrzajKupaonice)
        {
            bool postojiSoba = false;
            List<SobaKlasa> lista = new List<SobaKlasa>();
            string sqlUpit = $"SELECT * FROM Soba";
            SqlDataReader dr = DB.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                SobaKlasa soba = RepozitorijSoba.DohvatiSobu(dr);
                lista.Add(soba);
            }
            dr.Close();
            foreach (SobaKlasa soba in lista)
            {
                if (soba.ID_soba == int.Parse(brojSobe) && soba.OIB_hotela == nazivHotela)
                {
                    postojiSoba = true;
                }
            }
            return postojiSoba;
        }
        



        //Gost unos provjera
        public static string ProvjeriDodavanjeIzmjenuGosta(string OIB_gosta, string ime, string prezime, string IBAN, string telefon, string email, string adresa, string drzavljanstvo, string covid_test, string datum_rodjenja)
        {

            string povratnaPoruka = "";
            povratnaPoruka += BibliotekeVanjske.ValidacijaUnosa.ProvjeriOIB(OIB_gosta);
            povratnaPoruka += BibliotekeVanjske.ValidacijaUnosa.ProvjeriIme(ime);
            povratnaPoruka += BibliotekeVanjske.ValidacijaUnosa.ProvjeriPrezime(prezime);
            povratnaPoruka += BibliotekeVanjske.ValidacijaUnosa.ProvjeriIBAN(IBAN);
            povratnaPoruka += BibliotekeVanjske.ValidacijaUnosa.ProvjeriTelefon(telefon);
            povratnaPoruka += BibliotekeVanjske.ValidacijaUnosa.ProvjeriAdresu(adresa);
            povratnaPoruka += BibliotekeVanjske.ValidacijaUnosa.ProvjeriDrzavljanstvo(drzavljanstvo);
            povratnaPoruka += BibliotekeVanjske.ValidacijaUnosa.ProvjeriCovidTest(covid_test);
            povratnaPoruka += BibliotekeVanjske.ValidacijaUnosa.ProvjeriDatumRodjenja(datum_rodjenja);
            if (povratnaPoruka == "")
            {
                if (BazaProvjeriDodavanjeIzmjenuGosta(OIB_gosta) == true)
                {
                    povratnaPoruka += "Postoji zapis sa istim podacima!\n";
                }
            }
            return povratnaPoruka;
        }

        public static bool BazaProvjeriDodavanjeIzmjenuGosta(string OIB_gosta)
        {
            bool postojiGost = false;
            List<GostKlasa> lista = new List<GostKlasa>();
            string sqlUpit = $"SELECT * FROM Gost";
            SqlDataReader dr = DB.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                GostKlasa gost = GostRepozitorij.DohvatiGosta(dr);
                lista.Add(gost);
            }
            dr.Close();
            foreach (GostKlasa gost in lista)
            {
                if (gost.OIB_gost == int.Parse(OIB_gosta))
                {
                    postojiGost = true;
                }
            }
            return postojiGost;

        }
        //Provjeri recenziju
        public static string ProvjeriRecenziju(int OIBgosta, int brojSobe, string opis, int ocjena,HotelKlasa hotel)
        {

            string povratnaPoruka = "";
            povratnaPoruka += BibliotekeVanjske.ValidacijaUnosa.ProvjeriOIB(OIBgosta.ToString());
            povratnaPoruka += BibliotekeVanjske.ValidacijaUnosa.ProvjeriBrojSobe(brojSobe.ToString());
            povratnaPoruka += BibliotekeVanjske.ValidacijaUnosa.ProvjeriSadrzaj(opis);
            if (povratnaPoruka == "")
            {

                if (BazaProvjeriDodavanjeRecenzije(OIBgosta,brojSobe, hotel) == false)
                {
                    povratnaPoruka += "Niste boravili u ovoj sobi!\n";
                }
            }
            return povratnaPoruka;
        }
        public static bool BazaProvjeriDodavanjeRecenzije(int OIB_gosta,int brojSobe,HotelKlasa hotel)
        {
            bool postojiGost = false;
            List<GostKlasa> lista = new List<GostKlasa>();
            string sqlUpit = $"SELECT * FROM Gost";
            SqlDataReader dr = DB.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                GostKlasa gost = GostRepozitorij.DohvatiGosta(dr);
                lista.Add(gost);
            }
            dr.Close();

            List<SobaKlasa> listaSoba = RepozitorijSoba.DohvatiSobePoHotelu(hotel);
            List<RezervacijaKlasa> listaRezervacija = RezervacijaRepozitorij.DohvatiRezervacijeGostaPoOIB(OIB_gosta.ToString());
            foreach (SobaKlasa soba in listaSoba)
            {
                foreach (RezervacijaKlasa rezervacija in listaRezervacija)
                {
                    if (soba.Broj_sobe==brojSobe.ToString() && soba.ID_soba==rezervacija.Id_soba)
                    {
                        postojiGost = true;
                    }
                }
            }
            return postojiGost;

        }
        public static string ProvjeriPrijavuKvara(int OIBgosta, int brojSobe, string opis, HotelKlasa hotel)
        {

            string povratnaPoruka = "";
            povratnaPoruka += BibliotekeVanjske.ValidacijaUnosa.ProvjeriOIB(OIBgosta.ToString());
            povratnaPoruka += BibliotekeVanjske.ValidacijaUnosa.ProvjeriBrojSobe(brojSobe.ToString());
            povratnaPoruka += BibliotekeVanjske.ValidacijaUnosa.ProvjeriSadrzaj(opis);
            if (povratnaPoruka == "")
            {

                if (BazaProvjeriPrijavuKvara(OIBgosta, brojSobe, hotel) == false)
                {
                    povratnaPoruka += "Niste boravili u sobi za koju želite prijaviti kvar!\n";
                }
            }
            return povratnaPoruka;
        }
        public static bool BazaProvjeriPrijavuKvara(int OIB_gosta, int brojSobe, HotelKlasa hotel)
        {
            bool postojiGost = false;
            List<GostKlasa> lista = new List<GostKlasa>();
            string sqlUpit = $"SELECT * FROM Gost";
            SqlDataReader dr = DB.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                GostKlasa gost = GostRepozitorij.DohvatiGosta(dr);
                lista.Add(gost);
            }
            dr.Close();

            List<SobaKlasa> listaSoba = RepozitorijSoba.DohvatiSobePoHotelu(hotel);
            List<RezervacijaKlasa> listaRezervacija = RezervacijaRepozitorij.DohvatiRezervacijeGostaPoOIB(OIB_gosta.ToString());
            foreach (SobaKlasa soba in listaSoba)
            {
                foreach (RezervacijaKlasa rezervacija in listaRezervacija)
                {
                    if (soba.Broj_sobe == brojSobe.ToString() && soba.ID_soba == rezervacija.Id_soba)
                    {
                        postojiGost = true;
                    }
                }
            }
            return postojiGost;

        }

    }
}
