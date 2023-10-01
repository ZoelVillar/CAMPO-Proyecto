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

        public bool guardarDatos(BE_Negocio negocio, out string mensaje)
        {
            return daoNegocio.guardarDatos(negocio, out mensaje);
        }

        public byte[] obtenerLogo(out bool obtenido)
        { 
            return daoNegocio.obtenerLogo(out obtenido);
        }

        public bool actualizarLogo(byte[] image, out string mensaje)
        { 
            return daoNegocio.actualizarLogo(image, out mensaje);
        }
    }
}
