using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista.Usuarios
{
    public partial class Vista_PrincipalUsuarios : Form
    {
        public Vista_PrincipalUsuarios()
        {
            InitializeComponent();
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

        private void btnGestionUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Vista_GestionarUsuarios>();
        }

        private void btnGestionPerfiles_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Vista_GestionarPerfil>();
        }

        private void btnGestionProveedores_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Vista_GestionarProveedoes>();
        }
    }
}
