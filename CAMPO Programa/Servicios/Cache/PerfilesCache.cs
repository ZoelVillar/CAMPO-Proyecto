using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using BE.Usuarios;


namespace Servicios.Cache
{
    public static class PerfilesCache //Static: Los valores son permanentes mientras la app exista
    {
        public static List<BE_Perfil> ListaPerfil { get; set; } = new List<BE_Perfil>();

    }
}
