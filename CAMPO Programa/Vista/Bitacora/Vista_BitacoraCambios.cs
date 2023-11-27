using BE.Biatcora;
using BE.Usuarios;
using ClosedXML.Excel;
using Negocio;
using Negocio.Bitacora;
using Servicios.Idiomas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using Vista.Usuarios.Idiomas;

namespace Vista.Bitacora
{
    public partial class Vista_BitacoraCambios : Form, IObserver
    {
        public Vista_BitacoraCambios()
        {
            InitializeComponent();
        }

        BLL_Bitacora bllBitacora;
        private void Vista_BitacoraCambios_Load(object sender, EventArgs e)
        {
            bllBitacora = new BLL_Bitacora();

            IdiomasStatic.Observer.AgregarObservador(this);

            dataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            dataGrid.AllowUserToAddRows = false;


            actualizarGrilla();
            cargarComboBusqueda();
        }

        private void actualizarGrilla()
        {

            var bitacora = bllBitacora.retornarBitacoraCambios();
            dataGrid.DataSource = bitacora;
            dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGrid.AutoResizeColumns();

            //foreach (var row in bitacora)
            //{
            //    dataGrid.Rows.Add(
            //        row.IdCambio,
            //        row.IdProducto,
            //        row.Codigo,
            //        row.Nombre, 
            //        row.Descripcion, 
            //        row.IdCategoria,
            //        row.Stock, 
            //        row.PrecioCompra, 
            //        row.PrecioVenta, 
            //        row.Estado,
            //        row.FechaCreado,
            //        row.Activo,
            //        row.DigitoHorizontal,
            //        row.FechaBitacora);
            //}

        }

        private void cargarComboBusqueda()
        {
            comboBuscar.Items.Clear();
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
                        this.dataGrid.CurrentCell = null;
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
                                    row.Cells[5].Value.ToString(),
                                    row.Cells[6].Value.ToString(),
                                    row.Cells[7].Value.ToString(),
                                    row.Cells[8].Value.ToString(),
                                    row.Cells[9].Value.ToString(),
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow fila in dataGrid.Rows)
            {
                fila.Visible = true;
            }
            actualizarGrilla();
            cargarComboBusqueda();
        }
        public void Actualizar()
        {
            IdiomasTraduccionServicios idiomas = new IdiomasTraduccionServicios();
            idiomas.CambiarIdiomaEnFormulario(this);
            idiomas.TraducirColumnas(dataGrid);
        }

        private void btnRestaurarCambio_Click(object sender, EventArgs e)
        {
            BLL_BitacoraCambiosProducto bllcambios = new BLL_BitacoraCambiosProducto();
            BE_BitacoraCambiosProducto bita = dataGrid.SelectedRows[0].DataBoundItem as BE_BitacoraCambiosProducto;
            bllcambios.ActivarCambio(bita);
            actualizarGrilla();
        }
    }
}
