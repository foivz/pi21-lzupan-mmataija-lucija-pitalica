using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_faza_1.Klase
{
   public  class RezervacijaRepozitorij
    {
        public static Klase.RezervacijaKlasa DohvatiRezervaciju(SqlDataReader dr)
        {
            Klase.RezervacijaKlasa rezervacija = null;
            if (dr != null)
            {
                rezervacija = new Klase.RezervacijaKlasa();
                rezervacija.Rezervacija_ID = int.Parse(dr["rezervacija_id"].ToString());
                rezervacija.Id_soba = int.Parse(dr["id_soba"].ToString());
               
                rezervacija.OIB_gosta = int.Parse(dr["OIB_gosta"].ToString());
                rezervacija.Datum_rezervacije = DateTime.Parse(dr["datum_rezervacije"].ToString());
                rezervacija.Datum_dolaska = DateTime.Parse(dr["datum_dolaska"].ToString());
                rezervacija.Datum_odlaska = DateTime.Parse(dr["datum_odlaska"].ToString());
                rezervacija.Cijena = decimal.Parse(dr["cijena"].ToString());
            }
            return rezervacija;
        }

        public static List<Klase.RezervacijaKlasa> DohvatiRezervacije()
        {
            List<Klase.RezervacijaKlasa> lista = new List<Klase.RezervacijaKlasa>();
            string sqlUpit = $"SELECT * FROM Rezervacija";
            SqlDataReader dr = DB.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                Klase.RezervacijaKlasa rezervacija = DohvatiRezervaciju(dr);
                lista.Add(rezervacija);
            }
            dr.Close();
            return lista;
        }

        public static int DodajRezervaciju(Klase.RezervacijaKlasa rezervacija)
        {
            string sqlUpit = "";
            bool postojiZapis = false;
            List<Klase.RezervacijaKlasa> rezervacije = new List<Klase.RezervacijaKlasa>();
            rezervacije = DohvatiRezervacije();
            foreach (Klase.RezervacijaKlasa item in rezervacije)
            {
                if (item.Rezervacija_ID == rezervacija.Rezervacija_ID)
                {
                    postojiZapis = true;
                }
            }
            if (postojiZapis == false)
            {
                sqlUpit = $"INSERT INTO Rezervacija (id_soba,OIB_gosta,datum_rezervacije,datum_dolaska,datum_odlaska,cijena) VALUES ('{rezervacija.Id_soba}','{rezervacija.OIB_gosta}','{rezervacija.Datum_rezervacije}','{rezervacija.Datum_dolaska}','{rezervacija.Datum_odlaska}','{rezervacija.Cijena}')";
            }
            return DB.Instance.IzvrsiUpit(sqlUpit);
        }

        public static int IzmijeniRezervaciju(Klase.RezervacijaKlasa rezervacija)
        {
            string sqlUpit = "";
            bool postojiZapis = false;
            List<Klase.RezervacijaKlasa> rezervacije = new List<Klase.RezervacijaKlasa>();
            rezervacije = DohvatiRezervacije();
            foreach (Klase.RezervacijaKlasa item in rezervacije)
            {
                if (item.Rezervacija_ID == rezervacija.Rezervacija_ID)
                {
                    postojiZapis = true;
                }
            }
            if (postojiZapis == true)
            {
                sqlUpit = $"UPDATE Rezervacija SET broj_sobe = '{rezervacija.Id_soba}', OIB_gosta = '{rezervacija.OIB_gosta}', datum_rezervacije='{rezervacija.Datum_rezervacije}', datum_dolaska='{rezervacija.Datum_dolaska}', datum_odlaska='{rezervacija.Datum_odlaska}', cijena='{rezervacija.Cijena}' WHERE rezervacija_id= {rezervacija.Rezervacija_ID}";
            }
            return DB.Instance.IzvrsiUpit(sqlUpit);
        }

        public static int ObrisiRezervaciju(Klase.RezervacijaKlasa rezervacija)
        {
            string sqlUpit = "";
            bool postojiZapis = false;
            List<Klase.RezervacijaKlasa> rezervacije = new List<Klase.RezervacijaKlasa>();
            rezervacije = DohvatiRezervacije();
            foreach (Klase.RezervacijaKlasa item in rezervacije)
            {
                if (item.Rezervacija_ID == rezervacija.Rezervacija_ID)
                {
                    postojiZapis = true;
                }
            }
            if (postojiZapis == true)
            {
                sqlUpit = $"DELETE FROM Rezervacija WHERE rezrvacija_id = {rezervacija.Rezervacija_ID}";
            }
            return DB.Instance.IzvrsiUpit(sqlUpit);
        }

        public static List<Klase.RezervacijaKlasa> DohvatiRezervacijeGosta(GostKlasa gost)
        {
            List<Klase.RezervacijaKlasa> lista = new List<Klase.RezervacijaKlasa>();
            string sqlUpit = $"SELECT * FROM Rezervacija  WHERE rezervacija.OIB_gosta='{gost.OIB_gost}'";
            SqlDataReader dr = DB.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                Klase.RezervacijaKlasa rezervacije = DohvatiRezervaciju(dr);
                lista.Add(rezervacije);
            }
            dr.Close();
            return lista;
        }

        public static List<Klase.RezervacijaKlasa> DohvatiRezervacijeGostaPoOIB(string OIB_gost)
        {
            List<Klase.RezervacijaKlasa> lista = new List<Klase.RezervacijaKlasa>();
            string sqlUpit = $"SELECT * FROM Rezervacija  WHERE Rezervacija.OIB_gosta='{OIB_gost}'";
            SqlDataReader dr = DB.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                Klase.RezervacijaKlasa rezervacije = DohvatiRezervaciju(dr);
                lista.Add(rezervacije);
            }
            dr.Close();
            return lista;
        }
        public static string DohvatiId_rezervacijee(SqlDataReader dr)
        {
            string rezervacija_id = null;
            if (dr != null)
            {
                rezervacija_id = dr["rezervacija_id"].ToString();
            }
            return rezervacija_id;
        }

    }
}
