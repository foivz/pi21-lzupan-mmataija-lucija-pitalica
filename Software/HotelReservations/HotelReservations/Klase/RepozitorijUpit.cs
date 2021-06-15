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
            }
            return upit;
        }

        public static UpitKlasa DohvatiUpitNeodgovoreni(SqlDataReader dr)
        {
            UpitKlasa upit = null;
            if (dr != null)
            {
                upit = new UpitKlasa();
                upit.OIB_hotela = dr["OIB_hotela"].ToString();
                upit.ID_upit = int.Parse(dr["id_upit"].ToString());
                upit.Datum_i_vrijeme_postavljanja_upita = DateTime.Parse(dr["datum_i_vrijeme"].ToString());
                upit.Opis = dr["opis"].ToString();
                upit.Kontakt = dr["kontakt"].ToString();
            }
            return upit;

        }
        public static UpitKlasa DohvatiUpitOdgovoreni(SqlDataReader dr)
        {
            UpitKlasa upit = null;
            if (dr != null)
            {
                upit = new UpitKlasa();
                upit.OIB_hotela = dr["OIB_hotela"].ToString();
                upit.ID_upit = int.Parse(dr["id_upit"].ToString());
                upit.Datum_i_vrijeme_postavljanja_upita = DateTime.Parse(dr["datum_i_vrijeme"].ToString());
                upit.Opis = dr["opis"].ToString();
                upit.Kontakt = dr["kontakt"].ToString();
                upit.Zaposlenik_OIB = int.Parse(dr["zaposlenik_odgovorio"].ToString());
                upit.Zaposlenik_Ime = dr["ime"].ToString();
                upit.Zaposlenik_Prezime = dr["prezime"].ToString();
                upit.Datum_odgovora = dr["datum_odgovora"].ToString();
            }
            return upit;
        }
        public static List<UpitKlasa> DohvatiUpite()
        {
            List<UpitKlasa> lista = new List<UpitKlasa>();
            string sqlUpit = $"SELECT Upit.id_upit FROM Upit";
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
            List<UpitKlasa> upiti = new List<UpitKlasa>();
            upiti = DohvatiUpite();


            sqlUpit = $"INSERT INTO Upit (datum_i_vrijeme,opis,OIB_hotela,kontakt) VALUES ('{upit.Datum_i_vrijeme_postavljanja_upita}','{upit.Opis}','{upit.OIB_hotela}','{upit.Kontakt}')";

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
        public static string DohvatiId_upita(SqlDataReader dr)
        {
            string id_upit = null;
            if (dr != null)
            {
                id_upit = dr["id_upit"].ToString();
            }
            return id_upit;
        }
        public static List<UpitKlasa> DohvatiNeodgovoreneUpite(int id_zaposlenika)
        {
            List<UpitKlasa> lista = new List<UpitKlasa>();
            string sqlUpit = $"SELECT * FROM Upit,Hotel,Zaposlenik WHERE Upit.zaposlenik_odgovorio IS NULL AND Hotel.OIB_hotela=Zaposlenik.OIB_hotela AND Zaposlenik.id_zaposlenika='{id_zaposlenika}'";
            SqlDataReader dr = DB.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                UpitKlasa upit = DohvatiUpitNeodgovoreni(dr);
                lista.Add(upit);
            }
            dr.Close();
            return lista;
        }
        public static int IzmijeniUpit(UpitKlasa upit, ZaposlenikKlasa zaposlenik)
        {
            string sqlUpit = "";
            bool postojiZapis = true;
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
                sqlUpit = $"UPDATE Upit SET zaposlenik_odgovorio = '{zaposlenik.ID_zaposlenik}', datum_odgovora='{upit.Datum_odgovora}' WHERE id_upit= {upit.ID_upit}";
            }
            return DB.Instance.IzvrsiUpit(sqlUpit);
        }
        public static List<UpitKlasa> DohvatiOdgovoreneUpite(int id_zaposlenika)
        {
            List<UpitKlasa> lista = new List<UpitKlasa>();
            string sqlUpit = $"SELECT Upit.id_upit,Upit.datum_i_vrijeme,Upit.opis,Upit.OIB_hotela,Upit.zaposlenik_odgovorio,Upit.kontakt,Upit.datum_odgovora,Zaposlenik.ime,Zaposlenik.prezime FROM Upit,Hotel,Zaposlenik WHERE Upit.zaposlenik_odgovorio IS NOT NULL AND Hotel.OIB_hotela=Zaposlenik.OIB_hotela AND Zaposlenik.id_zaposlenika='{id_zaposlenika}'";
            SqlDataReader dr = DB.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                UpitKlasa upit = DohvatiUpitOdgovoreni(dr);
                lista.Add(upit);
            }
            dr.Close();
            return lista;
        }
    
}
}
