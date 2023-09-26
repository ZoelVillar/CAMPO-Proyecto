using BE.Biatcora;
using BE.Idiomas;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesosDatos.Bitacora
{
    public class DAO_BitaciraEventos
    {
        private AccesoSQL dbConnection;
        public DAO_BitaciraEventos()
        {
            dbConnection = AccesoSQL.getInstance();
        }
        public List<BE_BitacoraEventos> retornarBitacora()
        {
            List<BE_BitacoraEventos> listaBitacora = new List<BE_BitacoraEventos>();
            try
            {
                using (var connection = dbConnection.GetConnection())
                {
                    dbConnection.OpenConnection();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "select * from BitacoraEventos";
                        command.CommandType = CommandType.Text;

                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                listaBitacora.Add(
                                    new BE_BitacoraEventos()
                                    {
                                        idBitacora = reader.GetInt32(0),
                                        User = reader.GetString(1),
                                        Fecha = reader.GetString(2),
                                        Accion = reader.GetString(3)
                                    });
                            }
                            return listaBitacora;
                        }
                        else { return listaBitacora; }
                    }
                }
            }
            catch { return listaBitacora; }
        }

    }
}
