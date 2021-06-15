using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_faza_1.Klase
{
    public static class RepozitorijRezervacijaGost
    {
        public static Klase.RezervacijaGost DohvatiRezervacijuGost(SqlDataReader dr)
        {
            Klase.RezervacijaGost rezervacijaGost = null;
            if (dr != null)
            {
                rezervacijaGost = new Klase.RezervacijaGost();
                rezervacijaGost.Rezervacija_ID = int.Parse(dr["rezervacija_id"].ToString());
                rezervacijaGost.ID_gost = int.Parse(dr["id_gosta"].ToString());
            }
            return rezervacijaGost;
        }

        public static List<Klase.RezervacijaGost> DohvatiRezervacijeGostiju()
        {
            List<Klase.RezervacijaGost> lista = new List<Klase.RezervacijaGost>();
            string sqlUpit = $"SELECT * FROM Rezervacija_Gost";
            SqlDataReader dr = DB.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                Klase.RezervacijaGost rezervacija = DohvatiRezervacijuGost(dr);
                lista.Add(rezervacija);
            }
            dr.Close();
            return lista;
        }

        public static int DohvatiIdGosta(int rezervacija_id)
        {
            RezervacijaGost rezervacijaGost = new RezervacijaGost();
            string sqlUpit = $"SELECT * FROM Rezervacija_Gost WHERE rezervacija_id='{rezervacija_id}'";
            int trazeni = 0;
            SqlDataReader dr = DB.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                RezervacijaGost gost = DohvatiRezervacijuGost(dr);
                trazeni = gost.ID_gost;
            }
            dr.Close();
            return trazeni;
        }
    }
}
