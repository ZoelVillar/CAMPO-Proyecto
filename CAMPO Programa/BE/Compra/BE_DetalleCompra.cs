using BE.Producto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.Compra
{
    public class BE_DetalleCompra
    {
        public int idDetalleCompra { get; set; }
        public BE_Producto oProducto { get; set; }
        public decimal precioCompra { get; set; }
        public decimal precioVenta { get; set; }
        public int cantidad { get; set; }
        public decimal total { get; set; }
        public string fecha { get; set; }
    }
}
    