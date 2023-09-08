using BE.Inventario;
using BE.Usuarios;
using Negocio;
using Negocio.Inventario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista.Inventario
{
    public partial class Vista_GestionCategorias : Form
    {
        public Vista_GestionCategorias()
        {
            InitializeComponent();
        }

        BLL_Categoria bllCategoria;
        string botonSeleccionado = "btnAgregar";
        private enum modoBoton
        {
            btnAgregar,
            btnEliminar,
            btnModificar
        }

        private modoBoton modoboton;
        private void Vista_GestionCategorias_Load(object sender, EventArgs e)
        {
            bllCategoria = new BLL_Categoria(); 
            dataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            dataGrid.AllowUserToAddRows = false;
            ActualizarGrilla();
            cargarComboBusqueda();
            botonesSeleccionados();
            cargarComboEstado();
        }

        private void cargarComboEstado()
        {
            if (comboEstado.Items.Count == 0)
            {
                comboEstado.Items.Add(new ComboItem() { Value = "Activado", Text = "Activado"});
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
                    comboBuscar.Items.Add(new ComboItem() { Value = col.Name, Text = col.HeaderText });

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
            BLL_Categoria bllCat = new BLL_Categoria();

            var categorias = bllCat.obtenerCategorias();

            foreach (var categoria in categorias)
            {
                dataGrid.Rows.Add(categoria.idCategoria, categoria.descripcion, categoria.estado ? "Activado" : "Desactivado");
            }
        }

        #region "cambio de colores de botones"

        private void dataGridCategoria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblCategoria.Text = "";
            if (dataGrid.RowCount != 0)
            {
                if (dataGrid.SelectedRows.Count > 0)
                {
                    lblCategoria.Text = dataGrid.SelectedRows[0].Cells["idCategoria"].Value.ToString() + " " + dataGrid.SelectedRows[0].Cells["descripcion"].Value.ToString();
                }
            }
        }

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


        private void btnAceptar_Click(object sender, EventArgs e)
        {
            switch (modoboton)
            {
                case modoBoton.btnAgregar: agregar(); break;
                case modoBoton.btnEliminar: eliminar(); break;
                case modoBoton.btnModificar: modificar(); break;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            lblCategoriaSeleccionada.Visible = false;
            lblCategoria.Visible = false;
            modoboton = modoBoton.btnAgregar;
            botonesSeleccionados();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            lblCategoriaSeleccionada.Visible = true;
            lblCategoria.Visible = true;
            modoboton = modoBoton.btnModificar;
            botonesSeleccionados();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGrid.RowCount != 0)
            {
                lblCategoriaSeleccionada.Visible = true;
                lblCategoria.Visible = true;
            }
            modoboton = modoBoton.btnEliminar;
            botonesSeleccionados();
        }


        #endregion

        private void agregar()
        {
            if(!String.IsNullOrEmpty(txtDescripcion.Text) && !String.IsNullOrEmpty(comboEstado.Text))
            {
                var mensaje = string.Empty;
                BE_Categoria categoria = new BE_Categoria() { descripcion = txtDescripcion.Text, estado = comboEstado.Text == "Activado" ? true : false };
                if (bllCategoria.crearCategoria(categoria,out mensaje))
                {
                    MessageBox.Show("Categoría agregada con éxito");
                    ActualizarGrilla();
                }
                else
                {
                    MessageBox.Show("Hubo un problema actualizando la categoría");
                }
            }
        }

        private void modificar()
        {
            if (dataGrid.RowCount != 0)
            {
                if (dataGrid.SelectedRows.Count > 0)
                {
                    if (!String.IsNullOrEmpty(txtDescripcion.Text) && !String.IsNullOrEmpty(comboEstado.Text))
                    {
                        var mensaje = string.Empty;
                        int id = int.Parse(dataGrid.SelectedRows[0].Cells["idCategoria"].Value.ToString());

                        BE_Categoria categoria = new BE_Categoria() { idCategoria = id, descripcion = txtDescripcion.Text, estado = comboEstado.Text == "Activado" ? true : false };

                        if (bllCategoria.modificarCategoria(categoria))
                        {
                            MessageBox.Show("Categoría modificada con éxito");
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

        private void eliminar()
        {
            if (dataGrid.RowCount != 0)
            {
                if (dataGrid.SelectedRows.Count > 0)
                {
                    
                    var mensaje = string.Empty;
                    int id = Int32.Parse(dataGrid.SelectedRows[0].Cells["idCategoria"].ToString());

                    if (bllCategoria.eliminarCategoria(id))
                    {
                        MessageBox.Show("Categoría eliminada con éxito");
                        ActualizarGrilla();
                    }
                    else
                    {
                        MessageBox.Show("Hubo un problema actualizando la categoría");
                    }
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string columnaSeleccionada = comboBuscar.SelectedItem.ToString();

            // Obtiene el texto de búsqueda del TextBox.
            string textoBusqueda = txtBuscar.Text;

            // Verifica si la columna seleccionada existe en la grilla.
            if (dataGrid.Columns.Contains(columnaSeleccionada))
            {
                // Itera a través de las filas de la grilla.
                foreach (DataGridViewRow fila in dataGrid.Rows)
                {
                    // Obtiene el valor de la celda en la columna seleccionada.
                    string valorCelda = fila.Cells[columnaSeleccionada].Value?.ToString();

                    // Compara el valor de la celda con el texto de búsqueda, ignorando mayúsculas y minúsculas.
                    if (!string.IsNullOrEmpty(valorCelda) && valorCelda.IndexOf(textoBusqueda, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        // Si se encuentra una coincidencia, muestra la fila en la grilla.
                        fila.Visible = true;
                    }
                    else
                    {
                        // Si no hay coincidencia, oculta la fila en la grilla.
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

        private void btnBorrarIngresoDatos_Click(object sender, EventArgs e)
        {
            txtDescripcion.Text = "";
            if (comboEstado.Items.Count > 0)
            {
                comboEstado.SelectedIndex = 0;
            }
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
    }
}
