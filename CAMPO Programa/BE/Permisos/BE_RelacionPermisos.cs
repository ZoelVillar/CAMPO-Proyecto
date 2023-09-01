using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.Permisos
{
    public class BE_RelacionPermisos
    {
        public BE_RelacionPermisos(BE_Permiso Permiso1, BE_Permiso Permiso2)
        {
            permiso1 = Permiso1;
            permiso2 = Permiso2;
        }

        public BE_Permiso permiso1 { get; set; }
        public BE_Permiso permiso2 { get; set; }
    }
}
