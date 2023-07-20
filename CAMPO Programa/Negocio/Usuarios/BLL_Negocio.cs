using AccesosDatos;
using BE.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Usuarios
{
    public class BLL_Negocio
    {
        DAO_Negocio daoNegocio = new DAO_Negocio();

        public BE_Negocio retornarNegocio()
        {
            return daoNegocio.retornarNegocio();
        }
    }
}
