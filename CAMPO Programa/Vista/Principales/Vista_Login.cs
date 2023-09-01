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

namespace Vista
{
    public partial class Vista_Login : Form
    {
        EncriptarContraseña encript; 
        public Vista_Login()
        {
            InitializeComponent();
        }
        private void Vista_Login_Load(object sender, EventArgs e)
        {
            encript = new EncriptarContraseña();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {     
            if (txtUsuario.Text != "" && txtUsuario.Text != " ")
            {
                if (txtContraseña.Text != "" && txtContraseña.Text != " ")
                {
                    if(txtUsuario.Text != UserLoginInfo.user_name)
                    {
                        BLL_User User = new BLL_User();
                        string hash = encript.Encriptar(txtContraseña.Text);
                        var ValidLogin = User.LoginUser(txtUsuario.Text);

                        if (ValidLogin == true)
                        {
                            if (!User.comprobarConexion())
                            {
                                if (!UserLoginInfo.user_blocked)
                                {
                                    if (encript.Validar(txtContraseña.Text))
                                    {
                                        BE_User userAux = new BE_User(
                                                UserLoginInfo.key_email,
                                                false,
                                                0
                                            );

                                        if (!User.EditarRestricciones(userAux))
                                        {
                                            Console.WriteLine("Error");
                                        }

                                        Vista_Principal mainMenu = new Vista_Principal();
                                        mainMenu.Show();
                                        mainMenu.FormClosed += Logout;
                                        this.Hide();

                                        UserLoginInfo.user_password = "";

                                    }
                                    else
                                    {
                                        if (UserLoginInfo.user_attempts == 3)
                                        {
                                            BE_User userAux = new BE_User(
                                                UserLoginInfo.key_email,
                                                true,
                                                UserLoginInfo.user_attempts
                                            );

                                            if (!User.EditarRestricciones(userAux))
                                            {
                                                Console.WriteLine("Error");
                                            }
                                            msgError("Número de intentos alcanzado, se bloqueó el usuario");
                                        }
                                        else
                                        {

                                            BE_User userAux = new BE_User(
                                                UserLoginInfo.key_email,
                                                false,
                                                UserLoginInfo.user_attempts + 1
                                            );

                                            if (!User.EditarRestricciones(userAux))
                                            {
                                                Console.WriteLine("Error");
                                            }
                                            msgError("La contraseña no coincide, se reducen sus intentos");
                                        }

                                        UserLoginInfo.ClearCache();
                                        txtContraseña.Clear();
                                        txtUsuario.Clear();
                                    }
                                }

                            }
                            else
                            {
                                UserLoginInfo.ClearCache();
                                msgError("Su usuario se encuentra bloqueado, comuníquese con un administrador");
                                txtContraseña.Clear();
                                txtUsuario.Clear();
                            
                            }
                            
                        }
                        else {
                            msgError("Error con sus Credenciales");
                            txtContraseña.Clear();
                            txtUsuario.Clear();
                        }
                    
                    }
                    else
                    {
                        msgError("Error con sus Credenciales");
                        txtContraseña.Clear();
                        txtUsuario.Clear();
                    }   
                }
                else { msgError("Ingrese una Contraseña"); }
            }
            else { msgError("Ingrese un Usuario"); }

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
            Application.Exit();
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
    }
}
