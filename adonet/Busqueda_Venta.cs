using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adonet
{
    public partial class busqueda_ventas : Form
    {
        Conexion_db objConexion = new Conexion_db();
        internal int _idVenta;

        public busqueda_ventas()
        {
            InitializeComponent();
        }

        private void busqueda_ventas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sistemadebicirepuestosDataSet7.ventas' Puede moverla o quitarla según sea necesario.
            this.ventasTableAdapter1.Fill(this.sistemadebicirepuestosDataSet7.ventas);
            grdBusquedaVenta.DataSource =
               objConexion.obtener_datos().Tables["ventas"].DefaultView;
        }
        void filtrar_datos(String valor)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = grdBusquedaVenta.DataSource;
            grdBusquedaVenta.DataSource = bs;
        }

        private void btnseleccionar_Click(object sender, EventArgs e)
        {
            if (grdBusquedaVenta.RowCount > 0)
            {
                _idVenta = int.Parse(grdBusquedaVenta.CurrentRow.Cells[0].Value.ToString());
                Close();

            }
            else
            {
                MessageBox.Show("NO hay datos que seleccionar", "Busqueda de Venta",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            filtrar_datos(txtbuscar.Text);
        }
    }
    }
    
    
