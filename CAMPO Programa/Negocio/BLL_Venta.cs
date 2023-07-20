using AccesosDatos;
using BE.Venta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class BLL_Venta
    {
        DAO_Venta daoVenta = new DAO_Venta();
        public bool CrearVenta(BE_Venta BEventa)
        {
            return daoVenta.CrearVenta(BEventa);
        }
    }
}
