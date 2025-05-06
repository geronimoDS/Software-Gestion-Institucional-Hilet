using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Instituto
{
    public partial class FormVerDatosGeneral : Form
    {
        public enum Datos { CARRERAS, MATERIAS }

        private Datos modoDatos;

        private int idSeleccion = 0;

        // Materias y carreras
        private string nombre = "";
        private string descripcion = "";
        private int idProfesor = 0;
        private int nResolucion = 0;


        public FormVerDatosGeneral(Datos modo)
        {
            InitializeComponent();

            Estilo.AplicarTodo(this);

            btnReiniciarFiltro.Height = 26;
            btnReiniciarFiltro.Width = 95;

            modoDatos = modo;

            CargarDatos();

            switch (modoDatos)
            {
                case Datos.MATERIAS:
                    this.Text = "Materias";
                    lblEspecifico.Text = "Profesor:";

                    // Ocultar columnas de ID que el usuario final no necesita ver, pero son necesarias para las demas funciones
                    // Index: 0 ID_Materia, 1 Nombre, 2 Descripcion, 3 nombre completo profesor, 4, Baja, 5 ID_Profesor, 6 Carrera, 7 Cursada
                    dataGridView.Columns[5].Visible = false;

                    btnDetalles.Visible = false;
                    btnDetalles.Enabled = false;

                    // Cargar lista de carreras en el combobox
                    try
                    {
                        string query = "SELECT ID_Carrera, Nombre AS Carreras FROM Carreras WHERE Baja = 0";

                        using (SqlConnection connection = new SqlConnection(Global.CADENA_CONEXION))
                        {
                            connection.Open();

                            using (SqlCommand command = new SqlCommand(query, connection))
                            {
                                using (SqlDataReader reader = command.ExecuteReader())
                                {
                                    while (reader.Read())
                                    {
                                        cmbCarrera.Items.Add(reader["Carreras"].ToString());
                                    }
                                }
                            }

                            connection.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al cargar los datos de profesores: {ex.Message}");
                    }


                    break;

                case Datos.CARRERAS:
                    this.Text = "Carreras";
                    lblEspecifico.Text = "Resolucion:";
                    panelFiltroCarrera.Visible = false;
                    panelFiltroCarrera.Enabled = false;

                    break;
            }
        }


        private void CargarDatos()
        {
            string query = "";
            int bajaCheck = 0;

            switch (modoDatos)
            {
                case Datos.MATERIAS:
                    
                    if (chkVerBajas.Checked) bajaCheck = 1;

                    query = $"SELECT M.ID_Materia AS ID, M.Nombre AS Materia, M.Descripcion, P.Nombre +' '+P.Apellido AS Profesor, M.Baja, PXM.ID_Profesor, C.Nombre AS Carrera, MXC.AnioCursada AS Año, (SELECT COUNT(ID_Matricula) FROM MateriasXAlumno WHERE ID_Materia = M.ID_Materia) AS Alumnos FROM ProfesoresXMaterias AS PXM INNER JOIN Personal AS P ON PXM.ID_Profesor = P.ID_Personal RIGHT JOIN Materias AS M ON M.ID_Materia = PXM.ID_Materia LEFT JOIN MateriasXCarrera AS MXC ON MXC.ID_Materia = M.ID_Materia LEFT JOIN Carreras AS C ON C.ID_Carrera = MXC.ID_Carrera WHERE M.Baja = {bajaCheck} ORDER BY M.Nombre";

                    if (Global.Permiso == NivelUsuario.PROFESOR)
                        query = $"SELECT M.ID_Materia AS ID, M.Nombre AS Materia, M.Descripcion, P.Nombre +' '+P.Apellido AS Profesor, M.Baja, PXM.ID_Profesor, C.Nombre AS Carrera, MXC.AnioCursada AS Año, (SELECT COUNT(ID_Matricula) FROM MateriasXAlumno WHERE ID_Materia = M.ID_Materia) AS Alumnos FROM ProfesoresXMaterias AS PXM INNER JOIN Personal AS P ON PXM.ID_Profesor = P.ID_Personal RIGHT JOIN Materias AS M ON M.ID_Materia = PXM.ID_Materia LEFT JOIN MateriasXCarrera AS MXC ON MXC.ID_Materia = M.ID_Materia LEFT JOIN Carreras AS C ON C.ID_Carrera = MXC.ID_Carrera WHERE M.Baja = {bajaCheck} AND P.ID_Personal = {Global.ID_Persona} ORDER BY M.Nombre";

                    if (Global.Permiso == NivelUsuario.ALUMNO)
                        query = $"SELECT M.ID_Materia AS ID, M.Nombre AS Materia, M.Descripcion, P.Nombre +' '+P.Apellido AS Profesor, M.Baja, PXM.ID_Profesor, C.Nombre AS Carrera, MXC.AnioCursada AS Año FROM ProfesoresXMaterias AS PXM INNER JOIN Personal AS P ON PXM.ID_Profesor = P.ID_Personal RIGHT JOIN Materias AS M ON M.ID_Materia = PXM.ID_Materia LEFT JOIN MateriasXCarrera AS MXC ON MXC.ID_Materia = M.ID_Materia LEFT JOIN Carreras AS C ON C.ID_Carrera = MXC.ID_Carrera WHERE M.Baja = {bajaCheck} AND C.ID_Carrera = {Global.AlumnoCarrera} AND MXC.AnioCursada = {Global.AlumnoCursada} ORDER BY M.Nombre";

                    break;

                case Datos.CARRERAS:
                    if (chkVerBajas.Checked) bajaCheck = 1;

                    query = $"SELECT Carreras.*, (SELECT COUNT(ID_Matricula) FROM AlumnosXCarrera AS AXC WHERE AXC.ID_Carrera = Carreras.ID_Carrera) AS Alumnos FROM Carreras WHERE Baja = {bajaCheck} ORDER BY Nombre";

                    break;
            }


            try
            {
                using (SqlConnection connection = new SqlConnection(Global.CADENA_CONEXION))
                {
                    // Abrir la conexión
                    connection.Open();

                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection))
                    {
                        using (DataTable dataTable = new DataTable())
                        {
                            dataAdapter.Fill(dataTable);

                            dataGridView.DataSource = dataTable;
                        }
                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos: {ex.Message}");
            }

            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }


        private void FormVerCarrerasMaterias_Load(object sender, EventArgs e)
        {
            lblDescripcionDato.BackColor = Estilo.ColorFondo;
            lblDescripcionDato.ForeColor = Estilo.ColorTextoOscuro;
            lblDescripcionDato.BorderStyle = BorderStyle.None;

            if (Global.Permiso == NivelUsuario.PROFESOR || Global.Permiso == NivelUsuario.ALUMNO)
            {
                chkVerBajas.Enabled = false;
                chkVerBajas.Visible = false;

                btnNueva.Enabled = false;
                btnNueva.Visible = false;

                btnEditar.Enabled = false;
                btnEditar.Visible = false;

                btnEliminar.Enabled = false;
                btnEliminar.Visible = false;

                btnRestaurar.Enabled = false;
                btnRestaurar.Visible = false;
            }

            // Ocultar columnas de ID que el usuario final no necesita ver, pero son necesarias para las demas funciones
            if (dataGridView.Columns.Count > 0)
            {
                dataGridView.Columns[0].Visible = false;
                dataGridView.Columns[4].Visible = false;
            }

        }


        private void chkVerBajas_CheckedChanged(object sender, EventArgs e)
        {
            CargarDatos();

            btnNueva.Enabled = !btnNueva.Enabled;

            btnEditar.Enabled = !btnEditar.Enabled;

            btnEliminar.Enabled = !btnEliminar.Enabled;
            btnEliminar.Visible = !btnEliminar.Visible;

            btnRestaurar.Enabled = !btnRestaurar.Enabled;
            btnRestaurar.Visible = !btnRestaurar.Visible;
        }



        // Conseguir datos desde la tabla
        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            switch (modoDatos)
            {
                case Datos.MATERIAS:
                    // Index: 0 ID_Materia, 1 Nombre, 2 Descripcion, 3 nombre completo profesor, 4, Baja, 5 ID_Profesor, 6 ID_Carrera, 7 Cursada

                    idSeleccion = dataGridView.CurrentRow.Cells[0].Value != DBNull.Value ? (int)dataGridView.CurrentRow.Cells[0].Value : 0;

                    nombre = dataGridView.CurrentRow.Cells[1].Value != DBNull.Value ? dataGridView.CurrentRow.Cells[1].Value.ToString() : "";

                    descripcion = dataGridView.CurrentRow.Cells[2].Value != DBNull.Value ? dataGridView.CurrentRow.Cells[2].Value.ToString() : "";

                    idProfesor = dataGridView.CurrentRow.Cells[5].Value != DBNull.Value ? (int)dataGridView.CurrentRow.Cells[5].Value : 0;

                    lblNombreDato.Text = nombre;
                    lblDescripcionDato.Text = descripcion;

                    lblEspecificoDato.Text = dataGridView.CurrentRow.Cells[3].Value != DBNull.Value ? dataGridView.CurrentRow.Cells[3].Value.ToString() : "";

                    break;

                case Datos.CARRERAS:
                    // Index: 0 ID_Carrera, 1 Nombre, 2 NResolucion, 3 Descripcion, 4 Baja
                    idSeleccion = dataGridView.CurrentRow.Cells[0].Value != DBNull.Value ? (int)dataGridView.CurrentRow.Cells[0].Value : 0;

                    nombre = dataGridView.CurrentRow.Cells[1].Value != DBNull.Value ? dataGridView.CurrentRow.Cells[1].Value.ToString() : "";

                    nResolucion = dataGridView.CurrentRow.Cells[2].Value != DBNull.Value ? (int)dataGridView.CurrentRow.Cells[2].Value : 0;

                    descripcion = dataGridView.CurrentRow.Cells[3].Value != DBNull.Value ? dataGridView.CurrentRow.Cells[3].Value.ToString() : "";

                    lblNombreDato.Text = nombre;
                    lblDescripcionDato.Text = descripcion;

                    lblEspecificoDato.Text = nResolucion != 0 ? dataGridView.CurrentRow.Cells[2].Value.ToString() : "";


                    break;
            }


        }

        private void btnNueva_Click(object sender, EventArgs e)
        {
            switch (modoDatos)
            {
                case Datos.MATERIAS:
                    FormCargarMateria formCargarMateria = new FormCargarMateria(false);
                    formCargarMateria.DatosIngresados += FormCargarMateria_DatosIngresados; // Conectar el evento
                    formCargarMateria.ShowDialog();

                    break;

                case Datos.CARRERAS:
                    FormCargarCarrera formCargarCarrera = new FormCargarCarrera();
                    formCargarCarrera.DatosIngresados += FormCargarMateria_DatosIngresados; // Conectar el evento
                    formCargarCarrera.ShowDialog();

                    break;
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (idSeleccion != 0)
            {
                switch (modoDatos)
                {
                    case Datos.MATERIAS:
                        FormCargarMateria formCargarMateria = new FormCargarMateria(false, idSeleccion, nombre, descripcion, idProfesor);
                        formCargarMateria.DatosIngresados += FormCargarMateria_DatosIngresados; // Conectar el evento
                        formCargarMateria.ShowDialog();

                        break;

                    case Datos.CARRERAS:
                        FormCargarCarrera formCargarCarrera = new FormCargarCarrera(idSeleccion, nombre, nResolucion, descripcion, false);
                        formCargarCarrera.DatosIngresados += FormCargarCarrera_DatosIngresados; // Conectar el evento
                        formCargarCarrera.ShowDialog();

                        break;
                }
            }

        }

        // Actualizar gridview cuando el form de carga tira el evento
        private void FormCargarMateria_DatosIngresados(object? sender, EventArgs e)
        {
            CargarDatos();
        }

        private void FormCargarCarrera_DatosIngresados(object? sender, EventArgs e)
        {
            CargarDatos();
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string connectionString = Global.CADENA_CONEXION;
            string query = "";
            string mensage = "";

            if (idSeleccion != 0)
            {
                switch (modoDatos)
                {
                    case Datos.MATERIAS:
                        query = "UPDATE Materias SET Baja = 1 WHERE ID_Materia = @ID_Seleccion";
                        mensage = "Materia dada de baja.";

                        break;

                    case Datos.CARRERAS:
                        query = "UPDATE Carreras SET Baja = 1 WHERE ID_Carrera = @ID_Seleccion";
                        mensage = "Carrera dada de baja.";

                        break;
                }

                try
                {
                    using (SqlConnection conection = new SqlConnection(connectionString))
                    {
                        conection.Open();

                        using (SqlCommand comando = new SqlCommand(query, conection))
                        {
                            comando.Parameters.AddWithValue("@ID_Seleccion", idSeleccion);

                            comando.ExecuteNonQuery();

                            MessageBox.Show(mensage);

                        }

                        conection.Close();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }

                CargarDatos();
            }
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            string connectionString = Global.CADENA_CONEXION;
            string query = "";
            string mensage = "";

            switch (modoDatos)
            {
                case Datos.MATERIAS:
                    query = "UPDATE Materias SET Baja = 0 WHERE ID_Materia = @ID_Seleccion";
                    mensage = "Materia restaurada.";

                    break;

                case Datos.CARRERAS:
                    query = "UPDATE Carreras SET Baja = 0 WHERE ID_Carrera = @ID_Seleccion";
                    mensage = "Carrera restaurada.";

                    break;
            }

            try
            {
                using (SqlConnection conection = new SqlConnection(connectionString))
                {
                    conection.Open();

                    using (SqlCommand comando = new SqlCommand(query, conection))
                    {
                        comando.Parameters.AddWithValue("@ID_Seleccion", idSeleccion);

                        comando.ExecuteNonQuery();

                        MessageBox.Show(mensage);

                    }

                    conection.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            CargarDatos();
        }


        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {
            if (idSeleccion != 0)
            switch (modoDatos)
            {
                case Datos.MATERIAS:
                    FormCargarMateria formCargarMateria = new FormCargarMateria(true, idSeleccion, nombre, descripcion, idProfesor);
                    formCargarMateria.ShowDialog();

                    break;

                case Datos.CARRERAS:
                    FormCargarCarrera formCargarCarrera = new FormCargarCarrera(idSeleccion, nombre, nResolucion, descripcion, true);
                    formCargarCarrera.ShowDialog();

                    break;
            }
        }

        private void btnReiniciarFiltro_Click(object sender, EventArgs e)
        {
            cmbCarrera.SelectedIndex = -1;
            cmbCarrera.Text = "Carrera";
            cmbCursada.SelectedIndex = -1;
            cmbCursada.Text = "Año";

            ActualizarTablaLocal();
        }

        private void ActualizarTablaLocal()
        {
            dataGridView.ClearSelection();
            dataGridView.CurrentCell = null;

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                // Si los 2 filtros estan en -1, mostrar todo
                row.Visible = true;

                DataGridViewColumn colCarrera;
                DataGridViewColumn colCursada;

                // Si solo se eligio el filtro de carrera
                if (cmbCarrera.SelectedIndex != -1 && cmbCursada.SelectedIndex == -1)
                {
                    colCarrera = dataGridView.Columns["Carrera"];

                    if (row.Cells[colCarrera.Index].Value.ToString() == cmbCarrera.SelectedItem.ToString())
                        row.Visible = true;
                    else
                        row.Visible = false;
                }
                else
                // Si solo se eligio el filtro de cursada
                if (cmbCursada.SelectedIndex != -1 && cmbCarrera.SelectedIndex == -1)
                {
                    colCursada = dataGridView.Columns["Año"];

                    if (row.Cells[colCursada.Index].Value.ToString() == cmbCursada.SelectedItem.ToString())
                        row.Visible = true;
                    else
                        row.Visible = false;
                }
                else
                // Si solo se eligieron los 2 filtros
                if (cmbCarrera.SelectedIndex != -1 && cmbCursada.SelectedIndex != -1)
                {
                    // Index: 0 ID_Materia, 1 Nombre, 2 Descripcion, 3 nombre completo profesor, 4, Baja, 5 ID_Profesor, 6 Carrera, 7 Cursada
                    colCarrera = dataGridView.Columns["Carrera"];
                    colCursada = dataGridView.Columns["Año"];

                    if (row.Cells[colCarrera.Index].Value.ToString() == cmbCarrera.SelectedItem.ToString() && row.Cells[colCursada.Index].Value.ToString() == cmbCursada.SelectedItem.ToString())
                        row.Visible = true;
                    else
                        row.Visible = false;
                }

            }
        }

        private void cmbCarrera_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarTablaLocal();
        }

        private void cmbCursada_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarTablaLocal();
        }
    }
}
