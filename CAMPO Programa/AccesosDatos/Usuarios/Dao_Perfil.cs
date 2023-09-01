﻿using BE;
using BE.Permisos;
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
    public class Dao_Perfil
    {
        private AccesoSQL dbConnection;

        public Dao_Perfil()
        {
            dbConnection = AccesoSQL.getInstance();
        }

        public bool agregarPerfil(string id_perfil, string FK_PermisoPerfil)
        {
            using (var connection = dbConnection.GetConnection())
            {
                dbConnection.OpenConnection();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = $"INSERT INTO Perfil (id_perfil, FK_PermisoPerfil) VALUES (@id_perfil, @FK_PermisoPerfil)"; ;

                    // Parámetros para los valores a insertar
                    command.Parameters.AddWithValue("@id_perfil", id_perfil);
                    command.Parameters.AddWithValue("@FK_PermisoPerfil", FK_PermisoPerfil);
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    { return true; }
                    else { return false; }
                }
            }
        }

        public bool eliminarPerfil(string id_perfil)
        {
            using (var connection = dbConnection.GetConnection())
            {
                dbConnection.OpenConnection();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;

                    command.CommandText = $"select * from Users where id_perfil=@id_perfil";
                    command.Parameters.AddWithValue("@id_perfil", id_perfil);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (!reader.HasRows)
                    {
                        reader.Close();
                        command.CommandText = $"delete from Perfil where id_perfil=@id_perfil";
                        command.Parameters.AddWithValue("@id_perfil", id_perfil);
                        command.CommandType = CommandType.Text;

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        { return true; }
                        else { return false; }
                    }
                    else return false;

                    
                }
            }
        }

        public bool modificarPerfil(string id_perfil, string usuario)
        {
            using (var connection = dbConnection.GetConnection())
            {
                dbConnection.OpenConnection();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = $"update Users set id_perfil=@id_perfil where key_email=@usuario"; ;

                    // Parámetros para los valores a insertar
                    command.Parameters.AddWithValue("@id_perfil", id_perfil);
                    command.Parameters.AddWithValue("@usuario", usuario);
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    { return true; }
                    else { return false; }
                }
            }
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
                    command.CommandText = "SELECT id_perfil, FK_PermisoPerfil FROM Perfil";
                    command.CommandType = System.Data.CommandType.Text;

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            BE_Perfil perfil = new BE_Perfil();
                            perfil.id_perfil = reader.GetString(0);
                            perfil.FK_PermisoPerfil = new BE_PermisoCompuesto(reader.GetString(1));

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
