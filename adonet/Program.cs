using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adonet
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Registro_de_Clientes());
            Application.Run(new Productos_de_Repuestos());
            Application.Run(new Detalle_de_Ventas());
            Application.Run(new Ventas_de_Productos());






        }
    }
}
