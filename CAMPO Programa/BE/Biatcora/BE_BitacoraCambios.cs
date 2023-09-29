using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.Biatcora
{
    public class BE_BitacoraCambios
    {
        public int idBitacora { get; set; }
        public string usuario { get; set; }
        public string accion { get; set; }
        public string datoPrevio { get; set; }
        public string datoPosterior { get; set; }
        public DateTime fecha { get; set; }
        public string executedSQL { get; set; }
        public string reverseSQL { get; set; }
    }
}
