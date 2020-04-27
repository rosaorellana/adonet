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
    public partial class busqueda_clientes : Form
    {
        Conexion_db objConexion = new Conexion_db();
        public int _idCliente;
        public busqueda_clientes()
        {
            InitializeComponent();
        }

        private void busqueda_clientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sistemadebicirepuestosDataSet2.clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter.Fill(this.sistemadebicirepuestosDataSet2.clientes);
            grdBusquedaClientes.DataSource =
                objConexion.obtener_datos().Tables["clientes"].DefaultView;
        }
        void filtrar_datos(String valor)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = grdBusquedaClientes.DataSource;
            bs.Filter = "nombre like '%" + valor + "%'";
            grdBusquedaClientes.DataSource = bs;
        }

        private void btnseleccionar_Click(object sender, EventArgs e)
        {
            if (grdBusquedaClientes.RowCount > 0)
            {
                _idCliente = int.Parse(grdBusquedaClientes.CurrentRow.Cells[0].Value.ToString());
                Close();

            }
            else
            {
                MessageBox.Show("NO hay datos que seleccionar", "Busqueda de Clientes",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            {
                filtrar_datos(txtbuscar.Text);
            }

        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

  }
    
    

    
