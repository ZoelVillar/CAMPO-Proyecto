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
    public partial class Vista_GestionProductos : Form
    {
        BLL_Producto bllProducto;
        string botonSeleccionado = "btnAgregar";
        private enum modoBoton
        {
            btnAgregar,
            btnEliminar,
            btnModificar
        }

        private modoBoton modoboton;
        public Vista_GestionProductos()
        {
            InitializeComponent();
        }

        private void Vista_GestionProductos_Load(object sender, EventArgs e)
        {
            bllProducto = new BLL_Producto();

            dataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            dataGrid.AllowUserToAddRows = false;

            ActualizarGrilla();
            cargarComboBusqueda();
            botonesSeleccionados();
            cargarComboEstado();
            cargarComboCategorias();
        }

        #region actualizar datos
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
        private void cargarComboCategorias()
        {
            BLL_Categoria bllCat = new BLL_Categoria();
            var categorias = bllCat.obtenerCategorias();

            // Filtra la lista para excluir el perfil "Administrador"

            if (categorias.Count > 0)
            {
                comboCategoria.DataSource = categorias;
                comboCategoria.DisplayMember = "descripcion";
                comboCategoria.ValueMember = "idCategoria";
                comboCategoria.SelectedIndex = 0;
            }
        }

        private void ActualizarGrilla()
        {
            dataGrid.Rows.Clear();

            var productos = bllProducto.retornarProductos();

            foreach (var producto in productos)
            {
                dataGrid.Rows.Add(producto.IdProducto, producto.Codigo, producto.Nombre, producto.Descripcion, producto.oCategoria.descripcion, producto.Stock, producto.PrecioCompra, producto.PrecioVenta, producto.Estado ? "Activado" : "Descativado");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow fila in dataGrid.Rows)
            {
                fila.Visible = true;
            }
            cargarComboCategorias();
            cargarComboEstado();
            cargarComboBusqueda();
            ActualizarGrilla();
        }


        #endregion

        #region bucsar
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
        #endregion

        #region manejo de botones
        private void dataGridProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblSeleccionadoEspecifico.Text = "";
            if (dataGrid.RowCount != 0)
            {
                if (dataGrid.SelectedRows.Count > 0)
                {
                    lblSeleccionadoEspecifico.Text = dataGrid.SelectedRows[0].Cells["id"].Value.ToString() + "- " + dataGrid.SelectedRows[0].Cells["nombre"].Value.ToString();
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
            txtCodigo.ReadOnly = false;
            lblSeleccionado.Visible = false;
            lblSeleccionadoEspecifico.Visible = false;
            modoboton = modoBoton.btnAgregar;
            botonesSeleccionados();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dataGrid.RowCount != 0)
            {
                txtCodigo.ReadOnly = true;
                lblSeleccionado.Visible = true;
                lblSeleccionadoEspecifico.Visible = true;
                modoboton = modoBoton.btnModificar;
                botonesSeleccionados();
            }
            else 
            {
                MessageBox.Show("No hay productos a modificar.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGrid.RowCount != 0)
            {
                txtCodigo.ReadOnly = true;
                lblSeleccionado.Visible = true;
                lblSeleccionadoEspecifico.Visible = true;
                modoboton = modoBoton.btnEliminar;
                botonesSeleccionados();
            }
            else
            {
                MessageBox.Show("No hay productos a eliminar.");
            }
        }

        #endregion


        private void agregar()
        {
            if (!String.IsNullOrEmpty(txtCodigo.Text) && !String.IsNullOrEmpty(txtNombre.Text) && !String.IsNullOrEmpty(txtDescripcion.Text) && !String.IsNullOrEmpty(comboCategoria.Text) && !String.IsNullOrEmpty(comboEstado.Text))
            {
                BE_Producto producto = new BE_Producto() {
                    Codigo = txtCodigo.Text,
                    Nombre = txtNombre.Text,
                    Descripcion = txtDescripcion.Text,
                    oCategoria = new BE.Inventario.BE_Categoria() { idCategoria = (int)comboCategoria.SelectedValue, descripcion = comboCategoria.Text },
                    Estado = comboEstado.Text == "Activado" ? true : false,
                    Stock = 0,
                    PrecioCompra = 0,
                    PrecioVenta = 0
                };

                DialogResult result = MessageBox.Show($"¿Desea agregar el producto {producto.Nombre}? \nSe ingresará sin stock y sin precio hasta realizar una compra", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                { 
                    if (bllProducto.crearProducto(producto))
                    {
                        MessageBox.Show("Producto agregado con éxito");
                        ActualizarGrilla();
                    }
                    else
                    {
                        MessageBox.Show("Hubo un problema agregando el producto");
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

                    DialogResult result = MessageBox.Show($"¿Desea eliminar el producto {dataGrid.SelectedRows[0].Cells["nombre"].Value.ToString()}?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        if (bllProducto.eliminarProducto(id))
                        {
                            MessageBox.Show("Producto eliminado con éxito");
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
                    if (!String.IsNullOrEmpty(txtCodigo.Text) && !String.IsNullOrEmpty(txtNombre.Text) && !String.IsNullOrEmpty(txtDescripcion.Text) && !String.IsNullOrEmpty(comboCategoria.Text) && !String.IsNullOrEmpty(comboEstado.Text))
                    {
                        int id = int.Parse(dataGrid.SelectedRows[0].Cells["id"].Value.ToString());

                        DialogResult result = MessageBox.Show($"¿Desea modificar el producto {dataGrid.SelectedRows[0].Cells["nombre"].Value.ToString()}?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            BE_Producto producto = new BE_Producto()
                            {
                                IdProducto = id,
                                Codigo = txtCodigo.Text,
                                Nombre = txtNombre.Text,
                                Descripcion = txtDescripcion.Text,
                                oCategoria = new BE.Inventario.BE_Categoria() { descripcion = comboCategoria.Text },
                                Estado = comboEstado.Text == "Activado" ? true : false,
                                Stock = 0,
                                PrecioCompra = 0,
                                PrecioVenta = 0
                            };

                            if (bllProducto.modificarProducto(producto))
                            {
                                MessageBox.Show("Producto modificado con éxito");
                                ActualizarGrilla();
                            }
                            else
                            {
                                MessageBox.Show("Hubo un problema actualizando el Producto");
                            }

                        }
                    }
                }
            }
        }

        private void btnAceptar_Click_1(object sender, EventArgs e)
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
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtCodigo.Text = "";
            comboCategoria.SelectedIndex = 0;
            comboEstado.SelectedIndex = 0;
        }
    }
}
