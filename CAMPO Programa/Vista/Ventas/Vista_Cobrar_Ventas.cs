using Negocio;
using Negocio.Bitacora;
using Servicios.Cache;
using Servicios.Idiomas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vista.Usuarios.Idiomas;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.xml;
using System.IO;
using iTextSharp.tool.xml;
using BE.Venta;
using Negocio.Usuarios;
using System.Drawing;
using Negocio.Inventario;

namespace Vista.Ventas
{
    public partial class Vista_Cobrar_Ventas : Form, IObserver
    {
        public Vista_Cobrar_Ventas()
        {
            InitializeComponent();
        }

        BLL_Venta BLLVenta;
        BLL_Producto BLL_Producto;
        BLL_Negocio negocio = new BLL_Negocio();
        private void Vista_Cobrar_Ventas_Load(object sender, EventArgs e)
        {
            VentaCache.Observer.AgregarObservador(this);
            IdiomasStatic.Observer.AgregarObservador(this);
            Actualizar();
            BLLVenta = new BLL_Venta();
            BLL_Producto = new BLL_Producto();
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
                VentaCache.venta.oUsuario = SessionManager.getSession.Usuario;
                VentaCache.venta.montoCambio = numericUpDown1.Value - VentaCache.venta.montoTotal;
                VentaCache.venta.fechaCreacion = DateTime.Now.ToString("ddMMyyyyHHmmss" );
                VentaCache.venta.montoPago = numericUpDown1.Value;
                VentaCache.venta.FormaPago = "Efectivo";

                if (BLLVenta.CrearVenta(VentaCache.venta))
                {
                    BLL_Producto.ActualizarStock(VentaCache.listaDetalleVenta);

                    MessageBox.Show("Venta Creada");
                    generarPDF();

                    BLL_Bitacora bitacora = new BLL_Bitacora();
                    bitacora.registrarBitacoraEvento("Nueva Venta", this.GetType().Name.Substring("Vista_".Length), 1);
                    VentaCache.borrarCacheVenta();
                }
                else
                {

                    BLL_Bitacora bitacora = new BLL_Bitacora();
                    bitacora.registrarBitacoraEvento("Pago Rechazado", this.GetType().Name.Substring("Vista_".Length), 1);
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
            VentaCache.venta.oUsuario = SessionManager.getSession.Usuario;
            VentaCache.venta.montoCambio = 0;
            VentaCache.venta.fechaCreacion = DateTime.Now.ToString("ddMMyyyyHHmmss");
            VentaCache.venta.montoPago = VentaCache.venta.montoTotal;
            VentaCache.venta.FormaPago = "Tarjeta";

            if (BLLVenta.CrearVenta(VentaCache.venta))
            {
                BLL_Producto.ActualizarStock(VentaCache.listaDetalleVenta);

                MessageBox.Show("Pago con tarjeta realizado");
                generarPDF();

                BLL_Bitacora bitacora = new BLL_Bitacora();
                bitacora.registrarBitacoraEvento("Nueva Venta", this.GetType().Name.Substring("Vista_".Length), 1);
                VentaCache.borrarCacheVenta();
            }
            else
            {

                BLL_Bitacora bitacora = new BLL_Bitacora();
                bitacora.registrarBitacoraEvento("Pago Rechazado", this.GetType().Name.Substring("Vista_".Length), 1);
                MessageBox.Show("Error al crear la venta");
            }
            
        }


        private void generarPDF()
        {
            //CREAR ARCHIVO PDF
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.FileName = "Nueva Venta_" + DateTime.Now.ToString("ddMMyyyyHHmmss") + ".pdf";

            string paginaHTML_texto = Properties.Resources.plantilla.ToString();
            paginaHTML_texto = paginaHTML_texto.Replace("@NUMMESA", VentaCache.venta.numMesa.ToString());
            paginaHTML_texto = paginaHTML_texto.Replace("@NOMMESERO", VentaCache.venta.nombreMesero);
            paginaHTML_texto = paginaHTML_texto.Replace("@FECHA", VentaCache.venta.fechaCreacion.ToString());
            paginaHTML_texto = paginaHTML_texto.Replace("@TIPOPEDIDO", VentaCache.venta.tipoPedido);
            paginaHTML_texto = paginaHTML_texto.Replace("@COMENTARIO", VentaCache.venta.comentariosAdicionales);


            string filas = string.Empty;


            foreach (BE_DetalleVenta detalleVenta in VentaCache.listaDetalleVenta)
            {
                filas += "<tr>";
                filas += "<td>" + detalleVenta.cantidad.ToString() + "</td>";
                filas += "<td>" + detalleVenta.oProducto.Nombre + "</td>";
                filas += "<td>" + detalleVenta.oProducto.PrecioVenta + "</td>";
                filas += "<td>" + detalleVenta.subTotal + "</td>";
                filas += "</tr>";

            }

            paginaHTML_texto = paginaHTML_texto.Replace("@FILAS", filas);
            paginaHTML_texto = paginaHTML_texto.Replace("@TOTAL", VentaCache.venta.montoPago.ToString());


            if (dialog.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(dialog.FileName, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);
                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);

                    pdfDoc.Open();

                    pdfDoc.Add(new Phrase(""));


                    bool obtenido = true;
                    byte[] image = new BLL_Negocio().obtenerLogo(out obtenido);
                    if (obtenido && image != null && image.Length > 0)
                    {
                        //iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(ByteToImage(image));
                    }


                    using (StringReader reader = new StringReader(paginaHTML_texto))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, reader);
                    }

                    pdfDoc.Close();
                    stream.Close();
                }

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

        public System.Drawing.Image ByteToImage(byte[] image)
        {
            MemoryStream stream = new MemoryStream();
            stream.Write(image, 0, image.Length);

            System.Drawing.Image image1 = new Bitmap(stream);

            return image1;
        }
    }
}
