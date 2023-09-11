using AccesosDatos.Inventario;
using AccesosDatos.Usuarios;
using BE.Compra;
using BE.Inventario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Usuarios
{
    public class BLL_Proveedor
    {
        DAO_Proveedor daoProveedor = new DAO_Proveedor();
        public List<BE_Proveedor> retornarProveedors()
        {
            return daoProveedor.retornarProveedors();
        }

        public bool crearProveedor(BE_Proveedor Proveedor)
        {
            return daoProveedor.crearProveedor(Proveedor);
        }

        public bool modificarProveedor(BE_Proveedor Proveedor)
        {
            return daoProveedor.modificarProveedor(Proveedor);
        }

        public bool eliminarProveedor(int idProveedor)
        {
            return daoProveedor.eliminarProveedor(idProveedor);
        }
    }
}
