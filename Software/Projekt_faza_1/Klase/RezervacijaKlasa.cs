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
    
        public RezervacijaKlasa()
        {

        }
    }
}
