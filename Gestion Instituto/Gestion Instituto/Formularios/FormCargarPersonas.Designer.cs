namespace Gestion_Instituto
{
    partial class FormCargarPersonas
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
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            btnCargar = new Button();
            label1 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            label11 = new Label();
            dateTimePicker1 = new DateTimePicker();
            txtDNI = new TextBox();
            label3 = new Label();
            groupBoxContacto = new GroupBox();
            label6 = new Label();
            txtTelefono2 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txtTelefono = new TextBox();
            txtCorreo = new TextBox();
            lblFechaInscipcion = new Label();
            groupBox2 = new GroupBox();
            label8 = new Label();
            txtCalle = new TextBox();
            groupBox3 = new GroupBox();
            lblFechaAmigable = new Label();
            lblFechaSQL = new Label();
            lblFechaAlta = new Label();
            lblFechaHoy = new Label();
            lblParaAlumno = new Label();
            groupBoxCarrera = new GroupBox();
            label15 = new Label();
            comboBoxElejirAño = new ComboBox();
            comboBoxCarreras = new ComboBox();
            label7 = new Label();
            groupBoxCargo = new GroupBox();
            comboBox1 = new ComboBox();
            label12 = new Label();
            panel1 = new Panel();
            btnActualizar = new Button();
            btnVolver = new Button();
            btnCancelar = new Button();
            groupBoxID_Estado = new GroupBox();
            label13 = new Label();
            label10 = new Label();
            txtEstado = new TextBox();
            txtId = new TextBox();
            groupBox1.SuspendLayout();
            groupBoxContacto.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBoxCarrera.SuspendLayout();
            groupBoxCargo.SuspendLayout();
            panel1.SuspendLayout();
            groupBoxID_Estado.SuspendLayout();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(107, 35);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(336, 26);
            txtNombre.TabIndex = 1;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(107, 78);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(336, 26);
            txtApellido.TabIndex = 2;
            // 
            // btnCargar
            // 
            btnCargar.Anchor = AnchorStyles.Top;
            btnCargar.Location = new Point(90, 23);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(140, 60);
            btnCargar.TabIndex = 15;
            btnCargar.Text = "Guardar";
            btnCargar.UseVisualStyleBackColor = true;
            btnCargar.Click += btnCargar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 38);
            label1.Name = "label1";
            label1.Size = new Size(64, 18);
            label1.TabIndex = 4;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 81);
            label2.Name = "label2";
            label2.Size = new Size(65, 18);
            label2.TabIndex = 5;
            label2.Text = "Apellido";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(txtDNI);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtApellido);
            groupBox1.Font = new Font("Arial", 12F);
            groupBox1.Location = new Point(25, 54);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(443, 217);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos Personales";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(26, 167);
            label11.Name = "label11";
            label11.Size = new Size(135, 18);
            label11.TabIndex = 11;
            label11.Text = "Fecha Nacimiento";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(167, 164);
            dateTimePicker1.MaxDate = new DateTime(2024, 10, 22, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(276, 26);
            dateTimePicker1.TabIndex = 4;
            dateTimePicker1.Value = new DateTime(2005, 12, 31, 0, 0, 0, 0);
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(107, 121);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(336, 26);
            txtDNI.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 124);
            label3.Name = "label3";
            label3.Size = new Size(34, 18);
            label3.TabIndex = 6;
            label3.Text = "DNI";
            // 
            // groupBoxContacto
            // 
            groupBoxContacto.Controls.Add(label6);
            groupBoxContacto.Controls.Add(txtTelefono2);
            groupBoxContacto.Controls.Add(label4);
            groupBoxContacto.Controls.Add(label5);
            groupBoxContacto.Controls.Add(txtTelefono);
            groupBoxContacto.Controls.Add(txtCorreo);
            groupBoxContacto.Font = new Font("Arial", 12F);
            groupBoxContacto.Location = new Point(498, 54);
            groupBoxContacto.Margin = new Padding(3, 2, 3, 2);
            groupBoxContacto.Name = "groupBoxContacto";
            groupBoxContacto.Padding = new Padding(3, 2, 3, 2);
            groupBoxContacto.Size = new Size(340, 156);
            groupBoxContacto.TabIndex = 8;
            groupBoxContacto.TabStop = false;
            groupBoxContacto.Text = "Forma de contacto";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 78);
            label6.Name = "label6";
            label6.Size = new Size(79, 18);
            label6.TabIndex = 11;
            label6.Text = "Telefono 2";
            // 
            // txtTelefono2
            // 
            txtTelefono2.Location = new Point(110, 75);
            txtTelefono2.Name = "txtTelefono2";
            txtTelefono2.Size = new Size(211, 26);
            txtTelefono2.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 33);
            label4.Name = "label4";
            label4.Size = new Size(66, 18);
            label4.TabIndex = 8;
            label4.Text = "Telefono";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 123);
            label5.Name = "label5";
            label5.Size = new Size(57, 18);
            label5.TabIndex = 9;
            label5.Text = "Correo";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(110, 30);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(211, 26);
            txtTelefono.TabIndex = 5;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(110, 120);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(211, 26);
            txtCorreo.TabIndex = 7;
            // 
            // lblFechaInscipcion
            // 
            lblFechaInscipcion.AutoSize = true;
            lblFechaInscipcion.Location = new Point(149, 46);
            lblFechaInscipcion.Name = "lblFechaInscipcion";
            lblFechaInscipcion.Size = new Size(0, 18);
            lblFechaInscipcion.TabIndex = 12;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(txtCalle);
            groupBox2.Font = new Font("Arial", 12F);
            groupBox2.Location = new Point(498, 214);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(340, 74);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "Dirección";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(18, 34);
            label8.Name = "label8";
            label8.Size = new Size(52, 18);
            label8.TabIndex = 8;
            label8.Text = "Calle: ";
            // 
            // txtCalle
            // 
            txtCalle.Location = new Point(110, 31);
            txtCalle.Name = "txtCalle";
            txtCalle.Size = new Size(211, 26);
            txtCalle.TabIndex = 8;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lblFechaAmigable);
            groupBox3.Controls.Add(lblFechaSQL);
            groupBox3.Controls.Add(lblFechaAlta);
            groupBox3.Controls.Add(lblFechaHoy);
            groupBox3.Controls.Add(lblParaAlumno);
            groupBox3.Controls.Add(lblFechaInscipcion);
            groupBox3.Font = new Font("Arial", 12F);
            groupBox3.Location = new Point(31, 314);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(443, 84);
            groupBox3.TabIndex = 14;
            groupBox3.TabStop = false;
            groupBox3.Text = "Inscripción";
            // 
            // lblFechaAmigable
            // 
            lblFechaAmigable.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblFechaAmigable.Font = new Font("Arial", 14F, FontStyle.Bold);
            lblFechaAmigable.ForeColor = SystemColors.AppWorkspace;
            lblFechaAmigable.Location = new Point(201, 34);
            lblFechaAmigable.Name = "lblFechaAmigable";
            lblFechaAmigable.Size = new Size(237, 27);
            lblFechaAmigable.TabIndex = 25;
            lblFechaAmigable.Tag = "fecha";
            lblFechaAmigable.Text = "Dia 00 Mes 00 Año 00";
            lblFechaAmigable.TextAlign = ContentAlignment.MiddleRight;
            lblFechaAmigable.Visible = false;
            // 
            // lblFechaSQL
            // 
            lblFechaSQL.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblFechaSQL.Font = new Font("Arial", 14F, FontStyle.Bold);
            lblFechaSQL.ForeColor = SystemColors.AppWorkspace;
            lblFechaSQL.Location = new Point(231, 34);
            lblFechaSQL.Name = "lblFechaSQL";
            lblFechaSQL.Size = new Size(183, 27);
            lblFechaSQL.TabIndex = 24;
            lblFechaSQL.Tag = "fecha";
            lblFechaSQL.Text = "Dia 00 Mes 00 Año 00";
            lblFechaSQL.TextAlign = ContentAlignment.MiddleRight;
            lblFechaSQL.Visible = false;
            // 
            // lblFechaAlta
            // 
            lblFechaAlta.AutoSize = true;
            lblFechaAlta.Location = new Point(16, 40);
            lblFechaAlta.Name = "lblFechaAlta";
            lblFechaAlta.Size = new Size(128, 18);
            lblFechaAlta.TabIndex = 23;
            lblFechaAlta.Text = " Fecha   de    Alta";
            lblFechaAlta.Visible = false;
            // 
            // lblFechaHoy
            // 
            lblFechaHoy.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblFechaHoy.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFechaHoy.ForeColor = SystemColors.AppWorkspace;
            lblFechaHoy.Location = new Point(175, 34);
            lblFechaHoy.Name = "lblFechaHoy";
            lblFechaHoy.Size = new Size(251, 27);
            lblFechaHoy.TabIndex = 22;
            lblFechaHoy.Tag = "fecha";
            lblFechaHoy.Text = "Dia 00 Mes 00 Año 00";
            lblFechaHoy.TextAlign = ContentAlignment.MiddleRight;
            lblFechaHoy.Visible = false;
            // 
            // lblParaAlumno
            // 
            lblParaAlumno.AutoSize = true;
            lblParaAlumno.Location = new Point(15, 40);
            lblParaAlumno.Name = "lblParaAlumno";
            lblParaAlumno.Size = new Size(130, 18);
            lblParaAlumno.TabIndex = 13;
            lblParaAlumno.Text = "Fecha Inscripción";
            lblParaAlumno.Visible = false;
            // 
            // groupBoxCarrera
            // 
            groupBoxCarrera.Controls.Add(label15);
            groupBoxCarrera.Controls.Add(comboBoxElejirAño);
            groupBoxCarrera.Controls.Add(comboBoxCarreras);
            groupBoxCarrera.Controls.Add(label7);
            groupBoxCarrera.Font = new Font("Arial", 12F);
            groupBoxCarrera.Location = new Point(498, 293);
            groupBoxCarrera.Name = "groupBoxCarrera";
            groupBoxCarrera.Size = new Size(340, 106);
            groupBoxCarrera.TabIndex = 18;
            groupBoxCarrera.TabStop = false;
            groupBoxCarrera.Text = "Eliga una Carrera";
            groupBoxCarrera.Visible = false;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(20, 68);
            label15.Name = "label15";
            label15.Size = new Size(100, 18);
            label15.TabIndex = 15;
            label15.Text = "Año Cursada";
            // 
            // comboBoxElejirAño
            // 
            comboBoxElejirAño.AccessibleDescription = "";
            comboBoxElejirAño.AccessibleName = "";
            comboBoxElejirAño.FormattingEnabled = true;
            comboBoxElejirAño.Items.AddRange(new object[] { "1", "2", "3" });
            comboBoxElejirAño.Location = new Point(126, 65);
            comboBoxElejirAño.Name = "comboBoxElejirAño";
            comboBoxElejirAño.Size = new Size(195, 26);
            comboBoxElejirAño.TabIndex = 10;
            comboBoxElejirAño.Text = "Elejir el Año";
            // 
            // comboBoxCarreras
            // 
            comboBoxCarreras.AccessibleDescription = "";
            comboBoxCarreras.AccessibleName = "";
            comboBoxCarreras.FormattingEnabled = true;
            comboBoxCarreras.Location = new Point(126, 34);
            comboBoxCarreras.Name = "comboBoxCarreras";
            comboBoxCarreras.Size = new Size(195, 26);
            comboBoxCarreras.TabIndex = 9;
            comboBoxCarreras.Text = "Elejir una Carrera";
            comboBoxCarreras.SelectedIndexChanged += comboBoxCarreras_SelectedIndexChanged;
            comboBoxCarreras.KeyPress += comboBoxCarreras_KeyPress;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(18, 37);
            label7.Name = "label7";
            label7.Size = new Size(62, 18);
            label7.TabIndex = 10;
            label7.Text = "Carrera";
            // 
            // groupBoxCargo
            // 
            groupBoxCargo.Controls.Add(comboBox1);
            groupBoxCargo.Controls.Add(label12);
            groupBoxCargo.Font = new Font("Arial", 12F);
            groupBoxCargo.Location = new Point(498, 293);
            groupBoxCargo.Name = "groupBoxCargo";
            groupBoxCargo.Size = new Size(340, 106);
            groupBoxCargo.TabIndex = 16;
            groupBoxCargo.TabStop = false;
            groupBoxCargo.Text = "Eliga un Cargo";
            groupBoxCargo.Visible = false;
            // 
            // comboBox1
            // 
            comboBox1.AccessibleDescription = "";
            comboBox1.AccessibleName = "";
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "personal", "profesor" });
            comboBox1.Location = new Point(116, 27);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(205, 26);
            comboBox1.TabIndex = 11;
            comboBox1.Text = "Elejir una opcion";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(18, 30);
            label12.Name = "label12";
            label12.Size = new Size(52, 18);
            label12.TabIndex = 10;
            label12.Text = "Cargo";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnActualizar);
            panel1.Controls.Add(btnVolver);
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(btnCargar);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 441);
            panel1.Name = "panel1";
            panel1.Size = new Size(884, 120);
            panel1.TabIndex = 15;
            // 
            // btnActualizar
            // 
            btnActualizar.Anchor = AnchorStyles.Top;
            btnActualizar.Location = new Point(278, 23);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(140, 60);
            btnActualizar.TabIndex = 16;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Anchor = AnchorStyles.Top;
            btnVolver.Location = new Point(654, 23);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(140, 60);
            btnVolver.TabIndex = 18;
            btnVolver.Text = "Volver al menu";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Top;
            btnCancelar.Location = new Point(466, 23);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(140, 60);
            btnCancelar.TabIndex = 17;
            btnCancelar.Text = "Limpiar Campos";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // groupBoxID_Estado
            // 
            groupBoxID_Estado.Controls.Add(label13);
            groupBoxID_Estado.Controls.Add(label10);
            groupBoxID_Estado.Controls.Add(txtEstado);
            groupBoxID_Estado.Controls.Add(txtId);
            groupBoxID_Estado.Font = new Font("Arial", 12F);
            groupBoxID_Estado.Location = new Point(25, 5);
            groupBoxID_Estado.Name = "groupBoxID_Estado";
            groupBoxID_Estado.Size = new Size(346, 44);
            groupBoxID_Estado.TabIndex = 17;
            groupBoxID_Estado.TabStop = false;
            groupBoxID_Estado.Visible = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(6, 13);
            label13.Name = "label13";
            label13.Size = new Size(23, 18);
            label13.TabIndex = 15;
            label13.Text = "ID";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(175, 13);
            label10.Name = "label10";
            label10.Size = new Size(58, 18);
            label10.TabIndex = 14;
            label10.Text = "Estado";
            // 
            // txtEstado
            // 
            txtEstado.BackColor = SystemColors.ButtonHighlight;
            txtEstado.Location = new Point(239, 10);
            txtEstado.Name = "txtEstado";
            txtEstado.ReadOnly = true;
            txtEstado.Size = new Size(96, 26);
            txtEstado.TabIndex = 13;
            // 
            // txtId
            // 
            txtId.Location = new Point(35, 10);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(81, 26);
            txtId.TabIndex = 12;
            // 
            // FormCargarPersonas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 561);
            ControlBox = false;
            Controls.Add(groupBoxCarrera);
            Controls.Add(groupBoxID_Estado);
            Controls.Add(groupBoxCargo);
            Controls.Add(panel1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBoxContacto);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCargarPersonas";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cargar datos";
            Load += FormCargarPersonas_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBoxContacto.ResumeLayout(false);
            groupBoxContacto.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBoxCarrera.ResumeLayout(false);
            groupBoxCarrera.PerformLayout();
            groupBoxCargo.ResumeLayout(false);
            groupBoxCargo.PerformLayout();
            panel1.ResumeLayout(false);
            groupBoxID_Estado.ResumeLayout(false);
            groupBoxID_Estado.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtApellido;
        private Button btnCargar;
        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private TextBox txtDNI;
        private Label label3;
        private GroupBox groupBoxContacto;
        private Label label4;
        private Label label5;
        private TextBox txtTelefono;
        private TextBox txtCorreo;
        private Label label6;
        private TextBox txtTelefono2;
        private Label lblFechaInscipcion;
        private GroupBox groupBox2;
        private Label label8;
        private TextBox txtCalle;
        private GroupBox groupBox3;
        private Panel panel1;
        private Button btnCancelar;
        private Button btnVolver;
        private DateTimePicker dateTimePicker1;
        private Label label11;
        private GroupBox groupBoxCargo;
        private ComboBox comboBox1;
        private Label label12;
        private GroupBox groupBoxID_Estado;
        private TextBox txtId;
        private TextBox txtEstado;
        private Label label13;
        private Label label10;
        private Button btnActualizar;
        private Label lblParaAlumno;
        private Label lblFechaHoy;
        private Label lblFechaAlta;
        private Label lblFechaSQL;
        private Label lblFechaAmigable;
        private GroupBox groupBoxCarrera;
        private ComboBox comboBoxCarreras;
        private Label label7;
        private Label label15;
        private ComboBox comboBoxElejirAño;
    }
}