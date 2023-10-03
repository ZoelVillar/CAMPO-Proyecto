using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.Biatcora
{
    public class BE_BitacoraEventos
    {
        public int idBitacora { get; set; }
        public string User { get; set; }
        public DateTime Fecha { get; set; }
        public string Accion { get; set; }
        public string Modulo { get; set; }
        public int Criticidad { get; set; }
    }
}
