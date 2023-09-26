using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.Biatcora
{
    public class BE_BitacoraEventos
    {
        public BE_BitacoraEventos()
        {
        }

        public int idBitacora { get; set; }
        public string User { get; set; }
        public string Fecha { get; set; }
        public string Accion { get; set; }
    }
}
