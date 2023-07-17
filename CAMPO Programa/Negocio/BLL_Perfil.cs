using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesosDatos;
using BE;


namespace Negocio
{
    public class BLL_Perfil
    {
        Dao_Perfil DaoPerfil = new Dao_Perfil();

        public List<BE_Perfil> retornaPerfiles()
        {
            return DaoPerfil.retornaPerfiles();
        }
    }
}
