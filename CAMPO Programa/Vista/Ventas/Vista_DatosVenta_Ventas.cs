using BE.Usuarios;
using BE.Venta;
using Negocio.Usuarios;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Vista.Ventas
{
    public partial class Vista_DatosVenta_Ventas : Form, IObserver
    {

        public Vista_DatosVenta_Ventas()
        {
            InitializeComponent();
        }

        BLL_Negocio Negocio;
        string ticketInfo = "";

        private void Vista_DatosVenta_Ventas_Load(object sender, EventArgs e)
        {
            Negocio = new BLL_Negocio();

            VentaCache.Observer.AgregarObservador(this);
            IdiomasStatic.Observer.AgregarObservador(this);
            ctrol_tipoPedido.SelectedIndex = 0;
            previsualizarTicket();
            Actualizar();

        }
        private void btnContinuarVenta_Click(object sender, EventArgs e)
        {

            bool posible = true;
            if (ctrol_numMesa.Value <= 0) { MessageBox.Show("Numero de mesa incorrecto"); posible = false; ctrol_numMesa.Value = 0; }

            if (ctrol_nbreMesero.Text.Trim() == "" || ctrol_nbreMesero.Text == "Nombre Apellido") { MessageBox.Show("Nombre de mesero incompleto"); posible = false; }

            if (posible)
            {
                VentaCache.venta.oUsuario = SessionManager.getSession.Usuario;
                VentaCache.venta.nombreMesero = ctrol_nbreMesero.Text;
                VentaCache.venta.numMesa = Convert.ToInt32(ctrol_numMesa.Value);
                VentaCache.venta.comentariosAdicionales = ctrol_Comentarios.Text;
                VentaCache.venta.tipoPedido = ctrol_tipoPedido.SelectedItem.ToString();
                VentaCache.venta.oDetalleVenta = VentaCache.listaDetalleVenta;
                VentaCache.ticketVenta = ticketInfo;

                if (Vista_Principal_Ventas.Instancia != null)
                {
                    Vista_Principal_Ventas.Instancia.AbrirFormulario<Vista_Carrito_Ventas>();
                }

            }
        }

        #region "visualizar ticket"
        public void previsualizarTicket()
        {
            BE_Negocio beNegocio = Negocio.retornarNegocio();

            ticketInfo = $" {beNegocio.Nombre} \n {beNegocio.Direccion} \n" +
                    "---------------------\n" +
                    "Control del pedido\n" +
                    $"Numero de mesa: {(Convert.ToInt32(ctrol_numMesa.Value)).ToString()}\n " +
                    $"Nombre del mesero: {ctrol_nbreMesero.Text}\n" +
                    $"Tipo De Pedido: {ctrol_tipoPedido.SelectedItem.ToString()}\n" +
                    $"Comentario: {ctrol_Comentarios.Text}\n" +
                    "---------------------\n" +
                    "Fecha: " + DateTime.Now.ToString("yyyy-MM-dd") + "\n" +
                    "Hora: " + DateTime.Now.ToString("HH:mm") + "\n" +
                    "---------------------\n" +
                    "Productos:\n";

            decimal totalVenta = 0;
            foreach (BE_DetalleVenta detalleVenta in VentaCache.listaDetalleVenta)
            {
                ticketInfo += detalleVenta.cantidad + " * " + detalleVenta.oProducto.Nombre + " - $" + detalleVenta.subTotal + "\n";
                totalVenta += detalleVenta.subTotal;
            }

            ticketInfo += "---------------------\n" +
                          "Total: $" + totalVenta;

            txtTicket.Text = ticketInfo;
        }

        private void ctrol_numMesa_ValueChanged(object sender, EventArgs e)
        {
            previsualizarTicket();
        }

        private void ctrol_nbreMesero_TextChanged(object sender, EventArgs e)
        {
            previsualizarTicket();
        }

        private void ctrol_Comentarios_TextChanged(object sender, EventArgs e)
        {
            previsualizarTicket();
        }

        private void ctrol_tipoPedido_SelectedIndexChanged(object sender, EventArgs e)
        {
            previsualizarTicket();
        }

        #endregion


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
            previsualizarTicket();
        }
    }
}
