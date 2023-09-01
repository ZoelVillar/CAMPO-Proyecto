using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.Permisos
{
    public class BE_PermisoCompuesto : BE_Permiso
    {
        public List<BE_Permiso> ListaPermisos;
        private List<BE_Permiso> auxListaPermisos;

        public BE_PermisoCompuesto(string idPermiso) : base(idPermiso)
        {
            ListaPermisos = new List<BE_Permiso>();
        }

        public override List<BE_Permiso> RetornarPermisos()
        {
            auxListaPermisos = new List<BE_Permiso>();
            lecturaPermisos(ListaPermisos);
            return auxListaPermisos;
        }

        public void lecturaPermisos(List<BE_Permiso> listaRecursiva)
        {
            foreach(BE_Permiso permiso in listaRecursiva)
            {
                if(permiso is BE_PermisoSimple)
                {
                    auxListaPermisos.Add(permiso);
                }
                else
                {
                    lecturaPermisos((permiso as BE_PermisoCompuesto).ListaPermisos);
                }
            }
        }
    }
}
