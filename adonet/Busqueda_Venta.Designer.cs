namespace adonet
{
    partial class busqueda_ventas
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
            this.lblbuscar = new System.Windows.Forms.Label();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnseleccionar = new System.Windows.Forms.Button();
            this.ventasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sistemadebicirepuestosDataSet5 = new adonet.sistemadebicirepuestosDataSet5();
            this.ventasTableAdapter = new adonet.sistemadebicirepuestosDataSet5TableAdapters.ventasTableAdapter();
            this.grdBusquedaVenta = new System.Windows.Forms.DataGridView();
            this.idVentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nfacturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipopagoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipofacturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sistemadebicirepuestosDataSet7 = new adonet.sistemadebicirepuestosDataSet7();
            this.ventasTableAdapter1 = new adonet.sistemadebicirepuestosDataSet7TableAdapters.ventasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ventasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemadebicirepuestosDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdBusquedaVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemadebicirepuestosDataSet7)).BeginInit();
            this.SuspendLayout();
            // 
            // lblbuscar
            // 
            this.lblbuscar.AutoSize = true;
            this.lblbuscar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbuscar.Location = new System.Drawing.Point(28, 15);
            this.lblbuscar.Name = "lblbuscar";
            this.lblbuscar.Size = new System.Drawing.Size(61, 18);
            this.lblbuscar.TabIndex = 12;
            this.lblbuscar.Text = "Buscar:";
            // 
            // txtbuscar
            // 
            this.txtbuscar.BackColor = System.Drawing.SystemColors.Control;
            this.txtbuscar.Location = new System.Drawing.Point(95, 15);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(187, 20);
            this.txtbuscar.TabIndex = 11;
            this.txtbuscar.TextChanged += new System.EventHandler(this.txtbuscar_TextChanged);
            // 
            // btncancelar
            // 
            this.btncancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btncancelar.Location = new System.Drawing.Point(571, 279);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 23);
            this.btncancelar.TabIndex = 14;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = false;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnseleccionar
            // 
            this.btnseleccionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnseleccionar.Location = new System.Drawing.Point(490, 279);
            this.btnseleccionar.Name = "btnseleccionar";
            this.btnseleccionar.Size = new System.Drawing.Size(75, 23);
            this.btnseleccionar.TabIndex = 13;
            this.btnseleccionar.Text = "Seleccionar";
            this.btnseleccionar.UseVisualStyleBackColor = false;
            this.btnseleccionar.Click += new System.EventHandler(this.btnseleccionar_Click);
            // 
            // ventasBindingSource
            // 
            this.ventasBindingSource.DataMember = "ventas";
            this.ventasBindingSource.DataSource = this.sistemadebicirepuestosDataSet5;
            // 
            // sistemadebicirepuestosDataSet5
            // 
            this.sistemadebicirepuestosDataSet5.DataSetName = "sistemadebicirepuestosDataSet5";
            this.sistemadebicirepuestosDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ventasTableAdapter
            // 
            this.ventasTableAdapter.ClearBeforeFill = true;
            // 
            // grdBusquedaVenta
            // 
            this.grdBusquedaVenta.AutoGenerateColumns = false;
            this.grdBusquedaVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdBusquedaVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idVentaDataGridViewTextBoxColumn,
            this.idClienteDataGridViewTextBoxColumn,
            this.nfacturaDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.tipopagoDataGridViewTextBoxColumn,
            this.tipofacturaDataGridViewTextBoxColumn});
            this.grdBusquedaVenta.DataSource = this.ventasBindingSource1;
            this.grdBusquedaVenta.Location = new System.Drawing.Point(12, 48);
            this.grdBusquedaVenta.Name = "grdBusquedaVenta";
            this.grdBusquedaVenta.Size = new System.Drawing.Size(634, 225);
            this.grdBusquedaVenta.TabIndex = 15;
            // 
            // idVentaDataGridViewTextBoxColumn
            // 
            this.idVentaDataGridViewTextBoxColumn.DataPropertyName = "idVenta";
            this.idVentaDataGridViewTextBoxColumn.HeaderText = "idVenta";
            this.idVentaDataGridViewTextBoxColumn.Name = "idVentaDataGridViewTextBoxColumn";
            // 
            // idClienteDataGridViewTextBoxColumn
            // 
            this.idClienteDataGridViewTextBoxColumn.DataPropertyName = "idCliente";
            this.idClienteDataGridViewTextBoxColumn.HeaderText = "idCliente";
            this.idClienteDataGridViewTextBoxColumn.Name = "idClienteDataGridViewTextBoxColumn";
            // 
            // nfacturaDataGridViewTextBoxColumn
            // 
            this.nfacturaDataGridViewTextBoxColumn.DataPropertyName = "nfactura";
            this.nfacturaDataGridViewTextBoxColumn.HeaderText = "nfactura";
            this.nfacturaDataGridViewTextBoxColumn.Name = "nfacturaDataGridViewTextBoxColumn";
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            // 
            // tipopagoDataGridViewTextBoxColumn
            // 
            this.tipopagoDataGridViewTextBoxColumn.DataPropertyName = "tipopago";
            this.tipopagoDataGridViewTextBoxColumn.HeaderText = "tipopago";
            this.tipopagoDataGridViewTextBoxColumn.Name = "tipopagoDataGridViewTextBoxColumn";
            // 
            // tipofacturaDataGridViewTextBoxColumn
            // 
            this.tipofacturaDataGridViewTextBoxColumn.DataPropertyName = "tipofactura";
            this.tipofacturaDataGridViewTextBoxColumn.HeaderText = "tipofactura";
            this.tipofacturaDataGridViewTextBoxColumn.Name = "tipofacturaDataGridViewTextBoxColumn";
            // 
            // ventasBindingSource1
            // 
            this.ventasBindingSource1.DataMember = "ventas";
            this.ventasBindingSource1.DataSource = this.sistemadebicirepuestosDataSet7;
            // 
            // sistemadebicirepuestosDataSet7
            // 
            this.sistemadebicirepuestosDataSet7.DataSetName = "sistemadebicirepuestosDataSet7";
            this.sistemadebicirepuestosDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ventasTableAdapter1
            // 
            this.ventasTableAdapter1.ClearBeforeFill = true;
            // 
            // busqueda_ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(658, 318);
            this.Controls.Add(this.grdBusquedaVenta);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnseleccionar);
            this.Controls.Add(this.lblbuscar);
            this.Controls.Add(this.txtbuscar);
            this.Name = "busqueda_ventas";
            this.Text = "Busqueda_Venta";
            this.Load += new System.EventHandler(this.busqueda_ventas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ventasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemadebicirepuestosDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdBusquedaVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemadebicirepuestosDataSet7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblbuscar;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnseleccionar;
        private sistemadebicirepuestosDataSet5 sistemadebicirepuestosDataSet5;
        private System.Windows.Forms.BindingSource ventasBindingSource;
        private sistemadebicirepuestosDataSet5TableAdapters.ventasTableAdapter ventasTableAdapter;
        private System.Windows.Forms.DataGridView grdBusquedaVenta;
        private sistemadebicirepuestosDataSet7 sistemadebicirepuestosDataSet7;
        private System.Windows.Forms.BindingSource ventasBindingSource1;
        private sistemadebicirepuestosDataSet7TableAdapters.ventasTableAdapter ventasTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nfacturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipopagoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipofacturaDataGridViewTextBoxColumn;
    }
}