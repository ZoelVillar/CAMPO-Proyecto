using BE.Biatcora;
using BE.Idiomas;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Servicios.Cache;

namespace AccesosDatos.Bitacora
{
    public class DAO_Bitacora
    {
        private AccesoSQL dbConnection;
        public DAO_Bitacora()
        {
            dbConnection = AccesoSQL.getInstance();
        }
        public List<BE_BitacoraEventos> retornarBitacoraEventos()
        {
            List<BE_BitacoraEventos> listaBitacora = new List<BE_BitacoraEventos>();
            try
            {
                using (var connection = dbConnection.GetConnection())
                {
                    dbConnection.OpenConnection();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "select * from BitacoraEventos";
                        command.CommandType = CommandType.Text;

                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                listaBitacora.Add(
                                    new BE_BitacoraEventos()
                                    {
                                        idBitacora = reader.GetInt32(0),
                                        User = reader.GetString(1),
                                        Fecha = reader.GetDateTime(2),
                                        Accion = reader.GetString(3),
                                        Modulo = reader.GetString(4),
                                        Criticidad = reader.GetInt32(5)
                                    });
                            }
                            return listaBitacora;
                        }
                        else { return listaBitacora; }
                    }
                }
            }
            catch { return listaBitacora; }
        }

        public bool registrarBitacoraEvento(string accion, string Modulo, int Criticidad)
        {
            try
            {
                using (var connection = dbConnection.GetConnection())
                {
                    dbConnection.OpenConnection();

                    using (var command = new SqlCommand())
                    {
                        if(SessionManager.getSession.Usuario == null)
                        {
                            return false;
                        }
                        command.Connection = connection;
                        command.CommandText = $"INSERT INTO BitacoraEventos (userEmail, accion, Modulo, Criticidad) VALUES (@useremail, @accion, @Modulo, @Criticidad)"; ;
                        // Parámetros para los valores a insertar
                        command.Parameters.AddWithValue("@useremail", SessionManager.getSession.Usuario.key_email);
                        command.Parameters.AddWithValue("@accion", accion);
                        command.Parameters.AddWithValue("@Modulo", Modulo);
                        command.Parameters.AddWithValue("@Criticidad", Criticidad);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        { return true; }
                        else { return false; }
                    }
                }
            }
            catch (SqlException)
            {
                return false;
            }
        }


        public bool restaurarCambio(string reverseSQL)
        {
            try
            {
                using (var connection = dbConnection.GetConnection())
                {
                    dbConnection.OpenConnection();


                    byte[] userEmail = Encoding.UTF8.GetBytes(SessionManager.getSession.Usuario.key_email); // Obtiene el correo del usuario
                    using (var sessionCommand = new SqlCommand("SET CONTEXT_INFO @UserEmail", connection))
                    {
                        sessionCommand.Parameters.AddWithValue("@UserEmail", userEmail);
                        sessionCommand.ExecuteNonQuery();
                    }

                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = reverseSQL;

                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.HasRows)
                        {
                            return true;
                        }
                        else { return false; }
                    }
                }
            }
            catch { return false; }
        }
        public List<BE_BitacoraCambiosProducto> retornarBitacoraCambios()
        {
            List<BE_BitacoraCambiosProducto> listaBitacora = new List<BE_BitacoraCambiosProducto>();
            //try
            //{
                using (var connection = dbConnection.GetConnection())
                {
                    dbConnection.OpenConnection();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "select * from BitacoraCambios";
                        command.CommandType = CommandType.Text;

                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                listaBitacora.Add(
                                    new BE_BitacoraCambiosProducto()
                                    {
                                        IdCambio = reader.GetInt32(0),
                                        IdProducto = reader.GetInt32(1),
                                        Codigo = reader.GetString(2),
                                        Nombre = reader.GetString(3),
                                        Descripcion = reader.GetString(4),
                                        IdCategoria = reader.GetInt32(5),
                                        Stock = reader.GetInt32(6),
                                        PrecioCompra = reader.GetDecimal(7),
                                        PrecioVenta = reader.GetDecimal(8),
                                        Estado = reader.GetBoolean(9),
                                        FechaCreado = reader.GetDateTime(10),
                                        Activo = reader.GetBoolean(11),
                                        DigitoHorizontal = reader.GetInt32(12),
                                        FechaBitacora = reader.GetDateTime(13)


                                    });
                            }
                            return listaBitacora;
                        }
                        else { return listaBitacora; }
                    }
                }
            //}
            //catch(SqlException ex ) { throw ex; return listaBitacora; }
        }

    }
}
