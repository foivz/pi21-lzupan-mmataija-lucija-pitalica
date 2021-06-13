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
                hotel.Lozinka = dr["lozinka"].ToString();

            }
            return hotel;
        }

        public static List<Klase.HotelKlasa> DohvatiHotele()
        {
            List<Klase.HotelKlasa> lista = new List<Klase.HotelKlasa>();
            string sqlUpit = $"SELECT * FROM Hotel";
            SqlDataReader dr = DB.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                Klase.HotelKlasa hotel = DohvatiHotel(dr);
                lista.Add(hotel);
            }
            dr.Close();
            return lista;
        }



        public static List<Klase.HotelKlasa> DohvatiFiltriraneHotele(string uvjet, string sadrzaj)
        {
            List<Klase.HotelKlasa> lista = new List<Klase.HotelKlasa>();
            string sqlUpit = $"SELECT * FROM Hotel";
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
                sqlUpit = $"INSERT INTO Hotel (OIB_hotela,IBAN,naziv_hotela,telefon,adresa,email,kapacitet) VALUES ('{hotel.OIB_Hotela}', '{hotel.IBAN}','{hotel.Naziv_hotel}','{hotel.Telefon}','{hotel.Adresa}','{hotel.Email}','{hotel.Kapacitet}')";
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
                sqlUpit = $"UPDATE Hotel SET iban='{hotel.IBAN}', naziv_hotela = '{hotel.Naziv_hotel}', telefon = '{hotel.Telefon}', adresa = '{hotel.Adresa}', email = '{hotel.Email}', kapacitet = '{hotel.Kapacitet}' WHERE OIB_hotela = {hotel.OIB_Hotela}";
            }
            return DB.Instance.IzvrsiUpit(sqlUpit);
        }
        public static Klase.HotelKlasa DohvatiHotelPoAdresiINazivu(string sadrzajNaziva, string sadrzajAdrese)
        {
            Klase.HotelKlasa hotelTrazeni = new HotelKlasa();
            string sqlUpit = $"SELECT * FROM Hotel";
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
        public static Klase.HotelKlasa DohvatiHotelPoZaposlenikovomImenu(string korisnicko_ime)
        {
            Klase.HotelKlasa hotelTrazeni = new HotelKlasa();
            string sqlUpit = $"SELECT Hotel.OIB_hotela, Hotel.IBAN, Hotel.naziv_hotela, Hotel.telefon, Hotel.adresa, Hotel.email, Hotel.kapacitet, Hotel.lozinka FROM Hotel, Zaposlenik WHERE Zaposlenik.korisnicko_ime = '{korisnicko_ime}' AND Zaposlenik.OIB_hotela = Hotel.OIB_hotela";
            SqlDataReader dr = DB.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                Klase.HotelKlasa hotel = DohvatiHotel(dr);
                hotelTrazeni = hotel;
            }
            dr.Close();
            return hotelTrazeni;
        }
        public static Klase.HotelKlasa DohvatiHotelPoZaposlenikovomImenu(string lozinka, string korisnicko_ime)
        {
            Klase.HotelKlasa hotelTrazeni = new HotelKlasa();
            string sqlUpit = $"SELECT Hotel.OIB_hotela, Hotel.IBAN, Hotel.naziv_hotela, Hotel.telefon, Hotel.adresa, Hotel.email, Hotel.kapacitet, Hotel.korisnik_id, Hotel.lozinka FROM Hotel, Zaposlenik WHERE Zaposlenik.korisnicko_ime = '{korisnicko_ime}' AND Zaposlenik.lozinka= '{lozinka}' AND Zaposlenik.OIB_hotela = Hotel.OIB_hotela";
            SqlDataReader dr = DB.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                Klase.HotelKlasa hotel = DohvatiHotel(dr);
                hotelTrazeni = hotel;
            }
            dr.Close();
            return hotelTrazeni;
        }

    }
}
