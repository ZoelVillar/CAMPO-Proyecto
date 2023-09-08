using AccesosDatos.Inventario;
using BE.Inventario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Inventario
{
    public class BLL_Categoria
    {
        DAO_Categoria daoCategoria = new DAO_Categoria();
        public List<BE_Categoria> obtenerCategorias()
        { 
            return daoCategoria.obtenerCategorias();
        }

        public bool crearCategoria(BE_Categoria categoria, out string mensaje)
        {
            mensaje = string.Empty;
            return daoCategoria.crearCategoria(categoria, out mensaje);
        }

        public bool modificarCategoria(BE_Categoria categoria)
        {
            return daoCategoria.modificarCategoria(categoria);
        }

        public bool eliminarCategoria(int categoria)
        {
            return daoCategoria.eliminarCategoria(categoria);
        }
    }
}
