using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesosDatos;
using BE;
using BE.Usuarios;


namespace Negocio
{
    public class BLL_Perfil
    {
        Dao_Perfil DaoPerfil = new Dao_Perfil();

        public List<BE_Perfil> retornaPerfiles()
        {
            return DaoPerfil.retornaPerfiles();
        }

        public bool agregarPerfil(string id_perfil, string FK_PermisoPerfil)
        {
            return DaoPerfil.agregarPerfil(id_perfil, FK_PermisoPerfil);
        }

        public bool eliminarPerfil(string id_perfil)
        {
            return DaoPerfil.eliminarPerfil(id_perfil);
        }

        public bool modificarPerfil(string id_perfil, string usuario)
        {
         return DaoPerfil.modificarPerfil(id_perfil, usuario);
        }

    }
    
}
