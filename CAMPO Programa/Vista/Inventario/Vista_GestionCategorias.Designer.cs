namespace Vista.Inventario
{
    partial class Vista_GestionCategorias
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBorrarBusqueda = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.comboBuscar = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblCategoriaSeleccionada = new System.Windows.Forms.Label();
            this.comboEstado = new System.Windows.Forms.ComboBox();
            this.btnBorrarIngresoDatos = new System.Windows.Forms.Button();
            this.estadolbl = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtError = new System.Windows.Forms.Label();
            this.labelFunction = new System.Windows.Forms.Label();
            this.lblDatos = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.idCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnExportar = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnBorrarBusqueda);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.txtBuscar);
            this.panel1.Controls.Add(this.comboBuscar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(481, 412);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(433, 217);
            this.panel1.TabIndex = 69;
            // 
            // btnBorrarBusqueda
            // 
            this.btnBorrarBusqueda.AutoEllipsis = true;
            this.btnBorrarBusqueda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBorrarBusqueda.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnBorrarBusqueda.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(16)))), ((int)(((byte)(48)))));
            this.btnBorrarBusqueda.FlatAppearance.BorderSize = 0;
            this.btnBorrarBusqueda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(20)))), ((int)(((byte)(57)))));
            this.btnBorrarBusqueda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrarBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarBusqueda.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBorrarBusqueda.Location = new System.Drawing.Point(119, 169);
            this.btnBorrarBusqueda.Name = "btnBorrarBusqueda";
            this.btnBorrarBusqueda.Size = new System.Drawing.Size(144, 35);
            this.btnBorrarBusqueda.TabIndex = 67;
            this.btnBorrarBusqueda.Text = "Borrar";
            this.btnBorrarBusqueda.UseVisualStyleBackColor = false;
            this.btnBorrarBusqueda.Click += new System.EventHandler(this.btnBorrarBusqueda_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.AutoEllipsis = true;
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(129)))), ((int)(((byte)(48)))));
            this.btnBuscar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(16)))), ((int)(((byte)(48)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(20)))), ((int)(((byte)(57)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBuscar.Location = new System.Drawing.Point(269, 169);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(144, 35);
            this.btnBuscar.TabIndex = 66;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(234, 64);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(179, 21);
            this.txtBuscar.TabIndex = 61;
            // 
            // comboBuscar
            // 
            this.comboBuscar.FormattingEnabled = true;
            this.comboBuscar.Location = new System.Drawing.Point(21, 64);
            this.comboBuscar.Name = "comboBuscar";
            this.comboBuscar.Size = new System.Drawing.Size(179, 23);
            this.comboBuscar.TabIndex = 60;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 59;
            this.label2.Text = "Buscar por:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(17, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 20);
            this.label8.TabIndex = 58;
            this.label8.Text = "Buscar en la Grilla";
            // 
            // btnRefresh
            // 
            this.btnRefresh.AutoEllipsis = true;
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(129)))), ((int)(((byte)(48)))));
            this.btnRefresh.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(16)))), ((int)(((byte)(48)))));
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(20)))), ((int)(((byte)(57)))));
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRefresh.Location = new System.Drawing.Point(846, 374);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(68, 32);
            this.btnRefresh.TabIndex = 70;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblCategoria);
            this.panel2.Controls.Add(this.lblCategoriaSeleccionada);
            this.panel2.Controls.Add(this.comboEstado);
            this.panel2.Controls.Add(this.btnBorrarIngresoDatos);
            this.panel2.Controls.Add(this.estadolbl);
            this.panel2.Controls.Add(this.btnAceptar);
            this.panel2.Controls.Add(this.txtError);
            this.panel2.Controls.Add(this.labelFunction);
            this.panel2.Controls.Add(this.lblDatos);
            this.panel2.Controls.Add(this.txtDescripcion);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(30, 412);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(433, 217);
            this.panel2.TabIndex = 68;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(207, 99);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(11, 16);
            this.lblCategoria.TabIndex = 69;
            this.lblCategoria.Text = "-";
            this.lblCategoria.Visible = false;
            // 
            // lblCategoriaSeleccionada
            // 
            this.lblCategoriaSeleccionada.AutoSize = true;
            this.lblCategoriaSeleccionada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoriaSeleccionada.Location = new System.Drawing.Point(22, 99);
            this.lblCategoriaSeleccionada.Name = "lblCategoriaSeleccionada";
            this.lblCategoriaSeleccionada.Size = new System.Drawing.Size(179, 16);
            this.lblCategoriaSeleccionada.TabIndex = 68;
            this.lblCategoriaSeleccionada.Text = "Categoría Seleccionada:";
            this.lblCategoriaSeleccionada.Visible = false;
            // 
            // comboEstado
            // 
            this.comboEstado.FormattingEnabled = true;
            this.comboEstado.Items.AddRange(new object[] {
            "Activado",
            "Desactivado"});
            this.comboEstado.Location = new System.Drawing.Point(234, 68);
            this.comboEstado.Name = "comboEstado";
            this.comboEstado.Size = new System.Drawing.Size(179, 23);
            this.comboEstado.TabIndex = 68;
            // 
            // btnBorrarIngresoDatos
            // 
            this.btnBorrarIngresoDatos.AutoEllipsis = true;
            this.btnBorrarIngresoDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBorrarIngresoDatos.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnBorrarIngresoDatos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(16)))), ((int)(((byte)(48)))));
            this.btnBorrarIngresoDatos.FlatAppearance.BorderSize = 0;
            this.btnBorrarIngresoDatos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(20)))), ((int)(((byte)(57)))));
            this.btnBorrarIngresoDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrarIngresoDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarIngresoDatos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBorrarIngresoDatos.Location = new System.Drawing.Point(120, 169);
            this.btnBorrarIngresoDatos.Name = "btnBorrarIngresoDatos";
            this.btnBorrarIngresoDatos.Size = new System.Drawing.Size(144, 35);
            this.btnBorrarIngresoDatos.TabIndex = 68;
            this.btnBorrarIngresoDatos.Text = "Borrar";
            this.btnBorrarIngresoDatos.UseVisualStyleBackColor = false;
            this.btnBorrarIngresoDatos.Click += new System.EventHandler(this.btnBorrarIngresoDatos_Click);
            // 
            // estadolbl
            // 
            this.estadolbl.AutoSize = true;
            this.estadolbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estadolbl.Location = new System.Drawing.Point(231, 50);
            this.estadolbl.Name = "estadolbl";
            this.estadolbl.Size = new System.Drawing.Size(45, 15);
            this.estadolbl.TabIndex = 63;
            this.estadolbl.Text = "Estado";
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
            this.btnAceptar.Location = new System.Drawing.Point(270, 169);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(144, 35);
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
            this.txtError.Location = new System.Drawing.Point(22, 147);
            this.txtError.Name = "txtError";
            this.txtError.Size = new System.Drawing.Size(41, 16);
            this.txtError.TabIndex = 60;
            this.txtError.Text = "Error";
            this.txtError.Visible = false;
            // 
            // labelFunction
            // 
            this.labelFunction.AutoSize = true;
            this.labelFunction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFunction.Location = new System.Drawing.Point(152, 12);
            this.labelFunction.Name = "labelFunction";
            this.labelFunction.Size = new System.Drawing.Size(147, 20);
            this.labelFunction.TabIndex = 59;
            this.labelFunction.Text = "- Crear Categoría\r\n";
            // 
            // lblDatos
            // 
            this.lblDatos.AutoSize = true;
            this.lblDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatos.Location = new System.Drawing.Point(17, 12);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(129, 20);
            this.lblDatos.TabIndex = 58;
            this.lblDatos.Text = "Ingresar Datos";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(25, 66);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(180, 21);
            this.txtDescripcion.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 51;
            this.label1.Text = "Descripción";
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCategoria,
            this.descripcion,
            this.estado});
            this.dataGrid.Location = new System.Drawing.Point(30, 23);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowHeadersWidth = 62;
            this.dataGrid.Size = new System.Drawing.Size(884, 329);
            this.dataGrid.TabIndex = 67;
            this.dataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCategoria_CellClick);
            // 
            // idCategoria
            // 
            this.idCategoria.HeaderText = "idCategoria";
            this.idCategoria.Name = "idCategoria";
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "descripción";
            this.descripcion.Name = "descripcion";
            this.descripcion.Width = 150;
            // 
            // estado
            // 
            this.estado.HeaderText = "estado";
            this.estado.Name = "estado";
            // 
            // btnAgregar
            // 
            this.btnAgregar.AutoEllipsis = true;
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAgregar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(16)))), ((int)(((byte)(48)))));
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(20)))), ((int)(((byte)(57)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAgregar.Location = new System.Drawing.Point(30, 374);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(68, 32);
            this.btnAgregar.TabIndex = 71;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.AutoEllipsis = true;
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnModificar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnModificar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(16)))), ((int)(((byte)(48)))));
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(20)))), ((int)(((byte)(57)))));
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnModificar.Location = new System.Drawing.Point(104, 374);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(68, 32);
            this.btnModificar.TabIndex = 72;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.AutoEllipsis = true;
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEliminar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(16)))), ((int)(((byte)(48)))));
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(20)))), ((int)(((byte)(57)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminar.Location = new System.Drawing.Point(178, 374);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(68, 32);
            this.btnEliminar.TabIndex = 73;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(129)))), ((int)(((byte)(48)))));
            this.btnExportar.FlatAppearance.BorderSize = 0;
            this.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnExportar.ForeColor = System.Drawing.Color.White;
            this.btnExportar.IconChar = FontAwesome.Sharp.IconChar.Download;
            this.btnExportar.IconColor = System.Drawing.Color.White;
            this.btnExportar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExportar.IconSize = 18;
            this.btnExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportar.Location = new System.Drawing.Point(721, 374);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(119, 32);
            this.btnExportar.TabIndex = 82;
            this.btnExportar.Text = "Export Excel";
            this.btnExportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExportar.UseVisualStyleBackColor = false;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // Vista_GestionCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(945, 660);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Vista_GestionCategorias";
            this.Text = "Vista_GestionCategorias";
            this.Load += new System.EventHandler(this.Vista_GestionCategorias_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBorrarBusqueda;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.ComboBox comboBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnBorrarIngresoDatos;
        private System.Windows.Forms.Label estadolbl;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label txtError;
        private System.Windows.Forms.Label labelFunction;
        private System.Windows.Forms.Label lblDatos;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.ComboBox comboEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblCategoriaSeleccionada;
        private System.Windows.Forms.Label lblCategoria;
        private FontAwesome.Sharp.IconButton btnExportar;
    }
}