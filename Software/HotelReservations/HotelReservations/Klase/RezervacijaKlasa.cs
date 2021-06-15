using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_faza_1.Klase
{
    public class RezervacijaKlasa
    {
        public int Rezervacija_ID { get; set; }
        public int Id_soba { get; set; }
        public int OIB_gosta { get; set; }
        public DateTime Datum_rezervacije { get; set; }
        public DateTime Datum_dolaska { get; set; }
        public DateTime Datum_odlaska { get; set; }
        public decimal Cijena { get; set; }
        public string Check_in { get; set; }
        public string Check_out { get; set; }
        public int Zaposlenik_OIB { get; set; }
        public int Zaposlenik_odjavio { get; set; }

        public string Zaposlenik_ime_prijavio { get; set; }
        public string Zaposlenik_prezime_prijavio { get; set; }
        public string Broj_sobe { get; set; }
        public string Ime_gosta { get; set; }
        public string Prezime_gosta { get; set; }
        public RezervacijaKlasa()
        {

        }
    }
}
