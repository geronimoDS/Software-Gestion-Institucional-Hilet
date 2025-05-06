namespace Gestion_Instituto
{
    partial class CargarNotas
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
            pnlCN = new Panel();
            pnlLEFT = new Panel();
            btnSeleccionar = new Button();
            gbNota = new GroupBox();
            txtNota = new TextBox();
            lblNota = new Label();
            gbMatricula = new GroupBox();
            lblMostrarMat = new Label();
            lblMostrarApellido = new Label();
            lblMostrarNombre = new Label();
            lblMatricula = new Label();
            lblApellido = new Label();
            lblNombre = new Label();
            txtSearchApellido = new TextBox();
            btnBuscar = new Button();
            lblSearchApellido = new Label();
            pnlBottom = new Panel();
            btnSalir = new Button();
            btnGuardar = new Button();
            errorProvider1 = new ErrorProvider(components);
            pnlCN.SuspendLayout();
            pnlLEFT.SuspendLayout();
            gbNota.SuspendLayout();
            gbMatricula.SuspendLayout();
            pnlBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // pnlCN
            // 
            pnlCN.Controls.Add(pnlLEFT);
            pnlCN.Dock = DockStyle.Fill;
            pnlCN.Location = new Point(0, 0);
            pnlCN.Name = "pnlCN";
            pnlCN.Size = new Size(484, 461);
            pnlCN.TabIndex = 0;
            // 
            // pnlLEFT
            // 
            pnlLEFT.Controls.Add(btnSeleccionar);
            pnlLEFT.Controls.Add(gbNota);
            pnlLEFT.Controls.Add(gbMatricula);
            pnlLEFT.Controls.Add(pnlBottom);
            pnlLEFT.Dock = DockStyle.Fill;
            pnlLEFT.Location = new Point(0, 0);
            pnlLEFT.Name = "pnlLEFT";
            pnlLEFT.Size = new Size(484, 461);
            pnlLEFT.TabIndex = 1;
            // 
            // btnSeleccionar
            // 
            btnSeleccionar.Location = new Point(172, 199);
            btnSeleccionar.Name = "btnSeleccionar";
            btnSeleccionar.Size = new Size(140, 60);
            btnSeleccionar.TabIndex = 0;
            btnSeleccionar.Text = "Seleccionar examen";
            btnSeleccionar.UseVisualStyleBackColor = true;
            btnSeleccionar.Click += btnSeleccionar_Click_1;
            // 
            // gbNota
            // 
            gbNota.Controls.Add(txtNota);
            gbNota.Controls.Add(lblNota);
            gbNota.Location = new Point(3, 278);
            gbNota.Name = "gbNota";
            gbNota.Size = new Size(481, 58);
            gbNota.TabIndex = 8;
            gbNota.TabStop = false;
            gbNota.Text = "Nota";
            // 
            // txtNota
            // 
            txtNota.Font = new Font("Arial", 12F);
            txtNota.Location = new Point(169, 19);
            txtNota.Name = "txtNota";
            txtNota.Size = new Size(259, 26);
            txtNota.TabIndex = 1;
            // 
            // lblNota
            // 
            lblNota.AutoSize = true;
            lblNota.Font = new Font("Arial", 12F);
            lblNota.Location = new Point(48, 22);
            lblNota.Name = "lblNota";
            lblNota.Size = new Size(106, 18);
            lblNota.TabIndex = 0;
            lblNota.Text = "Nota Examen:";
            // 
            // gbMatricula
            // 
            gbMatricula.Controls.Add(lblMostrarMat);
            gbMatricula.Controls.Add(lblMostrarApellido);
            gbMatricula.Controls.Add(lblMostrarNombre);
            gbMatricula.Controls.Add(lblMatricula);
            gbMatricula.Controls.Add(lblApellido);
            gbMatricula.Controls.Add(lblNombre);
            gbMatricula.Controls.Add(txtSearchApellido);
            gbMatricula.Controls.Add(btnBuscar);
            gbMatricula.Controls.Add(lblSearchApellido);
            gbMatricula.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbMatricula.Location = new Point(3, 3);
            gbMatricula.Name = "gbMatricula";
            gbMatricula.Size = new Size(481, 181);
            gbMatricula.TabIndex = 6;
            gbMatricula.TabStop = false;
            gbMatricula.Text = "Alumno";
            // 
            // lblMostrarMat
            // 
            lblMostrarMat.AutoSize = true;
            lblMostrarMat.Font = new Font("Arial", 12F);
            lblMostrarMat.Location = new Point(128, 144);
            lblMostrarMat.Name = "lblMostrarMat";
            lblMostrarMat.Size = new Size(0, 18);
            lblMostrarMat.TabIndex = 8;
            // 
            // lblMostrarApellido
            // 
            lblMostrarApellido.AutoSize = true;
            lblMostrarApellido.Font = new Font("Arial", 12F);
            lblMostrarApellido.Location = new Point(128, 115);
            lblMostrarApellido.Name = "lblMostrarApellido";
            lblMostrarApellido.Size = new Size(0, 18);
            lblMostrarApellido.TabIndex = 7;
            // 
            // lblMostrarNombre
            // 
            lblMostrarNombre.AutoSize = true;
            lblMostrarNombre.Font = new Font("Arial", 12F);
            lblMostrarNombre.Location = new Point(128, 86);
            lblMostrarNombre.Name = "lblMostrarNombre";
            lblMostrarNombre.Size = new Size(0, 18);
            lblMostrarNombre.TabIndex = 6;
            // 
            // lblMatricula
            // 
            lblMatricula.AutoSize = true;
            lblMatricula.Font = new Font("Arial", 12F);
            lblMatricula.Location = new Point(48, 144);
            lblMatricula.Name = "lblMatricula";
            lblMatricula.Size = new Size(75, 18);
            lblMatricula.TabIndex = 5;
            lblMatricula.Text = "Matricula:";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Arial", 12F);
            lblApellido.Location = new Point(48, 115);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(69, 18);
            lblApellido.TabIndex = 4;
            lblApellido.Text = "Apellido:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Arial", 12F);
            lblNombre.Location = new Point(48, 86);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(68, 18);
            lblNombre.TabIndex = 3;
            lblNombre.Text = "Nombre:";
            // 
            // txtSearchApellido
            // 
            txtSearchApellido.Font = new Font("Arial", 12F);
            txtSearchApellido.Location = new Point(114, 39);
            txtSearchApellido.Name = "txtSearchApellido";
            txtSearchApellido.Size = new Size(195, 26);
            txtSearchApellido.TabIndex = 2;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(327, 39);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(101, 26);
            btnBuscar.TabIndex = 0;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click_1;
            // 
            // lblSearchApellido
            // 
            lblSearchApellido.AutoSize = true;
            lblSearchApellido.Font = new Font("Arial", 12F);
            lblSearchApellido.Location = new Point(48, 42);
            lblSearchApellido.Name = "lblSearchApellido";
            lblSearchApellido.Size = new Size(69, 18);
            lblSearchApellido.TabIndex = 1;
            lblSearchApellido.Text = "Apellido:";
            // 
            // pnlBottom
            // 
            pnlBottom.Controls.Add(btnSalir);
            pnlBottom.Controls.Add(btnGuardar);
            pnlBottom.Dock = DockStyle.Bottom;
            pnlBottom.Location = new Point(0, 342);
            pnlBottom.Name = "pnlBottom";
            pnlBottom.Size = new Size(484, 119);
            pnlBottom.TabIndex = 5;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(51, 28);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(140, 60);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(291, 28);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(140, 60);
            btnGuardar.TabIndex = 4;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // CargarNotas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 461);
            Controls.Add(pnlCN);
            Name = "CargarNotas";
            Text = "Cargar notas";
            Load += CargarNotas_Load;
            pnlCN.ResumeLayout(false);
            pnlLEFT.ResumeLayout(false);
            gbNota.ResumeLayout(false);
            gbNota.PerformLayout();
            gbMatricula.ResumeLayout(false);
            gbMatricula.PerformLayout();
            pnlBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlCN;
        private Panel pnlLEFT;
        private Panel pnlBottom;
        private GroupBox gbNota;
        private TextBox txtNota;
        private Label lblNota;
        private Button btnSeleccionar;
        private GroupBox gbMatricula;
        private Label lblMostrarMat;
        private Label lblMostrarApellido;
        private Label lblMostrarNombre;
        private Label lblMatricula;
        private Label lblApellido;
        private Label lblNombre;
        private TextBox txtSearchApellido;
        private Button btnBuscar;
        private Label lblSearchApellido;
        private Button btnSalir;
        private Button btnGuardar;
        private ErrorProvider errorProvider1;
    }
}