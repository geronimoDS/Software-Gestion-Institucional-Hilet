namespace Gestion_Instituto
{
    partial class FormMostrar
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
            dataGridView1 = new DataGridView();
            btnModificar = new Button();
            panel1 = new Panel();
            btnNuevo = new Button();
            btnDarDeAlta = new Button();
            btnVolverMenu = new Button();
            btnDardDeBaja = new Button();
            chkVerInactivos = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(860, 384);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // btnModificar
            // 
            btnModificar.Anchor = AnchorStyles.Top;
            btnModificar.Location = new Point(279, 23);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(140, 60);
            btnModificar.TabIndex = 2;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnNuevo);
            panel1.Controls.Add(btnDarDeAlta);
            panel1.Controls.Add(btnVolverMenu);
            panel1.Controls.Add(btnDardDeBaja);
            panel1.Controls.Add(btnModificar);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 441);
            panel1.Name = "panel1";
            panel1.Size = new Size(884, 120);
            panel1.TabIndex = 3;
            // 
            // btnNuevo
            // 
            btnNuevo.Anchor = AnchorStyles.Top;
            btnNuevo.Location = new Point(93, 23);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(140, 60);
            btnNuevo.TabIndex = 7;
            btnNuevo.Text = "Cargar nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnDarDeAlta
            // 
            btnDarDeAlta.Anchor = AnchorStyles.Top;
            btnDarDeAlta.Enabled = false;
            btnDarDeAlta.Location = new Point(465, 23);
            btnDarDeAlta.Name = "btnDarDeAlta";
            btnDarDeAlta.Size = new Size(140, 60);
            btnDarDeAlta.TabIndex = 6;
            btnDarDeAlta.Text = "Dar de Alta";
            btnDarDeAlta.UseVisualStyleBackColor = true;
            btnDarDeAlta.Click += btnDarDeAlta_Click;
            // 
            // btnVolverMenu
            // 
            btnVolverMenu.Anchor = AnchorStyles.Top;
            btnVolverMenu.Location = new Point(651, 23);
            btnVolverMenu.Name = "btnVolverMenu";
            btnVolverMenu.Size = new Size(140, 60);
            btnVolverMenu.TabIndex = 3;
            btnVolverMenu.Text = "Volver al Menu";
            btnVolverMenu.UseVisualStyleBackColor = true;
            btnVolverMenu.Click += button1_Click;
            // 
            // btnDardDeBaja
            // 
            btnDardDeBaja.Anchor = AnchorStyles.Top;
            btnDardDeBaja.Enabled = false;
            btnDardDeBaja.Location = new Point(465, 23);
            btnDardDeBaja.Name = "btnDardDeBaja";
            btnDardDeBaja.Size = new Size(140, 60);
            btnDardDeBaja.TabIndex = 4;
            btnDardDeBaja.Text = "Dar de Baja";
            btnDardDeBaja.UseVisualStyleBackColor = true;
            btnDardDeBaja.Click += btnDardDeBaja_Click;
            // 
            // chkVerInactivos
            // 
            chkVerInactivos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            chkVerInactivos.AutoSize = true;
            chkVerInactivos.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkVerInactivos.Location = new Point(11, 402);
            chkVerInactivos.Name = "chkVerInactivos";
            chkVerInactivos.Size = new Size(115, 22);
            chkVerInactivos.TabIndex = 5;
            chkVerInactivos.Text = "Ver Inactivos";
            chkVerInactivos.UseVisualStyleBackColor = true;
            chkVerInactivos.CheckedChanged += chkVerInactivos_CheckedChanged;
            // 
            // FormMostrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 561);
            ControlBox = false;
            Controls.Add(panel1);
            Controls.Add(chkVerInactivos);
            Controls.Add(dataGridView1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormMostrar";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Ver datos";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnModificar;
        private Panel panel1;
        private Button btnVolverMenu;
        private Button btnDardDeBaja;
        private CheckBox chkVerInactivos;
        private Button btnDarDeAlta;
        private Button btnNuevo;
    }
}