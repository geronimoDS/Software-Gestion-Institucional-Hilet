namespace Gestion_Instituto
{
    partial class CrearExamen
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
            pnlCE = new Panel();
            lblAnio = new Label();
            cbAnioE = new ComboBox();
            btnProfesor = new Button();
            lblProfesor = new Label();
            lblFecha = new Label();
            dtpFechaE = new DateTimePicker();
            pnlButton = new Panel();
            btnCrear = new Button();
            btnSalir = new Button();
            lblInstancia = new Label();
            lblMateria = new Label();
            lblCarrera = new Label();
            cbInstanciaE = new ComboBox();
            cbMateriaE = new ComboBox();
            cbCarrerasE = new ComboBox();
            pnlCE.SuspendLayout();
            pnlButton.SuspendLayout();
            SuspendLayout();
            // 
            // pnlCE
            // 
            pnlCE.Controls.Add(lblAnio);
            pnlCE.Controls.Add(cbAnioE);
            pnlCE.Controls.Add(btnProfesor);
            pnlCE.Controls.Add(lblProfesor);
            pnlCE.Controls.Add(lblFecha);
            pnlCE.Controls.Add(dtpFechaE);
            pnlCE.Controls.Add(pnlButton);
            pnlCE.Controls.Add(lblInstancia);
            pnlCE.Controls.Add(lblMateria);
            pnlCE.Controls.Add(lblCarrera);
            pnlCE.Controls.Add(cbInstanciaE);
            pnlCE.Controls.Add(cbMateriaE);
            pnlCE.Controls.Add(cbCarrerasE);
            pnlCE.Dock = DockStyle.Fill;
            pnlCE.Location = new Point(0, 0);
            pnlCE.Name = "pnlCE";
            pnlCE.Size = new Size(484, 411);
            pnlCE.TabIndex = 0;
            // 
            // lblAnio
            // 
            lblAnio.AutoSize = true;
            lblAnio.Font = new Font("Arial", 12F);
            lblAnio.Location = new Point(70, 115);
            lblAnio.Name = "lblAnio";
            lblAnio.Size = new Size(40, 18);
            lblAnio.TabIndex = 12;
            lblAnio.Text = "Año:";
            // 
            // cbAnioE
            // 
            cbAnioE.Enabled = false;
            cbAnioE.Font = new Font("Arial", 12F);
            cbAnioE.FormattingEnabled = true;
            cbAnioE.Items.AddRange(new object[] { "1", "2", "3" });
            cbAnioE.Location = new Point(169, 112);
            cbAnioE.Name = "cbAnioE";
            cbAnioE.Size = new Size(250, 26);
            cbAnioE.TabIndex = 11;
            cbAnioE.SelectedIndexChanged += cbAnioE_SelectedIndexChanged;
            // 
            // btnProfesor
            // 
            btnProfesor.Enabled = false;
            btnProfesor.Font = new Font("Arial", 12F);
            btnProfesor.Location = new Point(169, 231);
            btnProfesor.Name = "btnProfesor";
            btnProfesor.Size = new Size(250, 33);
            btnProfesor.TabIndex = 10;
            btnProfesor.Text = "Seleccionar Profesor";
            btnProfesor.UseVisualStyleBackColor = true;
            btnProfesor.Click += btnProfesor_Click;
            // 
            // lblProfesor
            // 
            lblProfesor.AutoSize = true;
            lblProfesor.Font = new Font("Arial", 12F);
            lblProfesor.Location = new Point(70, 238);
            lblProfesor.Name = "lblProfesor";
            lblProfesor.Size = new Size(72, 18);
            lblProfesor.TabIndex = 9;
            lblProfesor.Text = "Profesor:";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Arial", 12F);
            lblFecha.Location = new Point(70, 197);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(56, 18);
            lblFecha.TabIndex = 8;
            lblFecha.Text = "Fecha:";
            // 
            // dtpFechaE
            // 
            dtpFechaE.Enabled = false;
            dtpFechaE.Font = new Font("Arial", 12F);
            dtpFechaE.Location = new Point(169, 191);
            dtpFechaE.Name = "dtpFechaE";
            dtpFechaE.Size = new Size(250, 26);
            dtpFechaE.TabIndex = 7;
            dtpFechaE.ValueChanged += dtpFechaE_ValueChanged;
            // 
            // pnlButton
            // 
            pnlButton.Controls.Add(btnCrear);
            pnlButton.Controls.Add(btnSalir);
            pnlButton.Dock = DockStyle.Bottom;
            pnlButton.Location = new Point(0, 298);
            pnlButton.Name = "pnlButton";
            pnlButton.Size = new Size(484, 113);
            pnlButton.TabIndex = 6;
            // 
            // btnCrear
            // 
            btnCrear.Enabled = false;
            btnCrear.Location = new Point(279, 15);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(140, 60);
            btnCrear.TabIndex = 1;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(70, 15);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(140, 60);
            btnSalir.TabIndex = 0;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // lblInstancia
            // 
            lblInstancia.AutoSize = true;
            lblInstancia.Font = new Font("Arial", 12F);
            lblInstancia.Location = new Point(70, 156);
            lblInstancia.Name = "lblInstancia";
            lblInstancia.Size = new Size(73, 18);
            lblInstancia.TabIndex = 5;
            lblInstancia.Text = "Instancia:";
            // 
            // lblMateria
            // 
            lblMateria.AutoSize = true;
            lblMateria.Font = new Font("Arial", 12F);
            lblMateria.Location = new Point(70, 74);
            lblMateria.Name = "lblMateria";
            lblMateria.Size = new Size(65, 18);
            lblMateria.TabIndex = 4;
            lblMateria.Text = "Materia:";
            // 
            // lblCarrera
            // 
            lblCarrera.AutoSize = true;
            lblCarrera.Font = new Font("Arial", 12F);
            lblCarrera.Location = new Point(70, 33);
            lblCarrera.Name = "lblCarrera";
            lblCarrera.Size = new Size(66, 18);
            lblCarrera.TabIndex = 3;
            lblCarrera.Text = "Carrera:";
            // 
            // cbInstanciaE
            // 
            cbInstanciaE.Enabled = false;
            cbInstanciaE.Font = new Font("Arial", 12F);
            cbInstanciaE.FormattingEnabled = true;
            cbInstanciaE.Items.AddRange(new object[] { "Instancia 1", "Recuperatorio 1", "Instancia 2", "Recuperatorio 2", "Flotante", "Final" });
            cbInstanciaE.Location = new Point(169, 153);
            cbInstanciaE.Name = "cbInstanciaE";
            cbInstanciaE.Size = new Size(250, 26);
            cbInstanciaE.TabIndex = 2;
            cbInstanciaE.SelectedIndexChanged += cbInstanciaE_SelectedIndexChanged;
            // 
            // cbMateriaE
            // 
            cbMateriaE.Enabled = false;
            cbMateriaE.Font = new Font("Arial", 12F);
            cbMateriaE.FormattingEnabled = true;
            cbMateriaE.Location = new Point(169, 71);
            cbMateriaE.Name = "cbMateriaE";
            cbMateriaE.Size = new Size(250, 26);
            cbMateriaE.TabIndex = 1;
            cbMateriaE.SelectedIndexChanged += cbMateriaE_SelectedIndexChanged;
            // 
            // cbCarrerasE
            // 
            cbCarrerasE.Font = new Font("Arial", 12F);
            cbCarrerasE.FormattingEnabled = true;
            cbCarrerasE.Location = new Point(169, 30);
            cbCarrerasE.Name = "cbCarrerasE";
            cbCarrerasE.Size = new Size(250, 26);
            cbCarrerasE.TabIndex = 0;
            cbCarrerasE.SelectedIndexChanged += cbCarrerasE_SelectedIndexChanged;
            // 
            // CrearExamen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 411);
            Controls.Add(pnlCE);
            Name = "CrearExamen";
            Text = "Crear examen";
            Load += CrearExamen_Load;
            pnlCE.ResumeLayout(false);
            pnlCE.PerformLayout();
            pnlButton.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlCE;
        private Panel pnlButton;
        private Button btnSalir;
        private Label lblInstancia;
        private Label lblMateria;
        private Label lblCarrera;
        private ComboBox cbInstanciaE;
        private ComboBox cbMateriaE;
        private ComboBox cbCarrerasE;
        private Button btnCrear;
        private Label lblProfesor;
        private Label lblFecha;
        private DateTimePicker dtpFechaE;
        private Button btnProfesor;
        private Label lblAnio;
        private ComboBox cbAnioE;
    }
}