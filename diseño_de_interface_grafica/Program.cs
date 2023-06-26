using System;
using System.Windows.Forms;

namespace diseño_de_interface_grafica
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ConnectionDB.InitializeConnection();

            Application.Run(new Empleado());

            ConnectionDB.CloseConnection();
        }
    }
}
