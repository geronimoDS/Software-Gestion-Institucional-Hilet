namespace Gestion_Instituto
{
    partial class FormReporteAlumno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReporteAlumno));
            pnlRP = new Panel();
            pnlBOTTOM = new Panel();
            btnFRAS = new Button();
            btnPDF = new Button();
            pnlNotas = new Panel();
            gbNotas = new GroupBox();
            dgvNotas = new DataGridView();
            pnlLeft = new Panel();
            gbDatos = new GroupBox();
            lblMostrarMatricula = new Label();
            lblMatricula = new Label();
            lblMostrarEstado = new Label();
            lblMostrarFIns = new Label();
            lblMostrarDomicilio = new Label();
            lblMostrarTel2 = new Label();
            lblMostrarTel = new Label();
            lblMostrarMail = new Label();
            lblMostrarFNac = new Label();
            lblMostrarDni = new Label();
            lblMostrarApellido = new Label();
            lblMostrarNombre = new Label();
            lblEstado = new Label();
            lblFechaInsc = new Label();
            lblDomicilio = new Label();
            lblTel2 = new Label();
            lblTel1 = new Label();
            lblMail = new Label();
            lblFechaNac = new Label();
            lblDNI = new Label();
            lblApellido = new Label();
            lblNombre = new Label();
            gbMatricula = new GroupBox();
            txtSearchApellido = new TextBox();
            btnBuscar = new Button();
            lblSearchApellido = new Label();
            pnlRP.SuspendLayout();
            pnlBOTTOM.SuspendLayout();
            pnlNotas.SuspendLayout();
            gbNotas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNotas).BeginInit();
            pnlLeft.SuspendLayout();
            gbDatos.SuspendLayout();
            gbMatricula.SuspendLayout();
            SuspendLayout();
            // 
            // pnlRP
            // 
            pnlRP.Controls.Add(pnlBOTTOM);
            pnlRP.Controls.Add(pnlNotas);
            pnlRP.Controls.Add(pnlLeft);
            pnlRP.Dock = DockStyle.Fill;
            pnlRP.Location = new Point(0, 0);
            pnlRP.MaximumSize = new Size(850, 581);
            pnlRP.MinimumSize = new Size(850, 581);
            pnlRP.Name = "pnlRP";
            pnlRP.Size = new Size(850, 581);
            pnlRP.TabIndex = 0;
            // 
            // pnlBOTTOM
            // 
            pnlBOTTOM.Controls.Add(btnFRAS);
            pnlBOTTOM.Controls.Add(btnPDF);
            pnlBOTTOM.Dock = DockStyle.Bottom;
            pnlBOTTOM.Location = new Point(375, 507);
            pnlBOTTOM.Name = "pnlBOTTOM";
            pnlBOTTOM.Size = new Size(475, 74);
            pnlBOTTOM.TabIndex = 5;
            // 
            // btnFRAS
            // 
            btnFRAS.Location = new Point(310, 9);
            btnFRAS.Name = "btnFRAS";
            btnFRAS.Size = new Size(140, 60);
            btnFRAS.TabIndex = 2;
            btnFRAS.Text = "Salir";
            btnFRAS.UseVisualStyleBackColor = true;
            btnFRAS.Click += btnFRAS_Click;
            // 
            // btnPDF
            // 
            btnPDF.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnPDF.Location = new Point(9, 9);
            btnPDF.Name = "btnPDF";
            btnPDF.Size = new Size(140, 60);
            btnPDF.TabIndex = 0;
            btnPDF.Text = "PDF";
            btnPDF.UseVisualStyleBackColor = true;
            btnPDF.Click += btnPDF_Click;
            // 
            // pnlNotas
            // 
            pnlNotas.Controls.Add(gbNotas);
            pnlNotas.Dock = DockStyle.Fill;
            pnlNotas.Location = new Point(375, 0);
            pnlNotas.Name = "pnlNotas";
            pnlNotas.Size = new Size(475, 581);
            pnlNotas.TabIndex = 4;
            // 
            // gbNotas
            // 
            gbNotas.Controls.Add(dgvNotas);
            gbNotas.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbNotas.Location = new Point(9, 12);
            gbNotas.Name = "gbNotas";
            gbNotas.Size = new Size(439, 484);
            gbNotas.TabIndex = 0;
            gbNotas.TabStop = false;
            gbNotas.Text = "Notas";
            // 
            // dgvNotas
            // 
            dgvNotas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNotas.Dock = DockStyle.Fill;
            dgvNotas.Location = new Point(3, 19);
            dgvNotas.Name = "dgvNotas";
            dgvNotas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNotas.Size = new Size(433, 462);
            dgvNotas.TabIndex = 0;
            // 
            // pnlLeft
            // 
            pnlLeft.Controls.Add(gbDatos);
            pnlLeft.Controls.Add(gbMatricula);
            pnlLeft.Dock = DockStyle.Left;
            pnlLeft.Location = new Point(0, 0);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.Size = new Size(375, 581);
            pnlLeft.TabIndex = 1;
            // 
            // gbDatos
            // 
            gbDatos.Controls.Add(lblMostrarMatricula);
            gbDatos.Controls.Add(lblMatricula);
            gbDatos.Controls.Add(lblMostrarEstado);
            gbDatos.Controls.Add(lblMostrarFIns);
            gbDatos.Controls.Add(lblMostrarDomicilio);
            gbDatos.Controls.Add(lblMostrarTel2);
            gbDatos.Controls.Add(lblMostrarTel);
            gbDatos.Controls.Add(lblMostrarMail);
            gbDatos.Controls.Add(lblMostrarFNac);
            gbDatos.Controls.Add(lblMostrarDni);
            gbDatos.Controls.Add(lblMostrarApellido);
            gbDatos.Controls.Add(lblMostrarNombre);
            gbDatos.Controls.Add(lblEstado);
            gbDatos.Controls.Add(lblFechaInsc);
            gbDatos.Controls.Add(lblDomicilio);
            gbDatos.Controls.Add(lblTel2);
            gbDatos.Controls.Add(lblTel1);
            gbDatos.Controls.Add(lblMail);
            gbDatos.Controls.Add(lblFechaNac);
            gbDatos.Controls.Add(lblDNI);
            gbDatos.Controls.Add(lblApellido);
            gbDatos.Controls.Add(lblNombre);
            gbDatos.Dock = DockStyle.Bottom;
            gbDatos.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbDatos.Location = new Point(0, 127);
            gbDatos.Name = "gbDatos";
            gbDatos.Size = new Size(375, 454);
            gbDatos.TabIndex = 1;
            gbDatos.TabStop = false;
            gbDatos.Text = "Datos de Alumno";
            // 
            // lblMostrarMatricula
            // 
            lblMostrarMatricula.AutoSize = true;
            lblMostrarMatricula.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMostrarMatricula.Location = new Point(179, 107);
            lblMostrarMatricula.Name = "lblMostrarMatricula";
            lblMostrarMatricula.Size = new Size(0, 15);
            lblMostrarMatricula.TabIndex = 21;
            // 
            // lblMatricula
            // 
            lblMatricula.AutoSize = true;
            lblMatricula.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMatricula.Location = new Point(179, 83);
            lblMatricula.Name = "lblMatricula";
            lblMatricula.Size = new Size(62, 15);
            lblMatricula.TabIndex = 20;
            lblMatricula.Text = "Matricula:";
            // 
            // lblMostrarEstado
            // 
            lblMostrarEstado.AutoSize = true;
            lblMostrarEstado.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMostrarEstado.Location = new Point(21, 417);
            lblMostrarEstado.Name = "lblMostrarEstado";
            lblMostrarEstado.Size = new Size(0, 15);
            lblMostrarEstado.TabIndex = 19;
            // 
            // lblMostrarFIns
            // 
            lblMostrarFIns.AutoSize = true;
            lblMostrarFIns.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMostrarFIns.Location = new Point(18, 367);
            lblMostrarFIns.Name = "lblMostrarFIns";
            lblMostrarFIns.Size = new Size(0, 15);
            lblMostrarFIns.TabIndex = 18;
            // 
            // lblMostrarDomicilio
            // 
            lblMostrarDomicilio.AutoSize = true;
            lblMostrarDomicilio.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMostrarDomicilio.Location = new Point(19, 318);
            lblMostrarDomicilio.Name = "lblMostrarDomicilio";
            lblMostrarDomicilio.Size = new Size(0, 15);
            lblMostrarDomicilio.TabIndex = 17;
            // 
            // lblMostrarTel2
            // 
            lblMostrarTel2.AutoSize = true;
            lblMostrarTel2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMostrarTel2.Location = new Point(179, 262);
            lblMostrarTel2.Name = "lblMostrarTel2";
            lblMostrarTel2.Size = new Size(0, 15);
            lblMostrarTel2.TabIndex = 16;
            // 
            // lblMostrarTel
            // 
            lblMostrarTel.AutoSize = true;
            lblMostrarTel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMostrarTel.Location = new Point(19, 263);
            lblMostrarTel.Name = "lblMostrarTel";
            lblMostrarTel.Size = new Size(0, 15);
            lblMostrarTel.TabIndex = 15;
            // 
            // lblMostrarMail
            // 
            lblMostrarMail.AutoSize = true;
            lblMostrarMail.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMostrarMail.Location = new Point(18, 211);
            lblMostrarMail.Name = "lblMostrarMail";
            lblMostrarMail.Size = new Size(0, 15);
            lblMostrarMail.TabIndex = 14;
            // 
            // lblMostrarFNac
            // 
            lblMostrarFNac.AutoSize = true;
            lblMostrarFNac.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMostrarFNac.Location = new Point(18, 161);
            lblMostrarFNac.Name = "lblMostrarFNac";
            lblMostrarFNac.Size = new Size(0, 15);
            lblMostrarFNac.TabIndex = 13;
            // 
            // lblMostrarDni
            // 
            lblMostrarDni.AutoSize = true;
            lblMostrarDni.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMostrarDni.Location = new Point(20, 107);
            lblMostrarDni.Name = "lblMostrarDni";
            lblMostrarDni.Size = new Size(0, 15);
            lblMostrarDni.TabIndex = 12;
            // 
            // lblMostrarApellido
            // 
            lblMostrarApellido.AutoSize = true;
            lblMostrarApellido.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMostrarApellido.Location = new Point(179, 57);
            lblMostrarApellido.Name = "lblMostrarApellido";
            lblMostrarApellido.Size = new Size(0, 15);
            lblMostrarApellido.TabIndex = 11;
            // 
            // lblMostrarNombre
            // 
            lblMostrarNombre.AutoSize = true;
            lblMostrarNombre.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMostrarNombre.Location = new Point(18, 57);
            lblMostrarNombre.Name = "lblMostrarNombre";
            lblMostrarNombre.Size = new Size(0, 15);
            lblMostrarNombre.TabIndex = 10;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEstado.Location = new Point(20, 393);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(46, 15);
            lblEstado.TabIndex = 9;
            lblEstado.Text = "Estado:";
            // 
            // lblFechaInsc
            // 
            lblFechaInsc.AutoSize = true;
            lblFechaInsc.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFechaInsc.Location = new Point(18, 342);
            lblFechaInsc.Name = "lblFechaInsc";
            lblFechaInsc.Size = new Size(105, 15);
            lblFechaInsc.TabIndex = 8;
            lblFechaInsc.Text = "Fecha Inscripcion:";
            // 
            // lblDomicilio
            // 
            lblDomicilio.AutoSize = true;
            lblDomicilio.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDomicilio.Location = new Point(20, 288);
            lblDomicilio.Name = "lblDomicilio";
            lblDomicilio.Size = new Size(62, 15);
            lblDomicilio.TabIndex = 7;
            lblDomicilio.Text = "Domicilio:";
            // 
            // lblTel2
            // 
            lblTel2.AutoSize = true;
            lblTel2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTel2.Location = new Point(179, 237);
            lblTel2.Name = "lblTel2";
            lblTel2.Size = new Size(84, 15);
            lblTel2.TabIndex = 6;
            lblTel2.Text = "Telefono Aux:";
            // 
            // lblTel1
            // 
            lblTel1.AutoSize = true;
            lblTel1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTel1.Location = new Point(18, 237);
            lblTel1.Name = "lblTel1";
            lblTel1.Size = new Size(59, 15);
            lblTel1.TabIndex = 5;
            lblTel1.Text = "Telefono:";
            // 
            // lblMail
            // 
            lblMail.AutoSize = true;
            lblMail.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMail.Location = new Point(18, 186);
            lblMail.Name = "lblMail";
            lblMail.Size = new Size(33, 15);
            lblMail.TabIndex = 4;
            lblMail.Text = "Mail:";
            // 
            // lblFechaNac
            // 
            lblFechaNac.AutoSize = true;
            lblFechaNac.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFechaNac.Location = new Point(18, 137);
            lblFechaNac.Name = "lblFechaNac";
            lblFechaNac.Size = new Size(109, 15);
            lblFechaNac.TabIndex = 3;
            lblFechaNac.Text = "Fecha Nacimiento:";
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDNI.Location = new Point(20, 83);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(32, 15);
            lblDNI.TabIndex = 2;
            lblDNI.Text = "DNI:";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblApellido.Location = new Point(179, 33);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(55, 15);
            lblApellido.TabIndex = 1;
            lblApellido.Text = "Apellido:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(18, 33);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(56, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre:";
            // 
            // gbMatricula
            // 
            gbMatricula.Controls.Add(txtSearchApellido);
            gbMatricula.Controls.Add(btnBuscar);
            gbMatricula.Controls.Add(lblSearchApellido);
            gbMatricula.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbMatricula.Location = new Point(3, 12);
            gbMatricula.Name = "gbMatricula";
            gbMatricula.Size = new Size(372, 100);
            gbMatricula.TabIndex = 0;
            gbMatricula.TabStop = false;
            gbMatricula.Text = "Alumno";
            // 
            // txtSearchApellido
            // 
            txtSearchApellido.Location = new Point(89, 27);
            txtSearchApellido.Name = "txtSearchApellido";
            txtSearchApellido.Size = new Size(258, 23);
            txtSearchApellido.TabIndex = 2;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(247, 62);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(100, 25);
            btnBuscar.TabIndex = 0;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // lblSearchApellido
            // 
            lblSearchApellido.AutoSize = true;
            lblSearchApellido.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSearchApellido.Location = new Point(18, 30);
            lblSearchApellido.Name = "lblSearchApellido";
            lblSearchApellido.Size = new Size(54, 15);
            lblSearchApellido.TabIndex = 1;
            lblSearchApellido.Text = "Apellido:";
            // 
            // FormReporteAlumno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(834, 581);
            ControlBox = false;
            Controls.Add(pnlRP);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(850, 620);
            MinimumSize = new Size(850, 620);
            Name = "FormReporteAlumno";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Reporte de alumno";
            Load += FormReporteAlumno_Load_1;
            pnlRP.ResumeLayout(false);
            pnlBOTTOM.ResumeLayout(false);
            pnlNotas.ResumeLayout(false);
            gbNotas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvNotas).EndInit();
            pnlLeft.ResumeLayout(false);
            gbDatos.ResumeLayout(false);
            gbDatos.PerformLayout();
            gbMatricula.ResumeLayout(false);
            gbMatricula.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlRP;
        private Panel pnlNotas;
        private GroupBox gbNotas;
        private DataGridView dgvNotas;
        private Panel pnlBOTTOM;
        private Button btnPDF;
        private Panel pnlLeft;
        private GroupBox gbDatos;
        private Label lblMostrarEstado;
        private Label lblMostrarFIns;
        private Label lblMostrarDomicilio;
        private Label lblMostrarTel2;
        private Label lblMostrarTel;
        private Label lblMostrarMail;
        private Label lblMostrarFNac;
        private Label lblMostrarDni;
        private Label lblMostrarApellido;
        private Label lblMostrarNombre;
        private Label lblEstado;
        private Label lblFechaInsc;
        private Label lblDomicilio;
        private Label lblTel2;
        private Label lblTel1;
        private Label lblMail;
        private Label lblFechaNac;
        private Label lblDNI;
        private Label lblApellido;
        private Label lblNombre;
        private GroupBox gbMatricula;
        private TextBox txtSearchApellido;
        private Button btnBuscar;
        private Label lblSearchApellido;
        private Label lblMostrarMatricula;
        private Label lblMatricula;
        private Button btnFRAS;
    }
}