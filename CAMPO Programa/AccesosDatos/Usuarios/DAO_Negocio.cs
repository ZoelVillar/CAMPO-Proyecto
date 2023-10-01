using BE;
using BE.Usuarios;
using Servicios.Cache;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
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
            BE_Negocio negocio = new BE_Negocio();
            try
            {
                using (var connection = dbConnection.GetConnection())
                {
                    dbConnection.OpenConnection();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "SELECT idNegocio, Nombre, CUIT, Direccion FROM NEGOCIO";
                        command.CommandType = System.Data.CommandType.Text;

                        SqlDataReader reader = command.ExecuteReader();

                    
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                negocio.idNegocio = reader.GetInt32(0);
                                negocio.Nombre = reader.GetString(1);
                                negocio.CUIT = reader.GetString(2);
                                negocio.Direccion = reader.GetString(3);

                            }
                        }
                        return negocio;
                    }
                }
            }
            catch (SqlException )
            {
                return negocio;
            }
        }

        public bool guardarDatos(BE_Negocio negocio, out string mensaje)
        {
            mensaje = string.Empty;

            try
            {
                using (var connection = dbConnection.GetConnection())
                {
                    dbConnection.OpenConnection();

                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "UPDATE NEGOCIO SET Nombre = @nombre, CUIT = @cuit, Direccion = @direccion WHERE idNegocio = @idNegocio";

                        command.Parameters.AddWithValue("@nombre", negocio.Nombre);
                        command.Parameters.AddWithValue("@cuit", negocio.CUIT);
                        command.Parameters.AddWithValue("@direccion", negocio.Direccion);
                        command.CommandType = CommandType.Text;

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        { return true; }
                        else { mensaje = "No se pudo actualizar los datos";  return false; }
                    }
                }

            }
            catch (SqlException ex)
            {
                mensaje = ex.Message;
                return false;
            }
        }

        public byte[] obtenerLogo(out bool obtenido)
        {
            obtenido = true;
            byte[] logo = new byte[0];

            try
            {
                using (var connection = dbConnection.GetConnection())
                {
                    dbConnection.OpenConnection();

                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "SELECT Logo from NEGOCIO WHERE idNegocio = 1";

                        command.CommandType = CommandType.Text;

                        SqlDataReader reader = command.ExecuteReader();


                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                if (!reader.IsDBNull(reader.GetOrdinal("Logo")))
                                {
                                    logo = (byte[])reader["Logo"];
                                }
                            }
                        }

                    }
                }

            }
            catch (SqlException)
            {
                obtenido= false;
            }

            return logo;
        }

        public bool actualizarLogo(byte[] image, out string mensaje)
        {
            mensaje = string.Empty;

            try
            {
                using (var connection = dbConnection.GetConnection())
                {
                    dbConnection.OpenConnection();

                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "UPDATE NEGOCIO SET Logo = @logo WHERE idNegocio = 1";

                        command.Parameters.AddWithValue("@logo", image);
                        command.CommandType = CommandType.Text;

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        { return true; }
                        else { mensaje = "No se pudo actualizar los datos"; return false; }
                    }
                }

            }
            catch (SqlException ex)
            {
                mensaje = ex.Message;
                return false;
            }
        }
    }
}

