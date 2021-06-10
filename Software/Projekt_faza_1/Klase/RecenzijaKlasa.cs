using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_faza_1.Klase
{
    public class RecenzijaKlasa
    {
        public int ID_recenzija { get; set; }
        public int OIB_gosta { get; set; }
        public int Broj_sobe { get; set; }
        public DateTime Datum_recenzije { get; set; }
       
        public string Opis { get; set; }
        public int Ocjena { get; set; }
        
        public RecenzijaKlasa()
        {

        }
    }
}
