
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.Inventario
{
    public class BE_Producto
    {
        public BE_Producto()
        {
        }

        public BE_Producto(string codigo, string nombre, string descripcion, BE_Categoria oCategoria, int stock, decimal precioCompra, decimal precioVenta, bool estado)
        {
            Codigo = codigo;
            Nombre = nombre;
            Descripcion = descripcion;
            this.oCategoria = oCategoria;
            Stock = stock;
            PrecioCompra = precioCompra;
            PrecioVenta = precioVenta;
            Estado = estado;
        }

        public BE_Producto(int idProducto, string codigo, string nombre, string descripcion, BE_Categoria oCategoria, int stock, decimal precioCompra, decimal precioVenta, bool estado, string fechaRegistro)
        {
            IdProducto = idProducto;
            Codigo = codigo;
            Nombre = nombre;
            Descripcion = descripcion;
            this.oCategoria = oCategoria;
            Stock = stock;
            PrecioCompra = precioCompra;
            PrecioVenta = precioVenta;
            Estado = estado;
            FechaRegistro = fechaRegistro;
        }

        public int IdProducto { get; set; }
        public string Codigo {get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public BE_Categoria oCategoria {get; set; }
        public int Stock { get; set; }
        public decimal PrecioCompra{get; set; }
        public decimal PrecioVenta { get; set; }
        public bool Estado { get; set; }
        public string FechaRegistro { get; set; }
    }
}
