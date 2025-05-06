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
    public partial class FormListaExamen : Form
    {
        public FormListaExamen()
        {
            InitializeComponent();
            Estilo.AplicarTodo(this);
            this.ControlBox = true;
        }

        private void FormListaExamen_Load(object sender, EventArgs e)
        {
            using (SqlConnection conexion = new SqlConnection(Global.CADENA_CONEXION))    //usando la conexion a sql
            {
                string ID_Examen = @"SELECT e.ID_Examen, C.nombre AS Carrera, m.nombre AS Materia, e.tipoexamen  AS Instancia , e.Fecha FROM Examen as E
                                                JOIN MateriasXCarrera MA ON E.ID_MateriasXCarrera = MA.ID_MateriasXCarrera
                                                JOIN Carreras C ON MA.ID_Carrera = C.ID_Carrera
                                                JOIN Materias M ON MA.ID_Materia = M.ID_Materia";

                conexion.Open();
                try
                {
                    //preparo el adaptador (nexo) entre la aplicacion y la bdd. Le paso la query y la bdd ya abierta donde ejecutarla
                    SqlDataAdapter adapter = new SqlDataAdapter(ID_Examen, Global.CADENA_CONEXION);
                    //declaro e instancio "dt" de tipo DataTable, para guardar alli, lo que contenga el adaptador
                    DataTable dt = new DataTable();
                    //le paso el contenido de "adptador" a "dt" (cargo la tabla)
                    adapter.Fill(dt);
                    //enlazo la grilla con "dt" para mostrar los datos en esa grilla
                    dgvLE.DataSource = dt;
                }
                catch (Exception ex) { }
            }
            
        }

        private void dgvLE_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Obtiene la fila actual
                var row = dgvLE.CurrentRow;

                if (row != null)
                {
                    // Obtiene el valor de la celda "ID_Matricula"
                    var idMatriculaValue = row.Cells["ID_Examen"].Value;

                    if (idMatriculaValue != null)
                    {
                        // Intenta convertir el valor a int
                        if (int.TryParse(idMatriculaValue.ToString(), out int matAux))
                        {
                            CargarNotas cargarNotas = Owner as CargarNotas;
                            if (cargarNotas != null)
                            {
                                cargarNotas.ID_Examen = matAux;
                            }
                        }
                        else
                        {
                            MessageBox.Show("El valor de ID del examen no es un número válido.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("El valor de ID del examen es nulo.");
                    }
                }
                this.Close();
            }
        }

        private void dgvLE_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
