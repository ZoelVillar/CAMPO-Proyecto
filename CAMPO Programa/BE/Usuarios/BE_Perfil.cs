using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BE_Perfil
    {
        public BE_Perfil()
        {
        }

        public BE_Perfil(int idperfil, string nombreperfil, string descripcion)
        {
            this.id_perfil = idperfil;
            this.nombre_perfil = nombreperfil;
            this.descripcion = descripcion;
        }

        public int id_perfil { get; set; }
        public string nombre_perfil { get; set; }
        public string descripcion { get; set; }
    }
}
