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
using BE.Usuarios;
using Servicios.Validaciones;
using Servicios.Cache;
using ClosedXML.Excel;

namespace Vista
{
    public partial class Vista_GestionarUsuarios : Form
    {
        
        Vista_GestionarPerfil perfilForm = new Vista_GestionarPerfil();
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

            perfilForm.PerfilAgregado += actualizarCombo;
            btnCrearUsuario.BackColor = Color.FromArgb(107, 112, 92);
            selectedButton = btnCrearUsuario;

            validaciones = new ValidarRegex();
            encriptacion = new EncriptarContraseña();
            dataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            dataGrid.AllowUserToAddRows = false;
            ActualizarGrilla();
            cargarComboPerfiles();
            cargarComboBusqueda();
        }

        private void cargarComboBusqueda()
        {
            foreach (DataGridViewColumn col in dataGrid.Columns)
            {
                if (col.Visible)
                {
                    comboBuscar.Items.Add(new ComboItem() { Value = col.Name, Text = col.HeaderText });

                }
            }

            if (comboBuscar.Items.Count > 0)
            {
                comboBuscar.SelectedIndex = 0;
            }
        }

        private void cargarComboPerfiles()
        {
            BLL_Perfil Perfil = new BLL_Perfil();
            var perfiles = Perfil.retornaPerfiles();

            // Filtra la lista para excluir el perfil "Administrador"
            var perfilesFiltrados = perfiles.Where(perfil => perfil.id_perfil != "Administrador").ToList();

            if (perfilesFiltrados.Count > 0)
            {
                comboPerfiles.DataSource = perfilesFiltrados;
                comboPerfiles.DisplayMember = "id_perfil";
                comboPerfiles.ValueMember = "id_perfil";
                comboPerfiles.SelectedIndex = 0;
            }
        }
        private void actualizarCombo(object sender, EventArgs e)
        {
            cargarComboPerfiles();
        }


