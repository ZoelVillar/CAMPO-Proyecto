namespace Vista.Usuarios.Idiomas
{
    partial class Vista_Idiomas
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
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.TraduccionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idiomaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idiomaNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TagID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Texto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditarTraduccion = new System.Windows.Forms.Button();
            this.listaIdiomas = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAgregarTag = new System.Windows.Forms.Button();
            this.btnEliminarTag = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TraduccionID,
            this.idiomaID,
            this.idiomaNombre,
            this.TagID,
            this.Tag,
            this.Descripcion,
            this.Texto});
            this.dataGrid.Location = new System.Drawing.Point(334, 133);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowHeadersWidth = 62;
            this.dataGrid.Size = new System.Drawing.Size(709, 368);
            this.dataGrid.TabIndex = 68;
            // 
            // TraduccionID
            // 
            this.TraduccionID.HeaderText = "TraduccionID";
            this.TraduccionID.Name = "TraduccionID";
            // 
            // idiomaID
            // 
            this.idiomaID.HeaderText = "idiomaID";
            this.idiomaID.Name = "idiomaID";
            this.idiomaID.Visible = false;
            // 
            // idiomaNombre
            // 
            this.idiomaNombre.HeaderText = "idiomaNombre";
            this.idiomaNombre.Name = "idiomaNombre";
            // 
            // TagID
            // 
            this.TagID.HeaderText = "TagID";
            this.TagID.Name = "TagID";
            // 
            // Tag
            // 
            this.Tag.HeaderText = "Tag";
            this.Tag.Name = "Tag";
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            // 
            // Texto
            // 
            this.Texto.HeaderText = "Texto";
            this.Texto.Name = "Texto";
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
            this.btnAgregar.Location = new System.Drawing.Point(64, 507);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(109, 35);
            this.btnAgregar.TabIndex = 69;
            this.btnAgregar.Tag = "btnAgregarIdioma";
            this.btnAgregar.Text = "Agregar Idioma";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
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
            this.btnEliminar.Location = new System.Drawing.Point(179, 507);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(105, 35);
            this.btnEliminar.TabIndex = 70;
            this.btnEliminar.Tag = "btnEliminarIdioma";
            this.btnEliminar.Text = "Eliminar Idioma";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditarTraduccion
            // 
            this.btnEditarTraduccion.AutoEllipsis = true;
            this.btnEditarTraduccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEditarTraduccion.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnEditarTraduccion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(16)))), ((int)(((byte)(48)))));
            this.btnEditarTraduccion.FlatAppearance.BorderSize = 0;
            this.btnEditarTraduccion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(20)))), ((int)(((byte)(57)))));
            this.btnEditarTraduccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarTraduccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarTraduccion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEditarTraduccion.Location = new System.Drawing.Point(334, 507);
            this.btnEditarTraduccion.Name = "btnEditarTraduccion";
            this.btnEditarTraduccion.Size = new System.Drawing.Size(144, 35);
            this.btnEditarTraduccion.TabIndex = 71;
            this.btnEditarTraduccion.Tag = "btnEditarTraduccion";
            this.btnEditarTraduccion.Text = "Editar Traduccion";
            this.btnEditarTraduccion.UseVisualStyleBackColor = false;
            this.btnEditarTraduccion.Click += new System.EventHandler(this.btnEditarTraduccion_Click);
            // 
            // listaIdiomas
            // 
            this.listaIdiomas.FormattingEnabled = true;
            this.listaIdiomas.Location = new System.Drawing.Point(64, 133);
            this.listaIdiomas.Name = "listaIdiomas";
            this.listaIdiomas.Size = new System.Drawing.Size(220, 368);
            this.listaIdiomas.TabIndex = 72;
            this.listaIdiomas.SelectedIndexChanged += new System.EventHandler(this.listaIdiomas_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 73;
            this.label1.Tag = "lblListadeIdiomas";
            this.label1.Text = "Lista de Idiomas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(331, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 74;
            this.label2.Tag = "lblTraducciones";
            this.label2.Text = "Traducciones:";
            // 
            // btnAgregarTag
            // 
            this.btnAgregarTag.AutoEllipsis = true;
            this.btnAgregarTag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAgregarTag.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAgregarTag.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(16)))), ((int)(((byte)(48)))));
            this.btnAgregarTag.FlatAppearance.BorderSize = 0;
            this.btnAgregarTag.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(20)))), ((int)(((byte)(57)))));
            this.btnAgregarTag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarTag.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAgregarTag.Location = new System.Drawing.Point(484, 507);
            this.btnAgregarTag.Name = "btnAgregarTag";
            this.btnAgregarTag.Size = new System.Drawing.Size(144, 35);
            this.btnAgregarTag.TabIndex = 75;
            this.btnAgregarTag.Tag = "btnAgregarTag";
            this.btnAgregarTag.Text = "Agregar Tag";
            this.btnAgregarTag.UseVisualStyleBackColor = false;
            this.btnAgregarTag.Click += new System.EventHandler(this.btnAgregarTag_Click);
            // 
            // btnEliminarTag
            // 
            this.btnEliminarTag.AutoEllipsis = true;
            this.btnEliminarTag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEliminarTag.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnEliminarTag.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(16)))), ((int)(((byte)(48)))));
            this.btnEliminarTag.FlatAppearance.BorderSize = 0;
            this.btnEliminarTag.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(20)))), ((int)(((byte)(57)))));
            this.btnEliminarTag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarTag.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminarTag.Location = new System.Drawing.Point(634, 507);
            this.btnEliminarTag.Name = "btnEliminarTag";
            this.btnEliminarTag.Size = new System.Drawing.Size(144, 35);
            this.btnEliminarTag.TabIndex = 76;
            this.btnEliminarTag.Tag = "btnEliminarTag";
            this.btnEliminarTag.Text = "Eliminar Tag";
            this.btnEliminarTag.UseVisualStyleBackColor = false;
            this.btnEliminarTag.Click += new System.EventHandler(this.btnEliminarTag_Click);
            // 
            // Vista_Idiomas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(1100, 660);
            this.Controls.Add(this.btnEliminarTag);
            this.Controls.Add(this.btnAgregarTag);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listaIdiomas);
            this.Controls.Add(this.btnEditarTraduccion);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dataGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Vista_Idiomas";
            this.Text = "Vista_Idiomas";
            this.Load += new System.EventHandler(this.Vista_Idiomas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditarTraduccion;
        private System.Windows.Forms.ListBox listaIdiomas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAgregarTag;
        private System.Windows.Forms.Button btnEliminarTag;
        private System.Windows.Forms.DataGridViewTextBoxColumn TraduccionID;
        private System.Windows.Forms.DataGridViewTextBoxColumn idiomaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn idiomaNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn TagID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tag;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Texto;
    }
}