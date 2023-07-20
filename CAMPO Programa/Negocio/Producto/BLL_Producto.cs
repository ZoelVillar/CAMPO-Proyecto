using AccesosDatos.Producto;
using BE.Producto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Venta
{
    public class BLL_Producto
    {
        DAO_Producto daoProducto = new DAO_Producto();
        public List<BE_Producto> retornarProductos()
        {
            return daoProducto.retornarProductos();
        }
    }
}
