using Projekt_faza_1.Klase;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_faza_1
{
    public class KorisnikRepozitorij
    {
        public static KorisnikKlasa DohvatiKorisnika(SqlDataReader dr)
        {
            KorisnikKlasa korisnik = null;
            if (dr != null)
            {
                korisnik = new KorisnikKlasa();
                korisnik.Korisnik_id = int.Parse(dr["korisnik_id"].ToString());
                korisnik.Korisnicko_ime= dr["korisnicko_ime"].ToString();
                korisnik.Lozinka= dr["lozinka"].ToString();
                korisnik.Uloga_id= int.Parse(dr["uloga_id"].ToString());
           
            }
            return korisnik;
        }
        public static List<KorisnikKlasa> DohvatiKorisnike()
        {
            List<KorisnikKlasa> lista = new List<KorisnikKlasa>();
            string sqlUpit = $"SELECT * FROM Korisnik";
            SqlDataReader dr = (SqlDataReader)DB.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                KorisnikKlasa korisnik = DohvatiKorisnika(dr);
                lista.Add(korisnik);
            }
            dr.Close();
            return lista;
        }
        public static int Spremi(KorisnikKlasa korisnik)
        {
            string sqlUpit = "";
            if (korisnik.Korisnik_id== 0)
            {
                sqlUpit = $"INSERT INTO Korisnik (korisnicko_ime, lozinka, uloga_id) VALUES ('{korisnik.Korisnicko_ime}', '{korisnik.Lozinka}', '{korisnik.Uloga_id}' )";
            }
            else
            {
                sqlUpit = $"UPDATE Korisnik SET korisnicko_ime = '{korisnik.Korisnicko_ime}',  lozinka = '{korisnik.Lozinka}', uloga_id = '{korisnik.Uloga_id}'  WHERE Id = {korisnik.Korisnik_id}";
            }
            return DB.Instance.IzvrsiUpit(sqlUpit);
        }
        public static int Obrisi(Korisnik korisnik)
        {
            string sqlDelete = "DELETE FROM Zaposlenik WHERE Id = " + korisnik.korisnik_id;
            return DB.Instance.IzvrsiUpit(sqlDelete);
        }
    }


}
