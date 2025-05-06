namespace Gestion_Instituto
{
    partial class FormReporteMateria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReporteMateria));
            pnlFRM = new Panel();
            pnlDGVMAT = new Panel();
            gbNotas = new GroupBox();
            dgvNotasE = new DataGridView();
            panel1 = new Panel();
            btnPDF = new Button();
            btnSalir = new Button();
            pnlSearchMaterias = new Panel();
            gbAnio = new GroupBox();
            cbAnio = new ComboBox();
            lblMostrarFecha = new Label();
            lblFecha = new Label();
            btnBuscarMAt = new Button();
            gbExamen = new GroupBox();
            cbExamen = new ComboBox();
            gbMateria = new GroupBox();
            cbMateria = new ComboBox();
            gpCarrera = new GroupBox();
            cbCarrera = new ComboBox();
            pnlFRM.SuspendLayout();
            pnlDGVMAT.SuspendLayout();
            gbNotas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNotasE).BeginInit();
            panel1.SuspendLayout();
            pnlSearchMaterias.SuspendLayout();
            gbAnio.SuspendLayout();
            gbExamen.SuspendLayout();
            gbMateria.SuspendLayout();
            gpCarrera.SuspendLayout();
            SuspendLayout();
            // 
            // pnlFRM
            // 
            pnlFRM.Controls.Add(pnlDGVMAT);
            pnlFRM.Controls.Add(panel1);
            pnlFRM.Controls.Add(pnlSearchMaterias);
            pnlFRM.Dock = DockStyle.Fill;
            pnlFRM.Location = new Point(0, 0);
            pnlFRM.Name = "pnlFRM";
            pnlFRM.Size = new Size(800, 450);
            pnlFRM.TabIndex = 0;
            // 
            // pnlDGVMAT
            // 
            pnlDGVMAT.Controls.Add(gbNotas);
            pnlDGVMAT.Dock = DockStyle.Right;
            pnlDGVMAT.Location = new Point(264, 0);
            pnlDGVMAT.Name = "pnlDGVMAT";
            pnlDGVMAT.Size = new Size(536, 376);
            pnlDGVMAT.TabIndex = 6;
            // 
            // gbNotas
            // 
            gbNotas.Controls.Add(dgvNotasE);
            gbNotas.Dock = DockStyle.Fill;
            gbNotas.Location = new Point(0, 0);
            gbNotas.Name = "gbNotas";
            gbNotas.Size = new Size(536, 376);
            gbNotas.TabIndex = 3;
            gbNotas.TabStop = false;
            gbNotas.Text = "Notas";
            // 
            // dgvNotasE
            // 
            dgvNotasE.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNotasE.Dock = DockStyle.Fill;
            dgvNotasE.Location = new Point(3, 19);
            dgvNotasE.Name = "dgvNotasE";
            dgvNotasE.Size = new Size(530, 354);
            dgvNotasE.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonFace;
            panel1.Controls.Add(btnPDF);
            panel1.Controls.Add(btnSalir);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 376);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 74);
            panel1.TabIndex = 5;
            // 
            // btnPDF
            // 
            btnPDF.Location = new Point(12, 6);
            btnPDF.Name = "btnPDF";
            btnPDF.Size = new Size(140, 60);
            btnPDF.TabIndex = 4;
            btnPDF.Text = "PDF";
            btnPDF.UseVisualStyleBackColor = true;
            btnPDF.Click += btnPDF_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(648, 6);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(140, 60);
            btnSalir.TabIndex = 11;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click_1;
            // 
            // pnlSearchMaterias
            // 
            pnlSearchMaterias.Controls.Add(gbAnio);
            pnlSearchMaterias.Controls.Add(lblMostrarFecha);
            pnlSearchMaterias.Controls.Add(lblFecha);
            pnlSearchMaterias.Controls.Add(btnBuscarMAt);
            pnlSearchMaterias.Controls.Add(gbExamen);
            pnlSearchMaterias.Controls.Add(gbMateria);
            pnlSearchMaterias.Controls.Add(gpCarrera);
            pnlSearchMaterias.Location = new Point(0, 0);
            pnlSearchMaterias.Name = "pnlSearchMaterias";
            pnlSearchMaterias.Size = new Size(267, 393);
            pnlSearchMaterias.TabIndex = 4;
            // 
            // gbAnio
            // 
            gbAnio.Controls.Add(cbAnio);
            gbAnio.Location = new Point(3, 121);
            gbAnio.Name = "gbAnio";
            gbAnio.Size = new Size(242, 53);
            gbAnio.TabIndex = 3;
            gbAnio.TabStop = false;
            gbAnio.Text = "Año";
            // 
            // cbAnio
            // 
            cbAnio.Enabled = false;
            cbAnio.FormattingEnabled = true;
            cbAnio.Items.AddRange(new object[] { "1", "2", "3" });
            cbAnio.Location = new Point(25, 22);
            cbAnio.Name = "cbAnio";
            cbAnio.Size = new Size(211, 23);
            cbAnio.TabIndex = 0;
            cbAnio.SelectedIndexChanged += cbAnio_SelectedIndexChanged;
            // 
            // lblMostrarFecha
            // 
            lblMostrarFecha.AutoSize = true;
            lblMostrarFecha.Location = new Point(101, 264);
            lblMostrarFecha.Name = "lblMostrarFecha";
            lblMostrarFecha.Size = new Size(0, 15);
            lblMostrarFecha.TabIndex = 5;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(28, 240);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(86, 15);
            lblFecha.TabIndex = 4;
            lblFecha.Text = "Fecha Examen:";
            // 
            // btnBuscarMAt
            // 
            btnBuscarMAt.Location = new Point(65, 293);
            btnBuscarMAt.Name = "btnBuscarMAt";
            btnBuscarMAt.Size = new Size(118, 48);
            btnBuscarMAt.TabIndex = 3;
            btnBuscarMAt.Text = "Buscar";
            btnBuscarMAt.UseVisualStyleBackColor = true;
            btnBuscarMAt.Click += btnBuscarMAt_Click;
            // 
            // gbExamen
            // 
            gbExamen.Controls.Add(cbExamen);
            gbExamen.Location = new Point(3, 180);
            gbExamen.Name = "gbExamen";
            gbExamen.Size = new Size(242, 53);
            gbExamen.TabIndex = 2;
            gbExamen.TabStop = false;
            gbExamen.Text = "Examen";
            // 
            // cbExamen
            // 
            cbExamen.Enabled = false;
            cbExamen.FormattingEnabled = true;
            cbExamen.Location = new Point(25, 22);
            cbExamen.Name = "cbExamen";
            cbExamen.Size = new Size(211, 23);
            cbExamen.TabIndex = 0;
            cbExamen.SelectedIndexChanged += cbExamen_SelectedIndexChanged_1;
            // 
            // gbMateria
            // 
            gbMateria.Controls.Add(cbMateria);
            gbMateria.Location = new Point(3, 62);
            gbMateria.Name = "gbMateria";
            gbMateria.Size = new Size(242, 53);
            gbMateria.TabIndex = 1;
            gbMateria.TabStop = false;
            gbMateria.Text = "Materia";
            // 
            // cbMateria
            // 
            cbMateria.Enabled = false;
            cbMateria.FormattingEnabled = true;
            cbMateria.Location = new Point(25, 22);
            cbMateria.Name = "cbMateria";
            cbMateria.Size = new Size(211, 23);
            cbMateria.TabIndex = 0;
            cbMateria.SelectedIndexChanged += cbMateria_SelectedIndexChanged_1;
            // 
            // gpCarrera
            // 
            gpCarrera.Controls.Add(cbCarrera);
            gpCarrera.Location = new Point(3, 3);
            gpCarrera.Name = "gpCarrera";
            gpCarrera.Size = new Size(242, 53);
            gpCarrera.TabIndex = 0;
            gpCarrera.TabStop = false;
            gpCarrera.Text = "Carrera";
            // 
            // cbCarrera
            // 
            cbCarrera.FormattingEnabled = true;
            cbCarrera.Location = new Point(25, 22);
            cbCarrera.Name = "cbCarrera";
            cbCarrera.Size = new Size(211, 23);
            cbCarrera.TabIndex = 0;
            cbCarrera.SelectedIndexChanged += cbCarrera_SelectedIndexChanged_1;
            // 
            // FormReporteMateria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlFRM);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(816, 489);
            MinimumSize = new Size(816, 489);
            Name = "FormReporteMateria";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "Reporte de materias";
            Load += FormReporteMateria_Load_1;
            pnlFRM.ResumeLayout(false);
            pnlDGVMAT.ResumeLayout(false);
            gbNotas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvNotasE).EndInit();
            panel1.ResumeLayout(false);
            pnlSearchMaterias.ResumeLayout(false);
            pnlSearchMaterias.PerformLayout();
            gbAnio.ResumeLayout(false);
            gbExamen.ResumeLayout(false);
            gbMateria.ResumeLayout(false);
            gpCarrera.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlFRM;
        private Panel pnlDGVMAT;
        private GroupBox gbNotas;
        private DataGridView dgvNotasE;
        private Panel panel1;
        private Button btnSalir;
        private Panel pnlSearchMaterias;
        private Button btnBuscarMAt;
        private GroupBox gbExamen;
        private ComboBox cbExamen;
        private GroupBox gbMateria;
        private ComboBox cbMateria;
        private GroupBox gpCarrera;
        private ComboBox cbCarrera;
        private Button btnPDF;
        private Label lblMostrarFecha;
        private Label lblFecha;
        private GroupBox gbAnio;
        private ComboBox cbAnio;
    }
}