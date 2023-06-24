using BE;
using Servicios.Cache;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using Servicios.Cache;

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
                    command.CommandText = $"INSERT INTO Users (id_employee, id_area, name_user, password_user, language_user, blocked_user) VALUES (@idEmployee, @idArea, @nameUser, @passwordUser, @languageUser, @blockedUser)"; ;
                    
                    // Parámetros para los valores a insertar
                    command.Parameters.AddWithValue("@idEmployee", usuario.id_employee);
                    command.Parameters.AddWithValue("@idArea", usuario.id_area);
                    command.Parameters.AddWithValue("@nameUser", usuario.name_user);
                    command.Parameters.AddWithValue("@passwordUser", usuario.password_user);
                    command.Parameters.AddWithValue("@languageUser", usuario.language_user);
                    command.Parameters.AddWithValue("@blockedUser", usuario.blocked_user);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
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
        public bool userExist(string name_user)
        {
            using (var connection = dbConnection.GetConnection())
            {
                BE_User usuario = new BE_User();
                dbConnection.OpenConnection();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select name_user from Users where name_user = @user";
                    command.Parameters.AddWithValue("user", name_user);
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
        public BE_User retornaUsuario(string name_user)
        {
            using (var connection = dbConnection.GetConnection())
            {
                BE_User usuario = new BE_User();
                dbConnection.OpenConnection();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select id_employee, id_area, name_user, password_user, language_user, blocked_user from Users where name_user = @user";
                    command.Parameters.AddWithValue("user", name_user);
                    command.CommandType = System.Data.CommandType.Text;


                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {   
                            usuario.id_employee = reader.GetString(0);
                            usuario.id_area = reader.GetString(1);
                            usuario.name_user = reader.GetString(2);
                            usuario.password_user = reader.GetString(3);
                            usuario.language_user = reader.GetString(4);
                            usuario.blocked_user = reader.GetBoolean(5);
                        }
                    }

                    return usuario;
                }
            }
        }
        public bool Login(string name_user)
        {
            using (var connection = dbConnection.GetConnection())
            {
                dbConnection.OpenConnection();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select id_employee, id_area, name_user, password_user, language_user, blocked_user from Users where name_user = @user";
                    command.Parameters.AddWithValue("user", name_user);
                    command.CommandType = System.Data.CommandType.Text;


                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            UserLoginInfo.id_employee = reader.GetString(0);
                            UserLoginInfo.id_area = reader.GetString(1);
                            UserLoginInfo.name_user = reader.GetString(2);
                            UserLoginInfo.password_user = reader.GetString(3);
                            UserLoginInfo.language_user = reader.GetString(4);
                            UserLoginInfo.blocked_user = reader.GetBoolean(5);
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
                    command.CommandText = "select id_employee, id_area, name_user, language_user, blocked_user from Users"; // Ajusta la consulta según tu estructura de base de datos

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            BE_User usuario = new BE_User();
                            usuario.id_employee = reader.GetString(0);
                            usuario.id_area = reader.GetString(1);
                            usuario.name_user = reader.GetString(2);
                            usuario.language_user = reader.GetString(3);
                            usuario.blocked_user = reader.GetBoolean(4);

                            usuarios.Add(usuario);
                        }
                    }
                }
            }

            return usuarios;
        }
    }
}
