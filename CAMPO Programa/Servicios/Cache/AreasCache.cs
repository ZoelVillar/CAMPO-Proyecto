using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace Servicios.Cache
{
    public static class AreasCache //Static: Los valores son permanentes mientras la app exista
    {
        public static List<BE_Areas> ListaAreas { get; set; } = new List<BE_Areas>();

    }
}
