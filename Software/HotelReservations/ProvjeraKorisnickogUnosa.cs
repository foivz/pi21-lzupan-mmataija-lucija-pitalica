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
       
       
       
       
      

    }
}
