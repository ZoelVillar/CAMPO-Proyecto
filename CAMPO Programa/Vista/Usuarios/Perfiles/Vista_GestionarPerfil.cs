using BE.Usuarios;
using Microsoft.VisualBasic;
using Negocio;
using Negocio.Usuarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class Vista_GestionarPerfil : Form
    {
        public Vista_GestionarPerfil()
        {
            InitializeComponent();
        }
        BLL_Permiso bllPermiso;
        BLL_RelacionPermisos bllRelacionPermisos;
        BLL_User bllUser;
        BLL_Perfil bllPerfil;
        private void Vista_GestionarPerfil_Load(object sender, EventArgs e)
        {
            bllPermiso = new BLL_Permiso();
            bllRelacionPermisos = new BLL_RelacionPermisos();
            bllUser = new BLL_User();
            bllPerfil = new BLL_Perfil();

            grillaPC.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grillaPC.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            grillaPS.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grillaPS.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            grillaPerfiles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grillaPerfiles.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

        }

        private void refrescarGrilla()
        {
            var listaPC = bllPermiso.ObtenerPermisos("C");
            var listaPS = bllPermiso.ObtenerPermisos("S");

            foreach (var PC in listaPC)
            {
                grillaPC.Rows.Add(PC.idPermiso);
            }
            foreach (var PS in listaPS)
            {
                grillaPS.Rows.Add(PS.idPermiso);
            }

            //FALTA MOSTRAR PERFILES
        }

        private void agregarPermiso(string tipo)
        {
            string tipoMensaje = tipo == "S" ? "Simple" : "Compuesto";
            string nuevoPermiso = Interaction.InputBox($"Ingrese el nombre del Permiso {tipoMensaje}: ");
            if (nuevoPermiso == "") { MessageBox.Show("Ingrese un nombre válido!"); }
            else
            {
                if (bllPermiso.crearPermiso(nuevoPermiso, tipo))
                {
                    refrescarGrilla();
                }
                else
                {
                    MessageBox.Show("Hubo un error, verifique los datos ingresados");
                }
            }
        }
        private void btnAgregarPC_Click(object sender, EventArgs e)
        {
            agregarPermiso("C");
        }

        private void btnAgregarPS_Click(object sender, EventArgs e)
        {
            agregarPermiso("S");
        }

        private void btnBorrarPS_Click(object sender, EventArgs e)
        {
            string permiso = grillaPS.CurrentRow.Cells[0].Value.ToString();
            DialogResult result = MessageBox.Show($"¿Desea eliminar el permiso {permiso}?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (bllPermiso.ElimiarPermiso(permiso))
                {
                    MessageBox.Show($"El permiso '{permiso}' fue eliminado correctamente");
                }
                else
                {
                    MessageBox.Show($"Ocurrió un error al eliminar el permiso");
                }
            }

        }

        private void btnEliminarPC_Click(object sender, EventArgs e)
        {
            string permisoBorrar = grillaPC.CurrentRow.Cells[0].Value.ToString();

            if (string.IsNullOrEmpty(permisoBorrar) || string.IsNullOrWhiteSpace(permisoBorrar) || grillaPC.RowCount != 0 || grillaPC.SelectedRows.Count > 0)
            {
                string mensaje = $"¿Seguro que desea eliminar el Permiso Compuesto {permisoBorrar}? Los perfiles con este permiso pasarán a tener permiso de 'usuario'. Se eliminarán todas las relaciones de este permiso ";

                DialogResult result = MessageBox.Show(mensaje, "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (bllRelacionPermisos.eliminarRelacion(permisoBorrar))
                    {
                        List<BE_User> listaUsuario = bllUser.ObtenerUsuarios();
                        foreach (BE_User user in listaUsuario)
                        {
                            //SEGUIR ACA EL BORRADO DE: PERFIL CON ESE PC, USUARIO CON ESE PC -> Usuario
                        }
                     
                    }
                    else
                    {
                        MessageBox.Show("Hubo un problema eliminando el permiso");
                    } 
                }
            }
            else MessageBox.Show("Seleccione correctamente el permiso compuesto");
        }
    }
}
