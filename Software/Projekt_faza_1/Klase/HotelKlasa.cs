using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_faza_1.Klase
{
    public class HotelKlasa
    {
        public string OIB_Hotela { get; set; }
        public string IBAN { get; set; }
        public string Naziv_hotel { get; set; }
        public string Telefon { get; set; }
        public string Adresa { get; set; }
        public string Email { get; set; }
        public int Kapacitet { get; set; }
        public int Korisnik_id { get; set; }
        public Image Fotografija { get; set; }

        public HotelKlasa()
        {

        }
        public override string ToString()
        {
            return this.Naziv_hotel + '-' + this.Adresa;
        }
    }
}
