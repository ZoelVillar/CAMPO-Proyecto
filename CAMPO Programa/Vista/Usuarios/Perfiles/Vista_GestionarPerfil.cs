using BE.Permisos;
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

            refrescarGrilla();
        }

        private void refrescarArbol()
        {
            treeViewPermisos.Nodes.Clear();
            List<BE_Permiso> lista = bllPermiso.ObtenerTodosPermisos();
            string PCSeleccionado = grillaPC.SelectedRows[0].Cells[0].Value.ToString();
            BE_Permiso Permiso = new BE_PermisoCompuesto(PCSeleccionado);
            Permiso = lista.Find(p => p.idPermiso == Permiso.idPermiso);
            treeViewPermisos.Nodes.Add(LecturaNodo(Permiso));
            treeViewPermisos.ExpandAll();
        }
        private void refrescarGrilla()
        {
            var listaPC = bllPermiso.ObtenerPermisos("C");
            var listaPS = bllPermiso.ObtenerPermisos("S");
            var listaPerfiles = bllPerfil.retornaPerfiles();

            grillaPC.Rows.Clear();
            grillaPS.Rows.Clear();
            grillaPerfiles.Rows.Clear();

            foreach (var PC in listaPC)
            {
                grillaPC.Rows.Add(PC.idPermiso);
            }
            foreach (var PS in listaPS)
            {
                grillaPS.Rows.Add(PS.idPermiso);
            }
            foreach(var perfil in listaPerfiles)
            {
                grillaPerfiles.Rows.Add(perfil.id_perfil, perfil.FK_PermisoPerfil.idPermiso);
            }

            
            //FALTA MOSTRAR PERFILES
        }

        private void agregarPermiso(string tipo)
        {
            string tipoMensaje = tipo == "S" ? "Simple" : "Compuesto";
            string nuevoPermiso = Interaction.InputBox($"Ingrese el nombre del Permiso {tipoMensaje}: ");
            if (string.IsNullOrEmpty(nuevoPermiso)) { MessageBox.Show("Ingrese un nombre válido!"); }
            else
            {
                if (bllPermiso.crearPermiso(nuevoPermiso, tipo))
                {
                    refrescarGrilla();
                    refrescarArbol();
                }
                else
                {
                    MessageBox.Show("Hubo un error, verifique los datos ingresados");
                }
            }
        }

        public TreeNode LecturaNodo(BE_Permiso permiso)
        {
            TreeNode nodo = new TreeNode(permiso.idPermiso);
            foreach (BE_Permiso p in (permiso as BE_PermisoCompuesto).ListaPermisos)
            {
                if (p is BE_PermisoSimple)
                {
                    nodo.Nodes.Add(p.idPermiso);
                }
                else
                {
                    nodo.Nodes.Add(LecturaNodo(p as BE_PermisoCompuesto));
                }
            }
            return nodo;
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
            refrescarArbol();
            refrescarGrilla();

        }

        private void btnEliminarPC_Click(object sender, EventArgs e)
        {
            string permisoBorrar = grillaPC.CurrentRow.Cells[0].Value.ToString();

            if (!string.IsNullOrEmpty(permisoBorrar) && !string.IsNullOrWhiteSpace(permisoBorrar) && grillaPC.RowCount != 0 && grillaPC.SelectedRows.Count > 0)
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

        private void btnVincularPCaPS_Click(object sender, EventArgs e)
        {
            string PermisoCompuesto = grillaPC.CurrentRow.Cells[0].Value.ToString();
            string PermisoSimple = grillaPS.CurrentRow.Cells[0].Value.ToString();
            DialogResult result = MessageBox.Show($"¿Desea relacionar el permiso {PermisoCompuesto} con el permiso {PermisoSimple}?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (bllPermiso.agregarRelacion(PermisoCompuesto, PermisoSimple))
                {
                    MessageBox.Show($"Permisos {PermisoCompuesto} y {PermisoSimple} relacionados con exito!");
                }
                else
                {
                    MessageBox.Show("Ocurrió un error al relacionar los permisos!");
                }
                refrescarArbol();

            }
        }

        private void btnVincularPCaPC_Click(object sender, EventArgs e)
        { 
            string permisoSeleccionado = grillaPC.CurrentRow.Cells[0].Value.ToString();
            if (!string.IsNullOrEmpty(permisoSeleccionado) && !string.IsNullOrWhiteSpace(permisoSeleccionado) && grillaPC.RowCount != 0 && grillaPC.SelectedRows.Count > 0)
            {
                string permisoAgregar = Interaction.InputBox($"Ingrese el Permiso Compuesto a vincular con: {permisoSeleccionado}");
                if (!string.IsNullOrEmpty(permisoAgregar) && !string.IsNullOrWhiteSpace(permisoAgregar) && permisoSeleccionado.ToLower() != permisoAgregar.ToLower())
                {
                    if (encontrarEnGrilla(permisoAgregar))
                    {
                        if(!encontrarPermiso(permisoSeleccionado, permisoAgregar))
                        {
                            bllRelacionPermisos.agregarRelacion(permisoSeleccionado, permisoAgregar);
                            refrescarArbol();
                            refrescarGrilla();
                        }
                    }
                    else { MessageBox.Show("Ingrese un permiso compuesto válido"); }
                }
                else { MessageBox.Show("Ingrese un permiso compuesto válido"); }

            }
            else { MessageBox.Show("Ingrese un permiso compuesto válido"); }
        }

        private bool encontrarEnGrilla(string permisoEncontrar)
        {
            foreach (DataGridViewRow row in grillaPC.Rows)
            {
                if (row.Cells["id_permiso"].Value != null)
                {
                    // Compara el valor de la celda con el permiso que deseas agregar
                    if (row.Cells["id_permiso"].Value.ToString() == permisoEncontrar)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private bool encontrarPermiso(string permisoSeleccionado, string permisoAgregar)
        {
            foreach (var p in bllRelacionPermisos.retornarPermisos(permisoSeleccionado))
            {
                if(p.permiso1.idPermiso == permisoAgregar || p.permiso2.idPermiso == permisoAgregar)
                {
                    return true;
                }
            }
            return false;
        }

        private void btnAgregarPerfil_Click(object sender, EventArgs e)
        {
            string idPerfil = Interaction.InputBox("Ingrese el nombre del perfil: ");
            if (string.IsNullOrEmpty(idPerfil)) { return; }
            string permisoPerfil = grillaPC.CurrentRow.Cells[0].Value.ToString();

            bllPerfil.agregarPerfil(idPerfil, permisoPerfil);
            refrescarGrilla();
            refrescarArbol();
        }

        private void btnEliminarPerfil_Click(object sender, EventArgs e)
        {
            string id_perfilBorrar = grillaPerfiles.CurrentRow.Cells[0].Value.ToString();
            
            DialogResult result = MessageBox.Show($"¿Desea eliminar el Perfil de {id_perfilBorrar}", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (bllPerfil.eliminarPerfil(id_perfilBorrar)) {
                    refrescarGrilla();
                    refrescarArbol();
                    MessageBox.Show("Perfil eliminado correctamente"); 
                }
                else MessageBox.Show("No se logró eliminar el Perfil");
            }
            else { return; }
        }

        private void grillaPC_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            refrescarArbol();
        }
    }
}
