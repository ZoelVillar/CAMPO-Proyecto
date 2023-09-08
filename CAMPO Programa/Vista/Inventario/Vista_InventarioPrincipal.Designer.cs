namespace Vista.Inventario
{
    partial class Vista_InventarioPrincipal
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
            this.btnGestionProductos = new System.Windows.Forms.Button();
            this.btnGestionCategorias = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panelFormularios = new System.Windows.Forms.Panel();
            this.panelBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBotones
            // 
            this.panelBotones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(228)))));
            this.panelBotones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBotones.Controls.Add(this.btnGestionProductos);
            this.panelBotones.Controls.Add(this.btnGestionCategorias);
            this.panelBotones.Controls.Add(this.btnLogout);
            this.panelBotones.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelBotones.Location = new System.Drawing.Point(945, 0);
            this.panelBotones.Margin = new System.Windows.Forms.Padding(0);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new System.Drawing.Size(155, 660);
            this.panelBotones.TabIndex = 45;
            // 
            // btnGestionProductos
            // 
            this.btnGestionProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGestionProductos.FlatAppearance.BorderSize = 0;
            this.btnGestionProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionProductos.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnGestionProductos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGestionProductos.Location = new System.Drawing.Point(12, 114);
            this.btnGestionProductos.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.btnGestionProductos.Name = "btnGestionProductos";
            this.btnGestionProductos.Size = new System.Drawing.Size(130, 47);
            this.btnGestionProductos.TabIndex = 49;
            this.btnGestionProductos.Text = "Gestionar Productos";
            this.btnGestionProductos.UseVisualStyleBackColor = false;
            this.btnGestionProductos.Click += new System.EventHandler(this.btnGestionProductos_Click);
            // 
            // btnGestionCategorias
            // 
            this.btnGestionCategorias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGestionCategorias.FlatAppearance.BorderSize = 0;
            this.btnGestionCategorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionCategorias.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnGestionCategorias.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGestionCategorias.Location = new System.Drawing.Point(12, 55);
            this.btnGestionCategorias.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.btnGestionCategorias.Name = "btnGestionCategorias";
            this.btnGestionCategorias.Size = new System.Drawing.Size(130, 46);
            this.btnGestionCategorias.TabIndex = 48;
            this.btnGestionCategorias.Text = "Gestionar Categorías";
            this.btnGestionCategorias.UseVisualStyleBackColor = false;
            this.btnGestionCategorias.Click += new System.EventHandler(this.btnGestionCategorias_Click);
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
            this.btnLogout.Location = new System.Drawing.Point(12, 500);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(0, 0);
            this.btnLogout.TabIndex = 40;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            // 
            // panelFormularios
            // 
            this.panelFormularios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormularios.Location = new System.Drawing.Point(0, 0);
            this.panelFormularios.Name = "panelFormularios";
            this.panelFormularios.Size = new System.Drawing.Size(945, 660);
            this.panelFormularios.TabIndex = 46;
            // 
            // Vista_InventarioPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(1100, 660);
            this.Controls.Add(this.panelFormularios);
            this.Controls.Add(this.panelBotones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Vista_InventarioPrincipal";
            this.Text = "Vista_InventarioPrincipal";
            this.Load += new System.EventHandler(this.Vista_InventarioPrincipal_Load);
            this.panelBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBotones;
        private System.Windows.Forms.Button btnGestionProductos;
        private System.Windows.Forms.Button btnGestionCategorias;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panelFormularios;
    }
}