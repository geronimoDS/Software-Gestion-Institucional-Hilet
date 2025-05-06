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
using static Gestion_Instituto.FormVerDatosGeneral;

namespace Gestion_Instituto
{
    public partial class FormCargarCarrera : Form
    {
        public event EventHandler DatosIngresados; // Evento para cuando se ingresan los datos

        private bool soloLectura = false;

        private bool esNueva = true;
        private int idCarrera = 0;
        private string nombreCarrera = "";
        private int nResolucion = 0;
        private string descripcionCarrera = "";

        private int idMateria = 0;
        private int cursada = 1;

        public FormCargarCarrera()
        {
            InitializeComponent();

            Estilo.AplicarTodo(this);
            MaximumSize = Size;
        }

        public FormCargarCarrera(int id, string nombre, int resolucion, string descripcion, bool lectura)
        {
            InitializeComponent();

            Estilo.AplicarTodo(this);
            MaximumSize = Size;

            esNueva = false;
            soloLectura = lectura;

            this.Text = soloLectura ? "Ver carrera" : "Editar carrera";

            idCarrera = id;
            nombreCarrera = nombre;
            nResolucion = resolucion;
            descripcionCarrera = descripcion;

            txtNombreCarrera.Text = nombre;
            txtDescripcionCarrera.Text = descripcion;
            txtResolucion.Text = resolucion.ToString();
        }

        protected virtual void OnDatosIngresados(EventArgs e)
        {
            DatosIngresados?.Invoke(this, e);
        }


