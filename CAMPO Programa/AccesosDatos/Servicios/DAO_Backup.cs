using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Servicios.Cache;


namespace AccesosDatos.Servicios
{
    public class DAO_Backup
    {
        private AccesoSQL dbConnection;
        public DAO_Backup()
        {
            dbConnection = AccesoSQL.getInstance();
        }
        public bool CrearBackup(string ruta)
        {
            try
            {
                string nombrecopia = $"DialectCafe_BackUp_{DateTime.Now:dd_MM_yyyy_HH-mm}.bak";
                using (var connection = dbConnection.GetConnection())
                {
                    dbConnection.OpenConnection();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = $"BACKUP DATABASE [DialectCafe] TO  DISK = N'{ruta}\\{nombrecopia}' WITH NOFORMAT, NOINIT,  NAME = N'LogIn-Full Database Backup', SKIP, NOREWIND, NOUNLOAD,  STATS = 10";
                        command.ExecuteNonQuery();
                    }
                }
                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool RestaurarBackup(string ruta)
        {
            try
            {
                using (var connection = dbConnection.GetConnection())
                {
                    dbConnection.OpenConnection();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "ALTER DATABASE [DialectCafe] SET SINGLE_USER WITH ROLLBACK IMMEDIATE";
                        command.ExecuteNonQuery();

                        command.CommandText = "USE MASTER RESTORE DATABASE [DialectCafe] FROM DISK=@ruta WITH REPLACE";
                        command.Parameters.AddWithValue("@ruta", ruta);
                        command.ExecuteNonQuery();

                        command.CommandText = "ALTER DATABASE [DialectCafe] SET MULTI_USER";
                        command.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception)
            {
                // Considera registrar la excepción aquí
                return false;
            }
        }

    }
}
