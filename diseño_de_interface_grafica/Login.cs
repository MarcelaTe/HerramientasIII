using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diseño_de_interface_grafica
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void materialSingleLineTextField1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string nombreUsuario = TxtUsuario.Text;
            string contraseña = TxtContraseña.Text;

            // Validar la información de inicio de sesión
            if (nombreUsuario == "admin" && contraseña == "admin")
            {
                // Mostrar la vista principal
                Principal principal = new Principal();
                principal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Nombre de usuario o contraseña incorrectos. Por favor, inténtalo de nuevo.");
            }
        }
    }
}
