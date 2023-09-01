using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.Permisos
{
    public abstract class BE_Permiso

    {
        public BE_Permiso(string idpermiso) {
            idPermiso = idpermiso;
        }

        public string idPermiso { get; set; }
        public abstract List<BE_Permiso> RetornarPermisos();


    }
}
