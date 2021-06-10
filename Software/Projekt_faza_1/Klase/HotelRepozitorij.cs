using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_faza_1.Klase
{
    public static class HotelRepozitorij
    {
        
        public static Klase.HotelKlasa DohvatiHotel(SqlDataReader dr)
        {
            Klase.HotelKlasa hotel = null;
            if (dr != null)
            {
                hotel = new Klase.HotelKlasa();
                hotel.OIB_Hotela = dr["OIB_hotela"].ToString();
                hotel.IBAN = dr["IBAN"].ToString();
                hotel.Naziv_hotel = dr["naziv_hotela"].ToString();
                hotel.Telefon = dr["telefon"].ToString();
                hotel.Adresa = dr["adresa"].ToString();
                hotel.Email = dr["email"].ToString();
                hotel.Kapacitet = int.Parse(dr["kapacitet"].ToString());
                hotel.Korisnik_id = int.Parse(dr["korisnik_id"].ToString());

            }
            return hotel;
        }

        public static List<Klase.HotelKlasa> DohvatiHotele()
        {
            List<Klase.HotelKlasa> lista = new List<Klase.HotelKlasa>();
            string sqlUpit = "SELECT * FROM Hotel";
            SqlDataReader dr = DB.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                Klase.HotelKlasa hotel = DohvatiHotel(dr);
                lista.Add(hotel);
            }
            dr.Close();
            return lista;
        }

  
        //VRATI SE
        public static List<Klase.HotelKlasa> DohvatiFiltriraneHotele(string uvjet, string sadrzaj)
        {
            List<Klase.HotelKlasa> lista = new List<Klase.HotelKlasa>();
            string sqlUpit = "SELECT * FROM Hotel";
            SqlDataReader dr = DB.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                Klase.HotelKlasa hotel = DohvatiHotel(dr);
                if (uvjet == "Naziv")
                {
                    if (hotel.Naziv_hotel.Contains(sadrzaj))
                    {
                        lista.Add(hotel);
                    }
                }
                if (uvjet == "Adresa")
                {
                    if (hotel.Adresa.Contains(sadrzaj))
                    {
                        lista.Add(hotel);
                    }
                }
                if (uvjet == "Kapacitet")
                {
                    if (hotel.Kapacitet.ToString().Contains(sadrzaj))
                    {
                        lista.Add(hotel);
                    }
                }
                if (uvjet == "OIB_Hotela")
                {
                    if (hotel.OIB_Hotela.ToString().Contains(sadrzaj))
                    {
                        lista.Add(hotel);
                    }
                }
            }
            dr.Close();
            return lista;
        }

        public static ZaposlenikKlasa DohvatiZaposlenika(SqlDataReader dr)
        {
            ZaposlenikKlasa zaposlenik = null;
            if (dr != null)
            {
                zaposlenik = new ZaposlenikKlasa();
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
            }
            return zaposlenik;
        }

        public static List<ZaposlenikKlasa> DohvatiZaposlenike(Klase.HotelKlasa hotel)
        {
            List<ZaposlenikKlasa> lista = new List<ZaposlenikKlasa>();
            string sqlUpit = $"SELECT OIB_zaposlenika,ime,prezime,IBAN,datum_rodjenja,email,telefon FROM Zaposlenik JOIN Zaposlen ON OIB_zaposlenika_zaposlenik=zaposlen.OIB_zaposlenika WHERE zaposlen.OIB_Hotela='{hotel.OIB_Hotela}'";
            SqlDataReader dr = DB.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                ZaposlenikKlasa zaposlenik = DohvatiZaposlenika(dr);
                lista.Add(zaposlenik);
            }
            dr.Close();
            return lista;
        }

        public static int DodajHotel(Klase.HotelKlasa hotel)
        {
            string sqlUpit = "";
            bool postojiZapis = false;
            List<Klase.HotelKlasa> hoteli = new List<Klase.HotelKlasa>();
            hoteli = DohvatiHotele();
            foreach (Klase.HotelKlasa item in hoteli)
            {
                if (item.OIB_Hotela == hotel.OIB_Hotela)
                {
                    postojiZapis = true;
                }
            }
            if (postojiZapis == false)
            {
                sqlUpit = $"INSERT INTO Hotel (OIB_hotela,IBAN,naziv_hotela,telefon,adresa,email,kapacitet,korisnik_id) VALUES ('{hotel.OIB_Hotela}', '{hotel.IBAN}','{hotel.Naziv_hotel}','{hotel.Telefon}','{hotel.Adresa}','{hotel.Email}','{hotel.Kapacitet}','{hotel.Korisnik_id}')";
            }
            return DB.Instance.IzvrsiUpit(sqlUpit);
        }
       

        public static int IzmijeniHotel(Klase.HotelKlasa hotel)
        {
            string sqlUpit = "";
            bool postojiZapis = false;
            List<Klase.HotelKlasa> hoteli = new List<Klase.HotelKlasa>();
            hoteli = DohvatiHotele();
            foreach (Klase.HotelKlasa item in hoteli)
            {
                if (item.OIB_Hotela == hotel.OIB_Hotela)
                {
                    postojiZapis = true;
                }
            }
            if (postojiZapis == true)
            {
                sqlUpit = $"UPDATE Hotel SET naziv_hotela = '{hotel.Naziv_hotel}', telefon = '{hotel.Telefon}', adresa = '{hotel.Adresa}', email = '{hotel.Email}', kapacitet = '{hotel.Kapacitet}' WHERE OIB_hotela = {hotel.OIB_Hotela}";
            }
            return DB.Instance.IzvrsiUpit(sqlUpit);
        }
        //BRISANJE NE ZELI RADIT ZBOG KLJUCA NA SOBU
        public static int ObrisiHotel(Klase.HotelKlasa hotel, int korisnik_id)
        {
            string sqlUpit = "";
            string sqlUpitDva = "";
            bool postojiZapis = false;
            List<Klase.HotelKlasa> hoteli = new List<Klase.HotelKlasa>();
            hoteli = DohvatiHotele();
            List <SobaKlasa> listaSoba  = RepozitorijSoba.DohvatiSobePoHotelu(hotel);
            foreach (Klase.HotelKlasa item in hoteli)
            {
                if (item.OIB_Hotela == hotel.OIB_Hotela)
                {
                    postojiZapis = true;
                }
            }
            if (postojiZapis == true)
            {
                sqlUpit = $"DELETE FROM Hotel WHERE OIB_hotela = {hotel.OIB_Hotela} ";
                foreach (var item in listaSoba)
                {
                    sqlUpitDva = $"DELETE FROM Soba WHERE OIB_hotela = {item.OIB_hotela} ";
                }
                
            }
            return DB.Instance.IzvrsiUpite(sqlUpit,sqlUpitDva);
        }

        //pretraga hotela Gost

        public static List<Klase.HotelKlasa> DohvatiHotelePoGostu(List<SobaKlasa> sobe)
        {
           
            List<Klase.HotelKlasa> listaHotela = HotelRepozitorij.DohvatiHotele();
            List<Klase.HotelKlasa> listaHotelaSlobodnih = new List<HotelKlasa>();
            
                foreach (var soba in sobe)
            {
                foreach (var hotel in listaHotela)
                {
                    if (soba.OIB_hotela == hotel.OIB_Hotela) 
                    {
                        if (listaHotelaSlobodnih.Count == 0)
                        {
                            listaHotelaSlobodnih.Add(hotel);

                        }
                        else if (listaHotelaSlobodnih.Contains(hotel) == false)
                           {
                            listaHotelaSlobodnih.Add(hotel);
                        }
                    }
                }
            }
            
           
            return listaHotelaSlobodnih;
        }

        public static Klase.HotelKlasa DohvatiHotelPoAdresiINazivu(string sadrzajNaziva, string sadrzajAdrese)
        {
            Klase.HotelKlasa hotelTrazeni = new HotelKlasa();
            string sqlUpit = "SELECT * FROM Hotel";
            SqlDataReader dr = DB.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                Klase.HotelKlasa hotel = DohvatiHotel(dr);
                if (hotel.Naziv_hotel.Contains(sadrzajNaziva) && hotel.Adresa.Contains(sadrzajAdrese))
                    {
                        hotelTrazeni = hotel;
                    }
                
               
            }
            dr.Close();
            return hotelTrazeni;
        }

    }
}
