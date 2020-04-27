using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient; 

namespace adonet
{
    class Conexion_db
    {
        SqlConnection miConexion = new SqlConnection();
        SqlCommand comandosSQL = new SqlCommand();
        SqlDataAdapter miAdaptadorDatos = new SqlDataAdapter();

        DataSet ds = new DataSet();

        public Conexion_db()
        {
            String cadena = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\sistemadebicirepuestos.mdf;Integrated Security=True";
            miConexion.ConnectionString = cadena;

        }
        public DataSet obtener_datos()
        {
            ds.Clear();
            comandosSQL.Connection = miConexion;

            comandosSQL.CommandText = "select * from clientes";
            miAdaptadorDatos.SelectCommand = comandosSQL;
            miAdaptadorDatos.Fill(ds, "clientes");

            comandosSQL.CommandText = "select * from productos";
            miAdaptadorDatos.SelectCommand = comandosSQL;
            miAdaptadorDatos.Fill(ds, "productos");

            comandosSQL.CommandText = "select * from dventas";
            miAdaptadorDatos.SelectCommand = comandosSQL;
            miAdaptadorDatos.Fill(ds, "dventas");

            comandosSQL.CommandText = "select * from ventas";
            miAdaptadorDatos.SelectCommand = comandosSQL;
            miAdaptadorDatos.Fill(ds, "ventas");

            


            return ds;

        }
        public void Registro_de_Clientes (String[] datos, String accion)
        {
            String sql = "";
            if (accion == "nuevo")
            {
                sql = "INSERT INTO clientes (codigo,nombre,direccion,telefono,dui,nit) VALUES(" +
                    "'" + datos[1] + "'," +
                    "'" + datos[2] + "'," +
                    "'" + datos[3] + "'," +
                    "'" + datos[4] + "'," +
                    "'" + datos[5] + "'," +
                    "'" + datos[6] + "'" +
                    ")";

            }
            else if (accion == "modificar")
            {
                sql = "UPDATE clientes SET " +
                    "codigo         = '" + datos[1] + "'," +
                    "nombre         = '" + datos[2] + "'," +
                    "direccion      = '" + datos[3] + "'," +
                    "telefono       = '" + datos[4] + "'," +
                    "dui            = '" + datos[5] + "'," +
                    "nit            = '" + datos[6] + "'" +
                    "WHERE idCliente = '" + datos[0] + "'";
            }
            else if (accion == "eliminar")
            {
                sql = "DELETE clientes FROM clientes WHERE idCliente='" + datos[0] + "'";
            }
            procesarSQL(sql);
        }

        public void Productos_de_Repuestos (String[] datos, String accion)
        {
            String sql = "";
            if (accion == "nuevo")
            {
                sql = "INSERT INTO productos (codigo,nombre,marca) VALUES(" +
                    "'" + datos[1] + "'," +
                    "'" + datos[2] + "'," +
                    "'" + datos[3] + "'," +
                     "WHERE idProducto = '" + datos[0] + "'";
            }
            else if (accion == "modificar")
            {
                sql = "UPDATE productos SET " +
                    "codigo         = '" + datos[1] + "'," +
                    "nombre         = '" + datos[2] + "'," +
                    "marca      = '" + datos[3] + "'," +
                    "WHERE idProducto = '" + datos[0] + "'";
            }
            else if (accion == "eliminar")
            {
                sql = "DELETE productos FROM clientes WHERE idProductos='" + datos[0] + "'";
            }
            procesarSQL(sql);
        }
        public void Ventas_de_Productos(String[] datos, String accion)
        {
            String sql = "";
            if (accion == "nuevo")
            {
                sql = "INSERT INTO ventas (nfactura,fecha,tipodepago,tipodefactura) VALUES(" +
                    "'" + datos[1] + "'," +
                    "'" + datos[2] + "'," +
                    "'" + datos[3] + "'," +
                    "'" + datos[4] + "'," +
                     "WHERE idVenta = '" + datos[0] + "'";
            }
            else if (accion == "modificar")
            {
                sql = "UPDATE ventas SET " +
                    "facturas         = '" + datos[1] + "'," +
                    "fecha            = '" + datos[2] + "'," +
                    "tipodepago       = '" + datos[3] + "'," +
                    "tipodefactura    = '" + datos[4] + "'," +
                    "WHERE idVenta    = '" + datos[0] + "'";
            }
            else if (accion == "eliminar")
            {
                sql = "DELETE ventas FROM ventas WHERE idVenta='" + datos[0] + "'";
            }
            procesarSQL(sql);
        }

        public void Detalle_de_Ventas(String[] datos, String accion)
        {
            String sql = "";
            if (accion == "nuevo")
            {
                sql = "INSERT INTO dventas (cantidad,precio,descuento) VALUES(" +
                    "'" + datos[1] + "'," +
                    "'" + datos[2] + "'," +
                    "'" + datos[3] + "'," +
                     "WHERE idDetalle = '" + datos[0] + "'";
            }
            else if (accion == "modificar")
            {
                sql = "UPDATE productos SET " +
                    "cantidad         = '" + datos[1] + "'," +
                    "precio         = '" + datos[2] + "'," +
                    "descuento      = '" + datos[3] + "'," +
                    "WHERE idDetalle = '" + datos[0] + "'";
            }
            else if (accion == "eliminar")
            {
                sql = "DELETE dventas FROM dventas WHERE idDetalle='" + datos[0] + "'";
            }
            procesarSQL(sql);
        }

        void procesarSQL(String sql)
        {
            comandosSQL.Connection = miConexion;
        }
    }       
}
