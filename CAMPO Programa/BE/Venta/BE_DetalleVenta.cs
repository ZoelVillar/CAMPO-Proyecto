using BE.Producto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.Venta
{
    public class BE_DetalleVenta
    {
        public int idDetalleVenta { get; set; }
        public BE_Producto oProducto { get; set; }
        public decimal precioVenta { get; set; }
        public int cantidad { get; set; }
        public decimal subTotal { get; set; }
        public string Fecha { get; set; }
    }
}
