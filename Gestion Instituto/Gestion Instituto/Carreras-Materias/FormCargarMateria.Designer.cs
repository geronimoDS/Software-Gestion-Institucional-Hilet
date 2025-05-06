namespace Gestion_Instituto
{
    partial class FormCargarMateria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCargarMateria));
            lblNombreMateria = new Label();
            lblDescripcionMateria = new Label();
            lblProfesor = new Label();
            txtNombreMateria = new TextBox();
            txtDescripcionMateria = new TextBox();
            comboBoxProfesor = new ComboBox();
            btnAceptarMateria = new Button();
            btnCancelar = new Button();
            errorProvider = new ErrorProvider(components);
            btnVolver = new Button();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // lblNombreMateria
            // 
            lblNombreMateria.AutoSize = true;
            lblNombreMateria.Font = new Font("Arial", 12F);
            lblNombreMateria.Location = new Point(70, 64);
            lblNombreMateria.Name = "lblNombreMateria";
            lblNombreMateria.Size = new Size(64, 18);
            lblNombreMateria.TabIndex = 0;
            lblNombreMateria.Text = "Nombre";
            // 
            // lblDescripcionMateria
            // 
            lblDescripcionMateria.AutoSize = true;
            lblDescripcionMateria.Font = new Font("Arial", 12F);
            lblDescripcionMateria.Location = new Point(70, 101);
            lblDescripcionMateria.Name = "lblDescripcionMateria";
            lblDescripcionMateria.Size = new Size(92, 18);
            lblDescripcionMateria.TabIndex = 1;
            lblDescripcionMateria.Text = "Descripcion";
            // 
            // lblProfesor
            // 
            lblProfesor.AutoSize = true;
            lblProfesor.Font = new Font("Arial", 12F);
            lblProfesor.Location = new Point(70, 234);
            lblProfesor.Name = "lblProfesor";
            lblProfesor.Size = new Size(124, 18);
            lblProfesor.TabIndex = 2;
            lblProfesor.Text = "Asignar profesor";
            // 
            // txtNombreMateria
            // 
            txtNombreMateria.Font = new Font("Arial", 12F);
            txtNombreMateria.Location = new Point(140, 61);
            txtNombreMateria.Name = "txtNombreMateria";
            txtNombreMateria.Size = new Size(279, 26);
            txtNombreMateria.TabIndex = 1;
            // 
            // txtDescripcionMateria
            // 
            txtDescripcionMateria.Font = new Font("Arial", 12F);
            txtDescripcionMateria.Location = new Point(70, 124);
            txtDescripcionMateria.Multiline = true;
            txtDescripcionMateria.Name = "txtDescripcionMateria";
            txtDescripcionMateria.Size = new Size(349, 82);
            txtDescripcionMateria.TabIndex = 2;
            // 
            // comboBoxProfesor
            // 
            comboBoxProfesor.Font = new Font("Arial", 12F);
            comboBoxProfesor.FormattingEnabled = true;
            comboBoxProfesor.Location = new Point(197, 231);
            comboBoxProfesor.Name = "comboBoxProfesor";
            comboBoxProfesor.Size = new Size(222, 26);
            comboBoxProfesor.Sorted = true;
            comboBoxProfesor.TabIndex = 3;
            comboBoxProfesor.SelectedIndexChanged += comboBoxProfesor_SelectedIndexChanged;
            // 
            // btnAceptarMateria
            // 
            btnAceptarMateria.Location = new Point(279, 300);
            btnAceptarMateria.Name = "btnAceptarMateria";
            btnAceptarMateria.Size = new Size(140, 60);
            btnAceptarMateria.TabIndex = 4;
            btnAceptarMateria.Text = "Guardar cambios";
            btnAceptarMateria.UseVisualStyleBackColor = true;
            btnAceptarMateria.Click += btnAceptarMateria_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(70, 300);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(140, 60);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // btnVolver
            // 
            btnVolver.Enabled = false;
            btnVolver.Location = new Point(279, 300);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(140, 60);
            btnVolver.TabIndex = 6;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Visible = false;
            btnVolver.Click += btnCancelar_Click;
            // 
            // FormCargarMateria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 411);
            ControlBox = false;
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptarMateria);
            Controls.Add(comboBoxProfesor);
            Controls.Add(txtDescripcionMateria);
            Controls.Add(txtNombreMateria);
            Controls.Add(lblProfesor);
            Controls.Add(lblDescripcionMateria);
            Controls.Add(lblNombreMateria);
            Controls.Add(btnVolver);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormCargarMateria";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Crear materia";
            Load += FormCargarMateria_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombreMateria;
        private Label lblDescripcionMateria;
        private Label lblProfesor;
        private TextBox txtNombreMateria;
        private TextBox txtDescripcionMateria;
        private ComboBox comboBoxProfesor;
        private Button btnAceptarMateria;
        private Button btnCancelar;
        private ErrorProvider errorProvider;
        private Button btnVolver;
    }
}