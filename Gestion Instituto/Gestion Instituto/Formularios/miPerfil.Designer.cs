namespace Gestion_Instituto.Formularios
{
    partial class miPerfil
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
            groupBox2 = new GroupBox();
            lblFechaAmigable = new Label();
            label11 = new Label();
            txtIdLogin = new TextBox();
            label3 = new Label();
            txtNombre = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtApellido = new TextBox();
            groupBoxAcualizar = new GroupBox();
            btnCancelar = new Button();
            btnGuardar = new Button();
            txtPasss = new TextBox();
            label8 = new Label();
            gbAsignaturas = new GroupBox();
            dgvAsignaturas = new DataGridView();
            gbCarrera = new GroupBox();
            txtAño = new TextBox();
            txtCarrera = new TextBox();
            label4 = new Label();
            label5 = new Label();
            btnActualizar = new Button();
            groupUsuarioYPass = new GroupBox();
            txtPass = new TextBox();
            txtUsuario = new TextBox();
            label6 = new Label();
            label7 = new Label();
            btnVolverMenu = new Button();
            errorProvider = new ErrorProvider(components);
            groupBox2.SuspendLayout();
            groupBoxAcualizar.SuspendLayout();
            gbAsignaturas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAsignaturas).BeginInit();
            gbCarrera.SuspendLayout();
            groupUsuarioYPass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblFechaAmigable);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(txtIdLogin);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txtNombre);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(txtApellido);
            groupBox2.Location = new Point(21, 11);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(354, 200);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Mis Datos Personales";
            // 
            // lblFechaAmigable
            // 
            lblFechaAmigable.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblFechaAmigable.Font = new Font("Arial", 14F, FontStyle.Bold);
            lblFechaAmigable.ForeColor = SystemColors.AppWorkspace;
            lblFechaAmigable.Location = new Point(110, 160);
            lblFechaAmigable.Name = "lblFechaAmigable";
            lblFechaAmigable.Size = new Size(184, 27);
            lblFechaAmigable.TabIndex = 26;
            lblFechaAmigable.Tag = "fecha";
            lblFechaAmigable.Text = "Dia 00 Mes 00 Año 00";
            lblFechaAmigable.TextAlign = ContentAlignment.MiddleRight;
            lblFechaAmigable.Visible = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(1, 164);
            label11.Name = "label11";
            label11.Size = new Size(103, 15);
            label11.TabIndex = 11;
            label11.Text = "Fecha Nacimiento";
            label11.Visible = false;
            // 
            // txtIdLogin
            // 
            txtIdLogin.BackColor = SystemColors.ButtonHighlight;
            txtIdLogin.Location = new Point(107, 116);
            txtIdLogin.Name = "txtIdLogin";
            txtIdLogin.ReadOnly = true;
            txtIdLogin.Size = new Size(141, 23);
            txtIdLogin.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 115);
            label3.Name = "label3";
            label3.Size = new Size(27, 15);
            label3.TabIndex = 6;
            label3.Text = "DNI";
            // 
            // txtNombre
            // 
            txtNombre.BackColor = SystemColors.ButtonHighlight;
            txtNombre.Location = new Point(107, 38);
            txtNombre.Name = "txtNombre";
            txtNombre.ReadOnly = true;
            txtNombre.Size = new Size(164, 23);
            txtNombre.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 37);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 4;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 75);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 5;
            label2.Text = "Apellido";
            // 
            // txtApellido
            // 
            txtApellido.BackColor = SystemColors.ButtonHighlight;
            txtApellido.Location = new Point(107, 76);
            txtApellido.Name = "txtApellido";
            txtApellido.ReadOnly = true;
            txtApellido.Size = new Size(164, 23);
            txtApellido.TabIndex = 1;
            // 
            // groupBoxAcualizar
            // 
            groupBoxAcualizar.Controls.Add(btnCancelar);
            groupBoxAcualizar.Controls.Add(btnGuardar);
            groupBoxAcualizar.Controls.Add(txtPasss);
            groupBoxAcualizar.Controls.Add(label8);
            groupBoxAcualizar.Location = new Point(400, 13);
            groupBoxAcualizar.Name = "groupBoxAcualizar";
            groupBoxAcualizar.Size = new Size(354, 198);
            groupBoxAcualizar.TabIndex = 12;
            groupBoxAcualizar.TabStop = false;
            groupBoxAcualizar.Text = "Confirmar cambios";
            groupBoxAcualizar.Visible = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Red;
            btnCancelar.Location = new Point(26, 121);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(140, 60);
            btnCancelar.TabIndex = 14;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Lime;
            btnGuardar.Location = new Point(188, 121);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(140, 60);
            btnGuardar.TabIndex = 13;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtPasss
            // 
            txtPasss.Location = new Point(131, 35);
            txtPasss.Name = "txtPasss";
            txtPasss.Size = new Size(197, 23);
            txtPasss.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(26, 39);
            label8.Name = "label8";
            label8.Size = new Size(67, 15);
            label8.TabIndex = 8;
            label8.Text = "Contraseña";
            // 
            // gbAsignaturas
            // 
            gbAsignaturas.Controls.Add(dgvAsignaturas);
            gbAsignaturas.Location = new Point(22, 216);
            gbAsignaturas.Name = "gbAsignaturas";
            gbAsignaturas.Size = new Size(732, 127);
            gbAsignaturas.TabIndex = 13;
            gbAsignaturas.TabStop = false;
            gbAsignaturas.Text = "Asignaturas";
            gbAsignaturas.Visible = false;
            // 
            // dgvAsignaturas
            // 
            dgvAsignaturas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAsignaturas.Dock = DockStyle.Fill;
            dgvAsignaturas.Location = new Point(3, 19);
            dgvAsignaturas.Name = "dgvAsignaturas";
            dgvAsignaturas.Size = new Size(726, 105);
            dgvAsignaturas.TabIndex = 0;
            // 
            // gbCarrera
            // 
            gbCarrera.Controls.Add(txtAño);
            gbCarrera.Controls.Add(txtCarrera);
            gbCarrera.Controls.Add(label4);
            gbCarrera.Controls.Add(label5);
            gbCarrera.Location = new Point(22, 232);
            gbCarrera.Name = "gbCarrera";
            gbCarrera.Size = new Size(311, 99);
            gbCarrera.TabIndex = 1;
            gbCarrera.TabStop = false;
            gbCarrera.Text = "Mi situación Academica";
            gbCarrera.Visible = false;
            // 
            // txtAño
            // 
            txtAño.Location = new Point(120, 68);
            txtAño.Name = "txtAño";
            txtAño.ReadOnly = true;
            txtAño.Size = new Size(127, 23);
            txtAño.TabIndex = 10;
            // 
            // txtCarrera
            // 
            txtCarrera.Location = new Point(122, 24);
            txtCarrera.Name = "txtCarrera";
            txtCarrera.ReadOnly = true;
            txtCarrera.Size = new Size(127, 23);
            txtCarrera.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 71);
            label4.Name = "label4";
            label4.Size = new Size(75, 15);
            label4.TabIndex = 8;
            label4.Text = "Año Cursada";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 27);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 7;
            label5.Text = "Carrera";
            // 
            // btnActualizar
            // 
            btnActualizar.Anchor = AnchorStyles.Bottom;
            btnActualizar.Location = new Point(188, 121);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(140, 60);
            btnActualizar.TabIndex = 6;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // groupUsuarioYPass
            // 
            groupUsuarioYPass.Controls.Add(txtPass);
            groupUsuarioYPass.Controls.Add(btnActualizar);
            groupUsuarioYPass.Controls.Add(txtUsuario);
            groupUsuarioYPass.Controls.Add(label6);
            groupUsuarioYPass.Controls.Add(label7);
            groupUsuarioYPass.Location = new Point(400, 13);
            groupUsuarioYPass.Name = "groupUsuarioYPass";
            groupUsuarioYPass.Size = new Size(354, 198);
            groupUsuarioYPass.TabIndex = 11;
            groupUsuarioYPass.TabStop = false;
            groupUsuarioYPass.Text = "Mi Usuario y Contraseña";
            // 
            // txtPass
            // 
            txtPass.Location = new Point(131, 75);
            txtPass.Name = "txtPass";
            txtPass.ReadOnly = true;
            txtPass.Size = new Size(197, 23);
            txtPass.TabIndex = 10;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(131, 36);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.ReadOnly = true;
            txtUsuario.Size = new Size(197, 23);
            txtUsuario.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(26, 78);
            label6.Name = "label6";
            label6.Size = new Size(67, 15);
            label6.TabIndex = 8;
            label6.Text = "Contraseña";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(26, 39);
            label7.Name = "label7";
            label7.Size = new Size(50, 15);
            label7.TabIndex = 7;
            label7.Text = "Usuario ";
            // 
            // btnVolverMenu
            // 
            btnVolverMenu.Anchor = AnchorStyles.Bottom;
            btnVolverMenu.Location = new Point(588, 372);
            btnVolverMenu.Name = "btnVolverMenu";
            btnVolverMenu.Size = new Size(140, 60);
            btnVolverMenu.TabIndex = 7;
            btnVolverMenu.Text = "Volver al Menu";
            btnVolverMenu.UseVisualStyleBackColor = true;
            btnVolverMenu.Click += btnVolverMenu_Click;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // miPerfil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(774, 461);
            ControlBox = false;
            Controls.Add(btnVolverMenu);
            Controls.Add(gbAsignaturas);
            Controls.Add(groupBoxAcualizar);
            Controls.Add(groupUsuarioYPass);
            Controls.Add(gbCarrera);
            Controls.Add(groupBox2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "miPerfil";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Mi perfil";
            Load += miPerfil_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBoxAcualizar.ResumeLayout(false);
            groupBoxAcualizar.PerformLayout();
            gbAsignaturas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAsignaturas).EndInit();
            gbCarrera.ResumeLayout(false);
            gbCarrera.PerformLayout();
            groupUsuarioYPass.ResumeLayout(false);
            groupUsuarioYPass.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox2;
        private Label label11;
        private TextBox txtIdLogin;
        private Label label3;
        private TextBox txtNombre;
        private Label label1;
        private Label label2;
        private TextBox txtApellido;
        private Label lblFechaAmigable;
        private GroupBox gbCarrera;
        private TextBox txtAño;
        private TextBox txtCarrera;
        private Label label4;
        private Label label5;
        private GroupBox groupUsuarioYPass;
        private TextBox txtPass;
        private TextBox txtUsuario;
        private Label label6;
        private Label label7;
        private GroupBox groupBoxAcualizar;
        private Button btnGuardar;
        private TextBox txtPasss;
        private Label label8;
        private Button btnCancelar;
        private Button btnActualizar;
        private GroupBox gbAsignaturas;
        private DataGridView dgvAsignaturas;
        private Button btnVolverMenu;
        private ErrorProvider errorProvider;
    }
}