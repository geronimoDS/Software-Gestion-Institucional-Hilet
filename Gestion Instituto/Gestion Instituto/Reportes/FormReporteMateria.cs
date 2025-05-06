using iTextSharp.text.pdf;
using iTextSharp.text;
using iTextSharp.tool.xml;
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

namespace Gestion_Instituto
{
    public partial class FormReporteMateria : Form
    {
        public FormReporteMateria()
        {
            InitializeComponent();
            Estilo.AplicarTodo(this);
        }

        string filas = string.Empty;
        int ID_Carrera = 0;
        int ID_Materia = 0;
        int ID_Anio = 0;
        int ID_Examen = 0;

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
                                cbCarrera.Items.Add(reader["Nombre"].ToString());
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
        private void cbCarrera_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            // Solo continuar si hay una selección válida en el ComboBox
            if (cbCarrera.SelectedIndex != -1)
            {
                try
                {
                    string query = "SELECT ID_Carrera FROM Carreras WHERE Nombre = @Nombre";

                    using (SqlConnection connection = new SqlConnection(Global.CADENA_CONEXION))
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@Nombre", cbCarrera.SelectedItem.ToString());
                            ID_Carrera = (int)command.ExecuteScalar(); // Obtiene el ID de la carrera seleccionada
                            cbMateria.Enabled = true;
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

        public void CargarMaterias()
        {
            cbMateria.Items.Clear();
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
                                cbMateria.Items.Add(reader["Nombre"].ToString());
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

        private void cbMateria_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            // Solo continuar si hay una selección válida en el ComboBox
            if (cbMateria.SelectedIndex != -1)
            {
                try
                {
                    string query = "SELECT ID_Materia FROM Materias WHERE Nombre = @Nombre";

                    using (SqlConnection connection = new SqlConnection(Global.CADENA_CONEXION))
                    {
                        connection.Open();

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@Nombre", cbMateria.SelectedItem.ToString());
                            ID_Materia = (int)command.ExecuteScalar(); // Obtiene el ID de la carrera seleccionada
                            cbAnio.Enabled = true;
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

        private void cbAnio_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (cbAnio.SelectedIndex != -1)
            {
                try
                {
                    ID_Anio = int.Parse(cbAnio.SelectedItem.ToString());
                    cbExamen.Enabled = true;
                    CargarExamen();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($" {ex.Message}");
                }
            }
        }


        public void CargarExamen()
        {
            cbExamen.Items.Clear();
            try
            {
                using (SqlConnection connection = new SqlConnection(Global.CADENA_CONEXION))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("sp_BuscarExamen", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@ID_Carrera", ID_Carrera);
                        command.Parameters.AddWithValue("@ID_Materia", ID_Materia);
                        command.Parameters.AddWithValue("@ID_Anio",ID_Anio);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                cbExamen.Items.Add(reader["TipoExamen"].ToString());
                            }
                        }
                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Primero crea la tabla examen: {ex.Message}");
            }
        }


        private void cbExamen_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cbExamen.SelectedIndex != -1)
            {
                try
                {
                    string query = "SELECT ID_Examen FROM Examen WHERE tipoexamen = @Nombre";

                    using (SqlConnection connection = new SqlConnection(Global.CADENA_CONEXION))
                    {
                        connection.Open();

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@Nombre", cbExamen.SelectedItem.ToString());
                            ID_Examen = (int)command.ExecuteScalar(); // Obtiene el ID de la carrera seleccionada/Retorna un solo valor
                        }

                        string query2 = "SELECT Fecha FROM Examen WHERE tipoexamen = @Nombre";

                        using (SqlCommand command = new SqlCommand(query2, connection))
                        {
                            command.Parameters.AddWithValue("@Nombre", cbExamen.SelectedItem.ToString());
                            lblMostrarFecha.Text = command.ExecuteScalar().ToString(); // Obtiene el ID de la carrera seleccionada/Retorna un solo valor
                        }


                        connection.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Carga al menos un examen: {ex.Message}");
                }
            }
            else
            {
                ID_Materia = 0; // Si no se selecciona nada, el ID es 0
            }
        }
        private void btnBuscarMAt_Click(object sender, EventArgs e)
        {
            if (cbExamen.SelectedIndex != -1)
            {
                try
                {
                    using (SqlConnection conexion = new SqlConnection(Global.CADENA_CONEXION))
                    {
                        conexion.Open();
                        using (SqlCommand sp_SearchALLNOTAS = new SqlCommand("sp_SearchALLNOTAS", conexion))
                        {
                            sp_SearchALLNOTAS.CommandType = CommandType.StoredProcedure;
                            sp_SearchALLNOTAS.Parameters.AddWithValue("@ID_Examen", ID_Examen);
                            sp_SearchALLNOTAS.Parameters.AddWithValue("@ID_Materia", ID_Materia);
                            sp_SearchALLNOTAS.Parameters.AddWithValue("ID_Carrera", ID_Carrera);
                            sp_SearchALLNOTAS.Parameters.AddWithValue("ID_Anio", ID_Anio);
                            try
                            {
                                using (SqlDataAdapter SaveNOtas = new SqlDataAdapter(sp_SearchALLNOTAS)) //Creo un nuevo reader, para traer los datos
                                {
                                    DataTable dt = new DataTable();
                                    //le paso el contenido de "adptador" a "dt" (cargo la tabla)
                                    SaveNOtas.Fill(dt);
                                    //enlazo la grilla con "dt" para mostrar los datos en esa grilla
                                    dgvNotasE.DataSource = dt;
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error: " + ex.Message);
                            }
                        }
                    }
                }
                catch { MessageBox.Show("Seleccione un examen"); }
            }
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormReporteMateria_Load_1(object sender, EventArgs e)
        {
            CargarCarreras();
        }
        private void CargarDatosExamen()
        {
            foreach (DataGridViewRow row in dgvNotasE.Rows)
            {
                if (row.IsNewRow) continue; // Ignora la fila nueva

                filas += "<tr>";

                for (int i = 0; i < row.Cells.Count; i++)
                {
                    // Comprueba si la celda no es nula antes de acceder a su valor
                    var cellValue = row.Cells[i].Value != null ? row.Cells[i].Value.ToString() : string.Empty; //? si, : o
                    filas += "<td>" + cellValue + "</td>";
                }

                filas += "</tr>";
            }

        }
        private void btnPDF_Click(object sender, EventArgs e)
        {
            CargarDatosExamen();
            SaveFileDialog save = new SaveFileDialog(); //Creo un savefiledialog
            save.FileName = $"{cbMateria.SelectedItem.ToString() + " " + cbExamen.SelectedItem.ToString()}.pdf";  //le doy nombre al archivo


            string Texto_Pagina = Properties.Resources.plantillaexamen.ToString();   //Agrego los valores al pdf
            Texto_Pagina = Texto_Pagina.Replace("@Carrera", cbCarrera.SelectedItem.ToString());
            Texto_Pagina = Texto_Pagina.Replace("@Fecha", lblMostrarFecha.Text);



            Texto_Pagina = Texto_Pagina.Replace("@Filas", filas);

            if (save.ShowDialog() == DialogResult.OK) //Verifico si es correcta la direccion
            {
                using (FileStream stream = new FileStream(save.FileName, FileMode.Create)) //Instancio un FileStream
                {

                    Document pdf = new Document(PageSize.A4, 25, 25, 25, 25);   //Utilizo el nugget pdf, para crear un pdf y generarlo con las dimenciones
                    PdfWriter writer = PdfWriter.GetInstance(pdf, stream); //Instancio un pdf
                    pdf.Open(); //Abro el pdf

                    using (StringReader sr = new StringReader(Texto_Pagina))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdf, sr);  //Asigno los valores
                    }

                    pdf.Close();
                    stream.Close();
                }
            }
        }

        private void Clean()
        {
            cbMateria.SelectedIndex = -1;
            cbAnio.SelectedIndex = -1;
            cbExamen.SelectedIndex = -1;
            lblMostrarFecha.Text = string.Empty;
            ID_Carrera = 0;
            ID_Materia = 0;
            ID_Anio = 0;
            ID_Examen = 0;
        }
        
    }
}
