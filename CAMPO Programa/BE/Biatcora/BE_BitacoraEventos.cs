using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.Biatcora
{
    public class BE_BitacoraEventos
    {
        public BE_BitacoraEventos(string user, DateTime fecha, string accion)
        {
            User = user;
            Fecha = fecha;
            Accion = accion;
        }

        public string User { get; set; }
        public DateTime Fecha { get; set; }
        public string Accion { get; set; }
    }
}
