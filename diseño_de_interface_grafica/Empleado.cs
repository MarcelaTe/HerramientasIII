using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diseño_de_interface_grafica
{
    public partial class Empleado : Form
    {
        public Empleado()
        {
            InitializeComponent();
            BtnCrear.Click += BtnCrear_Click;
            BtnActualizar.Click += BtnActualizar_Click;
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void TxtCodigo_Click(object sender, EventArgs e)
        {

        }

        private void BtnCrear_Click(object sender, EventArgs e)
        {
            // Capturar los valores de los campos en variables
            string nombre = TxtEmpleado.Text;
            int documento = int.Parse(TxtCodigo.Text);
            string sexo = TxtSexo.Text; // Captura el valor del campo de sexo
            string escolaridad = comboBox1.SelectedItem.ToString();
            DateTime fechaNacimiento = monthCalendar1.SelectionRange.Start;
            string direccion = materialSingleLineTextField1.Text;
            string telefono = materialSingleLineTextField2.Text;
            string email = materialSingleLineTextField3.Text;
            string cargo = comboBox2.SelectedItem.ToString(); // Captura el valor del campo de cargo
            string datosAdicionales = richTextBox1.Text;
            DateTime fechaIngreso = monthCalendar2.SelectionRange.Start;
            DateTime? fechaRetiro = monthCalendar3.SelectionRange.Start;

            // Insertar los datos en la tabla TBLEMPLEADO
            try
            {
                SqlConnection cn = new SqlConnection("Data Source=DESARROLLOU;Initial Catalog=DBFACTURAS;Integrated Security=True");
                cn.Open();

                SqlCommand cmd = new SqlCommand("INSERT INTO TBLEMPLEADO (NumDocumento, StrNombre, StrSexo, StrEscolaridad, DtmFechaNacimiento, " +
                                                 "StrDireccion, StrTelefono, StrEmail, StrCargo, StrDatosAdicionales, DtmIngreso, DtmRetiro, DtmFechaModifica) " +
                                                 "VALUES (@Documento, @Nombre, @Sexo, @Escolaridad, @FechaNacimiento, @Direccion, @Telefono, " +
                                                 "@Email, @Cargo, @DatosAdicionales, @Ingreso, @Retiro, @FechaModifica)", cn);

                cmd.Parameters.AddWithValue("@Documento", documento);
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Sexo", sexo);
                cmd.Parameters.AddWithValue("@Escolaridad", escolaridad);
                cmd.Parameters.AddWithValue("@FechaNacimiento", fechaNacimiento);
                cmd.Parameters.AddWithValue("@Direccion", direccion);
                cmd.Parameters.AddWithValue("@Telefono", telefono);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Cargo", cargo);
                cmd.Parameters.AddWithValue("@DatosAdicionales", datosAdicionales);
                cmd.Parameters.AddWithValue("@Ingreso", fechaIngreso);
                cmd.Parameters.AddWithValue("@Retiro", fechaRetiro);
                cmd.Parameters.AddWithValue("@FechaModifica", DateTime.Now);

                cmd.ExecuteNonQuery();

                cn.Close();

                MessageBox.Show("Empleado creado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear el empleado: " + ex.Message);
            }

        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            // Obtener el nombre del empleado que se va a actualizar
            string nombreEmpleado = TxtEmpleado.Text;

            // Buscar el ID del empleado con el mismo nombre
            int idEmpleado = BuscarIdEmpleado(nombreEmpleado);

            // Verificar si se encontró un empleado con el mismo nombre
            if (idEmpleado == -1)
            {
                MessageBox.Show("No se encontró un empleado con el nombre especificado.");
                return;
            }

            int documento = int.Parse(TxtCodigo.Text);
            string sexo = TxtSexo.Text; // Captura el valor del campo de sexo
            string escolaridad = comboBox1.SelectedItem.ToString();
            DateTime fechaNacimiento = monthCalendar1.SelectionRange.Start;
            string direccion = materialSingleLineTextField1.Text;
            string telefono = materialSingleLineTextField2.Text;
            string email = materialSingleLineTextField3.Text;
            string cargo = comboBox2.SelectedItem.ToString(); // Captura el valor del campo de cargo
            string datosAdicionales = richTextBox1.Text;
            DateTime fechaIngreso = monthCalendar2.SelectionRange.Start;
            DateTime? fechaRetiro = monthCalendar3.SelectionRange.Start;

            // Actualizar los datos en la tabla TBLEMPLEADO
            try
            {
                SqlConnection cn = new SqlConnection("Data Source=DESARROLLOU;Initial Catalog=DBFACTURAS;Integrated Security=True");
                cn.Open();

                SqlCommand cmd = new SqlCommand("UPDATE TBLEMPLEADO SET NumDocumento = @Documento, StrSexo = @Sexo, " +
                                                 "StrEscolaridad = @Escolaridad, DtmFechaNacimiento = @FechaNacimiento, StrDireccion = @Direccion, " +
                                                 "StrTelefono = @Telefono, StrEmail = @Email, StrCargo = @Cargo, StrDatosAdicionales = @DatosAdicionales, " +
                                                 "DtmIngreso = @Ingreso, DtmRetiro = @Retiro, DtmFechaModifica = @FechaModifica " +
                                                 "WHERE IdEmpleado = @IdEmpleado", cn);

                cmd.Parameters.AddWithValue("@Documento", documento);
                cmd.Parameters.AddWithValue("@Sexo", sexo);
                cmd.Parameters.AddWithValue("@Escolaridad", escolaridad);
                cmd.Parameters.AddWithValue("@FechaNacimiento", fechaNacimiento);
                cmd.Parameters.AddWithValue("@Direccion", direccion);
                cmd.Parameters.AddWithValue("@Telefono", telefono);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Cargo", cargo);
                cmd.Parameters.AddWithValue("@DatosAdicionales", datosAdicionales);
                cmd.Parameters.AddWithValue("@Ingreso", fechaIngreso);
                cmd.Parameters.AddWithValue("@Retiro", fechaRetiro);
                cmd.Parameters.AddWithValue("@FechaModifica", DateTime.Now);

                cmd.ExecuteNonQuery();

                cn.Close();

                MessageBox.Show("Empleado actualizado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el empleado: " + ex.Message);
            }
        }

        private int BuscarIdEmpleado(string nombreEmpleado)
        {
            int idEmpleado = -1;

            try
            {
                SqlConnection cn = new SqlConnection("Data Source=DESARROLLOU;Initial Catalog=DBFACTURAS;Integrated Security=True");
                cn.Open();

                SqlCommand cmd = new SqlCommand("SELECT IdEmpleado FROM TBLEMPLEADO WHERE StrNombre = @Nombre", cn);
                cmd.Parameters.AddWithValue("@Nombre", nombreEmpleado);

                object result = cmd.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                {
                    idEmpleado = Convert.ToInt32(result);
                }

                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar el empleado: " + ex.Message);
            }

            return idEmpleado;
        }

    }
}
