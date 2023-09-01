using BE.Permisos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.Usuarios
{
    public class BE_Perfil
    {
        public BE_Perfil()
        {
        }

        public BE_Perfil( string id_perfil, BE_PermisoCompuesto fk_permiso)
        {
            this.id_perfil = id_perfil;
            this.FK_PermisoPerfil = fk_permiso;
        }

        public string id_perfil { get; set; }
        public BE_PermisoCompuesto FK_PermisoPerfil { get; set; }
    }
}
