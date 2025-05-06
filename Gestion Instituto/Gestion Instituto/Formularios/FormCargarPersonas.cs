using Gestion_Instituto.Clases;
using System;
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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Gestion_Instituto
{
    public partial class FormCargarPersonas : Form
    {
        //
        public string TipoSeleccion { get; set; }
        string connectionString = Global.CADENA_CONEXION;
        public FormCargarPersonas()
        {

            InitializeComponent();


            lblFechaAmigable.Text = DateTime.Today.ToString("dd 'de' MMMM 'del' yyyy");// Amigable para el usuario
            lblFechaHoy.Text = DateTime.Today.ToString();//para guardar
            Estilo.AplicarTodo(this);
            MaximumSize = Size;

        }

        public void FechaDeSql()
        {
            lblFechaSQL.Visible = true;
        }
        public void FechaDeHoy()
        {
            lblFechaAmigable.Visible = true;
        }

        public void CargarNuevo()
        {
            if (TipoSeleccion == "Alumno")
            {
                // VerificarDNI();
                CargarAlumno();
            }
            else if (TipoSeleccion == "Personal")
            {
                CargarPersonal();
            }
        }
        public void GroupBoxCarrera()
        {
            groupBoxCarrera.Visible = true;
        }
        public void GroupBoxID_Estado()
        {
            groupBoxID_Estado.Visible = true;
        }
        public void MostrarCargo()
        {
            groupBoxCargo.Visible = true;
        }
        public void lblFechaParaAlumno()
        {
            lblParaAlumno.Visible = true;
        }
        public void lblFechaParaPersonlal()
        {
            lblFechaAlta.Visible = true;
        }
        public void LimpiarCampos()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtDNI.Clear();
            txtTelefono.Clear();
            txtTelefono2.Clear();
            // txtDNI.Text = "___ - _________ - ___";
            // txtTelefono.Text = "(_____) ___________";
            // txtTelefono2.Text = "(_____) ___________";
            txtCorreo.Clear();
            txtCalle.Clear();
            comboBox1.Text = "Elejir una opcion";
            comboBoxCarreras.Text = "Elejir una Carrera";
            comboBoxElejirAño.Text = "Elejir el Año";
            txtNombre.Focus();
        }
        public void MostrarBotonActualizar()
        {
            btnActualizar.Enabled = false;

        }
        public void OcultarComboBox5()
        {
            groupBoxID_Estado.Visible = false;
        }
        public void DesabilitarGuardar()
        {
            btnCargar.Enabled = false;
        }
        public void cuadroDNI()
        {
            txtDNI.ReadOnly = true;
        }
        public void ModificarCarrera()
        {
            groupBoxCarrera.Visible = true;
        }
        public FormCargarPersonas(int idAlumno, string nombre, string apellido, string correo, int dni, string telefono, string telefono2, string domicilio, DateTime fechaNacimiento, DateTime fechaInscripcion, bool estado)
        {

            InitializeComponent();
            Estilo.AplicarTodo(this);
            MaximumSize = Size;
            btnActualizar.Visible = true;

            // Asignar los datos a los controles del formulario
            txtId.Text = idAlumno.ToString();
            txtNombre.Text = nombre;
            txtApellido.Text = apellido;
            txtCorreo.Text = correo;
            txtDNI.Text = dni.ToString();
            txtTelefono.Text = telefono;
            txtTelefono2.Text = telefono2;
            txtCalle.Text = domicilio;
            dateTimePicker1.Value = fechaNacimiento;
            lblFechaSQL.Text = fechaInscripcion.ToString();
            txtEstado.Text = estado ? "Inactivo" : "Activo";
            if (estado)
            {
                txtEstado.ForeColor = Color.Red;   // Si es "Inactivo", poner rojo
            }
            else
            {
                txtEstado.ForeColor = Color.Green;  // Si es "Activo", poner verde
            }
        }
        public FormCargarPersonas(int idPersonal, string nombre, string apellido, string correo, int dni, string telefono, string telefono2, string domicilio, DateTime fechaNacimiento, DateTime fechaInscripcion, string cargo, bool estado)
        {
            InitializeComponent();
            Estilo.AplicarTodo(this);
            MaximumSize = Size;
            btnActualizar.Visible = true;

            // Asignar los datos a los controles del formulario
            txtId.Text = idPersonal.ToString();
            txtNombre.Text = nombre;
            txtApellido.Text = apellido;
            txtCorreo.Text = correo;
            txtDNI.Text = dni.ToString();
            txtTelefono.Text = telefono;
            txtTelefono2.Text = telefono2;
            txtCalle.Text = domicilio;

            dateTimePicker1.Value = fechaNacimiento;
            lblFechaSQL.Text = fechaInscripcion.ToString();
            txtEstado.Text = estado ? "Inactivo" : "Activo";
            if (estado)
            {
                txtEstado.ForeColor = Color.Red;   // Si es "Inactivo", poner rojo
            }
            else
            {
                txtEstado.ForeColor = Color.Green;  // Si es "Activo", poner verde
            }
        }
        public void ActualizarDatos() //recibo el contrsuctor
        {
            FechaDeSql();
            if (TipoSeleccion == "Alumno")
            {
                ActualizarAlumnos();

            }
            else if (TipoSeleccion == "Personal")
            {
                ActualizarPersonal();
            }
        }

        public void ActualizarAlumnos()
        {

            // Verificamos si los campos de texto están vacíos
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellido.Text) ||
                string.IsNullOrWhiteSpace(txtDNI.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono2.Text) ||
                string.IsNullOrWhiteSpace(txtCorreo.Text) ||
                string.IsNullOrWhiteSpace(txtCalle.Text))
            {
                // Si alguno está vacío, mostramos un mensaje de error
                MessageBox.Show("Todos los campos son obligatorios. Por favor, " +
      "completá todos los datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verifico si son valores numéricos
            if (!int.TryParse(txtDNI.Text, out int dni))
            {
                // Si no son válidos, mostramos un mensaje de error
                MessageBox.Show("Por favor, ingresá valores numéricos válidos en " +
        "El campo DNI.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Si todas las validaciones pasan, procedemos a guardar
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string correo = txtCorreo.Text;
            string telefono = txtTelefono.Text;
            string telefono2 = txtTelefono2.Text;
            string domicilio = txtCalle.Text;

            //Guado la fecha de hoy
            DateTime fechaIncripcion1;

            if (DateTime.TryParse(lblFechaSQL.Text, out fechaIncripcion1))
            { }
            else
            {
                MessageBox.Show("El formato de la fecha es incorrecto.");
            }
            //--------------VALIDAR EL COMBOBOX AÑO--------------
            string valorAño = comboBoxElejirAño.Text;
            if (comboBoxElejirAño.SelectedIndex == -1)
            {
                MessageBox.Show("Debe Elejir un Año");
                return;
            }
            else if (valorAño == "Elejir el Año")
            {

                MessageBox.Show("Debe Elejir un Año");
                return;
            }

            int ComboboxElejirCarrera()
            {

                int seleccion = comboBoxElejirAño.SelectedIndex;
                if (comboBoxElejirAño.SelectedIndex == 0)
                {
                    seleccion = 1;

                }
                else if (comboBoxElejirAño.SelectedIndex == 1)
                {
                    seleccion = 2;

                }
                else
                { seleccion = 3; }
                //  MessageBox.Show("indice es" + seleccion);
                return seleccion;
            }
            string valor = comboBoxCarreras.Text;
            if (comboBoxElejirAño.SelectedIndex == -1)
            {
                MessageBox.Show("Debe Elejir una Carrera");
                return;
            }
            else if (valor == "Elejir una Carrera")
            {

                MessageBox.Show("Debe Elejiruna Carrera");
                return;
            }
            else

            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    try
                    {
                        conexion.Open();
                        using (SqlCommand comandoSql = new SqlCommand("sp_ActualizarAlumnoYCarrera", conexion))
                        {
                            comandoSql.CommandType = CommandType.StoredProcedure;
                            // Agregar los parámetros con los valores desde el formulario
                            comandoSql.Parameters.AddWithValue("@ID_Matricula", txtId.Text);
                            comandoSql.Parameters.AddWithValue("@Nombre", nombre);
                            comandoSql.Parameters.AddWithValue("@Apellido", apellido);
                            comandoSql.Parameters.AddWithValue("@DNI", dni);
                            comandoSql.Parameters.AddWithValue("@Mail", correo);
                            comandoSql.Parameters.AddWithValue("@Telefono1", telefono);
                            comandoSql.Parameters.AddWithValue("@Telefono2", telefono2);
                            comandoSql.Parameters.AddWithValue("@Domicilio", domicilio);
                            comandoSql.Parameters.AddWithValue("@FechaInscripcion", fechaIncripcion1);
                            comandoSql.Parameters.AddWithValue("@FechaNacimiento", dateTimePicker1.MaxDate);
                            comandoSql.Parameters.AddWithValue("@ID_Carrera", FormCargarPersonas.ID_Carrera);
                            comandoSql.Parameters.AddWithValue("@AnioCursada", ComboboxElejirCarrera());

                            // Ejecutar el comando de actualización
                            comandoSql.ExecuteNonQuery();
                            MessageBox.Show("Alumno Actualizado correctamente");
                            FormMostrar mostrar = new FormMostrar();

                            this.Close();

                        }
                    }
                    catch (Exception ex)
                    {
                        // Manejar cualquier excepción
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }
        public void ActualizarPersonal()
        {
            // Verificamos si los campos de texto están vacíos
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellido.Text) ||
                string.IsNullOrWhiteSpace(txtDNI.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono2.Text) ||
                string.IsNullOrWhiteSpace(txtCorreo.Text) ||
                string.IsNullOrWhiteSpace(txtCalle.Text))
            {
                // Si alguno está vacío, mostramos un mensaje de error
                MessageBox.Show("Todos los campos son obligatorios. Por favor, " +
      "completá todos los datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verificamos si los valores numéricos son válidos
            if (!int.TryParse(txtDNI.Text, out int dni))
            {
                // Si no son válidos, mostramos un mensaje de error
                MessageBox.Show("Por favor, ingresá valores numéricos válidos en " +
        "El campo DNI.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Si todas las validaciones pasan, procedemos a guardar
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string correo = txtCorreo.Text;
            string telefono = txtTelefono.Text;
            string telefono2 = txtTelefono2.Text;
            string domicilio = txtCalle.Text;
            //Guado la fecha de hoy
            DateTime fechaIncripcion1;
            if (DateTime.TryParse(lblFechaSQL.Text, out fechaIncripcion1))
            {/*MessageBox.Show("Fecha con exito");*/ }
            else
            {
                MessageBox.Show("El formato de la fecha es incorrecto.");
            }
            //Validar ComoBox Cargo
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Debe Elejir un Cargo");
                return;
            }
            else
            {
                string valor = comboBox1.Text;

                if (valor == "Elejir una opcion")
                {
                    MessageBox.Show("Debe Elejir un Cargo");
                    return;
                }
            }
            //modifique el ComboBox en "ComboBoxStyle" a "DropDownList" sea solo lectura
            string ComboboxCargo()
            {
                // Guardar la selección en una variable string
                string seleccion = comboBox1.SelectedItem.ToString();

                // Verificar qué opción fue seleccionada
                if (seleccion == "personal")
                {
                    seleccion = "personal";
                }
                else if (seleccion == "Profesor")
                {
                    seleccion = "Profesor";
                }

                return seleccion;
            }
            string seleccion = ComboboxCargo();

            string connectionString = Global.CADENA_CONEXION;
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                try
                {
                    conexion.Open();
                    using (SqlCommand comandoSql = new SqlCommand("sp_ActualizarPersonal", conexion))
                    {
                        comandoSql.CommandType = CommandType.StoredProcedure;
                        // Agregar los parámetros con los valores desde el formulario
                        comandoSql.Parameters.AddWithValue("@Nombre", nombre);
                        comandoSql.Parameters.AddWithValue("@Apellido", apellido);
                        comandoSql.Parameters.AddWithValue("@DNI", dni);
                        comandoSql.Parameters.AddWithValue("@Mail", correo);
                        comandoSql.Parameters.AddWithValue("@Telefono1", telefono);
                        comandoSql.Parameters.AddWithValue("@Telefono2", telefono2);
                        comandoSql.Parameters.AddWithValue("@Domicilio", domicilio);
                        comandoSql.Parameters.AddWithValue("@Cargo", seleccion);
                        comandoSql.Parameters.AddWithValue("@FechaInicio", fechaIncripcion1);
                        comandoSql.Parameters.AddWithValue("@FechaNacimiento", dateTimePicker1.MaxDate);

                        comandoSql.ExecuteNonQuery();
                        //Probar si se actualiza la lista...pero no funciona
                        FormMostrar mostrar = new FormMostrar();
                        mostrar.PersonalActivo();

                        MessageBox.Show("Personal Actualizado correctamente");
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    // Manejar cualquier excepción
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        public void CargarAlumno()//---------------------------
        {
            // Primero verifico si el DNI EXISTE
            string dniIngresado = txtDNI.Text;
            bool dniExiste = false;

            try
            {
                string query = "SELECT COUNT(*) FROM Alumnos WHERE DNI = @DNI";

                using (SqlConnection connection = new SqlConnection(Global.CADENA_CONEXION))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Agregar el parámetro @DNI con el valor del DNI ingresado
                        command.Parameters.AddWithValue("@DNI", dniIngresado);

                        // Ejecutar la consulta y verificar si el DNI ya existe
                        int count = (int)command.ExecuteScalar();

                        if (count > 0)
                        {
                            dniExiste = true; // El DNI ya existe
                        }
                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al verificar el DNI: {ex.Message}");
            }

            // SI EXISTE, NO LO DEJO AVANZAR
            if (dniExiste)
            {
                MessageBox.Show("El DNI ya existe. Por favor, ingrese otro.");
                txtDNI.Focus();
                return;
            }
            //SI ES DNI ES NUEVO, AHORA PROCEDO A GUARDARLO 
            else
            {
                //COMINEZO CON LA VERIFICACION 
                if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
               string.IsNullOrWhiteSpace(txtApellido.Text) ||
               string.IsNullOrWhiteSpace(txtDNI.Text) ||
               string.IsNullOrWhiteSpace(txtTelefono.Text) ||
               string.IsNullOrWhiteSpace(txtTelefono2.Text) ||
               string.IsNullOrWhiteSpace(txtCorreo.Text) ||
               string.IsNullOrWhiteSpace(txtCalle.Text))
                {
                    MessageBox.Show("Todos los campos son obligatorios. Por favor, " +
          "completá todos los datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!int.TryParse(txtDNI.Text, out int dni))
                {
                    MessageBox.Show("Por favor, ingresá valores numéricos válidos en " +
            "El campo DNI.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Si todas las validaciones pasan, seguimos
                string nombre = txtNombre.Text;
                string apellido = txtApellido.Text;
                string correo = txtCorreo.Text;
                string telefono = txtTelefono.Text;
                string telefono2 = txtTelefono2.Text;
                string domicilio = txtCalle.Text;
                //Guado la fecha de hoy
                DateTime fechaIncripcion1;

                if (DateTime.TryParse(lblFechaHoy.Text, out fechaIncripcion1))
                { }
                else
                {
                    MessageBox.Show("El formato de la fecha es incorrecto.");
                }
                //--------------VALIDAR EL COMBOBOX AÑO--------------
                string valorAño = comboBoxElejirAño.Text;
                if (comboBoxElejirAño.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe Elejir un Año");
                    return;
                }
                else if (valorAño == "Elejir el Año")
                {

                    MessageBox.Show("Debe Elejir un Año");
                    return;
                }

                int ComboboxElejirCarrera()
                {

                    int seleccion = comboBoxElejirAño.SelectedIndex;
                    // Verificar qué opción fue seleccionada
                    if (comboBoxElejirAño.SelectedIndex == 0)
                    {
                        seleccion = 1;

                    }
                    else if (comboBoxElejirAño.SelectedIndex == 1)
                    {
                        seleccion = 2;

                    }
                    else
                    { seleccion = 3; }
                    //  MessageBox.Show("indice es" + seleccion);
                    return seleccion;
                }

                //Validar ComoBox Carrera
                string valor = comboBoxCarreras.Text;
                if (comboBoxCarreras.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe Elejir una Carrera");
                    return;
                }
                else if (valor == "Elejir una Carrera")
                {

                    MessageBox.Show("Debe Elejir una Carrera");
                    return;
                }
                else

                {


                    using (SqlConnection conexion = new SqlConnection(connectionString))
                    {
                        try
                        {

                            conexion.Open();

                            using (SqlCommand comandoSql = new SqlCommand("sp_AgregarAlumnoYcarrera", conexion))
                            {
                                int estado = 0; //LE DA DE ALTA CON EL VALOR 0       
                                // Definir el comando como un procedimiento almacenado
                                comandoSql.CommandType = CommandType.StoredProcedure;
                                // Agrego parámetros y sus valores
                                comandoSql.Parameters.AddWithValue("@Nombre", nombre);
                                comandoSql.Parameters.AddWithValue("@Apellido", apellido);
                                comandoSql.Parameters.AddWithValue("@DNI", dni);
                                comandoSql.Parameters.AddWithValue("@Mail", correo);
                                comandoSql.Parameters.AddWithValue("@Telefono1", telefono);
                                comandoSql.Parameters.AddWithValue("@Telefono2", telefono2);
                                comandoSql.Parameters.AddWithValue("@Domicilio", domicilio);
                                comandoSql.Parameters.AddWithValue("@FechaInscripcion", fechaIncripcion1);
                                comandoSql.Parameters.AddWithValue("@FechaNacimiento", dateTimePicker1.MaxDate);
                                comandoSql.Parameters.AddWithValue("@Baja ", estado);
                                comandoSql.Parameters.AddWithValue("@ID_Carrera", FormCargarPersonas.ID_Carrera);
                                comandoSql.Parameters.AddWithValue("@AnioCursada", ComboboxElejirCarrera());

                                comandoSql.ExecuteNonQuery();

                                MessageBox.Show("Alumno agregado correctamente");
                                LimpiarCampos();
                                conexion.Close();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }
                    }
                }
            }
        }
        public void CargarPersonal()
        {
            // Primero verifico si el DNI EXISTE
            string dniIngresado = txtDNI.Text;
            bool dniExiste = false;

            try
            {
                string query = "SELECT COUNT(*) FROM Personal WHERE DNI = @DNI";

                using (SqlConnection connection = new SqlConnection(Global.CADENA_CONEXION))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Agregar el parámetro @DNI con el valor del DNI ingresado
                        command.Parameters.AddWithValue("@DNI", dniIngresado);

                        // Ejecutar la consulta y verificar si el DNI ya existe
                        int count = (int)command.ExecuteScalar();

                        if (count > 0)
                        {
                            dniExiste = true; // El DNI ya existe
                        }
                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al verificar el DNI: {ex.Message}");
            }

            // SI EL DNI EXISTE, NO LO DEJO AVANZAR
            if (dniExiste)
            {
                MessageBox.Show("El DNI ya existe. Por favor, ingrese otro.");
                txtDNI.Focus();
                return;
            }
            // SI EL DNI ES NUEVO , SEGUIMOS...
            else
            {
                // Verificamos si los campos de texto están vacíos
                if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                    string.IsNullOrWhiteSpace(txtApellido.Text) ||
                    string.IsNullOrWhiteSpace(txtDNI.Text) ||
                    string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                    string.IsNullOrWhiteSpace(txtTelefono2.Text) ||
                    string.IsNullOrWhiteSpace(txtCorreo.Text) ||
                    string.IsNullOrWhiteSpace(txtCalle.Text))
                {
                    MessageBox.Show("Todos los campos son obligatorios. Por favor, " +
          "completá todos los datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(txtDNI.Text, out int dni))
                {

                    MessageBox.Show("Por favor, ingresá valores numéricos válidos en " +
            "El campo DNI.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Si todas las validaciones pasan, seeguimos...
                string nombre = txtNombre.Text;
                string apellido = txtApellido.Text;
                string correo = txtCorreo.Text;
                string telefono = txtTelefono.Text;
                string telefono2 = txtTelefono2.Text;
                string domicilio = txtCalle.Text;
                //Guado la fecha de hoy
                DateTime fechaIncripcion1;

                if (DateTime.TryParse(lblFechaHoy.Text, out fechaIncripcion1))
                { }
                else
                {
                    MessageBox.Show("El formato de la fecha es incorrecto.");
                }
                //Validar ComoBox Cargo
                if (comboBox1.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe Elejir un Cargo");
                    return;
                }
                else
                {
                    string valor = comboBox1.Text;

                    if (valor == "Elejir una opcion")
                    {
                        MessageBox.Show("Debe Elejir un Cargo");
                        return;
                    }
                }

                string ComboboxCargo()
                {

                    string seleccion = comboBox1.SelectedItem.ToString();
                    // Verificar qué opción fue seleccionada
                    if (seleccion == "Administrativo")
                    {
                        seleccion = "Administrativo";

                    }
                    else if (seleccion == "Profesor")
                    {
                        seleccion = "Profesor";

                    }
                    return seleccion;
                }
                string seleccion = ComboboxCargo();
                string connectionString = Global.CADENA_CONEXION;

                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    try
                    {
                        conexion.Open();
                        using (SqlCommand comandoSql = new SqlCommand("sp_AgregarPersonal", conexion))
                        {
                            int estado = 0;
                            comandoSql.CommandType = CommandType.StoredProcedure;

                            // Agrego los parámetros y sus valores
                            comandoSql.Parameters.AddWithValue("@Nombre", nombre);
                            comandoSql.Parameters.AddWithValue("@Apellido", apellido);
                            comandoSql.Parameters.AddWithValue("@DNI", dni);
                            comandoSql.Parameters.AddWithValue("@Mail", correo);
                            comandoSql.Parameters.AddWithValue("@Telefono1", telefono);
                            comandoSql.Parameters.AddWithValue("@Telefono2", telefono2);
                            comandoSql.Parameters.AddWithValue("@Domicilio", domicilio);
                            comandoSql.Parameters.AddWithValue("@Cargo", seleccion);
                            comandoSql.Parameters.AddWithValue("@FechaInicio", fechaIncripcion1);
                            comandoSql.Parameters.AddWithValue("@FechaNacimiento", dateTimePicker1.MaxDate);
                            comandoSql.Parameters.AddWithValue("@Baja ", estado);

                            comandoSql.ExecuteNonQuery();

                            MessageBox.Show("Personal agregado correctamente");
                            LimpiarCampos();
                            conexion.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }

        }
        private void btnCargar_Click(object sender, EventArgs e)
        {
            CargarNuevo();

        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarDatos();

        }

        private void comboBoxCarreras_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        //-------------------------------- CARGA DE CARERAS AL COMOBOBOX----------------
        private void CargarCarreras()
        {
            try
            {
                string query = "SELECT Nombre FROM Carreras WHERE Baja = 0";

                using (SqlConnection connection = new SqlConnection(Global.CADENA_CONEXION))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                comboBoxCarreras.Items.Add(reader["Nombre"].ToString());
                            }
                        }
                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error! Primero CREÁ la tabla carrera: {ex.Message}");
            }
        }//Carga las carreras al combobox
        static int ID_Carrera { get; set; }
        public void comboBoxCarreras_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idCarrera = 0;
            // Solo continuar si hay una selección válida en el ComboBox
            if (comboBoxCarreras.SelectedIndex != -1)
            {
                try
                {
                    string query = "SELECT ID_Carrera FROM Carreras WHERE Nombre = @Nombre";

                    using (SqlConnection connection = new SqlConnection(Global.CADENA_CONEXION))
                    {
                        connection.Open();

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@Nombre", comboBoxCarreras.SelectedItem.ToString());
                            idCarrera = (int)command.ExecuteScalar(); // Obtiene el ID de la carrera seleccionada
                            FormCargarPersonas.ID_Carrera = idCarrera;
                        }
                        // MessageBox.Show("ID CARRERA es:  "+ idCarrera);
                        connection.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error! Primero CREÁ la tabla carrera: {ex.Message}");
                    MessageBox.Show($"CARGA al menos UNA carrera: {ex.Message}");
                }
            }
            else
            {
                idCarrera = 0; // Si no se selecciona nada, el ID es 0
            }
        }

        private void FormCargarPersonas_Load(object sender, EventArgs e)
        {
            CargarCarreras();
            comboBoxCarreras.Visible = true;
        }

        
    }
}
