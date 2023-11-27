using AccesosDatos.Inventario;
using BE.Inventario;
using BE.Venta;
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

        public void ActualizarStock(List<BE_DetalleVenta> detallesVenta)
        {
            var lista = daoProducto.retornarProductos();

            foreach (BE_DetalleVenta detalle in detallesVenta)
            {
                BE_Producto productoSeleccionado = lista.FirstOrDefault(p => p.IdProducto == detalle.oProducto.IdProducto);

                BE_Producto producto = new BE_Producto();

                // Asigna los valores del producto original al nuevo producto
                producto.IdProducto = detalle.oProducto.IdProducto;
                producto.Codigo = detalle.oProducto.Codigo;
                producto.Nombre = detalle.oProducto.Nombre;
                producto.Descripcion = detalle.oProducto.Descripcion;
                producto.oCategoria = detalle.oProducto.oCategoria;
                producto.PrecioCompra = detalle.oProducto.PrecioCompra;
                producto.PrecioVenta = detalle.oProducto.PrecioVenta;
                producto.Estado = detalle.oProducto.Estado;
                producto.FechaRegistro = detalle.oProducto.FechaRegistro;

                // Modifica el stock
                producto.Stock = productoSeleccionado.Stock - detalle.cantidad;

                // Llama a la función para modificar el producto
                daoProducto.actualizarStock(producto);
            }
        }
    }
}
