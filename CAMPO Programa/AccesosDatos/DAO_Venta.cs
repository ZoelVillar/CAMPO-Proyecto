using BE.Inventario;
using BE.Usuarios;
using BE.Venta;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesosDatos
{
    public class DAO_Venta
    {
        private AccesoSQL dbConnection;

        public DAO_Venta()
        {
            dbConnection = AccesoSQL.getInstance();
        }
        public bool CrearVenta(BE_Venta bEventa)
        {
            try
            {
                using (var connection = dbConnection.GetConnection())
                {
                    dbConnection.OpenConnection();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = $"INSERT INTO Venta (mailUsuario, [montoPago], [montoCambio], [montoTotal], [nombreMesero], [numMesa], [comentariosAdicionales], [tipoPedido], FormaPago) VALUES (@mailUsuario, @montoPago, @montoCambio, @montoTotal, @nombreMesero, @numMesa, @comentariosAdicionales, @tipoPedido, @FormaPago)"; ;

                        // Parámetros para los valores a insertar
                        command.Parameters.AddWithValue("@mailUsuario", bEventa.oUsuario.key_email);
                        command.Parameters.AddWithValue("@montoPago", bEventa.montoPago);
                        command.Parameters.AddWithValue("@montoCambio", bEventa.montoCambio);
                        command.Parameters.AddWithValue("@montoTotal", bEventa.montoTotal);
                        command.Parameters.AddWithValue("@nombreMesero", bEventa.nombreMesero);
                        command.Parameters.AddWithValue("@numMesa", bEventa.numMesa);
                        command.Parameters.AddWithValue("@comentariosAdicionales", bEventa.comentariosAdicionales);
                        command.Parameters.AddWithValue("@tipoPedido", bEventa.tipoPedido);
                        command.Parameters.AddWithValue("@FormaPago", bEventa.FormaPago);

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

        public List<BE_Venta> retornarVentas()
        {
            using (var connection = dbConnection.GetConnection())
            {
                List<BE_Venta> listaVentas = new List<BE_Venta>();
                dbConnection.OpenConnection();

                try
                {
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "select * from Venta";
                        command.CommandType = CommandType.Text;

                        SqlDataReader dr = command.ExecuteReader();

                        if (dr.HasRows)
                        {
                            while (dr.Read())
                            {
                                listaVentas.Add(new BE_Venta() {
                                    idVenta = Convert.ToInt32(dr["idVenta"]),
                                    oUsuario = new BE_User() { key_email = dr["mailUsuario"].ToString() },
                                    montoPago = Convert.ToDecimal(dr["montoPago"]),
                                    montoCambio = Convert.ToDecimal(dr["montoCambio"]),
                                    montoTotal = Convert.ToDecimal(dr["montoTotal"]),
                                    nombreMesero = dr["nombreMesero"].ToString(),
                                    numMesa = Convert.ToInt32(dr["numMesa"]),
                                    comentariosAdicionales = dr["comentariosAdicionales"].ToString(),
                                    tipoPedido = dr["tipoPedido"].ToString(),
                                    fechaCreacion = dr["fechaCreacion"].ToString(),
                                    FormaPago = dr["FormaPago"].ToString()
                                });
                            }
                            return listaVentas;
                        }
                        else { return listaVentas; }
                    }
                }
                catch (SqlException)
                {
                    return listaVentas;
                }

            }
        }
    }
}

