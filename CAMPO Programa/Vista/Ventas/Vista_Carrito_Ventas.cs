using BE.Inventario;
using BE.Venta;
using DocumentFormat.OpenXml.Vml.Spreadsheet;
using Negocio.Bitacora;
using Negocio.Inventario;
using Servicios.Cache;
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

namespace Vista.Ventas
{
    public partial class Vista_Carrito_Ventas : Form, IObserver
    {
        public Vista_Carrito_Ventas()
        {
            InitializeComponent();
        }

        BLL_Producto ProductoManager;
        Vista_Cobrar_Ventas cobrar;
        private void Vista_Carrito_Ventas_Load(object sender, EventArgs e)
        {
            IdiomasStatic.Observer.AgregarObservador(this);
            ProductoManager = new BLL_Producto();
            cargarProductos();

            Actualizar();

        }

        private void cargarProductos()
        {
            var lista = ProductoManager.retornarProductos();

            if (lista.Count > 0)
            {
                foreach (BE_Producto producto in lista)
                {
                    listProductos.Items.Add(producto.Nombre);
                }
            }
        }

        private void btnAceptarProducto_Click(object sender, EventArgs e)
        {
            bool posible = true;
            if (listProductos.Items.Count == 0) { MessageBox.Show("No hay productos para vender"); posible = false; }
            if (listProductos.SelectedItem == null) { MessageBox.Show("Seleccione un producto"); posible = false; }

            if (listProductos.SelectedItem != null && posible)
            {
                if (txtCantidad.Value > 0)
                {
                    var listaTodosProductos = ProductoManager.retornarProductos();
                    string nombreProductoSeleccionado = listProductos.SelectedItem.ToString();
                    int cantidad = Convert.ToInt32(txtCantidad.Value);

                    BE_Producto productoSeleccionado = listaTodosProductos.FirstOrDefault(p => p.Nombre == nombreProductoSeleccionado);

                    BE_DetalleVenta productoAgregado = new BE_DetalleVenta();
                    productoAgregado.oProducto = productoSeleccionado;
                    productoAgregado.precioVenta = productoSeleccionado.PrecioVenta;
                    productoAgregado.cantidad = cantidad;
                    productoAgregado.subTotal = cantidad * productoSeleccionado.PrecioVenta;

                    bool Encontrado = false;
                    if (gridCarrito.RowCount != 0)
                    {
                        foreach (DataGridViewRow row in gridCarrito.Rows)
                        {
                            if (row.Cells["NombreProducto"].Value != null)
                            {
                                if (row.Cells["NombreProducto"].Value.ToString() == productoAgregado.oProducto.Nombre)
                                {
                                    int cantidadExistente = Convert.ToInt32(row.Cells["Cantidad"].Value);
                                    int nuevaCantidad = cantidadExistente + Convert.ToInt32(txtCantidad.Value);

                                    if (nuevaCantidad <= productoSeleccionado.Stock)
                                    {
                                        decimal precio = Convert.ToDecimal(row.Cells["Precio"].Value);
                                        decimal subtotalExistente = cantidadExistente * precio;
                                        decimal nuevoSubtotal = nuevaCantidad * precio;

                                        row.Cells["Cantidad"].Value = nuevaCantidad;
                                        row.Cells["SubTotal"].Value = nuevoSubtotal;
                                        Encontrado = true;

                                        //Borrar el producto del carrito y cambiarlo

                                        BE_DetalleVenta productoEliminar = VentaCache.listaDetalleVenta.FirstOrDefault(p => p.oProducto.Nombre == productoAgregado.oProducto.Nombre);
                                        if (productoEliminar != null) { VentaCache.listaDetalleVenta.Remove(productoEliminar); }

                                        //Agrego el producto
                                        VentaCache.listaDetalleVenta.Add(productoAgregado);
                                    }
                                    else {
                                        txtCantidad.Value = 0;
                                        MessageBox.Show("No hay mas stock");
                                        return;
                                    }
                                }
                            }
                        }
                    }

                    if (!Encontrado)
                    {
                        if (productoAgregado.cantidad <= productoSeleccionado.Stock) //Consulta STOCK
                        {
                            VentaCache.listaDetalleVenta.Add(productoAgregado);
                            gridCarrito.Rows.Add(productoAgregado.oProducto.Nombre, productoAgregado.cantidad, productoAgregado.precioVenta, productoAgregado.subTotal);
                        }
                        else
                        {
                            txtCantidad.Value = 0;
                            MessageBox.Show("No hay mas stock");
                            return;
                        }
                    }

                    decimal total = 0;
                    foreach (BE_DetalleVenta detalleVenta in VentaCache.listaDetalleVenta)
                    {
                        total += detalleVenta.subTotal;
                    }
                    VentaCache.venta.montoTotal = total;    
                    VentaCache.Observer.NotificarObservadores();
                }
                txtCantidad.Value = 0;

            }
        }

        private void btnContinuarVenta_Click(object sender, EventArgs e)
        {
            bool posible = true;
            if (gridCarrito.RowCount < 1) { MessageBox.Show("Complete el carrito"); posible = false; }

            if (Vista_Principal_Ventas.Instancia != null && posible)
            {

                BLL_Bitacora bitacora = new BLL_Bitacora();
                bitacora.registrarBitacoraEvento("Completando datos de venta", this.GetType().Name.Substring("Vista_".Length), 2);
                Vista_Principal_Ventas.Instancia.AbrirFormulario<Vista_DatosVenta_Ventas>();
            }
        }

        private void btnBorrarCarrito_Click(object sender, EventArgs e)
        {
            gridCarrito.Rows.Clear();
            VentaCache.borrarCacheVenta();
            VentaCache.Observer.NotificarObservadores();
        }

        private void btnCobrarVenta_Click(object sender, EventArgs e)
        {
            if (Vista_Principal_Ventas.Instancia != null && VentaCache.venta.numMesa != 0 && VentaCache.venta.oDetalleVenta.Count > 0)
            {

                Vista_Principal_Ventas.Instancia.AbrirFormulario<Vista_Cobrar_Ventas>();
            }
            else
            {
                MessageBox.Show("Debe completar todos los datos de la venta");
            }
        }

        private void txtProductoBuscar_TextChanged(object sender, EventArgs e)
        {
            string textoBusqueda = txtProductoBuscar.Text;
            var lista = ProductoManager.retornarProductos();
            listProductos.Items.Clear();

            foreach (BE_Producto producto in lista)
            {
                if (producto.Nombre.Contains(textoBusqueda))
                {
                    listProductos.Items.Add(producto.Nombre);
                }
            }

        }

        public void Actualizar()
        {
            IdiomasTraduccionServicios idiomasTraduccion = new IdiomasTraduccionServicios();
            idiomasTraduccion.CambiarIdiomaEnFormulario(this);
            idiomasTraduccion.TraducirColumnas(gridCarrito);
        }

    }
}
