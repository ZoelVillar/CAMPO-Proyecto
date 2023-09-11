using BE;
using BE.Usuarios;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesosDatos
{
    public class DAO_Negocio
    {
      

        private AccesoSQL dbConnection;

        public DAO_Negocio()
        {
            dbConnection = AccesoSQL.getInstance();
        }

        public BE_Negocio retornarNegocio()
        {
            try
            {
                using (var connection = dbConnection.GetConnection())
                {
                    dbConnection.OpenConnection();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "SELECT idNegocio, Nombre, RUC, Direccion FROM NEGOCIO";
                        command.CommandType = System.Data.CommandType.Text;

                        SqlDataReader reader = command.ExecuteReader();

                    
                        BE_Negocio negocio = new BE_Negocio();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                negocio.idNegocio = reader.GetInt32(0);
                                negocio.Nombre = reader.GetString(1);
                                negocio.RUC = reader.GetString(2);
                                negocio.Direccion = reader.GetString(3);

                            }
                        }
                        return negocio;
                    }
                }
            }
            catch (SqlException )
            {
                BE_Negocio negocioVacio = new BE_Negocio();
                return negocioVacio;
            }
        }
    }
}

