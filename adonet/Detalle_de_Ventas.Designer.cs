namespace adonet
{
    partial class Detalle_de_Ventas
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
            this.grbDatosDetalle = new System.Windows.Forms.GroupBox();
            this.lblnregistros = new System.Windows.Forms.Label();
            this.lblidDetalle = new System.Windows.Forms.Label();
            this.txtdescuento = new System.Windows.Forms.TextBox();
            this.lbldescuento = new System.Windows.Forms.Label();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.lblprecio = new System.Windows.Forms.Label();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.lblcantidad = new System.Windows.Forms.Label();
            this.grbedicion.SuspendLayout();
            this.grbnavegacion.SuspendLayout();
            this.grbDatosDetalle.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbedicion
            // 
            this.grbedicion.Controls.Add(this.btnbuscar);
            this.grbedicion.Controls.Add(this.btneliminar);
            this.grbedicion.Controls.Add(this.btnmodificar);
            this.grbedicion.Controls.Add(this.btnnuevo);
            this.grbedicion.Location = new System.Drawing.Point(264, 297);
            this.grbedicion.Name = "grbedicion";
            this.grbedicion.Size = new System.Drawing.Size(265, 73);
            this.grbedicion.TabIndex = 20;
            this.grbedicion.TabStop = false;
            this.grbedicion.Text = "Edicion de Detalle";
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
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
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
            this.grbnavegacion.Location = new System.Drawing.Point(32, 297);
            this.grbnavegacion.Name = "grbnavegacion";
            this.grbnavegacion.Size = new System.Drawing.Size(226, 73);
            this.grbnavegacion.TabIndex = 18;
            this.grbnavegacion.TabStop = false;
            this.grbnavegacion.Text = "Navegacion";
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
            // grbDatosDetalle
            // 
            this.grbDatosDetalle.Controls.Add(this.lblnregistros);
            this.grbDatosDetalle.Controls.Add(this.lblidDetalle);
            this.grbDatosDetalle.Controls.Add(this.txtdescuento);
            this.grbDatosDetalle.Controls.Add(this.lbldescuento);
            this.grbDatosDetalle.Controls.Add(this.txtprecio);
            this.grbDatosDetalle.Controls.Add(this.lblprecio);
            this.grbDatosDetalle.Controls.Add(this.txtcantidad);
            this.grbDatosDetalle.Controls.Add(this.lblcantidad);
            this.grbDatosDetalle.Location = new System.Drawing.Point(32, 12);
            this.grbDatosDetalle.Name = "grbDatosDetalle";
            this.grbDatosDetalle.Size = new System.Drawing.Size(390, 252);
            this.grbDatosDetalle.TabIndex = 19;
            this.grbDatosDetalle.TabStop = false;
            this.grbDatosDetalle.Text = "Datos de Detalle";
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
            // lblidDetalle
            // 
            this.lblidDetalle.AutoSize = true;
            this.lblidDetalle.Location = new System.Drawing.Point(215, 66);
            this.lblidDetalle.Name = "lblidDetalle";
            this.lblidDetalle.Size = new System.Drawing.Size(21, 13);
            this.lblidDetalle.TabIndex = 12;
            this.lblidDetalle.Text = "ID:";
            // 
            // txtdescuento
            // 
            this.txtdescuento.Location = new System.Drawing.Point(125, 129);
            this.txtdescuento.Multiline = true;
            this.txtdescuento.Name = "txtdescuento";
            this.txtdescuento.Size = new System.Drawing.Size(199, 22);
            this.txtdescuento.TabIndex = 5;
            // 
            // lbldescuento
            // 
            this.lbldescuento.AutoSize = true;
            this.lbldescuento.Location = new System.Drawing.Point(30, 132);
            this.lbldescuento.Name = "lbldescuento";
            this.lbldescuento.Size = new System.Drawing.Size(77, 13);
            this.lbldescuento.TabIndex = 4;
            this.lbldescuento.Text = "DESCUENTO:";
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(104, 98);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(220, 20);
            this.txtprecio.TabIndex = 3;
            // 
            // lblprecio
            // 
            this.lblprecio.AutoSize = true;
            this.lblprecio.Location = new System.Drawing.Point(30, 101);
            this.lblprecio.Name = "lblprecio";
            this.lblprecio.Size = new System.Drawing.Size(50, 13);
            this.lblprecio.TabIndex = 2;
            this.lblprecio.Text = "PRECIO:";
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(104, 63);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(105, 20);
            this.txtcantidad.TabIndex = 1;
            // 
            // lblcantidad
            // 
            this.lblcantidad.AutoSize = true;
            this.lblcantidad.Location = new System.Drawing.Point(30, 66);
            this.lblcantidad.Name = "lblcantidad";
            this.lblcantidad.Size = new System.Drawing.Size(65, 13);
            this.lblcantidad.TabIndex = 0;
            this.lblcantidad.Text = "CANTIDAD:";
            // 
            // Detalle_de_Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(543, 389);
            this.Controls.Add(this.grbedicion);
            this.Controls.Add(this.grbnavegacion);
            this.Controls.Add(this.grbDatosDetalle);
            this.Name = "Detalle_de_Ventas";
            this.Text = "Detalle_de_Ventas";
            this.Load += new System.EventHandler(this.Detalle_de_Ventas_Load);
            this.grbedicion.ResumeLayout(false);
            this.grbnavegacion.ResumeLayout(false);
            this.grbDatosDetalle.ResumeLayout(false);
            this.grbDatosDetalle.PerformLayout();
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
        private System.Windows.Forms.GroupBox grbDatosDetalle;
        private System.Windows.Forms.Label lblnregistros;
        private System.Windows.Forms.Label lblidDetalle;
        private System.Windows.Forms.TextBox txtdescuento;
        private System.Windows.Forms.Label lbldescuento;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.Label lblprecio;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.Label lblcantidad;
    }
}