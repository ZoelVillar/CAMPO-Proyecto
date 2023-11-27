using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.Biatcora
{
    public class BE_BitacoraCambiosProducto
    {
        public int IdCambio { get; set; }
        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public int IdCategoria { get; set; }
        public int Stock { get; set; }
        public decimal PrecioCompra { get; set; }
        public decimal PrecioVenta { get; set; }
        public bool Estado { get; set; }
        public DateTime FechaCreado { get; set; }
        public bool Activo { get; set; }
        public int DigitoHorizontal { get; set; }
        public DateTime FechaBitacora { get; set; }
    }
}
