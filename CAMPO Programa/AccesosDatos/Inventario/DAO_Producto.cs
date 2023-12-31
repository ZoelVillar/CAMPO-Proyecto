﻿using AccesosDatos.Bitacora;
using AccesosDatos.Servicios;
using BE;
using BE.Biatcora;
using BE.Inventario;
using BE.Venta;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Servicios.Cache;

namespace AccesosDatos.Inventario
{
    public class DAO_Producto
    {
        DAO_DigitoVerificador DigitoVerificador = new DAO_DigitoVerificador();
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

                try
                {
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "SELECT [idProducto],[codigo],[nombre],p.[descripcion],c.[idCategoria], c.descripcion[DescripcionCategoria], p.stock,[precioCompra],[precioVenta], p.estado FROM Producto p inner join Categoria c on c.idCategoria = p.idCategoria";
                        command.CommandType = CommandType.Text;

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
                                    oCategoria = new BE_Categoria() { idCategoria = Convert.ToInt32(dr["IdCategoria"]), descripcion = dr["DescripcionCategoria"].ToString() },
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
                catch (SqlException)
                {
                    return listaProductos;
                }

            }
        }

        public bool crearProducto(BE_Producto producto)
        {

            try
            {
                using (var connection = dbConnection.GetConnection())
                {
                    dbConnection.OpenConnection();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "SP_GuardarProducto";
                        command.Parameters.AddWithValue("codigo", producto.Codigo);
                        command.Parameters.AddWithValue("nombre", producto.Nombre);
                        command.Parameters.AddWithValue("descripcion", producto.Descripcion);
                        command.Parameters.AddWithValue("idCategoria", producto.oCategoria.idCategoria);
                        command.Parameters.AddWithValue("stock", 0);
                        command.Parameters.AddWithValue("precioCompra", 0);
                        command.Parameters.AddWithValue("precioVenta", 0);
                        command.Parameters.AddWithValue("estado", producto.Estado);

                        command.Parameters.Add("@idProducto", SqlDbType.Int).Direction = ParameterDirection.Output;
                        command.Parameters.Add("@FechaCreacion", SqlDbType.DateTime).Direction = ParameterDirection.Output;

                        command.CommandType = CommandType.StoredProcedure;
                        int rowsAffected = command.ExecuteNonQuery();

                        DigitoVerificador.UpdateDigitosVerificadores("Producto");
                        DigitoVerificador.UpdateDigitosVerificadores("Producto");

                        if (rowsAffected > 0)
                        {

                            DAO_BitacoraCambiosProducto dAO_BitacoraCambiosProducto = new DAO_BitacoraCambiosProducto();
                            int idProductoGenerado = (int)command.Parameters["@idProducto"].Value;

                            BE_BitacoraCambiosProducto bE_BitacoraCambiosProducto = dAO_BitacoraCambiosProducto.retornarElementoBitacora(idProductoGenerado);
                            dAO_BitacoraCambiosProducto.GuardarBitacoraCambio(bE_BitacoraCambiosProducto); 
                            return true; 
                        }
                        else { return false; }
                    }
                }
            }
            catch (SqlException ex)
            {
                return false;
            }
        }

        public bool modificarProducto(BE_Producto producto)
        {
            try
            {
                using (var connection = dbConnection.GetConnection())
                {
                    dbConnection.OpenConnection();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "SP_ModificarProducto";
                        command.Parameters.AddWithValue("@idProducto", producto.IdProducto);
                        command.Parameters.AddWithValue("@codigo", producto.Codigo);
                        command.Parameters.AddWithValue("@nombre", producto.Nombre);
                        command.Parameters.AddWithValue("@descripcion", producto.Descripcion);
                        command.Parameters.AddWithValue("@idCategoria", producto.oCategoria.idCategoria);
                        command.Parameters.AddWithValue("@estado", producto.Estado);
                        command.Parameters.AddWithValue("@stock", producto.Stock);

                        command.CommandType = CommandType.StoredProcedure;
                        int rowsAffected = command.ExecuteNonQuery();


                        DigitoVerificador.UpdateDigitosVerificadores("Producto");
                        DigitoVerificador.UpdateDigitosVerificadores("Producto");

                        if (rowsAffected > 0)
                        {

                            DAO_BitacoraCambiosProducto dAO_BitacoraCambiosProducto = new DAO_BitacoraCambiosProducto();
                            

                            BE_BitacoraCambiosProducto bE_BitacoraCambiosProducto = dAO_BitacoraCambiosProducto.retornarElementoBitacora(producto.IdProducto);
                            dAO_BitacoraCambiosProducto.GuardarBitacoraCambio(bE_BitacoraCambiosProducto);
                            return true; }
                        else { return false; }
                    }
                }

            }
            catch (SqlException ex)
            {
                return false;
            }
        }

        public bool actualizarStock(BE_Producto producto)
        {
            try
            {
                using (var connection = dbConnection.GetConnection())
                {
                    dbConnection.OpenConnection();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "SP_ModificarProducto";
                        command.Parameters.AddWithValue("@idProducto", producto.IdProducto);
                        command.Parameters.AddWithValue("@stock", producto.Stock);

                        command.CommandType = CommandType.StoredProcedure;
                        int rowsAffected = command.ExecuteNonQuery();


                        DigitoVerificador.UpdateDigitosVerificadores("Producto");
                        DigitoVerificador.UpdateDigitosVerificadores("Producto");

                        if (rowsAffected > 0)
                        {

                            DAO_BitacoraCambiosProducto dAO_BitacoraCambiosProducto = new DAO_BitacoraCambiosProducto();

                            BE_BitacoraCambiosProducto bE_BitacoraCambiosProducto = dAO_BitacoraCambiosProducto.retornarElementoBitacora(producto.IdProducto);
                            dAO_BitacoraCambiosProducto.GuardarBitacoraCambio(bE_BitacoraCambiosProducto);
                            return true;
                        }
                        else { return false; }
                    }
                }

            }
            catch (SqlException )
            {
                return false;
            }
        }

        public bool eliminarProducto(int idProducto)
        {
            try
            {
                using (var connection = dbConnection.GetConnection())
                {
                    dbConnection.OpenConnection();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "SP_EliminarProducto";
                        command.Parameters.AddWithValue("@idProducto", idProducto);
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
