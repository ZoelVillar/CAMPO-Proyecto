using BE.Permisos;
using BE.Usuarios;
using Microsoft.VisualBasic;
using Negocio;
using Negocio.Bitacora;
using Negocio.Usuarios;
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

namespace Vista
{
    public partial class Vista_GestionarPerfil : Form, IObserver
    {
        public Vista_GestionarPerfil()
        {
            InitializeComponent();
        }
        BLL_Permiso bllPermiso;
        BLL_RelacionPermisos bllRelacionPermisos;
        BLL_User bllUser;
        BLL_Perfil bllPerfil;
        public event EventHandler PerfilAgregado;
        private void Vista_GestionarPerfil_Load(object sender, EventArgs e)
        {
            IdiomasStatic.Observer.AgregarObservador(this);
            bllPermiso = new BLL_Permiso();
            bllRelacionPermisos = new BLL_RelacionPermisos();
            bllUser = new BLL_User();
            bllPerfil = new BLL_Perfil();

            grillaPC.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grillaPS.AllowUserToAddRows = false;
            grillaPC.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            grillaPC.AllowUserToAddRows = false; 
            grillaPS.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grillaPS.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            grillaPerfiles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grillaPerfiles.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            grillaPerfiles.AllowUserToAddRows = false; 

            refrescarGrilla();
            Actualizar();
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
            BLL_Bitacora bitacora = new BLL_Bitacora();
            bitacora.registrarBitacoraEvento($"Permiso Agregado", this.GetType().Name, 2);
            agregarPermiso("C");
        }

        private void btnAgregarPS_Click(object sender, EventArgs e)
        {

            BLL_Bitacora bitacora = new BLL_Bitacora();
            bitacora.registrarBitacoraEvento($"Permiso Agregado", this.GetType().Name, 2);
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
                string mensaje = $"¿Seguro que desea eliminar el Permiso Compuesto {permisoBorrar}? Los usuarios con este permiso pasarán a tener permiso de 'usuario'. Se eliminarán todas las relaciones de este permiso ";

                DialogResult result = MessageBox.Show(mensaje, "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    List<BE_Perfil> listaPerfilesBorrar = bllPerfil.retornaPerfiles().Where(x => x.FK_PermisoPerfil.idPermiso == permisoBorrar).ToList();
                    if(listaPerfilesBorrar.Count > 0)
                    {
                        foreach (BE_Perfil perfil in listaPerfilesBorrar)
                        {
                            bllPerfil.eliminarPerfil(perfil.id_perfil);
                        }                 
                    }

                    bllRelacionPermisos.eliminarRelacion(permisoBorrar);

                    if (bllPermiso.ElimiarPermiso(permisoBorrar))
                    {
                        MessageBox.Show("Permiso eliminado exitosamente");
                    }
                    else
                    {
                        MessageBox.Show("Hubo un problema eliminando el permiso");
                    }

                    foreach (DataGridViewRow row in grillaPC.Rows)
                    {
                        if (row.Cells["id_permiso"].Value != null && row.Cells["id_permiso"].Value.ToString() == "Administrador")
                        {
                            row.Selected = true;
                            break; 
                        }
                    }

                    refrescarArbol();
                    refrescarGrilla();
                    EventHandler handler = PerfilAgregado;
                    if (handler != null)
                    {
                        handler(this, EventArgs.Empty);
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

            if (bllPerfil.agregarPerfil(idPerfil, permisoPerfil)) 
            {
                BLL_Bitacora bitacora = new BLL_Bitacora();
                bitacora.registrarBitacoraEvento($"Perfil Agregado", this.GetType().Name, 1);
                refrescarGrilla();
                refrescarArbol();
            }
            else
            {
                MessageBox.Show("Error agregando el perfil");
            }

            EventHandler handler = PerfilAgregado;
            if(handler != null)
            {
                handler(this, EventArgs.Empty);
            }
        }

        private void btnEliminarPerfil_Click(object sender, EventArgs e)
        {
            string id_perfilBorrar = grillaPerfiles.CurrentRow.Cells[0].Value.ToString();
            
            DialogResult result = MessageBox.Show($"¿Desea eliminar el Perfil de {id_perfilBorrar}? Los usuarios con este perfil continuarán con el perfil 'Usuario Basico'", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (bllPerfil.eliminarPerfil(id_perfilBorrar)) {


                    BLL_Bitacora bitacora = new BLL_Bitacora();
                    bitacora.registrarBitacoraEvento($"Perfil Eliminado", this.GetType().Name, 1);

                    refrescarGrilla();
                    refrescarArbol();

                    EventHandler handler = PerfilAgregado;
                    if (handler != null)
                    {
                        handler(this, EventArgs.Empty);
                    }

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

        private void btnDesvincular_Click(object sender, EventArgs e)
        {
            TreeNode permisoDesvincular = treeViewPermisos.SelectedNode;
            if(permisoDesvincular != null && permisoDesvincular != treeViewPermisos.Nodes[0])
            {
                DialogResult result = MessageBox.Show($"¿Desea desvincular el Permiso {permisoDesvincular.Text} del Permiso Compuesto {treeViewPermisos.Nodes[0]}?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (bllRelacionPermisos.eliminarRelacion(treeViewPermisos.Nodes[0].Text, permisoDesvincular.Text))
                    {
                        refrescarArbol();
                        refrescarGrilla();
                        MessageBox.Show("Permisos desvinculados efectivamente");
                    }
                    else MessageBox.Show("Hubo un problema realizando la operación");
                }
            }

        }

        public void Actualizar()
        {
            IdiomasTraduccionServicios idioams = new IdiomasTraduccionServicios();
            idioams.CambiarIdiomaEnFormulario(this);
            idioams.TraducirColumnas(grillaPerfiles);
            idioams.TraducirColumnas(grillaPC);
            idioams.TraducirColumnas(grillaPS);
        }
    }
}
