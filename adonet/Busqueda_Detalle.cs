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
    public partial class busqueda_detalle : Form
    {
        Conexion_db objConexion = new Conexion_db();
        internal int _idDetalle;
        public busqueda_detalle()
        {
            InitializeComponent();
        }

        private void Busqueda_Detalle_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sistemadebicirepuestosDataSet6.dventas' Puede moverla o quitarla según sea necesario.
            this.dventasTableAdapter.Fill(this.sistemadebicirepuestosDataSet6.dventas);
            grdBusquedaDetalle.DataSource =
              objConexion.obtener_datos().Tables["dventas"].DefaultView;
        }
        void filtrar_datos(String valor)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = grdBusquedaDetalle.DataSource;
            grdBusquedaDetalle.DataSource = bs;
        }
   
        private void btnseleccionar_Click(object sender, EventArgs e)
        {
            if (grdBusquedaDetalle.RowCount > 0)
            {
                _idDetalle = int.Parse(grdBusquedaDetalle.CurrentRow.Cells[0].Value.ToString());
                Close();

            }
            else
            {
                MessageBox.Show("NO hay datos que seleccionar", "Busqueda de Detalle",
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
