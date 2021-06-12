using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_faza_1
{
    class DB
    {
        private static DB instance;

        public static DB Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DB();
                }

                return instance;
            }
        }

        public string ConnectionString { get; private set; }

        public SqlConnection Connection { get; private set; }

        private DB()
        {
            ConnectionString = "Data Source=31.147.204.119\\PISERVER,1433; Initial Catalog=PI21-07_DB; User=PI21-07_User; Password=\"@&f}gXJ;\"";
            Connection = new SqlConnection(ConnectionString);
            Connection.Open();
        }

        public void CloseConnection()
        {
            if (Connection.State != System.Data.ConnectionState.Closed)
            {
                Connection.Close();
            }
        }

        public SqlDataReader DohvatiDataReader(string sqlUpit)
        {
            SqlCommand command = new SqlCommand(sqlUpit, Connection);
            return command.ExecuteReader();
        }

        public object DohvatiVrijednost(string sqlUpit)
        {
            SqlCommand command = new SqlCommand(sqlUpit, Connection);
            return command.ExecuteScalar();
        }

        public int IzvrsiUpit(string sqlUpit)
        {
            SqlCommand command = new SqlCommand(sqlUpit, Connection);
            return command.ExecuteNonQuery();
        }
        public int IzvrsiUpite(string sqlUpit, string sqlUpitDva)
        {
            SqlCommand command = new SqlCommand(sqlUpit, Connection);
            SqlCommand command1 = new SqlCommand(sqlUpitDva, Connection);
            return command.ExecuteNonQuery();
        }
    }

}
