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
        public static Korisnik DohvatiKorisnika(SqlDataReader dr)
        {
            Korisnik korisnik = null;
            if (dr != null)
            {
                korisnik = new Korisnik();
                korisnik.korisnik_id = int.Parse(dr["korisnik_id"].ToString());
                korisnik.korisnicko_ime= dr["korisnicko_ime"].ToString();
                korisnik.lozinka = dr["lozinka"].ToString();
                korisnik.uloga_id = int.Parse(dr["uloga_id"].ToString());
           
            }
            return korisnik;
        }
        public static List<Korisnik> DohvatiKorisnike()
        {
            List<Korisnik> lista = new List<Korisnik>();
            string sqlUpit = $"SELECT * FROM korisnik";
            SqlDataReader dr = (SqlDataReader)DB.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                Korisnik korisnik = DohvatiKorisnika(dr);
                lista.Add(korisnik);
            }
            dr.Close();
            return lista;
        }
        public static int Spremi(Korisnik korisnik)
        {
            string sqlUpit = "";
            if (korisnik.korisnik_id == 0)
            {
                sqlUpit = $"INSERT INTO korisnik (korisnicko_ime, lozinka, uloga_id) VALUES ('{korisnik.korisnicko_ime}', '{korisnik.lozinka}', '{korisnik.uloga_id}' )";
            }
            else
            {
                sqlUpit = $"UPDATE korisnik SET korisnicko_ime = '{korisnik.korisnicko_ime}',  lozinka = '{korisnik.lozinka}', uloga_id = '{korisnik.uloga_id}'  WHERE Id = {korisnik.korisnik_id}";
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
