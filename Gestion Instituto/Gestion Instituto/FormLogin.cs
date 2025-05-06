using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Gestion_Instituto
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;

            // Agregar esto a cada formulario
            Estilo.AplicarTodo(this);
            MaximumSize = Size;

            StartPosition = FormStartPosition.CenterScreen;
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            try
            {
                string connectionString = Global.CADENA_CONEXION;

                using (SqlConnection conection = new SqlConnection(connectionString))
                {
                    string query = "sp_PrimerArranque";

                    conection.Open();

                    using (SqlCommand comando = new SqlCommand(query, conection))
                    {
                        comando.CommandType = CommandType.StoredProcedure;
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

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            if (!DatosEntrada.ValidarTexto(txtUsuario, errorProviderLogin, "Debe ingresar un usuario valido")) return;
            if (!DatosEntrada.ValidarTexto(txtContrasena, errorProviderLogin, "Debe ingresar una contraseña")) return;

            string connectionString = Global.CADENA_CONEXION;


            string username = txtUsuario.Text;
            string password = txtContrasena.Text;

            string rol = "";
            bool baja = false;
            int idLogin = 0;
            int idPersona = 0;

            string query = "";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    query = "SELECT ID_Login, Rol, Baja FROM Usuarios WHERE Usuario = @Usuario AND Pass = @Pass";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Usuario", username);
                        command.Parameters.AddWithValue("@Pass", password);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                idLogin = (int)reader["ID_Login"];
                                rol = reader["Rol"].ToString();
                                baja = (bool)reader["Baja"];
                            }
                        }
                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción
                MessageBox.Show("Error: " + ex.Message);
            }

            bool getIdPersona = false;

            if (rol != "" && !baja) // Si existe y no esta dado de baja
            {
                switch (rol.ToString())
                {
                    case "administrador":
                        Global.Permiso = NivelUsuario.ADMIN;
                        break;
                    case "personal":
                        Global.Permiso = NivelUsuario.PERSONAL;
                        break;
                    case "profesor":
                        Global.Permiso = NivelUsuario.PROFESOR;
                        getIdPersona = true;
                        query = "SELECT ID_Personal FROM Personal WHERE ID_Login = @ID_Login";
                        break;
                    case "alumno":
                        Global.Permiso = NivelUsuario.ALUMNO;
                        getIdPersona = true;
                        query = "SELECT ID_Matricula FROM Alumnos WHERE ID_Login = @ID_Login";
                        break;
                }

                if (getIdPersona)
                {
                    try
                    {
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open();

                            using (SqlCommand command = new SqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@ID_Login", idLogin);

                                idPersona = (int)command.ExecuteScalar();
                            }


                            if (Global.Permiso == NivelUsuario.ALUMNO)
                            {
                                query = "SELECT ID_Carrera, AnioCursada FROM AlumnosXCarrera WHERE ID_Matricula = @ID_Matricula;";

                                using (SqlCommand command = new SqlCommand(query, connection))
                                {
                                    command.Parameters.AddWithValue("@ID_Matricula", idPersona);

                                    using (SqlDataReader reader = command.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            Global.AlumnoCarrera = (int)reader["ID_Carrera"];
                                            Global.AlumnoCursada = (int)reader["Aniocursada"];
                                        }
                                    }

                                    Debug.WriteLine(Global.AlumnoCarrera);
                                    Debug.WriteLine(Global.AlumnoCursada);
                                }
                            }


                            connection.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        // Manejar cualquier excepción
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }

                Global.ID_Login = idLogin;
                Global.ID_Persona = idPersona;
            }
            else
            {
                MessageBox.Show("El usuario no existe");
                txtUsuario.Clear();
                txtContrasena.Clear();
                txtUsuario.Focus();
                return;
            }




            // Cambiar de ventana
            FormDashboard dashboard = new FormDashboard(username);
            dashboard.StartPosition = FormStartPosition.CenterScreen;
            dashboard.Show();
            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.ActiveControl = txtContrasena;
            }
        }

        private void txtContrasena_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAcceder_Click(sender, e);
            }
        }
    }
}
