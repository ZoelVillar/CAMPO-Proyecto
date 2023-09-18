using BE.Idiomas;
using BE.Permisos;
using BE.Usuarios;
using Microsoft.VisualBasic.ApplicationServices;
using Negocio;
using Negocio.Idiomas;
using Negocio.Usuarios;
using Servicios.Cache;
using Servicios.Idiomas;
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
using Vista.Inventario;
using Vista.Usuarios;
using Vista.Usuarios.Idiomas;

namespace Vista
{
    public partial class Vista_Principal : Form, IObserver
    {
        private static Vista_Principal Vista = new Vista_Principal();

        EncriptarContraseña encript;
        private Button selectedButton = null;
        BLL_Perfil bllPerfil;
        BLL_Permiso bllPermiso;
        List<BE_Permiso> listaPermisos;

        BLL_Idioma bllIdioma;
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

            bllIdioma = new BLL_Idioma();
            actualizarComboIdiomas();

            IdiomasStatic.Observer.AgregarObservador(this);
            cargarPerfiles();
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

        private void actualizarComboIdiomas()
        {
            comboIdiomas.Items.Clear();

            var idiomas = bllIdioma.retornaIdiomas();

            if (idiomas.Count > 0)
            {
                comboIdiomas.DataSource = idiomas;
                comboIdiomas.DisplayMember = "nombre";
                comboIdiomas.ValueMember = "id";
                comboIdiomas.SelectedIndex = 0;
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
            AbrirFormulario<Vista_PrincipalUsuarios>();
        }
        private void btnPerfil_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Vista_Perfil>();
        }

        private void btnGestionAreas_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Vista_GestionarPerfil>();
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Vista_InventarioPrincipal>();
        }
        #endregion

        #region "Funcion que maneja el cambio de colores de los botones"
        private void Button_Click(object sender, EventArgs e)
        {
            // Verifica si hay un botón seleccionado actualmente
            if (selectedButton != null)
            {
                // Restablece el color del botón seleccionado previamente
                selectedButton.BackColor = Color.White;
                selectedButton.ForeColor = Color.FromArgb(64, 64, 64);
            }

            // Obtiene el botón que se ha hecho clic
            Button clickedButton = (Button)sender;

            // Cambia el color del botón seleccionado al color
            clickedButton.BackColor = Color.FromArgb(230, 107, 45);
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

        private void btnGestionIdiomas_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Vista_Idiomas>();
        }

        public void Actualizar()
        {
            MessageBox.Show($"Traducciones {IdiomasStatic.Observer.obtenerIdiomaActual()}");

            //Recorrer los botones -> recorrer traducciones - relacionar
            var idiomaEncontrado = bllIdioma.retornaIdiomas().Find(x => x.nombre == comboIdiomas.Text);
            var traducciones = bllIdioma.retornaTraduccionesIdioma(new BE_Idioma() { id = idiomaEncontrado.id, nombre = idiomaEncontrado.nombre});

            foreach (BE_Traduccion traduccion in traducciones) 
            { 
                foreach(Control control in this.panelBotones.Controls) 
                {
                    if(control.Tag.ToString() == traduccion.tagIdioma.tag) 
                    {
                        if (traduccion.textoTraducido != "-----") 
                        { 
                            control.Text = traduccion.textoTraducido;
                        }
                    }
                }
            }
        }

        private void comboIdiomas_SelectedValueChanged(object sender, EventArgs e)
        {
            IdiomasStatic.Observer.cambiarIdioma(comboIdiomas.Text);
        }
    }
}
