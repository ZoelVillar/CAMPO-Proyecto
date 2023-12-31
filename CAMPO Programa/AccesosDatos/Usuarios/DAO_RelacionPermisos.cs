﻿using BE.Permisos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace AccesosDatos.Usuarios
{
    public class DAO_RelacionPermisos
    {
        private AccesoSQL dbConnection;
        public DAO_RelacionPermisos()
        {
            dbConnection = AccesoSQL.getInstance();
        }

        public List<BE_RelacionPermisos> retornarPermisos()
        {
            List<BE_RelacionPermisos> listaRelacionPermisos = new List<BE_RelacionPermisos>();

            try
            {
                using (var connection = dbConnection.GetConnection())
                {
                    dbConnection.OpenConnection();

                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "select * from RelacionPermisos";

                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                BE_RelacionPermisos relacion = new BE_RelacionPermisos(
                                        new BE_PermisoCompuesto(reader.GetString(0)),
                                        new BE_PermisoSimple(reader.GetString(1))
                                    );
                                listaRelacionPermisos.Add(relacion);
                            }
                        }

                        return listaRelacionPermisos;

                    }
                }

            }
            catch (SqlException )
            {
                return listaRelacionPermisos;
            }

        }

        public List<BE_RelacionPermisos> retornarPermisos(string FK_CodigoPC)
        {
            List<BE_RelacionPermisos> listaRelacionPermisos = new List<BE_RelacionPermisos>();

            try
            {
                using (var connection = dbConnection.GetConnection())
                {
                    dbConnection.OpenConnection();

                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "select * from RelacionPermisos where FK_CodigoPC = @FK_CodigoPC";
                        command.Parameters.AddWithValue("@FK_CodigoPC", FK_CodigoPC);

                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                BE_RelacionPermisos relacion = new BE_RelacionPermisos(
                                        new BE_PermisoCompuesto(reader.GetString(0)),
                                        new BE_PermisoSimple(reader.GetString(1))
                                    );
                                listaRelacionPermisos.Add(relacion);
                            }
                        }

                        return listaRelacionPermisos;

                    }
                }
            }
            catch (SqlException )
            {
                return listaRelacionPermisos;
            }

        }

        public bool eliminarRelacion(string permiso1, string permiso2 = "")
        {
            try
            {
                using (var connection = dbConnection.GetConnection())
                {
                    dbConnection.OpenConnection();

                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;

                        if(permiso2 == "")
                        {
                            command.Parameters.AddWithValue("@permiso1", permiso1);
                            command.CommandText = "delete from RelacionPermisos where FK_CodigoPC = @permiso1";
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@permiso1", permiso1);
                            command.Parameters.AddWithValue("@permiso2", permiso2);
                            command.CommandText = "delete from RelacionPermisos where FK_CodigoPC = @permiso1 and FK_CodigoPS=@permiso2";
                        }

                        command.CommandType = CommandType.Text;
                        int rowsAffected = command.ExecuteNonQuery();
                                              
                        if (rowsAffected > 0)
                        { return true; }
                        else { return false; }
                    }
                }

            }
            catch (SqlException )
            {
                return false;
            }
        }

        public bool agregarRelacion(string permiso1, string permiso2)
        {
            try
            {
                using (var connection = dbConnection.GetConnection())
                {
                    dbConnection.OpenConnection();

                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;


                        command.CommandText = $"select * from RelacionPermisos where FK_CodigoPC = @Permiso1 AND FK_CodigoPS = @Permiso2";
                        command.Parameters.AddWithValue("@Permiso1", permiso1);
                        command.Parameters.AddWithValue("@Permiso2", permiso2);
                        command.CommandType = CommandType.Text;
                        SqlDataReader reader = command.ExecuteReader();

                        if (!reader.HasRows)
                        {
                            reader.Close();
                            command.CommandText = $"insert into RelacionPermisos values(@Permiso1,@Permiso2)";

                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            { return true; }
                            else { return false; }
                        }
                        else return false;


                    }

                }
            }
            catch (SqlException )
            {
                return false;
            }
        }
    }
}
