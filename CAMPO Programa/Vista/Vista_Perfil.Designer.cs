namespace Vista
{
    partial class Vista_Perfil
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
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnModifUser = new System.Windows.Forms.Button();
            this.txtContraActual = new System.Windows.Forms.TextBox();
            this.txtNuevaContra = new System.Windows.Forms.TextBox();
            this.txtRepetirContra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.panelBotonesIzquierdo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBotonesIzquierdo
            // 
            this.panelBotonesIzquierdo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.panelBotonesIzquierdo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBotonesIzquierdo.Controls.Add(this.btnModifUser);
            this.panelBotonesIzquierdo.Controls.Add(this.btnLogout);
            this.panelBotonesIzquierdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelBotonesIzquierdo.Location = new System.Drawing.Point(0, 0);
            this.panelBotonesIzquierdo.Margin = new System.Windows.Forms.Padding(0);
            this.panelBotonesIzquierdo.Name = "panelBotonesIzquierdo";
            this.panelBotonesIzquierdo.Size = new System.Drawing.Size(136, 550);
            this.panelBotonesIzquierdo.TabIndex = 43;
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
            // btnModifUser
            // 
            this.btnModifUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnModifUser.FlatAppearance.BorderSize = 0;
            this.btnModifUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifUser.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnModifUser.Location = new System.Drawing.Point(12, 106);
            this.btnModifUser.Name = "btnModifUser";
            this.btnModifUser.Size = new System.Drawing.Size(112, 48);
            this.btnModifUser.TabIndex = 48;
            this.btnModifUser.Text = "Cambiar Contraseña";
            this.btnModifUser.UseVisualStyleBackColor = false;
            // 
            // txtContraActual
            // 
            this.txtContraActual.Location = new System.Drawing.Point(280, 153);
            this.txtContraActual.Name = "txtContraActual";
            this.txtContraActual.Size = new System.Drawing.Size(249, 20);
            this.txtContraActual.TabIndex = 46;
            // 
            // txtNuevaContra
            // 
            this.txtNuevaContra.Location = new System.Drawing.Point(280, 214);
            this.txtNuevaContra.Name = "txtNuevaContra";
            this.txtNuevaContra.Size = new System.Drawing.Size(249, 20);
            this.txtNuevaContra.TabIndex = 47;
            // 
            // txtRepetirContra
            // 
            this.txtRepetirContra.Location = new System.Drawing.Point(280, 255);
            this.txtRepetirContra.Name = "txtRepetirContra";
            this.txtRepetirContra.Size = new System.Drawing.Size(249, 20);
            this.txtRepetirContra.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(177, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 49;
            this.label1.Text = "Contraseña Actual:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 50;
            this.label2.Text = "Nueva Contraseña:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(177, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 51;
            this.label3.Text = "Repetir Contraseña:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.btnAceptar);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtContraActual);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtNuevaContra);
            this.panel1.Controls.Add(this.txtRepetirContra);
            this.panel1.Location = new System.Drawing.Point(158, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(697, 526);
            this.panel1.TabIndex = 52;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(277, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 13);
            this.label4.TabIndex = 52;
            this.label4.Text = "CAMBIAR CONTRASEÑA";
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
            this.btnAceptar.Location = new System.Drawing.Point(280, 321);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(144, 35);
            this.btnAceptar.TabIndex = 62;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // Vista_Perfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(879, 550);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelBotonesIzquierdo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Vista_Perfil";
            this.Text = "Vista_Perfil";
            this.Load += new System.EventHandler(this.Vista_Perfil_Load);
            this.panelBotonesIzquierdo.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBotonesIzquierdo;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnModifUser;
        private System.Windows.Forms.TextBox txtContraActual;
        private System.Windows.Forms.TextBox txtNuevaContra;
        private System.Windows.Forms.TextBox txtRepetirContra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAceptar;
    }
}