namespace Vista.Principales
{
    partial class Vista_Negocio
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
            this.grillaBitacoraCambios = new System.Windows.Forms.Label();
            this.pictureLogo = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCargarLogo = new FontAwesome.Sharp.IconButton();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCUIT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGuardarCambios = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grillaBitacoraCambios
            // 
            this.grillaBitacoraCambios.AutoSize = true;
            this.grillaBitacoraCambios.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grillaBitacoraCambios.Location = new System.Drawing.Point(148, 37);
            this.grillaBitacoraCambios.Name = "grillaBitacoraCambios";
            this.grillaBitacoraCambios.Size = new System.Drawing.Size(189, 26);
            this.grillaBitacoraCambios.TabIndex = 3;
            this.grillaBitacoraCambios.Text = "Datos del Negocio";
            // 
            // pictureLogo
            // 
            this.pictureLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureLogo.Location = new System.Drawing.Point(16, 31);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.Size = new System.Drawing.Size(205, 177);
            this.pictureLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureLogo.TabIndex = 4;
            this.pictureLogo.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 60;
            this.label2.Text = "Logo:";
            // 
            // btnCargarLogo
            // 
            this.btnCargarLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(129)))), ((int)(((byte)(48)))));
            this.btnCargarLogo.FlatAppearance.BorderSize = 0;
            this.btnCargarLogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnCargarLogo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCargarLogo.IconChar = FontAwesome.Sharp.IconChar.Upload;
            this.btnCargarLogo.IconColor = System.Drawing.Color.White;
            this.btnCargarLogo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCargarLogo.IconSize = 18;
            this.btnCargarLogo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCargarLogo.Location = new System.Drawing.Point(16, 226);
            this.btnCargarLogo.Name = "btnCargarLogo";
            this.btnCargarLogo.Size = new System.Drawing.Size(205, 32);
            this.btnCargarLogo.TabIndex = 61;
            this.btnCargarLogo.Text = "Cargar Logo";
            this.btnCargarLogo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCargarLogo.UseVisualStyleBackColor = false;
            this.btnCargarLogo.Click += new System.EventHandler(this.btnCargarLogo_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(265, 47);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(205, 20);
            this.txtNombre.TabIndex = 63;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(262, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 62;
            this.label1.Text = "Nombre del Negocio:";
            // 
            // txtCUIT
            // 
            this.txtCUIT.Location = new System.Drawing.Point(265, 101);
            this.txtCUIT.Name = "txtCUIT";
            this.txtCUIT.Size = new System.Drawing.Size(205, 20);
            this.txtCUIT.TabIndex = 65;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(262, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 64;
            this.label3.Text = "CUIT:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(265, 158);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(205, 20);
            this.txtDireccion.TabIndex = 69;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(262, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 68;
            this.label4.Text = "Direccion";
            // 
            // btnGuardarCambios
            // 
            this.btnGuardarCambios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(129)))), ((int)(((byte)(48)))));
            this.btnGuardarCambios.FlatAppearance.BorderSize = 0;
            this.btnGuardarCambios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarCambios.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnGuardarCambios.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardarCambios.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleUp;
            this.btnGuardarCambios.IconColor = System.Drawing.Color.White;
            this.btnGuardarCambios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardarCambios.IconSize = 18;
            this.btnGuardarCambios.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarCambios.Location = new System.Drawing.Point(265, 226);
            this.btnGuardarCambios.Name = "btnGuardarCambios";
            this.btnGuardarCambios.Size = new System.Drawing.Size(205, 32);
            this.btnGuardarCambios.TabIndex = 70;
            this.btnGuardarCambios.Text = "Guardar  Cambios";
            this.btnGuardarCambios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardarCambios.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.btnGuardarCambios);
            this.panel1.Controls.Add(this.pictureLogo);
            this.panel1.Controls.Add(this.txtDireccion);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnCargarLogo);
            this.panel1.Controls.Add(this.txtCUIT);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(153, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(485, 283);
            this.panel1.TabIndex = 71;
            // 
            // Vista_Negocio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grillaBitacoraCambios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Vista_Negocio";
            this.Text = "Vista_Negocio";
            this.Load += new System.EventHandler(this.Vista_Negocio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label grillaBitacoraCambios;
        private System.Windows.Forms.PictureBox pictureLogo;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton btnCargarLogo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCUIT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton btnGuardarCambios;
        private System.Windows.Forms.Panel panel1;
    }
}