using Servicios.Idiomas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vista.Usuarios.Idiomas;

namespace Vista.Inventario
{
    public partial class Vista_InventarioPrincipal : Form, IObserver
    {
        public Vista_InventarioPrincipal()
        {
            InitializeComponent();
        }
        public static Vista_InventarioPrincipal Instancia { get; private set; }
        private void Vista_InventarioPrincipal_Load(object sender, EventArgs e)
        {
            Instancia = this;
            IdiomasStatic.Observer.AgregarObservador(this);
            Actualizar();
        }

        public void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = panelFormularios.Controls.OfType<MiForm>().FirstOrDefault(); //Busca en la coleeccion el formulario


            if (formulario == null) // Si el form no existe
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelFormularios.Controls.Add(formulario);
                panelFormularios.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            else // Si el form existe
            {
                formulario.BringToFront();
            }
        }

        private void btnGestionCategorias_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Vista_GestionCategorias>();
        }

        private void btnGestionProductos_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Vista_GestionProductos>();
        }

        public void Actualizar()
        {
            IdiomasTraduccionServicios Idiomas = new IdiomasTraduccionServicios();
            Idiomas.CambiarIdiomaEnFormulario(this);
        }
    }
}
