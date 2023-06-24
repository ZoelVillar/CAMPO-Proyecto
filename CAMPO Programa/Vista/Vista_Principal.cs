using Servicios.Cache;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class Vista_Principal : Form
    {
        private static Vista_Principal Vista = new Vista_Principal();
        
        private Button selectedButton = null;
        public Vista_Principal()
        {
            InitializeComponent();
        }
        private void Vista_Principal_Load(object sender, EventArgs e)
        {
            LoadUserData();
            AttachButtonClickEvent(panelBotones);
        }

        private void AttachButtonClickEvent(Panel panel)
        {
            foreach (Control control in panel.Controls)
            {
                if (control is Button button && button.Visible)
                {
                    button.Click -= Button_Click;
                    button.Click += Button_Click;
                }
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

            respuestaToolbox(false);
        }

        private void button1_Click(object sender, EventArgs e) //Btn Cerrar
        {
            respuestaToolbox(true);
        }

        public void respuestaToolbox(bool salirAplicacion)
        {
            Vista_ToolBox toolbox = new Vista_ToolBox();
            toolbox.ShowDialog();

            if (toolbox.respuesta == true)
            {
                if (salirAplicacion)
                {
                    Application.Exit();
                }
                else
                { 
                    this.Close();
                }
            }
        }

        private void AbrirFormulario<MiForm>() where MiForm : Form, new(){
            Form formulario;
            formulario = panelFormularios.Controls.OfType<MiForm>().FirstOrDefault(); //Busca en la coleeccion el formulario


            if (formulario == null) // Si el form no existe
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle= FormBorderStyle.None;
                formulario.Dock= DockStyle.Fill;
                panelFormularios.Controls.Add(formulario);
                panelFormularios.Tag= formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            else // Si el form existe
            {
                formulario.BringToFront();
            }
        }

        #region "Salir , minimizar y redimensionar"

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel4_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label1_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        private void btnAbrirVentas_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Vista_Principal_Ventas>();
        }

        private void btnAbrirCompras_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Vista_Principal_Compras>();
        }

        private void btnGestionUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Vista_GestionarUsuarios>();
        }

        /*Funcion que maneja el cambio de colores de los botones*/
        private void Button_Click(object sender, EventArgs e)
        {
            // Verifica si hay un botón seleccionado actualmente
            if (selectedButton != null)
            {
                // Restablece el color del botón seleccionado previamente
                selectedButton.BackColor = Color.FromArgb(237, 237, 233);
                selectedButton.ForeColor = Color.FromArgb(64, 64, 64);
            }

            // Obtiene el botón que se ha hecho clic
            Button clickedButton = (Button)sender;

            // Cambia el color del botón seleccionado al color
            clickedButton.BackColor = Color.FromArgb(107, 112, 92);
            clickedButton.ForeColor = Color.White;

            // Actualiza el botón seleccionado
            selectedButton = clickedButton;
        }

        private void LoadUserData()
        {
            lblNombre.Text = UserLoginInfo.name_user;
            lblArea.Text = UserLoginInfo.id_area;
        }

    }
}
