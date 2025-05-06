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
    public partial class FormListaProfesor : Form
    {
        public FormListaProfesor()
        {
            InitializeComponent();
        }

        private void FormListaProfesor_Load(object sender, EventArgs e)
        {
            using (SqlConnection conexion = new SqlConnection(Global.CADENA_CONEXION))    //usando la conexion a sql
            {
                string apellido = "select ID_Personal, Nombre, Apellido from Personal WHERE Cargo = 'profesor'";

                conexion.Open();
                try
                {
                    //preparo el adaptador (nexo) entre la aplicacion y la bdd. Le paso la query y la bdd ya abierta donde ejecutarla
                    SqlDataAdapter adapter = new SqlDataAdapter(apellido, Global.CADENA_CONEXION);
                    //declaro e instancio "dt" de tipo DataTable, para guardar alli, lo que contenga el adaptador
                    DataTable dt = new DataTable();
                    //le paso el contenido de "adptador" a "dt" (cargo la tabla)
                    adapter.Fill(dt);
                    //enlazo la grilla con "dt" para mostrar los datos en esa grilla
                    dgvProfesores.DataSource = dt;
                }
                catch (Exception ex) { }
            }
        }

        private void dgvProfesores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Obtiene la fila actual
                var row = dgvProfesores.CurrentRow;

                if (row != null)
                {
                    // Obtiene el valor de la celda "ID_Matricula"
                    var idMatriculaValue = row.Cells["ID_Personal"].Value;

                    if (idMatriculaValue != null)
                    {
                        // Intenta convertir el valor a int
                        if (int.TryParse(idMatriculaValue.ToString(), out int matAux))
                        {
                            CrearExamen crearexamen = Owner as CrearExamen;
                            if (crearexamen != null)
                            {
                                crearexamen.ID_Profesor = matAux;
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
