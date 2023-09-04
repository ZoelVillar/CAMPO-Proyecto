using BE;
using BE.Permisos;
using BE.Producto;
using BE.Usuarios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesosDatos.Usuarios
{
    public class DAO_Permiso
    {
        private AccesoSQL dbConnection;

        public DAO_Permiso()
        {
            dbConnection = AccesoSQL.getInstance();
        }

        public bool crearPermiso(string idPermiso, string tipoPermiso)
        {
            try
            {
                using (var connection = dbConnection.GetConnection())
                {
                    dbConnection.OpenConnection();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = $"select * from Permiso where id_Permiso = @idPermiso";
                        command.Parameters.AddWithValue("@idPermiso", idPermiso);
                        command.Parameters.AddWithValue("@tipoPermiso", tipoPermiso);
                        command.CommandType = CommandType.Text;

                        SqlDataReader reader = command.ExecuteReader();
                        if (!reader.HasRows)
                        {
                            reader.Close();
                            command.CommandText = $"Insert into Permiso values(@idPermiso, @tipoPermiso)";
                            command.CommandType = CommandType.Text;
                            int rowsAffected = command.ExecuteNonQuery();
                            return rowsAffected > 0;
                        }
                        else 
                        {
                            reader.Close();
                            return false;
                        }

                    }
                }

            }
            catch (SqlException Exception)
            {
                return false;
            }
        }

        public List<BE_Permiso> ObtenerPermisos(string tipoPermiso)
        {
            List<BE_Permiso> auxPermisos = new List<BE_Permiso>();

            try
            {
                using (var connection = dbConnection.GetConnection())
                {
                    dbConnection.OpenConnection();

                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "select * from Permiso where tipo_Permiso = @tipoPermiso";
                        command.Parameters.AddWithValue("@tipoPermiso", tipoPermiso);

                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.HasRows)
                        {
                            if(tipoPermiso == "C")
                            {
                                while (reader.Read())
                                {
                                    BE_PermisoCompuesto permisoC = new BE_PermisoCompuesto(reader.GetString(0));
                                    auxPermisos.Add(permisoC);
                                }
                            }
                            else
                            {
                                while(reader.Read())
                                {
                                    BE_PermisoSimple permisoS = new BE_PermisoSimple(reader.GetString(0));
                                    auxPermisos.Add(permisoS);
                                }
                            }
                        }

                        return auxPermisos;

                    }
                }

            }
            catch (SqlException Exception)
            {
                return auxPermisos;
            }

        }

        public bool VincularPermisos(string permisoA, string permisoB)
        {
            try
            {
                using (var connection = dbConnection.GetConnection())
                {
                    dbConnection.OpenConnection();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.Parameters.AddWithValue("@PermisoA", permisoA);
                        command.Parameters.AddWithValue("@PermisoB", permisoB);
                        command.CommandText = $"insert into RelacionPermisos values(@PermisoA,@PermisoB)";
                        command.CommandType = CommandType.Text;
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        { return true; }
                        else { return false; }
                    }
                }
            }
            catch (SqlException Exception)
            {
                return false;
            }
        }

        public bool ElimiarPermiso(string id_perfil)
        {
            try
            {
                using (var connection = dbConnection.GetConnection())
                {
                    dbConnection.OpenConnection();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;

                        command.CommandText = $"select * from RelacionPermisos where FK_CodigoPS=@id_perfil";
                        command.Parameters.AddWithValue("@id_perfil", id_perfil);
                        command.CommandType = CommandType.Text;
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                reader.Close();
                                command.CommandText = $"delete from RelacionPermisos where FK_CodigoPS=@id_perfil";
                                int rowsAffected = command.ExecuteNonQuery();
                                if (rowsAffected > 0)
                                { return eliminarPermisoBBDD(id_perfil); }
                                else { return false; }
                            }
                            else
                            {
                                reader.Close(); 
                                return eliminarPermisoBBDD(id_perfil);
                            }
                        }
                       

                       
                    }
                }
            }
            catch (SqlException Exception)
            {
                throw;
            }
        }

        private bool eliminarPermisoBBDD(string id_perfil)
        {
            using (var connection = dbConnection.GetConnection())
            {
                dbConnection.OpenConnection();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = $"delete from Permiso where id_Permiso=@id_perfil";
                    command.Parameters.AddWithValue("@id_perfil", id_perfil);
                    command.CommandType = CommandType.Text;
                    int rowsAffected2 = command.ExecuteNonQuery();

                    if (rowsAffected2 > 0)
                    { return true; }
                    else { return false; }
                }
            }
        }
                public List<BE_Permiso> ObtenerTodosPermisos()
        {
            List<BE_Permiso> auxPermisos = new List<BE_Permiso>();

            try
            {
                using (var connection = dbConnection.GetConnection())
                {
                    dbConnection.OpenConnection();

                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "select * from Permiso";

                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                if (reader.GetString(1) == "C")
                                {
                                    BE_PermisoCompuesto permisoC = new BE_PermisoCompuesto(reader.GetString(0));
                                    auxPermisos.Add(permisoC);
                                }
                                else
                                {
                                    BE_PermisoSimple permisoS = new BE_PermisoSimple(reader.GetString(0));
                                    auxPermisos.Add(permisoS);
                                }
                            }
                        }

                        return auxPermisos;

                    }
                }   
            }
            catch (SqlException Exception)
            {
                return auxPermisos;
            }

        }
    }
}
