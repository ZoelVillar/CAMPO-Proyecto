using BE.Permisos;
using BE.Usuarios;
using Microsoft.VisualBasic.ApplicationServices;
using Negocio;
using Negocio.Usuarios;
using Servicios.Cache;
using Servicios.Validaciones;
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

        EncriptarContraseña encript;
        private Button selectedButton = null;
        BLL_Perfil bllPerfil;
        BLL_Permiso bllPermiso;
        List<BE_Permiso> listaPermisos;
        public Vista_Principal()
        {
            InitializeComponent();
        }
        private void Vista_Principal_Load(object sender, EventArgs e)
        {
            encript = new EncriptarContraseña();
            listaPermisos = new List<BE_Permiso>();
            bllPerfil = new BLL_Perfil();
            bllPermiso = new BLL_Permiso();
            //cargarPerfiles();
            LoadUserData();
            AttachButtonClickEvent(panelBotones);
            consultarCambiarContraseña();
        }

        public void consultarCambiarContraseña()
        {
            BLL_User User = new BLL_User();
            var primerContraseña = UserLoginInfo.user_name.Trim() + UserLoginInfo.user_lastname.Trim();

            var userAux = User.retornaUsuario(UserLoginInfo.key_email);

            if (encript.ValidarContraseñaUsuario(primerContraseña, userAux.user_password))
            {
                MessageBox.Show("Por favor cambie la contraseña ingresando a su perfil");
            }
        }

        #region "salir"
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
        #endregion


        //abrir form al presionar boton
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

        private void LoadUserData()
        {
            lblNombre.Text = UserLoginInfo.user_name + " " + UserLoginInfo.user_lastname;
            lblArea.Text = UserLoginInfo.id_perfil;
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

        #region "Abrir Formularios"
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
        private void btnPerfil_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Vista_Perfil>();
        }

        private void btnGestionAreas_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Vista_GestionarPerfil>();
        }
        #endregion

        #region "Funcion que maneja el cambio de colores de los botones"
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


        #endregion

        private void cargarPerfiles()
        {
            if(UserLoginInfo.id_perfil != "Administrador")
            {
                List <BE_Perfil> perfiles = bllPerfil.retornaPerfiles();
                List<BE_Permiso> permisos = bllPermiso.ObtenerTodosPermisos();
                BE_Perfil perfil = perfiles.Find(x => x.id_perfil == UserLoginInfo.id_perfil);

                foreach(Control control in this.panelBotones.Controls)
                {
                    if(control is Button)
                    {
                        if(!permisos.Find(x => x.idPermiso == perfil.FK_PermisoPerfil.idPermiso).RetornarPermisos().Exists(x => x.idPermiso == control.Tag.ToString()))
                        {
                            control.Visible = false;
                        }
                    }
                }
            }
        }
    }
}
