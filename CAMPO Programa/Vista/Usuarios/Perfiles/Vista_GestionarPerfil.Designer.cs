namespace Vista
{
    partial class Vista_GestionarPerfil
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
            this.grillaPerfiles = new System.Windows.Forms.DataGridView();
            this.id_perfil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PermisoPerfil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grillaPC = new System.Windows.Forms.DataGridView();
            this.id_permiso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grillaPS = new System.Windows.Forms.DataGridView();
            this.id_permiso_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.treeViewPermisos = new System.Windows.Forms.TreeView();
            this.btnAgregarPerfil = new System.Windows.Forms.Button();
            this.btnEliminarPerfil = new System.Windows.Forms.Button();
            this.btnEliminarPC = new System.Windows.Forms.Button();
            this.btnAgregarPC = new System.Windows.Forms.Button();
            this.btnVincularPCaPC = new System.Windows.Forms.Button();
            this.btnVincularPCaPS = new System.Windows.Forms.Button();
            this.btnAgregarPS = new System.Windows.Forms.Button();
            this.btnBorrarPS = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDesvincular = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grillaPerfiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaPC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaPS)).BeginInit();
            this.SuspendLayout();
            // 
            // grillaPerfiles
            // 
            this.grillaPerfiles.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grillaPerfiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaPerfiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_perfil,
            this.PermisoPerfil});
            this.grillaPerfiles.Location = new System.Drawing.Point(456, 65);
            this.grillaPerfiles.Name = "grillaPerfiles";
            this.grillaPerfiles.RowHeadersWidth = 51;
            this.grillaPerfiles.Size = new System.Drawing.Size(438, 193);
            this.grillaPerfiles.TabIndex = 0;
            // 
            // id_perfil
            // 
            this.id_perfil.HeaderText = "id_perfil";
            this.id_perfil.Name = "id_perfil";
            // 
            // PermisoPerfil
            // 
            this.PermisoPerfil.HeaderText = "PermisoPerfil";
            this.PermisoPerfil.Name = "PermisoPerfil";
            // 
            // grillaPC
            // 
            this.grillaPC.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grillaPC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaPC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_permiso});
            this.grillaPC.Location = new System.Drawing.Point(456, 295);
            this.grillaPC.Name = "grillaPC";
            this.grillaPC.RowHeadersWidth = 51;
            this.grillaPC.Size = new System.Drawing.Size(180, 260);
            this.grillaPC.TabIndex = 1;
            this.grillaPC.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grillaPC_RowHeaderMouseClick);
            // 
            // id_permiso
            // 
            this.id_permiso.HeaderText = "id_permiso";
            this.id_permiso.Name = "id_permiso";
            // 
            // grillaPS
            // 
            this.grillaPS.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grillaPS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaPS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_permiso_});
            this.grillaPS.Location = new System.Drawing.Point(714, 295);
            this.grillaPS.Name = "grillaPS";
            this.grillaPS.RowHeadersWidth = 51;
            this.grillaPS.Size = new System.Drawing.Size(180, 260);
            this.grillaPS.TabIndex = 2;
            // 
            // id_permiso_
            // 
            this.id_permiso_.HeaderText = "id_permiso";
            this.id_permiso_.Name = "id_permiso_";
            // 
            // treeViewPermisos
            // 
            this.treeViewPermisos.Location = new System.Drawing.Point(41, 65);
            this.treeViewPermisos.Name = "treeViewPermisos";
            this.treeViewPermisos.Size = new System.Drawing.Size(234, 490);
            this.treeViewPermisos.TabIndex = 56;
            // 
            // btnAgregarPerfil
            // 
            this.btnAgregarPerfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAgregarPerfil.FlatAppearance.BorderSize = 0;
            this.btnAgregarPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarPerfil.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAgregarPerfil.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAgregarPerfil.Location = new System.Drawing.Point(308, 65);
            this.btnAgregarPerfil.Margin = new System.Windows.Forms.Padding(3, 3, 15, 10);
            this.btnAgregarPerfil.Name = "btnAgregarPerfil";
            this.btnAgregarPerfil.Size = new System.Drawing.Size(130, 40);
            this.btnAgregarPerfil.TabIndex = 57;
            this.btnAgregarPerfil.Text = "Agregar Perfil";
            this.btnAgregarPerfil.UseVisualStyleBackColor = false;
            this.btnAgregarPerfil.Click += new System.EventHandler(this.btnAgregarPerfil_Click);
            // 
            // btnEliminarPerfil
            // 
            this.btnEliminarPerfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEliminarPerfil.FlatAppearance.BorderSize = 0;
            this.btnEliminarPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarPerfil.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnEliminarPerfil.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminarPerfil.Location = new System.Drawing.Point(308, 118);
            this.btnEliminarPerfil.Margin = new System.Windows.Forms.Padding(3, 3, 15, 10);
            this.btnEliminarPerfil.Name = "btnEliminarPerfil";
            this.btnEliminarPerfil.Size = new System.Drawing.Size(130, 40);
            this.btnEliminarPerfil.TabIndex = 58;
            this.btnEliminarPerfil.Text = "Eliminar Perfil";
            this.btnEliminarPerfil.UseVisualStyleBackColor = false;
            this.btnEliminarPerfil.Click += new System.EventHandler(this.btnEliminarPerfil_Click);
            // 
            // btnEliminarPC
            // 
            this.btnEliminarPC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEliminarPC.FlatAppearance.BorderSize = 0;
            this.btnEliminarPC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarPC.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnEliminarPC.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminarPC.Location = new System.Drawing.Point(308, 358);
            this.btnEliminarPC.Margin = new System.Windows.Forms.Padding(3, 3, 15, 10);
            this.btnEliminarPC.Name = "btnEliminarPC";
            this.btnEliminarPC.Size = new System.Drawing.Size(130, 50);
            this.btnEliminarPC.TabIndex = 60;
            this.btnEliminarPC.Text = "Eliminar Permiso Compuesto";
            this.btnEliminarPC.UseVisualStyleBackColor = false;
            this.btnEliminarPC.Click += new System.EventHandler(this.btnEliminarPC_Click);
            // 
            // btnAgregarPC
            // 
            this.btnAgregarPC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAgregarPC.FlatAppearance.BorderSize = 0;
            this.btnAgregarPC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarPC.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAgregarPC.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAgregarPC.Location = new System.Drawing.Point(308, 295);
            this.btnAgregarPC.Margin = new System.Windows.Forms.Padding(3, 3, 15, 10);
            this.btnAgregarPC.Name = "btnAgregarPC";
            this.btnAgregarPC.Size = new System.Drawing.Size(130, 50);
            this.btnAgregarPC.TabIndex = 59;
            this.btnAgregarPC.Text = "Agregar Permiso Compuesto";
            this.btnAgregarPC.UseVisualStyleBackColor = false;
            this.btnAgregarPC.Click += new System.EventHandler(this.btnAgregarPC_Click);
            // 
            // btnVincularPCaPC
            // 
            this.btnVincularPCaPC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnVincularPCaPC.FlatAppearance.BorderSize = 0;
            this.btnVincularPCaPC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVincularPCaPC.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnVincularPCaPC.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnVincularPCaPC.Location = new System.Drawing.Point(308, 505);
            this.btnVincularPCaPC.Margin = new System.Windows.Forms.Padding(3, 3, 15, 10);
            this.btnVincularPCaPC.Name = "btnVincularPCaPC";
            this.btnVincularPCaPC.Size = new System.Drawing.Size(130, 50);
            this.btnVincularPCaPC.TabIndex = 62;
            this.btnVincularPCaPC.Text = "Vincular: \r\nP.C. → P.C.";
            this.btnVincularPCaPC.UseVisualStyleBackColor = false;
            this.btnVincularPCaPC.Click += new System.EventHandler(this.btnVincularPCaPC_Click);
            // 
            // btnVincularPCaPS
            // 
            this.btnVincularPCaPS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnVincularPCaPS.FlatAppearance.BorderSize = 0;
            this.btnVincularPCaPS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVincularPCaPS.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnVincularPCaPS.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnVincularPCaPS.Location = new System.Drawing.Point(308, 442);
            this.btnVincularPCaPS.Margin = new System.Windows.Forms.Padding(3, 3, 15, 10);
            this.btnVincularPCaPS.Name = "btnVincularPCaPS";
            this.btnVincularPCaPS.Size = new System.Drawing.Size(130, 50);
            this.btnVincularPCaPS.TabIndex = 61;
            this.btnVincularPCaPS.Text = "Vincular: \r\nP.C. → P.S.";
            this.btnVincularPCaPS.UseVisualStyleBackColor = false;
            this.btnVincularPCaPS.Click += new System.EventHandler(this.btnVincularPCaPS_Click);
            // 
            // btnAgregarPS
            // 
            this.btnAgregarPS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAgregarPS.FlatAppearance.BorderSize = 0;
            this.btnAgregarPS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarPS.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAgregarPS.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAgregarPS.Location = new System.Drawing.Point(714, 561);
            this.btnAgregarPS.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.btnAgregarPS.Name = "btnAgregarPS";
            this.btnAgregarPS.Size = new System.Drawing.Size(86, 36);
            this.btnAgregarPS.TabIndex = 63;
            this.btnAgregarPS.Text = "Nuevo PS";
            this.btnAgregarPS.UseVisualStyleBackColor = false;
            this.btnAgregarPS.Click += new System.EventHandler(this.btnAgregarPS_Click);
            // 
            // btnBorrarPS
            // 
            this.btnBorrarPS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBorrarPS.FlatAppearance.BorderSize = 0;
            this.btnBorrarPS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrarPS.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnBorrarPS.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBorrarPS.Location = new System.Drawing.Point(808, 561);
            this.btnBorrarPS.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.btnBorrarPS.Name = "btnBorrarPS";
            this.btnBorrarPS.Size = new System.Drawing.Size(86, 36);
            this.btnBorrarPS.TabIndex = 64;
            this.btnBorrarPS.Text = "Borrar PS";
            this.btnBorrarPS.UseVisualStyleBackColor = false;
            this.btnBorrarPS.Click += new System.EventHandler(this.btnBorrarPS_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(452, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 19);
            this.label1.TabIndex = 65;
            this.label1.Text = "Permisos  Compuestos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(710, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 19);
            this.label2.TabIndex = 66;
            this.label2.Text = "Permisos  Simples:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(452, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 19);
            this.label3.TabIndex = 67;
            this.label3.Text = "Perfiles:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(37, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 19);
            this.label4.TabIndex = 68;
            this.label4.Text = "Permisos:";
            // 
            // btnDesvincular
            // 
            this.btnDesvincular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDesvincular.FlatAppearance.BorderSize = 0;
            this.btnDesvincular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesvincular.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDesvincular.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDesvincular.Location = new System.Drawing.Point(41, 561);
            this.btnDesvincular.Margin = new System.Windows.Forms.Padding(3, 3, 15, 10);
            this.btnDesvincular.Name = "btnDesvincular";
            this.btnDesvincular.Size = new System.Drawing.Size(234, 36);
            this.btnDesvincular.TabIndex = 69;
            this.btnDesvincular.Text = "Desvincular";
            this.btnDesvincular.UseVisualStyleBackColor = false;
            this.btnDesvincular.Click += new System.EventHandler(this.btnDesvincular_Click);
            // 
            // Vista_GestionarPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(945, 660);
            this.Controls.Add(this.btnDesvincular);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBorrarPS);
            this.Controls.Add(this.btnAgregarPS);
            this.Controls.Add(this.btnVincularPCaPC);
            this.Controls.Add(this.btnVincularPCaPS);
            this.Controls.Add(this.btnEliminarPC);
            this.Controls.Add(this.btnAgregarPC);
            this.Controls.Add(this.btnEliminarPerfil);
            this.Controls.Add(this.btnAgregarPerfil);
            this.Controls.Add(this.treeViewPermisos);
            this.Controls.Add(this.grillaPS);
            this.Controls.Add(this.grillaPC);
            this.Controls.Add(this.grillaPerfiles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Vista_GestionarPerfil";
            this.Text = "Vista_GestionarAreas";
            this.Load += new System.EventHandler(this.Vista_GestionarPerfil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaPerfiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaPC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaPS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grillaPerfiles;
        private System.Windows.Forms.DataGridView grillaPC;
        private System.Windows.Forms.DataGridView grillaPS;
        private System.Windows.Forms.TreeView treeViewPermisos;
        private System.Windows.Forms.Button btnAgregarPerfil;
        private System.Windows.Forms.Button btnEliminarPerfil;
        private System.Windows.Forms.Button btnEliminarPC;
        private System.Windows.Forms.Button btnAgregarPC;
        private System.Windows.Forms.Button btnVincularPCaPC;
        private System.Windows.Forms.Button btnVincularPCaPS;
        private System.Windows.Forms.Button btnAgregarPS;
        private System.Windows.Forms.Button btnBorrarPS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_permiso;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_permiso_;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_perfil;
        private System.Windows.Forms.DataGridViewTextBoxColumn PermisoPerfil;
        private System.Windows.Forms.Button btnDesvincular;
    }
}