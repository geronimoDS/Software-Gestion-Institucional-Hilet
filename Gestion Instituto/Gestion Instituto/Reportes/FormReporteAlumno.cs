using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data;      //Usado para la conexion sql
using System.Data.SqlClient;

using iTextSharp.text;  //Addons del paquete nugget para creacion de pdfs
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System.IO;
using System.Drawing.Printing;

namespace Gestion_Instituto
{
    public partial class FormReporteAlumno : Form
    {
        public FormReporteAlumno()
        {
            InitializeComponent();
            Estilo.AplicarTodo(this);
            btnBuscar.Width = 100;
            btnBuscar.Height = 25;
        }
        public int Matricula; //Creo la variable matricula, que va a guardar la matricula del usuario, para traer los datos
        string filas = string.Empty;
        private void pnlNotas_Paint(object sender, PaintEventArgs e)
        {

        }

        public void permisos()
        {
            gbMatricula.Visible = false;    //Desactivo la opcion para ingresar el apellido
            gbMatricula.Enabled = false;
            gbDatos.Dock = DockStyle.Fill; //Aumento el tamaño del gbDatos
        }

        public void BuscarAlumno()
        {

            string SApellido = txtSearchApellido.Text.ToString(); //Guardo el Apellido

            string connectionString = Global.CADENA_CONEXION; //Guardo el valor de la conexion a sql


            using (SqlConnection conexion = new SqlConnection(connectionString))    //usando la conexion a sql
            {
                try
                {
                    // Abrir la conexión
                    conexion.Open();

                    string Permiso = Global.Permiso.ToString(); //Guardo el "Permiso" del usuario actual
                    if (Permiso == "ALUMNO")
                    {
                        int ID = Global.ID_Login; //Guardo El ID_Login para hacer una busqueda


                        using (SqlCommand SearchID_Login = new SqlCommand("sp_SearchID_Login", conexion))
                        {

                            // Definir el comando como un procedimiento almacenado
                            SearchID_Login.CommandType = CommandType.StoredProcedure;

                            // Agregar los parámetros del store procedure y los valores que le voy a pasar
                            SearchID_Login.Parameters.AddWithValue("@ID_LOGIN", ID);

                            try
                            {
                                using (SqlDataReader Reader = SearchID_Login.ExecuteReader())
                                {
                                    if (Reader.Read()) // Verifica si hay resultados
                                    {
                                        Matricula = (int)Reader["ID_Matricula"]; //Guardo la matricula del alumno actual
                                    }

                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error: " + ex.Message);
                            }
                        }
                    }
                    else
                        using (SqlCommand SearchApellido = new SqlCommand("sp_SearchAlumn", conexion))
                        {

                            // Definir el comando como un procedimiento almacenado
                            SearchApellido.CommandType = CommandType.StoredProcedure;

                            // Agregar los parámetros del store procedure y los valores que le voy a pasar
                            SearchApellido.Parameters.AddWithValue("@Apellido", SApellido);

                            if (SApellido != "") //Si el campo, no esta vacio
                            {
                                try
                                {
                                    using (SqlDataReader reader = SearchApellido.ExecuteReader())
                                    {
                                        if (reader.Read()) // Verifica si hay resultados
                                        {
                                            reader.Close(); //Cierro el reader, porque no se permite utilizar dos readers a la vez
                                            FormListaAlumnos formListaAlumnos = new FormListaAlumnos(SApellido);     //Creo una instancia del form
                                            AddOwnedForm(formListaAlumnos); //Le asigno una propiedad al form
                                            formListaAlumnos.ShowDialog();  //Muestro el form
                                        }
                                        else
                                        {
                                            MessageBox.Show("No se encontraron resultados.");
                                        }
                                    }
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Error: " + ex.Message);
                                }

                            }
                            else
                            {
                                MessageBox.Show("Ingrese un Apellido");
                            }
                            SearchApellido.ExecuteNonQuery();
                        }
                    // Crear el comando para ejecutar el procedimiento almacenado
                    using (SqlCommand ALLDateAlumn = new SqlCommand("sp_ALLDateAlumn", conexion))
                    {
                        // Definir el comando como un procedimiento almacenado
                        ALLDateAlumn.CommandType = CommandType.StoredProcedure;

                        // Agregar los parámetros del store procedure y los valores que le voy a pasar
                        ALLDateAlumn.Parameters.AddWithValue("@Matricula", Matricula);

                        try
                        {
                            using (SqlDataReader SaveDate = ALLDateAlumn.ExecuteReader()) //Creo un nuevo reader, para traer los datos
                            {
                                if (SaveDate.Read()) //Verifico si hay resultados
                                {
                                    string Estado;

                                    // Asigna los valores a los Labels
                                    lblMostrarApellido.Text = SaveDate["Apellido"].ToString();
                                    lblMostrarNombre.Text = SaveDate["Nombre"].ToString();
                                    lblMostrarDni.Text = SaveDate["DNI"].ToString();
                                    lblMostrarMatricula.Text = SaveDate["ID_Matricula"].ToString();
                                    Matricula = Convert.ToInt32(lblMostrarMatricula.Text);
                                    lblMostrarFNac.Text = SaveDate["FechaNacimiento"].ToString();
                                    lblMostrarMail.Text = SaveDate["Mail"].ToString();
                                    lblMostrarTel.Text = SaveDate["Telefono1"].ToString();
                                    lblMostrarTel2.Text = SaveDate["Telefono2"].ToString();
                                    lblMostrarDomicilio.Text = SaveDate["Domicilio"].ToString();
                                    lblMostrarFIns.Text = SaveDate["FechaInscripcion"].ToString();
                                    Estado = SaveDate["Baja"].ToString();
                                    if (Estado == "False")
                                    {
                                        lblMostrarEstado.Text = "Activo";
                                    }
                                    else { lblMostrarEstado.Text = "Inactivo"; }
                                    SaveDate.Close(); //Cierro el reader

                                    using (SqlCommand ALLNOTAAlum = new SqlCommand("sp_SearchNotas", conexion))
                                    {
                                        ALLNOTAAlum.CommandType = CommandType.StoredProcedure;
                                        ALLNOTAAlum.Parameters.AddWithValue("@Matricula", Matricula);

                                        try
                                        {
                                            using (SqlDataAdapter SaveNOtas = new SqlDataAdapter(ALLNOTAAlum)) //Creo un nuevo reader, para traer los datos
                                            {
                                                DataTable dt = new DataTable();
                                                //le paso el contenido de "adptador" a "dt" (cargo la tabla)
                                                SaveNOtas.Fill(dt);
                                                //enlazo la grilla con "dt" para mostrar los datos en esa grilla
                                                dgvNotas.DataSource = dt;
                                            }
                                            ALLDateAlumn.ExecuteNonQuery();

                                            foreach (DataGridViewRow row in dgvNotas.Rows)
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
                                        catch (Exception ex)
                                        {
                                            MessageBox.Show("Error: " + ex.Message);
                                        }

                                    }

                                }
                            }
                            ALLDateAlumn.ExecuteNonQuery();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Manejar cualquier excepción
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarAlumno();
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog(); //Creo un savefiledialog
            save.FileName = $"{Matricula.ToString()}.pdf";  //le doy nombre al archivo


            string Texto_Pagina = Properties.Resources.plantillafinal.ToString();   //Agrego los valores al pdf
            Texto_Pagina = Texto_Pagina.Replace("@Apellido", lblMostrarApellido.Text);
            Texto_Pagina = Texto_Pagina.Replace("@Nombre", lblMostrarNombre.Text);
            Texto_Pagina = Texto_Pagina.Replace("@Matricula", lblMostrarMatricula.Text);
            Texto_Pagina = Texto_Pagina.Replace("@DNI", lblMostrarDni.Text);
            Texto_Pagina = Texto_Pagina.Replace("@FechaInsc", lblMostrarFIns.Text);



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

        private void btnFRAS_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormReporteAlumno_Load_1(object sender, EventArgs e)
        {

        }
    }
}
