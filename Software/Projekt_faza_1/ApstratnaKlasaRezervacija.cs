using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_faza_1
{
    public abstract class ApstraktnaKlasaRezervacija
    {
        public static int Rezervacija_ID { get; set; }
        public static int ID_soba { get; set; }
        public static int OIB_gosta { get; set; }
        public static DateTime Datum_rezervacije { get; set; }
        public static DateTime Datum_dolaska { get; set; }
        public static DateTime Datum_odlaska { get; set; }
        public static decimal Cijena { get; set; }
        public static int Slobodna { get; set; }
       
    }
}
