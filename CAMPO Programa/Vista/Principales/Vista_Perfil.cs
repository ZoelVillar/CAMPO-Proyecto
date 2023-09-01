using Negocio;
using Servicios.Cache;
using Servicios.Validaciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE.Usuarios;
using BE;

namespace Vista
{
    public partial class Vista_Perfil : Form
    {
        public Vista_Perfil()
        {
            InitializeComponent();
        }
        ValidarRegex validaciones;
        EncriptarContraseña encriptacion;
        private void Vista_Perfil_Load(object sender, EventArgs e)
        {
            validaciones = new ValidarRegex();
            encriptacion = new EncriptarContraseña();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
           
            if (!String.IsNullOrEmpty(txtContraActual.Text))
            {
                if (!String.IsNullOrEmpty(txtNuevaContra.Text) || !String.IsNullOrEmpty(txtRepetirContra.Text))
                {
                    BLL_User User = new BLL_User();
                    string contraseñaActual = encriptacion.Encriptar(txtContraActual.Text);

                    var userAux = User.retornaUsuario(UserLoginInfo.key_email);

                    if(encriptacion.ValidarContraseñaUsuario(txtContraActual.Text.Trim(), userAux.user_password))
                    {
                        if(txtNuevaContra.Text == txtRepetirContra.Text)
                        {
                            if(validaciones.validarContraseña(txtNuevaContra.Text))
                            {
                                userAux.user_password = encriptacion.Encriptar(txtNuevaContra.Text);
                                User.ActualizarContraseña(userAux);
                                MessageBox.Show("Se actualizó la contraseña");
                                txtContraActual.Text = "";
                                txtNuevaContra.Text = "";
                                txtRepetirContra.Text = "";

                                userAux.user_password = "";
                                UserLoginInfo.user_password = "";

                            }
                            else { MessageBox.Show("La contraseña es insegura"); }
                        }
                        else { MessageBox.Show("Las contraseñas no coinciden"); }
                    }
                    else { MessageBox.Show("Contraseña actual incorrecta"); }
                }
                else { MessageBox.Show("Complete todos los campos"); }
            }
            else { MessageBox.Show("Ingrese la contraseña Actual");}
        }
    }
}
