
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE.Usuarios;

namespace BE.Compra
{
    public class BE_Compra
    {
        public int idCompra { get; set; }
        public BE_User oUsuario { get; set; }
        public BE_Proveedor oProveedor { get; set; }
        public decimal montoTotal { get; set; }
        public List<BE_DetalleCompra> oDetalleCompra { get; set; }
        public string fecha { get; set; }

    }
}
