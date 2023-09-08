namespace Vista.Bitacora
{
    partial class Vista_BitacoraCambios
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grillaBitacoraCambios = new System.Windows.Forms.Label();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Accion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TablaAfectada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CampoAnterior = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CampoActual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Usuario,
            this.Accion,
            this.TablaAfectada,
            this.CampoAnterior,
            this.CampoActual,
            this.Fecha});
            this.dataGridView1.Location = new System.Drawing.Point(40, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(863, 470);
            this.dataGridView1.TabIndex = 1;
            // 
            // grillaBitacoraCambios
            // 
            this.grillaBitacoraCambios.AutoSize = true;
            this.grillaBitacoraCambios.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grillaBitacoraCambios.Location = new System.Drawing.Point(35, 61);
            this.grillaBitacoraCambios.Name = "grillaBitacoraCambios";
            this.grillaBitacoraCambios.Size = new System.Drawing.Size(210, 26);
            this.grillaBitacoraCambios.TabIndex = 2;
            this.grillaBitacoraCambios.Text = "Bitácora de Cambios";
            // 
            // Usuario
            // 
            this.Usuario.HeaderText = "Usuario";
            this.Usuario.Name = "Usuario";
            // 
            // Accion
            // 
            this.Accion.HeaderText = "Acción";
            this.Accion.Name = "Accion";
            // 
            // TablaAfectada
            // 
            this.TablaAfectada.HeaderText = "TablaAfectada";
            this.TablaAfectada.Name = "TablaAfectada";
            // 
            // CampoAnterior
            // 
            this.CampoAnterior.HeaderText = "Campo Anterior";
            this.CampoAnterior.Name = "CampoAnterior";
            // 
            // CampoActual
            // 
            this.CampoActual.HeaderText = "Campo Actual";
            this.CampoActual.Name = "CampoActual";
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            // 
            // Vista_BitacoraCambios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(945, 660);
            this.Controls.Add(this.grillaBitacoraCambios);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Vista_BitacoraCambios";
            this.Text = "Vista_BitacoraCambios";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label grillaBitacoraCambios;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Accion;
        private System.Windows.Forms.DataGridViewTextBoxColumn TablaAfectada;
        private System.Windows.Forms.DataGridViewTextBoxColumn CampoAnterior;
        private System.Windows.Forms.DataGridViewTextBoxColumn CampoActual;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
    }
}