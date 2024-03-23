using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Negocio;
using Servicios.Validaciones;
using BE;
using BE.Usuarios;
using Servicios.Cache;
using Servicios.Idiomas;
using Vista.Usuarios.Idiomas;
using Microsoft.VisualBasic.ApplicationServices;
using Negocio.Bitacora;
using Negocio.Servicios;
using Vista.Principales.Administracion;
using Negocio.Idiomas;

namespace Vista
{
    public partial class Vista_Login : Form, IObserver
    {
        EncriptarContraseña encript; 
        public Vista_Login()
        {
            InitializeComponent();
        }

        BLL_Bitacora bitacora;
        BLL_DigitoVerificador bllDigito;
        BLL_Idioma bllIdioma;
        private void Vista_Login_Load(object sender, EventArgs e)
        {
            bitacora = new BLL_Bitacora();
            bllDigito = new BLL_DigitoVerificador();
            bllIdioma = new BLL_Idioma();
            actualizarComboIdiomas();

            IdiomasStatic.Observer.AgregarObservador(this);
            encript = new EncriptarContraseña();
            Actualizar();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool posible = true; string mensaje = "";

            if (string.IsNullOrEmpty(txtUsuario.Text)) { posible = false; mensaje += "Ingrese un mail";  }
            if (string.IsNullOrEmpty(txtContraseña.Text)) { posible = false; mensaje += "\nIngrese una contraseña"; }

           //Comprobar que los campos no estén vacíos
            if (posible)
            {
                BLL_User User = new BLL_User();
                BE_User Usuario = User.retornaUsuario(txtUsuario.Text);
                string hash = encript.Encriptar(txtContraseña.Text);
                
                //Comrpobar usuario y contraseña + que no haya una conexion existente
                if (User.LoginUser(txtUsuario.Text, txtContraseña.Text) && !User.comprobarConexion())
                {
                    //Comprobar que no este bloqueado
                    if (!Usuario.user_blocked)
                    {
                        BE_User userAux = new BE_User()
                        {
                            key_email = Usuario.key_email,
                            user_blocked = false,
                            user_attempts = 0
                        };
                        SessionManager.Login(Usuario);

                        User.EditarRestricciones(userAux);

                        //Verificar DV
                        if (bllDigito.VerificarDigito("Producto") && bllDigito.VerificarDigito("Venta") && bllDigito.VerificarDigito("Users"))
                        {

                            bitacora.registrarBitacoraEvento("Login", this.GetType().Name.Substring("Vista_".Length), 3);

                            Vista_Principal mainMenu = new Vista_Principal();
                            mainMenu.Show();
                            mainMenu.FormClosed += Logout;
                            this.Hide();

                        }
                        else
                        {
                            bitacora.registrarBitacoraEvento("Login fallido, errores de integridad", this.GetType().Name.Substring("Vista_".Length), 1);
                            if (SessionManager.getSession.Usuario.id_perfil == "Administrador")
                            {
                                DialogResult r = MessageBox.Show("Errores de integridad. Abrir panel de control", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                                if (r == DialogResult.No) Application.Exit();
                                else
                                {
                                    Vista_DigitoVerificador vista_DigitoVerificador = new Vista_DigitoVerificador();
                                    vista_DigitoVerificador.Show();
                                    this.Hide();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Error en el sistema, por favor, contacte a un Administrador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }

                    }
                    else { posible = false; mensaje = "Su usuario se encuentra bloqueado"; }
                }
                else 
                {
                    posible = false;
                    mensaje = "La contraseña y usuario no coinciden"; 
                    if (Usuario.key_email != null)
                    {
                        //Si erró 3 veces, se bloquea
                        if (Usuario.user_attempts + 1 >= 3)
                        {
                           BE_User userAux = new BE_User(
                           Usuario.key_email,
                           true,
                           Usuario.user_attempts);

                           if (!User.EditarRestricciones(userAux)) { Console.WriteLine("Error"); }
                            mensaje = "La contraseña y usuario no coinciden, Se bloqueó su Usuario. Comuníquese con un Administrador";
                        }
                        else
                        {
                        //Aumentar el número de intentos
                            BE_User userAux = new BE_User(
                                Usuario.key_email,
                                false,
                                Usuario.user_attempts + 1
                            );

                            if (!User.EditarRestricciones(userAux)) { Console.WriteLine("Error"); }
                            mensaje = $"La contraseña y usuario no coinciden, le quedan {3 - Usuario.user_attempts + 1} intentos.";

                        }
                    }
                }
            }

            if (!posible)
            {
                MessageBox.Show(mensaje);
            }
            
        }

        private void elseUsuarioBloqueado(BE_User Usuario)
        {
            BLL_User User = new BLL_User();

            if (Usuario.user_attempts == 3)
            {
                BE_User userAux = new BE_User(
                    Usuario.key_email,
                    true,
                    Usuario.user_attempts
                );

                if (!User.EditarRestricciones(userAux))
                {
                    Console.WriteLine("Error");
                }
                bitacora.registrarBitacoraEvento("Usuario Bloqueado", this.GetType().Name.Substring("Vista_".Length), 3);

                msgError("Número de intentos alcanzado, se bloqueó el usuario");
            }
            else
            {

                BE_User userAux = new BE_User(
                    Usuario.key_email,
                    false,
                    Usuario.user_attempts + 1
                );

                if (!User.EditarRestricciones(userAux))
                {
                    Console.WriteLine("Error");
                }
                msgError("La contraseña no coincide, se reducen sus intentos");
            }

        }

        private void Logout(object sender, FormClosedEventArgs e)
        {
            txtUsuario.Clear();
            txtContraseña.Clear() ;
            txtError.Visible= false;
            this.Show();
        }

        private void msgError(string error)
        {
            txtError.Text = error;
            txtError.Visible = true;
        }

   

        #region "Salir , minimizar y redimensionar"

        [DllImport("user32.DLL",EntryPoint ="ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg,int wparam, int lparam) ;
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


        private void button1_Click(object sender, EventArgs e) //Btn Cerrar
        {
            if (bitacora.registrarBitacoraEvento("Logout", this.GetType().Name.Substring("Vista_".Length), 3))
            {
                Application.Exit();
            }
            else
            {
                Application.Exit();
            }
            

        }

        private void button4_Click(object sender, EventArgs e) //Btn Minimizar
        {
            this.WindowState= FormWindowState.Minimized;
        }
        #endregion

        private void label4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Comuniquese con su administrador, gracias");
        }

        private void label7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Comuniquese con su administrador, gracias");
        }

        private void btnVerContra_Click(object sender, EventArgs e)
        {
            if (txtContraseña.UseSystemPasswordChar == true) { txtContraseña.UseSystemPasswordChar = false;  } else txtContraseña.UseSystemPasswordChar = true;
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

        public void Actualizar()
        {
            IdiomasTraduccionServicios asd = new IdiomasTraduccionServicios();
            asd.CambiarIdiomaEnFormulario(this);
        }

        private void comboIdiomas_SelectedValueChanged(object sender, EventArgs e)
        {
            IdiomasStatic.Observer.cambiarIdioma(comboIdiomas.Text);
        }
    }
}
