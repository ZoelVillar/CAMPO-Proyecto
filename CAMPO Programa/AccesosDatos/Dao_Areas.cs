using BE;
using Servicios.Cache;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace AccesosDatos
{
    public class Dao_Areas
    {
        private AccesoSQL dbConnection;

        public Dao_Areas()
        {
            dbConnection = AccesoSQL.getInstance();
        }

        public bool retornaAreas()
        {
            using (var connection = dbConnection.GetConnection())
            {
                dbConnection.OpenConnection();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT id_area, nombre_area, descripcion FROM Area";
                    command.CommandType = System.Data.CommandType.Text;

                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            BE_Areas Area = new BE_Areas();
                            Area.id_area = reader.GetInt32(0);
                            Area.nombre_area = reader.GetString(1);
                            Area.descripcion = reader.GetString(2);

                            AreasCache.ListaAreas.Add(Area);
                        }
                        return true;
                    }
                    else { return false; }
                }
            }
        }
    }
}
