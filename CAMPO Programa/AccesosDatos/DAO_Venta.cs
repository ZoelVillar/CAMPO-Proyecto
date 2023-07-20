using BE.Venta;
using System;
using System.Collections.Generic;
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
            using (var connection = dbConnection.GetConnection())
            {
                dbConnection.OpenConnection();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = $"INSERT INTO Venta (mailUsuario, [montoPago], [montoCambio], [montoTotal], [nombreMesero], [numMesa], [comentariosAdicionales], [tipoPedido]) VALUES (@mailUsuario, @montoPago, @montoCambio, @montoTotal, @nombreMesero, @numMesa, @comentariosAdicionales, @tipoPedido)"; ;

                    // Parámetros para los valores a insertar
                    command.Parameters.AddWithValue("@mailUsuario", bEventa.oUsuario.key_email);
                    command.Parameters.AddWithValue("@montoPago", bEventa.montoPago);
                    command.Parameters.AddWithValue("@montoCambio", bEventa.montoCambio);
                    command.Parameters.AddWithValue("@montoTotal", bEventa.montoTotal);
                    command.Parameters.AddWithValue("@nombreMesero", bEventa.nombreMesero);
                    command.Parameters.AddWithValue("@numMesa", bEventa.numMesa);
                    command.Parameters.AddWithValue("@comentariosAdicionales", bEventa.comentariosAdicionales);
                    command.Parameters.AddWithValue("@tipoPedido", bEventa.tipoPedido);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    { return true; }
                    else { return false; }
                }
            }
        }
    }
}

