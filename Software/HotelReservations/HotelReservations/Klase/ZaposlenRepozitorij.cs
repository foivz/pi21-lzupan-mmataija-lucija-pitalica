using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_faza_1.Klase
{
    public static class ZaposlenRepozitorij
    {
        public static Klase.ZaposlenKlasa DohvatiZaposlenikHotel(SqlDataReader dr)
        {
            Klase.ZaposlenKlasa zaposlen = null;
            if (dr != null)
            {
                zaposlen = new Klase.ZaposlenKlasa();
                zaposlen.OIB_zaposlenika = int.Parse(dr["id_zaposlenika"].ToString());
                zaposlen.OIB_hotela = dr["OIB_hotela"].ToString();
            }
            return zaposlen;
        }

        public static List<Klase.ZaposlenKlasa> DohvatiListuZaposlenikHotel()
        {
            List<Klase.ZaposlenKlasa> lista = new List<Klase.ZaposlenKlasa>();
            string sqlUpit = $"SELECT * FROM Zaposlen";
            SqlDataReader dr = DB.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                Klase.ZaposlenKlasa zaposlen = DohvatiZaposlenikHotel(dr);
                lista.Add(zaposlen);
            }
            dr.Close();
            return lista;
        }

        public static int DodajPodatkeUZaposlen(string OIB_hotela)
        {
            string sqlUpit = "";
            ZaposlenikKlasa zaposlenik = ZaposlenikRepozitorij.DohvatiZaposlenikaZadnjeg();
            sqlUpit = $"INSERT INTO Zaposlen (id_zaposlenika,OIB_hotela) VALUES ('{zaposlenik.ID_zaposlenik}','{OIB_hotela}')";
            return DB.Instance.IzvrsiUpit(sqlUpit);
        }
        public static int IzbrisiZaposlen(int id)
        {
            string sqlUpit = "";
            sqlUpit = $"DELETE Zaposlen WHERE id_zaposlenika='{id}'";
            return DB.Instance.IzvrsiUpit(sqlUpit);
        }
    }
}
