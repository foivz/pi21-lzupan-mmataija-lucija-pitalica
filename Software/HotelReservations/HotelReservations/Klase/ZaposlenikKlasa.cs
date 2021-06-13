using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_faza_1.Klase
{
    public class ZaposlenikKlasa
    {
        public int ID_zaposlenik { get; set; }
        public int OIB_zaposlenika { get; set; }
        public string OIB_hotela { get; set; }
        public string ID_tip { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string IBAN { get; set; }

        public DateTime Datum_rodjenja { get; set; }
        public string Email { get; set; }
        public string Adresa { get; set; }
        public string Korisnicko_ime { get; set; }
        public string Lozinka { get; set; }
        public string Telefon { get; set; }
        public int Korisnik_id { get; set; }
        public ZaposlenikKlasa()
        {

        }
    }
}
