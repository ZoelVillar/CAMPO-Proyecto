using BE.Usuarios;
using Negocio.Bitacora;
using Negocio.Usuarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using MessageBox = System.Windows.MessageBox;

namespace Vista.Principales
{
    public partial class Vista_Negocio : Form
    {
        public Vista_Negocio()
        {
            InitializeComponent();
        }
        BLL_Negocio bllNegocio;
        BE_Negocio Negocio;
        private void Vista_Negocio_Load(object sender, EventArgs e)
        {
            bllNegocio = new BLL_Negocio();
            Negocio = bllNegocio.retornarNegocio();

            cargarImagen();
            cargarDatos();
        }
        public void cargarDatos()
        {
            txtNombre.Text = Negocio.Nombre;
            txtCUIT.Text = Negocio.CUIT;
            txtDireccion.Text = Negocio.Direccion;
        }

        public void cargarImagen()
        {
            bool obtenido = true;
            byte[] image = new BLL_Negocio().obtenerLogo(out obtenido);
            if (obtenido && image != null && image.Length > 0) { pictureLogo.Image = ByteToImage(image); }
        }
        public Image ByteToImage(byte[] image) 
        { 
            MemoryStream stream = new MemoryStream();
            stream.Write(image, 0, image.Length);

            Image image1 = new Bitmap(stream);

            return image1;
        }

        private void btnCargarLogo_Click(object sender, EventArgs e)
        {
            string mensaje = "";

            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.FileName = "Files|*.jpg;*.jpeg;*.png";

            if(openDialog.ShowDialog() == DialogResult.OK)
            {
                byte[] image = File.ReadAllBytes(openDialog.FileName);
                bool respuesta = bllNegocio.actualizarLogo(image, out mensaje);

                if (respuesta)
                { 
                    pictureLogo.Image = ByteToImage(image); 
                    BLL_Bitacora bitacora = new BLL_Bitacora();
                    bitacora.registrarBitacoraEvento($"Cambios del negocio", this.GetType().Name.Substring("Vista_".Length), 2);
                }
                else { MessageBox.Show(mensaje, "Mensaje", MessageBoxButton.OK); }
               
                
            }
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            BE_Negocio negocio = new BE_Negocio()
            {
                Nombre = txtNombre.Text,
                CUIT = txtCUIT.Text,
                Direccion = txtDireccion.Text
            };

            bool respuesta = bllNegocio.guardarDatos(negocio, out mensaje);

            if (respuesta)
            {
                MessageBox.Show("Los cambios fueron guardados");
                BLL_Bitacora bitacora = new BLL_Bitacora();
                bitacora.registrarBitacoraEvento($"Cambios del negocio", this.GetType().Name.Substring("Vista_".Length), 2);
            }
            else
            {
                MessageBox.Show("No se pudieron actualizar los datos");
            }

        }
    }
}
