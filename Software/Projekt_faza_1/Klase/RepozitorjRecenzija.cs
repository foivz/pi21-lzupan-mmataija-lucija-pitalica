using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_faza_1.Klase
{
    public static class RepozitorjRecenzija
    {
        public static Klase.RecenzijaKlasa DohvatiRecenziju(SqlDataReader dr)
        {
            Klase.RecenzijaKlasa recenzija = null;
            if (dr != null)
            {
                recenzija = new Klase.RecenzijaKlasa();
                recenzija.ID_recenzija = int.Parse(dr["id_recenzija"].ToString());
                recenzija.OIB_gosta = int.Parse(dr["OIB_gosta"].ToString());
                recenzija.Broj_sobe = int.Parse(dr["broj_sobe"].ToString());
                recenzija.Datum_recenzije = DateTime.Parse(dr["datum_recenzije"].ToString());
                recenzija.Opis = dr["opis"].ToString();
                recenzija.Ocjena = int.Parse(dr["ocjena"].ToString());
            }
            return recenzija;
        }

        public static List<Klase.RecenzijaKlasa> DohvatiRecenzije()
        {
            List<Klase.RecenzijaKlasa> lista = new List<Klase.RecenzijaKlasa>();
            string sqlUpit = $"SELECT * FROM Recenzija";
            SqlDataReader dr = DB.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                Klase.RecenzijaKlasa recenzija = DohvatiRecenziju(dr);
                lista.Add(recenzija);
            }
            dr.Close();
            return lista;
        }

        public static int DodajRecenziju(Klase.RecenzijaKlasa recenzija)
        {
            string sqlUpit = "";
            bool postojiZapis = false;
            List<Klase.RecenzijaKlasa> recenzije = new List<Klase.RecenzijaKlasa>();
            recenzije = DohvatiRecenzije();
            foreach (Klase.RecenzijaKlasa item in recenzije)
            {
                if (item.ID_recenzija == recenzija.ID_recenzija)
                {
                    postojiZapis = true;
                }
            }
            if (postojiZapis == false)
            {
                sqlUpit = $"INSERT INTO Recenzija (OIB_gosta,broj_sobe,datum_recenzije,opis,ocjena) VALUES ('{recenzija.OIB_gosta}','{recenzija.Broj_sobe}','{recenzija.Datum_recenzije}','{recenzija.Opis}','{recenzija.Ocjena}')";
            }
            return DB.Instance.IzvrsiUpit(sqlUpit);
        }


        public static int ObrisiRecenziju(Klase.RecenzijaKlasa recenzija)
        {
            string sqlUpit = "";
            bool postojiZapis = false;
            List<Klase.RecenzijaKlasa> recenzije = new List<Klase.RecenzijaKlasa>();
            recenzije = DohvatiRecenzije();
            foreach (Klase.RecenzijaKlasa item in recenzije)
            {
                if (item.ID_recenzija == recenzija.ID_recenzija)
                {
                    postojiZapis = true;
                }
            }
            if (postojiZapis == true)
            {
                sqlUpit = $"DELETE FROM Recenzija WHERE id_recenzija = {recenzija.ID_recenzija}";
            }
            return DB.Instance.IzvrsiUpit(sqlUpit);
        }

        public static List<Klase.RecenzijaKlasa> DohvatiRecenzijeGosta(Gost gost)
        {
            List<Klase.RecenzijaKlasa> lista = new List<Klase.RecenzijaKlasa>();
            string sqlUpit = $"SELECT * FROM Recenzija WHERE Recenzija.OIB_gosta='{gost.OIB_gosta}'";
            SqlDataReader dr = DB.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                Klase.RecenzijaKlasa recenzija = DohvatiRecenziju(dr);
                lista.Add(recenzija);
            }
            dr.Close();
            return lista;
        }



        public static string DohvatiId_recenzije(SqlDataReader dr)
        {
            string id_recenzija = null;
            if (dr != null)
            {
                id_recenzija = dr["id_recenzija"].ToString();
            }
            return id_recenzija;
        }
    }
}