        private void CargarDatos()
        {
            string query = $"Select MXC.ID_Materia, MXC.AnioCursada AS Cursada, M.Nombre AS Materia FROM Materias AS M INNER JOIN MateriasXCarrera AS MXC ON M.ID_Materia = MXC.ID_Materia WHERE MXC.ID_Carrera = {idCarrera} AND M.Baja = 0";

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

            // Ocultar columnas de ID que el usuario final no necesita ver, pero son necesarias para las demas funciones
            if (dataGridView.Columns.Count > 0)
            {
                // 0 ID_Materia, 1 año cursada, 2 nombre materia
                dataGridView.Columns[0].Visible = false;
                dataGridView.Columns[1].Visible = false;
            }

            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void CrearListaMaterias()
        {
            try
            {
                cmbMateria.Items.Clear();

                string query = "SELECT ID_Materia, Nombre AS Materias FROM Materias WHERE Baja = 0";

                using (SqlConnection connection = new SqlConnection(Global.CADENA_CONEXION))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                cmbMateria.Items.Add(reader["Materias"].ToString());
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

        private void ActualizarTablaLocal()
        {
            dataGridView.ClearSelection();
            dataGridView.CurrentCell = null;

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                DataGridViewColumn col = dataGridView.Columns["Cursada"];
                if (row.Cells[col.Index].Value.ToString() == cursada.ToString())
                    row.Visible = true;
                else
                    row.Visible = false;
            }
        }


        private void FormCargarCarrera_Load(object sender, EventArgs e)
        {
            nuevaMateria.Width = 82;
            nuevaMateria.Height = 26;

            cmbCursada.SelectedIndex = 0;
            
            // Poner en modo de solo lectura
            if (soloLectura)
            {
                txtNombreCarrera.ReadOnly = true;
                txtDescripcionCarrera.ReadOnly = true;
                txtResolucion.ReadOnly = true;

                btnAceptarCarrera.Enabled = false;
                btnAceptarCarrera.Visible = false;
                btnCancelar.Enabled = false;
                btnCancelar.Visible = false;
                btnQuitarMateria.Enabled = false;
                btnQuitarMateria.Visible = false;
                btnAgregarMateria.Enabled = false;
                btnAgregarMateria.Visible = false;
                lblMateria.Visible = false;
                cmbMateria.Enabled = false;
                cmbMateria.Visible = false;
                nuevaMateria.Enabled = false;
                nuevaMateria.Visible = false;

                btnVolver.Enabled = true;
                btnVolver.Visible = true;

                this.Text = "Ver carrera";
            }
            else
            {
                cmbCursada.SelectedIndex = 0;
                cursada = cmbCursada.SelectedIndex + 1;

                // Cargar lista de materias en el combobox
                CrearListaMaterias();
            }

            if (!esNueva)
            {
                CargarDatos();
                ActualizarTablaLocal();
            }
            else
            {
                // Preparar las columnas manualmente si es una carrera nueva
                DataGridViewColumn columna1 = new DataGridViewTextBoxColumn();
                columna1.HeaderText = "ID_Materia";
                columna1.Name = "ID_Materia";
                dataGridView.Columns.Add(columna1);

                DataGridViewColumn columna2 = new DataGridViewTextBoxColumn();
                columna2.HeaderText = "Cursada";
                columna2.Name = "Cursada";
                dataGridView.Columns.Add(columna2);

                DataGridViewColumn columna3 = new DataGridViewTextBoxColumn();
                columna3.HeaderText = "Materia";
                columna3.Name = "Materia";
                dataGridView.Columns.Add(columna3);
            }
        }


        private void cmbCursada_SelectedIndexChanged(object sender, EventArgs e)
        {
            cursada = cmbCursada.SelectedIndex + 1;

            ActualizarTablaLocal();
        }

        private void cmbMateria_SelectedIndexChanged(object sender, EventArgs e)
        {
            // conseguir el ID de la materia seleccionada
            if (cmbMateria.SelectedIndex != -1)
                try
                {
                    string query = "SELECT ID_Materia FROM Materias WHERE Nombre = @NombreMateria";

                    using (SqlConnection connection = new SqlConnection(Global.CADENA_CONEXION))
                    {
                        connection.Open();

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@NombreMateria", cmbMateria.SelectedItem.ToString());
                            idMateria = (int)command.ExecuteScalar();
                        }

                        connection.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar los datos: {ex.Message}");
                }

            else idMateria = 0;
        }

        private void nuevaMateria_Click(object sender, EventArgs e)
        {
            FormCargarMateria formCargarMateria = new FormCargarMateria(false);
            formCargarMateria.DatosIngresados += FormCargarMateria_DatosIngresados; // Conectar el evento
            formCargarMateria.ShowDialog();
        }
        private void FormCargarMateria_DatosIngresados(object? sender, EventArgs e)
        {
            CrearListaMaterias();
        }

        private void btnQuitarMateria_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow != null)
                dataGridView.Rows.Remove(dataGridView.CurrentRow);

            ActualizarTablaLocal();
        }

