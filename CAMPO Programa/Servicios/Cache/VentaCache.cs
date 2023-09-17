using BE.Venta;
using Servicios.Idiomas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Cache
{
    public static class VentaCache
    {
        public static BE_Venta venta { get; set; } = new BE_Venta();

        public static ObserverVentas Observer { get; set; }  = new ObserverVentas();
        public static List<BE_DetalleVenta> listaDetalleVenta { get; set; } = new List<BE_DetalleVenta>();

        public static string ticketVenta { get; set; }
        public static void borrarCacheVenta()
        {
            venta.oUsuario = null;
            venta.montoPago = 0;
            venta.montoCambio = 0;
            venta.montoTotal = 0;
            venta.nombreMesero = "";
            venta.numMesa = 0;
            venta.comentariosAdicionales = "";
            venta.tipoPedido = "";
            venta.fechaCreacion = "";
            venta.oDetalleVenta = new List<BE_DetalleVenta>();

            listaDetalleVenta = listaDetalleVenta = new List<BE_DetalleVenta>();
        }
    }
}
