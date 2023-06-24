using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE;
using Servicios.Validaciones;

namespace Vista
{
    public partial class Vista_GestionarUsuarios : Form
    {
        public Vista_GestionarUsuarios()
        {
            InitializeComponent();
        }

        ValidarRegex validaciones;
        EncriptarContraseña encriptacion;
        private Button selectedButton = null;

        private void Vista_GestionarUsuarios_Load(object sender, EventArgs e)
        {

            AttachButtonClickEvent(panelBotonesIzquierdo);

            btnCrearUsuario.BackColor = Color.FromArgb(107, 112, 92);
            selectedButton = btnCrearUsuario;

            validaciones = new ValidarRegex();
            encriptacion = new EncriptarContraseña();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            ActualizarGrilla();
        }
        private void ActualizarGrilla()
        {
            dataGridView1.Rows.Clear();
            BLL_User User = new BLL_User();

            var usuarios = User.ObtenerUsuarios();

            foreach (var usuario in usuarios)
            {
                dataGridView1.Rows.Add(usuario.id_employee, usuario.id_area, usuario.name_user, usuario.language_user, usuario.blocked_user); 
            }
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

        /*Funcion que maneja el cambio de colores de los botones*/
        private void Button_Click(object sender, EventArgs e)
        {
            // Verifica si hay un botón seleccionado actualmente
            if (selectedButton != null)
            {
                // Restablece el color del botón seleccionado previamente
                selectedButton.BackColor = Color.FromArgb(64, 64, 64);
            }

            // Obtiene el botón que se ha hecho clic
            Button clickedButton = (Button)sender;
            
            // Cambia el color del botón seleccionado al color naranja
            clickedButton.BackColor = Color.FromArgb(107, 112, 92);

            // Actualiza el botón seleccionado
            selectedButton = clickedButton;
        }

        //
        private void btnModifUser_Click(object sender, EventArgs e)
        {
        }
        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (lblEmail.Visible == false)
            {
                crearUsuario();
            }
        }

        //private void modificarUsuario()
        //{
        //    BLL_User User = new BLL_User();

        //    if (txtNmbrUser.Text != "" || txtNmbrUser.Text != " ")
        //    {
        //        if (txtNuevaContraseña.Text != "" || txtNuevaContraseña.Text != " ")
        //        {
        //            if (txtConfirmarContraseña.Text != "" || txtConfirmarContraseña.Text != " ")
        //            {

        //                if(User.userExist(txtNmbrUser.Text))
        //                {
        //                    BE_User AuxUsuario = User.retornaUsuario(txtNmbrUser.Text);
        //                }

        //                var _nombre = txtNuevoNombre.Text;
        //                if (validaciones.validarUserName(_nombre))
        //                {
        //                    var _contraseña = txtNuevaContraseña.Text;
        //                    var _ConfirmContra = txtConfirmarContraseña.Text;

        //                    if (validaciones.validarContraseña(_contraseña))
        //                    {
        //                        if (_contraseña == _ConfirmContra)
        //                        {
        //                            string contraseña = encriptacion.Encriptar(_contraseña);
        //                            BE_User usuario = new BE_User(_nombre, "AA001", _nombre, contraseña, "ESP", false);

        //                            if (User.CrearUsuario(usuario))
        //                            {
        //                                MessageBox.Show("Usuario Agregado exitosamenter");
        //                            }
        //                            else
        //                            {
        //                                MessageBox.Show("Hubo un error agregando el usuario");
        //                            }
        //                            ActualizarGrilla();
        //                        }
        //                        MessageBox.Show("Las contraseñas no coinciden");
        //                    }
        //                    else
        //                    {
        //                        MessageBox.Show("La contraseña no cumple las normas");
        //                        txtNmbrUser.Text = "";
        //                        txtNuevaContraseña.Text = "";
        //                        txtConfirmarContraseña.Text = "";
        //                    }
        //                }
        //                else
        //                {
        //                    MessageBox.Show("El nombre de usuario no cumple las normas");
        //                    txtNmbrUser.Text = "";
        //                    txtNuevaContraseña.Text = "";
        //                    txtConfirmarContraseña.Text = "";
        //                }
        //            }
        //            else
        //            {
        //                MessageBox.Show("Ingrese la contraseña");
        //            }
        //        }
        //        else
        //        {
        //            MessageBox.Show("Ingrese la contraseña");
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Ingrese el Nombre de Usuario");
        //    }
        //}
        private void crearUsuario()
        {
            BLL_User User = new BLL_User();

                if (txtNuevaContraseña.Text != "" || txtNuevaContraseña.Text != " ")
                {
                    if (txtConfirmarContraseña.Text != "" || txtConfirmarContraseña.Text != " ")
                    {
                        var _nombre = txtNuevoNombre.Text;
                        if (validaciones.validarUserName(_nombre))
                        {
                            var _contraseña = txtNuevaContraseña.Text;
                            var _ConfirmContra = txtConfirmarContraseña.Text;

                            if (validaciones.validarContraseña(_contraseña))
                            {
                                if (_contraseña == _ConfirmContra)
                                {
                                    string contraseña = encriptacion.Encriptar(_contraseña);
                                    BE_User usuario = new BE_User(_nombre, "AA001", _nombre, contraseña, "ESP", false);
                                    
                                    if(User.CrearUsuario(usuario))
                                    {
                                        MessageBox.Show("Usuario Agregado exitosamenter");
                                    }
                                    else
                                    {
                                        MessageBox.Show("Hubo un error agregando el usuario");
                                    }

                                    ActualizarGrilla();
                                }
                                MessageBox.Show("Las contraseñas no coinciden");

                            }
                            else
                            {
                                MessageBox.Show("La contraseña no cumple las normas");
                                txtEmail.Text = "";
                                txtNuevaContraseña.Text = "";
                                txtConfirmarContraseña.Text = "";
                            }
                        }
                        else
                        {
                            MessageBox.Show("El nombre de usuario no cumple las normas");
                            txtEmail.Text = "";
                            txtNuevaContraseña.Text = "";
                            txtConfirmarContraseña.Text = "";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ingrese la contraseña");
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese la contraseña");
                }


        }

    }
}
