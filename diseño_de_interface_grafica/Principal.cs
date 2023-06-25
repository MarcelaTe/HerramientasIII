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
    public partial class Principal1 : MaterialForm
    {
        public Principal1()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
   
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            // Crear una instancia de la vista de productos
            Productos vistaProductos = new Productos();

            // Configurar el tamaño y la posición de la vista de productos para que se ajuste al panel contenedor
            vistaProductos.TopLevel = false;
            vistaProductos.FormBorderStyle = FormBorderStyle.None;
            vistaProductos.Dock = DockStyle.Fill;

            // Agregar la vista de productos al panel contenedor
            pnlContenedor.Controls.Clear(); // Limpiar el contenido previo del panel
            pnlContenedor.Controls.Add(vistaProductos);

            // Mostrar la vista de productos
            vistaProductos.Show();
        }

        private void btnCategorias_Click_1(object sender, EventArgs e)
        {
            // Crear una instancia de la vista de categorias
            Categorias vistaCategorias = new Categorias();

            // Configurar el tamaño y la posición de la vista de categorias para que se ajuste al panel contenedor
            vistaCategorias.TopLevel = false;
            vistaCategorias.FormBorderStyle = FormBorderStyle.None;
            vistaCategorias.Dock = DockStyle.Fill;

            // Agregar la vista de categorias al panel contenedor
            pnlContenedor.Controls.Clear(); // Limpiar el contenido previo del panel
            pnlContenedor.Controls.Add(vistaCategorias);

            // Mostrar la vista de categorias
            vistaCategorias.Show();
        }

        private void btnClientes_Click_1(object sender, EventArgs e)
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

        private void btnFacturación_Click(object sender, EventArgs e)
        {
            // Crear una instancia de la vista de facturas
            Facturas vistaFacturas = new Facturas();

            // Configurar el tamaño y la posición de la vista de facturas para que se ajuste al panel contenedor
            vistaFacturas.TopLevel = false;
            vistaFacturas.FormBorderStyle = FormBorderStyle.None;
            vistaFacturas.Dock = DockStyle.Fill;

            // Agregar la vista de facturas al panel contenedor
            pnlContenedor.Controls.Clear(); // Limpiar el contenido previo del panel
            pnlContenedor.Controls.Add(vistaFacturas);

            // Mostrar la vista de clientes
            vistaFacturas.Show();
        }

        private void btnInformes_Click_1(object sender, EventArgs e)
        {
            // Crear una instancia de la vista de informes
            Informes vistaInformes = new Informes();

            // Configurar el tamaño y la posición de la vista de informes para que se ajuste al panel contenedor
            vistaInformes.TopLevel = false;
            vistaInformes.FormBorderStyle = FormBorderStyle.None;
            vistaInformes.Dock = DockStyle.Fill;

            // Agregar la vista de informes al panel contenedor
            pnlContenedor.Controls.Clear(); // Limpiar el contenido previo del panel
            pnlContenedor.Controls.Add(vistaInformes);

            // Mostrar la vista de informes
            vistaInformes.Show();
        }

        private void btnSeguridad_Click_1(object sender, EventArgs e)
        {
            // Crear una instancia de la vista de seguridad
            Seguridad vistaSeguridad = new Seguridad();

            // Configurar el tamaño y la posición de la vista de seguridad para que se ajuste al panel contenedor
            vistaSeguridad.TopLevel = false;
            vistaSeguridad.FormBorderStyle = FormBorderStyle.None;
            vistaSeguridad.Dock = DockStyle.Fill;

            // Agregar la vista de seguridad al panel contenedor
            pnlContenedor.Controls.Clear(); // Limpiar el contenido previo del panel
            pnlContenedor.Controls.Add(vistaSeguridad);

            // Mostrar la vista de seguridad
            vistaSeguridad.Show();
        }

        private void btnRoles_Click_1(object sender, EventArgs e)
        {
            // Crear una instancia de la vista de roles
            Roles vistaRoles = new Roles();

            // Configurar el tamaño y la posición de la vista de roles para que se ajuste al panel contenedor
            vistaRoles.TopLevel = false;
            vistaRoles.FormBorderStyle = FormBorderStyle.None;
            vistaRoles.Dock = DockStyle.Fill;

            // Agregar la vista de roles al panel contenedor
            pnlContenedor.Controls.Clear(); // Limpiar el contenido previo del panel
            pnlContenedor.Controls.Add(vistaRoles);

            // Mostrar la vista de roles
            vistaRoles.Show();
        }

        private void btnEmpleados_Click_1(object sender, EventArgs e)
        {
            // Crear una instancia de la vista de empleados
            Empleado vistaEmpleados = new Empleado();

            // Configurar el tamaño y la posición de la vista de empleados para que se ajuste al panel contenedor
            vistaEmpleados.TopLevel = false;
            vistaEmpleados.FormBorderStyle = FormBorderStyle.None;
            vistaEmpleados.Dock = DockStyle.Fill;

            // Agregar la vista de empleados al panel contenedor
            pnlContenedor.Controls.Clear(); // Limpiar el contenido previo del panel
            pnlContenedor.Controls.Add(vistaEmpleados);

            // Mostrar la vista de empleados
            vistaEmpleados.Show();
        }

        private void btnAyuda_Click_1(object sender, EventArgs e)
        {
            // Crear una instancia de la vista de ayuda
            Ayuda vistaAyuda = new Ayuda();

            // Configurar el tamaño y la posición de la vista de ayuda para que se ajuste al panel contenedor
            vistaAyuda.TopLevel = false;
            vistaAyuda.FormBorderStyle = FormBorderStyle.None;
            vistaAyuda.Dock = DockStyle.Fill;

            // Agregar la vista de ayuda al panel contenedor
            pnlContenedor.Controls.Clear(); // Limpiar el contenido previo del panel
            pnlContenedor.Controls.Add(vistaAyuda);

            // Mostrar la vista de ayuda
            vistaAyuda.Show();
        }

        private void btnAcerca_Click_1(object sender, EventArgs e)
        {
            // Crear una instancia de la vista de acerca de
            Acerca vistaAcerca = new Acerca();

            // Configurar el tamaño y la posición de la vista de acerca de para que se ajuste al panel contenedor
            vistaAcerca.TopLevel = false;
            vistaAcerca.FormBorderStyle = FormBorderStyle.None;
            vistaAcerca.Dock = DockStyle.Fill;

            // Agregar la vista de acerca de al panel contenedor
            pnlContenedor.Controls.Clear(); // Limpiar el contenido previo del panel
            pnlContenedor.Controls.Add(vistaAcerca);

            // Mostrar la vista de acerca de
            vistaAcerca.Show();
        }
    }
}
