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
using Servicios.Cache;

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
            AttachButtonClickEvent(panelBotones);

            btnCrearUsuario.BackColor = Color.FromArgb(107, 112, 92);
            selectedButton = btnCrearUsuario;

            validaciones = new ValidarRegex();
            encriptacion = new EncriptarContraseña();
            dataGridUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridUsuarios.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            ActualizarGrilla();
            cargarComboPerfiles();
        }

        private void cargarComboPerfiles()
        {
            BLL_Perfil Perfil = new BLL_Perfil();
            if (Perfil.retornaPerfiles().Count > 0)
            {
                comboPerfiles.DataSource = Perfil.retornaPerfiles();
                comboPerfiles.DisplayMember = "nombre_perfil";
                comboPerfiles.ValueMember = "id_perfil";
                comboPerfiles.SelectedIndex = 0;
            }
        }
        private void ActualizarGrilla()
        {
            dataGridUsuarios.Rows.Clear();
            BLL_User User = new BLL_User();

            var usuarios = User.ObtenerUsuarios();

            foreach (var usuario in usuarios)
            {
                dataGridUsuarios.Rows.Add(usuario.id_perfil, usuario.key_email, usuario.user_name, usuario.user_lastname, usuario.user_blocked, usuario.user_attempts); 
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

        #region "Crear y modificar Usuario"

        #region "switch buttons"
        private enum ModoUsuario
        {
            Crear,
            Modificar
        }

        private ModoUsuario modoUsuario;
            
        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            txtEmail.Text = "";
            btnAceptar.Visible = true;
            txtEmail.Enabled = true;
            labelFunction.Text = "- Crear Usuario";
            modoUsuario = ModoUsuario.Crear;
        }
        private void btnModifUser_Click(object sender, EventArgs e)
        {
            btnAceptar.Visible = true;
            txtEmail.Enabled = false;
            labelFunction.Text = "- Modificar Usuario";
            if (dataGridUsuarios.SelectedRows[0].Cells["Email"].Value != null) { txtEmail.Text = dataGridUsuarios.SelectedRows[0].Cells["Email"].Value.ToString(); }
            else { txtEmail.Text = ""; }
            modoUsuario = ModoUsuario.Modificar;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            switch (modoUsuario)
            {
                case ModoUsuario.Crear:
                    crearUsuario();
                    break;
                case ModoUsuario.Modificar:
                    modificarUsuario();
                    break;
                default:
                    MessageBox.Show("Uh!");
                    crearUsuario();
                    break;
            }
        }

        #endregion

        private void modificarUsuario()
        {
            
            if (dataGridUsuarios.RowCount != 0)
            {
                if (dataGridUsuarios.SelectedRows.Count > 0)
                {
                    BLL_User User = new BLL_User();

                    DataGridViewRow selectedRow = dataGridUsuarios.SelectedRows[0];
                    string email = selectedRow.Cells["Email"].Value.ToString().Trim();


                        if (!String.IsNullOrEmpty(txtNuevoNombre.Text) || !String.IsNullOrEmpty(txtNuevoApellido.Text))
                        {
                          
                                int selectedId = (int)comboPerfiles.SelectedValue;
                                BE_User usuarioAux = new BE_User(email, txtNuevoNombre.Text.Trim(), txtNuevoApellido.Text.Trim(), selectedId);

                                string mensaje = $"Seguro que quieres modificar a {usuarioAux.key_email}, con el nombre: {usuarioAux.user_name}, el apellido: {usuarioAux.user_lastname} y el rol de: {comboPerfiles.SelectedItem.ToString()}?";

                                DialogResult resultado = MessageBox.Show(mensaje, "Confirmar modificación de Usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                                if (resultado == DialogResult.Yes)
                                {
                                    if (User.ModificarUsuario(usuarioAux))
                                    {
                                        MessageBox.Show("Usuario modificado exitosamente!");
                                        txtEmail.Text = "";
                                        txtNuevoApellido.Text = "";
                                        txtNuevoNombre.Text = "";
                                    }
                                    else
                                    {
                                        MessageBox.Show("Hubo un error agregando el usuario");
                                        txtEmail.Text = "";
                                        txtNuevoApellido.Text = "";
                                        txtNuevoNombre.Text = "";
                                    }

                                    ActualizarGrilla();
                                }else{
                                    txtEmail.Text = "";
                                    txtNuevoApellido.Text = "";
                                    txtNuevoNombre.Text = "";
                                }
                        } else{ MessageBox.Show("Complete todos los campos");}

                }else { MessageBox.Show("Seleccione un Usuario"); }
          
            }else {MessageBox.Show("No hay usuarios para modificar"); }
        }

        #region "crearUsuario"

        private void crearUsuario()
        {
            BLL_User User = new BLL_User();

                if (!String.IsNullOrEmpty(txtEmail.Text))
                {
                    if (!String.IsNullOrEmpty(txtNuevoNombre.Text) || !String.IsNullOrEmpty(txtNuevoApellido.Text))
                    {
                        var _email = txtEmail.Text;
                        if (validaciones.validarEmail(_email))
                        {
                            string userPassword = encriptacion.Encriptar(txtNuevoNombre.Text + txtNuevoApellido.Text);
                            int selectedId = (int)comboPerfiles.SelectedValue;
                            BE_User usuario = new BE_User(_email, txtNuevoNombre.Text.Trim(), txtNuevoApellido.Text.Trim(), userPassword, false, 0, selectedId);

                            string mensaje = $"Seguro que quieres crear a {usuario.key_email}, con el nombre: {usuario.user_name}, el apellido: {usuario.user_lastname} y el rol de: {comboPerfiles.SelectedItem.ToString()}?";

                            DialogResult resultado = MessageBox.Show(mensaje, "Confirmar Creación de Usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            if (resultado == DialogResult.Yes)
                            {
                                if (User.CrearUsuario(usuario))
                                {
                                    MessageBox.Show("Usuario Agregado exitosamente!");
                                    txtEmail.Text = "";
                                    txtNuevoApellido.Text = "";
                                    txtNuevoNombre.Text = "";
                                }
                                else
                                {
                                    MessageBox.Show("Hubo un error agregando el usuario");
                                    txtEmail.Text = "";
                                    txtNuevoApellido.Text = "";
                                    txtNuevoNombre.Text = "";
                                }
                                ActualizarGrilla();
                            }
                            else
                            {
                                txtEmail.Text = "";
                                txtNuevoApellido.Text = "";
                                txtNuevoNombre.Text = "";
                            }
                        }
                        else
                        {
                            MessageBox.Show("El email no tiene un formato correcto");
                            txtEmail.Text = "";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Complete todos los campos");
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese la email");
                }


        }
        #endregion

        #endregion

        #region "Bloquear y Desbloquear"
        private void btnBloquear_Click(object sender, EventArgs e)
        {
            bloquearDesbloquear(true);
        }
        private void btnDesbloquear_Click(object sender, EventArgs e)
        {
            bloquearDesbloquear(false);
        }

        private void bloquearDesbloquear(bool condicion)
        {
            btnAceptar.Visible = false;
            if (dataGridUsuarios.RowCount != 0)
            {
                if (dataGridUsuarios.SelectedRows.Count > 0)
                {

                    BLL_User User = new BLL_User();

                    DataGridViewRow selectedRow = dataGridUsuarios.SelectedRows[0];
                    string email = selectedRow.Cells["Email"].Value.ToString();
                        
                    string funcion = condicion == true ? "Bloquear" : "Desbloquear";
                    
                    string mensaje = $"Seguro que quiere {funcion} el usuario {email}?";

                    DialogResult resultado = MessageBox.Show(mensaje, "Confirmar modificación de Usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resultado == DialogResult.Yes)
                    {
                        BE_User userAux = new BE_User(
                                        email,
                                        condicion,
                                        0
                                    );

                        if (User.EditarRestricciones(userAux))
                        {
                            MessageBox.Show("Se modificó el usuario correctamente");
                        }
                        else
                        {
                            MessageBox.Show("No se pudo modificar el usuario");
                        }
                    }
                    
                }
                else
                {
                    MessageBox.Show("Seleccione un Usuario");

                }
            }
            else
            {
                MessageBox.Show("No hay usuarios para modificar");
            }

            ActualizarGrilla();
        }

        #endregion

        private void dataGridUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(modoUsuario == ModoUsuario.Modificar)
            {
                if (dataGridUsuarios.SelectedRows[0].Cells["Email"].Value != null)
                {
                    txtEmail.Text = dataGridUsuarios.SelectedRows[0].Cells["Email"].Value.ToString();
                }else { txtEmail.Text = ""; }
            }
            
        }
    }
}
