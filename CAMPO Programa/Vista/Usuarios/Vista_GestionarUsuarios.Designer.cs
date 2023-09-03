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
            this.panelBotones = new System.Windows.Forms.Panel();
            this.btnDesbloquear = new System.Windows.Forms.Button();
            this.btnBloquear = new System.Windows.Forms.Button();
            this.btnModifUser = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnCrearUsuario = new System.Windows.Forms.Button();
            this.IntentosInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bloqueado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Perfil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridUsuarios = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtNuevoNombre = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblDatos = new System.Windows.Forms.Label();
            this.labelFunction = new System.Windows.Forms.Label();
            this.txtError = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNuevoApellido = new System.Windows.Forms.TextBox();
            this.comboPerfiles = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsuarios)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBotones
            // 
            this.panelBotones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(190)))), ((int)(((byte)(169)))));
            this.panelBotones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBotones.Controls.Add(this.btnDesbloquear);
            this.panelBotones.Controls.Add(this.btnBloquear);
            this.panelBotones.Controls.Add(this.btnModifUser);
            this.panelBotones.Controls.Add(this.btnLogout);
            this.panelBotones.Controls.Add(this.btnCrearUsuario);
            this.panelBotones.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelBotones.Location = new System.Drawing.Point(1261, 0);
            this.panelBotones.Margin = new System.Windows.Forms.Padding(0);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new System.Drawing.Size(206, 812);
            this.panelBotones.TabIndex = 42;
            // 
            // btnDesbloquear
            // 
            this.btnDesbloquear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDesbloquear.FlatAppearance.BorderSize = 0;
            this.btnDesbloquear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesbloquear.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDesbloquear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDesbloquear.Location = new System.Drawing.Point(16, 193);
            this.btnDesbloquear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 12);
            this.btnDesbloquear.Name = "btnDesbloquear";
            this.btnDesbloquear.Size = new System.Drawing.Size(173, 49);
            this.btnDesbloquear.TabIndex = 51;
            this.btnDesbloquear.Text = "Desbloquear";
            this.btnDesbloquear.UseVisualStyleBackColor = false;
            this.btnDesbloquear.Click += new System.EventHandler(this.btnDesbloquear_Click);
            // 
            // btnBloquear
            // 
            this.btnBloquear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBloquear.FlatAppearance.BorderSize = 0;
            this.btnBloquear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBloquear.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnBloquear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBloquear.Location = new System.Drawing.Point(17, 258);
            this.btnBloquear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 12);
            this.btnBloquear.Name = "btnBloquear";
            this.btnBloquear.Size = new System.Drawing.Size(173, 49);
            this.btnBloquear.TabIndex = 50;
            this.btnBloquear.Text = "Bloquear";
            this.btnBloquear.UseVisualStyleBackColor = false;
            this.btnBloquear.Click += new System.EventHandler(this.btnBloquear_Click);
            // 
            // btnModifUser
            // 
            this.btnModifUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnModifUser.FlatAppearance.BorderSize = 0;
            this.btnModifUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifUser.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnModifUser.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnModifUser.Location = new System.Drawing.Point(16, 97);
            this.btnModifUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 12);
            this.btnModifUser.Name = "btnModifUser";
            this.btnModifUser.Size = new System.Drawing.Size(173, 49);
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
            this.btnCrearUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCrearUsuario.FlatAppearance.BorderSize = 0;
            this.btnCrearUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearUsuario.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCrearUsuario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCrearUsuario.Location = new System.Drawing.Point(16, 32);
            this.btnCrearUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 12);
            this.btnCrearUsuario.Name = "btnCrearUsuario";
            this.btnCrearUsuario.Size = new System.Drawing.Size(173, 49);
            this.btnCrearUsuario.TabIndex = 44;
            this.btnCrearUsuario.Text = "Crear Usuario";
            this.btnCrearUsuario.UseVisualStyleBackColor = false;
            this.btnCrearUsuario.Click += new System.EventHandler(this.btnCrearUsuario_Click);
            // 
            // IntentosInicio
            // 
            this.IntentosInicio.HeaderText = "Intentos de Inicio";
            this.IntentosInicio.MinimumWidth = 6;
            this.IntentosInicio.Name = "IntentosInicio";
            this.IntentosInicio.Width = 125;
            // 
            // Bloqueado
            // 
            this.Bloqueado.HeaderText = "Bloqueado";
            this.Bloqueado.MinimumWidth = 6;
            this.Bloqueado.Name = "Bloqueado";
            this.Bloqueado.ReadOnly = true;
            this.Bloqueado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Bloqueado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Bloqueado.Width = 125;
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.MinimumWidth = 6;
            this.Apellido.Name = "Apellido";
            this.Apellido.Width = 125;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 125;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.Width = 125;
            // 
            // Perfil
            // 
            this.Perfil.HeaderText = "Perfil";
            this.Perfil.MinimumWidth = 6;
            this.Perfil.Name = "Perfil";
            this.Perfil.Width = 125;
            // 
            // dataGridUsuarios
            // 
            this.dataGridUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Perfil,
            this.Email,
            this.Nombre,
            this.Apellido,
            this.Bloqueado,
            this.IntentosInicio});
            this.dataGridUsuarios.Location = new System.Drawing.Point(56, 33);
            this.dataGridUsuarios.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridUsuarios.Name = "dataGridUsuarios";
            this.dataGridUsuarios.RowHeadersWidth = 62;
            this.dataGridUsuarios.Size = new System.Drawing.Size(1165, 405);
            this.dataGridUsuarios.TabIndex = 43;
            this.dataGridUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridUsuarios_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(392, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 51;
            this.label1.Text = "Nombre";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(95, 70);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(45, 18);
            this.lblEmail.TabIndex = 50;
            this.lblEmail.Text = "Email";
            // 
            // txtNuevoNombre
            // 
            this.txtNuevoNombre.Location = new System.Drawing.Point(396, 92);
            this.txtNuevoNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNuevoNombre.Name = "txtNuevoNombre";
            this.txtNuevoNombre.Size = new System.Drawing.Size(239, 24);
            this.txtNuevoNombre.TabIndex = 45;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(99, 92);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(237, 24);
            this.txtEmail.TabIndex = 44;
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
            // labelFunction
            // 
            this.labelFunction.AutoSize = true;
            this.labelFunction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFunction.Location = new System.Drawing.Point(196, 17);
            this.labelFunction.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFunction.Name = "labelFunction";
            this.labelFunction.Size = new System.Drawing.Size(160, 25);
            this.labelFunction.TabIndex = 59;
            this.labelFunction.Text = "- Crear Usuario";
            // 
            // txtError
            // 
            this.txtError.AutoSize = true;
            this.txtError.Font = new System.Drawing.Font("Bodoni MT", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(16)))), ((int)(((byte)(48)))));
            this.txtError.Location = new System.Drawing.Point(97, 206);
            this.txtError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtError.Name = "txtError";
            this.txtError.Size = new System.Drawing.Size(54, 20);
            this.txtError.TabIndex = 60;
            this.txtError.Text = "Error";
            this.txtError.Visible = false;
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
            this.btnAceptar.Location = new System.Drawing.Point(728, 222);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(192, 43);
            this.btnAceptar.TabIndex = 61;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(392, 134);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 18);
            this.label3.TabIndex = 63;
            this.label3.Text = "Apellido";
            // 
            // txtNuevoApellido
            // 
            this.txtNuevoApellido.Location = new System.Drawing.Point(396, 154);
            this.txtNuevoApellido.Margin = new System.Windows.Forms.Padding(4);
            this.txtNuevoApellido.Name = "txtNuevoApellido";
            this.txtNuevoApellido.Size = new System.Drawing.Size(239, 24);
            this.txtNuevoApellido.TabIndex = 62;
            // 
            // comboPerfiles
            // 
            this.comboPerfiles.FormattingEnabled = true;
            this.comboPerfiles.Location = new System.Drawing.Point(101, 155);
            this.comboPerfiles.Margin = new System.Windows.Forms.Padding(4);
            this.comboPerfiles.Name = "comboPerfiles";
            this.comboPerfiles.Size = new System.Drawing.Size(237, 26);
            this.comboPerfiles.TabIndex = 64;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(97, 135);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 18);
            this.label4.TabIndex = 65;
            this.label4.Text = "Perfil";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.comboPerfiles);
            this.panel2.Controls.Add(this.txtNuevoApellido);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btnAceptar);
            this.panel2.Controls.Add(this.txtError);
            this.panel2.Controls.Add(this.labelFunction);
            this.panel2.Controls.Add(this.lblDatos);
            this.panel2.Controls.Add(this.txtEmail);
            this.panel2.Controls.Add(this.txtNuevoNombre);
            this.panel2.Controls.Add(this.lblEmail);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(157, 471);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(953, 295);
            this.panel2.TabIndex = 58;
            // 
            // Vista_GestionarUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1467, 812);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridUsuarios);
            this.Controls.Add(this.panelBotones);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Vista_GestionarUsuarios";
            this.Text = "Vista_GestionarUsuarios";
            this.Load += new System.EventHandler(this.Vista_GestionarUsuarios_Load);
            this.panelBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsuarios)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBotones;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnCrearUsuario;
        private System.Windows.Forms.Button btnDesbloquear;
        private System.Windows.Forms.Button btnBloquear;
        private System.Windows.Forms.Button btnModifUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn IntentosInicio;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Bloqueado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Perfil;
        private System.Windows.Forms.DataGridView dataGridUsuarios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtNuevoNombre;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblDatos;
        private System.Windows.Forms.Label labelFunction;
        private System.Windows.Forms.Label txtError;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNuevoApellido;
        private System.Windows.Forms.ComboBox comboPerfiles;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
    }
}