namespace Practica_Git
{
    partial class FormVentas
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
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.txtPrecioUnitario = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblPrecioUnitario = new System.Windows.Forms.Label();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.btnCapturarVenta = new System.Windows.Forms.Button();
            this.dgVentas = new System.Windows.Forms.DataGridView();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.strNombreProducto = new System.Windows.Forms.Label();
            this.grpDatosVenta = new System.Windows.Forms.GroupBox();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Venta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalDeVentas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgVentas)).BeginInit();
            this.grpDatosVenta.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(139, 69);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 26);
            this.txtCantidad.TabIndex = 0;
            // 
            // txtDescuento
            // 
            this.txtDescuento.Location = new System.Drawing.Point(423, 69);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(157, 26);
            this.txtDescuento.TabIndex = 1;
            // 
            // txtPrecioUnitario
            // 
            this.txtPrecioUnitario.Location = new System.Drawing.Point(275, 69);
            this.txtPrecioUnitario.Name = "txtPrecioUnitario";
            this.txtPrecioUnitario.Size = new System.Drawing.Size(100, 26);
            this.txtPrecioUnitario.TabIndex = 2;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(135, 33);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(73, 20);
            this.lblCantidad.TabIndex = 3;
            this.lblCantidad.Text = "Cantidad";
            // 
            // lblPrecioUnitario
            // 
            this.lblPrecioUnitario.AutoSize = true;
            this.lblPrecioUnitario.Location = new System.Drawing.Point(271, 33);
            this.lblPrecioUnitario.Name = "lblPrecioUnitario";
            this.lblPrecioUnitario.Size = new System.Drawing.Size(109, 20);
            this.lblPrecioUnitario.TabIndex = 4;
            this.lblPrecioUnitario.Text = "Precio unitario";
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Location = new System.Drawing.Point(419, 33);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(177, 20);
            this.lblDescuento.TabIndex = 5;
            this.lblDescuento.Text = "Descuento (Porcentaje)";
            // 
            // btnCapturarVenta
            // 
            this.btnCapturarVenta.Location = new System.Drawing.Point(644, 69);
            this.btnCapturarVenta.Name = "btnCapturarVenta";
            this.btnCapturarVenta.Size = new System.Drawing.Size(143, 35);
            this.btnCapturarVenta.TabIndex = 6;
            this.btnCapturarVenta.Text = "Capturar venta";
            this.btnCapturarVenta.UseVisualStyleBackColor = true;
            this.btnCapturarVenta.Click += new System.EventHandler(this.btnCapturarVenta_Click);
            // 
            // dgVentas
            // 
            this.dgVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Producto,
            this.Cantidad,
            this.Precio,
            this.Descuento,
            this.Venta,
            this.TotalDeVentas});
            this.dgVentas.Location = new System.Drawing.Point(47, 186);
            this.dgVentas.Name = "dgVentas";
            this.dgVentas.RowHeadersWidth = 62;
            this.dgVentas.RowTemplate.Height = 28;
            this.dgVentas.Size = new System.Drawing.Size(1362, 289);
            this.dgVentas.TabIndex = 7;
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(29, 69);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(100, 26);
            this.txtNombreProducto.TabIndex = 8;
            // 
            // strNombreProducto
            // 
            this.strNombreProducto.AutoSize = true;
            this.strNombreProducto.Location = new System.Drawing.Point(29, 29);
            this.strNombreProducto.Name = "strNombreProducto";
            this.strNombreProducto.Size = new System.Drawing.Size(65, 20);
            this.strNombreProducto.TabIndex = 9;
            this.strNombreProducto.Text = "Nombre";
            // 
            // grpDatosVenta
            // 
            this.grpDatosVenta.Controls.Add(this.txtCantidad);
            this.grpDatosVenta.Controls.Add(this.strNombreProducto);
            this.grpDatosVenta.Controls.Add(this.lblCantidad);
            this.grpDatosVenta.Controls.Add(this.txtDescuento);
            this.grpDatosVenta.Controls.Add(this.txtNombreProducto);
            this.grpDatosVenta.Controls.Add(this.txtPrecioUnitario);
            this.grpDatosVenta.Controls.Add(this.lblPrecioUnitario);
            this.grpDatosVenta.Controls.Add(this.btnCapturarVenta);
            this.grpDatosVenta.Controls.Add(this.lblDescuento);
            this.grpDatosVenta.Location = new System.Drawing.Point(47, 1);
            this.grpDatosVenta.Name = "grpDatosVenta";
            this.grpDatosVenta.Size = new System.Drawing.Size(813, 156);
            this.grpDatosVenta.TabIndex = 10;
            this.grpDatosVenta.TabStop = false;
            this.grpDatosVenta.Text = "Datos venta";
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.MinimumWidth = 8;
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            this.Producto.Width = 150;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 8;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 150;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.MinimumWidth = 8;
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Width = 150;
            // 
            // Descuento
            // 
            this.Descuento.HeaderText = "Descuento";
            this.Descuento.MinimumWidth = 8;
            this.Descuento.Name = "Descuento";
            this.Descuento.ReadOnly = true;
            this.Descuento.Width = 150;
            // 
            // Venta
            // 
            this.Venta.HeaderText = "Venta";
            this.Venta.MinimumWidth = 8;
            this.Venta.Name = "Venta";
            this.Venta.ReadOnly = true;
            this.Venta.Width = 150;
            // 
            // TotalDeVentas
            // 
            this.TotalDeVentas.HeaderText = "Total de ventas";
            this.TotalDeVentas.MinimumWidth = 8;
            this.TotalDeVentas.Name = "TotalDeVentas";
            this.TotalDeVentas.ReadOnly = true;
            this.TotalDeVentas.Width = 150;
            // 
            // FormVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1421, 598);
            this.Controls.Add(this.grpDatosVenta);
            this.Controls.Add(this.dgVentas);
            this.Name = "FormVentas";
            this.Text = "FormVentas";
            ((System.ComponentModel.ISupportInitialize)(this.dgVentas)).EndInit();
            this.grpDatosVenta.ResumeLayout(false);
            this.grpDatosVenta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.TextBox txtPrecioUnitario;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblPrecioUnitario;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.Button btnCapturarVenta;
        private System.Windows.Forms.DataGridView dgVentas;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.Label strNombreProducto;
        private System.Windows.Forms.GroupBox grpDatosVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Venta;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalDeVentas;
    }
}