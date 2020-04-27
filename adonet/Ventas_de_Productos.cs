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
    public partial class Ventas_de_Productos : Form
    {
        Conexion_db objConexion = new Conexion_db();
        int posicion = 0;
        string accion = "nuevo";
        DataTable tbl = new DataTable();
        public Ventas_de_Productos()
        {
            

            InitializeComponent();
        }

   
    private void Ventas_de_Productos_Load(object sender, EventArgs e)
        {
            actualizarDs();
            mostrarDatos();
        }
        void actualizarDs()
        {
            tbl = objConexion.obtener_datos().Tables["ventas"];
            tbl.PrimaryKey = new DataColumn[] { tbl.Columns["idVenta"] };
        }
        void mostrarDatos()
        {
            try
            {
                

                lblidVenta.Text = tbl.Rows[posicion].ItemArray[0].ToString();
                txtnfactura.Text = tbl.Rows[posicion].ItemArray[2].ToString();
                txtfecha.Text = tbl.Rows[posicion].ItemArray[3].ToString();
                txttipodepago.Text = tbl.Rows[posicion].ItemArray[4].ToString();
                txttipodefactura.Text = tbl.Rows[posicion].ItemArray[5].ToString();

                lblnregistros.Text = (posicion + 1) + " de " + tbl.Rows.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No hay Datos que mostrar " + ex.Message, "Registros de Venta",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar_cajas();
            }
        }
        void limpiar_cajas()
        {
            txtnfactura.Text = "";
            txtfecha.Text = "";
            txttipodepago.Text = "";
            txttipodefactura.Text = "";
        }
        void controles(Boolean valor)
        {
            grbnavegacion.Enabled = valor;
            btneliminar.Enabled = valor;
            btnbuscar.Enabled = valor;
            grbDatosVenta.Enabled = !valor;
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            if (btnnuevo.Text == "Nuevo")
            {
                btnnuevo.Text = "Guardar";
                btnmodificar.Text = "Cancelar";
                accion = "nuevo";

                limpiar_cajas();
                controles(false);
            }
            else
            { 
                String[] valores = {
                    lblidVenta.Text,
                    txtnfactura.Text,
                    txtfecha.Text,
                    txttipodepago.Text,
                    txttipodefactura.Text
                };
                objConexion.Ventas_de_Productos(valores, accion);
                actualizarDs();
                posicion = tbl.Rows.Count - 1;
                mostrarDatos();

                controles(true);

                btnnuevo.Text = "Nuevo";
                btnmodificar.Text = "Modificar";
            }
        }

        private void btnprimero_Click(object sender, EventArgs e)
        {
            posicion = 0;
            mostrarDatos();
        }

        private void btnanterior_Click(object sender, EventArgs e)
        {
            if (posicion > 0)
            {
                posicion--;
                mostrarDatos();
            }
            else
            {
                MessageBox.Show("Primer Registro...", "Registros de Venta",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnsiguiente_Click(object sender, EventArgs e)
        {
            if (posicion < tbl.Rows.Count - 1)
            {
                posicion++;
                mostrarDatos();
            }
            else
            {
                MessageBox.Show("Ultimo Registro...", "Registros de Venta",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnultimo_Click(object sender, EventArgs e)
        {
            posicion = tbl.Rows.Count - 1;
            mostrarDatos();
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            if (btnmodificar.Text == "Modificar")
            {
                btnnuevo.Text = "Guardar";
                btnmodificar.Text = "Cancelar";
                accion = "modificar";

                controles(false);

                btnnuevo.Text = "Guardar";
                btnmodificar.Text = "Cancelar";

            }
            else
            { 
                controles(true);
                mostrarDatos();

                btnnuevo.Text = "Nuevo";
                btnmodificar.Text = "Modificar";
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            busqueda_ventas frmBusquedaProducto = new busqueda_ventas();
            frmBusquedaProducto.ShowDialog();

            if (frmBusquedaProducto._idVenta > 0)
            {
                posicion = tbl.Rows.IndexOf(tbl.Rows.Find(frmBusquedaProducto._idVenta));
                mostrarDatos();
            }
        }

        private void grbnavegacion_Enter(object sender, EventArgs e)
        {

        }
    }
}
  
 
    
     
