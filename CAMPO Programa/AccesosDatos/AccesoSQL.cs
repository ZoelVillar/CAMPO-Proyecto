using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesosDatos
{
    public class AccesoSQL
    {
        private static string connectionString;
        private SqlConnection connection;

        private AccesoSQL()
        {
            inicializar();
            connection = new SqlConnection(connectionString);
            connection.ConnectionString = connectionString;
        }

        private static AccesoSQL instance;

        public static void inicializar()
        {
            connectionString = "Data Source=.;Initial Catalog=DialectCafe;Integrated Security=True";
        }

        public static AccesoSQL getInstance()
        {
            if(instance == null)
            {
                inicializar();
                instance = new AccesoSQL();
            }
            return instance;
        }

        public SqlConnection GetConnection()
        {
            return instance.connection;
        }

        public void OpenConnection()
        {
            if (connection.State != ConnectionState.Open)
            {
                inicializar();
                instance.connection.ConnectionString = connectionString;
                instance.connection.Open();
            }
        }

        public void CloseConnection()
        {
            if (connection.State != ConnectionState.Closed)
            {
                instance.connection.Close();
            }
        }


    }
}
