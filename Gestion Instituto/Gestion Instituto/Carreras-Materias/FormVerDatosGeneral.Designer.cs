namespace Gestion_Instituto
{
    partial class FormVerDatosGeneral
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVerDatosGeneral));
            dataGridView = new DataGridView();
            btnNueva = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            chkVerBajas = new CheckBox();
            panelBotones = new Panel();
            btnRestaurar = new Button();
            btnVolver = new Button();
            lblNombre = new Label();
            lblNombreDato = new Label();
            lblDescripcion = new Label();
            lblEspecifico = new Label();
            lblEspecificoDato = new Label();
            lblDescripcionDato = new TextBox();
            btnDetalles = new Button();
            cmbCarrera = new ComboBox();
            cmbCursada = new ComboBox();
            panelFiltroCarrera = new Panel();
            btnReiniciarFiltro = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            panelBotones.SuspendLayout();
            panelFiltroCarrera.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView.Location = new Point(12, 12);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.ShowEditingIcon = false;
            dataGridView.Size = new Size(860, 245);
            dataGridView.TabIndex = 0;
            dataGridView.SelectionChanged += dataGridView_SelectionChanged;
            // 
            // btnNueva
            // 
            btnNueva.Anchor = AnchorStyles.Top;
            btnNueva.Location = new Point(90, 23);
            btnNueva.Name = "btnNueva";
            btnNueva.Size = new Size(140, 60);
            btnNueva.TabIndex = 1;
            btnNueva.Text = "Crear nueva";
            btnNueva.UseVisualStyleBackColor = true;
            btnNueva.Click += btnNueva_Click;
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.Top;
            btnEditar.Location = new Point(278, 23);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(140, 60);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Top;
            btnEliminar.Location = new Point(466, 23);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(140, 60);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // chkVerBajas
            // 
            chkVerBajas.AutoSize = true;
            chkVerBajas.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkVerBajas.Location = new Point(12, 263);
            chkVerBajas.Name = "chkVerBajas";
            chkVerBajas.Size = new Size(131, 22);
            chkVerBajas.TabIndex = 4;
            chkVerBajas.Text = "Ver eliminadas";
            chkVerBajas.UseVisualStyleBackColor = true;
            chkVerBajas.CheckedChanged += chkVerBajas_CheckedChanged;
            // 
            // panelBotones
            // 
            panelBotones.Controls.Add(btnRestaurar);
            panelBotones.Controls.Add(btnVolver);
            panelBotones.Controls.Add(btnNueva);
            panelBotones.Controls.Add(btnEditar);
            panelBotones.Controls.Add(btnEliminar);
            panelBotones.Dock = DockStyle.Bottom;
            panelBotones.Location = new Point(0, 441);
            panelBotones.Name = "panelBotones";
            panelBotones.Size = new Size(884, 120);
            panelBotones.TabIndex = 5;
            // 
            // btnRestaurar
            // 
            btnRestaurar.Anchor = AnchorStyles.Top;
            btnRestaurar.Enabled = false;
            btnRestaurar.Location = new Point(466, 23);
            btnRestaurar.Name = "btnRestaurar";
            btnRestaurar.Size = new Size(140, 60);
            btnRestaurar.TabIndex = 4;
            btnRestaurar.Text = "Restaurar";
            btnRestaurar.UseVisualStyleBackColor = true;
            btnRestaurar.Visible = false;
            btnRestaurar.Click += btnRestaurar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Anchor = AnchorStyles.Top;
            btnVolver.Location = new Point(654, 23);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(140, 60);
            btnVolver.TabIndex = 4;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Arial", 12F);
            lblNombre.Location = new Point(90, 308);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(68, 18);
            lblNombre.TabIndex = 6;
            lblNombre.Text = "Nombre:";
            // 
            // lblNombreDato
            // 
            lblNombreDato.AutoSize = true;
            lblNombreDato.Font = new Font("Arial", 12F);
            lblNombreDato.Location = new Point(192, 308);
            lblNombreDato.Name = "lblNombreDato";
            lblNombreDato.Size = new Size(13, 18);
            lblNombreDato.TabIndex = 7;
            lblNombreDato.Text = "-";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Arial", 12F);
            lblDescripcion.Location = new Point(90, 376);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(96, 18);
            lblDescripcion.TabIndex = 8;
            lblDescripcion.Text = "Descripcion:";
            // 
            // lblEspecifico
            // 
            lblEspecifico.AutoSize = true;
            lblEspecifico.Font = new Font("Arial", 12F);
            lblEspecifico.Location = new Point(90, 342);
            lblEspecifico.Name = "lblEspecifico";
            lblEspecifico.Size = new Size(89, 18);
            lblEspecifico.TabIndex = 10;
            lblEspecifico.Text = "placeholder";
            // 
            // lblEspecificoDato
            // 
            lblEspecificoDato.AutoSize = true;
            lblEspecificoDato.Font = new Font("Arial", 12F);
            lblEspecificoDato.Location = new Point(192, 342);
            lblEspecificoDato.Name = "lblEspecificoDato";
            lblEspecificoDato.Size = new Size(13, 18);
            lblEspecificoDato.TabIndex = 11;
            lblEspecificoDato.Text = "-";
            // 
            // lblDescripcionDato
            // 
            lblDescripcionDato.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblDescripcionDato.BorderStyle = BorderStyle.None;
            lblDescripcionDato.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescripcionDato.Location = new Point(192, 376);
            lblDescripcionDato.Multiline = true;
            lblDescripcionDato.Name = "lblDescripcionDato";
            lblDescripcionDato.ReadOnly = true;
            lblDescripcionDato.Size = new Size(602, 58);
            lblDescripcionDato.TabIndex = 12;
            lblDescripcionDato.Tag = "";
            // 
            // btnDetalles
            // 
            btnDetalles.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDetalles.Location = new Point(654, 300);
            btnDetalles.Name = "btnDetalles";
            btnDetalles.Size = new Size(140, 60);
            btnDetalles.TabIndex = 13;
            btnDetalles.Text = "Ver Detalles";
            btnDetalles.UseVisualStyleBackColor = true;
            btnDetalles.Click += btnDetalles_Click;
            // 
            // cmbCarrera
            // 
            cmbCarrera.Anchor = AnchorStyles.Right;
            cmbCarrera.FormattingEnabled = true;
            cmbCarrera.Location = new Point(16, 1);
            cmbCarrera.Name = "cmbCarrera";
            cmbCarrera.Size = new Size(140, 23);
            cmbCarrera.TabIndex = 14;
            cmbCarrera.Text = "Carrera";
            cmbCarrera.SelectedIndexChanged += cmbCarrera_SelectedIndexChanged;
            // 
            // cmbCursada
            // 
            cmbCursada.Anchor = AnchorStyles.Right;
            cmbCursada.FormattingEnabled = true;
            cmbCursada.Items.AddRange(new object[] { "1", "2", "3" });
            cmbCursada.Location = new Point(162, 1);
            cmbCursada.Margin = new Padding(3, 3, 0, 3);
            cmbCursada.Name = "cmbCursada";
            cmbCursada.Size = new Size(72, 23);
            cmbCursada.TabIndex = 15;
            cmbCursada.Text = "Año";
            cmbCursada.SelectedIndexChanged += cmbCursada_SelectedIndexChanged;
            // 
            // panelFiltroCarrera
            // 
            panelFiltroCarrera.Controls.Add(btnReiniciarFiltro);
            panelFiltroCarrera.Controls.Add(cmbCursada);
            panelFiltroCarrera.Controls.Add(cmbCarrera);
            panelFiltroCarrera.Location = new Point(537, 263);
            panelFiltroCarrera.Name = "panelFiltroCarrera";
            panelFiltroCarrera.Size = new Size(335, 29);
            panelFiltroCarrera.TabIndex = 17;
            // 
            // btnReiniciarFiltro
            // 
            btnReiniciarFiltro.Anchor = AnchorStyles.Right;
            btnReiniciarFiltro.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReiniciarFiltro.Location = new Point(237, 1);
            btnReiniciarFiltro.Name = "btnReiniciarFiltro";
            btnReiniciarFiltro.Size = new Size(95, 25);
            btnReiniciarFiltro.TabIndex = 17;
            btnReiniciarFiltro.Text = "Reiniciar";
            btnReiniciarFiltro.UseVisualStyleBackColor = true;
            btnReiniciarFiltro.Click += btnReiniciarFiltro_Click;
            // 
            // FormVerDatosGeneral
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 561);
            ControlBox = false;
            Controls.Add(panelFiltroCarrera);
            Controls.Add(btnDetalles);
            Controls.Add(lblDescripcionDato);
            Controls.Add(lblEspecificoDato);
            Controls.Add(lblEspecifico);
            Controls.Add(lblDescripcion);
            Controls.Add(lblNombreDato);
            Controls.Add(lblNombre);
            Controls.Add(panelBotones);
            Controls.Add(chkVerBajas);
            Controls.Add(dataGridView);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormVerDatosGeneral";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Titulo";
            Load += FormVerCarrerasMaterias_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            panelBotones.ResumeLayout(false);
            panelFiltroCarrera.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView;
        private Button btnNueva;
        private Button btnEditar;
        private Button btnEliminar;
        private CheckBox chkVerBajas;
        private Panel panelBotones;
        private Button btnRestaurar;
        private Button btnVolver;
        private Label lblNombre;
        private Label lblNombreDato;
        private Label lblDescripcion;
        private Label lblEspecifico;
        private Label lblEspecificoDato;
        private TextBox lblDescripcionDato;
        private Button btnDetalles;
        private ComboBox cmbCarrera;
        private ComboBox cmbCursada;
        private Panel panelFiltroCarrera;
        private Button btnReiniciarFiltro;
    }
}