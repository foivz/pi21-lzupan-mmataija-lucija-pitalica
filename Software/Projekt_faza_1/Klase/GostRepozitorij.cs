using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_faza_1.Klase
{
    public  static class GostRepozitorij
    {
        public static GostKlasa DohvatiGosta(SqlDataReader dr)
        {
            GostKlasa gost = null;
            if (dr != null)
            {
                gost = new GostKlasa();
                gost.OIB_gost = int.Parse(dr["OIB_gosta"].ToString());
                gost.Ime = dr["ime"].ToString();
                gost.Prezime = dr["prezime"].ToString();
                gost.IBAN = dr["IBAN"].ToString();
                gost.Telefon = dr["telefon"].ToString();
                gost.Email = dr["email"].ToString();
                gost.Adresa = dr["adresa"].ToString();
                gost.Drzavljanstvo = dr["drzavljanstvo"].ToString();
                gost.Covid_test = dr["covid_test"].ToString();
                gost.Datum_rodjenja = DateTime.Parse(dr["datum_rodjenja"].ToString());
            }
            return gost;
        }

        public static List<GostKlasa> DohvatiGoste()
        {
            List<GostKlasa> lista = new List<GostKlasa>();
            string sqlUpit = $"SELECT * FROM Gost";
            SqlDataReader dr = DB.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                GostKlasa gost = DohvatiGosta(dr);
                lista.Add(gost);
            }
            dr.Close();
            return lista;
        }

        public static int DodajGosta(GostKlasa gost)
        {
            string sqlUpit = "";
            bool postojiZapis = false;
            List<GostKlasa> gosti = new List<GostKlasa>();
            gosti = DohvatiGoste();
            foreach (GostKlasa item in gosti)
            {
                if (item.OIB_gost == gost.OIB_gost)
                {
                    postojiZapis = true;
                }
            }
            if (postojiZapis == false)
            {
                sqlUpit = $"INSERT INTO Gost (OIB_gosta,ime,prezime,IBAN,telefon,email,adresa,drzavljanstvo,covid_test,datum_rodjenja) VALUES ('{gost.OIB_gost}','{gost.Ime}','{gost.Prezime}','{gost.IBAN}','{gost.Telefon}','{gost.Email}','{gost.Adresa}','{gost.Drzavljanstvo}','{gost.Covid_test}','{gost.Datum_rodjenja}')";
            }
            return DB.Instance.IzvrsiUpit(sqlUpit);
        }

        public static int IzmijeniGosta(GostKlasa gost)
        {
            string sqlUpit = "";
            bool postojiZapis = false;
            List<GostKlasa> gosti = new List<GostKlasa>();
            gosti = DohvatiGoste();
            foreach (GostKlasa item in gosti)
            {
                if (item.OIB_gost == gost.OIB_gost)
                {
                    postojiZapis = true;
                }
            }
            if (postojiZapis == true)
            {
                sqlUpit = $"UPDATE Gost SET ime = '{gost.Ime}', prezime = '{gost.Prezime}', telefon='{gost.Telefon}', email='{gost.Email}', adresa='{gost.Adresa}',drzavljanstvo='{gost.Drzavljanstvo}',covid_test='{gost.Covid_test}' WHERE OIB_gosta = {gost.OIB_gost}";
            }
            return DB.Instance.IzvrsiUpit(sqlUpit);
        }

        public static int ObrisiGosta(GostKlasa gost)
        {
            string sqlUpit = "";
            bool postojiZapis = false;
            List<GostKlasa> gosti = new List<GostKlasa>();
            gosti = DohvatiGoste();
            foreach (GostKlasa item in gosti)
            {
                if (item.OIB_gost == gost.OIB_gost)
                {
                    postojiZapis = true;
                }
            }
            if (postojiZapis == true)
            {
                sqlUpit = $"DELETE FROM Gost WHERE OIB_gosta = {gost.OIB_gost}";
            }
            return DB.Instance.IzvrsiUpit(sqlUpit);
        }

        public static List<GostKlasa> DohvatiGosteHotela(GostKlasa gost)
        {
            List<GostKlasa> lista = new List<GostKlasa>();
            string sqlUpit = $"SELECT * FROM Gost WHERE rezrvacija.OIB_gosta='{gost.OIB_gost}' AND rezervacija.broj_sobe=soba.broj_sobe AND hotel.OIB_hotela=soba.OIB_hotela";
            SqlDataReader dr = DB.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                GostKlasa gostTrazeni = DohvatiGosta(dr);
                lista.Add(gostTrazeni);
            }
            dr.Close();
            return lista;
        }



        public static string DohvatiOIB_gosta(SqlDataReader dr)
        {
            string OIB_gosta = null;
            if (dr != null)
            {
               OIB_gosta = dr["OIB_gosta"].ToString();
            }
            return OIB_gosta;
        }



    }

}