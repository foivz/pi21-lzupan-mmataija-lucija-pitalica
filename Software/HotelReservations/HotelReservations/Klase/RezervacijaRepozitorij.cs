using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_faza_1.Klase
{
    public static class RezervacijaRepozitorij
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
                rezervacija.Check_in = dr["check_in"].ToString();
                rezervacija.Check_out = dr["check_out"].ToString();
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
        public static RezervacijaKlasa DohvatiZadnjuRezervaciju()
        {
            RezervacijaKlasa trazena = new RezervacijaKlasa();
            List<RezervacijaKlasa> listaRezervacija = new List<RezervacijaKlasa>();
            listaRezervacija = DohvatiRezervacije();
            int brojac = listaRezervacija.Count();
            for (int i = 0; i < brojac; i++)
            {
                if (i == brojac - 1)
                {
                    trazena = listaRezervacija[i];
                }
            }
            return trazena;
        }

        public static int DodajPodatkeURezervacijaGost()
        {
            string sqlUpit = "";
            Klase.RezervacijaKlasa rezervacija = DohvatiZadnjuRezervaciju();
            GostKlasa gostKlasa = GostRepozitorij.DohvatiGostaZadnjeg();
            sqlUpit = $"INSERT INTO Rezervacija_Gost (id_gosta,rezervacija_id) VALUES ('{gostKlasa.ID_gost}','{rezervacija.Rezervacija_ID}')";
            return DB.Instance.IzvrsiUpit(sqlUpit);
        }
        public static int DodajPodatkeVecPostojecuRezervaciju(int rezervacija_id)
        {
            string sqlUpit = "";
            GostKlasa gostKlasa = GostRepozitorij.DohvatiGostaZadnjeg();
            sqlUpit = $"INSERT INTO Rezervacija_Gost (id_gosta,rezervacija_id) VALUES ('{gostKlasa.ID_gost}','{rezervacija_id}')";
            return DB.Instance.IzvrsiUpit(sqlUpit);
        }

        public static List<Klase.RezervacijaKlasa> DohvatiRezervacijeBezZaposlenikOdjavioPrijavio()
        {
            List<Klase.RezervacijaKlasa> lista = new List<Klase.RezervacijaKlasa>();
            string sqlUpit = $"SELECT * FROM Rezervacija";
            SqlDataReader dr = DB.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                Klase.RezervacijaKlasa rezervacija = DohvatiRezervacijuBezZaposlenikOdjavioPrijavio(dr);
                lista.Add(rezervacija);
            }
            dr.Close();
            return lista;
        }
        public static Klase.RezervacijaKlasa DohvatiRezervacijuBezZaposlenikOdjavioPrijavio(SqlDataReader dr)
        {
            Klase.RezervacijaKlasa rezervacija = null;
            if (dr != null)
            {
                rezervacija = new Klase.RezervacijaKlasa();
                rezervacija.Rezervacija_ID = int.Parse(dr["rezervacija_id"].ToString());
                rezervacija.Id_soba = int.Parse(dr["id_soba"].ToString());
                rezervacija.Broj_sobe = dr["broj_sobe"].ToString();
                rezervacija.OIB_gosta = int.Parse(dr["OIB_gosta"].ToString());
                rezervacija.Datum_rezervacije = DateTime.Parse(dr["datum_rezervacije"].ToString());
                rezervacija.Datum_dolaska = DateTime.Parse(dr["datum_dolaska"].ToString());
                rezervacija.Datum_odlaska = DateTime.Parse(dr["datum_odlaska"].ToString());
                rezervacija.Cijena = decimal.Parse(dr["cijena"].ToString());
                rezervacija.Check_in = dr["check_in"].ToString();
                rezervacija.Check_out = dr["check_out"].ToString();
                rezervacija.Ime_gosta = dr["ime"].ToString();
                rezervacija.Prezime_gosta = dr["prezime"].ToString();
            }
            return rezervacija;
        }

        public static Klase.RezervacijaKlasa DohvatiRezervacijuSaPrijavama(SqlDataReader dr)
        {
            Klase.RezervacijaKlasa rezervacija = null;
            if (dr != null)
            {
                rezervacija = new Klase.RezervacijaKlasa();
                rezervacija.Rezervacija_ID = int.Parse(dr["rezervacija_id"].ToString());
                rezervacija.Broj_sobe = dr["broj_sobe"].ToString();
                rezervacija.OIB_gosta = int.Parse(dr["OIB_gosta"].ToString());
                rezervacija.Datum_rezervacije = DateTime.Parse(dr["datum_rezervacije"].ToString());
                rezervacija.Datum_dolaska = DateTime.Parse(dr["datum_dolaska"].ToString());
                rezervacija.Datum_odlaska = DateTime.Parse(dr["datum_odlaska"].ToString());
                rezervacija.Cijena = decimal.Parse(dr["cijena"].ToString());
                rezervacija.Check_in = dr["check_in"].ToString();
                rezervacija.Check_out = dr["check_out"].ToString();
                rezervacija.Zaposlenik_OIB = int.Parse(dr["OIB_zaposlenika"].ToString());
                rezervacija.Zaposlenik_ime_prijavio = dr["ime"].ToString();
                rezervacija.Zaposlenik_prezime_prijavio = dr["prezime"].ToString();

            }
            return rezervacija;
        }
        public static int DodajGostaUIstuSobu(Klase.RezervacijaKlasa rezervacija)
        {
            string sqlUpit = "";
            sqlUpit = $"INSERT INTO Rezervacija (rezervacija_id,id_soba,OIB_gosta,datum_rezervacije,datum_dolaska,datum_odlaska,cijena,check_in,zaposlenik_prijavio) VALUES ('{rezervacija.Rezervacija_ID}','{rezervacija.Id_soba}','{rezervacija.OIB_gosta}','{rezervacija.Datum_rezervacije}','{rezervacija.Datum_dolaska}','{rezervacija.Datum_odlaska}','{rezervacija.Cijena}','{rezervacija.Check_in}', '{rezervacija.Zaposlenik_OIB}')";
            return DB.Instance.IzvrsiUpit(sqlUpit);
        }

        public static int PrijaviGosta(Klase.RezervacijaKlasa rezervacija)
        {
            string sqlUpit = "";

            sqlUpit = $"UPDATE Rezervacija SET check_in='{rezervacija.Check_in}',zaposlenik_prijavio='{rezervacija.Zaposlenik_OIB}' WHERE rezervacija_id = {rezervacija.Rezervacija_ID}";
            return DB.Instance.IzvrsiUpit(sqlUpit);
        }
        public static List<Klase.RezervacijaKlasa> DohvatiPrijavljeneGoste(HotelKlasa hotelKlasa)
        {
            List<Klase.RezervacijaKlasa> lista = new List<Klase.RezervacijaKlasa>();
            string sqlUpit = $"SELECT Rezervacija.rezervacija_id,Gost.OIB_gosta,Soba.broj_sobe,Rezervacija.cijena,Rezervacija.zaposlenik_prijavio,Rezervacija.check_in,Zaposlenik.OIB_zaposlenika,Zaposlenik.ime, Zaposlenik.prezime, Rezervacija.check_out, Rezervacija.datum_rezervacije, Rezervacija.datum_odlaska, Rezervacija.datum_dolaska,Gost.id_gosta FROM Rezervacija,Hotel,Soba,Zaposlenik,Rezervacija_Gost,Gost WHERE Hotel.OIB_hotela = Soba.OIB_hotela AND Soba.id_soba = Rezervacija.id_soba AND Hotel.OIB_hotela = '{hotelKlasa.OIB_Hotela}' AND check_in IS NOT NULL AND check_out IS NULL AND Rezervacija.zaposlenik_prijavio=Zaposlenik.id_zaposlenika AND Rezervacija.rezervacija_id=Rezervacija_Gost.rezervacija_id AND Rezervacija_Gost.id_gosta=Gost.id_gosta";
            SqlDataReader dr = DB.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                Klase.RezervacijaKlasa rezervacija = DohvatiRezervacijuSaPrijavama(dr);
                lista.Add(rezervacija);
            }
            dr.Close();
            return lista;
        }

        public static int OdjaviGosta(Klase.RezervacijaKlasa rezervacija)
        {
            string sqlUpit = "";

            sqlUpit = $"UPDATE Rezervacija SET check_out='{rezervacija.Check_out}', zaposlenik_odjavio='{rezervacija.Zaposlenik_odjavio}' WHERE rezervacija_id = {rezervacija.Rezervacija_ID}";
            return DB.Instance.IzvrsiUpit(sqlUpit);
        }
        public static List<Klase.RezervacijaKlasa> DohvatiRezervacijeZaDanasnjiDatumNeprijavljeneGoste(HotelKlasa hotelKlasa)
        {
            List<Klase.RezervacijaKlasa> lista = new List<Klase.RezervacijaKlasa>();
            DateTime datum = DateTime.Now;
            string sqlUpit = $"SELECT Rezervacija.rezervacija_id,Rezervacija.id_soba,Soba.broj_sobe,Gost.OIB_gosta,Rezervacija.datum_rezervacije,Rezervacija.datum_odlaska, Rezervacija.datum_dolaska,Rezervacija.cijena, Rezervacija.check_in, Rezervacija.check_out, Gost.ime, Gost.prezime FROM Rezervacija,Hotel,Soba,Rezervacija_Gost,Gost WHERE datum_dolaska = '{datum}' AND check_in IS NULL AND Hotel.OIB_hotela = Soba.OIB_hotela AND Soba.id_soba = Rezervacija.id_soba AND Hotel.OIB_hotela = '{hotelKlasa.OIB_Hotela}' AND Rezervacija_Gost.id_gosta=Gost.id_gosta AND Rezervacija_Gost.rezervacija_id=Rezervacija.rezervacija_id";
            SqlDataReader dr = DB.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                Klase.RezervacijaKlasa rezervacija = DohvatiRezervacijuBezZaposlenikOdjavioPrijavio(dr);
                lista.Add(rezervacija);
            }
            dr.Close();
            return lista;
        }
    }
}
