using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE.Usuarios;

namespace BE.Venta
{
    public class BE_Venta
    {
        public int idVenta { get; set; }
        public BE_User oUsuario { get; set; }
        public decimal montoPago { get; set; }
        public decimal montoCambio { get; set; }
        public decimal montoTotal { get; set; }
        public string nombreMesero { get; set; }
        public int numMesa { get; set; }
        public string comentariosAdicionales { get; set; }
        public string tipoPedido { get; set; }
        public string fechaCreacion { get; set; }
        public string FormaPago { get; set; }

        public List<BE_DetalleVenta> oDetalleVenta { get; set; }

      
    }
}
