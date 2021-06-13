using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_faza_1.Klase
{
   public static class RepozitorijPrijavaKvara
    {
        public static Klase.PrijavaKvaraKlasa DohvatiPrijavukvara(SqlDataReader dr)
        {
            Klase.PrijavaKvaraKlasa prijava = null;
            if (dr != null)
            {
                prijava = new Klase.PrijavaKvaraKlasa();
                prijava.ID_prijava = int.Parse(dr["id_prijava"].ToString());
                prijava.Broj_sobe = int.Parse(dr["broj_sobe"].ToString());
                prijava.OIB_gosta = int.Parse(dr["OIB_gosta"].ToString());
                prijava.Datum_prijave_kvara = DateTime.Parse(dr["datum_prijave_kvara"].ToString());
                prijava.Opis = (dr["opis"].ToString());
                prijava.OIB_hotela = (dr["OIB_hotela"].ToString());
            }
            return prijava;
        }

        public static List<Klase.PrijavaKvaraKlasa> DohvatiPrijave()
        {
            List<Klase.PrijavaKvaraKlasa> lista = new List<Klase.PrijavaKvaraKlasa>();
            string sqlUpit = $"SELECT * FROM Prijava_kvara";
            SqlDataReader dr = DB.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                Klase.PrijavaKvaraKlasa prijava = DohvatiPrijavukvara(dr);
                lista.Add(prijava);
            }
            dr.Close();
            return lista;
        }
        public static List<Klase.PrijavaKvaraKlasa> DohvatiPrijavePoHotelu(HotelKlasa hotel)
        {
            List<Klase.PrijavaKvaraKlasa> lista = new List<Klase.PrijavaKvaraKlasa>();
            string sqlUpit = $"SELECT * FROM Prijava_kvara WHERE '{hotel.OIB_Hotela}' = Prijava_kvara.OIB_hotela";
            SqlDataReader dr = DB.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                Klase.PrijavaKvaraKlasa prijava = DohvatiPrijavukvara(dr);
                lista.Add(prijava);
            }
            dr.Close();
            return lista;
        }

        public static int DodajPrijavuKvara(Klase.PrijavaKvaraKlasa prijava)
        {
            string sqlUpit = "";
            sqlUpit = $"INSERT INTO Prijava_kvara (broj_sobe,OIB_gosta,datum_prijave_kvara,opis,OIB_hotela) VALUES ('{prijava.Broj_sobe}','{prijava.OIB_gosta}','{prijava.Datum_prijave_kvara}','{prijava.Opis}','{prijava.OIB_hotela}')";
            return DB.Instance.IzvrsiUpit(sqlUpit);
        }



        public static int ObrisiPrijavu(Klase.PrijavaKvaraKlasa prijava)
        {
            string sqlUpit = "";
            bool postojiZapis = false;
            List<Klase.PrijavaKvaraKlasa> prijave = new List<Klase.PrijavaKvaraKlasa>();
            prijave = DohvatiPrijave();
            foreach (Klase.PrijavaKvaraKlasa item in prijave)
            {
                if (item.ID_prijava == prijava.ID_prijava)
                {
                    postojiZapis = true;
                }
            }
            if (postojiZapis == true)
            {
                sqlUpit = $"DELETE FROM Prijava_kvara WHERE id_prijava = {prijava.ID_prijava}";
            }
            return DB.Instance.IzvrsiUpit(sqlUpit);
        }

        public static List<Klase.PrijavaKvaraKlasa> DohvatiPrijaveGosta(Gost gost)
        {
            List<Klase.PrijavaKvaraKlasa> lista = new List<Klase.PrijavaKvaraKlasa>();
            string sqlUpit = $"SELECT * FROM Prijava_kvara WHERE Prijava.OIB_gosta='{gost.OIB_gosta}'";
            SqlDataReader dr = DB.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                Klase.PrijavaKvaraKlasa prijava = DohvatiPrijavukvara(dr);
                lista.Add(prijava);
            }
            dr.Close();
            return lista;
        }



        public static string DohvatiId_prijave(SqlDataReader dr)
        {
            string id_prijava = null;
            if (dr != null)
            {
                id_prijava = dr["id_prijava"].ToString();
            }
            return id_prijava;
        }
    }
}
