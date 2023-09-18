namespace Vista.Usuarios
{
    partial class Vista_PrincipalUsuarios
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
            this.btnGestionProveedores = new System.Windows.Forms.Button();
            this.btnGestionPerfiles = new System.Windows.Forms.Button();
            this.btnGestionUsuarios = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panelFormularios = new System.Windows.Forms.Panel();
            this.panelBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBotones
            // 
            this.panelBotones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(228)))));
            this.panelBotones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBotones.Controls.Add(this.btnGestionProveedores);
            this.panelBotones.Controls.Add(this.btnGestionPerfiles);
            this.panelBotones.Controls.Add(this.btnGestionUsuarios);
            this.panelBotones.Controls.Add(this.btnLogout);
            this.panelBotones.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelBotones.Location = new System.Drawing.Point(945, 0);
            this.panelBotones.Margin = new System.Windows.Forms.Padding(0);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new System.Drawing.Size(155, 660);
            this.panelBotones.TabIndex = 43;
            // 
            // btnGestionProveedores
            // 
            this.btnGestionProveedores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGestionProveedores.FlatAppearance.BorderSize = 0;
            this.btnGestionProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionProveedores.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnGestionProveedores.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGestionProveedores.Location = new System.Drawing.Point(12, 166);
            this.btnGestionProveedores.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.btnGestionProveedores.Name = "btnGestionProveedores";
            this.btnGestionProveedores.Size = new System.Drawing.Size(130, 46);
            this.btnGestionProveedores.TabIndex = 51;
            this.btnGestionProveedores.Tag = "btnGestionarProveedores";
            this.btnGestionProveedores.Text = "Gestionar \r\nProveedores";
            this.btnGestionProveedores.UseVisualStyleBackColor = false;
            this.btnGestionProveedores.Click += new System.EventHandler(this.btnGestionProveedores_Click);
            // 
            // btnGestionPerfiles
            // 
            this.btnGestionPerfiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGestionPerfiles.FlatAppearance.BorderSize = 0;
            this.btnGestionPerfiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionPerfiles.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnGestionPerfiles.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGestionPerfiles.Location = new System.Drawing.Point(12, 107);
            this.btnGestionPerfiles.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.btnGestionPerfiles.Name = "btnGestionPerfiles";
            this.btnGestionPerfiles.Size = new System.Drawing.Size(130, 46);
            this.btnGestionPerfiles.TabIndex = 50;
            this.btnGestionPerfiles.Tag = "btnGestionarPerfiles";
            this.btnGestionPerfiles.Text = "Gestionar \r\nPerfiles";
            this.btnGestionPerfiles.UseVisualStyleBackColor = false;
            this.btnGestionPerfiles.Click += new System.EventHandler(this.btnGestionPerfiles_Click);
            // 
            // btnGestionUsuarios
            // 
            this.btnGestionUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGestionUsuarios.FlatAppearance.BorderSize = 0;
            this.btnGestionUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionUsuarios.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnGestionUsuarios.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGestionUsuarios.Location = new System.Drawing.Point(12, 48);
            this.btnGestionUsuarios.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.btnGestionUsuarios.Name = "btnGestionUsuarios";
            this.btnGestionUsuarios.Size = new System.Drawing.Size(130, 46);
            this.btnGestionUsuarios.TabIndex = 49;
            this.btnGestionUsuarios.Tag = "btnGestionarUsuarios";
            this.btnGestionUsuarios.Text = "Gestionar Usuarios";
            this.btnGestionUsuarios.UseVisualStyleBackColor = false;
            this.btnGestionUsuarios.Click += new System.EventHandler(this.btnGestionUsuarios_Click);
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
            this.panelFormularios.TabIndex = 47;
            // 
            // Vista_PrincipalUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(1100, 660);
            this.Controls.Add(this.panelFormularios);
            this.Controls.Add(this.panelBotones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Vista_PrincipalUsuarios";
            this.Text = "Vista_PrincipalUsuarios";
            this.Load += new System.EventHandler(this.Vista_PrincipalUsuarios_Load);
            this.panelBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBotones;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panelFormularios;
        private System.Windows.Forms.Button btnGestionUsuarios;
        private System.Windows.Forms.Button btnGestionPerfiles;
        private System.Windows.Forms.Button btnGestionProveedores;
    }
}