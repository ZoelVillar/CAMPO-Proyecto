using AccesosDatos.Inventario;
using BE.Inventario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Inventario

{
    public class BLL_Producto
    {
        DAO_Producto daoProducto = new DAO_Producto();
        public List<BE_Producto> retornarProductos()
        {
            return daoProducto.retornarProductos();
        }

        public bool crearProducto(BE_Producto producto)
        {
            return daoProducto.crearProducto(producto);
        }

        public bool modificarProducto(BE_Producto producto)
        {
            return daoProducto.modificarProducto(producto);
        }

        public bool eliminarProducto(int idProducto)
        {
            return daoProducto.eliminarProducto(idProducto);
        }
    }
}
