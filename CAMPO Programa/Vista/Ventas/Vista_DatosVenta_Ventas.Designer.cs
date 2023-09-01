namespace Vista.Ventas
{
    partial class Vista_DatosVenta_Ventas
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
            this.ctrol_numMesa = new System.Windows.Forms.NumericUpDown();
            this.ctrol_nbreMesero = new System.Windows.Forms.TextBox();
            this.ctrol_Comentarios = new System.Windows.Forms.TextBox();
            this.ctrol_tipoPedido = new System.Windows.Forms.ComboBox();
            this.lblNumMesa = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnContinuarVenta = new System.Windows.Forms.Button();
            this.btnVolverAtras = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textTicket = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ctrol_numMesa)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctrol_numMesa
            // 
            this.ctrol_numMesa.Location = new System.Drawing.Point(88, 86);
            this.ctrol_numMesa.Name = "ctrol_numMesa";
            this.ctrol_numMesa.Size = new System.Drawing.Size(287, 20);
            this.ctrol_numMesa.TabIndex = 0;
            this.ctrol_numMesa.ValueChanged += new System.EventHandler(this.ctrol_numMesa_ValueChanged);
            // 
            // ctrol_nbreMesero
            // 
            this.ctrol_nbreMesero.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F);
            this.ctrol_nbreMesero.Location = new System.Drawing.Point(88, 139);
            this.ctrol_nbreMesero.Name = "ctrol_nbreMesero";
            this.ctrol_nbreMesero.Size = new System.Drawing.Size(287, 21);
            this.ctrol_nbreMesero.TabIndex = 1;
            this.ctrol_nbreMesero.Text = "Nombre Apellido";
            this.ctrol_nbreMesero.TextChanged += new System.EventHandler(this.ctrol_nbreMesero_TextChanged);
            // 
            // ctrol_Comentarios
            // 
            this.ctrol_Comentarios.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F);
            this.ctrol_Comentarios.Location = new System.Drawing.Point(88, 201);
            this.ctrol_Comentarios.Multiline = true;
            this.ctrol_Comentarios.Name = "ctrol_Comentarios";
            this.ctrol_Comentarios.Size = new System.Drawing.Size(287, 195);
            this.ctrol_Comentarios.TabIndex = 2;
            this.ctrol_Comentarios.Text = "Comentarios Adicionales";
            this.ctrol_Comentarios.TextChanged += new System.EventHandler(this.ctrol_Comentarios_TextChanged);
            // 
            // ctrol_tipoPedido
            // 
            this.ctrol_tipoPedido.FormattingEnabled = true;
            this.ctrol_tipoPedido.Items.AddRange(new object[] {
            "Para Llevar",
            "Para Comer en Local"});
            this.ctrol_tipoPedido.Location = new System.Drawing.Point(91, 434);
            this.ctrol_tipoPedido.Name = "ctrol_tipoPedido";
            this.ctrol_tipoPedido.Size = new System.Drawing.Size(284, 21);
            this.ctrol_tipoPedido.TabIndex = 3;
            this.ctrol_tipoPedido.TabStop = false;
            this.ctrol_tipoPedido.SelectedIndexChanged += new System.EventHandler(this.ctrol_tipoPedido_SelectedIndexChanged);
            // 
            // lblNumMesa
            // 
            this.lblNumMesa.AutoSize = true;
            this.lblNumMesa.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNumMesa.Location = new System.Drawing.Point(88, 67);
            this.lblNumMesa.Name = "lblNumMesa";
            this.lblNumMesa.Size = new System.Drawing.Size(113, 17);
            this.lblNumMesa.TabIndex = 4;
            this.lblNumMesa.Text = "Numero de Mesa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(85, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre del Mesero";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(85, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Comentarios";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(88, 414);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tipo de pedido";
            // 
            // btnContinuarVenta
            // 
            this.btnContinuarVenta.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinuarVenta.Location = new System.Drawing.Point(276, 476);
            this.btnContinuarVenta.Name = "btnContinuarVenta";
            this.btnContinuarVenta.Size = new System.Drawing.Size(99, 46);
            this.btnContinuarVenta.TabIndex = 64;
            this.btnContinuarVenta.Text = "Cobrar Venta";
            this.btnContinuarVenta.UseVisualStyleBackColor = true;
            this.btnContinuarVenta.Click += new System.EventHandler(this.btnContinuarVenta_Click);
            // 
            // btnVolverAtras
            // 
            this.btnVolverAtras.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverAtras.Location = new System.Drawing.Point(91, 476);
            this.btnVolverAtras.Name = "btnVolverAtras";
            this.btnVolverAtras.Size = new System.Drawing.Size(99, 46);
            this.btnVolverAtras.TabIndex = 65;
            this.btnVolverAtras.Text = "Volver Atras";
            this.btnVolverAtras.UseVisualStyleBackColor = true;
            this.btnVolverAtras.Click += new System.EventHandler(this.btnVolverAtras_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(567, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 68;
            this.label1.Text = "Ticket:";
            // 
            // textTicket
            // 
            this.textTicket.AutoSize = true;
            this.textTicket.BackColor = System.Drawing.Color.White;
            this.textTicket.Location = new System.Drawing.Point(10, 14);
            this.textTicket.Name = "textTicket";
            this.textTicket.Size = new System.Drawing.Size(35, 13);
            this.textTicket.TabIndex = 69;
            this.textTicket.Text = "label5";
            this.textTicket.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.textTicket);
            this.panel1.Location = new System.Drawing.Point(570, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 436);
            this.panel1.TabIndex = 70;
            // 
            // Vista_DatosVenta_Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(228)))));
            this.ClientSize = new System.Drawing.Size(945, 660);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVolverAtras);
            this.Controls.Add(this.btnContinuarVenta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNumMesa);
            this.Controls.Add(this.ctrol_tipoPedido);
            this.Controls.Add(this.ctrol_Comentarios);
            this.Controls.Add(this.ctrol_nbreMesero);
            this.Controls.Add(this.ctrol_numMesa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Vista_DatosVenta_Ventas";
            this.Text = "Vista_DatosVenta_Ventas";
            this.Load += new System.EventHandler(this.Vista_DatosVenta_Ventas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ctrol_numMesa)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown ctrol_numMesa;
        private System.Windows.Forms.TextBox ctrol_nbreMesero;
        private System.Windows.Forms.TextBox ctrol_Comentarios;
        private System.Windows.Forms.ComboBox ctrol_tipoPedido;
        private System.Windows.Forms.Label lblNumMesa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnContinuarVenta;
        private System.Windows.Forms.Button btnVolverAtras;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label textTicket;
        private System.Windows.Forms.Panel panel1;
    }
}