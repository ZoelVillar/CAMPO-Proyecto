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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTicket = new System.Windows.Forms.RichTextBox();
            this.btnVolverAtras = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ctrol_numMesa)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctrol_numMesa
            // 
            this.ctrol_numMesa.Location = new System.Drawing.Point(150, 92);
            this.ctrol_numMesa.Name = "ctrol_numMesa";
            this.ctrol_numMesa.Size = new System.Drawing.Size(287, 20);
            this.ctrol_numMesa.TabIndex = 0;
            this.ctrol_numMesa.ValueChanged += new System.EventHandler(this.ctrol_numMesa_ValueChanged);
            // 
            // ctrol_nbreMesero
            // 
            this.ctrol_nbreMesero.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F);
            this.ctrol_nbreMesero.Location = new System.Drawing.Point(150, 145);
            this.ctrol_nbreMesero.Name = "ctrol_nbreMesero";
            this.ctrol_nbreMesero.Size = new System.Drawing.Size(287, 21);
            this.ctrol_nbreMesero.TabIndex = 1;
            this.ctrol_nbreMesero.Text = "Nombre Apellido";
            this.ctrol_nbreMesero.TextChanged += new System.EventHandler(this.ctrol_nbreMesero_TextChanged);
            // 
            // ctrol_Comentarios
            // 
            this.ctrol_Comentarios.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F);
            this.ctrol_Comentarios.Location = new System.Drawing.Point(150, 207);
            this.ctrol_Comentarios.Multiline = true;
            this.ctrol_Comentarios.Name = "ctrol_Comentarios";
            this.ctrol_Comentarios.Size = new System.Drawing.Size(287, 195);
            this.ctrol_Comentarios.TabIndex = 2;
            this.ctrol_Comentarios.Text = " ";
            this.ctrol_Comentarios.TextChanged += new System.EventHandler(this.ctrol_Comentarios_TextChanged);
            // 
            // ctrol_tipoPedido
            // 
            this.ctrol_tipoPedido.FormattingEnabled = true;
            this.ctrol_tipoPedido.Items.AddRange(new object[] {
            "Para Llevar",
            "Para Comer en Local"});
            this.ctrol_tipoPedido.Location = new System.Drawing.Point(153, 440);
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
            this.lblNumMesa.Location = new System.Drawing.Point(150, 73);
            this.lblNumMesa.Name = "lblNumMesa";
            this.lblNumMesa.Size = new System.Drawing.Size(113, 17);
            this.lblNumMesa.TabIndex = 4;
            this.lblNumMesa.Text = "Numero de Mesa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(147, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre del Mesero";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(147, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Comentarios";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(150, 420);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tipo de pedido";
            // 
            // btnContinuarVenta
            // 
            this.btnContinuarVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(129)))), ((int)(((byte)(48)))));
            this.btnContinuarVenta.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.btnContinuarVenta.FlatAppearance.BorderSize = 0;
            this.btnContinuarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinuarVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnContinuarVenta.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnContinuarVenta.Location = new System.Drawing.Point(153, 482);
            this.btnContinuarVenta.Name = "btnContinuarVenta";
            this.btnContinuarVenta.Size = new System.Drawing.Size(284, 46);
            this.btnContinuarVenta.TabIndex = 64;
            this.btnContinuarVenta.Text = "Continuar Venta";
            this.btnContinuarVenta.UseVisualStyleBackColor = false;
            this.btnContinuarVenta.Click += new System.EventHandler(this.btnContinuarVenta_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(502, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 68;
            this.label1.Text = "Ticket:";
            // 
            // txtTicket
            // 
            this.txtTicket.Location = new System.Drawing.Point(505, 91);
            this.txtTicket.Name = "txtTicket";
            this.txtTicket.Size = new System.Drawing.Size(213, 436);
            this.txtTicket.TabIndex = 71;
            this.txtTicket.Text = "";
            // 
            // btnVolverAtras
            // 
            this.btnVolverAtras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(129)))), ((int)(((byte)(48)))));
            this.btnVolverAtras.FlatAppearance.BorderSize = 0;
            this.btnVolverAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolverAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnVolverAtras.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnVolverAtras.Location = new System.Drawing.Point(22, 15);
            this.btnVolverAtras.Name = "btnVolverAtras";
            this.btnVolverAtras.Size = new System.Drawing.Size(130, 40);
            this.btnVolverAtras.TabIndex = 72;
            this.btnVolverAtras.Text = "Volver Atras";
            this.btnVolverAtras.UseVisualStyleBackColor = false;
            this.btnVolverAtras.Click += new System.EventHandler(this.btnVolverAtras_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnVolverAtras);
            this.panel1.Controls.Add(this.txtTicket);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ctrol_numMesa);
            this.panel1.Controls.Add(this.ctrol_nbreMesero);
            this.panel1.Controls.Add(this.btnContinuarVenta);
            this.panel1.Controls.Add(this.ctrol_Comentarios);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.ctrol_tipoPedido);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblNumMesa);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(50, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(845, 560);
            this.panel1.TabIndex = 73;
            // 
            // Vista_DatosVenta_Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(945, 660);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Vista_DatosVenta_Ventas";
            this.Text = "Vista_DatosVenta_Ventas";
            this.Load += new System.EventHandler(this.Vista_DatosVenta_Ventas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ctrol_numMesa)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtTicket;
        private System.Windows.Forms.Button btnVolverAtras;
        private System.Windows.Forms.Panel panel1;
    }
}