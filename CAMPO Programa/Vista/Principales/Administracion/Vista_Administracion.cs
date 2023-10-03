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
using Vista.Bitacora;

namespace Vista.Principales.Administracion
{
    public partial class Vista_Administracion : Form, IObserver
    {
        public Vista_Administracion()
        {
            InitializeComponent();
        }
        private void Vista_Administracion_Load(object sender, EventArgs e)
        {
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


        private void btnGestionNegocio_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Vista_Negocio>();
        }

        public void Actualizar()
        {
        }

        private void btnBitacoraCambios_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Vista_BitacoraCambios>();
        }

        private void btnBitacoraEventos_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Vista_BitacoraEvento>();
        }
    }
}
