using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Gestion_Instituto
{

    public partial class FormMostrar : Form
    {
        public string TipoSeleccion { get; set; }

        string connectionString = Global.CADENA_CONEXION;

        public FormMostrar()
        {
            InitializeComponent();
            void CargarDatos()
            {
                if (TipoSeleccion == "Alumno")
                {
                    AlumnosActivos();
                }
                else if (TipoSeleccion == "Personal")
                {
                    PersonalActivo();
                }
            }

            CargarDatos();
            Estilo.AplicarTodo(this);
        }

        public void CargarDatos()
        {
            if (TipoSeleccion == "Alumno")
            {
                AlumnosActivos();
            }
            else if (TipoSeleccion == "Personal")
            {
                PersonalActivo();
            }
        }

        public void ResultadoBusqueda(int idBusqueda)
        {
            // Para cuando es automatico por busqueda
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                int value = (int)dataGridView1.Rows[row.Index].Cells[0].Value;
                if (value == idBusqueda)
                {
                    dataGridView1.Rows[row.Index].Selected = true;
                    btnModificar_Click(this, new EventArgs());
                    break;
                }
            }
        }


        public void DarDeBaja()
        {
            if (TipoSeleccion == "Alumno")
            {
                DarBajaAlumno();
            }
            else if (TipoSeleccion == "Personal")
            {
                DarBajaPersonal();
            }
        }

        public void DarDeAlta()
        {
            if (TipoSeleccion == "Alumno")
            {
                DarAltaAlumno();
            }
            else if (TipoSeleccion == "Personal")
            {
                DarAltaPersonal();
            }
        }
        public void MostrarActivos()
        {
            if (TipoSeleccion == "Alumno")
            {
                AlumnosActivos();
            }
            else if (TipoSeleccion == "Personal")
            {
                PersonalActivo();
            }
        }
        public void MostrarInactivos()
        {
            if (TipoSeleccion == "Alumno")
            {
                AlumnosInactivos();
            }
            else if (TipoSeleccion == "Personal")
            {
                PersonalInactivos();
            }
        }
        public void BtnDarAlta()
        {
            btnDarDeAlta.Enabled = true;
            btnDarDeAlta.Visible = true;
        }
        public void BtnDarAlta2()
        {
            btnDarDeAlta.Enabled = false;
            btnDarDeAlta.Visible = false;
        }
        public void BtnDarBaja()
        {
            btnDardDeBaja.Enabled = true;
            btnDardDeBaja.Visible = true;
        }
        public void BtnDarBaja2()
        {
            btnDardDeBaja.Enabled = false;
            btnDardDeBaja.Visible = false;
        }

        public void AlumnosActivos()
        {
            // string query = "SELECT * FROM Alumnos WHERE Baja = 0";
            string query = "select ID_Matricula as 'Matricula',Apellido, Nombre, DNI,FechaNacimiento as 'Fecha Nacimiento', Mail, Telefono1,Telefono2,Domicilio, FechaInscripcion AS'Fecha Inscripcion', Baja  from Alumnos where Baja=0";

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

        public void AlumnosInactivos()
        {
            // BtnDarAlta();
            // string query = "SELECT * FROM Alumnos WHERE Baja = 1";
            string query = "select ID_Matricula as 'Matricula',Apellido, Nombre, DNI,FechaNacimiento as 'Fecha Nacimiento', Mail, Telefono1,Telefono2,Domicilio, FechaInscripcion AS'Fecha Inscripcion', Baja  from Alumnos where Baja=1";

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
        public void PersonalActivo()
        {

            // string query = "SELECT * FROM Personal WHERE Baja = 0";
            string query = "select ID_Personal as 'ID',Apellido, Nombre, DNI,\r\nFechaNacimiento as 'Fecha Nacimiento', Mail, Telefono1,Telefono2,\r\nDomicilio, Cargo, FechaInicio AS'Fecha Inicio', Baja  from Personal where Baja=0";

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

        private void PersonalInactivos()
        {
            //  string query = "SELECT * FROM Personal WHERE Baja = 1";
            string query = "select ID_Personal as 'ID',Apellido, Nombre, DNI,\r\nFechaNacimiento as 'Fecha Nacimiento', Mail, Telefono1,Telefono2,\r\nDomicilio, Cargo, FechaInicio AS'Fecha Inicio', Baja  from Personal where Baja=1";

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
                    //    CargarDatos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar los datos: {ex.Message}");
                }
            }

        }


        public void DarBajaAlumno()
        {

            // Verificar si hay una fila seleccionada en el DataGridView
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Obtener el DNI de la fila seleccionada
                int dni = (int)(dataGridView1.SelectedRows[0].Cells["DNI"].Value);
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    try
                    {
                        conexion.Open();
                        // Crear un comando para ejecutar el procedimiento almacenado
                        using (SqlCommand cmd = new SqlCommand("sp_DarBajaAlumno", conexion))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@DNI", dni);

                            // Ejecutar el procedimiento
                            cmd.ExecuteNonQuery();

                            // Informar al usuario que la operación fue exitosa
                            MessageBox.Show("El alumno ha sido dado de baja exitosamente.");
                            //    CargarDatos();

                        }
                    }
                    catch (Exception ex)
                    {
                        // Manejar cualquier error que ocurra durante la operación
                        MessageBox.Show("Error al dar de baja al alumno: " + ex.Message);
                    }
                }
            }
            else
            {
                // Si no hay una fila seleccionada, mostrar un mensaje
                MessageBox.Show("Por favor, selecciona un alumno para dar de baja.");
            }
            AlumnosActivos();
        }
        public void DarBajaPersonal()
        {

            // Verificar si hay una fila seleccionada en el DataGridView
            if (dataGridView1.SelectedRows.Count > 0)
            {

                // Obtener el DNI de la fila seleccionada
                int dni = (int)(dataGridView1.SelectedRows[0].Cells["DNI"].Value);
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    try
                    {
                        conexion.Open();
                        // Crear un comando para ejecutar el procedimiento almacenado
                        using (SqlCommand cmd = new SqlCommand("sp_DarBajaPersonal", conexion))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@DNI", dni);

                            // Ejecutar el procedimiento
                            cmd.ExecuteNonQuery();

                            // Informar al usuario que la operación fue exitosa
                            MessageBox.Show("El Personal ha sido dado de baja exitosamente.");
                            //  CargarDatos();

                        }
                    }
                    catch (Exception ex)
                    {
                        // Manejar cualquier error que ocurra durante la operación
                        MessageBox.Show("Error al dar de baja al alumno: " + ex.Message);
                    }
                }
            }
            else
            {
                // Si no hay una fila seleccionada, mostrar un mensaje
                MessageBox.Show("Por favor, selecciona un Personal para dar de baja.");
            }
            PersonalActivo();
        }
        public void DarAltaAlumno()
        {
            // Verificar si hay una fila seleccionada en el DataGridView
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Obtener el DNI de la fila seleccionada
                int dni = (int)(dataGridView1.SelectedRows[0].Cells["DNI"].Value);
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    try
                    {
                        conexion.Open();

                        // Crear un comando para ejecutar el procedimiento almacenado
                        using (SqlCommand cmd = new SqlCommand("sp_DarAltaAlumno", conexion))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@DNI", dni);

                            // Ejecutar el procedimiento
                            cmd.ExecuteNonQuery();

                            // Informar al usuario que la operación fue exitosa
                            MessageBox.Show("El alumno ha sido dado de alta exitosamente.");

                        }
                    }
                    catch (Exception ex)
                    {
                        // Manejar cualquier error que ocurra durante la operación
                        MessageBox.Show("Error al dar de alta al alumno: " + ex.Message);
                    }
                }
            }
            else
            {
                // Si no hay una fila seleccionada, mostrar un mensaje
                MessageBox.Show("Por favor, selecciona un alumno para dar de alta.");
            }
            AlumnosInactivos();
        }
        public void DarAltaPersonal()
        {
            // Verificar si hay una fila seleccionada en el DataGridView
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Obtener el DNI de la fila seleccionada
                int dni = (int)(dataGridView1.SelectedRows[0].Cells["DNI"].Value);
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    try
                    {
                        conexion.Open();

                        // Crear un comando para ejecutar el procedimiento almacenado
                        using (SqlCommand cmd = new SqlCommand("sp_DarAltaPersonal", conexion))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@DNI", dni);

                            // Ejecutar el procedimiento
                            cmd.ExecuteNonQuery();

                            // Informar al usuario que la operación fue exitosa
                            MessageBox.Show("El Personal ha sido dado de alta exitosamente.");

                            // Recargar los datos para reflejar los cambios

                        }
                    }
                    catch (Exception ex)
                    {
                        // Manejar cualquier error que ocurra durante la operación
                        MessageBox.Show("Error al dar de alta alPersonal: " + ex.Message);
                    }
                }
            }
            else
            {
                // Si no hay una fila seleccionada, mostrar un mensaje
                MessageBox.Show("Por favor, selecciona un alumno para dar de alta.");
            }
            MostrarInactivos();
        }
        public void ModificarDatos()
        {

            if (TipoSeleccion == "Alumno")
            {
                ModificarAlumno();
            }
            else if (TipoSeleccion == "Personal")
            {
                ModificarPersona();
            }
        }
        // NO PUEDO PROBAR ESTE METODO   public void ModificarPersona(DataGridViewCellEventArgs e)
        public void ModificarPersona()
        {
            try
            {
                // ESTO NO FUNCIONA
                /* if ( dataGridView1.SelectedRows[0].Index == -1 ||         
                      dataGridView1.SelectedCells[0].Value.ToString() == "")
                 {
                     MessageBox.Show("Error, seleccione una fila para modificar.");
                     return;
                 }*/
                if (dataGridView1.SelectedRows.Count > 0)
                {

                    int idPersonal = (int)(dataGridView1.SelectedRows[0].Cells["ID"].Value);
                    string apellido = dataGridView1.SelectedRows[0].Cells["Apellido"].Value.ToString();
                    string nombre = dataGridView1.SelectedRows[0].Cells["Nombre"].Value.ToString();
                    int dni = (int)(dataGridView1.SelectedRows[0].Cells["DNI"].Value);
                    DateTime fechaNacimiento = (DateTime)(dataGridView1.SelectedRows[0].Cells["Fecha Nacimiento"].Value);
                    string correo = dataGridView1.SelectedRows[0].Cells["Mail"].Value.ToString();
                    string telefono1 = dataGridView1.SelectedRows[0].Cells["Telefono1"].Value.ToString();
                    string telefono2 = dataGridView1.SelectedRows[0].Cells["Telefono2"].Value.ToString();
                    string domicilio = dataGridView1.SelectedRows[0].Cells["Domicilio"].Value.ToString();
                    string cargo = dataGridView1.SelectedRows[0].Cells["Cargo"].Value.ToString();
                    bool estado = (bool)(dataGridView1.SelectedRows[0].Cells["Baja"].Value);
                    DateTime fechaInscripcion = (DateTime)(dataGridView1.SelectedRows[0].Cells["Fecha Inicio"].Value);
                    //Saco todos lo datos de la tabla y lo guardo en el Contructor, y se la páso al Formulario "Cargar"
                    // Abrir el formulario de edición con los datos cargados

                    FormCargarPersonas formModoficarDatos = new FormCargarPersonas(idPersonal, nombre, apellido, correo, dni, telefono1, telefono2, domicilio, fechaNacimiento, fechaInscripcion, cargo, estado);
                    // FormAlumno formVerDatos = new FormAlumno();
                    formModoficarDatos.TipoSeleccion = "Personal";
                    formModoficarDatos.cuadroDNI();
                    formModoficarDatos.FechaDeSql();
                    formModoficarDatos.lblFechaParaPersonlal();
                    formModoficarDatos.MostrarCargo();
                    formModoficarDatos.GroupBoxID_Estado();
                    formModoficarDatos.DesabilitarGuardar();
                    formModoficarDatos.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Error, seleccione una fila para modificar.");
                }
            }
            catch (Exception ex)
            {
                // Manejar cualquier error que ocurra durante la operación
                MessageBox.Show("Error al modificar aPersonal: " + ex.Message);
            }
        }

        public void ModificarAlumno()
        {

            try
            {
                // ESTO NO FUNCIONA
                /* if ( dataGridView1.SelectedRows[0].Index == -1 ||         
                      dataGridView1.SelectedCells[0].Value.ToString() == "")
                 {
                     MessageBox.Show("Error, seleccione una fila para modificar.");
                     return;
                 }*/

                if (dataGridView1.SelectedRows.Count > 0)
                {

                    int idAlumno = (int)(dataGridView1.SelectedRows[0].Cells["Matricula"].Value);
                    string apellido = dataGridView1.SelectedRows[0].Cells["Apellido"].Value.ToString();
                    string nombre = dataGridView1.SelectedRows[0].Cells["Nombre"].Value.ToString();
                    int dni = (int)(dataGridView1.SelectedRows[0].Cells["DNI"].Value);
                    DateTime fechaNacimiento = (DateTime)(dataGridView1.SelectedRows[0].Cells["Fecha Nacimiento"].Value);
                    string correo = dataGridView1.SelectedRows[0].Cells["Mail"].Value.ToString();
                    string telefono1 = dataGridView1.SelectedRows[0].Cells["Telefono1"].Value.ToString();
                    string telefono2 = dataGridView1.SelectedRows[0].Cells["Telefono2"].Value.ToString();
                    string domicilio = dataGridView1.SelectedRows[0].Cells["Domicilio"].Value.ToString();
                    bool estado = (bool)(dataGridView1.SelectedRows[0].Cells["Baja"].Value);

                    DateTime fechaInscripcion = (DateTime)(dataGridView1.SelectedRows[0].Cells["Fecha Inscripcion"].Value);

                    // Abrir el formulario de edición con los datos cargados

                    FormCargarPersonas formModoficarDatos = new FormCargarPersonas(idAlumno, nombre, apellido, correo, dni, telefono1, telefono2, domicilio, fechaNacimiento, fechaInscripcion, estado);
                    // FormAlumno formVerDatos = new FormAlumno();
                    formModoficarDatos.TipoSeleccion = "Alumno";
                    formModoficarDatos.ModificarCarrera();
                    formModoficarDatos.cuadroDNI();
                    formModoficarDatos.FechaDeSql();
                    formModoficarDatos.lblFechaParaAlumno();
                    formModoficarDatos.GroupBoxID_Estado();
                    formModoficarDatos.DesabilitarGuardar();
                    formModoficarDatos.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                // Manejar cualquier error que ocurra durante la operación
                MessageBox.Show("Error al modificar alumno: " + ex.Message);
            }
            // CargarDatos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ModificarDatos();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkVerInactivos_CheckedChanged(object sender, EventArgs e)
        {
            btnNuevo.Enabled = !btnNuevo.Enabled;
            btnModificar.Enabled = !btnModificar.Enabled;

            if (chkVerInactivos.Checked)
            {
                MostrarInactivos(); // Método cuando el checkbox está marcado
                BtnDarAlta();
                BtnDarBaja2();
            }
            else
            {
                MostrarActivos(); // Método cuando el checkbox está desmarcado
                BtnDarBaja();
                BtnDarAlta2();
            }
        }

        private void btnDarDeAlta_Click(object sender, EventArgs e)
        {
            DarDeAlta();
        }

        private void btnDardDeBaja_Click(object sender, EventArgs e)
        {
            DarDeBaja();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ModificarDatos();
        }
    
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (TipoSeleccion == "Personal")
            {
                FormCargarPersonas formCargarPersonal = new FormCargarPersonas();
                formCargarPersonal.TipoSeleccion = "Personal";
                formCargarPersonal.FechaDeHoy();
                formCargarPersonal.lblFechaParaPersonlal();
                formCargarPersonal.MostrarBotonActualizar();
                formCargarPersonal.MostrarCargo();
                formCargarPersonal.ShowDialog();
            }

            if (TipoSeleccion == "Alumno")
            {
                FormCargarPersonas formAgregarAlumno = new FormCargarPersonas();
                formAgregarAlumno.TipoSeleccion = "Alumno";
                formAgregarAlumno.GroupBoxCarrera();
                formAgregarAlumno.lblFechaParaAlumno();
                formAgregarAlumno.FechaDeHoy();
                formAgregarAlumno.MostrarBotonActualizar();
                formAgregarAlumno.OcultarComboBox5();
                formAgregarAlumno.ShowDialog();
            }
        }

    }

}