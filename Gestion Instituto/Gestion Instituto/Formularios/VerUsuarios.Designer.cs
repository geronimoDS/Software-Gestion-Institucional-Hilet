namespace Gestion_Instituto.Formularios
{
    partial class VerUsuarios
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
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            btnCancelar = new Button();
            btnDarDeAlta = new Button();
            btnDardDeBaja = new Button();
            btnCrearAlumno = new Button();
            btnVolverMenu = new Button();
            btnGuardarCambios = new Button();
            btnModificar = new Button();
            chkVerInactivos = new CheckBox();
            groupBoxUsuario = new GroupBox();
            comboBoxRol = new ComboBox();
            groupBoxIdEstado = new GroupBox();
            txtEstado = new TextBox();
            txtID = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label12 = new Label();
            txtContraseña = new TextBox();
            txtUsuario = new TextBox();
            label2 = new Label();
            label1 = new Label();
            errorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            groupBoxUsuario.SuspendLayout();
            groupBoxIdEstado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(413, 36);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(429, 347);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(btnDarDeAlta);
            panel1.Controls.Add(btnDardDeBaja);
            panel1.Controls.Add(btnCrearAlumno);
            panel1.Controls.Add(btnVolverMenu);
            panel1.Controls.Add(btnGuardarCambios);
            panel1.Controls.Add(btnModificar);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 441);
            panel1.Name = "panel1";
            panel1.Size = new Size(884, 120);
            panel1.TabIndex = 6;
            // 
            // btnCancelar
            // 
            btnCancelar.Enabled = false;
            btnCancelar.Location = new Point(278, 23);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(140, 60);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Visible = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnDarDeAlta
            // 
            btnDarDeAlta.Location = new Point(278, 23);
            btnDarDeAlta.Name = "btnDarDeAlta";
            btnDarDeAlta.Size = new Size(140, 60);
            btnDarDeAlta.TabIndex = 6;
            btnDarDeAlta.Text = "Dar de Alta";
            btnDarDeAlta.UseVisualStyleBackColor = true;
            btnDarDeAlta.Visible = false;
            btnDarDeAlta.Click += btnDarDeAlta_Click;
            // 
            // btnDardDeBaja
            // 
            btnDardDeBaja.Location = new Point(278, 23);
            btnDardDeBaja.Name = "btnDardDeBaja";
            btnDardDeBaja.Size = new Size(140, 60);
            btnDardDeBaja.TabIndex = 4;
            btnDardDeBaja.Text = "Dar de Baja";
            btnDardDeBaja.UseVisualStyleBackColor = true;
            btnDardDeBaja.Visible = false;
            btnDardDeBaja.Click += btnDardDeBaja_Click;
            // 
            // btnCrearAlumno
            // 
            btnCrearAlumno.Location = new Point(466, 23);
            btnCrearAlumno.Name = "btnCrearAlumno";
            btnCrearAlumno.Size = new Size(140, 60);
            btnCrearAlumno.TabIndex = 7;
            btnCrearAlumno.Text = "Nuevo Alumno";
            btnCrearAlumno.UseVisualStyleBackColor = true;
            btnCrearAlumno.Click += btnCrearAlumno_Click;
            // 
            // btnVolverMenu
            // 
            btnVolverMenu.Location = new Point(654, 23);
            btnVolverMenu.Name = "btnVolverMenu";
            btnVolverMenu.Size = new Size(140, 60);
            btnVolverMenu.TabIndex = 3;
            btnVolverMenu.Text = "Volver al Menu";
            btnVolverMenu.UseVisualStyleBackColor = true;
            btnVolverMenu.Click += btnVolverMenu_Click;
            // 
            // btnGuardarCambios
            // 
            btnGuardarCambios.Enabled = false;
            btnGuardarCambios.Location = new Point(90, 23);
            btnGuardarCambios.Name = "btnGuardarCambios";
            btnGuardarCambios.Size = new Size(140, 60);
            btnGuardarCambios.TabIndex = 8;
            btnGuardarCambios.Text = "Aceptar";
            btnGuardarCambios.UseVisualStyleBackColor = true;
            btnGuardarCambios.Visible = false;
            btnGuardarCambios.Click += btnGuardarCambios_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(90, 23);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(140, 60);
            btnModificar.TabIndex = 2;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // chkVerInactivos
            // 
            chkVerInactivos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            chkVerInactivos.AutoSize = true;
            chkVerInactivos.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkVerInactivos.Location = new Point(413, 389);
            chkVerInactivos.Name = "chkVerInactivos";
            chkVerInactivos.Size = new Size(115, 22);
            chkVerInactivos.TabIndex = 7;
            chkVerInactivos.Text = "Ver Inactivos";
            chkVerInactivos.UseVisualStyleBackColor = true;
            chkVerInactivos.CheckedChanged += chkVerInactivos_CheckedChanged;
            // 
            // groupBoxUsuario
            // 
            groupBoxUsuario.Controls.Add(comboBoxRol);
            groupBoxUsuario.Controls.Add(groupBoxIdEstado);
            groupBoxUsuario.Controls.Add(label12);
            groupBoxUsuario.Controls.Add(txtContraseña);
            groupBoxUsuario.Controls.Add(txtUsuario);
            groupBoxUsuario.Controls.Add(label2);
            groupBoxUsuario.Controls.Add(label1);
            groupBoxUsuario.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBoxUsuario.Location = new Point(42, 36);
            groupBoxUsuario.Name = "groupBoxUsuario";
            groupBoxUsuario.Size = new Size(333, 347);
            groupBoxUsuario.TabIndex = 9;
            groupBoxUsuario.TabStop = false;
            groupBoxUsuario.Text = "Usuario";
            // 
            // comboBoxRol
            // 
            comboBoxRol.AccessibleDescription = "";
            comboBoxRol.AccessibleName = "";
            comboBoxRol.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRol.Font = new Font("Arial", 12F);
            comboBoxRol.FormattingEnabled = true;
            comboBoxRol.Items.AddRange(new object[] { "administrador", "personal", "profesor", "alumno" });
            comboBoxRol.Location = new Point(141, 220);
            comboBoxRol.Name = "comboBoxRol";
            comboBoxRol.Size = new Size(171, 26);
            comboBoxRol.TabIndex = 11;
            // 
            // groupBoxIdEstado
            // 
            groupBoxIdEstado.Controls.Add(txtEstado);
            groupBoxIdEstado.Controls.Add(txtID);
            groupBoxIdEstado.Controls.Add(label4);
            groupBoxIdEstado.Controls.Add(label5);
            groupBoxIdEstado.Location = new Point(21, 22);
            groupBoxIdEstado.Name = "groupBoxIdEstado";
            groupBoxIdEstado.Size = new Size(291, 54);
            groupBoxIdEstado.TabIndex = 10;
            groupBoxIdEstado.TabStop = false;
            // 
            // txtEstado
            // 
            txtEstado.BackColor = SystemColors.ButtonHighlight;
            txtEstado.Font = new Font("Arial", 12F);
            txtEstado.Location = new Point(196, 21);
            txtEstado.Name = "txtEstado";
            txtEstado.ReadOnly = true;
            txtEstado.Size = new Size(89, 26);
            txtEstado.TabIndex = 9;
            // 
            // txtID
            // 
            txtID.Font = new Font("Arial", 12F);
            txtID.Location = new Point(38, 21);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(50, 26);
            txtID.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F);
            label4.Location = new Point(120, 24);
            label4.Name = "label4";
            label4.Size = new Size(58, 18);
            label4.TabIndex = 3;
            label4.Text = "Estado";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F);
            label5.Location = new Point(9, 24);
            label5.Name = "label5";
            label5.Size = new Size(23, 18);
            label5.TabIndex = 4;
            label5.Text = "ID";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial", 12F);
            label12.Location = new Point(30, 223);
            label12.Name = "label12";
            label12.Size = new Size(52, 18);
            label12.TabIndex = 10;
            label12.Text = "Cargo";
            // 
            // txtContraseña
            // 
            txtContraseña.Font = new Font("Arial", 12F);
            txtContraseña.Location = new Point(141, 166);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(171, 26);
            txtContraseña.TabIndex = 6;
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Arial", 12F);
            txtUsuario.Location = new Point(141, 112);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(171, 26);
            txtUsuario.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F);
            label2.Location = new Point(30, 169);
            label2.Name = "label2";
            label2.Size = new Size(89, 18);
            label2.TabIndex = 1;
            label2.Text = "Contraseña";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F);
            label1.Location = new Point(30, 115);
            label1.Name = "label1";
            label1.Size = new Size(66, 18);
            label1.TabIndex = 0;
            label1.Text = "Usuario ";
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // VerUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 561);
            ControlBox = false;
            Controls.Add(groupBoxUsuario);
            Controls.Add(panel1);
            Controls.Add(chkVerInactivos);
            Controls.Add(dataGridView1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "VerUsuarios";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Ver usuarios";
            Load += VerUsuarios_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            groupBoxUsuario.ResumeLayout(false);
            groupBoxUsuario.PerformLayout();
            groupBoxIdEstado.ResumeLayout(false);
            groupBoxIdEstado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Panel panel1;
        private Button btnDarDeAlta;
        private Button btnDardDeBaja;
        private Button btnVolverMenu;
        private Button btnModificar;
        private CheckBox chkVerInactivos;
        private GroupBox groupBoxUsuario;
        private TextBox txtEstado;
        private TextBox txtID;
        private TextBox txtContraseña;
        private TextBox txtUsuario;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label1;
        private GroupBox groupBoxIdEstado;
        private ComboBox comboBoxRol;
        private Label label12;
        private ErrorProvider errorProvider;
        private Button btnCancelar;
        private Button btnGuardarCambios;
        private Button btnCrearAlumno;
    }
}