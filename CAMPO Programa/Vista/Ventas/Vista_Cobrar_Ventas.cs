using Negocio;
using Servicios.Cache;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista.Ventas
{
    public partial class Vista_Cobrar_Ventas : Form
    {
        public Vista_Cobrar_Ventas()
        {
            InitializeComponent();
        }

        BLL_Venta BLLVenta;
        private void Vista_Cobrar_Ventas_Load(object sender, EventArgs e)
        {
            lblTotalPagar.Text = VentaCache.venta.montoTotal.ToString();
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

            if (BLLVenta.CrearVenta(VentaCache.venta))
            {
                MessageBox.Show("Venta Creada");
                VentaCache.borrarCacheVenta();
                if (Vista_Principal_Ventas.Instancia != null)
                {
                    //Vista_Principal_Ventas.Instancia.AbrirFormulario<Vista_Principal>();
                }
            }
            else
            {
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
            if (numericUpDown1.Value >= VentaCache.venta.montoTotal)
            {
                VentaCache.venta.montoCambio = 0;
                VentaCache.venta.montoPago = VentaCache.venta.montoTotal;

                if (BLLVenta.CrearVenta(VentaCache.venta))
                {
                    MessageBox.Show("Pago con tarjeta realizado");
                    VentaCache.borrarCacheVenta();
                    if (Vista_Principal_Ventas.Instancia != null)
                    {
                        //Vista_Principal_Ventas.Instancia.AbrirFormulario<Vista_Principal>();
                    }
                }
                else
                {
                    MessageBox.Show("Error al crear la venta");
                }
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void btnVolverAtras_Click(object sender, EventArgs e)
        {
            if (Vista_Principal_Ventas.Instancia != null)
            {
                Vista_Principal_Ventas.Instancia.AbrirFormulario<Vista_DatosVenta_Ventas>();
            }
        }
    }
}
