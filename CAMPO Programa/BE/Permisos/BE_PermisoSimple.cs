using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.Permisos
{
    public class BE_PermisoSimple : BE_Permiso
    {
        public BE_PermisoSimple(string idPermiso) : base(idPermiso){}
        public override List<BE_Permiso> RetornarPermisos()
        {
            return new List<BE_Permiso>() { this };
        }
    }
}
