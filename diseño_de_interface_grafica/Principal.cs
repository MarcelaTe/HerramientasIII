using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace diseño_de_interface_grafica
{
    public partial class Principal : MaterialForm
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //mostrar formulario clientes
        private void BtnClientes_Click(object sender, EventArgs e)
        {
        }

        private void TapObcionesMenu_Click(object sender, EventArgs e)
        {
            // Crear una instancia de la vista de clientes
            Clientes vistaClientes = new Clientes();

            // Configurar el tamaño y la posición de la vista de clientes para que se ajuste al panel contenedor
            vistaClientes.TopLevel = false;
            vistaClientes.FormBorderStyle = FormBorderStyle.None;
            vistaClientes.Dock = DockStyle.Fill;

            // Agregar la vista de clientes al panel contenedor
            pnlContenedor.Controls.Clear(); // Limpiar el contenido previo del panel
            pnlContenedor.Controls.Add(vistaClientes);

            // Mostrar la vista de clientes
            vistaClientes.Show();

        }
    }
}
