using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Gestion_Instituto
{
    public partial class CrearExamen : Form
    {
        public CrearExamen()
        {
            InitializeComponent();
            Estilo.AplicarTodo(this);
            btnProfesor.Width = 250;
            btnProfesor.Height = 33;
        }

        public int ID_Carrera = 0;
        public int ID_Materia = 0;
        public int ID_Profesor = 0;
        public int ID_MateriaXCarrera = 0;
        public string Instancia = string.Empty;
        public string Anio = string.Empty;
        public DateTime Fecha;

        private void CargarCarreras()
        {
            try
            {
                string query = "SELECT Nombre FROM Carreras";

                using (SqlConnection connection = new SqlConnection(Global.CADENA_CONEXION))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                cbCarrerasE.Items.Add(reader["Nombre"].ToString());
                            }
                        }
                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Primero crea la tabla carrera: {ex.Message}");
            }
        }//Carga las carreras al combobox

        private void cbCarrerasE_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Solo continuar si hay una selección válida en el ComboBox
            if (cbCarrerasE.SelectedIndex != -1)
            {
                try
                {
                    string query = "SELECT ID_Carrera FROM Carreras WHERE Nombre = @Nombre";

                    using (SqlConnection connection = new SqlConnection(Global.CADENA_CONEXION))
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@Nombre", cbCarrerasE.SelectedItem.ToString());
                            ID_Carrera = (int)command.ExecuteScalar(); // Obtiene el ID de la carrera seleccionada
                            cbMateriaE.Enabled = true;
                            CargarMaterias();
                        }

                        connection.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Carga al menos una carrera: {ex.Message}");
                }
            }
            else
            {
                ID_Carrera = 0; // Si no se selecciona nada, el ID es 0
            }
        }

        private void CargarMaterias()
        {
            cbMateriaE.Items.Clear();
            try
            {
                using (SqlConnection connection = new SqlConnection(Global.CADENA_CONEXION))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("sp_BuscarMaterias", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@ID_Carrera", ID_Carrera);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                cbMateriaE.Items.Add(reader["Nombre"].ToString());
                            }
                        }
                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Primero crea la tabla materia: {ex.Message}");
            }
        }

        private void cbMateriaE_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Solo continuar si hay una selección válida en el ComboBox
            if (cbMateriaE.SelectedIndex != -1)
            {
                try
                {
                    string query = "SELECT ID_Materia FROM Materias WHERE Nombre = @Nombre";

                    using (SqlConnection connection = new SqlConnection(Global.CADENA_CONEXION))
                    {
                        connection.Open();

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@Nombre", cbMateriaE.SelectedItem.ToString());
                            ID_Materia = (int)command.ExecuteScalar(); // Obtiene el ID de la carrera seleccionada
                            cbAnioE.Enabled = true;
                        }

                        connection.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Carga al menos una materia: {ex.Message}");
                }
            }
            else
            {
                ID_Materia = 0; // Si no se selecciona nada, el ID es 0
            }
        }

        private void cbAnioE_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbAnioE.SelectedIndex != -1)
            {
                try
                {
                    Anio = cbAnioE.SelectedItem.ToString();
                    cbInstanciaE.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($" {ex.Message}");
                }
            }
        }

        private void cbInstanciaE_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbInstanciaE.SelectedIndex != -1)
            {
                try
                {
                    Instancia = cbInstanciaE.SelectedItem.ToString();
                    dtpFechaE.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($" {ex.Message}");
                }
            }
        }

        private void dtpFechaE_ValueChanged(object sender, EventArgs e)
        {
            if (dtpFechaE.Checked)
            {
                Fecha = dtpFechaE.Value;
                btnProfesor.Enabled = true;
            }
        }

        private void btnProfesor_Click(object sender, EventArgs e)
        {
            FormListaProfesor formListaProfesor = new FormListaProfesor();     //Creo una instancia del form
            AddOwnedForm(formListaProfesor); //Le asigno una propiedad al form
            formListaProfesor.ShowDialog();
            btnCrear.Enabled = true;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Global.CADENA_CONEXION))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("sp_SearchMatXCarr", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@ID_Materia", ID_Materia);
                        command.Parameters.AddWithValue("@ID_Carrera", ID_Carrera);
                        ID_MateriaXCarrera = (int)command.ExecuteScalar(); // Obtiene el ID de la carrera seleccionada
                    }

                    using (SqlCommand command = new SqlCommand("sp_CreateExam", connection))
                    {
                        int estado = 0;

                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@Fecha", Fecha);
                        command.Parameters.AddWithValue("@TipoExamen", Instancia);
                        command.Parameters.AddWithValue("@AnioExamen",int.Parse(Anio));
                        command.Parameters.AddWithValue("@ID_Profesor", ID_Profesor);
                        command.Parameters.AddWithValue("@ID_MateriasXCarrera", ID_MateriaXCarrera);
                        command.Parameters.AddWithValue("@Baja", estado);

                        command.ExecuteNonQuery();
                        MessageBox.Show("Examen creado correctamente");

                    }
                    connection.Close();
                }
            }
            catch (Exception ex) { MessageBox.Show($"{ex.Message}"); }
            limpiarcampos();
        }

        private void limpiarcampos()
        {
            cbCarrerasE.SelectedIndex = -1;
            cbMateriaE.SelectedIndex = -1;
            cbInstanciaE.SelectedIndex = -1;
            cbAnioE.SelectedIndex = -1;
            dtpFechaE.Checked = false;
        }
        private void CrearExamen_Load(object sender, EventArgs e)
        {
            CargarCarreras();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
