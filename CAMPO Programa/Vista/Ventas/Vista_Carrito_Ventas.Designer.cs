namespace Vista.Ventas
{
    partial class Vista_Carrito_Ventas
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
            this.label2 = new System.Windows.Forms.Label();
            this.gridCarrito = new System.Windows.Forms.DataGridView();
            this.NombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listProductos = new System.Windows.Forms.ListBox();
            this.txtCantidad = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAceptarProducto = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProductoBuscar = new System.Windows.Forms.TextBox();
            this.btnContinuarVenta = new System.Windows.Forms.Button();
            this.btnBorrarCarrito = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gridCarrito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(42, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 17);
            this.label2.TabIndex = 61;
            this.label2.Text = "Lista de Productos";
            // 
            // gridCarrito
            // 
            this.gridCarrito.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gridCarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCarrito.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreProducto,
            this.Cantidad,
            this.Precio,
            this.SubTotal});
            this.gridCarrito.Location = new System.Drawing.Point(16, 16);
            this.gridCarrito.Name = "gridCarrito";
            this.gridCarrito.Size = new System.Drawing.Size(483, 344);
            this.gridCarrito.TabIndex = 68;
            // 
            // NombreProducto
            // 
            this.NombreProducto.HeaderText = "Nombre Producto";
            this.NombreProducto.Name = "NombreProducto";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Width = 70;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.Width = 80;
            // 
            // SubTotal
            // 
            this.SubTotal.HeaderText = "SubTotal";
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.Width = 80;
            // 
            // listProductos
            // 
            this.listProductos.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listProductos.FormattingEnabled = true;
            this.listProductos.ItemHeight = 17;
            this.listProductos.Location = new System.Drawing.Point(45, 99);
            this.listProductos.Name = "listProductos";
            this.listProductos.Size = new System.Drawing.Size(288, 344);
            this.listProductos.TabIndex = 59;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(45, 519);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(165, 20);
            this.txtCantidad.TabIndex = 67;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(381, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 60;
            this.label1.Text = "Carrito";
            // 
            // btnAceptarProducto
            // 
            this.btnAceptarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(129)))), ((int)(((byte)(48)))));
            this.btnAceptarProducto.FlatAppearance.BorderSize = 0;
            this.btnAceptarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnAceptarProducto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAceptarProducto.Location = new System.Drawing.Point(237, 500);
            this.btnAceptarProducto.Name = "btnAceptarProducto";
            this.btnAceptarProducto.Size = new System.Drawing.Size(96, 39);
            this.btnAceptarProducto.TabIndex = 66;
            this.btnAceptarProducto.Text = "Aceptar";
            this.btnAceptarProducto.UseVisualStyleBackColor = false;
            this.btnAceptarProducto.Click += new System.EventHandler(this.btnAceptarProducto_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 502);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 62;
            this.label3.Text = "Cantidad";
            // 
            // txtProductoBuscar
            // 
            this.txtProductoBuscar.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductoBuscar.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtProductoBuscar.Location = new System.Drawing.Point(45, 476);
            this.txtProductoBuscar.Name = "txtProductoBuscar";
            this.txtProductoBuscar.Size = new System.Drawing.Size(165, 21);
            this.txtProductoBuscar.TabIndex = 65;
            this.txtProductoBuscar.Text = "Producto";
            // 
            // btnContinuarVenta
            // 
            this.btnContinuarVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(129)))), ((int)(((byte)(48)))));
            this.btnContinuarVenta.FlatAppearance.BorderSize = 0;
            this.btnContinuarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinuarVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnContinuarVenta.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnContinuarVenta.Location = new System.Drawing.Point(424, 377);
            this.btnContinuarVenta.Name = "btnContinuarVenta";
            this.btnContinuarVenta.Size = new System.Drawing.Size(75, 46);
            this.btnContinuarVenta.TabIndex = 63;
            this.btnContinuarVenta.Text = "Continuar Venta";
            this.btnContinuarVenta.UseVisualStyleBackColor = false;
            this.btnContinuarVenta.Click += new System.EventHandler(this.btnContinuarVenta_Click);
            // 
            // btnBorrarCarrito
            // 
            this.btnBorrarCarrito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(129)))), ((int)(((byte)(48)))));
            this.btnBorrarCarrito.FlatAppearance.BorderSize = 0;
            this.btnBorrarCarrito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrarCarrito.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnBorrarCarrito.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBorrarCarrito.Location = new System.Drawing.Point(329, 377);
            this.btnBorrarCarrito.Name = "btnBorrarCarrito";
            this.btnBorrarCarrito.Size = new System.Drawing.Size(75, 46);
            this.btnBorrarCarrito.TabIndex = 64;
            this.btnBorrarCarrito.Text = "Borrar Carrito";
            this.btnBorrarCarrito.UseVisualStyleBackColor = false;
            this.btnBorrarCarrito.Click += new System.EventHandler(this.btnBorrarCarrito_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.AutoEllipsis = true;
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(129)))), ((int)(((byte)(48)))));
            this.btnRefresh.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(16)))), ((int)(((byte)(48)))));
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(20)))), ((int)(((byte)(57)))));
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRefresh.Location = new System.Drawing.Point(237, 473);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(96, 21);
            this.btnRefresh.TabIndex = 83;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 456);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 84;
            this.label4.Text = "Nombre";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.gridCarrito);
            this.panel1.Controls.Add(this.btnBorrarCarrito);
            this.panel1.Controls.Add(this.btnContinuarVenta);
            this.panel1.Location = new System.Drawing.Point(384, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(514, 440);
            this.panel1.TabIndex = 85;
            // 
            // Vista_Carrito_Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(228)))));
            this.ClientSize = new System.Drawing.Size(945, 660);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listProductos);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAceptarProducto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtProductoBuscar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Vista_Carrito_Ventas";
            this.Text = "Vista_Carrito_Ventas";
            this.Load += new System.EventHandler(this.Vista_Carrito_Ventas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridCarrito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView gridCarrito;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.ListBox listProductos;
        private System.Windows.Forms.NumericUpDown txtCantidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAceptarProducto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProductoBuscar;
        private System.Windows.Forms.Button btnContinuarVenta;
        private System.Windows.Forms.Button btnBorrarCarrito;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
    }
}