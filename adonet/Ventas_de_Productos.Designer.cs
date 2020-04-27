namespace adonet
{
    partial class Ventas_de_Productos
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
            this.grbedicion = new System.Windows.Forms.GroupBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.grbnavegacion = new System.Windows.Forms.GroupBox();
            this.btnultimo = new System.Windows.Forms.Button();
            this.btnsiguiente = new System.Windows.Forms.Button();
            this.btnprimero = new System.Windows.Forms.Button();
            this.btnanterior = new System.Windows.Forms.Button();
            this.grbDatosVenta = new System.Windows.Forms.GroupBox();
            this.txttipodefactura = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblnregistros = new System.Windows.Forms.Label();
            this.lblidVenta = new System.Windows.Forms.Label();
            this.txttipodepago = new System.Windows.Forms.TextBox();
            this.lblmarca = new System.Windows.Forms.Label();
            this.txtfecha = new System.Windows.Forms.TextBox();
            this.lblfecha = new System.Windows.Forms.Label();
            this.txtnfactura = new System.Windows.Forms.TextBox();
            this.lblnfactura = new System.Windows.Forms.Label();
            this.grbedicion.SuspendLayout();
            this.grbnavegacion.SuspendLayout();
            this.grbDatosVenta.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbedicion
            // 
            this.grbedicion.Controls.Add(this.btnbuscar);
            this.grbedicion.Controls.Add(this.btneliminar);
            this.grbedicion.Controls.Add(this.btnmodificar);
            this.grbedicion.Controls.Add(this.btnnuevo);
            this.grbedicion.Location = new System.Drawing.Point(268, 297);
            this.grbedicion.Name = "grbedicion";
            this.grbedicion.Size = new System.Drawing.Size(265, 73);
            this.grbedicion.TabIndex = 17;
            this.grbedicion.TabStop = false;
            this.grbedicion.Text = "Edicion de Venta";
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnbuscar.Location = new System.Drawing.Point(198, 27);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(59, 21);
            this.btnbuscar.TabIndex = 8;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = false;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btneliminar.Location = new System.Drawing.Point(133, 27);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(59, 21);
            this.btneliminar.TabIndex = 7;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = false;
            // 
            // btnmodificar
            // 
            this.btnmodificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnmodificar.Location = new System.Drawing.Point(68, 27);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(59, 21);
            this.btnmodificar.TabIndex = 5;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.UseVisualStyleBackColor = false;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btnnuevo
            // 
            this.btnnuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnnuevo.Location = new System.Drawing.Point(7, 27);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(55, 21);
            this.btnnuevo.TabIndex = 6;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.UseVisualStyleBackColor = false;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // grbnavegacion
            // 
            this.grbnavegacion.Controls.Add(this.btnultimo);
            this.grbnavegacion.Controls.Add(this.btnsiguiente);
            this.grbnavegacion.Controls.Add(this.btnprimero);
            this.grbnavegacion.Controls.Add(this.btnanterior);
            this.grbnavegacion.Location = new System.Drawing.Point(36, 297);
            this.grbnavegacion.Name = "grbnavegacion";
            this.grbnavegacion.Size = new System.Drawing.Size(226, 73);
            this.grbnavegacion.TabIndex = 15;
            this.grbnavegacion.TabStop = false;
            this.grbnavegacion.Text = "Navegacion";
            this.grbnavegacion.Enter += new System.EventHandler(this.grbnavegacion_Enter);
            // 
            // btnultimo
            // 
            this.btnultimo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnultimo.Location = new System.Drawing.Point(181, 27);
            this.btnultimo.Name = "btnultimo";
            this.btnultimo.Size = new System.Drawing.Size(41, 21);
            this.btnultimo.TabIndex = 3;
            this.btnultimo.Text = ">l";
            this.btnultimo.UseVisualStyleBackColor = false;
            this.btnultimo.Click += new System.EventHandler(this.btnultimo_Click);
            // 
            // btnsiguiente
            // 
            this.btnsiguiente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnsiguiente.Location = new System.Drawing.Point(134, 27);
            this.btnsiguiente.Name = "btnsiguiente";
            this.btnsiguiente.Size = new System.Drawing.Size(41, 21);
            this.btnsiguiente.TabIndex = 4;
            this.btnsiguiente.Text = ">";
            this.btnsiguiente.UseVisualStyleBackColor = false;
            this.btnsiguiente.Click += new System.EventHandler(this.btnsiguiente_Click);
            // 
            // btnprimero
            // 
            this.btnprimero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnprimero.Location = new System.Drawing.Point(10, 27);
            this.btnprimero.Name = "btnprimero";
            this.btnprimero.Size = new System.Drawing.Size(41, 21);
            this.btnprimero.TabIndex = 2;
            this.btnprimero.Text = "l<";
            this.btnprimero.UseVisualStyleBackColor = false;
            this.btnprimero.Click += new System.EventHandler(this.btnprimero_Click);
            // 
            // btnanterior
            // 
            this.btnanterior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnanterior.Location = new System.Drawing.Point(57, 27);
            this.btnanterior.Name = "btnanterior";
            this.btnanterior.Size = new System.Drawing.Size(41, 21);
            this.btnanterior.TabIndex = 1;
            this.btnanterior.Text = "<";
            this.btnanterior.UseVisualStyleBackColor = false;
            this.btnanterior.Click += new System.EventHandler(this.btnanterior_Click);
            // 
            // grbDatosVenta
            // 
            this.grbDatosVenta.Controls.Add(this.txttipodefactura);
            this.grbDatosVenta.Controls.Add(this.label2);
            this.grbDatosVenta.Controls.Add(this.lblnregistros);
            this.grbDatosVenta.Controls.Add(this.lblidVenta);
            this.grbDatosVenta.Controls.Add(this.txttipodepago);
            this.grbDatosVenta.Controls.Add(this.lblmarca);
            this.grbDatosVenta.Controls.Add(this.txtfecha);
            this.grbDatosVenta.Controls.Add(this.lblfecha);
            this.grbDatosVenta.Controls.Add(this.txtnfactura);
            this.grbDatosVenta.Controls.Add(this.lblnfactura);
            this.grbDatosVenta.Location = new System.Drawing.Point(36, 12);
            this.grbDatosVenta.Name = "grbDatosVenta";
            this.grbDatosVenta.Size = new System.Drawing.Size(390, 252);
            this.grbDatosVenta.TabIndex = 16;
            this.grbDatosVenta.TabStop = false;
            this.grbDatosVenta.Text = "Datos de venta";
            // 
            // txttipodefactura
            // 
            this.txttipodefactura.Location = new System.Drawing.Point(142, 170);
            this.txttipodefactura.Name = "txttipodefactura";
            this.txttipodefactura.Size = new System.Drawing.Size(220, 20);
            this.txttipodefactura.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "TIPO DE FACTURA:";
            // 
            // lblnregistros
            // 
            this.lblnregistros.AutoSize = true;
            this.lblnregistros.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnregistros.Location = new System.Drawing.Point(266, 66);
            this.lblnregistros.Name = "lblnregistros";
            this.lblnregistros.Size = new System.Drawing.Size(73, 13);
            this.lblnregistros.TabIndex = 13;
            this.lblnregistros.Text = "REGISTROS:";
            // 
            // lblidVenta
            // 
            this.lblidVenta.AutoSize = true;
            this.lblidVenta.Location = new System.Drawing.Point(215, 66);
            this.lblidVenta.Name = "lblidVenta";
            this.lblidVenta.Size = new System.Drawing.Size(21, 13);
            this.lblidVenta.TabIndex = 12;
            this.lblidVenta.Text = "ID:";
            // 
            // txttipodepago
            // 
            this.txttipodepago.Location = new System.Drawing.Point(125, 129);
            this.txttipodepago.Multiline = true;
            this.txttipodepago.Name = "txttipodepago";
            this.txttipodepago.Size = new System.Drawing.Size(199, 22);
            this.txttipodepago.TabIndex = 5;
            // 
            // lblmarca
            // 
            this.lblmarca.AutoSize = true;
            this.lblmarca.Location = new System.Drawing.Point(30, 132);
            this.lblmarca.Name = "lblmarca";
            this.lblmarca.Size = new System.Drawing.Size(89, 13);
            this.lblmarca.TabIndex = 4;
            this.lblmarca.Text = "TIPO DE  PAGO:";
            // 
            // txtfecha
            // 
            this.txtfecha.Location = new System.Drawing.Point(104, 98);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.Size = new System.Drawing.Size(220, 20);
            this.txtfecha.TabIndex = 3;
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.Location = new System.Drawing.Point(30, 101);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(45, 13);
            this.lblfecha.TabIndex = 2;
            this.lblfecha.Text = "FECHA:";
            // 
            // txtnfactura
            // 
            this.txtnfactura.Location = new System.Drawing.Point(104, 63);
            this.txtnfactura.Name = "txtnfactura";
            this.txtnfactura.Size = new System.Drawing.Size(105, 20);
            this.txtnfactura.TabIndex = 1;
            // 
            // lblnfactura
            // 
            this.lblnfactura.AutoSize = true;
            this.lblnfactura.Location = new System.Drawing.Point(30, 66);
            this.lblnfactura.Name = "lblnfactura";
            this.lblnfactura.Size = new System.Drawing.Size(68, 13);
            this.lblnfactura.TabIndex = 0;
            this.lblnfactura.Text = "NFACTURA:";
            // 
            // Ventas_de_Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(554, 396);
            this.Controls.Add(this.grbedicion);
            this.Controls.Add(this.grbnavegacion);
            this.Controls.Add(this.grbDatosVenta);
            this.Name = "Ventas_de_Productos";
            this.Text = "Ventas_de_Productos";
            this.Load += new System.EventHandler(this.Ventas_de_Productos_Load);
            this.grbedicion.ResumeLayout(false);
            this.grbnavegacion.ResumeLayout(false);
            this.grbDatosVenta.ResumeLayout(false);
            this.grbDatosVenta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbedicion;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.GroupBox grbnavegacion;
        private System.Windows.Forms.Button btnultimo;
        private System.Windows.Forms.Button btnsiguiente;
        private System.Windows.Forms.Button btnprimero;
        private System.Windows.Forms.Button btnanterior;
        private System.Windows.Forms.GroupBox grbDatosVenta;
        private System.Windows.Forms.Label lblnregistros;
        private System.Windows.Forms.Label lblidVenta;
        private System.Windows.Forms.TextBox txttipodepago;
        private System.Windows.Forms.Label lblmarca;
        private System.Windows.Forms.TextBox txtfecha;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.TextBox txtnfactura;
        private System.Windows.Forms.Label lblnfactura;
        private System.Windows.Forms.TextBox txttipodefactura;
        private System.Windows.Forms.Label label2;
    }
}