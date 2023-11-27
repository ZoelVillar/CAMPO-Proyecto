using BE.Biatcora;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesosDatos.Bitacora
{
    public class DAO_BitacoraCambiosProducto
    {
        private AccesoSQL dbConnection;
        public DAO_BitacoraCambiosProducto()
        {
            dbConnection = AccesoSQL.getInstance();
        }

        public BE_BitacoraCambiosProducto retornarElementoBitacora(int id)
        {
            BE_BitacoraCambiosProducto bitacoraCampo = new BE_BitacoraCambiosProducto();
            using (var connection = dbConnection.GetConnection())
            {
                dbConnection.OpenConnection();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT [idProducto] ,[codigo] ,[nombre] ,[descripcion] ,[idCategoria] ,[stock] ,[precioCompra] ,[precioVenta],[estado],[FechaCreacion],[DigitoHorizontal] FROM Producto WHERE idProducto = @idProducto";
                    command.Parameters.AddWithValue("@idProducto", id);
                    command.CommandType = CommandType.Text;

                    SqlDataReader dr = command.ExecuteReader();
                    if (dr.Read())
                    {
                        bitacoraCampo.IdProducto = Convert.ToInt32(dr["IdProducto"]);
                        bitacoraCampo.Nombre = dr["Nombre"].ToString();
                        bitacoraCampo.Codigo = dr["Codigo"].ToString();
                        bitacoraCampo.Descripcion = dr["Descripcion"].ToString();
                        bitacoraCampo.IdCategoria = Convert.ToInt32(dr["IdCategoria"]);
                        bitacoraCampo.Stock = Convert.ToInt32(dr["stock"].ToString());
                        bitacoraCampo.PrecioCompra = Convert.ToDecimal(dr["PrecioCompra"].ToString());
                        bitacoraCampo.PrecioVenta = Convert.ToDecimal(dr["Precioventa"].ToString());
                        bitacoraCampo.Estado = Convert.ToBoolean(dr["estado"]);
                        bitacoraCampo.Activo = true;
                        bitacoraCampo.FechaCreado = Convert.ToDateTime(dr["FechaCreacion"]);
                        bitacoraCampo.DigitoHorizontal = Convert.ToInt32(dr["DigitoHorizontal"]);

                    }

                    return bitacoraCampo;
                }
            }
        }
        public void GuardarBitacoraCambio(BE_BitacoraCambiosProducto bita)
        {
            try
            {
                using (var connection = dbConnection.GetConnection())
                {
                    dbConnection.OpenConnection();
                    // Desactivar el registro existente en la BitacoraCambios para el producto
                    using (SqlCommand comando = new SqlCommand())
                    {
                        comando.Connection = connection;
                        comando.Parameters.AddWithValue("@IdProducto", bita.IdProducto);
                        comando.CommandText = "UPDATE BitacoraCambios SET Activo = 0 WHERE IdProducto = @IdProducto";
                        comando.ExecuteNonQuery();
                    }

                    // Insertar nuevo registro en la BitacoraCambios
                    using (SqlCommand comando = new SqlCommand())
                    {
                        comando.Connection = connection;

                        comando.CommandText = "INSERT INTO BitacoraCambios (IdProducto,Codigo, Nombre,Descripcion,IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado,FechaCreado, Activo, DigitoHorizontal) " +
                                              "VALUES (@IdProducto,@Codigo, @Nombre, @Descripcion, @IdCategoria, @Stock,  @PrecioCompra, @PrecioVenta,@Estado,@FechaCreado, @Activo, @DigitoHorizontal)";
                        
                        comando.Parameters.AddWithValue("@IdProducto", bita.IdProducto);
                        comando.Parameters.AddWithValue("@Codigo", bita.Codigo);
                        comando.Parameters.AddWithValue("@Nombre", bita.Nombre);
                        comando.Parameters.AddWithValue("@Descripcion", bita.Descripcion);
                        comando.Parameters.AddWithValue("@IdCategoria", bita.IdCategoria);
                        comando.Parameters.AddWithValue("@Stock", bita.Stock);
                        comando.Parameters.AddWithValue("@PrecioCompra", bita.PrecioCompra);
                        comando.Parameters.AddWithValue("@PrecioVenta", bita.PrecioVenta);
                        comando.Parameters.AddWithValue("@Estado", bita.Estado);
                        comando.Parameters.AddWithValue("@FechaCreado", bita.FechaCreado);
                        comando.Parameters.AddWithValue("@Activo", bita.Activo);
                        comando.Parameters.AddWithValue("@DigitoHorizontal", bita.DigitoHorizontal);


                        comando.ExecuteNonQuery();
                    }
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
           


        }

        public List<BE_BitacoraCambiosProducto> RetornarBitacora()
        {
            List<BE_BitacoraCambiosProducto> ListaBitacora = new List<BE_BitacoraCambiosProducto>();
            try
            {
                using (var connection = dbConnection.GetConnection())
                {
                    dbConnection.OpenConnection();
                    using (var comando = new SqlCommand("SELECT IdProducto, IdCambio, Nombre, Stock, Descripcion, PrecioCompra, PrecioVenta, Activo, DigitoHorizontal FROM BitacoraCambio", connection))
                    {
                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                BE_BitacoraCambiosProducto bitacora = new BE_BitacoraCambiosProducto
                                {
                                    IdCambio = reader.GetInt32(0),
                                    IdProducto = reader.GetInt32(1),
                                    Codigo = !reader.IsDBNull(2) ? reader.GetString(2) : null,
                                    Nombre = !reader.IsDBNull(3) ? reader.GetString(3) : null,
                                    Descripcion = !reader.IsDBNull(4) ? reader.GetString(4) : null,
                                    IdCategoria = !reader.IsDBNull(5) ? reader.GetInt32(5) : 0,
                                    Stock = !reader.IsDBNull(6) ? reader.GetInt32(6) : 0,
                                    PrecioCompra = !reader.IsDBNull(7) ? reader.GetDecimal(7) : 0,
                                    PrecioVenta = !reader.IsDBNull(8) ? reader.GetDecimal(8) : 0,
                                    Estado = !reader.IsDBNull(9) && reader.GetBoolean(9),
                                    FechaCreado = !reader.IsDBNull(10) ? reader.GetDateTime(10) : DateTime.MinValue,
                                    Activo = !reader.IsDBNull(11) && reader.GetBoolean(11),
                                    DigitoHorizontal = !reader.IsDBNull(12) ? reader.GetInt32(12) : 0,
                                    FechaBitacora = !reader.IsDBNull(13) ? reader.GetDateTime(13) : DateTime.MinValue,
                                };
                                ListaBitacora.Add(bitacora);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return ListaBitacora;
        }

        public void ActivarCambio(BE_BitacoraCambiosProducto bitacora)
        {
            try
            {
                using (var connection = dbConnection.GetConnection())
                {
                    dbConnection.OpenConnection();
                    using (var comando = new SqlCommand())
                    {
                        comando.Connection = connection;
                        comando.Parameters.AddWithValue("@IdCambio", bitacora.IdCambio);
                        comando.Parameters.AddWithValue("@IdProducto", bitacora.IdProducto);
                        comando.Parameters.AddWithValue("@Codigo", bitacora.Codigo);
                        comando.Parameters.AddWithValue("@Nombre", bitacora.Nombre);
                        comando.Parameters.AddWithValue("@Descripcion", bitacora.Descripcion);
                        comando.Parameters.AddWithValue("@IdCategoria", bitacora.IdCategoria);
                        comando.Parameters.AddWithValue("@Stock", bitacora.Stock);
                        comando.Parameters.AddWithValue("@PrecioCompra", bitacora.PrecioCompra);
                        comando.Parameters.AddWithValue("@PrecioVenta", bitacora.PrecioVenta);
                        comando.Parameters.AddWithValue("@Estado", bitacora.Estado);
                        comando.Parameters.AddWithValue("@FechaCreado", bitacora.FechaCreado);
                        comando.Parameters.AddWithValue("@Activo", bitacora.Activo);
                        comando.Parameters.AddWithValue("@DigitoHorizontal", bitacora.DigitoHorizontal);
                        comando.CommandType = CommandType.Text;

                        // Desactivar el registro existente en la BitacoraCambios para el producto
                        comando.CommandText = "UPDATE BitacoraCambios SET Activo = 0 WHERE IdProducto = @IdProducto";
                        comando.ExecuteNonQuery();

                        // Activar el nuevo registro en la BitacoraCambios
                        comando.CommandText = "UPDATE BitacoraCambios SET Activo = 1 WHERE IdCambio = @IdCambio";
                      
                        comando.ExecuteNonQuery();

                        // Actualizar el producto con los datos de la bitácora
                        comando.CommandText = "UPDATE Producto SET " +
                                                "Codigo = @Codigo, " +
                                                "Nombre = @Nombre, " +
                                                "Descripcion = @Descripcion, " +
                                                "IdCategoria = @IdCategoria, " +
                                                "Stock = @Stock, " +
                                                "PrecioCompra = @PrecioCompra, " +
                                                "PrecioVenta = @PrecioVenta, " +
                                                "Estado = @Estado, " +
                                                "FechaCreacion = @FechaCreado, " +
                                                "DigitoHorizontal = @DigitoHorizontal " +
                                                "WHERE IdProducto = @IdProducto";
                    

                        comando.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
