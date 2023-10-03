using BE.Compra;
using BE.Inventario;
using BE.Usuarios;
using ClosedXML.Excel;
using Negocio.Bitacora;
using Negocio.Inventario;
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

namespace Vista.Usuarios
{
    public partial class Vista_GestionarProveedoes : Form, IObserver
    {
        string botonSeleccionado = "btnAgregar";
        private enum modoBoton
        {
            btnAgregar,
            btnEliminar,
            btnModificar
        }

        private modoBoton modoboton;

        BLL_Proveedor bllProveedor;
        public Vista_GestionarProveedoes()
        {
            InitializeComponent();
        }

        private void Vista_GestionarProveedoes_Load(object sender, EventArgs e)
        {
            IdiomasStatic.Observer.AgregarObservador(this);
            bllProveedor = new BLL_Proveedor();
            dataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            dataGrid.AllowUserToAddRows = false;

            ActualizarGrilla();
            cargarComboBusqueda();
            botonesSeleccionados();
            cargarComboEstado();

            Actualizar();
        }

        #region actualizaciones

        private void cargarComboEstado()
        {
            if (comboEstado.Items.Count == 0)
            {
                comboEstado.Items.Add(new ComboItem() { Value = "Activado", Text = "Activado" });
                comboEstado.Items.Add(new ComboItem() { Value = "Desactivado", Text = "Desactivado" });
            }

            if (comboEstado.Items.Count > 0)
            {
                comboEstado.SelectedIndex = 0;
            }
        }

        private void cargarComboBusqueda()
        {
            foreach (DataGridViewColumn col in dataGrid.Columns)
            {
                if (col.Visible)
                {
                    comboBuscar.Items.Add(new ComboItem() { Value = col.Name, Text = col.Name });

                }
            }

            if (comboBuscar.Items.Count > 0)
            {
                comboBuscar.SelectedIndex = 0;
            }
        }
        

        private void ActualizarGrilla()
        {
            dataGrid.Rows.Clear();

            var proveedores = bllProveedor.retornarProveedors();

            foreach (var proveedor in proveedores)
            {
                dataGrid.Rows.Add(proveedor.IdProveedor, proveedor.Documento, proveedor.Ubicacion, proveedor.Mail, proveedor.Telefono, proveedor.Estado ? "Activado" : "Descativado");
            }
        }

