namespace Vista
{
    partial class Vista_GestionarUsuarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelBotonesIzquierdo = new System.Windows.Forms.Panel();
            this.btnDesbloquear = new System.Windows.Forms.Button();
            this.btnBloquear = new System.Windows.Forms.Button();
            this.btnModifUser = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnCrearUsuario = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IDUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDArea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Idioma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bloqueado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.txtNuevoNombre = new System.Windows.Forms.TextBox();
            this.txtNuevaContraseña = new System.Windows.Forms.TextBox();
            this.txtConfirmarContraseña = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNuevaContraseña = new System.Windows.Forms.Label();
            this.lblConfirmarContraseña = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblIdioma = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtError = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDatos = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.panelBotonesIzquierdo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBotonesIzquierdo
            // 
            this.panelBotonesIzquierdo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.panelBotonesIzquierdo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBotonesIzquierdo.Controls.Add(this.btnDesbloquear);
            this.panelBotonesIzquierdo.Controls.Add(this.btnBloquear);
            this.panelBotonesIzquierdo.Controls.Add(this.btnModifUser);
            this.panelBotonesIzquierdo.Controls.Add(this.btnLogout);
            this.panelBotonesIzquierdo.Controls.Add(this.btnCrearUsuario);
            this.panelBotonesIzquierdo.Location = new System.Drawing.Point(0, 0);
            this.panelBotonesIzquierdo.Margin = new System.Windows.Forms.Padding(0);
            this.panelBotonesIzquierdo.Name = "panelBotonesIzquierdo";
            this.panelBotonesIzquierdo.Size = new System.Drawing.Size(181, 684);
            this.panelBotonesIzquierdo.TabIndex = 42;
            // 
            // btnDesbloquear
            // 
            this.btnDesbloquear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDesbloquear.FlatAppearance.BorderSize = 0;
            this.btnDesbloquear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesbloquear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesbloquear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDesbloquear.Location = new System.Drawing.Point(15, 513);
            this.btnDesbloquear.Margin = new System.Windows.Forms.Padding(4);
            this.btnDesbloquear.Name = "btnDesbloquear";
            this.btnDesbloquear.Size = new System.Drawing.Size(149, 39);
            this.btnDesbloquear.TabIndex = 51;
            this.btnDesbloquear.Text = "Bloquear";
            this.btnDesbloquear.UseVisualStyleBackColor = false;
            // 
            // btnBloquear
            // 
            this.btnBloquear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBloquear.FlatAppearance.BorderSize = 0;
            this.btnBloquear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBloquear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBloquear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBloquear.Location = new System.Drawing.Point(15, 559);
            this.btnBloquear.Margin = new System.Windows.Forms.Padding(4);
            this.btnBloquear.Name = "btnBloquear";
            this.btnBloquear.Size = new System.Drawing.Size(149, 39);
            this.btnBloquear.TabIndex = 50;
            this.btnBloquear.Text = "Desbloquear";
            this.btnBloquear.UseVisualStyleBackColor = false;
            // 
            // btnModifUser
            // 
            this.btnModifUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnModifUser.FlatAppearance.BorderSize = 0;
            this.btnModifUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifUser.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnModifUser.Location = new System.Drawing.Point(16, 433);
            this.btnModifUser.Margin = new System.Windows.Forms.Padding(4);
            this.btnModifUser.Name = "btnModifUser";
            this.btnModifUser.Size = new System.Drawing.Size(149, 39);
            this.btnModifUser.TabIndex = 48;
            this.btnModifUser.Text = "ModifUsuario";
            this.btnModifUser.UseVisualStyleBackColor = false;
            this.btnModifUser.Click += new System.EventHandler(this.btnModifUser_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.AutoEllipsis = true;
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(129)))), ((int)(((byte)(48)))));
            this.btnLogout.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(16)))), ((int)(((byte)(48)))));
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(20)))), ((int)(((byte)(57)))));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLogout.Location = new System.Drawing.Point(16, 615);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(0, 0);
            this.btnLogout.TabIndex = 40;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            // 
            // btnCrearUsuario
            // 
            this.btnCrearUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(112)))), ((int)(((byte)(92)))));
            this.btnCrearUsuario.FlatAppearance.BorderSize = 0;
            this.btnCrearUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearUsuario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCrearUsuario.Location = new System.Drawing.Point(16, 386);
            this.btnCrearUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.btnCrearUsuario.Name = "btnCrearUsuario";
            this.btnCrearUsuario.Size = new System.Drawing.Size(149, 39);
            this.btnCrearUsuario.TabIndex = 44;
            this.btnCrearUsuario.Text = "Crear Usuario";
            this.btnCrearUsuario.UseVisualStyleBackColor = false;
            this.btnCrearUsuario.Click += new System.EventHandler(this.btnCrearUsuario_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDUsuario,
            this.IDArea,
            this.NombreUsuario,
            this.Idioma,
            this.Bloqueado});
            this.dataGridView1.Location = new System.Drawing.Point(203, 15);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(953, 351);
            this.dataGridView1.TabIndex = 43;
            // 
            // IDUsuario
            // 
            this.IDUsuario.HeaderText = "ID Usuario";
            this.IDUsuario.MinimumWidth = 8;
            this.IDUsuario.Name = "IDUsuario";
            this.IDUsuario.Width = 150;
            // 
            // IDArea
            // 
            this.IDArea.HeaderText = "ID Area";
            this.IDArea.MinimumWidth = 8;
            this.IDArea.Name = "IDArea";
            this.IDArea.Width = 150;
            // 
            // NombreUsuario
            // 
            this.NombreUsuario.HeaderText = "Nombre Usuario";
            this.NombreUsuario.MinimumWidth = 8;
            this.NombreUsuario.Name = "NombreUsuario";
            this.NombreUsuario.Width = 150;
            // 
            // Idioma
            // 
            this.Idioma.HeaderText = "Idioma";
            this.Idioma.MinimumWidth = 8;
            this.Idioma.Name = "Idioma";
            this.Idioma.Width = 150;
            // 
            // Bloqueado
            // 
            this.Bloqueado.HeaderText = "Bloqueado";
            this.Bloqueado.MinimumWidth = 8;
            this.Bloqueado.Name = "Bloqueado";
            this.Bloqueado.ReadOnly = true;
            this.Bloqueado.Width = 150;
            // 
            // txtNuevoNombre
            // 
            this.txtNuevoNombre.Location = new System.Drawing.Point(19, 150);
            this.txtNuevoNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNuevoNombre.Name = "txtNuevoNombre";
            this.txtNuevoNombre.Size = new System.Drawing.Size(191, 24);
            this.txtNuevoNombre.TabIndex = 45;
            // 
            // txtNuevaContraseña
            // 
            this.txtNuevaContraseña.Location = new System.Drawing.Point(279, 153);
            this.txtNuevaContraseña.Margin = new System.Windows.Forms.Padding(4);
            this.txtNuevaContraseña.Name = "txtNuevaContraseña";
            this.txtNuevaContraseña.Size = new System.Drawing.Size(191, 24);
            this.txtNuevaContraseña.TabIndex = 46;
            // 
            // txtConfirmarContraseña
            // 
            this.txtConfirmarContraseña.Location = new System.Drawing.Point(279, 204);
            this.txtConfirmarContraseña.Margin = new System.Windows.Forms.Padding(4);
            this.txtConfirmarContraseña.Name = "txtConfirmarContraseña";
            this.txtConfirmarContraseña.Size = new System.Drawing.Size(191, 24);
            this.txtConfirmarContraseña.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 130);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 51;
            this.label1.Text = "Nombre";
            // 
            // lblNuevaContraseña
            // 
            this.lblNuevaContraseña.AutoSize = true;
            this.lblNuevaContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevaContraseña.Location = new System.Drawing.Point(275, 131);
            this.lblNuevaContraseña.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNuevaContraseña.Name = "lblNuevaContraseña";
            this.lblNuevaContraseña.Size = new System.Drawing.Size(131, 18);
            this.lblNuevaContraseña.TabIndex = 52;
            this.lblNuevaContraseña.Text = "Nueva Contraseña";
            // 
            // lblConfirmarContraseña
            // 
            this.lblConfirmarContraseña.AutoSize = true;
            this.lblConfirmarContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmarContraseña.Location = new System.Drawing.Point(279, 180);
            this.lblConfirmarContraseña.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConfirmarContraseña.Name = "lblConfirmarContraseña";
            this.lblConfirmarContraseña.Size = new System.Drawing.Size(155, 18);
            this.lblConfirmarContraseña.TabIndex = 53;
            this.lblConfirmarContraseña.Text = "Confirmar Contraseña";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(1172, 24);
            this.menuStrip1.TabIndex = 54;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(533, 153);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(191, 26);
            this.comboBox1.TabIndex = 55;
            // 
            // lblIdioma
            // 
            this.lblIdioma.AutoSize = true;
            this.lblIdioma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdioma.Location = new System.Drawing.Point(529, 130);
            this.lblIdioma.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdioma.Name = "lblIdioma";
            this.lblIdioma.Size = new System.Drawing.Size(112, 18);
            this.lblIdioma.TabIndex = 57;
            this.lblIdioma.Text = "Cambiar Idioma";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.comboBox2);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btnAceptar);
            this.panel2.Controls.Add(this.txtError);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lblDatos);
            this.panel2.Controls.Add(this.txtEmail);
            this.panel2.Controls.Add(this.lblIdioma);
            this.panel2.Controls.Add(this.txtNuevoNombre);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.txtNuevaContraseña);
            this.panel2.Controls.Add(this.lblConfirmarContraseña);
            this.panel2.Controls.Add(this.txtConfirmarContraseña);
            this.panel2.Controls.Add(this.lblNuevaContraseña);
            this.panel2.Controls.Add(this.lblEmail);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(203, 373);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(953, 295);
            this.panel2.TabIndex = 58;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(20, 198);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(191, 24);
            this.textBox1.TabIndex = 62;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 178);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 18);
            this.label3.TabIndex = 63;
            this.label3.Text = "Apellido";
            // 
            // btnAceptar
            // 
            this.btnAceptar.AutoEllipsis = true;
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(129)))), ((int)(((byte)(48)))));
            this.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAceptar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(16)))), ((int)(((byte)(48)))));
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(20)))), ((int)(((byte)(57)))));
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAceptar.Location = new System.Drawing.Point(759, 233);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(173, 43);
            this.btnAceptar.TabIndex = 61;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtError
            // 
            this.txtError.AutoSize = true;
            this.txtError.Font = new System.Drawing.Font("Bodoni MT", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(16)))), ((int)(((byte)(48)))));
            this.txtError.Location = new System.Drawing.Point(17, 256);
            this.txtError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtError.Name = "txtError";
            this.txtError.Size = new System.Drawing.Size(54, 20);
            this.txtError.TabIndex = 60;
            this.txtError.Text = "Error";
            this.txtError.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(196, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 25);
            this.label2.TabIndex = 59;
            this.label2.Text = "- Crear Usuario";
            // 
            // lblDatos
            // 
            this.lblDatos.AutoSize = true;
            this.lblDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatos.Location = new System.Drawing.Point(16, 17);
            this.lblDatos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(153, 25);
            this.lblDatos.TabIndex = 58;
            this.lblDatos.Text = "Ingresar Datos";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(19, 81);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(191, 24);
            this.txtEmail.TabIndex = 44;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(15, 59);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(45, 18);
            this.lblEmail.TabIndex = 50;
            this.lblEmail.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(529, 181);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 18);
            this.label4.TabIndex = 65;
            this.label4.Text = "Rol";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(533, 204);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(191, 26);
            this.comboBox2.TabIndex = 64;
            // 
            // Vista_GestionarUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 677);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panelBotonesIzquierdo);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Vista_GestionarUsuarios";
            this.Text = "Vista_GestionarUsuarios";
            this.Load += new System.EventHandler(this.Vista_GestionarUsuarios_Load);
            this.panelBotonesIzquierdo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelBotonesIzquierdo;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnCrearUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDArea;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Idioma;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Bloqueado;
        private System.Windows.Forms.TextBox txtNuevoNombre;
        private System.Windows.Forms.TextBox txtNuevaContraseña;
        private System.Windows.Forms.TextBox txtConfirmarContraseña;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNuevaContraseña;
        private System.Windows.Forms.Label lblConfirmarContraseña;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblIdioma;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblDatos;
        private System.Windows.Forms.Button btnDesbloquear;
        private System.Windows.Forms.Button btnBloquear;
        private System.Windows.Forms.Button btnModifUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtError;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}