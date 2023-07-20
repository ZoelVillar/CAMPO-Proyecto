using BE;
using BE.Producto;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesosDatos.Producto
{
    public class DAO_Producto
    {
        private AccesoSQL dbConnection;

        public DAO_Producto()
        {
            dbConnection = AccesoSQL.getInstance();
        }
        public List<BE_Producto> retornarProductos()
        {
            using (var connection = dbConnection.GetConnection())
            {
                List<BE_Producto> listaProductos = new List<BE_Producto>();
                dbConnection.OpenConnection();

                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT [idProducto],[codigo],[nombre],p.[descripcion],c.[idCategoria], c.descripcion[DescripcionCategoria], p.stock,[precioCompra],[precioVenta], p.estado FROM Producto p \r\ninner join Categoria c on c.idCategoria = p.idCategoria";
                    command.CommandType = System.Data.CommandType.Text;

                    SqlDataReader dr = command.ExecuteReader();

                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            listaProductos.Add(new BE_Producto()
                            {
                                IdProducto = Convert.ToInt32(dr["IdProducto"]),
                                Codigo = dr["Codigo"].ToString(), 
                                Nombre = dr["Nombre"].ToString(),
                                Descripcion = dr["Descripcion"].ToString(),
                                oCategoria = new BE_Categoria() { IdCategoria = Convert.ToInt32(dr["IdCategoria"]), Descripcion = dr["DescripcionCategoria"].ToString() },
                                Stock = Convert.ToInt32(dr["stock"].ToString()),
                                PrecioCompra = Convert.ToDecimal(dr["PrecioCompra"].ToString()),
                                PrecioVenta = Convert.ToDecimal(dr["Precioventa"].ToString()),
                                Estado = Convert.ToBoolean(dr["Estado"])
                            });
                        }
                        return listaProductos;
                    }
                    else { return listaProductos; }
                }
            }
        }
    }
}
