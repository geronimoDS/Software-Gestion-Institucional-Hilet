using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Instituto.Formularios
{
    public partial class miPerfil : Form
    {
        string connectionString = Global.CADENA_CONEXION;
        public miPerfil()
        {
            InitializeComponent();
            Estilo.AplicarTodo(this);
            MaximumSize = Size;
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.ReadOnly)
            {
                txtUsuario.ReadOnly = false;
                txtPass.ReadOnly = false;
            }
            else
            {
                if (!DatosEntrada.ValidarTexto(txtUsuario, errorProvider, "El usuario no peude estar vacio")) return;
                if (!DatosEntrada.ValidarTexto(txtPass, errorProvider, "La contraseña no peude estar vacia")) return;
                groupBoxAcualizar.Visible = true;
                groupBoxAcualizar.Enabled = true;
                groupUsuarioYPass.Visible = false;
                groupUsuarioYPass.Enabled = false;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            groupBoxAcualizar.Enabled = false;
            groupBoxAcualizar.Visible = false;
            txtUsuario.ReadOnly = true;
            txtPass.ReadOnly = true;
            groupUsuarioYPass.Visible = true;
            groupUsuarioYPass.Enabled = true;
        }

        private void btnVolverMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void miPerfil_Load(object sender, EventArgs e)
        {
            // Conexión a la base de datos
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string Permiso = Global.Permiso.ToString();
                    int idLogin = Global.ID_Login;

                    string sql = "";

                    switch (Permiso)
                    {
                        case "ALUMNO":
                            gbCarrera.Enabled = true;
                            gbCarrera.Visible = true;
                            // Consulta SQL
                            sql = @"
                                 SELECT 
                                       Alumnos.Nombre,
                                       Alumnos.Apellido,
                                       Alumnos.DNI,
                                       Usuarios.Usuario,
                                       Usuarios.Pass,
                                       Carreras.Nombre as NombreC,
		                               AlumnosXCarrera.AnioCursada
                                   FROM 
                                       Alumnos
                                   JOIN 
                                       Usuarios ON Usuarios.ID_Login = Alumnos.ID_Login
                                   JOIN 
                                       AlumnosXCarrera ON Alumnos.ID_Matricula = AlumnosXCarrera.ID_Matricula
                                   JOIN
                                       Carreras ON Carreras.ID_Carrera = AlumnosXCarrera.ID_Carrera 
                                   WHERE 
                                       Usuarios.ID_Login = @ID_Login";

                            using (SqlCommand command = new SqlCommand(sql, connection))
                            {
                                command.Parameters.AddWithValue("@ID_Login", idLogin);
                                SqlDataReader reader = command.ExecuteReader();

                                if (reader.Read())
                                {
                                    txtNombre.Text = reader["Nombre"].ToString();
                                    txtApellido.Text = reader["Apellido"].ToString();
                                    txtIdLogin.Text = reader["DNI"].ToString();
                                    txtUsuario.Text = reader["Usuario"].ToString();
                                    txtPass.Text = reader["Pass"].ToString();
                                    txtCarrera.Text = reader["NombreC"].ToString();
                                    txtAño.Text = reader["AnioCursada"].ToString();
                                }
                                else
                                {
                                    MessageBox.Show("No se encontraron resultados.");
                                }
                            }
                            break;
                        case "PROFESOR":
                            gbAsignaturas.Enabled = true;
                            gbAsignaturas.Visible = true;
                            sql = @"
                                        SELECT 
                                               p.Nombre,
                                               p.Apellido,
                                               p.DNI,
                                               u.Usuario,
                                               u.Pass
                                                   FROM 
                                                       Personal as p
		                                            JOIN Usuarios u ON u.ID_Login = p.ID_Login
                                                   WHERE 
                                                       u.ID_Login = @ID_Login";
                            string sql2 = @"
                                            SELECT 
                                               m.Nombre as Materia,
                                               c.nombre as Carrera
                                                   FROM 
                                                       Personal as p
		                                            JOIN Usuarios u ON u.ID_Login = p.ID_Login
		                                            JOIN ProfesoresXMaterias PM on p.ID_Personal = PM.ID_Profesor
		                                            JOIN Materias m ON PM.ID_Materia = m.ID_Materia
		                                            JOIN MateriasXCarrera MC ON M.ID_Materia = mc.ID_Materia 
		                                            JOIN Carreras c on MC.ID_Carrera = c.ID_Carrera
                                                   WHERE 
                                                       u.ID_Login = " + idLogin;
                            using (SqlCommand command = new SqlCommand(sql, connection))
                            {
                                command.Parameters.AddWithValue("@ID_Login", idLogin);
                                SqlDataReader reader = command.ExecuteReader();

                                if (reader.Read())
                                {
                                    txtNombre.Text = reader["Nombre"].ToString();
                                    txtApellido.Text = reader["Apellido"].ToString();
                                    txtIdLogin.Text = reader["DNI"].ToString();
                                    txtUsuario.Text = reader["Usuario"].ToString();
                                    txtPass.Text = reader["Pass"].ToString();

                                    reader.Close();
                                    using (SqlConnection Conector = new SqlConnection(connectionString))
                                    {
                                        Conector.Open();

                                            SqlDataAdapter adaptador = new SqlDataAdapter(sql2, connection);
                                            DataTable dataTable = new DataTable();

                                            // Llenar el DataTable con los datos de la consulta
                                            adaptador.Fill(dataTable);

                                            // Asignar el DataTable al DataGridView
                                            dgvAsignaturas.DataSource = dataTable;
                                    }
                                }



                                else
                                {
                                    MessageBox.Show("No se encontraron resultados.");
                                }
                            }
                            break;
                        case "PERSONAL":
                            sql = @"
                                        SELECT 
                                           Personal.Nombre,
                                           Personal.Apellido,
                                           Personal.DNI,
                                           Usuarios.Usuario,
                                           Usuarios.Pass
                                               FROM 
                                                   Personal
                                               JOIN 
                                                   Usuarios ON Usuarios.ID_Login = Personal.ID_Login
                                               WHERE 
                                                   Usuarios.ID_Login = @ID_Login";

                            using (SqlCommand command = new SqlCommand(sql, connection))
                            {
                                command.Parameters.AddWithValue("@ID_Login", idLogin);
                                SqlDataReader reader = command.ExecuteReader();

                                if (reader.Read())
                                {
                                    txtNombre.Text = reader["Nombre"].ToString();
                                    txtApellido.Text = reader["Apellido"].ToString();
                                    txtIdLogin.Text = reader["DNI"].ToString();
                                    txtUsuario.Text = reader["Usuario"].ToString();
                                    txtPass.Text = reader["Pass"].ToString();
                                }
                                else
                                {
                                    MessageBox.Show("No se encontraron resultados.");
                                }
                            }
                            break;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                groupBoxAcualizar.Enabled = true;
                groupBoxAcualizar.Visible = true;
                try
                {


                    // Obtener el ID_Login del ...(deberia traer el ID_Login del EMUMERADO)

                    int idLogin = Global.ID_Login;
                    string permiso = Global.Permiso.ToString();
                    string sql = "";



                    using (SqlCommand comandoSql = new SqlCommand("sp_ActualizarMiPerfil", conexion))
                    {
                        conexion.Open();
                        int estado = 0;
                        // Definir el comando como un procedimiento almacenado
                        comandoSql.CommandType = CommandType.StoredProcedure;

                        // Agrego parámetros y sus valores
                        comandoSql.Parameters.AddWithValue("@ID_Login ", idLogin);
                        comandoSql.Parameters.AddWithValue("@Pass", txtPasss.Text);
                        //  comandoSql.Parameters.AddWithValue("@Rol", comboBoxRol.Text);

                        comandoSql.ExecuteNonQuery();

                        MessageBox.Show("Usuario actualizado correctamente");
                        // UsuariosActivos();
                        //   LimpiarCampos();
                        conexion.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                groupBoxAcualizar.Enabled = false;
                groupBoxAcualizar.Visible = false;
                txtUsuario.ReadOnly = true;
                txtPass.ReadOnly = true;
                groupUsuarioYPass.Visible = true;
                groupUsuarioYPass.Enabled = true;
            }
        }
    }

}
