using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesosDatos;
using AccesosDatos.Usuarios;
using BE;
using BE.Permisos;
using BE.Usuarios;

namespace Negocio.Usuarios
{
    public class BLL_Permiso
    {
        DAO_Permiso DaoPerfil;
        DAO_RelacionPermisos RelacionPermisos;

        public BLL_Permiso() { 
            DaoPerfil = new DAO_Permiso();
            RelacionPermisos = new DAO_RelacionPermisos();
        }

        public bool crearPermiso(string idPermiso, string tipoPermiso)
        {
            return DaoPerfil.crearPermiso(idPermiso, tipoPermiso);
        }

        public List<BE_Permiso> ObtenerPermisos(string tipoPermiso)
        {
            return DaoPerfil.ObtenerPermisos(tipoPermiso);
        }

        public bool ElimiarPermiso(string idPermiso)
        {
            return DaoPerfil.ElimiarPermiso(idPermiso);
        }

        public bool agregarRelacion(string permiso1, string permiso2)
        {
            return RelacionPermisos.agregarRelacion(permiso1, permiso2);
        }
    }
}