        private void ActualizarGrilla()
        {
            dataGrid.Rows.Clear();
            BLL_User User = new BLL_User();

            var usuarios = User.ObtenerUsuarios();

            foreach (var usuario in usuarios)
            {
                dataGrid.Rows.Add(usuario.id_perfil, usuario.key_email, usuario.user_name, usuario.user_lastname, usuario.user_blocked, usuario.user_attempts); 
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
            if (dataGrid.SelectedRows[0].Cells["Email"].Value != null) { txtEmail.Text = dataGrid.SelectedRows[0].Cells["Email"].Value.ToString(); }
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
            
            if (dataGrid.RowCount != 0)
            {
                if (dataGrid.SelectedRows.Count > 0)
                {
                    BLL_User User = new BLL_User();

                    DataGridViewRow selectedRow = dataGrid.SelectedRows[0];
                    string email = selectedRow.Cells["Email"].Value.ToString().Trim();


                        if (!String.IsNullOrEmpty(txtNuevoNombre.Text) || !String.IsNullOrEmpty(txtNuevoApellido.Text))
                        {
                                BE_User usuarioAux = new BE_User(email, txtNuevoNombre.Text.Trim(), txtNuevoApellido.Text.Trim(), comboPerfiles.SelectedItem.ToString());

                                string mensaje = $"Seguro que quieres modificar a {usuarioAux.key_email}, con el nombre: {usuarioAux.user_name}, el apellido: {usuarioAux.user_lastname} y el rol de: {comboPerfiles.Text}?";

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
                            BE_User usuario = new BE_User(_email, txtNuevoNombre.Text.Trim(), txtNuevoApellido.Text.Trim(), userPassword, false, 0, comboPerfiles.Text);

                            string mensaje = $"Seguro que quieres crear a {usuario.key_email}, con el nombre: {usuario.user_name}, el apellido: {usuario.user_lastname} y el rol de: {comboPerfiles.Text}?";

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
            if (dataGrid.RowCount != 0)
            {
                if (dataGrid.SelectedRows.Count > 0)
                {

                    BLL_User User = new BLL_User();

                    DataGridViewRow selectedRow = dataGrid.SelectedRows[0];
                    string email = selectedRow.Cells["Email"].Value.ToString();
                        
                    string funcion = condicion == true ? "Bloquear" : "Desbloquear";
                    
                    string mensaje = $"¿Seguro que quiere {funcion} el usuario {email}? \nNombre: {selectedRow.Cells["Nombre"].Value.ToString()} \nApellido: {selectedRow.Cells["Apellido"].Value.ToString()}";

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
                if (dataGrid.SelectedRows[0].Cells["Email"].Value != null)
                {
                    txtEmail.Text = dataGrid.SelectedRows[0].Cells["Email"].Value.ToString();
                }else { txtEmail.Text = ""; }
            }
            
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow fila in dataGrid.Rows)
            {
                fila.Visible = true;
            }
            cargarComboPerfiles();
            cargarComboBusqueda();
            ActualizarGrilla();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Obtiene el nombre de la columna seleccionada en el ComboBox.
            string columnaSeleccionada = comboBuscar.SelectedItem.ToString();

            // Obtiene el texto de búsqueda del TextBox.
            string textoBusqueda = txtBuscar.Text;

            // Verifica si la columna seleccionada existe en la grilla.
            if (dataGrid.Columns.Contains(columnaSeleccionada))
            {
                // Itera a través de las filas de la grilla.
                foreach (DataGridViewRow fila in dataGrid.Rows)
                {
                    // Obtiene el valor de la celda en la columna seleccionada.
                    string valorCelda = fila.Cells[columnaSeleccionada].Value?.ToString();

                    // Compara el valor de la celda con el texto de búsqueda, ignorando mayúsculas y minúsculas.
                    if (!string.IsNullOrEmpty(valorCelda) && valorCelda.IndexOf(textoBusqueda, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        // Si se encuentra una coincidencia, muestra la fila en la grilla.
                        fila.Visible = true;
                    }
                    else
                    {
                        // Si no hay coincidencia, oculta la fila en la grilla.
                        fila.Visible = false;
                    }
                }
            }
            else
            {
                // La columna seleccionada no existe en la grilla.
                MessageBox.Show("La columna seleccionada no existe en la grilla.");
            }
        }

        private void btnBorrarBusqueda_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow fila in dataGrid.Rows)
            {
                fila.Visible = true;
            }

            txtBuscar.Text = "";
            dataGrid.Text = string.Empty;
        }

        private void btnBorrarIngresoDatos_Click(object sender, EventArgs e)
        {
            txtEmail.Text = "";
            txtNuevoNombre.Text = "";
            txtNuevoApellido.Text = "";
            if (comboPerfiles.Items.Count > 0)
            {
                comboPerfiles.SelectedIndex = 0;
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGrid.Rows.Count > 0)
                {
                    DataTable dt = new DataTable();

                    foreach (DataGridViewColumn column in dataGrid.Columns)
                    {
                        if (column.HeaderText != "" && column.Visible)
                        {
                            dt.Columns.Add(column.HeaderText, typeof(string));
                        }
                    }

                    foreach (DataGridViewRow row in dataGrid.Rows)
                    {
                        if (row.Visible)
                        {
                            object[] values = new object[dataGrid.Columns.Count];

                            for (int i = 0; i < dataGrid.Columns.Count; i++)
                            {
                                values[i] = row.Cells[i].Value;
                            }

                            dt.Rows.Add(values);

                        }
                    }
                    string nombreProyecto = this.GetType().Name;
                    if (nombreProyecto.StartsWith("Vista_"))
                    {
                        nombreProyecto = nombreProyecto.Substring("Vista_".Length);
                    }

                    SaveFileDialog savefile = new SaveFileDialog();
                    savefile.FileName = string.Format($"{nombreProyecto}_{DateTime.Now.ToString("ddMMyyyyHHmm")}.xlsx");
                    savefile.Filter = "Excel Files | *.xlsx";

                    if (savefile.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            XLWorkbook xLWorkbook = new XLWorkbook();
                            var hoja = xLWorkbook.Worksheets.Add(dt, "Reporte");
                            hoja.ColumnsUsed().AdjustToContents();
                            xLWorkbook.SaveAs(savefile.FileName);
                            MessageBox.Show("Reporte Generado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch
                        {
                            MessageBox.Show("Error generando el reporte", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No hay datos para descargar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un error inesperado");
            }
        }
    }
}
