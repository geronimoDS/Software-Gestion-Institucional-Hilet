namespace Gestion_Instituto
{
    partial class FormCargarCarrera
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCargarCarrera));
            btnCancelar = new Button();
            btnAceptarCarrera = new Button();
            lblNombre = new Label();
            lblDescripcion = new Label();
            lblResolucion = new Label();
            txtNombreCarrera = new TextBox();
            txtResolucion = new TextBox();
            txtDescripcionCarrera = new TextBox();
            dataGridView = new DataGridView();
            cmbCursada = new ComboBox();
            lblMaterias = new Label();
            btnAgregarMateria = new Button();
            btnQuitarMateria = new Button();
            panel1 = new Panel();
            nuevaMateria = new Button();
            lblMateria = new Label();
            lblCursada = new Label();
            cmbMateria = new ComboBox();
            btnVolver = new Button();
            errorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(265, 465);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(140, 60);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAceptarCarrera
            // 
            btnAceptarCarrera.Location = new Point(479, 465);
            btnAceptarCarrera.Name = "btnAceptarCarrera";
            btnAceptarCarrera.Size = new Size(140, 60);
            btnAceptarCarrera.TabIndex = 8;
            btnAceptarCarrera.Text = "Guardar cambios";
            btnAceptarCarrera.UseVisualStyleBackColor = true;
            btnAceptarCarrera.Click += btnAceptarCarrera_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Arial", 12F);
            lblNombre.Location = new Point(36, 40);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 18);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Arial", 12F);
            lblDescripcion.Location = new Point(35, 82);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(92, 18);
            lblDescripcion.TabIndex = 3;
            lblDescripcion.Text = "Descripcion";
            // 
            // lblResolucion
            // 
            lblResolucion.AutoSize = true;
            lblResolucion.Font = new Font("Arial", 12F);
            lblResolucion.Location = new Point(595, 40);
            lblResolucion.Name = "lblResolucion";
            lblResolucion.Size = new Size(141, 18);
            lblResolucion.TabIndex = 4;
            lblResolucion.Text = "Resolucion numero";
            // 
            // txtNombreCarrera
            // 
            txtNombreCarrera.Font = new Font("Arial", 12F);
            txtNombreCarrera.Location = new Point(106, 37);
            txtNombreCarrera.Name = "txtNombreCarrera";
            txtNombreCarrera.Size = new Size(438, 26);
            txtNombreCarrera.TabIndex = 1;
            // 
            // txtResolucion
            // 
            txtResolucion.Font = new Font("Arial", 12F);
            txtResolucion.Location = new Point(742, 37);
            txtResolucion.Name = "txtResolucion";
            txtResolucion.Size = new Size(100, 26);
            txtResolucion.TabIndex = 2;
            // 
            // txtDescripcionCarrera
            // 
            txtDescripcionCarrera.Font = new Font("Arial", 12F);
            txtDescripcionCarrera.Location = new Point(36, 103);
            txtDescripcionCarrera.Multiline = true;
            txtDescripcionCarrera.Name = "txtDescripcionCarrera";
            txtDescripcionCarrera.Size = new Size(806, 67);
            txtDescripcionCarrera.TabIndex = 3;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(10, 10);
            dataGridView.Margin = new Padding(10);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.ShowEditingIcon = false;
            dataGridView.Size = new Size(435, 203);
            dataGridView.TabIndex = 10;
            // 
            // cmbCursada
            // 
            cmbCursada.Font = new Font("Arial", 12F);
            cmbCursada.FormattingEnabled = true;
            cmbCursada.Items.AddRange(new object[] { "1", "2", "3" });
            cmbCursada.Location = new Point(596, 7);
            cmbCursada.Margin = new Padding(10);
            cmbCursada.MaxDropDownItems = 20;
            cmbCursada.Name = "cmbCursada";
            cmbCursada.Size = new Size(199, 26);
            cmbCursada.TabIndex = 4;
            cmbCursada.SelectedIndexChanged += cmbCursada_SelectedIndexChanged;
            // 
            // lblMaterias
            // 
            lblMaterias.AutoSize = true;
            lblMaterias.Font = new Font("Arial", 12F);
            lblMaterias.Location = new Point(35, 189);
            lblMaterias.Name = "lblMaterias";
            lblMaterias.Size = new Size(69, 18);
            lblMaterias.TabIndex = 10;
            lblMaterias.Text = "Materias";
            // 
            // btnAgregarMateria
            // 
            btnAgregarMateria.Location = new Point(655, 153);
            btnAgregarMateria.Name = "btnAgregarMateria";
            btnAgregarMateria.Size = new Size(140, 60);
            btnAgregarMateria.TabIndex = 6;
            btnAgregarMateria.Text = "Agregar materia";
            btnAgregarMateria.UseVisualStyleBackColor = true;
            btnAgregarMateria.Click += btnAgregarMateria_Click;
            // 
            // btnQuitarMateria
            // 
            btnQuitarMateria.Location = new Point(465, 153);
            btnQuitarMateria.Name = "btnQuitarMateria";
            btnQuitarMateria.Size = new Size(140, 60);
            btnQuitarMateria.TabIndex = 7;
            btnQuitarMateria.Text = "Quitar materia";
            btnQuitarMateria.UseVisualStyleBackColor = true;
            btnQuitarMateria.Click += btnQuitarMateria_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(nuevaMateria);
            panel1.Controls.Add(lblMateria);
            panel1.Controls.Add(lblCursada);
            panel1.Controls.Add(cmbMateria);
            panel1.Controls.Add(btnQuitarMateria);
            panel1.Controls.Add(btnAgregarMateria);
            panel1.Controls.Add(cmbCursada);
            panel1.Controls.Add(dataGridView);
            panel1.Location = new Point(35, 210);
            panel1.Name = "panel1";
            panel1.Size = new Size(807, 225);
            panel1.TabIndex = 13;
            // 
            // nuevaMateria
            // 
            nuevaMateria.BackColor = Color.White;
            nuevaMateria.FlatAppearance.BorderSize = 0;
            nuevaMateria.FlatStyle = FlatStyle.Flat;
            nuevaMateria.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nuevaMateria.ForeColor = SystemColors.ButtonShadow;
            nuevaMateria.Location = new Point(713, 97);
            nuevaMateria.Name = "nuevaMateria";
            nuevaMateria.Size = new Size(82, 26);
            nuevaMateria.TabIndex = 16;
            nuevaMateria.Tag = "";
            nuevaMateria.Text = "Nueva";
            nuevaMateria.UseVisualStyleBackColor = false;
            nuevaMateria.Click += nuevaMateria_Click;
            // 
            // lblMateria
            // 
            lblMateria.AutoSize = true;
            lblMateria.Font = new Font("Arial", 12F);
            lblMateria.Location = new Point(465, 70);
            lblMateria.Name = "lblMateria";
            lblMateria.Size = new Size(61, 18);
            lblMateria.TabIndex = 15;
            lblMateria.Text = "Materia";
            // 
            // lblCursada
            // 
            lblCursada.AutoSize = true;
            lblCursada.Font = new Font("Arial", 12F);
            lblCursada.Location = new Point(465, 10);
            lblCursada.Name = "lblCursada";
            lblCursada.Size = new Size(118, 18);
            lblCursada.TabIndex = 14;
            lblCursada.Text = "Año de cursada";
            // 
            // cmbMateria
            // 
            cmbMateria.Font = new Font("Arial", 12F);
            cmbMateria.FormattingEnabled = true;
            cmbMateria.Location = new Point(465, 98);
            cmbMateria.Margin = new Padding(10);
            cmbMateria.Name = "cmbMateria";
            cmbMateria.Size = new Size(235, 26);
            cmbMateria.Sorted = true;
            cmbMateria.TabIndex = 5;
            cmbMateria.SelectedIndexChanged += cmbMateria_SelectedIndexChanged;
            // 
            // btnVolver
            // 
            btnVolver.Enabled = false;
            btnVolver.Location = new Point(479, 465);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(140, 60);
            btnVolver.TabIndex = 14;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Visible = false;
            btnVolver.Click += btnCancelar_Click;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // FormCargarCarrera
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 561);
            ControlBox = false;
            Controls.Add(panel1);
            Controls.Add(txtDescripcionCarrera);
            Controls.Add(lblMaterias);
            Controls.Add(txtResolucion);
            Controls.Add(txtNombreCarrera);
            Controls.Add(lblResolucion);
            Controls.Add(lblDescripcion);
            Controls.Add(lblNombre);
            Controls.Add(btnAceptarCarrera);
            Controls.Add(btnCancelar);
            Controls.Add(btnVolver);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCargarCarrera";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Crear carrera";
            Load += FormCargarCarrera_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnAceptarCarrera;
        private Label lblNombre;
        private Label lblDescripcion;
        private Label lblResolucion;
        private TextBox txtNombreCarrera;
        private TextBox txtResolucion;
        private TextBox txtDescripcionCarrera;
        private DataGridView dataGridView;
        private ComboBox cmbCursada;
        private Label lblMaterias;
        private Button btnAgregarMateria;
        private Button btnQuitarMateria;
        private Panel panel1;
        private Label lblCursada;
        private ComboBox cmbMateria;
        private Label lblMateria;
        private Button btnVolver;
        private ErrorProvider errorProvider;
        private Button nuevaMateria;
    }
}