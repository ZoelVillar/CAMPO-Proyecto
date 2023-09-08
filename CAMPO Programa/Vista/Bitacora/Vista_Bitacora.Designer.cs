namespace Vista.Bitacora
{
    partial class Vista_Bitacora
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
            this.btnBitacoraCambios = new System.Windows.Forms.Button();
            this.btnBitacoraEventos = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panelBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBotones
            // 
            this.panelBotones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(190)))), ((int)(((byte)(169)))));
            this.panelBotones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBotones.Controls.Add(this.btnBitacoraCambios);
            this.panelBotones.Controls.Add(this.btnBitacoraEventos);
            this.panelBotones.Controls.Add(this.btnLogout);
            this.panelBotones.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelBotones.Location = new System.Drawing.Point(945, 0);
            this.panelBotones.Margin = new System.Windows.Forms.Padding(0);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new System.Drawing.Size(155, 660);
            this.panelBotones.TabIndex = 46;
            // 
            // btnBitacoraCambios
            // 
            this.btnBitacoraCambios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBitacoraCambios.FlatAppearance.BorderSize = 0;
            this.btnBitacoraCambios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBitacoraCambios.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnBitacoraCambios.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBitacoraCambios.Location = new System.Drawing.Point(12, 108);
            this.btnBitacoraCambios.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.btnBitacoraCambios.Name = "btnBitacoraCambios";
            this.btnBitacoraCambios.Size = new System.Drawing.Size(130, 40);
            this.btnBitacoraCambios.TabIndex = 49;
            this.btnBitacoraCambios.Text = "Bitacora Cambios";
            this.btnBitacoraCambios.UseVisualStyleBackColor = false;
            // 
            // btnBitacoraEventos
            // 
            this.btnBitacoraEventos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBitacoraEventos.FlatAppearance.BorderSize = 0;
            this.btnBitacoraEventos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBitacoraEventos.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnBitacoraEventos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBitacoraEventos.Location = new System.Drawing.Point(12, 55);
            this.btnBitacoraEventos.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.btnBitacoraEventos.Name = "btnBitacoraEventos";
            this.btnBitacoraEventos.Size = new System.Drawing.Size(130, 40);
            this.btnBitacoraEventos.TabIndex = 48;
            this.btnBitacoraEventos.Text = "Bitacora Eventos";
            this.btnBitacoraEventos.UseVisualStyleBackColor = false;
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
            // Vista_Bitacora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(1100, 660);
            this.Controls.Add(this.panelBotones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Vista_Bitacora";
            this.Text = "Vista_Bitacora";
            this.panelBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBotones;
        private System.Windows.Forms.Button btnBitacoraCambios;
        private System.Windows.Forms.Button btnBitacoraEventos;
        private System.Windows.Forms.Button btnLogout;
    }
}