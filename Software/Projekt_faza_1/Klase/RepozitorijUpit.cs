using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_faza_1.Klase
{
    public static class RepozitorijUpit
    {
        public static UpitKlasa DohvatiUpit(SqlDataReader dr)
        {
            UpitKlasa upit = null;
            if (dr != null)
            {
                upit = new UpitKlasa();
                upit.ID_upit = int.Parse(dr["id_upit"].ToString());
                upit.OIB_gosta = int.Parse(dr["OIB_gosta"].ToString());
                upit.Datum_i_vrijeme = DateTime.Parse(dr["datum_i_vrijeme"].ToString());
                upit.Opis = dr["opis"].ToString();
            }
            return upit;
        }

        public static List<UpitKlasa> DohvatiUpite()
        {
            List<UpitKlasa> lista = new List<UpitKlasa>();
            string sqlUpit = $"SELECT * FROM Upit";
            SqlDataReader dr = DB.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                UpitKlasa upit = DohvatiUpit(dr);
                lista.Add(upit);
            }
            dr.Close();
            return lista;
        }

        public static int DodajUpit(UpitKlasa upit)
        {
            string sqlUpit = "";
            bool postojiZapis = false;
            List<UpitKlasa> upiti = new List<UpitKlasa>();
            upiti = DohvatiUpite();
            foreach (UpitKlasa item in upiti)
            {
                if (item.ID_upit == upit.ID_upit)
                {
                    postojiZapis = true;
                }
            }
            if (postojiZapis == false)
            {
                sqlUpit = $"INSERT INTO Upit (OIB_gosta,datum_i_vrijeme,opis) VALUES ('{upit.OIB_gosta}','{upit.Datum_i_vrijeme}','{upit.Opis}')";
            }
            return DB.Instance.IzvrsiUpit(sqlUpit);
        }


        public static int ObrisiPrijavu(UpitKlasa upit)
        {
            string sqlUpit = "";
            bool postojiZapis = false;
            List<UpitKlasa> upiti = new List<UpitKlasa>();
            upiti = DohvatiUpite();
            foreach (UpitKlasa item in upiti)
            {
                if (item.ID_upit == upit.ID_upit)
                {
                    postojiZapis = true;
                }
            }
            if (postojiZapis == true)
            {
                sqlUpit = $"DELETE FROM Upit WHERE id_upit = {upit.ID_upit}";
            }
            return DB.Instance.IzvrsiUpit(sqlUpit);
        }

        public static List<UpitKlasa> DohvatiUpiteGosta(Gost gost)
        {
            List<UpitKlasa> lista = new List<UpitKlasa>();
            string sqlUpit = $"SELECT * FROM Upit WHERE Upit.OIB_gosta='{gost.OIB_gosta}'";
            SqlDataReader dr = DB.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                UpitKlasa upit = DohvatiUpit(dr);
                lista.Add(upit);
            }
            dr.Close();
            return lista;
        }



        public static string DohvatiId_upita(SqlDataReader dr)
        {
            string id_upit = null;
            if (dr != null)
            {
                id_upit = dr["id_upit"].ToString();
            }
            return id_upit;
        }
    }
}
