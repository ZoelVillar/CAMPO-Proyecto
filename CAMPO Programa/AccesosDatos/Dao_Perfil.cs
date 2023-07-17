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
    public class Dao_Perfil
    {
        private AccesoSQL dbConnection;

        public Dao_Perfil()
        {
            dbConnection = AccesoSQL.getInstance();
        }

        public List<BE_Perfil> retornaPerfiles()
        {
            using (var connection = dbConnection.GetConnection())
            {
                List<BE_Perfil> listaPerfiles = new List<BE_Perfil>();
                dbConnection.OpenConnection();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT id_perfil, nombre_perfil, descripcion FROM Perfil";
                    command.CommandType = System.Data.CommandType.Text;

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            BE_Perfil perfil = new BE_Perfil();
                            perfil.id_perfil = reader.GetInt32(0);
                            perfil.nombre_perfil = reader.GetString(1);
                            perfil.descripcion = reader.GetString(2);

                            listaPerfiles.Add(perfil);
                        }
                        return listaPerfiles;
                    }
                    else { return listaPerfiles; }
                }
            }
        }
    }
}
