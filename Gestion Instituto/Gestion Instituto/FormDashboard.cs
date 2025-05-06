using Gestion_Instituto;
using Gestion_Instituto.Clases;
using Gestion_Instituto.Formularios;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Gestion_Instituto
{
    public partial class FormDashboard : Form
    {
        public FormDashboard(string Username)
        {
            InitializeComponent();

            // Agregar esto a cada formulario
            Estilo.AplicarTodo(this);

            toolStripLabelPermiso.Text = Global.Permiso.ToString();
            toolStripLabelUsuario.Text = Username;
        }

        private void FormDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {
            switch (Global.Permiso)
            {
                case NivelUsuario.ADMIN:
                    // Desabilitar y ocultar botones acceso rapido (irrelevantes para este nivel)
                    btnVerExamenes.Enabled = false;
                    btnVerExamenes.Visible = false;

                    // Opciones adicionales para combo box de busqueda
                    cmbBusqueda.Items.Add("Alumnos");
                    cmbBusqueda.Items.Add("Personal");

                    // Desabilitar y ocultar opciones menuStrip
                    miCuentaToolStripMenuItem.Enabled = false;
                    miCuentaToolStripMenuItem.Visible = false;
                    miReporteToolStripMenuItem.Enabled = false;
                    miReporteToolStripMenuItem.Visible = false;

                    break;

                case NivelUsuario.PERSONAL:
                    // Desabilitar y ocultar opciones menuStrip
                    usuariosToolStripMenuItem.Enabled = false;
                    usuariosToolStripMenuItem.Visible = false;

                    miReporteToolStripMenuItem.Enabled = false;
                    miReporteToolStripMenuItem.Visible = false;

                    // Desabilitar y ocultar botones acceso rapido
                    btnVerExamenes.Enabled = false;
                    btnVerExamenes.Visible = false;

                    btnVerExamenes.Enabled = false;
                    btnVerExamenes.Visible = false;

                    // Opciones adicionales para combo box de busqueda
                    cmbBusqueda.Items.Add("Alumnos");

                    break;

                case NivelUsuario.PROFESOR:
                    // Desabilitar y ocultar opciones menuStrip
                    usuariosToolStripMenuItem.Enabled = false;
                    usuariosToolStripMenuItem.Visible = false;

                    carrerasToolStripMenuItem.Enabled = false;
                    carrerasToolStripMenuItem.Visible = false;

                    alumnosToolStripMenuItem.Enabled = false;
                    alumnosToolStripMenuItem.Visible = false;

                    personalToolStripMenuItem.Enabled = false;
                    personalToolStripMenuItem.Visible = false;

                    nuevaMateriaToolStripMenuItem.Enabled = false;
                    nuevaMateriaToolStripMenuItem.Visible = false;

                    CrearExamen.Enabled = false;
                    CrearExamen.Visible = false;

                    modificarNotasToolStripMenuItem.Enabled = false;
                    modificarNotasToolStripMenuItem.Visible = false;

                    miReporteToolStripMenuItem.Enabled = false;
                    miReporteToolStripMenuItem.Visible = false;

                    // Desabilitar y ocultar botones acceso rapido
                    btnNuevoAlumno.Enabled = false;
                    btnNuevoAlumno.Visible = false;

                    break;

                case NivelUsuario.ALUMNO:
                    // Desabilitar y ocultar opciones menuStrip
                    usuariosToolStripMenuItem.Enabled = false;
                    usuariosToolStripMenuItem.Visible = false;

                    carrerasToolStripMenuItem.Enabled = false;
                    carrerasToolStripMenuItem.Visible = false;

                    alumnosToolStripMenuItem.Enabled = false;
                    alumnosToolStripMenuItem.Visible = false;

                    personalToolStripMenuItem.Enabled = false;
                    personalToolStripMenuItem.Visible = false;

                    nuevaMateriaToolStripMenuItem.Enabled = false;
                    nuevaMateriaToolStripMenuItem.Visible = false;

                    CrearExamen.Enabled = false;
                    CrearExamen.Visible = false;

                    modificarNotasToolStripMenuItem.Enabled = false;
                    modificarNotasToolStripMenuItem.Visible = false;

                    generarToolStripMenuItem.Enabled = false;
                    generarToolStripMenuItem.Visible = false;
                    reporteMateriaToolStripMenuItem.Enabled = false;
                    reporteMateriaToolStripMenuItem.Visible = false;

                    // Desabilitar y ocultar botones acceso rapido
                    btnReportes.Enabled = true;
                    btnReportes.Visible = true;

                    btnNuevoAlumno.Enabled = false;
                    btnNuevoAlumno.Visible = false;

                    btnRegistrarExamen.Enabled = false;
                    btnRegistrarExamen.Visible = false;

                    btnCargarNotas.Enabled = false;
                    btnCargarNotas.Visible = false;

                    break;
            }

            // Opciones adicionales para combo box de busqueda
            cmbBusqueda.Items.Add("Materias");

            // Levantar datos para el resumen
            try
            {
                string query = "";

                using (SqlConnection connection = new SqlConnection(Global.CADENA_CONEXION))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        query = "SELECT COUNT(ID_Matricula) FROM Alumnos WHERE BAJA = 0";
                        command.CommandText = query;
                        lblCantAlumnos.Text = command.ExecuteScalar().ToString();

                        query = "SELECT COUNT(ID_Materia) FROM Materias WHERE BAJA = 0";
                        command.CommandText = query;
                        lblCantMaterias.Text = command.ExecuteScalar().ToString();

                        query = "select AVG(Nota) from NotasXAlumno";
                        command.CommandText = query;
                        lblPromedioNotas.Text = command.ExecuteScalar().ToString();
                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar datos: {ex.Message}");
            }

            timerReloj_Tick(sender, e);
        }

        private void timerReloj_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm");

            lblFecha.Text = DateTime.Now.ToString("dddd dd" + " \\de " + "MMMM" + " \\de " + "yyyy");
        }

        BusquedaResultados busquedaResultados;
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtBuscar.Text) || cmbBusqueda.SelectedIndex == -1) return;

            busquedaResultados = new BusquedaResultados(txtBuscar.Width + cmbBusqueda.Width, this.Location, cmbBusqueda.SelectedItem.ToString(), txtBuscar.Text);
            Debug.WriteLine(this.Location.ToString());
            busquedaResultados.Show();
        }
        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnBuscar_Click(this, new EventArgs());
            }
        }
        private void FormDashboard_Activated(object sender, EventArgs e)
        {
            // Un poco de limpieza, cerrar todo el cuadro de busqueda al clickear afuera y las ventanas que haya abierto si se selecciono algo
            if (busquedaResultados != null)
            {
                busquedaResultados.Close();
            }
        }

        private void btnModoEstilo_Click(object sender, EventArgs e)
        {
            Estilo.ModoOscuro = !Estilo.ModoOscuro;
            btnModoEstilo.Image = Estilo.ModoOscuro ? Properties.Resources.sun : Properties.Resources.moon;
            Estilo.AplicarTodo(this);
            btnBuscar.BackColor = Estilo.ColorPrincipal;
        }


        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Agustín López Cano \nGerónimo Santiny \nGonzalo Ramos Bravo \nNatanael Balta", "Grupo 4",
                MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }


        private void btnVerMaterias_Click(object sender, EventArgs e)
        {
            FormVerDatosGeneral formVerMaterias = new FormVerDatosGeneral(FormVerDatosGeneral.Datos.MATERIAS);
            formVerMaterias.ShowDialog();
        }

        private void nuevaMateriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCargarMateria formCargarMateria = new FormCargarMateria(false);
            formCargarMateria.ShowDialog();
        }

        private void verCarrerasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormVerDatosGeneral formVerCarreras = new FormVerDatosGeneral(FormVerDatosGeneral.Datos.CARRERAS);
            formVerCarreras.ShowDialog();
        }

        private void nuevaCarreraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCargarCarrera formCargarCarrera = new FormCargarCarrera();
            formCargarCarrera.ShowDialog();
        }




        private void btnNuevoAlumno_Click(object sender, EventArgs e)
        {
            // Crear una instancia del segundo formulario
            FormCargarPersonas formAgregarAlumno = new FormCargarPersonas();
            formAgregarAlumno.TipoSeleccion = "Alumno";
            formAgregarAlumno.GroupBoxCarrera();
            formAgregarAlumno.FechaDeHoy();
            formAgregarAlumno.lblFechaParaAlumno();
            formAgregarAlumno.MostrarBotonActualizar();
            formAgregarAlumno.OcultarComboBox5();
            formAgregarAlumno.ShowDialog();
        }


        private void agregarAlumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCargarPersonas formAgregarAlumno = new FormCargarPersonas();
            formAgregarAlumno.TipoSeleccion = "Alumno";
            formAgregarAlumno.GroupBoxCarrera();
            formAgregarAlumno.lblFechaParaAlumno();
            formAgregarAlumno.FechaDeHoy();
            formAgregarAlumno.MostrarBotonActualizar();
            formAgregarAlumno.OcultarComboBox5();
            formAgregarAlumno.ShowDialog();
        }

        private void profesorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormMostrar mostrarForm = new FormMostrar();
            mostrarForm.TipoSeleccion = "Personal";
            mostrarForm.PersonalActivo();
            mostrarForm.BtnDarBaja();
            mostrarForm.ShowDialog();
        }

        private void verAlumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMostrar mostrarForm = new FormMostrar();
            mostrarForm.TipoSeleccion = "Alumno";
            mostrarForm.AlumnosActivos();
            mostrarForm.BtnDarBaja();
            mostrarForm.ShowDialog();

        }


        private void agregToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCargarPersonas formCargarPersonal = new FormCargarPersonas();
            formCargarPersonal.TipoSeleccion = "Personal";
            formCargarPersonal.FechaDeHoy();
            formCargarPersonal.lblFechaParaPersonlal();
            formCargarPersonal.MostrarBotonActualizar();
            formCargarPersonal.MostrarCargo();
            formCargarPersonal.ShowDialog();
        }


        private void miCuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            miPerfil miPerfil = new miPerfil();
            miPerfil.ShowDialog();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VerUsuarios verUsuarios = new VerUsuarios();
            verUsuarios.BtnDarBaja();
            verUsuarios.UsuariosActivos();
            verUsuarios.ShowDialog();

        }
        private void miReporteToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormReporteAlumno formReporteAlumno = new FormReporteAlumno(); //Creo una instancia del form
            formReporteAlumno.permisos();
            formReporteAlumno.BuscarAlumno();
            formReporteAlumno.ShowDialog(); //Muestro el form
        }

        private void generarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReporteAlumno formReporteAlumno = new FormReporteAlumno(); //Creo una instancia del form
            formReporteAlumno.ShowDialog(); //Muestro el form
        }

        private void reporteMateriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReporteMateria formReporteMateria = new FormReporteMateria();
            formReporteMateria.ShowDialog();
        }

        private void CrearExamen_Click(object sender, EventArgs e)
        {
            CrearExamen crearExamenForm = new CrearExamen();
            crearExamenForm.ShowDialog();
        }

        private void VerExamenes_Click(object sender, EventArgs e)
        {
            VerExamenes verExamenes = new VerExamenes();
            verExamenes.ShowDialog();
        }

        private void modificarNotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CargarNotas cargarNotas = new CargarNotas();
            cargarNotas.ShowDialog();
        }

        private void btnRegistrarExamen_Click(object sender, EventArgs e)
        {
            CrearExamen_Click(sender, e);
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            if (Global.Permiso == NivelUsuario.ALUMNO)
                miReporteToolStripMenuItem_Click_1(sender, e);
        }

        private void btnCargarNotas_Click(object sender, EventArgs e)
        {
            modificarNotasToolStripMenuItem_Click(sender, e);
        }

        private void btnVerExamenes_Click(object sender, EventArgs e)
        {
            VerExamenes_Click(sender, e);
        }
    }
}
