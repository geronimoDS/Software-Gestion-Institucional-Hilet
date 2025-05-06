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
    public partial class VerExamenes : Form
    {
        public VerExamenes()
        {
            InitializeComponent();

            Estilo.AplicarTodo(this);
        }

        private void btnCrearExamen_Click(object sender, EventArgs e)
        {
            CrearExamen crearExamen = new CrearExamen();
            crearExamen.ShowDialog();
        }

        private void VerExamenes_Load(object sender, EventArgs e)
        {
            string query = @"SELECT e.ID_Examen, C.nombre AS Carrera, m.nombre AS Materia, e.tipoexamen  AS Instancia , e.Fecha FROM Examen as E
                                        JOIN MateriasXCarrera MA ON E.ID_MateriasXCarrera = MA.ID_MateriasXCarrera
                                        JOIN Carreras C ON MA.ID_Carrera = C.ID_Carrera
                                        JOIN Materias M ON MA.ID_Materia = M.ID_Materia";
            using (SqlConnection connection = new SqlConnection(Global.CADENA_CONEXION))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    try
                    {
                        using (SqlDataAdapter SaveNOtas = new SqlDataAdapter(cmd)) //Creo un nuevo reader, para traer los datos
                        {
                            DataTable dt = new DataTable();
                            //le paso el contenido de "adptador" a "dt" (cargo la tabla)
                            SaveNOtas.Fill(dt);
                            //enlazo la grilla con "dt" para mostrar los datos en esa grilla
                            dgvExamens.DataSource = dt;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }

        }

        private void btnSALIR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCargarNotas_Click(object sender, EventArgs e)
        {
            CargarNotas cargarNotas = new CargarNotas();
            cargarNotas.ShowDialog();
        }
    }
}
