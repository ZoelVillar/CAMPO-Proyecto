using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.Idiomas
{
    public class BE_Traduccion
    {
        public int id { get; set; }
        public BE_Idioma idIdioma { get; set; }
        public BE_TagIdioma tagIdioma { get; set; }
        public string textoTraducido { get; set; }

    }
}
