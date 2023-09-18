using BE.Idiomas;
using Negocio.Idiomas;
using Servicios.Idiomas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista.Usuarios.Idiomas
{
    public class IdiomasTraduccionServicios
    {
        public void TraducirColumnas(DataGridView dataGridView)
        {
            BLL_Idioma bllIdioma = new BLL_Idioma();
            string idiomaActual = IdiomasStatic.Observer.obtenerIdiomaActual();
            var idiomaEncontrado = bllIdioma.retornaIdiomas().Find(x => x.nombre == idiomaActual);
            var traducciones = bllIdioma.retornaTraduccionesIdioma(new BE_Idioma() { id = idiomaEncontrado.id, nombre = idiomaEncontrado.nombre });

            foreach (DataGridViewColumn columna in dataGridView.Columns)
            {
                // Verifica si la columna tiene un nombre asignado
                if (!string.IsNullOrEmpty(columna.Name))
                {
                    // Busca la traducción correspondiente en las traducciones usando el nombre de la columna
                    var traduccion = traducciones.FirstOrDefault(t => t.tagIdioma.tag == columna.Name);

                    // Si se encuentra una traducción válida, asigna el texto traducido a la cabecera de la columna
                    if (traduccion != null && traduccion.textoTraducido != "-----")
                    {
                        columna.HeaderText = traduccion.textoTraducido;
                    }
                }
            }
        }

        public void CambiarIdiomaEnFormulario(Form formulario)
        {
            BLL_Idioma bllIdioma = new BLL_Idioma();
            string idiomaActual = IdiomasStatic.Observer.obtenerIdiomaActual();
            var idiomaEncontrado = bllIdioma.retornaIdiomas().Find(x => x.nombre == idiomaActual);
            var traducciones = bllIdioma.retornaTraduccionesIdioma(new BE_Idioma() { id = idiomaEncontrado.id, nombre = idiomaEncontrado.nombre });

            foreach (BE_Traduccion traduccion in traducciones)
            {
                RecorrerControles(formulario, traduccion);
            }
        }

        private void RecorrerControles(Control control, BE_Traduccion traduccion)
        {
            if (control.Tag != null && control.Tag.ToString() == traduccion.tagIdioma.tag)
            {
                if (traduccion.textoTraducido != "-----")
                {
                    control.Text = traduccion.textoTraducido;
                }
            }

            foreach (Control childControl in control.Controls)
            {
                RecorrerControles(childControl, traduccion);
            }
        }
    }
}
