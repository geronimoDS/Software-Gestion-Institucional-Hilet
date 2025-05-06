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
    public partial class FormListaAlumnos : Form
    {
        string Apellido;
        public FormListaAlumnos(string SApellido)
        {
            InitializeComponent();
            Apellido = SApellido;
            Estilo.AplicarTodo(this);
        }

        public string connectionString = Global.CADENA_CONEXION;


        private void dgvLA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void FormListaAlumnos_Load(object sender, EventArgs e)
        {
            using (SqlConnection conexion = new SqlConnection(connectionString))    //usando la conexion a sql
            {
                string apellido = $"EXEC sp_SearchAlumn {Apellido}";

                conexion.Open();
                try
                {
                    //preparo el adaptador (nexo) entre la aplicacion y la bdd. Le paso la query y la bdd ya abierta donde ejecutarla
                    SqlDataAdapter adapter = new SqlDataAdapter(apellido, connectionString);
                    //declaro e instancio "dt" de tipo DataTable, para guardar alli, lo que contenga el adaptador
                    DataTable dt = new DataTable();
                    //le paso el contenido de "adptador" a "dt" (cargo la tabla)
                    adapter.Fill(dt);
                    //enlazo la grilla con "dt" para mostrar los datos en esa grilla
                    dgvLA.DataSource = dt;
                }
                catch (Exception ex) { }
            }
        }

        private void dgvLA_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Obtiene la fila actual
                var row = dgvLA.CurrentRow;

                if (row != null)
                {
                    // Obtiene el valor de la celda "ID_Matricula"
                    var idMatriculaValue = row.Cells["ID_Matricula"].Value;

                    if (idMatriculaValue != null)
                    {
                        // Intenta convertir el valor a int
                        if (int.TryParse(idMatriculaValue.ToString(), out int matAux))
                        {
                            FormReporteAlumno formReporteAlumno = Owner as FormReporteAlumno;
                            if (formReporteAlumno != null)
                            {
                                formReporteAlumno.Matricula = matAux;
                            }
                            CargarNotas cargar = Owner as CargarNotas;
                            if (cargar != null)
                            {
                                cargar.ID_Matricula = matAux;
                            }
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("El ID de matrícula no es un número válido.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("El valor de ID de matrícula es nulo.");
                    }
                }
            }
        }
    }
}
