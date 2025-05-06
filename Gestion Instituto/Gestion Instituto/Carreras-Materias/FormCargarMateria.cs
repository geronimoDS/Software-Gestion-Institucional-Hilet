using System.Data;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Gestion_Instituto
{
    public partial class FormCargarMateria : Form
    {
        public event EventHandler DatosIngresados; // Evento para cuando se ingresan los datos

        private bool esNueva = true;
        private int idMateria = 0;
        private string nombreMateria = "";
        private string descripcionMateria = "";
        private int idProfesor = 0;

        private string nombreProfesorCompleto = ""; // Para guardar cuando es una materia editada

        bool soloLectura = false;

        public FormCargarMateria(bool lectura)
        {
            InitializeComponent();

            Estilo.AplicarTodo(this);
            MaximumSize = Size;

            soloLectura = lectura;
        }

        public FormCargarMateria(bool lectura, int id, string nombre, string descripcion, int profesor)
        {
            InitializeComponent();

            Estilo.AplicarTodo(this);
            MaximumSize = Size;

            this.Text = "Editar materia";

            soloLectura = lectura;

            idMateria = id;
            nombreMateria = nombre;
            descripcionMateria = descripcion;
            idProfesor = profesor;

            txtNombreMateria.Text = nombre;
            txtDescripcionMateria.Text = descripcion;

            esNueva = false;
        }

        protected virtual void OnDatosIngresados(EventArgs e)
        {
            DatosIngresados?.Invoke(this, e);
        }

        private void FormCargarMateria_Load(object sender, EventArgs e)
        {
            if (soloLectura)
            {
                Text = "Ver Materia";
                btnAceptarMateria.Enabled = false;
                btnAceptarMateria.Visible = false;
                btnCancelar.Enabled = false;
                btnCancelar.Visible = false;
                btnVolver.Enabled = true;
                btnVolver.Visible = true;
                txtDescripcionMateria.ReadOnly = true;
                txtNombreMateria.ReadOnly = true;
                lblProfesor.Visible = false;
                comboBoxProfesor.Enabled = false;
                comboBoxProfesor.Visible = false;
                
            }

            // Cargar lista de profesores en el combobox
            try
            {
                string query = "SELECT ID_Personal, Nombre +' '+ Apellido AS Profesores FROM Personal WHERE Baja = 0 AND Cargo = 'profesor'";

                using (SqlConnection connection = new SqlConnection(Global.CADENA_CONEXION))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                comboBoxProfesor.Items.Add(reader["Profesores"].ToString());

                                if (!esNueva && idProfesor == (int)reader["ID_Personal"])
                                {
                                    nombreProfesorCompleto = reader["Profesores"].ToString();

                                    comboBoxProfesor.SelectedIndex = comboBoxProfesor.Items.Count - 1;
                                }
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
        }

        private void comboBoxProfesor_SelectedIndexChanged(object sender, EventArgs e)
        {
            // conseguir el ID del profesor seleccionado
            if (comboBoxProfesor.SelectedIndex != -1)
                try
                {
                    string query = "SELECT ID_Personal FROM Personal WHERE Nombre +' '+ Apellido = @NombreCompleto";

                    using (SqlConnection connection = new SqlConnection(Global.CADENA_CONEXION))
                    {
                        connection.Open();

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@NombreCompleto", comboBoxProfesor.SelectedItem.ToString());
                            idProfesor = (int)command.ExecuteScalar();
                        }

                        connection.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar los datos: {ex.Message}");
                }

            else idProfesor = 0;

        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptarMateria_Click(object sender, EventArgs e)
        {
            if (!DatosEntrada.ValidarTexto(txtNombreMateria, errorProvider, "El nombre de la materia no puede queadar en blanco")) return;
            if (!DatosEntrada.ValidarTexto(txtDescripcionMateria, errorProvider, "Debe detallar la materia")) return;

            nombreMateria = txtNombreMateria.Text;
            descripcionMateria = txtDescripcionMateria.Text;

            try
            {
                string connectionString = Global.CADENA_CONEXION;

                using (SqlConnection conection = new SqlConnection(connectionString))
                {
                    string query = "";

                    if (esNueva)
                        query = "sp_MateriaNueva";
                    else
                        query = "sp_MateriaEditar";

                    conection.Open();

                    using (SqlCommand comando = new SqlCommand(query, conection))
                    {
                        comando.CommandType = CommandType.StoredProcedure;

                        if (!esNueva) comando.Parameters.AddWithValue("@ID_Materia", idMateria);

                        comando.Parameters.AddWithValue("@Nombre", nombreMateria);
                        comando.Parameters.AddWithValue("@Descripcion", descripcionMateria);
                        comando.Parameters.AddWithValue("@ID_Profesor", idProfesor);

                        comando.ExecuteNonQuery();

                        MessageBox.Show(esNueva? "Materia creada correctamente." : "Materia actualizada correctamente.");

                        txtNombreMateria.Clear();
                        txtDescripcionMateria.Clear();
                        comboBoxProfesor.SelectedIndex = -1;
                    }

                    conection.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            OnDatosIngresados(EventArgs.Empty); // Avisa que se cargaron datos nuevos

            Close();

        }

    }
}
