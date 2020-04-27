namespace adonet
{
    partial class busqueda_detalle
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
            this.components = new System.ComponentModel.Container();
            this.grdBusquedaDetalle = new System.Windows.Forms.DataGridView();
            this.idDetalleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idVentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descuentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dventasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sistemadebicirepuestosDataSet6 = new adonet.sistemadebicirepuestosDataSet6();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnseleccionar = new System.Windows.Forms.Button();
            this.lblbuscar = new System.Windows.Forms.Label();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.dventasTableAdapter = new adonet.sistemadebicirepuestosDataSet6TableAdapters.dventasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.grdBusquedaDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dventasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemadebicirepuestosDataSet6)).BeginInit();
            this.SuspendLayout();
            // 
            // grdBusquedaDetalle
            // 
            this.grdBusquedaDetalle.AutoGenerateColumns = false;
            this.grdBusquedaDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdBusquedaDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDetalleDataGridViewTextBoxColumn,
            this.idVentaDataGridViewTextBoxColumn,
            this.idProductoDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn,
            this.precioDataGridViewTextBoxColumn,
            this.descuentoDataGridViewTextBoxColumn});
            this.grdBusquedaDetalle.DataSource = this.dventasBindingSource;
            this.grdBusquedaDetalle.Location = new System.Drawing.Point(12, 66);
            this.grdBusquedaDetalle.Name = "grdBusquedaDetalle";
            this.grdBusquedaDetalle.Size = new System.Drawing.Size(652, 256);
            this.grdBusquedaDetalle.TabIndex = 18;
            // 
            // idDetalleDataGridViewTextBoxColumn
            // 
            this.idDetalleDataGridViewTextBoxColumn.DataPropertyName = "idDetalle";
            this.idDetalleDataGridViewTextBoxColumn.HeaderText = "idDetalle";
            this.idDetalleDataGridViewTextBoxColumn.Name = "idDetalleDataGridViewTextBoxColumn";
            // 
            // idVentaDataGridViewTextBoxColumn
            // 
            this.idVentaDataGridViewTextBoxColumn.DataPropertyName = "idVenta";
            this.idVentaDataGridViewTextBoxColumn.HeaderText = "idVenta";
            this.idVentaDataGridViewTextBoxColumn.Name = "idVentaDataGridViewTextBoxColumn";
            // 
            // idProductoDataGridViewTextBoxColumn
            // 
            this.idProductoDataGridViewTextBoxColumn.DataPropertyName = "idProducto";
            this.idProductoDataGridViewTextBoxColumn.HeaderText = "idProducto";
            this.idProductoDataGridViewTextBoxColumn.Name = "idProductoDataGridViewTextBoxColumn";
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "cantidad";
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "cantidad";
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            // 
            // precioDataGridViewTextBoxColumn
            // 
            this.precioDataGridViewTextBoxColumn.DataPropertyName = "precio";
            this.precioDataGridViewTextBoxColumn.HeaderText = "precio";
            this.precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            // 
            // descuentoDataGridViewTextBoxColumn
            // 
            this.descuentoDataGridViewTextBoxColumn.DataPropertyName = "descuento";
            this.descuentoDataGridViewTextBoxColumn.HeaderText = "descuento";
            this.descuentoDataGridViewTextBoxColumn.Name = "descuentoDataGridViewTextBoxColumn";
            // 
            // dventasBindingSource
            // 
            this.dventasBindingSource.DataMember = "dventas";
            this.dventasBindingSource.DataSource = this.sistemadebicirepuestosDataSet6;
            // 
            // sistemadebicirepuestosDataSet6
            // 
            this.sistemadebicirepuestosDataSet6.DataSetName = "sistemadebicirepuestosDataSet6";
            this.sistemadebicirepuestosDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btncancelar
            // 
            this.btncancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btncancelar.Location = new System.Drawing.Point(589, 329);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 22);
            this.btncancelar.TabIndex = 17;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = false;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnseleccionar
            // 
            this.btnseleccionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnseleccionar.Location = new System.Drawing.Point(508, 329);
            this.btnseleccionar.Name = "btnseleccionar";
            this.btnseleccionar.Size = new System.Drawing.Size(75, 22);
            this.btnseleccionar.TabIndex = 16;
            this.btnseleccionar.Text = "Seleccionar";
            this.btnseleccionar.UseVisualStyleBackColor = false;
            this.btnseleccionar.Click += new System.EventHandler(this.btnseleccionar_Click);
            // 
            // lblbuscar
            // 
            this.lblbuscar.AutoSize = true;
            this.lblbuscar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbuscar.Location = new System.Drawing.Point(37, 20);
            this.lblbuscar.Name = "lblbuscar";
            this.lblbuscar.Size = new System.Drawing.Size(61, 18);
            this.lblbuscar.TabIndex = 15;
            this.lblbuscar.Text = "Buscar:";
            // 
            // txtbuscar
            // 
            this.txtbuscar.BackColor = System.Drawing.SystemColors.Control;
            this.txtbuscar.Location = new System.Drawing.Point(104, 21);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(187, 20);
            this.txtbuscar.TabIndex = 14;
            this.txtbuscar.TextChanged += new System.EventHandler(this.txtbuscar_TextChanged);
            // 
            // dventasTableAdapter
            // 
            this.dventasTableAdapter.ClearBeforeFill = true;
            // 
            // busqueda_detalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(687, 363);
            this.Controls.Add(this.grdBusquedaDetalle);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnseleccionar);
            this.Controls.Add(this.lblbuscar);
            this.Controls.Add(this.txtbuscar);
            this.Name = "busqueda_detalle";
            this.Text = "Busqueda_Detalle";
            this.Load += new System.EventHandler(this.Busqueda_Detalle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdBusquedaDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dventasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemadebicirepuestosDataSet6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdBusquedaDetalle;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnseleccionar;
        private System.Windows.Forms.Label lblbuscar;
        private System.Windows.Forms.TextBox txtbuscar;
        private sistemadebicirepuestosDataSet6 sistemadebicirepuestosDataSet6;
        private System.Windows.Forms.BindingSource dventasBindingSource;
        private sistemadebicirepuestosDataSet6TableAdapters.dventasTableAdapter dventasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDetalleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descuentoDataGridViewTextBoxColumn;
    }
}