namespace Vista.Principales.Administracion
{
    partial class Vista_DigitoVerificador
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
            this.btnActualizarDigitos = new System.Windows.Forms.Button();
            this.btnRealizarRestore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnActualizarDigitos
            // 
            this.btnActualizarDigitos.Location = new System.Drawing.Point(70, 39);
            this.btnActualizarDigitos.Name = "btnActualizarDigitos";
            this.btnActualizarDigitos.Size = new System.Drawing.Size(93, 61);
            this.btnActualizarDigitos.TabIndex = 0;
            this.btnActualizarDigitos.Tag = "btnActualizarDigitos";
            this.btnActualizarDigitos.Text = "Actualizar Digitos";
            this.btnActualizarDigitos.UseVisualStyleBackColor = true;
            this.btnActualizarDigitos.Click += new System.EventHandler(this.btnActualizarDigitos_Click);
            // 
            // btnRealizarRestore
            // 
            this.btnRealizarRestore.Location = new System.Drawing.Point(242, 39);
            this.btnRealizarRestore.Name = "btnRealizarRestore";
            this.btnRealizarRestore.Size = new System.Drawing.Size(93, 61);
            this.btnRealizarRestore.TabIndex = 1;
            this.btnRealizarRestore.Tag = "btnRealizarRestore";
            this.btnRealizarRestore.Text = "Realizar Restore";
            this.btnRealizarRestore.UseVisualStyleBackColor = true;
            this.btnRealizarRestore.Click += new System.EventHandler(this.btnRealizarRestore_Click);
            // 
            // Vista_DigitoVerificador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 145);
            this.Controls.Add(this.btnRealizarRestore);
            this.Controls.Add(this.btnActualizarDigitos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Vista_DigitoVerificador";
            this.Text = "Vista_DigitoVerificador";
            this.Load += new System.EventHandler(this.Vista_DigitoVerificador_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnActualizarDigitos;
        private System.Windows.Forms.Button btnRealizarRestore;
    }
}