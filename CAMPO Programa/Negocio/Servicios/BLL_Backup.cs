using AccesosDatos.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Servicios
{
    public class BLL_Backup
    {
        private DAO_Backup daoBackup;
        public BLL_Backup()
        {
            daoBackup = new DAO_Backup();
        }
        public bool CrearBackup(string ruta)
        {
            try
            {
                return daoBackup.CrearBackup(ruta);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool RestaurarBackup(string ruta)
        {
            try
            {
                return daoBackup.RestaurarBackup(ruta);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
