using Negocio;
using Negocio.Bitacora;
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
using System.Windows.Forms;
using Vista.Usuarios.Idiomas;

namespace Vista.Ventas
{
    public partial class Vista_Cobrar_Ventas : Form, IObserver
    {
        public Vista_Cobrar_Ventas()
        {
            InitializeComponent();
        }

        BLL_Venta BLLVenta;
        private void Vista_Cobrar_Ventas_Load(object sender, EventArgs e)
        {
            VentaCache.Observer.AgregarObservador(this);
            IdiomasStatic.Observer.AgregarObservador(this);
            Actualizar();
            BLLVenta = new BLL_Venta();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown1.Value >= VentaCache.venta.montoTotal)
            {
                lblCambio.Text = (numericUpDown1.Value - VentaCache.venta.montoTotal).ToString();
            }
            else
            {
                lblCambio.Text = "Dinero insuficiente";
            }
        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value >= VentaCache.venta.montoTotal)
            {
                VentaCache.venta.montoCambio = numericUpDown1.Value - VentaCache.venta.montoTotal;
                VentaCache.venta.montoPago = numericUpDown1.Value;
                VentaCache.venta.FormaPago = "Efectivo";

                if (BLLVenta.CrearVenta(VentaCache.venta))
                {

                    BLL_Bitacora bitacora = new BLL_Bitacora();
                    bitacora.registrarBitacoraEvento("Nueva Venta", this.GetType().Name, 1);
                    MessageBox.Show("Venta Creada");
                    VentaCache.borrarCacheVenta();
                }
                else
                {

                    BLL_Bitacora bitacora = new BLL_Bitacora();
                    bitacora.registrarBitacoraEvento("Pago Rechazado", this.GetType().Name, 1);
                    MessageBox.Show("Error al crear la venta");
                }
            }
            else
            {
                MessageBox.Show("Error");
            }

        }

        private void btnPagarTarjeta_Click(object sender, EventArgs e)
        {
            VentaCache.venta.montoCambio = 0;
            VentaCache.venta.montoPago = VentaCache.venta.montoTotal;
            VentaCache.venta.FormaPago = "Tarjeta";

            if (BLLVenta.CrearVenta(VentaCache.venta))
            {

                BLL_Bitacora bitacora = new BLL_Bitacora();
                bitacora.registrarBitacoraEvento("Nueva Venta", this.GetType().Name, 1);
                MessageBox.Show("Pago con tarjeta realizado");
                VentaCache.borrarCacheVenta();
            }
            else
            {

                BLL_Bitacora bitacora = new BLL_Bitacora();
                bitacora.registrarBitacoraEvento("Pago Rechazado", this.GetType().Name, 1);
                MessageBox.Show("Error al crear la venta");
            }
            
        }

        private void btnVolverAtras_Click(object sender, EventArgs e)
        {
            if (Vista_Principal_Ventas.Instancia != null)
            {
                Vista_Principal_Ventas.Instancia.AbrirFormulario<Vista_Carrito_Ventas>();
            }
        }


        public void Actualizar()
        {
            IdiomasTraduccionServicios idiomasTraduccion = new IdiomasTraduccionServicios();
            idiomasTraduccion.CambiarIdiomaEnFormulario(this);
            lblTotalPagar.Text = VentaCache.venta.montoTotal.ToString();
        }
    }
}
