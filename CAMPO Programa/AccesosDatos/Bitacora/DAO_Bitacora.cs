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
        public List<BE_BitacoraCambios> retornarBitacoraCambios()
        {
            List<BE_BitacoraCambios> listaBitacora = new List<BE_BitacoraCambios>();
            try
            {
                using (var connection = dbConnection.GetConnection())
                {
                    dbConnection.OpenConnection();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "select * from BitacoraCambiosUsuarios";
                        command.CommandType = CommandType.Text;

                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                listaBitacora.Add(
                                    new BE_BitacoraCambios()
                                    {
                                        idBitacora = reader.GetInt32(0),
                                        usuario = reader.GetString(1),
                                        accion = reader.GetString(2),
                                        datoPrevio = reader.GetString(3),
                                        datoPosterior = reader.GetString(4),
                                        fecha = reader.GetDateTime(5),
                                        executedSQL = reader.GetString(6),
                                        reverseSQL = reader.GetString(7)
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

    }
}
