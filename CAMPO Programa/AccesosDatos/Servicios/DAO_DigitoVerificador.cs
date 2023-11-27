using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesosDatos.Servicios
{
    public class DAO_DigitoVerificador
    {
        private AccesoSQL dbConnection;
        public DAO_DigitoVerificador()
        {
            dbConnection = AccesoSQL.getInstance();
        }

        public static int ObtenerHash(string str)
        {
            return str.GetHashCode();
        }

        public bool VerificarDigito(string Tabla)
        {
            using (var connection = dbConnection.GetConnection())
            {
                dbConnection.OpenConnection();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = $"SELECT * FROM {Tabla}";
                    SqlDataAdapter DA = new SqlDataAdapter(command);
                    DataSet DS = new DataSet();
                    DA.Fill(DS);
                    if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
                    {
                        if (DS.Tables[0].Columns.Contains("FechaCreacion"))
                        {
                            DS.Tables[0].Columns.Remove("FechaCreacion");
                        }

                        foreach (DataRow Dr in DS.Tables[0].Rows)
                        {
                            string cadena = "";
                            foreach (object valor in Dr.ItemArray)
                            {
                                if (valor.ToString() == Dr["DigitoHorizontal"].ToString())
                                    continue;
                                cadena += valor.ToString();
                            }
                            int cadenaEncriptada = ObtenerHash(cadena);
                            if (int.Parse(Dr["DigitoHorizontal"].ToString()) != cadenaEncriptada)
                            {
                                return false;
                            }
                        }
                        return true;
                    } 
                    return false;
                }
            }
           
        }

        public bool UpdateDigitosVerificadores(string Tabla)
        {
            try
            {
                using (var connection = dbConnection.GetConnection())
                {
                    dbConnection.OpenConnection();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;

                        // Obtener todos los registros de la tabla
                        command.CommandText = $"SELECT * FROM {Tabla}";
                        SqlDataAdapter DA = new SqlDataAdapter(command);
                        DataSet DS = new DataSet();
                        DA.Fill(DS);

                        string NombreCampo = "DigitoHorizontal";

                        if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
                        {
                            if (DS.Tables[0].Columns.Contains("FechaCreacion"))
                            {
                                DS.Tables[0].Columns.Remove("FechaCreacion");
                            }
                            foreach (DataRow Dr in DS.Tables[0].Rows)
                            {
                                string cadena = "";
                                foreach (object valor in Dr.ItemArray)
                                {
                                    if (valor.ToString() == Dr[NombreCampo].ToString())
                                        continue;
                                    cadena += valor.ToString();
                                }

                                using (var comando2 = new SqlCommand())
                                {
                                    comando2.Connection = connection;
                                    int cadenaEncriptada = ObtenerHash(cadena);
                                    comando2.CommandText = $"UPDATE {Tabla} SET DigitoHorizontal = '{cadenaEncriptada}' WHERE {NombreCampo} = '{Dr[NombreCampo]}';";
                                    comando2.ExecuteNonQuery();
                                }
                            }

                            return true; // Operación exitosa
                        }
                        else
                        {
                            return false; // No hay registros en la tabla
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;   
                return false; // Error durante la operación
            }
        }

    }
}
