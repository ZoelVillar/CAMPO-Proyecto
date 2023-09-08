using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.Inventario
{
    public class BE_Categoria
    {
        public BE_Categoria()
        {
            
        }

        public BE_Categoria(string descripcion, bool estado)
        {
            this.descripcion = descripcion;
            this.estado = estado;
        }

        public BE_Categoria(int idCategoria, string descripcion, bool estado)
        {
            this.idCategoria = idCategoria;
            this.descripcion = descripcion;
            this.estado = estado;
        }
        public int idCategoria { get; set; }
        public string descripcion { get; set; }
        public bool estado { get; set; }

    }
}
