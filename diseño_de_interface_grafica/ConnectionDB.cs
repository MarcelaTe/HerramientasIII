using System;
using System.Data.SqlClient;

namespace diseño_de_interface_grafica
{
    public static class ConnectionDB
    {
        private static SqlConnection connection;

        public static void InitializeConnection()
        {
            try
            {
                connection = new SqlConnection("Data Source=DESARROLLOU;Initial Catalog=DBFACTURAS;Integrated Security=True");
                connection.Open();
                Console.WriteLine("Conexión exitosa");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al conectar a la base de datos: " + ex.Message);
            }
        }

        public static void CloseConnection()
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
                Console.WriteLine("Conexión cerrada");
            }
        }
    }
}