        private void btnAgregarMateria_Click(object sender, EventArgs e)
        {
            if (idMateria != 0)
            {
                if ((DataTable)dataGridView.DataSource == null)
                {
                    dataGridView.Rows.Add(new object[] { idMateria.ToString(), cursada.ToString(), cmbMateria.SelectedItem.ToString() });
                }
                else
                {
                    DataTable dataTable = (DataTable)dataGridView.DataSource;
                    DataRow newRow = dataTable.NewRow();
                    newRow["ID_Materia"] = idMateria.ToString();
                    newRow["Cursada"] = cursada.ToString();
                    newRow["Materia"] = cmbMateria.SelectedItem.ToString();
                    dataTable.Rows.Add(newRow);
                    dataGridView.Refresh();
                }

                cmbMateria.SelectedIndex = -1;

                ActualizarTablaLocal();
            }
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptarCarrera_Click(object sender, EventArgs e)
        {
            if (!DatosEntrada.ValidarTexto(txtNombreCarrera, errorProvider, "El nombre de la carrera no puede queadar en blanco")) return;
            if (!DatosEntrada.ValidarNumero(txtResolucion, errorProvider, "Ingrese un numero de resolucion valido")) return;
            if (!DatosEntrada.ValidarTexto(txtDescripcionCarrera, errorProvider, "Debe detallar la carrera")) return;

            nombreCarrera = txtNombreCarrera.Text;
            nResolucion = int.Parse(txtResolucion.Text);
            descripcionCarrera = txtDescripcionCarrera.Text;

            if (esNueva)
            {
                // Crear carrera nueva
                try
                {
                    string connectionString = Global.CADENA_CONEXION;

                    using (SqlConnection conection = new SqlConnection(connectionString))
                    {
                        string query = "";

                        conection.Open();

                        // Crear carrera
                        query = $"INSERT INTO Carreras VALUES (@Nombre, @Resolucion, @Descripcion, 0)";
                        using (SqlCommand comando = new SqlCommand(query, conection))
                        {
                            comando.Parameters.AddWithValue("@Nombre", nombreCarrera);
                            comando.Parameters.AddWithValue("@Resolucion", nResolucion);
                            comando.Parameters.AddWithValue("@Descripcion", descripcionCarrera);

                            comando.ExecuteNonQuery();
                        }

                        // Conseguir id de la carrera creada
                        query = "SELECT IDENT_CURRENT('Carreras')";
                        using (SqlCommand comando = new SqlCommand(query, conection))
                        {
                            string temp = comando.ExecuteScalar().ToString();
                            idCarrera = int.Parse(temp);
                        }

                        conection.Close();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }

            }
            else
            {
                // Editar carrera
                try
                {
                    string connectionString = Global.CADENA_CONEXION;

                    using (SqlConnection conection = new SqlConnection(connectionString))
                    {
                        string query = "";

                        conection.Open();

                        // Editar carrera
                        query = $"UPDATE Carreras SET Nombre = @Nombre, NResolucion = @Resolucion, Descripcion = @Descripcion WHERE ID_Carrera = @ID_Carrera";
                        using (SqlCommand comando = new SqlCommand(query, conection))
                        {
                            comando.Parameters.AddWithValue("@Nombre", nombreCarrera);
                            comando.Parameters.AddWithValue("@Resolucion", nResolucion);
                            comando.Parameters.AddWithValue("@Descripcion", descripcionCarrera);
                            comando.Parameters.AddWithValue("@ID_Carrera", idCarrera);

                            comando.ExecuteNonQuery();
                        }

                        // Borrar las materias para agregar las que se editaron (si, no sera la mejor manera de hacerlo pero bueno, ya no hay tiempo)
                        query = "DELETE FROM MateriasXCarrera WHERE ID_Carrera = @ID_Carrera";
                        using (SqlCommand comando = new SqlCommand(query, conection))
                        {
                            comando.Parameters.AddWithValue("@ID_Carrera", idCarrera);

                            comando.ExecuteNonQuery();
                        }

                        conection.Close();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

            // Agregar materias
            try
            {
                string connectionString = Global.CADENA_CONEXION;

                using (SqlConnection conection = new SqlConnection(connectionString))
                {
                    string query = "";

                    conection.Open();

                    query = "INSERT INTO MateriasXCarrera VALUES (@ID_Carrera, @ID_Materia, @Cursada)";
                    using (SqlCommand comando = new SqlCommand(query, conection))
                    {
                        comando.Parameters.AddWithValue("@ID_Carrera", idCarrera);
                        comando.Parameters.AddWithValue("@ID_Materia", idMateria);
                        comando.Parameters.AddWithValue("@Cursada", cursada);

                        // 0 ID_Materia, 1 año cursada, 2 nombre materia
                        foreach (DataGridViewRow row in dataGridView.Rows)
                        {
                            int idM = int.Parse(row.Cells[0].Value.ToString());
                            int curs = int.Parse(row.Cells[1].Value.ToString());

                            comando.Parameters["@ID_Materia"].Value = idM;
                            comando.Parameters["@Cursada"].Value = curs;

                            comando.ExecuteNonQuery();
                        }
                    }

                    conection.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            MessageBox.Show(esNueva ? "Carrera creada correctamente." : "Carrera actualizada correctamente.");

            OnDatosIngresados(EventArgs.Empty); // Avisa que se cargaron datos nuevos

            Close();
        }

    }
}
