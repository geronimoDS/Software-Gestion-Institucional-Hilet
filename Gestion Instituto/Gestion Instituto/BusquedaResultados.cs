using iTextSharp.text.pdf.parser.clipper;
using Org.BouncyCastle.Pkix;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Gestion_Instituto
{
    public partial class BusquedaResultados : Form
    {
        string tipoBusqueda;
        string busqueda;

        public BusquedaResultados(int ancho, Point p, string tipo, string bus)
        {
            InitializeComponent();

            Estilo.AplicarTodo(this);

            dataGridView.Dock = DockStyle.Fill;

            Width = ancho;

            StartPosition = FormStartPosition.Manual;

            Point offset = new Point(58, 160);
            Location = new Point(p.X + offset.X, p.Y + offset.Y);

            tipoBusqueda = tipo;
            busqueda = bus;
        }


        private void BusquedaResultados_Load(object sender, EventArgs e)
        {
            string query = "";

            switch (tipoBusqueda)
            {
                case "Alumnos":
                    query = $"SELECT ID_Matricula AS ID, Apellido+' '+Nombre AS NombreCompleto FROM Alumnos WHERE Baja = 0 AND Nombre+' '+Apellido LIKE '%{busqueda}%'";
                    break;

                case "Personal":
                    query = $"SELECT ID_Personal AS ID, Apellido+' '+Nombre AS NombreCompleto FROM Personal WHERE Baja = 0 AND Nombre+' '+Apellido LIKE '%{busqueda}%'";
                    break;
                case "Profesor":
                    query = $"SELECT ID_Personal AS ID, Apellido+' '+Nombre AS NombreCompleto FROM Personal WHERE Baja = 0 AND Cargo = 'profesor' AND Nombre+' '+Apellido LIKE '%{busqueda}%'";
                    break;
                case "Materias":
                    query = $"SELECT ID_Materia AS ID, Nombre, Descripcion FROM Materias WHERE Baja = 0 AND Nombre LIKE '%{busqueda}%'";
                    break;
                case "Examen":
                    query = $"SELECT E.ID_Examen AS ID, E.Fecha, M.Nombre, E.TipoExamen FROM Examen AS E INNER JOIN Materias AS M ON E.ID_Examen = M.ID_Materia WHERE E.Baja = 0 AND M.Nombre LIKE '%{busqueda}%'";
                    break;
                case "Notas":
                    query = "Select * FROM NotasXAlumno"; // Placeholder
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

            dataGridView.Columns[0].Visible = false;

            if (tipoBusqueda == "Materias") dataGridView.Columns[2].Visible = false;

            dataGridView.Height = dataGridView.Rows.Count * dataGridView.RowTemplate.Height;

            this.Height = dataGridView.Rows.Count * (dataGridView.RowTemplate.Height - 2);
        }

        public FormMostrar resultadoPersona;
        public FormCargarMateria resultadoMateria;
        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idBusqueda;

            switch (tipoBusqueda)
            {
                case "Alumnos":
                    resultadoPersona = new FormMostrar();
                    resultadoPersona.TipoSeleccion = "Alumno";
                    idBusqueda = (int)dataGridView.CurrentRow.Cells[0].Value;
                    resultadoPersona.AlumnosActivos();
                    resultadoPersona.BtnDarBaja();
                    resultadoPersona.ResultadoBusqueda(idBusqueda);

                    break;
                case "Personal":
                    resultadoPersona = new FormMostrar();
                    resultadoPersona.TipoSeleccion = "Personal";
                    idBusqueda = (int)dataGridView.CurrentRow.Cells[0].Value;
                    resultadoPersona.PersonalActivo();
                    resultadoPersona.BtnDarBaja();
                    resultadoPersona.ResultadoBusqueda(idBusqueda);

                    break;
                case "Materias":
                    int idSeleccion = dataGridView.CurrentRow.Cells[0].Value != DBNull.Value ? (int)dataGridView.CurrentRow.Cells[0].Value : 0;

                    string nombre = dataGridView.CurrentRow.Cells[1].Value != DBNull.Value ? dataGridView.CurrentRow.Cells[1].Value.ToString() : "";

                    string descripcion = dataGridView.CurrentRow.Cells[2].Value != DBNull.Value ? dataGridView.CurrentRow.Cells[2].Value.ToString() : "";

                    int idProfesor = 0;

                    resultadoMateria = new FormCargarMateria(true, idSeleccion, nombre, descripcion, idProfesor);
                    resultadoMateria.ShowDialog();


                    break;
                case "Examen":
                    break;
                case "Notas":
                    break;
            }
        }

        private void dataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void BusquedaResultados_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (resultadoMateria != null) resultadoMateria.Close();
            if (resultadoPersona != null) resultadoPersona.Close();
        }
    }
}
