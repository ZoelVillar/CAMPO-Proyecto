using BE.Idiomas;
using BE.Inventario;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AccesosDatos.Idiomas
{
    public class DAO_Idioma
    {
        private AccesoSQL dbConnection;
        public DAO_Idioma()
        {
            dbConnection = AccesoSQL.getInstance();
        }

        public List<BE_Idioma> retornaIdiomas()
        {
            List<BE_Idioma> listaIdiomas = new List<BE_Idioma>();
            try
            {
                using (var connection = dbConnection.GetConnection())
                {
                    dbConnection.OpenConnection();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "select * from Idioma";
                        command.CommandType = CommandType.Text;

                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                listaIdiomas.Add(
                                    new BE_Idioma() { 
                                        id = Convert.ToInt32(reader["ID"]), 
                                        nombre = reader["Nombre"].ToString() 
                                    });
                            }
                            return listaIdiomas;
                        }
                        else { return listaIdiomas; }
                    }
                }
            }catch{ return listaIdiomas;  }
        }

        public List<BE_Traduccion> retornaTraducciones()
        {
            List<BE_Traduccion> listaTraducciones = new List<BE_Traduccion>();
            try
            {
                using (var connection = dbConnection.GetConnection())
                {
                    dbConnection.OpenConnection();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "select T.ID as 'TraduccionID', I.ID as 'IdiomaID', I.Nombre, E.ID as 'TagID', E.Tag, T.TextoTraducido from Traduccion T inner join Idioma I ON T.IdiomaID = I.ID inner join Etiqueta E on T.EtiquetaID = E.ID ";
                        command.CommandType = CommandType.Text;

                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                listaTraducciones.Add(
                                    new BE_Traduccion()
                                    {
                                        id = Convert.ToInt32(reader["TraduccionID"]),
                                        idIdioma = new BE_Idioma() { id = Convert.ToInt32(reader["IdiomaID"]), nombre = reader["Nombre"].ToString() },
                                        tagIdioma = new BE_TagIdioma() { id = Convert.ToInt32(reader["TagID"]), tag = reader["Tag"].ToString() },
                                        textoTraducido = reader["TextoTraducido"].ToString()
                                    });
                            }
                            return listaTraducciones;
                        }
                        else { return listaTraducciones; }
                    }
                }
            }
            catch { return listaTraducciones; }
        }

        public List<BE_Traduccion> retornaTraduccionesIdioma(BE_Idioma Idioma)
        {
            List<BE_Traduccion> listaTraducciones = new List<BE_Traduccion>();
            try
            {
                using (var connection = dbConnection.GetConnection())
                {
                    dbConnection.OpenConnection();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "select T.ID as 'TraduccionID', I.ID as 'IdiomaID', I.Nombre, E.ID as 'TagID', E.Tag, T.TextoTraducido from Traduccion T inner join Idioma I ON T.IdiomaID = I.ID inner join Etiqueta E on T.EtiquetaID = E.ID  where I.ID = @idioma";
                        command.Parameters.AddWithValue("@idioma", Idioma.id);
                        command.CommandType = CommandType.Text;

                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                listaTraducciones.Add(
                                    new BE_Traduccion()
                                    {
                                        id = Convert.ToInt32(reader["TraduccionID"]),
                                        idIdioma = new BE_Idioma() { id = Convert.ToInt32(reader["IdiomaID"]), nombre = reader["Nombre"].ToString() },
                                        tagIdioma = new BE_TagIdioma() { id = Convert.ToInt32(reader["TagID"]), tag = reader["Tag"].ToString() },
                                        textoTraducido = reader["TextoTraducido"].ToString()
                                    });
                            }
                            return listaTraducciones;
                        }
                        else { return listaTraducciones; }
                    }
                }
            }
            catch { return listaTraducciones; }
        }

        public bool agregarIdioma(BE_Idioma idioma)
        {
            try
            {
                using (var connection = dbConnection.GetConnection())
                {
                    dbConnection.OpenConnection();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "SP_GuardarIdiomaConTraducciones";
                        command.Parameters.AddWithValue("@Nombre", idioma.nombre);
                        command.Parameters.AddWithValue("@TextoInicial", "-----");


                        command.CommandType = CommandType.StoredProcedure;
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        { return true; }
                        else { return false; }
                    }
                }
            }
            catch { return false;  }
             
        }

        public bool eliminarIdioma(int idioma)
        {
            try
            {
                using (var connection = dbConnection.GetConnection())
                {
                    dbConnection.OpenConnection();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "SP_EliminarIdioma";
                        command.Parameters.AddWithValue("@IdiomaID", idioma);


                        command.CommandType = CommandType.StoredProcedure;
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        { return true; }
                        else { return false; }
                    }
                }
            }
            catch { return false; }

        }

        public bool editarTraduccion(BE_Idioma Idioma, BE_TagIdioma etiqueta, string texto)
        {
            try
            {
                using (var connection = dbConnection.GetConnection())
                {
                    dbConnection.OpenConnection();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "SP_EditarTraduccion";
                        command.Parameters.AddWithValue("@IdiomaID", Idioma.id);
                        command.Parameters.AddWithValue("@EtiquetaID", etiqueta.id);
                        command.Parameters.AddWithValue("@NuevoTexto", texto);
                        
                        command.CommandType = CommandType.StoredProcedure;
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        { return true; }
                        else { return false; }
                    }
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
