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
    public class Dao_User
    {
        private AccesoSQL dbConnection;

        public Dao_User()
        {
            dbConnection = AccesoSQL.getInstance();
        }

        public bool CrearUsuario(BE_User usuario)
        {
            using (var connection = dbConnection.GetConnection())
            {
                dbConnection.OpenConnection();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = $"INSERT INTO Users (key_email, user_name, user_lastname, user_password, user_blocked, user_attempts, id_area) VALUES (@key_email, @user_name, @user_lastname, @user_password, @user_blocked, @user_attempts, @id_area)"; ;
                    
                    // Parámetros para los valores a insertar
                    command.Parameters.AddWithValue("@key_email", usuario.key_email);
                    command.Parameters.AddWithValue("@user_name", usuario.user_name);
                    command.Parameters.AddWithValue("@user_lastname", usuario.user_lastname);
                    command.Parameters.AddWithValue("@user_password", usuario.user_password);
                    command.Parameters.AddWithValue("@user_blocked", usuario.user_blocked);
                    command.Parameters.AddWithValue("@user_attempts", usuario.user_attempts);
                    command.Parameters.AddWithValue("@id_area", usuario.id_area);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    { return true;}
                    else{ return false;}
                }
            }
        }
        public bool userExist(string key_email)
        {
            using (var connection = dbConnection.GetConnection())
            {
                BE_User usuario = new BE_User();
                dbConnection.OpenConnection();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select key_email from Users where key_email = @email";
                    command.Parameters.AddWithValue("email", key_email);
                    command.CommandType = System.Data.CommandType.Text;


                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                    
                }
            }
        }
        public BE_User retornaUsuario(string key_email)
        {
            using (var connection = dbConnection.GetConnection())
            {
                BE_User usuario = new BE_User();
                dbConnection.OpenConnection();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT U.key_email, U.user_name, U.user_lastname, U.user_password, U.user_blocked, U.user_attempts, U.id_area, A.nombre_area FROM Users U JOIN Area A ON U.id_area = A.id_area WHERE U.key_email = @user";
                    command.Parameters.AddWithValue("user", key_email);
                    command.CommandType = System.Data.CommandType.Text;


                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {   
                            usuario.key_email = reader.GetString(0);
                            usuario.user_name = reader.GetString(1);
                            usuario.user_lastname = reader.GetString(2);
                            usuario.user_password = reader.GetString(3);
                            usuario.user_blocked = reader.GetBoolean(4);
                            usuario.user_attempts = reader.GetInt32(5);
                            usuario.id_area = reader.GetInt32(6);
                            usuario.nombre_area = reader.GetString(7);
                        }
                    }

                    return usuario;
                }
            }
        }
        public bool Login(string key_email)
        {
            using (var connection = dbConnection.GetConnection())
            {
                dbConnection.OpenConnection();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT U.key_email, U.user_name, U.user_lastname, U.user_password, U.user_blocked, U.user_attempts, U.id_area, A.nombre_area FROM Users U JOIN Area A ON U.id_area = A.id_area WHERE U.key_email = @user";
                    command.Parameters.AddWithValue("user", key_email);
                    command.CommandType = System.Data.CommandType.Text;

                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            UserLoginInfo.key_email = reader.GetString(0);
                            UserLoginInfo.user_name = reader.GetString(1);
                            UserLoginInfo.user_lastname = reader.GetString(2);
                            UserLoginInfo.user_password = reader.GetString(3);
                            UserLoginInfo.user_blocked = reader.GetBoolean(4);
                            UserLoginInfo.user_attempts = reader.GetInt32(5);
                            UserLoginInfo.id_area = reader.GetInt32(6);
                            UserLoginInfo.nombre_area = reader.GetString(7);
                        }
                        return true;
                    }
                    else { return false; }
                }
            }
        }

        public List<BE_User> ObtenerUsuarios()
        {
            List<BE_User> usuarios = new List<BE_User>();

            using (var connection = dbConnection.GetConnection())
            {
                dbConnection.OpenConnection();

                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT U.key_email, U.user_name, U.user_lastname, U.user_password, U.user_blocked, U.user_attempts, U.id_area, A.nombre_area FROM Users U INNER JOIN Area A ON U.id_area = A.id_area"; // Ajusta la consulta según tu estructura de base de datos

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            BE_User usuario = new BE_User();
                            usuario.key_email = reader.GetString(0);
                            usuario.user_name = reader.GetString(1);
                            usuario.user_lastname = reader.GetString(2);
                            usuario.user_password = reader.GetString(3);
                            usuario.user_blocked = reader.GetBoolean(4);
                            usuario.user_attempts = reader.GetInt32(5);
                            usuario.id_area = reader.GetInt32(6);
                            usuario.nombre_area = reader.GetString(7);

                            usuarios.Add(usuario);
                        }
                    }
                }
            }

            return usuarios;
        }
    }
}
