using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Gestion_Instituto.Formularios
{
    public partial class VerUsuarios : Form
    {
        string connectionString = Global.CADENA_CONEXION;
        public VerUsuarios()
        {
            InitializeComponent();
            BtnDarBaja();
            Estilo.AplicarTodo(this);
            MaximumSize = Size;
        }
        public void BtnDarAlta()
        {
            btnDarDeAlta.Visible = true;
        }
        public void BtnDarAlta2()
        {
            btnDarDeAlta.Visible = false;
        }
        public void BtnDarBaja()
        {
            btnDardDeBaja.Visible = true;
        }
        public void BtnDarBaja2()
        {
            btnDardDeBaja.Visible = false;
        }


        private void VerUsuarios_Load(object sender, EventArgs e)
        {
            txtUsuario.ReadOnly = true;
            txtContraseña.ReadOnly = true;
            comboBoxRol.Enabled = false;

            if (dataGridView1.Columns.Count > 0)
            {
                dataGridView1.Columns[4].Visible = false;
            }
        }


        public void UsuariosActivos()
        {
            string query = "SELECT * FROM Usuarios WHERE Baja = 0";

            // Crear la conexión y el comando
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    // Abrir la conexión
                    connection.Open();

                    // Crear el adaptador con la consulta SQL
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);

                    // Crear una DataTable para almacenar los resultados
                    DataTable dataTable = new DataTable();

                    // Llenar el DataTable con los datos de la consulta
                    dataAdapter.Fill(dataTable);

                    // Asignar el DataTable al DataGridView
                    dataGridView1.DataSource = dataTable;
                    //  CargarDatos();


                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar los datos: {ex.Message}");
                }
            }

        }

        public void UsuarioInactivos()
        {
            // BtnDarAlta();
            string query = "SELECT * FROM Usuarios WHERE Baja = 1";

            // Crear la conexión y el comando
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    // Abrir la conexión
                    connection.Open();

                    // Crear el adaptador con la consulta SQL
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);

                    // Crear una DataTable para almacenar los resultados
                    DataTable dataTable = new DataTable();

                    // Llenar el DataTable con los datos de la consulta
                    dataAdapter.Fill(dataTable);

                    // Asignar el DataTable al DataGridView
                    dataGridView1.DataSource = dataTable;
                    // CargarDatos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar los datos: {ex.Message}");
                }
            }

        }

        private void DarDeBajaPersonal(int usuarioID)
        {
            //string connectionString = "tu_cadena_de_conexion"; // Asegúrate de que la cadena de conexión sea correcta
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                try
                {
                    conexion.Open();
                    // Actualizar solo el usuario con el ID correspondiente
                    string query = "UPDATE Usuarios SET Baja = 1 WHERE ID_Login = @ID_Login AND Rol != 'alumno'";
                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@ID_Login", usuarioID); // Parámetro para el ID

                        // Ejecutar el comando
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("El Personal ha sido dado de baja exitosamente.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al dar de baja al alumno: " + ex.Message);
                }
            }
        }
        private void DarDeBajaAlumno(int usuarioID)
        {

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                try
                {
                    conexion.Open();
                    // Actualizar solo el usuario con el ID correspondiente
                    string query = "UPDATE Usuarios SET Baja = 1 WHERE ID_Login = @ID_Login AND Rol = 'alumno'";
                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@ID_Login", usuarioID); // Parámetro para el ID

                        // Ejecutar el comando
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("El alumno ha sido dado de baja exitosamente.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al dar de baja al alumno: " + ex.Message);
                }
            }
        }
        private void DarDeAltaPersonal(int usuarioID)
        {
            //string connectionString = "tu_cadena_de_conexion"; // Asegúrate de que la cadena de conexión sea correcta
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                try
                {
                    conexion.Open();
                    // Actualizar solo el usuario con el ID correspondiente
                    string query = "UPDATE Usuarios SET Baja = 0 WHERE ID_Login = @ID_Login AND Rol != 'alumno'";
                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@ID_Login", usuarioID); // Parámetro para el ID

                        // Ejecutar el comando
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("El Personal ha sido dado de Alta exitosamente.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al dar de Alta al alumno: " + ex.Message);
                }
            }
        }
        private void DarDeAltaAlumno(int usuarioID)
        {

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                try
                {
                    conexion.Open();
                    // Actualizar solo el usuario con el ID correspondiente
                    string query = "UPDATE Usuarios SET Baja = 0 WHERE ID_Login = @ID_Login AND Rol = 'alumno'";
                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@ID_Login", usuarioID); // Parámetro para el ID

                        // Ejecutar el comando
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("El alumno ha sido dado de Alta exitosamente.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al dar de Alta al alumno: " + ex.Message);
                }
            }
        }
        private void btnVolverMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDardDeBaja_Click(object sender, EventArgs e)

        {
            //NO PUEDO CAPTURAR EL ERROR DE LA FILA EN BLANCO DEL DATAGRIDVIEW
            try
            {

                if (dataGridView1.SelectedRows.Count > 0)
                {
                    // Obtengo el valor de la columna 'Rol'
                    string rol = dataGridView1.SelectedRows[0].Cells["Rol"].Value.ToString();

                    int usuarioID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID_Login"].Value);

                    if (rol == "administrador")
                    {
                        MessageBox.Show("No se puede dar de baja el usuario administrador.");
                        return;
                    }

                    if (rol == "alumno")
                    {
                        DarDeBajaAlumno(usuarioID);
                        UsuariosActivos();
                    }
                    else if (rol != "alumno")
                    {
                        DarDeBajaPersonal(usuarioID);
                        UsuariosActivos();
                    }

                }
                else
                {
                    MessageBox.Show("Por favor, selecciona una fila primero.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al dar de baja al alumno: " + ex.Message);
            }

        }
        private void chkVerInactivos_CheckedChanged(object sender, EventArgs e)
        {
            if (chkVerInactivos.Checked)
            {
                UsuarioInactivos(); // Método cuando el checkbox está marcado
                BtnDarAlta();
                BtnDarBaja2();
            }
            else
            {
                UsuariosActivos(); // Método cuando el checkbox está desmarcado
                BtnDarBaja();
                BtnDarAlta2();
            }
            // ^ auch mis ojos...



            btnModificar.Enabled = !btnModificar.Enabled; // <- asi se hace, no esa cosa! ^ XD
        }


        private void btnDarDeAlta_Click(object sender, EventArgs e)
        {

            //NO PUEDO CAPTURAR EL ERROR DE LA FILA EN BLANCO DEL DATAGRIDVIEW
            try
            {

                if (dataGridView1.SelectedRows.Count > 0)
                {
                    // Obtengo el valor de la columna 'Rol'
                    string rol = dataGridView1.SelectedRows[0].Cells["Rol"].Value.ToString();

                    int usuarioID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID_Login"].Value);

                    if (rol == "alumno")
                    {
                        DarDeAltaAlumno(usuarioID);
                        UsuarioInactivos();
                    }
                    else if (rol != "alumno")
                    {
                        DarDeAltaPersonal(usuarioID);
                        UsuarioInactivos();
                    }

                }
                else
                {
                    MessageBox.Show("Por favor, selecciona una fila primero.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al dar de baja al alumno: " + ex.Message);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            //   bool estado = (bool)(dataGridView1.SelectedRows[0].Cells["Baja"].Value);
            bool estado = (bool)(dataGridView1.CurrentRow.Cells["Baja"].Value);
            // Cambiar el color de las letras del TextBox según el valor de la variable estado
            if (estado)
            {
                txtEstado.ForeColor = Color.Red;   // Si es "Inactivo", poner rojo
            }
            else
            {
                txtEstado.ForeColor = Color.Green;  // Si es "Activo", poner verde
            }
            txtEstado.Text = estado ? "Inactivo" : "Activo";
            txtID.Text = dataGridView1.CurrentRow.Cells["ID_Login"].Value.ToString();
            txtUsuario.Text = dataGridView1.CurrentRow.Cells["Usuario"].Value.ToString();
            txtContraseña.Text = dataGridView1.CurrentRow.Cells["Pass"].Value.ToString();
            string rol = dataGridView1.CurrentRow.Cells["Rol"].Value.ToString();
            comboBoxRol.Text = rol; // Asignar el valor al ComboBox


        }

        private void btnCrearAlumno_Click(object sender, EventArgs e)
        {
            // Crear una instancia del segundo formulario
            FormCargarPersonas formAgregarAlumno = new FormCargarPersonas();
            formAgregarAlumno.TipoSeleccion = "Alumno";
            formAgregarAlumno.GroupBoxCarrera();
            formAgregarAlumno.FechaDeHoy();
            formAgregarAlumno.lblFechaParaAlumno();
            formAgregarAlumno.MostrarBotonActualizar();
            formAgregarAlumno.OcultarComboBox5();
            formAgregarAlumno.ShowDialog();
        }


        private void CambiarEdicion()
        {
            txtUsuario.ReadOnly = !txtUsuario.ReadOnly;
            txtContraseña.ReadOnly = !txtContraseña.ReadOnly;

            btnGuardarCambios.Enabled = !btnGuardarCambios.Enabled;
            btnGuardarCambios.Visible = !btnGuardarCambios.Visible;
            btnCancelar.Enabled = !btnCancelar.Enabled;
            btnCancelar.Visible = !btnCancelar.Visible;

            btnModificar.Enabled = !btnModificar.Enabled;
            btnModificar.Visible = !btnModificar.Visible;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            CambiarEdicion();

            // No permitir cambiar el rol del usuario admin original del programa
            if ((int)dataGridView1.SelectedRows[0].Cells["ID_Login"].Value == 1)
                comboBoxRol.Enabled = false;
            else
                comboBoxRol.Enabled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            CambiarEdicion();
            comboBoxRol.Enabled = false;

            dataGridView1_SelectionChanged(sender, new EventArgs());
        }


        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            if (comboBoxRol.SelectedIndex == -1)
            {
                errorProvider.SetError(comboBoxRol, "Debe seleccionar el rol");
                return;
            }

            try
            {

                if (dataGridView1.SelectedRows.Count > 0)
                {
                    // Obtengo el valor de la columna 'Rol'
                    string rol = dataGridView1.SelectedRows[0].Cells["Rol"].Value.ToString();

                    using (SqlConnection conexion = new SqlConnection(connectionString))
                    {
                        try
                        {

                            conexion.Open();

                            using (SqlCommand comandoSql = new SqlCommand("sp_ActualizarUsuario", conexion))
                            {
                                int estado = 0;
                                // Definir el comando como un procedimiento almacenado
                                comandoSql.CommandType = CommandType.StoredProcedure;

                                // Agrego parámetros y sus valores
                                comandoSql.Parameters.AddWithValue("@Usuario ", txtUsuario.Text);
                                comandoSql.Parameters.AddWithValue("@ID_Login ", txtID.Text);
                                comandoSql.Parameters.AddWithValue("@Pass", txtContraseña.Text);
                                comandoSql.Parameters.AddWithValue("@Rol", comboBoxRol.Text);

                                comandoSql.ExecuteNonQuery();

                                MessageBox.Show("Usuario actualizado correctamente");
                                UsuariosActivos();
                                //   LimpiarCampos();
                                conexion.Close();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Por favor, selecciona una fila primero.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el Usuario: " + ex.Message);
            }

            CambiarEdicion();
            comboBoxRol.Enabled = false;
        }


    }
}
