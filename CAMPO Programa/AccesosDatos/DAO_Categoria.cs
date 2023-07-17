using BE;
using BE.Producto;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesosDatos
{
    public class DAO_Categoria
    {
        private AccesoSQL dbConnection;

        public DAO_Categoria()
        {
            dbConnection = AccesoSQL.getInstance();
        }

        public List<BE_User> Listar()
        {
            List<BE_User> lista = new List<BE_User>();

            using (var connection = dbConnection.GetConnection())
            {
                dbConnection.OpenConnection();
                StringBuilder query = new StringBuilder();
                query.AppendLine("select idCategoria, descripcion, estado from Categoria");
               
                using (var command = new SqlCommand(query.ToString(), connection))
                {
                    command.CommandType = CommandType.Text;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            BE_Categoria Categoria = new BE_Categoria();

                            Categoria.IdCategoria = Convert.ToInt32(reader["idCategoria"]);
                            Categoria.Descripcion = reader["Description"].ToString();
                            Categoria.Estado = Convert.ToBoolean(reader["Estado"]);
                            
                            
                        }
                    }
                }
            }
            return lista;
        }

        //public int Registrar(BE_Categoria obj, out string Mensaje)
        //{
        //    int idCategoriaGenerado = 0;
        //    Mensaje = string.Empty;
        //    using (var connection = dbConnection.GetConnection())
        //    {
        //        SqlCommand cmd = new SqlCommand(" SP_RegistrarCategoria", connection);
        //        cmd.Parameters.AddWithValue("Descripcion")

        //    }
        //}
    }
}
