using AccesosDatos.Usuarios;
using BE.Permisos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Usuarios
{
    public class BLL_RelacionPermisos
    {
        DAO_RelacionPermisos daoPermisos;

        public BLL_RelacionPermisos()
        {
            daoPermisos = new DAO_RelacionPermisos();
        }

        public List<BE_RelacionPermisos> retornarPermisos()
        {
            return daoPermisos.retornarPermisos();
        }

        public List<BE_RelacionPermisos> retornarPermisos(string FK_CodigoPC)
        {
            return daoPermisos.retornarPermisos(FK_CodigoPC);
        }

        public bool eliminarRelacion(string permiso1, string permiso2 = "")
        {
            return daoPermisos.eliminarRelacion(permiso1, permiso2);
        }

        public bool agregarRelacion(string permiso1, string permiso2)
        {
            return daoPermisos.agregarRelacion(permiso1, permiso2);
        }
    }
}
