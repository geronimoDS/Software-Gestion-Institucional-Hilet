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
    public partial class CargarNotas : Form
    {
        public CargarNotas()
        {
            InitializeComponent();
            Estilo.AplicarTodo(this);
        }

        public int ID_Examen = 0;
        public int ID_Matricula = 0;
        public int Nota = 0;
        public string SApellido = String.Empty;
        bool guardado = false;

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LimpiarCampos()
        {
            txtSearchApellido.Clear();
            txtNota.Clear();
        }

        private void CapError()
        {

            if (txtSearchApellido.Text == "") //Revisa si estan vacios los campos
            {
                errorProvider1.SetError(txtSearchApellido, "Debe de ingresar un Alumno"); //Si es asi, tira un error y muestra el codigo que se escribio
                txtSearchApellido.Focus();
                return;
            }
            errorProvider1.SetError(txtSearchApellido, "");

            if (ID_Matricula == 0)
            {
                errorProvider1.SetError(btnBuscar, "Debe de seleccionar un alumno");
                btnBuscar.Focus();
                return;
            }
            errorProvider1.SetError(btnBuscar, "");

            if (ID_Examen == 0)
            {
                errorProvider1.SetError(btnSeleccionar, "Debe de seleccionar un examen");
                btnSeleccionar.Focus();
                return;
            }
            errorProvider1.SetError(btnSeleccionar, "");

            if (txtNota.Text == "") //Revisa si estan vacios los campos
            {
                errorProvider1.SetError(txtNota, "Debe de ingresar una Nota"); //Si es asi, tira un error y muestra el codigo que se escribio
                txtNota.Focus();
                return;
            }
            errorProvider1.SetError(txtNota, "");

            guardado = true;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            CapError();
            if (guardado == true)
            {
                Nota = Convert.ToInt32(txtNota.Text);
                if (Nota > 0 && Nota <= 10)
                {
                    using (SqlConnection conexion = new SqlConnection(Global.CADENA_CONEXION))
                    {
                        conexion.Open();
                        using (SqlCommand command = new SqlCommand("sp_AgregarNota", conexion))
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@Nota", txtNota.Text);
                            command.Parameters.AddWithValue("@ID_Alumno", ID_Matricula);
                            command.Parameters.AddWithValue("@ID_Examen", ID_Examen);

                            command.ExecuteNonQuery();
                            MessageBox.Show("Nota cargada correctamente");
                        }
                        conexion.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese una nota valida");
                }
            }
            Clean();
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            SApellido = txtSearchApellido.Text;
            using (SqlConnection conexion = new SqlConnection(Global.CADENA_CONEXION))
            {
                conexion.Open();
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

                                    FormListaAlumnos formListaAlumnos = new FormListaAlumnos(SApellido);     //Creo una instancia del form
                                    AddOwnedForm(formListaAlumnos); //Le asigno una propiedad al form
                                    formListaAlumnos.ShowDialog();  //Muestro el form

                                    string query = "SELECT Nombre, Apellido, ID_Matricula FROM Alumnos WHERE ID_Matricula = @ID_Matricula";

                                    reader.Close();

                                    using (SqlCommand command = new SqlCommand(query, conexion))
                                    {
                                        command.Parameters.AddWithValue("@ID_Matricula", ID_Matricula);
                                        using (SqlDataReader lector = command.ExecuteReader())
                                        {
                                            if (lector.Read())
                                            {

                                                lblMostrarApellido.Text = lector["Apellido"].ToString();

                                                lblMostrarNombre.Text = lector["Nombre"].ToString();

                                                lblMostrarMat.Text = lector["ID_Matricula"].ToString();
                                                lector.Close();
                                            }
                                            else
                                            {
                                                MessageBox.Show("Error");
                                            }
                                            lector.Close();
                                        }
                                    }
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
            }
        }

        private void btnSeleccionar_Click_1(object sender, EventArgs e)
        {
            FormListaExamen formListaExamen = new FormListaExamen();
            AddOwnedForm(formListaExamen);
            formListaExamen.ShowDialog();
        }

        private void Clean()
        {
            txtSearchApellido.Clear();
            ID_Examen = 0;
            ID_Matricula = 0;
            Nota = 0;
            SApellido = String.Empty;
            guardado = false;
            txtNota.Clear();
            lblMostrarNombre.Text = String.Empty;
            lblMostrarApellido.Text = String.Empty;
            lblMostrarMat.Text = String.Empty;
        }
        
        private void CargarNotas_Load(object sender, EventArgs e)
        {
            btnBuscar.Width = 101;
            btnBuscar.Height = 26;
        }
    }
}
