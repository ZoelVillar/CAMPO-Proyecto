using AccesosDatos.Idiomas;
using BE.Idiomas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Idiomas
{
    public class BLL_Idioma
    {

        DAO_Idioma daoIdioma = new DAO_Idioma();
        public BLL_Idioma()
        {
            listaTraducciones = daoIdioma.retornaTraducciones();
        }

        public List<BE_Traduccion> listaTraducciones { get; set; }

        public List<BE_Idioma> retornaIdiomas()
        {
            return daoIdioma.retornaIdiomas();
        }

        public List<BE_Traduccion> retornaTraducciones()
        {
            return daoIdioma.retornaTraducciones();
        }

        public List<BE_Traduccion> retornaTraduccionesIdioma(BE_Idioma Idioma)
        {
            return daoIdioma.retornaTraduccionesIdioma(Idioma);
        }
        public bool agregarIdioma(BE_Idioma idioma)
        {
            return daoIdioma.agregarIdioma(idioma);
        }


        public bool eliminarIdioma(int idioma)
        {
            return daoIdioma.eliminarIdioma(idioma);
        }

        public bool editarTraduccion(BE_Idioma Idioma, BE_TagIdioma etiqueta, string texto)
        {
            return daoIdioma.editarTraduccion(Idioma, etiqueta, texto);
        }

        public bool agregarTag(string tag, string descripcion)
        {
            return daoIdioma.agregarTag(tag, descripcion);
        }

        public bool eliminarTag(string TagID)
        {
            return daoIdioma.eliminarTag(TagID);
        }

    }
}
