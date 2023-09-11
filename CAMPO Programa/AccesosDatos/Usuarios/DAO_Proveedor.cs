using BE.Inventario;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE.Compra;

namespace AccesosDatos.Usuarios
{
    public class DAO_Proveedor
    {

        private AccesoSQL dbConnection;
        public DAO_Proveedor()
        {
            dbConnection = AccesoSQL.getInstance();
        }

        public List<BE_Proveedor> retornarProveedors()
        {
            using (var connection = dbConnection.GetConnection())
            {
                List<BE_Proveedor> listaProveedors = new List<BE_Proveedor>();
                dbConnection.OpenConnection();

                try
                {
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "SELECT [idProveedor],[Documento],[Ubicacion],[Mail],[Telefono], Estado from Proveedor";
                        command.CommandType = System.Data.CommandType.Text;

                        SqlDataReader dr = command.ExecuteReader();

                        if (dr.HasRows)
                        {
                            while (dr.Read())
                            {
                                listaProveedors.Add(new BE_Proveedor()
                                {
                                    IdProveedor = Convert.ToInt32(dr["IdProveedor"]),
                                    Documento = dr["Documento"].ToString(),
                                    Ubicacion = dr["Ubicacion"].ToString(),
                                    Mail = dr["Mail"].ToString(),
                                    Telefono = dr["Telefono"].ToString(),
                                    Estado = Convert.ToBoolean(dr["Estado"])
                                });
                            }
                            return listaProveedors;
                        }
                        else { return listaProveedors; }
                    }
                }
                catch (SqlException)
                {
                    return listaProveedors;
                }

            }
        }

        public bool crearProveedor(BE_Proveedor Proveedor)
        {
            try
            {
                using (var connection = dbConnection.GetConnection())
                {
                    dbConnection.OpenConnection();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "SP_GuardarProveedor";
                        command.Parameters.AddWithValue("Documento", Proveedor.Documento);
                        command.Parameters.AddWithValue("Ubicacion", Proveedor.Ubicacion);
                        command.Parameters.AddWithValue("Mail", Proveedor.Mail);
                        command.Parameters.AddWithValue("Telefono", Proveedor.Telefono);
                        command.Parameters.AddWithValue("Estado", Proveedor.Estado);

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

        public bool modificarProveedor(BE_Proveedor Proveedor)
        {
            try
            {
                using (var connection = dbConnection.GetConnection())
                {
                    dbConnection.OpenConnection();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "SP_ModificarProveedor";
                        command.Parameters.AddWithValue("@idProveedor", Proveedor.IdProveedor);
                        command.Parameters.AddWithValue("@Documento", Proveedor.Documento);
                        command.Parameters.AddWithValue("@Ubicacion", Proveedor.Ubicacion);
                        command.Parameters.AddWithValue("@Mail", Proveedor.Mail);
                        command.Parameters.AddWithValue("@Telefono", Proveedor.Telefono);
                        command.Parameters.AddWithValue("@estado", Proveedor.Estado);


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

        public bool eliminarProveedor(int idProveedor)
        {
            try
            {
                using (var connection = dbConnection.GetConnection())
                {
                    dbConnection.OpenConnection();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "SP_EliminarProveedor";
                        command.Parameters.AddWithValue("@idProveedor", idProveedor);
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
