using Negocio.Bitacora;
using Negocio.Servicios;
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
using Vista.Usuarios.Idiomas;

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
            IdiomasTraduccionServicios idiomasTraduccion = new IdiomasTraduccionServicios();
            idiomasTraduccion.CambiarIdiomaEnFormulario(this);
        }

        private void btnBitacoraCambios_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Vista_BitacoraCambios>();
        }

        private void btnBitacoraEventos_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Vista_BitacoraEvento>();
        }

        private void btnRealziarRestore_Click(object sender, EventArgs e)
        {
            OpenFileDialog opn = new OpenFileDialog();
            opn.Filter = "SQL SERVER database backup files|*.bak";
            opn.Title = "Database Restore";
            if (opn.ShowDialog() == DialogResult.OK)
            {
                BLL_Backup backup = new BLL_Backup();
                if (backup.RestaurarBackup(opn.FileName))
                {
                    MessageBox.Show("Restore de la base de datos generado exitosamente");
                }
                else {          
                    MessageBox.Show("Error al realizar el restore de la base de datos");
                }

            }
        }

        private void btnRealizarBackup_Click(object sender, EventArgs e)
        {
            BLL_Backup backup = new BLL_Backup();
            string ruta = "";
            using (var fd = new FolderBrowserDialog())
            {
                if (fd.ShowDialog() == System.Windows.Forms.DialogResult.OK && !string.IsNullOrWhiteSpace(fd.SelectedPath))
                {
                    ruta = fd.SelectedPath;
                    if (backup.CrearBackup(ruta))
                    {
                        MessageBox.Show("Backup generado exitosamente");
                    }
                    else
                    {
                        MessageBox.Show("Error al generar el backup");
                    }
                }
            }
        }
    }
}
