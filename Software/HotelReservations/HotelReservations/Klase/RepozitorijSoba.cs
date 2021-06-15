using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_faza_1.Klase
{
    public static class RepozitorijSoba
    {
        public static SobaKlasa DohvatiSobu(SqlDataReader dr)
        {
            SobaKlasa soba = null;
            if (dr != null)
            {
                soba = new SobaKlasa();
                soba.ID_soba = int.Parse(dr["id_soba"].ToString());
                soba.OIB_hotela = dr["OIB_hotela"].ToString();
                soba.VelicinaSobe = int.Parse(dr["velicina_sobe"].ToString());
                soba.Kapacitet = int.Parse(dr["kapacitet"].ToString());
                soba.Sadrzaj_sobe = dr["sadrzaj_sobe"].ToString();
                soba.Sadrzaj_kupaonice = dr["sadrzaj_kupaonice"].ToString();
                soba.Napomene = dr["napomene"].ToString();
                soba.Slobodna = int.Parse(dr["slobodna"].ToString());
                soba.Broj_sobe = dr["broj_sobe"].ToString();
                soba.Cijena = decimal.Parse(dr["cijena"].ToString());
            }
            return soba;
        }

        public static List<SobaKlasa> DohvatiSobe()
        {
            List<SobaKlasa> lista = new List<SobaKlasa>();
            string sqlUpit = $"SELECT * FROM Soba";
            SqlDataReader dr = DB.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                SobaKlasa soba = DohvatiSobu(dr);
                lista.Add(soba);
            }
            dr.Close();
            return lista;
        }
        public static List<SobaKlasa> DohvatiSobePoHotelu(Klase.HotelKlasa hotel)
        {

            List<SobaKlasa> lista = new List<SobaKlasa>();
            string sqlUpit = $"SELECT * FROM Soba WHERE '{hotel.OIB_Hotela}' = OIB_hotela";
            SqlDataReader dr = DB.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                SobaKlasa soba = DohvatiSobu(dr);
                lista.Add(soba);
            }
            dr.Close();
            return lista;
        }
        public static List<SobaKlasa> DohvatiSobePoOIB(string hotel)
        {

            List<SobaKlasa> lista = new List<SobaKlasa>();
            string sqlUpit = $"SELECT * FROM Soba WHERE '{hotel}' = OIB_hotela";
            SqlDataReader dr = DB.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                SobaKlasa soba = DohvatiSobu(dr);
                lista.Add(soba);
            }
            dr.Close();
            return lista;
        }
        
        public static List<SobaKlasa> DohvatiFiltriraneSobe(string uvjet, string sadrzaj)
        {
            List<SobaKlasa> lista = new List<SobaKlasa>();
            string sqlUpit = "SELECT * FROM Soba";
            SqlDataReader dr = DB.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                SobaKlasa soba = DohvatiSobu(dr);
                if (uvjet == "OIB_Hotela")
                {
                    if (soba.OIB_hotela.Contains(sadrzaj))
                    {
                        lista.Add(soba);
                    }
                }
                if (uvjet == "ID_soba")
                {
                    if (soba.ID_soba.ToString().Contains(sadrzaj))
                    {
                        lista.Add(soba);
                    }
                }
                if (uvjet == "VelicinaSobe")
                {
                    if (soba.VelicinaSobe.ToString().Contains(sadrzaj))
                    {
                        lista.Add(soba);
                    }
                }

                if (uvjet == "Kapacitet")
                {
                    if (soba.Kapacitet.ToString().Contains(sadrzaj))
                    {
                        lista.Add(soba);
                    }
                }

            }
            dr.Close();

            return lista;
        }
        public static List<SobaKlasa> DohvatiSlobodneSobe(DateTime datumdolaska, DateTime datumodlaska, string uvjet, string sadrzaj)
        {
            List<SobaKlasa> lista = new List<SobaKlasa>();
            string sqlUpit = $"SELECT * FROM Soba  JOIN Rezervacija ON Rezervacija.id_soba=Soba.id_soba WHERE Soba.slobodna=0 AND datum_dolaska>='{datumdolaska}' AND datum_odlaska<='{datumodlaska}'";
            SqlDataReader dr = DB.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                SobaKlasa soba = DohvatiSobu(dr);



                if (uvjet == "Kapacitet")
                {
                    if (soba.Kapacitet.ToString().Contains(sadrzaj))
                    {
                        lista.Add(soba);
                    }
                }

            }
            dr.Close();

            return lista;
        }
        public static List<SobaKlasa> DohvatiSlobodneSobePoDatumu(DateTime datumdolaska, DateTime datumodlaska, string uvjet, string sadrzaj, HotelKlasa hotel)
        {
            List<SobaKlasa> lista = new List<SobaKlasa>();
            string sqlUpit = $"SELECT * FROM Soba WHERE Soba.id_soba NOT IN (SELECT Soba.id_soba FROM Soba JOIN Rezervacija ON Rezervacija.id_soba=Soba.id_soba WHERE (datum_dolaska > '{datumdolaska}' AND datum_dolaska <'{datumodlaska}') OR (datum_odlaska > '{datumdolaska}' AND datum_odlaska < '{datumodlaska}') OR (datum_dolaska <= '{datumdolaska}' AND datum_odlaska >= '{datumodlaska}')) AND OIB_hotela='{hotel.OIB_Hotela}'";

            SqlDataReader dr = DB.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                SobaKlasa soba = DohvatiSobu(dr);



                if (uvjet == "Kapacitet")
                {
                    if (soba.Kapacitet.ToString().Contains(sadrzaj))
                    {
                        lista.Add(soba);
                    }
                }

            }
            dr.Close();

            return lista;
        }
        public static List<SobaKlasa> DohvatiSlobodneSobePoDatumuGost(DateTime datumdolaska, DateTime datumodlaska)
        {
            List<SobaKlasa> lista = new List<SobaKlasa>();
            string sqlUpit = $"SELECT * FROM Soba WHERE Soba.id_soba NOT IN (SELECT Soba.id_soba FROM Soba JOIN Rezervacija ON Rezervacija.id_soba=Soba.id_soba WHERE (datum_dolaska > '{datumdolaska}' AND datum_dolaska <'{datumodlaska}') OR (datum_odlaska > '{datumdolaska}' AND datum_odlaska < '{datumodlaska}') OR (datum_dolaska <= '{datumdolaska}' AND datum_odlaska >= '{datumodlaska}'))";

            SqlDataReader dr = DB.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                SobaKlasa soba = DohvatiSobu(dr);
                lista.Add(soba);

            }
            dr.Close();
            return lista;
        }
        public static List<SobaKlasa> DohvatiZauzeteSobe(DateTime datumdolaska, DateTime datumodlaska, string uvjet, string sadrzaj)
        {
            List<SobaKlasa> lista = new List<SobaKlasa>();
            string sqlUpit = $"SELECT * FROM Soba  JOIN Rezervacija ON Rezervacija.id_soba=Soba.id_soba WHERE datum_dolaska>='{datumdolaska}' AND datum_odlaska<='{datumodlaska}'";
            SqlDataReader dr = DB.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                SobaKlasa soba = DohvatiSobu(dr);



                if (uvjet == "Kapacitet")
                {
                    if (soba.Kapacitet.ToString().Contains(sadrzaj))
                    {
                        lista.Add(soba);
                    }
                }

            }
            dr.Close();

            return lista;
        }


        public static int DodajSobu(SobaKlasa soba)
        {
            string sqlUpit = "";
            bool postojiZapis = false;
            List<SobaKlasa> sobe = new List<SobaKlasa>();
            sobe = DohvatiSobe();
            foreach (SobaKlasa item in sobe)
            {
                if (item.ID_soba == soba.ID_soba)
                {
                    postojiZapis = true;
                }
            }
            if (postojiZapis == false)
            {
                sqlUpit = $"INSERT INTO Soba (OIB_hotela,velicina_sobe,kapacitet,sadrzaj_sobe,sadrzaj_kupaonice,napomene,slobodna,broj_sobe,cijena) VALUES ('{soba.OIB_hotela}','{soba.VelicinaSobe}','{soba.Kapacitet}','{soba.Sadrzaj_sobe}','{soba.Sadrzaj_kupaonice}','{soba.Napomene}','{soba.Slobodna}','{soba.Broj_sobe}','{soba.Cijena}')";
            }
            return DB.Instance.IzvrsiUpit(sqlUpit);
        }

        public static int IzmijeniSobu(SobaKlasa soba)
        {
            string sqlUpit = "";
            bool postojiZapis = false;
            List<SobaKlasa> sobe = new List<SobaKlasa>();
            sobe = DohvatiSobe();
            foreach (SobaKlasa item in sobe)
            {
                if (item.ID_soba == soba.ID_soba && item.Broj_sobe == soba.Broj_sobe && item.OIB_hotela == soba.OIB_hotela)
                {
                    postojiZapis = true;
                }
            }
            if (postojiZapis == true)
            {
                sqlUpit = $"UPDATE Soba SET velicina_sobe = '{soba.VelicinaSobe}', kapacitet = '{soba.Kapacitet}', sadrzaj_sobe = '{soba.Sadrzaj_sobe}', sadrzaj_kupaonice = '{soba.Sadrzaj_kupaonice}', napomene = '{soba.Napomene}', broj_sobe='{soba.Broj_sobe}',cijena = '{soba.Cijena}' WHERE id_soba = {soba.ID_soba}";
            }
            return DB.Instance.IzvrsiUpit(sqlUpit);
        }
        public static int PromijeniStatus(SobaKlasa soba)
        {
            string sqlUpit = "";
            bool postojiZapis = false;
            List<SobaKlasa> sobe = new List<SobaKlasa>();
            sobe = DohvatiSobe();
            foreach (SobaKlasa item in sobe)
            {
                if (item.ID_soba == soba.ID_soba)
                {
                    postojiZapis = true;
                }
            }
            if (postojiZapis == true)
            {
                sqlUpit = $"UPDATE Soba SET slobodna = 1 WHERE id_soba = {soba.ID_soba}";
            }
            return DB.Instance.IzvrsiUpit(sqlUpit);
        }
        public static int ObrisiSobu(SobaKlasa soba)
        {
            string sqlUpit = "";
            bool postojiZapis = false;
            List<SobaKlasa> sobe = new List<SobaKlasa>();
            sobe = DohvatiSobe();
            foreach (SobaKlasa item in sobe)
            {
                if (item.ID_soba == soba.ID_soba)
                {
                    postojiZapis = true;
                }
            }
            if (postojiZapis == true)
            {
                sqlUpit = $"DELETE FROM Soba WHERE id_soba = {soba.ID_soba}";
            }
            return DB.Instance.IzvrsiUpit(sqlUpit);
        }
    
    }
}
