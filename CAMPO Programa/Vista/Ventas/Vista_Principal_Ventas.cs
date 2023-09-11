using BE.Inventario;
using BE.Venta;
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
using Vista.Ventas;

namespace Vista
{
    public partial class Vista_Principal_Ventas : Form
    {
        public Vista_Principal_Ventas()
        {
            InitializeComponent();
        }

        public static Vista_Principal_Ventas Instancia { get; private set; }

        private void Vista_Principal_Ventas_Load(object sender, EventArgs e)
        {
            Instancia = this;
        }

        //abrir form al presionar boton
        public void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = panelFormularios.Controls.OfType<MiForm>().FirstOrDefault(); //Busca en la coleeccion el formulario


            if (formulario == null) // Si el form no existe
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelFormularios.Controls.Add(formulario);
                panelFormularios.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();  
            }
            else // Si el form existe
            {
                formulario.BringToFront();
            }
        }

        private void btnCrearVenta_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Vista_Carrito_Ventas>();
        }

        private void btnVerVentas_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Vista_VerVentas>();
        }
    }
}
