using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_faza_1.Klase
{
    public static class ZaposlenikRepozitorij
    {
        public static ZaposlenikKlasa DohvatiZaposlenika(SqlDataReader dr)
        {
            ZaposlenikKlasa zaposlenik = null;
            if (dr != null)
            {
                zaposlenik = new ZaposlenikKlasa();
                zaposlenik.ID_zaposlenik = int.Parse(dr["id_zaposlenika"].ToString());
                zaposlenik.OIB_zaposlenika = int.Parse(dr["OIB_zaposlenika"].ToString());
                zaposlenik.OIB_hotela = dr["OIB_hotela"].ToString();
                zaposlenik.ID_tip = dr["id_tip"].ToString();
                zaposlenik.Ime = dr["ime"].ToString();
                zaposlenik.Prezime = dr["prezime"].ToString();
                zaposlenik.IBAN = dr["IBAN"].ToString();
                zaposlenik.Datum_rodjenja = DateTime.Parse(dr["datum_rodjenja"].ToString());
                zaposlenik.Email = dr["email"].ToString();
                zaposlenik.Adresa = dr["adresa"].ToString();
                zaposlenik.Korisnicko_ime = dr["korisnicko_ime"].ToString();
                zaposlenik.Telefon = dr["telefon"].ToString();
                zaposlenik.Korisnik_id = int.Parse(dr["korisnik_id"].ToString());
                zaposlenik.Lozinka = dr["lozinka"].ToString();
            }
            return zaposlenik;
        }
        public static TipZaposlenikaKlasa DohvatiTipZaposlenik(SqlDataReader dr)
        {
            TipZaposlenikaKlasa tip = null;
            if (dr != null)
            {
                tip = new TipZaposlenikaKlasa();
                tip.ID_tip = dr["id_tip"].ToString();
                tip.Naziv = dr["naziv"].ToString();

            }
            return tip;
        }

        public static List<ZaposlenikKlasa> DohvatiZaposlenike()
        {
            List<ZaposlenikKlasa> lista = new List<ZaposlenikKlasa>();
            string sqlUpit = $"SELECT * FROM Zaposlenik";
            SqlDataReader dr = DB.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                ZaposlenikKlasa zaposlenik = DohvatiZaposlenika(dr);
                lista.Add(zaposlenik);
            }
            dr.Close();
            return lista;
        }
        public static List<ZaposlenikKlasa> DohvatiZaposlenikePoHotelu(Klase.HotelKlasa hotel)
        {
            List<ZaposlenikKlasa> lista = new List<ZaposlenikKlasa>();
            string sqlUpit = $"SELECT * FROM Zaposlenik WHERE '{hotel.OIB_Hotela}' = OIB_hotela";
            SqlDataReader dr = DB.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                ZaposlenikKlasa zaposlenik = DohvatiZaposlenika(dr);
                lista.Add(zaposlenik);
            }
            dr.Close();
            return lista;
        }

        public static List<TipZaposlenikaKlasa> DohvatiTipZaposlenika()
        {
            List<TipZaposlenikaKlasa> lista = new List<TipZaposlenikaKlasa>();
            string sqlUpit = $"SELECT * FROM Tip_zaposlenika";
            SqlDataReader dr = DB.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                TipZaposlenikaKlasa tip = DohvatiTipZaposlenik(dr);
                lista.Add(tip);
            }
            dr.Close();
            return lista;
        }

        public static string DohvatiNazivTipaPoZaposleniku(string id_tip)
        {
            List<TipZaposlenikaKlasa> lista = new List<TipZaposlenikaKlasa>();
            lista = DohvatiTipZaposlenika();
            string naziv = "";
            foreach (var item in lista)
            {
                if (item.ID_tip == id_tip)
                {
                    naziv = item.Naziv;
                }
            }
            return naziv;
        }
        public static int DodajZaposlenika(ZaposlenikKlasa zaposlenik)
        {
            string sqlUpit = "";
            bool postojiZapis = false;
            List<ZaposlenikKlasa> zaposlenici = new List<ZaposlenikKlasa>();
            zaposlenici = DohvatiZaposlenike();
          
            if (postojiZapis == false)
            {
                sqlUpit = $"INSERT INTO Zaposlenik (OIB_zaposlenika,OIB_hotela,id_tip,ime,prezime,IBAN,datum_rodjenja,email,adresa,korisnicko_ime,telefon,korisnik_id,lozinka) VALUES ('{zaposlenik.OIB_zaposlenika}','{zaposlenik.OIB_hotela}','{zaposlenik.ID_tip}','{zaposlenik.Ime}','{zaposlenik.Prezime}','{zaposlenik.IBAN}','{zaposlenik.Datum_rodjenja}','{zaposlenik.Email}','{zaposlenik.Adresa}','{zaposlenik.Korisnicko_ime}','{zaposlenik.Telefon}','{zaposlenik.Korisnik_id}', '{zaposlenik.Lozinka}')";
            }
            return DB.Instance.IzvrsiUpit(sqlUpit);
        }

        public static int IzmijeniLozinkuZaposlenikovu(ZaposlenikKlasa zaposlenik)
        {
            string sqlUpit = "";
            sqlUpit = $"UPDATE Korisnik SET lozinka='{zaposlenik.Lozinka}' WHERE korisnicko_ime = '{zaposlenik.Korisnicko_ime}'";
            return DB.Instance.IzvrsiUpit(sqlUpit);
        }
        public static int IzmijeniZaposlenika(ZaposlenikKlasa zaposlenik)
        {
            string sqlUpit = "";
            sqlUpit = $"UPDATE Zaposlenik SET lozinka='{zaposlenik.Lozinka}',iban='{zaposlenik.IBAN}',OIB_hotela='{zaposlenik.OIB_hotela}',ID_tip='{zaposlenik.ID_tip}',ime = '{zaposlenik.Ime}', prezime = '{zaposlenik.Prezime}',email='{zaposlenik.Email}',adresa='{zaposlenik.Adresa}',korisnicko_ime='{zaposlenik.Korisnicko_ime}',telefon='{zaposlenik.Telefon}',korisnik_id='{zaposlenik.Korisnik_id}' WHERE id_zaposlenika = {zaposlenik.ID_zaposlenik}";
            return DB.Instance.IzvrsiUpit(sqlUpit);
        }

        public static int ObrisiZaposlenika(ZaposlenikKlasa zaposlenik)
        {
            string sqlUpit = "";
            bool postojiZapis = false;
            List<ZaposlenikKlasa> zaposlenici = new List<ZaposlenikKlasa>();
            zaposlenici = DohvatiZaposlenike();
            foreach (ZaposlenikKlasa item in zaposlenici)
            {
                if (item.OIB_zaposlenika == zaposlenik.OIB_zaposlenika)
                {
                    postojiZapis = true;
                }
            }
            if (postojiZapis == true)
            {
                sqlUpit = $"DELETE FROM Zaposlenik WHERE OIB_zaposlenika = {zaposlenik.OIB_zaposlenika}";
            }
            return DB.Instance.IzvrsiUpit(sqlUpit);
        }

        public static List<ZaposlenikKlasa> DohvatiZaposlenikeHotela(Klase.HotelKlasa hotel)
        {
            List<ZaposlenikKlasa> zaposlenici = new List<ZaposlenikKlasa>();
            string sqlUpit = $"SELECT * FROM Zaposlenik JOIN Zaposlen ON zaposlenik.OIB_zaposlenika=Zaposlen.OIB_zaposlenika WHERE zaposlen.OIB_hotela='{hotel.OIB_Hotela}'";
            SqlDataReader dr = DB.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                ZaposlenikKlasa zaposlenik = DohvatiZaposlenika(dr);
                zaposlenici.Add(zaposlenik);
            }
            dr.Close();
            return zaposlenici;
        }



        public static string DohvatiOIBZaposlenika(SqlDataReader dr)
        {
            string oib = null;
            if (dr != null)
            {
                oib = dr["OIB_zaposlenika"].ToString();
            }
            return oib;
        }

        public static int IzbaciZaposlenikaIzHotela(Klase.HotelKlasa selektiraniHotel, ZaposlenikKlasa zaposlenik)
        {
            string sqlUpit = "";
            sqlUpit = $"DELETE FROM Zaposlen WHERE OIB_zaposlenika = {zaposlenik.OIB_zaposlenika} AND OIB_hotela = {selektiraniHotel.OIB_Hotela}";
            return DB.Instance.IzvrsiUpit(sqlUpit);
        }

        public static int DodjeliZaposlenikaHotelu(Klase.HotelKlasa selektiraniHotel, ZaposlenikKlasa zaposlenik)
        {
            string sqlUpit = $"INSERT INTO Zaposlen (OIB_Hotela,OIB_zaposlenika) VALUES ('{selektiraniHotel.OIB_Hotela}','{zaposlenik.OIB_zaposlenika}')";
            return DB.Instance.IzvrsiUpit(sqlUpit);
        }

        public static ZaposlenikKlasa DohvatiZaposlenikaPoImenu(string korisnicko_ime, string lozinka)
        {
            ZaposlenikKlasa trazeni = new ZaposlenikKlasa();
            string sqlUpit = $"SELECT * FROM Zaposlenik WHERE '{korisnicko_ime}' = korisnicko_ime AND lozinka='{lozinka}'";
            SqlDataReader dr = DB.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                ZaposlenikKlasa zaposlenik = DohvatiZaposlenika(dr);
                trazeni = zaposlenik;
            }
            dr.Close();
            return trazeni;
        }
        public static ZaposlenikKlasa DohvatiZaposlenikaPoImenu(string korisnicko_ime)
        {
            ZaposlenikKlasa trazeni = new ZaposlenikKlasa();
            string sqlUpit = $"SELECT * FROM Zaposlenik WHERE '{korisnicko_ime}' = korisnicko_ime";
            SqlDataReader dr = DB.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                ZaposlenikKlasa zaposlenik = DohvatiZaposlenika(dr);
                trazeni = zaposlenik;
            }
            dr.Close();
            return trazeni;
        }
        public static ZaposlenikKlasa DohvatiZaposlenikaZadnjeg()
        {
            ZaposlenikKlasa trazeni = new ZaposlenikKlasa();
            List<ZaposlenikKlasa> lista = new List<ZaposlenikKlasa>();
            lista = DohvatiZaposlenike();
            int brojac = lista.Count();
            for (int i = 0; i < brojac; i++)
            {
                if (i == brojac - 1)
                {
                    trazeni = lista[i];
                }
            }
            return trazeni;
        }

    }
}
