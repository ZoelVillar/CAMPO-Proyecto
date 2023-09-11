namespace Vista
{
    partial class Vista_Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vista_Principal));
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panelFormularios = new System.Windows.Forms.Panel();
            this.panelDerecho = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblPerfil = new System.Windows.Forms.Label();
            this.panelBotones = new System.Windows.Forms.Panel();
            this.btnInventario = new System.Windows.Forms.Button();
            this.btnGestionProductos = new System.Windows.Forms.Button();
            this.btnGestionIdiomas = new System.Windows.Forms.Button();
            this.btnPerfil = new System.Windows.Forms.Button();
            this.btnGestionUsuarios = new System.Windows.Forms.Button();
            this.btnAbrirVentas = new System.Windows.Forms.Button();
            this.btnAbrirCompras = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.comboIdiomas = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panelContenedor.SuspendLayout();
            this.panelDerecho.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContenedor
            // 
            this.panelContenedor.Controls.Add(this.panelFormularios);
            this.panelContenedor.Controls.Add(this.panelDerecho);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 60);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1320, 660);
            this.panelContenedor.TabIndex = 41;
            // 
            // panelFormularios
            // 
            this.panelFormularios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(228)))));
            this.panelFormularios.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelFormularios.BackgroundImage")));
            this.panelFormularios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelFormularios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormularios.Location = new System.Drawing.Point(0, 0);
            this.panelFormularios.Margin = new System.Windows.Forms.Padding(0);
            this.panelFormularios.Name = "panelFormularios";
            this.panelFormularios.Size = new System.Drawing.Size(1100, 660);
            this.panelFormularios.TabIndex = 42;
            // 
            // panelDerecho
            // 
            this.panelDerecho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(228)))));
            this.panelDerecho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDerecho.Controls.Add(this.panel3);
            this.panelDerecho.Controls.Add(this.panelBotones);
            this.panelDerecho.Controls.Add(this.pictureBox1);
            this.panelDerecho.Controls.Add(this.btnLogout);
            this.panelDerecho.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelDerecho.Location = new System.Drawing.Point(1100, 0);
            this.panelDerecho.Margin = new System.Windows.Forms.Padding(0);
            this.panelDerecho.Name = "panelDerecho";
            this.panelDerecho.Size = new System.Drawing.Size(220, 660);
            this.panelDerecho.TabIndex = 41;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(44)))), ((int)(((byte)(36)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.lblArea);
            this.panel3.Controls.Add(this.lblNombre);
            this.panel3.Controls.Add(this.lblPerfil);
            this.panel3.Location = new System.Drawing.Point(8, 86);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(203, 51);
            this.panel3.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 19);
            this.label2.TabIndex = 47;
            this.label2.Text = "Usuario:";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.ForeColor = System.Drawing.Color.White;
            this.lblArea.Location = new System.Drawing.Point(83, 27);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(13, 16);
            this.lblArea.TabIndex = 40;
            this.lblArea.Text = "a";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(82, 11);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(14, 16);
            this.lblNombre.TabIndex = 45;
            this.lblNombre.Text = "b";
            // 
            // lblPerfil
            // 
            this.lblPerfil.AutoSize = true;
            this.lblPerfil.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblPerfil.ForeColor = System.Drawing.Color.White;
            this.lblPerfil.Location = new System.Drawing.Point(7, 24);
            this.lblPerfil.Name = "lblPerfil";
            this.lblPerfil.Size = new System.Drawing.Size(49, 19);
            this.lblPerfil.TabIndex = 46;
            this.lblPerfil.Text = "Perfil:";
            // 
            // panelBotones
            // 
            this.panelBotones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(44)))), ((int)(((byte)(36)))));
            this.panelBotones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBotones.Controls.Add(this.btnInventario);
            this.panelBotones.Controls.Add(this.btnGestionProductos);
            this.panelBotones.Controls.Add(this.btnGestionIdiomas);
            this.panelBotones.Controls.Add(this.btnPerfil);
            this.panelBotones.Controls.Add(this.btnGestionUsuarios);
            this.panelBotones.Controls.Add(this.btnAbrirVentas);
            this.panelBotones.Controls.Add(this.btnAbrirCompras);
            this.panelBotones.Location = new System.Drawing.Point(8, 143);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new System.Drawing.Size(203, 431);
            this.panelBotones.TabIndex = 0;
            // 
            // btnInventario
            // 
            this.btnInventario.AutoEllipsis = true;
            this.btnInventario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(233)))));
            this.btnInventario.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnInventario.FlatAppearance.BorderSize = 0;
            this.btnInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventario.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnInventario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnInventario.Location = new System.Drawing.Point(11, 260);
            this.btnInventario.Margin = new System.Windows.Forms.Padding(3, 3, 3, 12);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(177, 35);
            this.btnInventario.TabIndex = 50;
            this.btnInventario.Tag = "btnInventario";
            this.btnInventario.Text = "Inventario";
            this.btnInventario.UseVisualStyleBackColor = false;
            this.btnInventario.Click += new System.EventHandler(this.btnInventario_Click);
            // 
            // btnGestionProductos
            // 
            this.btnGestionProductos.AutoEllipsis = true;
            this.btnGestionProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(233)))));
            this.btnGestionProductos.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGestionProductos.FlatAppearance.BorderSize = 0;
            this.btnGestionProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionProductos.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnGestionProductos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGestionProductos.Location = new System.Drawing.Point(10, 110);
            this.btnGestionProductos.Margin = new System.Windows.Forms.Padding(3, 3, 3, 12);
            this.btnGestionProductos.Name = "btnGestionProductos";
            this.btnGestionProductos.Size = new System.Drawing.Size(177, 35);
            this.btnGestionProductos.TabIndex = 49;
            this.btnGestionProductos.Tag = "btnProductos";
            this.btnGestionProductos.Text = "Gestión de Productos";
            this.btnGestionProductos.UseVisualStyleBackColor = false;
            // 
            // btnGestionIdiomas
            // 
            this.btnGestionIdiomas.AutoEllipsis = true;
            this.btnGestionIdiomas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(233)))));
            this.btnGestionIdiomas.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGestionIdiomas.FlatAppearance.BorderSize = 0;
            this.btnGestionIdiomas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionIdiomas.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnGestionIdiomas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGestionIdiomas.Location = new System.Drawing.Point(10, 210);
            this.btnGestionIdiomas.Margin = new System.Windows.Forms.Padding(3, 3, 3, 12);
            this.btnGestionIdiomas.Name = "btnGestionIdiomas";
            this.btnGestionIdiomas.Size = new System.Drawing.Size(177, 35);
            this.btnGestionIdiomas.TabIndex = 48;
            this.btnGestionIdiomas.Tag = "btnIdiomas";
            this.btnGestionIdiomas.Text = "Gestión de Idiomas";
            this.btnGestionIdiomas.UseVisualStyleBackColor = false;
            this.btnGestionIdiomas.Click += new System.EventHandler(this.btnGestionIdiomas_Click);
            // 
            // btnPerfil
            // 
            this.btnPerfil.AutoEllipsis = true;
            this.btnPerfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(233)))));
            this.btnPerfil.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnPerfil.FlatAppearance.BorderSize = 0;
            this.btnPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerfil.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerfil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPerfil.Location = new System.Drawing.Point(10, 382);
            this.btnPerfil.Margin = new System.Windows.Forms.Padding(3, 3, 3, 12);
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.Size = new System.Drawing.Size(177, 35);
            this.btnPerfil.TabIndex = 46;
            this.btnPerfil.Tag = "btnPerfil";
            this.btnPerfil.Text = "Perfil";
            this.btnPerfil.UseVisualStyleBackColor = false;
            this.btnPerfil.Click += new System.EventHandler(this.btnPerfil_Click);
            // 
            // btnGestionUsuarios
            // 
            this.btnGestionUsuarios.AutoEllipsis = true;
            this.btnGestionUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(233)))));
            this.btnGestionUsuarios.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGestionUsuarios.FlatAppearance.BorderSize = 0;
            this.btnGestionUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionUsuarios.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnGestionUsuarios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGestionUsuarios.Location = new System.Drawing.Point(10, 160);
            this.btnGestionUsuarios.Margin = new System.Windows.Forms.Padding(3, 3, 3, 12);
            this.btnGestionUsuarios.Name = "btnGestionUsuarios";
            this.btnGestionUsuarios.Size = new System.Drawing.Size(177, 35);
            this.btnGestionUsuarios.TabIndex = 45;
            this.btnGestionUsuarios.Tag = "btnUsuarios";
            this.btnGestionUsuarios.Text = "Gestión de Usuarios";
            this.btnGestionUsuarios.UseVisualStyleBackColor = false;
            this.btnGestionUsuarios.Click += new System.EventHandler(this.btnGestionUsuarios_Click);
            // 
            // btnAbrirVentas
            // 
            this.btnAbrirVentas.AutoEllipsis = true;
            this.btnAbrirVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(233)))));
            this.btnAbrirVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbrirVentas.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAbrirVentas.FlatAppearance.BorderSize = 0;
            this.btnAbrirVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrirVentas.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAbrirVentas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAbrirVentas.Location = new System.Drawing.Point(10, 10);
            this.btnAbrirVentas.Margin = new System.Windows.Forms.Padding(3, 3, 3, 12);
            this.btnAbrirVentas.Name = "btnAbrirVentas";
            this.btnAbrirVentas.Size = new System.Drawing.Size(177, 35);
            this.btnAbrirVentas.TabIndex = 43;
            this.btnAbrirVentas.Tag = "btnAbrirVentas";
            this.btnAbrirVentas.Text = "Gestión de Ventas";
            this.btnAbrirVentas.UseVisualStyleBackColor = false;
            this.btnAbrirVentas.Click += new System.EventHandler(this.btnAbrirVentas_Click);
            // 
            // btnAbrirCompras
            // 
            this.btnAbrirCompras.AutoEllipsis = true;
            this.btnAbrirCompras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(233)))));
            this.btnAbrirCompras.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAbrirCompras.FlatAppearance.BorderSize = 0;
            this.btnAbrirCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrirCompras.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAbrirCompras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAbrirCompras.Location = new System.Drawing.Point(10, 60);
            this.btnAbrirCompras.Margin = new System.Windows.Forms.Padding(3, 3, 3, 12);
            this.btnAbrirCompras.Name = "btnAbrirCompras";
            this.btnAbrirCompras.Size = new System.Drawing.Size(177, 35);
            this.btnAbrirCompras.TabIndex = 44;
            this.btnAbrirCompras.Tag = "btnCompras";
            this.btnAbrirCompras.Text = "Gestión de Compras";
            this.btnAbrirCompras.UseVisualStyleBackColor = false;
            this.btnAbrirCompras.Click += new System.EventHandler(this.btnAbrirCompras_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(221, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // btnLogout
            // 
            this.btnLogout.AutoEllipsis = true;
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(233)))));
            this.btnLogout.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(112)))), ((int)(((byte)(92)))));
            this.btnLogout.FlatAppearance.BorderSize = 2;
            this.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(112)))), ((int)(((byte)(92)))));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLogout.Location = new System.Drawing.Point(8, 594);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(203, 35);
            this.btnLogout.TabIndex = 40;
            this.btnLogout.Tag = "btnCerrarSesion";
            this.btnLogout.Text = "Cerrar Sesión";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // button4
            // 
            this.button4.AutoEllipsis = true;
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button4.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(16)))), ((int)(((byte)(48)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(20)))), ((int)(((byte)(57)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button4.Location = new System.Drawing.Point(1214, 13);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(35, 35);
            this.button4.TabIndex = 9;
            this.button4.Text = "-";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.AutoEllipsis = true;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(16)))), ((int)(((byte)(48)))));
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(16)))), ((int)(((byte)(48)))));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(20)))), ((int)(((byte)(57)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(1255, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bodoni MT", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(533, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 36);
            this.label1.TabIndex = 39;
            this.label1.Text = "DIALECT CAFÉ";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown_1);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(44)))), ((int)(((byte)(36)))));
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.comboIdiomas);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.button4);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1320, 60);
            this.panel4.TabIndex = 21;
            this.panel4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel4_MouseDown_1);
            // 
            // comboIdiomas
            // 
            this.comboIdiomas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comboIdiomas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboIdiomas.ForeColor = System.Drawing.SystemColors.Window;
            this.comboIdiomas.FormattingEnabled = true;
            this.comboIdiomas.Location = new System.Drawing.Point(78, 22);
            this.comboIdiomas.Name = "comboIdiomas";
            this.comboIdiomas.Size = new System.Drawing.Size(121, 21);
            this.comboIdiomas.TabIndex = 40;
            this.comboIdiomas.SelectedValueChanged += new System.EventHandler(this.comboIdiomas_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 19);
            this.label3.TabIndex = 48;
            this.label3.Text = "Idioma:";
            // 
            // Vista_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1320, 720);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Vista_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vista_ToolBox";
            this.Load += new System.EventHandler(this.Vista_Principal_Load);
            this.panelContenedor.ResumeLayout(false);
            this.panelDerecho.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panelBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Panel panelFormularios;
        private System.Windows.Forms.Panel panelDerecho;
        private System.Windows.Forms.Panel panelBotones;
        private System.Windows.Forms.Button btnGestionUsuarios;
        private System.Windows.Forms.Button btnAbrirVentas;
        private System.Windows.Forms.Button btnAbrirCompras;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPerfil;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnPerfil;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnGestionIdiomas;
        private System.Windows.Forms.Button btnGestionProductos;
        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.ComboBox comboIdiomas;
        private System.Windows.Forms.Label label3;
    }
}

