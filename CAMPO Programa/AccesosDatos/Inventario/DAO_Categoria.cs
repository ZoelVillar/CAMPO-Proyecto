using BE.Inventario;
using BE.Permisos;
using BE.Usuarios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesosDatos.Inventario
{
    public class DAO_Categoria
    {
        private AccesoSQL dbConnection;

        public DAO_Categoria()
        {
            dbConnection = AccesoSQL.getInstance();
        }

        public List<BE_Categoria> obtenerCategorias()
        {
            List<BE_Categoria> listaCtegorias = new List<BE_Categoria>();

            try
            {
                using (var connection = dbConnection.GetConnection())
                {
                    dbConnection.OpenConnection();

                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "select idCategoria, descripcion, estado from Categoria";

                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                BE_Categoria categoria = new BE_Categoria();
                                categoria.idCategoria = Convert.ToInt32(reader["idCategoria"]);
                                categoria.descripcion = reader["descripcion"].ToString();
                                categoria.estado = Convert.ToBoolean(reader["estado"]);
                                listaCtegorias.Add(categoria);
                            }
                        }
                    }
                }

                return listaCtegorias;
            }
            catch (SqlException)
            {
                return listaCtegorias;
            }
        }

        public bool crearCategoria(BE_Categoria categoria, out string mensaje)
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
                        command.CommandText = "SP_GuardarCategoria";
                        command.Parameters.AddWithValue("descripcion", categoria.descripcion);
                        command.Parameters.AddWithValue("estado", categoria.estado);
                        command.Parameters.Add("resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                        command.Parameters.Add("mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                        command.CommandType = CommandType.StoredProcedure;

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

        public bool modificarCategoria(BE_Categoria categoria)
        {
            try
            {
                using (var connection = dbConnection.GetConnection())
                {
                    dbConnection.OpenConnection();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "SP_ModificarCategoria";
                        command.Parameters.AddWithValue("@idCategoria", categoria.idCategoria);
                        command.Parameters.AddWithValue("@descripcion", categoria.descripcion);
                        command.Parameters.AddWithValue("@estado", categoria.estado);
                        command.Parameters.Add("resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                        command.Parameters.Add("mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                        command.CommandType = CommandType.StoredProcedure;

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

        public bool eliminarCategoria(int categoria)
        {
            try
            {
                using (var connection = dbConnection.GetConnection())
                {
                    dbConnection.OpenConnection();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "SP_EliminarCategoria";
                        command.Parameters.AddWithValue("idCategoria", categoria);
                        command.CommandType = CommandType.StoredProcedure;

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
    }
}
