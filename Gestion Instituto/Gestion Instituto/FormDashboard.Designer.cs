namespace Gestion_Instituto
{
    partial class FormDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDashboard));
            menuStripDashboard = new MenuStrip();
            inicioToolStripMenuItem = new ToolStripMenuItem();
            miCuentaToolStripMenuItem = new ToolStripMenuItem();
            acercaDeToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            carrerasToolStripMenuItem = new ToolStripMenuItem();
            verCarrerasToolStripMenuItem = new ToolStripMenuItem();
            nuevaCarreraToolStripMenuItem = new ToolStripMenuItem();
            materiasToolStripMenuItem = new ToolStripMenuItem();
            verMateriasToolStripMenuItem = new ToolStripMenuItem();
            nuevaMateriaToolStripMenuItem = new ToolStripMenuItem();
            alumnosToolStripMenuItem = new ToolStripMenuItem();
            verAlumnosToolStripMenuItem = new ToolStripMenuItem();
            agregarAlumnosToolStripMenuItem = new ToolStripMenuItem();
            examenesToolStripMenuItem = new ToolStripMenuItem();
            CrearExamen = new ToolStripMenuItem();
            VerExamenes = new ToolStripMenuItem();
            modificarNotasToolStripMenuItem = new ToolStripMenuItem();
            personalToolStripMenuItem = new ToolStripMenuItem();
            profesorToolStripMenuItem1 = new ToolStripMenuItem();
            agregToolStripMenuItem = new ToolStripMenuItem();
            reportesToolStripMenuItem = new ToolStripMenuItem();
            generarToolStripMenuItem = new ToolStripMenuItem();
            reporteMateriaToolStripMenuItem = new ToolStripMenuItem();
            miReporteToolStripMenuItem = new ToolStripMenuItem();
            usuariosToolStripMenuItem = new ToolStripMenuItem();
            statusStrip = new StatusStrip();
            toolStripLabelPermiso = new ToolStripStatusLabel();
            toolStripLabelUsuario = new ToolStripStatusLabel();
            btnBuscar = new Button();
            txtBuscar = new TextBox();
            lblResumen = new Label();
            lblTextoAlumnos = new Label();
            lblTextoMateria = new Label();
            lblTextoPromedio = new Label();
            lblCantAlumnos = new Label();
            lblCantMaterias = new Label();
            lblPromedioNotas = new Label();
            btnNuevoAlumno = new Button();
            btnRegistrarExamen = new Button();
            btnCargarNotas = new Button();
            btnReportes = new Button();
            LogoHilet = new PictureBox();
            flowAccesoRapido = new FlowLayoutPanel();
            btnVerExamenes = new Button();
            btnVerMaterias = new Button();
            panelResumen = new Panel();
            lblHora = new Label();
            lblFecha = new Label();
            timerReloj = new System.Windows.Forms.Timer(components);
            panelCuadroBusqueda = new Panel();
            btnModoEstilo = new Button();
            cmbBusqueda = new ComboBox();
            linea = new Panel();
            lblAccesoRapido = new Label();
            menuStripDashboard.SuspendLayout();
            statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LogoHilet).BeginInit();
            flowAccesoRapido.SuspendLayout();
            panelResumen.SuspendLayout();
            panelCuadroBusqueda.SuspendLayout();
            SuspendLayout();
            // 
            // menuStripDashboard
            // 
            menuStripDashboard.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStripDashboard.ImageScalingSize = new Size(20, 20);
            menuStripDashboard.Items.AddRange(new ToolStripItem[] { inicioToolStripMenuItem, carrerasToolStripMenuItem, materiasToolStripMenuItem, alumnosToolStripMenuItem, examenesToolStripMenuItem, personalToolStripMenuItem, reportesToolStripMenuItem, usuariosToolStripMenuItem });
            menuStripDashboard.Location = new Point(0, 0);
            menuStripDashboard.Name = "menuStripDashboard";
            menuStripDashboard.Size = new Size(984, 26);
            menuStripDashboard.TabIndex = 1;
            menuStripDashboard.Text = "menuStrip";
            // 
            // inicioToolStripMenuItem
            // 
            inicioToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { miCuentaToolStripMenuItem, acercaDeToolStripMenuItem, salirToolStripMenuItem });
            inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            inicioToolStripMenuItem.Size = new Size(56, 22);
            inicioToolStripMenuItem.Text = "&Inicio";
            // 
            // miCuentaToolStripMenuItem
            // 
            miCuentaToolStripMenuItem.Name = "miCuentaToolStripMenuItem";
            miCuentaToolStripMenuItem.Size = new Size(148, 22);
            miCuentaToolStripMenuItem.Text = "&Mi cuenta";
            miCuentaToolStripMenuItem.Click += miCuentaToolStripMenuItem_Click;
            // 
            // acercaDeToolStripMenuItem
            // 
            acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            acercaDeToolStripMenuItem.Size = new Size(148, 22);
            acercaDeToolStripMenuItem.Text = "&Acerca de";
            acercaDeToolStripMenuItem.Click += acercaDeToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(148, 22);
            salirToolStripMenuItem.Text = "&Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // carrerasToolStripMenuItem
            // 
            carrerasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { verCarrerasToolStripMenuItem, nuevaCarreraToolStripMenuItem });
            carrerasToolStripMenuItem.Name = "carrerasToolStripMenuItem";
            carrerasToolStripMenuItem.Size = new Size(82, 22);
            carrerasToolStripMenuItem.Text = "&Carreras";
            // 
            // verCarrerasToolStripMenuItem
            // 
            verCarrerasToolStripMenuItem.Name = "verCarrerasToolStripMenuItem";
            verCarrerasToolStripMenuItem.Size = new Size(170, 22);
            verCarrerasToolStripMenuItem.Text = "&Ver carreras";
            verCarrerasToolStripMenuItem.Click += verCarrerasToolStripMenuItem_Click;
            // 
            // nuevaCarreraToolStripMenuItem
            // 
            nuevaCarreraToolStripMenuItem.Name = "nuevaCarreraToolStripMenuItem";
            nuevaCarreraToolStripMenuItem.Size = new Size(170, 22);
            nuevaCarreraToolStripMenuItem.Text = "&Crear carrera";
            nuevaCarreraToolStripMenuItem.Click += nuevaCarreraToolStripMenuItem_Click;
            // 
            // materiasToolStripMenuItem
            // 
            materiasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { verMateriasToolStripMenuItem, nuevaMateriaToolStripMenuItem });
            materiasToolStripMenuItem.Name = "materiasToolStripMenuItem";
            materiasToolStripMenuItem.Size = new Size(81, 22);
            materiasToolStripMenuItem.Text = "&Materias";
            // 
            // verMateriasToolStripMenuItem
            // 
            verMateriasToolStripMenuItem.Name = "verMateriasToolStripMenuItem";
            verMateriasToolStripMenuItem.Size = new Size(177, 22);
            verMateriasToolStripMenuItem.Text = "&Ver materias";
            verMateriasToolStripMenuItem.Click += btnVerMaterias_Click;
            // 
            // nuevaMateriaToolStripMenuItem
            // 
            nuevaMateriaToolStripMenuItem.Name = "nuevaMateriaToolStripMenuItem";
            nuevaMateriaToolStripMenuItem.Size = new Size(177, 22);
            nuevaMateriaToolStripMenuItem.Text = "&Nueva materia";
            nuevaMateriaToolStripMenuItem.Click += nuevaMateriaToolStripMenuItem_Click;
            // 
            // alumnosToolStripMenuItem
            // 
            alumnosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { verAlumnosToolStripMenuItem, agregarAlumnosToolStripMenuItem });
            alumnosToolStripMenuItem.Name = "alumnosToolStripMenuItem";
            alumnosToolStripMenuItem.Size = new Size(80, 22);
            alumnosToolStripMenuItem.Text = "&Alumnos";
            // 
            // verAlumnosToolStripMenuItem
            // 
            verAlumnosToolStripMenuItem.Name = "verAlumnosToolStripMenuItem";
            verAlumnosToolStripMenuItem.Size = new Size(195, 22);
            verAlumnosToolStripMenuItem.Text = "&Ver alumnos";
            verAlumnosToolStripMenuItem.Click += verAlumnosToolStripMenuItem_Click;
            // 
            // agregarAlumnosToolStripMenuItem
            // 
            agregarAlumnosToolStripMenuItem.Name = "agregarAlumnosToolStripMenuItem";
            agregarAlumnosToolStripMenuItem.Size = new Size(195, 22);
            agregarAlumnosToolStripMenuItem.Text = "&Agregar alumnos";
            agregarAlumnosToolStripMenuItem.Click += agregarAlumnosToolStripMenuItem_Click;
            // 
            // examenesToolStripMenuItem
            // 
            examenesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { CrearExamen, VerExamenes, modificarNotasToolStripMenuItem });
            examenesToolStripMenuItem.Name = "examenesToolStripMenuItem";
            examenesToolStripMenuItem.Size = new Size(94, 22);
            examenesToolStripMenuItem.Text = "&Examenes";
            // 
            // CrearExamen
            // 
            CrearExamen.Name = "CrearExamen";
            CrearExamen.Size = new Size(177, 22);
            CrearExamen.Text = "Crear Examen";
            CrearExamen.Click += CrearExamen_Click;
            // 
            // VerExamenes
            // 
            VerExamenes.Name = "VerExamenes";
            VerExamenes.Size = new Size(177, 22);
            VerExamenes.Text = "Ver examenes";
            VerExamenes.Click += VerExamenes_Click;
            // 
            // modificarNotasToolStripMenuItem
            // 
            modificarNotasToolStripMenuItem.Name = "modificarNotasToolStripMenuItem";
            modificarNotasToolStripMenuItem.Size = new Size(177, 22);
            modificarNotasToolStripMenuItem.Text = "Cargar notas";
            modificarNotasToolStripMenuItem.Click += modificarNotasToolStripMenuItem_Click;
            // 
            // personalToolStripMenuItem
            // 
            personalToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { profesorToolStripMenuItem1, agregToolStripMenuItem });
            personalToolStripMenuItem.Name = "personalToolStripMenuItem";
            personalToolStripMenuItem.Size = new Size(82, 22);
            personalToolStripMenuItem.Text = "&Personal";
            // 
            // profesorToolStripMenuItem1
            // 
            profesorToolStripMenuItem1.Name = "profesorToolStripMenuItem1";
            profesorToolStripMenuItem1.Size = new Size(186, 22);
            profesorToolStripMenuItem1.Text = "&Ver Personal";
            profesorToolStripMenuItem1.Click += profesorToolStripMenuItem1_Click;
            // 
            // agregToolStripMenuItem
            // 
            agregToolStripMenuItem.Name = "agregToolStripMenuItem";
            agregToolStripMenuItem.Size = new Size(186, 22);
            agregToolStripMenuItem.Text = "&Nuevo Personal";
            agregToolStripMenuItem.Click += agregToolStripMenuItem_Click;
            // 
            // reportesToolStripMenuItem
            // 
            reportesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { generarToolStripMenuItem, reporteMateriaToolStripMenuItem, miReporteToolStripMenuItem });
            reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            reportesToolStripMenuItem.Size = new Size(84, 22);
            reportesToolStripMenuItem.Text = "&Reportes";
            // 
            // generarToolStripMenuItem
            // 
            generarToolStripMenuItem.Name = "generarToolStripMenuItem";
            generarToolStripMenuItem.Size = new Size(189, 22);
            generarToolStripMenuItem.Text = "&Reporte Alumno";
            generarToolStripMenuItem.Click += generarToolStripMenuItem_Click;
            // 
            // reporteMateriaToolStripMenuItem
            // 
            reporteMateriaToolStripMenuItem.Name = "reporteMateriaToolStripMenuItem";
            reporteMateriaToolStripMenuItem.Size = new Size(189, 22);
            reporteMateriaToolStripMenuItem.Text = "&Reporte Materia";
            reporteMateriaToolStripMenuItem.Click += reporteMateriaToolStripMenuItem_Click;
            // 
            // miReporteToolStripMenuItem
            // 
            miReporteToolStripMenuItem.Name = "miReporteToolStripMenuItem";
            miReporteToolStripMenuItem.Size = new Size(189, 22);
            miReporteToolStripMenuItem.Text = "&Mi reporte";
            miReporteToolStripMenuItem.Click += miReporteToolStripMenuItem_Click_1;
            // 
            // usuariosToolStripMenuItem
            // 
            usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            usuariosToolStripMenuItem.Size = new Size(82, 22);
            usuariosToolStripMenuItem.Text = "&Usuarios";
            usuariosToolStripMenuItem.Click += usuariosToolStripMenuItem_Click;
            // 
            // statusStrip
            // 
            statusStrip.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            statusStrip.ImageScalingSize = new Size(20, 20);
            statusStrip.Items.AddRange(new ToolStripItem[] { toolStripLabelPermiso, toolStripLabelUsuario });
            statusStrip.Location = new Point(0, 588);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(984, 23);
            statusStrip.TabIndex = 2;
            statusStrip.Text = "statusStrip";
            // 
            // toolStripLabelPermiso
            // 
            toolStripLabelPermiso.Name = "toolStripLabelPermiso";
            toolStripLabelPermiso.Size = new Size(67, 18);
            toolStripLabelPermiso.Text = "Permiso";
            // 
            // toolStripLabelUsuario
            // 
            toolStripLabelUsuario.Name = "toolStripLabelUsuario";
            toolStripLabelUsuario.Size = new Size(62, 18);
            toolStripLabelUsuario.Text = "Usuario";
            // 
            // btnBuscar
            // 
            btnBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBuscar.BackColor = Color.FromArgb(33, 63, 96);
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Image = Properties.Resources.icono_lupa;
            btnBuscar.Location = new Point(846, 40);
            btnBuscar.Margin = new Padding(0);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(37, 35);
            btnBuscar.TabIndex = 3;
            btnBuscar.Tag = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBuscar.BorderStyle = BorderStyle.FixedSingle;
            txtBuscar.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscar.ForeColor = SystemColors.WindowFrame;
            txtBuscar.Location = new Point(135, 40);
            txtBuscar.Margin = new Padding(0);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(711, 35);
            txtBuscar.TabIndex = 4;
            txtBuscar.Tag = "BarraBusqueda";
            txtBuscar.KeyDown += txtBuscar_KeyDown;
            // 
            // lblResumen
            // 
            lblResumen.AutoSize = true;
            lblResumen.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResumen.Location = new Point(3, 0);
            lblResumen.Name = "lblResumen";
            lblResumen.Size = new Size(115, 27);
            lblResumen.TabIndex = 5;
            lblResumen.Tag = "titulo";
            lblResumen.Text = "Resumen";
            // 
            // lblTextoAlumnos
            // 
            lblTextoAlumnos.AutoSize = true;
            lblTextoAlumnos.Font = new Font("Arial", 12F);
            lblTextoAlumnos.Location = new Point(3, 55);
            lblTextoAlumnos.Name = "lblTextoAlumnos";
            lblTextoAlumnos.Size = new Size(140, 18);
            lblTextoAlumnos.TabIndex = 6;
            lblTextoAlumnos.Text = "Alumnos cursando:";
            // 
            // lblTextoMateria
            // 
            lblTextoMateria.AutoSize = true;
            lblTextoMateria.Font = new Font("Arial", 12F);
            lblTextoMateria.Location = new Point(3, 99);
            lblTextoMateria.Name = "lblTextoMateria";
            lblTextoMateria.Size = new Size(73, 18);
            lblTextoMateria.TabIndex = 7;
            lblTextoMateria.Text = "Materias:";
            // 
            // lblTextoPromedio
            // 
            lblTextoPromedio.AutoSize = true;
            lblTextoPromedio.Font = new Font("Arial", 12F);
            lblTextoPromedio.Location = new Point(3, 143);
            lblTextoPromedio.Name = "lblTextoPromedio";
            lblTextoPromedio.Size = new Size(145, 18);
            lblTextoPromedio.TabIndex = 8;
            lblTextoPromedio.Text = "Promedio de notas:";
            // 
            // lblCantAlumnos
            // 
            lblCantAlumnos.AutoSize = true;
            lblCantAlumnos.Font = new Font("Arial", 12F);
            lblCantAlumnos.Location = new Point(194, 55);
            lblCantAlumnos.Name = "lblCantAlumnos";
            lblCantAlumnos.Size = new Size(17, 18);
            lblCantAlumnos.TabIndex = 9;
            lblCantAlumnos.Text = "0";
            // 
            // lblCantMaterias
            // 
            lblCantMaterias.AutoSize = true;
            lblCantMaterias.Font = new Font("Arial", 12F);
            lblCantMaterias.Location = new Point(194, 99);
            lblCantMaterias.Name = "lblCantMaterias";
            lblCantMaterias.Size = new Size(17, 18);
            lblCantMaterias.TabIndex = 10;
            lblCantMaterias.Text = "0";
            // 
            // lblPromedioNotas
            // 
            lblPromedioNotas.AutoSize = true;
            lblPromedioNotas.Font = new Font("Arial", 12F);
            lblPromedioNotas.Location = new Point(194, 143);
            lblPromedioNotas.Name = "lblPromedioNotas";
            lblPromedioNotas.Size = new Size(17, 18);
            lblPromedioNotas.TabIndex = 11;
            lblPromedioNotas.Text = "0";
            // 
            // btnNuevoAlumno
            // 
            btnNuevoAlumno.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnNuevoAlumno.Font = new Font("Arial", 12F);
            btnNuevoAlumno.Location = new Point(727, 3);
            btnNuevoAlumno.Margin = new Padding(18, 3, 18, 3);
            btnNuevoAlumno.Name = "btnNuevoAlumno";
            btnNuevoAlumno.Size = new Size(140, 40);
            btnNuevoAlumno.TabIndex = 12;
            btnNuevoAlumno.Text = "Nuevo alumno";
            btnNuevoAlumno.UseVisualStyleBackColor = false;
            btnNuevoAlumno.Click += btnNuevoAlumno_Click;
            // 
            // btnRegistrarExamen
            // 
            btnRegistrarExamen.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnRegistrarExamen.Font = new Font("Arial", 12F);
            btnRegistrarExamen.Location = new Point(551, 3);
            btnRegistrarExamen.Margin = new Padding(18, 3, 18, 3);
            btnRegistrarExamen.Name = "btnRegistrarExamen";
            btnRegistrarExamen.Size = new Size(140, 40);
            btnRegistrarExamen.TabIndex = 13;
            btnRegistrarExamen.Text = "Registrar examen";
            btnRegistrarExamen.UseVisualStyleBackColor = true;
            btnRegistrarExamen.Click += btnRegistrarExamen_Click;
            // 
            // btnCargarNotas
            // 
            btnCargarNotas.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCargarNotas.Font = new Font("Arial", 12F);
            btnCargarNotas.Location = new Point(375, 3);
            btnCargarNotas.Margin = new Padding(18, 3, 18, 3);
            btnCargarNotas.Name = "btnCargarNotas";
            btnCargarNotas.Size = new Size(140, 40);
            btnCargarNotas.TabIndex = 14;
            btnCargarNotas.Text = "Cargar notas";
            btnCargarNotas.UseVisualStyleBackColor = true;
            btnCargarNotas.Click += btnCargarNotas_Click;
            // 
            // btnReportes
            // 
            btnReportes.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnReportes.Enabled = false;
            btnReportes.Font = new Font("Arial", 12F);
            btnReportes.Location = new Point(727, 49);
            btnReportes.Margin = new Padding(18, 3, 18, 3);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(140, 40);
            btnReportes.TabIndex = 16;
            btnReportes.Text = "Reportes";
            btnReportes.UseVisualStyleBackColor = true;
            btnReportes.Visible = false;
            btnReportes.Click += btnReportes_Click;
            // 
            // LogoHilet
            // 
            LogoHilet.Image = (Image)resources.GetObject("LogoHilet.Image");
            LogoHilet.Location = new Point(0, 0);
            LogoHilet.Name = "LogoHilet";
            LogoHilet.Size = new Size(135, 40);
            LogoHilet.TabIndex = 17;
            LogoHilet.TabStop = false;
            // 
            // flowAccesoRapido
            // 
            flowAccesoRapido.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowAccesoRapido.Controls.Add(btnNuevoAlumno);
            flowAccesoRapido.Controls.Add(btnRegistrarExamen);
            flowAccesoRapido.Controls.Add(btnCargarNotas);
            flowAccesoRapido.Controls.Add(btnVerExamenes);
            flowAccesoRapido.Controls.Add(btnVerMaterias);
            flowAccesoRapido.Controls.Add(btnReportes);
            flowAccesoRapido.FlowDirection = FlowDirection.RightToLeft;
            flowAccesoRapido.Location = new Point(50, 494);
            flowAccesoRapido.Name = "flowAccesoRapido";
            flowAccesoRapido.Size = new Size(885, 92);
            flowAccesoRapido.TabIndex = 18;
            // 
            // btnVerExamenes
            // 
            btnVerExamenes.Font = new Font("Arial", 12F);
            btnVerExamenes.Location = new Point(199, 3);
            btnVerExamenes.Margin = new Padding(18, 3, 18, 3);
            btnVerExamenes.Name = "btnVerExamenes";
            btnVerExamenes.Size = new Size(140, 40);
            btnVerExamenes.TabIndex = 18;
            btnVerExamenes.Text = "Ver examenes";
            btnVerExamenes.UseVisualStyleBackColor = true;
            btnVerExamenes.Click += btnVerExamenes_Click;
            // 
            // btnVerMaterias
            // 
            btnVerMaterias.Font = new Font("Arial", 12F);
            btnVerMaterias.Location = new Point(23, 3);
            btnVerMaterias.Margin = new Padding(18, 3, 18, 3);
            btnVerMaterias.Name = "btnVerMaterias";
            btnVerMaterias.Size = new Size(140, 40);
            btnVerMaterias.TabIndex = 17;
            btnVerMaterias.Text = "Ver materias";
            btnVerMaterias.UseVisualStyleBackColor = true;
            btnVerMaterias.Click += btnVerMaterias_Click;
            // 
            // panelResumen
            // 
            panelResumen.Controls.Add(lblResumen);
            panelResumen.Controls.Add(lblTextoAlumnos);
            panelResumen.Controls.Add(lblTextoMateria);
            panelResumen.Controls.Add(lblPromedioNotas);
            panelResumen.Controls.Add(lblTextoPromedio);
            panelResumen.Controls.Add(lblCantMaterias);
            panelResumen.Controls.Add(lblCantAlumnos);
            panelResumen.Location = new Point(50, 164);
            panelResumen.Name = "panelResumen";
            panelResumen.Size = new Size(500, 291);
            panelResumen.TabIndex = 19;
            // 
            // lblHora
            // 
            lblHora.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblHora.Font = new Font("Arial", 76F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHora.ForeColor = SystemColors.AppWorkspace;
            lblHora.Location = new Point(619, 164);
            lblHora.Name = "lblHora";
            lblHora.RightToLeft = RightToLeft.No;
            lblHora.Size = new Size(353, 117);
            lblHora.TabIndex = 20;
            lblHora.Tag = "hora";
            lblHora.Text = "00:00";
            lblHora.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblFecha
            // 
            lblFecha.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblFecha.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFecha.ForeColor = SystemColors.AppWorkspace;
            lblFecha.Location = new Point(619, 281);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(316, 27);
            lblFecha.TabIndex = 21;
            lblFecha.Tag = "fecha";
            lblFecha.Text = "Semana 00 de Mes de 0000";
            lblFecha.TextAlign = ContentAlignment.MiddleRight;
            // 
            // timerReloj
            // 
            timerReloj.Enabled = true;
            timerReloj.Interval = 1000;
            timerReloj.Tick += timerReloj_Tick;
            // 
            // panelCuadroBusqueda
            // 
            panelCuadroBusqueda.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelCuadroBusqueda.Controls.Add(btnModoEstilo);
            panelCuadroBusqueda.Controls.Add(cmbBusqueda);
            panelCuadroBusqueda.Controls.Add(btnBuscar);
            panelCuadroBusqueda.Controls.Add(LogoHilet);
            panelCuadroBusqueda.Controls.Add(txtBuscar);
            panelCuadroBusqueda.Location = new Point(50, 55);
            panelCuadroBusqueda.Name = "panelCuadroBusqueda";
            panelCuadroBusqueda.Size = new Size(885, 79);
            panelCuadroBusqueda.TabIndex = 22;
            // 
            // btnModoEstilo
            // 
            btnModoEstilo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnModoEstilo.FlatAppearance.BorderSize = 0;
            btnModoEstilo.FlatStyle = FlatStyle.Flat;
            btnModoEstilo.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnModoEstilo.ForeColor = Color.White;
            btnModoEstilo.Image = Properties.Resources.moon;
            btnModoEstilo.Location = new Point(846, 0);
            btnModoEstilo.Margin = new Padding(0);
            btnModoEstilo.Name = "btnModoEstilo";
            btnModoEstilo.Size = new Size(37, 35);
            btnModoEstilo.TabIndex = 19;
            btnModoEstilo.Tag = "BotonLuz";
            btnModoEstilo.UseVisualStyleBackColor = false;
            btnModoEstilo.Click += btnModoEstilo_Click;
            // 
            // cmbBusqueda
            // 
            cmbBusqueda.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbBusqueda.ForeColor = SystemColors.WindowFrame;
            cmbBusqueda.FormattingEnabled = true;
            cmbBusqueda.Location = new Point(0, 40);
            cmbBusqueda.Margin = new Padding(0);
            cmbBusqueda.Name = "cmbBusqueda";
            cmbBusqueda.Size = new Size(135, 35);
            cmbBusqueda.Sorted = true;
            cmbBusqueda.TabIndex = 18;
            cmbBusqueda.Tag = "Buscar";
            cmbBusqueda.Text = "Buscar...";
            // 
            // linea
            // 
            linea.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            linea.BorderStyle = BorderStyle.FixedSingle;
            linea.Location = new Point(-1, 461);
            linea.Name = "linea";
            linea.Size = new Size(986, 150);
            linea.TabIndex = 0;
            // 
            // lblAccesoRapido
            // 
            lblAccesoRapido.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblAccesoRapido.AutoSize = true;
            lblAccesoRapido.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAccesoRapido.Location = new Point(807, 452);
            lblAccesoRapido.Name = "lblAccesoRapido";
            lblAccesoRapido.Size = new Size(110, 18);
            lblAccesoRapido.TabIndex = 23;
            lblAccesoRapido.Text = "Acceso rapido";
            // 
            // FormDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 611);
            Controls.Add(lblAccesoRapido);
            Controls.Add(flowAccesoRapido);
            Controls.Add(statusStrip);
            Controls.Add(linea);
            Controls.Add(panelCuadroBusqueda);
            Controls.Add(lblFecha);
            Controls.Add(lblHora);
            Controls.Add(panelResumen);
            Controls.Add(menuStripDashboard);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStripDashboard;
            Name = "FormDashboard";
            Text = "Gestion Instituto";
            Activated += FormDashboard_Activated;
            FormClosed += FormDashboard_FormClosed;
            Load += FormDashboard_Load;
            menuStripDashboard.ResumeLayout(false);
            menuStripDashboard.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)LogoHilet).EndInit();
            flowAccesoRapido.ResumeLayout(false);
            panelResumen.ResumeLayout(false);
            panelResumen.PerformLayout();
            panelCuadroBusqueda.ResumeLayout(false);
            panelCuadroBusqueda.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStripDashboard;
        private ToolStripMenuItem inicioToolStripMenuItem;
        private StatusStrip statusStrip;
        private ToolStripMenuItem carrerasToolStripMenuItem;
        private ToolStripMenuItem alumnosToolStripMenuItem;
        private ToolStripMenuItem examenesToolStripMenuItem;
        private ToolStripMenuItem reportesToolStripMenuItem;
        private ToolStripMenuItem usuariosToolStripMenuItem;
        private Button btnBuscar;
        private TextBox txtBuscar;
        private Label lblResumen;
        private Label lblTextoAlumnos;
        private Label lblTextoMateria;
        private Label lblTextoPromedio;
        private Label lblCantAlumnos;
        private Label lblCantMaterias;
        private Label lblPromedioNotas;
        private Button btnNuevoAlumno;
        private Button btnRegistrarExamen;
        private Button btnCargarNotas;
        private Button btnReportes;
        private PictureBox LogoHilet;
        private ToolStripMenuItem agregarAlumnosToolStripMenuItem;
        private ToolStripMenuItem VerExamenes;
        private ToolStripMenuItem CrearExamen;
        private ToolStripMenuItem agregToolStripMenuItem;
        private ToolStripMenuItem profesorToolStripMenuItem1;
        private ToolStripMenuItem modificarNotasToolStripMenuItem;
        private ToolStripMenuItem verCarrerasToolStripMenuItem;
        private ToolStripMenuItem nuevaCarreraToolStripMenuItem;
        private ToolStripMenuItem generarToolStripMenuItem;
        private ToolStripMenuItem verAlumnosToolStripMenuItem;
        private FlowLayoutPanel flowAccesoRapido;
        private Panel panelResumen;
        private Label lblHora;
        private Label lblFecha;
        private System.Windows.Forms.Timer timerReloj;
        private ToolStripStatusLabel toolStripLabelPermiso;
        private Panel panelCuadroBusqueda;
        private Button btnVerMaterias;
        private Button btnVerExamenes;
        private ToolStripMenuItem materiasToolStripMenuItem;
        private ToolStripMenuItem verMateriasToolStripMenuItem;
        private ToolStripMenuItem nuevaMateriaToolStripMenuItem;
        private ToolStripStatusLabel toolStripLabelUsuario;
        private ToolStripMenuItem miCuentaToolStripMenuItem;
        private ToolStripMenuItem acercaDeToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem personalToolStripMenuItem;
        private ToolStripMenuItem reporteMateriaToolStripMenuItem;
        private ComboBox cmbBusqueda;
        private Panel linea;
        private Label lblAccesoRapido;
        private Button btnModoEstilo;
        private ToolStripMenuItem miReporteToolStripMenuItem;
    }
}