        #endregion
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            txtDocumento.ReadOnly = false;
            lblSeleccionado.Visible = false;
            lblSeleccionadoEspecifico.Visible = false;
            modoboton = modoBoton.btnAgregar;
            botonesSeleccionados();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dataGrid.RowCount != 0)
            {
                txtDocumento.ReadOnly = true;
                lblSeleccionado.Visible = true;
                lblSeleccionadoEspecifico.Visible = true;
                modoboton = modoBoton.btnModificar;
                botonesSeleccionados();
            }
            else
            {
                MessageBox.Show("No hay Proveedors a modificar.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGrid.RowCount != 0)
            {
                txtDocumento.ReadOnly = true;
                lblSeleccionado.Visible = true;
                lblSeleccionadoEspecifico.Visible = true;
                modoboton = modoBoton.btnEliminar;
                botonesSeleccionados();
            }
            else
            {
                MessageBox.Show("No hay Proveedors a eliminar.");
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            switch (modoboton)
            {
                case modoBoton.btnAgregar: agregar(); break;
                case modoBoton.btnEliminar: eliminar(); break;
                case modoBoton.btnModificar: modificar(); break;
            }
        }

        private void btnBorrarIngresoDatos_Click(object sender, EventArgs e)
        {
            txtDocumento.Text = "";
            txtMail.Text = "";
            txtDocumento.Text = "";
            comboEstado.SelectedIndex = 0;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string columnaSeleccionada = comboBuscar.SelectedItem.ToString();

            string textoBusqueda = txtBuscar.Text;

            if (dataGrid.Columns.Contains(columnaSeleccionada))
            {
                foreach (DataGridViewRow fila in dataGrid.Rows)
                {
                    string valorCelda = fila.Cells[columnaSeleccionada].Value?.ToString();

                    if (!string.IsNullOrEmpty(valorCelda) && valorCelda.IndexOf(textoBusqueda, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        fila.Visible = true;
                    }
                    else
                    {
                        fila.Visible = false;
                    }
                }
            }
            else
            {
                // La columna seleccionada no existe en la grilla.
                MessageBox.Show("La columna seleccionada no existe en la grilla.");
            }
        }

        private void btnBorrarBusqueda_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow fila in dataGrid.Rows)
            {
                fila.Visible = true;
            }

            txtBuscar.Text = "";
            dataGrid.Text = string.Empty;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow fila in dataGrid.Rows)
            {
                fila.Visible = true;
            }
            cargarComboEstado();
            cargarComboBusqueda();
            ActualizarGrilla();
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGrid.Rows.Count > 0)
                {
                    DataTable dt = new DataTable();

                    foreach (DataGridViewColumn column in dataGrid.Columns)
                    {
                        if (column.HeaderText != "" && column.Visible)
                        {
                            dt.Columns.Add(column.HeaderText, typeof(string));
                        }
                    }

                    foreach (DataGridViewRow row in dataGrid.Rows)
                    {
                        if (row.Visible)
                        {
                            dt.Rows.Add(new object[] {
                                    row.Cells[0].Value.ToString(),
                                    row.Cells[1].Value.ToString(),
                                    row.Cells[2].Value.ToString(),
                                    row.Cells[3].Value.ToString(),
                                    row.Cells[4].Value.ToString(),
                                    row.Cells[5].Value.ToString()
                                });

                        }
                    }

                    string nombreProyecto = this.GetType().Name;
                    if (nombreProyecto.StartsWith("Vista_"))
                    {
                        nombreProyecto = nombreProyecto.Substring("Vista_".Length);
                    }

                    SaveFileDialog savefile = new SaveFileDialog();
                    savefile.FileName = string.Format($"{nombreProyecto}_{DateTime.Now.ToString("ddMMyyyyHHmm")}.xlsx");
                    savefile.Filter = "Excel Files | *.xlsx";

                    if (savefile.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            XLWorkbook xLWorkbook = new XLWorkbook();
                            var hoja = xLWorkbook.Worksheets.Add(dt, "Reporte");
                            hoja.ColumnsUsed().AdjustToContents();
                            xLWorkbook.SaveAs(savefile.FileName);
                            MessageBox.Show("Reporte Generado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch
                        {
                            MessageBox.Show("Error generando el reporte", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No hay datos para descargar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un error inesperado");
            }
        }

        #region botones seleccionados


        private void botonesSeleccionados()
        {
            btnAgregar.BackColor = Color.FromArgb(64, 64, 64);
            btnEliminar.BackColor = Color.FromArgb(64, 64, 64);
            btnModificar.BackColor = Color.FromArgb(64, 64, 64);

            switch (modoboton)
            {
                case modoBoton.btnAgregar: btnAgregar.BackColor = Color.FromArgb(217, 129, 48); break;
                case modoBoton.btnEliminar: btnEliminar.BackColor = Color.FromArgb(217, 129, 48); break;
                case modoBoton.btnModificar: btnModificar.BackColor = Color.FromArgb(217, 129, 48); break;
            }
        }

        #endregion
        private void agregar()
        {
            if (!String.IsNullOrEmpty(txtDocumento.Text) && !String.IsNullOrEmpty(txtMail.Text) && !String.IsNullOrEmpty(txtUbicacion.Text) && !String.IsNullOrEmpty(txtTelefono.Text)  && !String.IsNullOrEmpty(comboEstado.Text))
            {
                BE_Proveedor proveedor = new BE_Proveedor()
                {
                    Documento = txtDocumento.Text,
                    Mail = txtMail.Text,
                    Ubicacion = txtUbicacion.Text,
                    Telefono = txtTelefono.Text,
                    Estado = comboEstado.Text == "Activado" ? true : false
                };

                DialogResult result = MessageBox.Show($"¿Desea agregar el proveedor {proveedor.Documento}?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (bllProveedor.crearProveedor(proveedor))
                    {

                        BLL_Bitacora bitacora = new BLL_Bitacora();
                        bitacora.registrarBitacoraEvento($"Proveedor Agregado", this.GetType().Name, 1);
                        MessageBox.Show("Proveedor agregado con éxito");
                        ActualizarGrilla();
                    }
                    else
                    {
                        MessageBox.Show("Hubo un problema agregando el Proveedor");
                    }

                }

            }
        }

        private void eliminar()
        {
            if (dataGrid.RowCount != 0)
            {
                if (dataGrid.SelectedRows.Count > 0)
                {
                    int id = int.Parse(dataGrid.SelectedRows[0].Cells["id"].Value.ToString());

                    DialogResult result = MessageBox.Show($"¿Desea eliminar el proveedor {dataGrid.SelectedRows[0].Cells["Documento"].Value.ToString()}?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        if (bllProveedor.eliminarProveedor(id))
                        {

                            BLL_Bitacora bitacora = new BLL_Bitacora();
                            bitacora.registrarBitacoraEvento($"Proveedor Eliminado", this.GetType().Name, 1);
                            MessageBox.Show("Proveedor eliminado con éxito");
                            ActualizarGrilla();
                        }
                        else
                        {
                            MessageBox.Show("Hubo un problema actualizando la categoría");
                        }

                    }

                }
            }
        }

        private void modificar()
        {
            if (dataGrid.RowCount != 0)
            {
                if (dataGrid.SelectedRows.Count > 0)
                {
                    if (!String.IsNullOrEmpty(txtDocumento.Text) && !String.IsNullOrEmpty(txtTelefono.Text) &&  !String.IsNullOrEmpty(txtMail.Text) && !String.IsNullOrEmpty(txtUbicacion.Text) && !String.IsNullOrEmpty(comboEstado.Text))
                    {
                        int id = int.Parse(dataGrid.SelectedRows[0].Cells["id"].Value.ToString());

                        DialogResult result = MessageBox.Show($"¿Desea modificar el proveedor {dataGrid.SelectedRows[0].Cells["Documento"].Value.ToString()}?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            BE_Proveedor proveedor = new BE_Proveedor()
                            {
                                IdProveedor = id,
                                Documento = txtDocumento.Text,
                                Ubicacion = txtUbicacion.Text,
                                Mail = txtMail.Text,
                                Telefono = txtTelefono.Text,
                                Estado = comboEstado.Text == "Activado" ? true : false
                            };

                            if (bllProveedor.modificarProveedor(proveedor))
                            {

                                BLL_Bitacora bitacora = new BLL_Bitacora();
                                bitacora.registrarBitacoraEvento($"Proveedor Modificado", this.GetType().Name, 1);
                                MessageBox.Show("Proveedor modificado con éxito");
                                ActualizarGrilla();
                            }
                            else
                            {
                                MessageBox.Show("Hubo un problema actualizando el Proveedor");
                            }

                        }
                    }
                }
            }
        }

        private void dataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblSeleccionadoEspecifico.Text = "";
            if (dataGrid.RowCount != 0)
            {
                if (dataGrid.SelectedRows.Count > 0)
                {
                    if (modoboton == modoBoton.btnModificar || modoboton == modoBoton.btnEliminar) 
                    {
                        txtDocumento.Text = dataGrid.SelectedRows[0].Cells["Documento"].Value.ToString();
                    }
                    lblSeleccionadoEspecifico.Text = dataGrid.SelectedRows[0].Cells["id"].Value.ToString() + "- " + dataGrid.SelectedRows[0].Cells["Documento"].Value.ToString();
                }
            }
        }

        public void Actualizar()
        {
            IdiomasTraduccionServicios idio = new IdiomasTraduccionServicios();
            idio.CambiarIdiomaEnFormulario(this);
            idio.TraducirColumnas(dataGrid);
        }
    }
}
