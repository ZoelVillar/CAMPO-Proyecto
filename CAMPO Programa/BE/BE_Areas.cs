using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BE_Areas
    {
        public BE_Areas()
        {
        }

        public BE_Areas(int id_area, string nombre_area, string descripcion)
        {
            this.id_area = id_area;
            this.nombre_area = nombre_area;
            this.descripcion = descripcion;
        }

        public int id_area { get; set; }
        public string nombre_area { get; set; }
        public string descripcion { get; set; }
    }
}
