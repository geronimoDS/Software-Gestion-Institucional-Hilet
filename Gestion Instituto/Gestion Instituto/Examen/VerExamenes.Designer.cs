namespace Gestion_Instituto
{
    partial class VerExamenes
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
            pnlVE = new Panel();
            pnlBOTTOM = new Panel();
            btnCargarNotas = new Button();
            btnCrearExamen = new Button();
            btnSALIR = new Button();
            pnlTOP = new Panel();
            dgvExamens = new DataGridView();
            pnlVE.SuspendLayout();
            pnlBOTTOM.SuspendLayout();
            pnlTOP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvExamens).BeginInit();
            SuspendLayout();
            // 
            // pnlVE
            // 
            pnlVE.Controls.Add(pnlBOTTOM);
            pnlVE.Controls.Add(pnlTOP);
            pnlVE.Dock = DockStyle.Fill;
            pnlVE.Location = new Point(0, 0);
            pnlVE.Name = "pnlVE";
            pnlVE.Size = new Size(800, 450);
            pnlVE.TabIndex = 0;
            // 
            // pnlBOTTOM
            // 
            pnlBOTTOM.Controls.Add(btnCargarNotas);
            pnlBOTTOM.Controls.Add(btnCrearExamen);
            pnlBOTTOM.Controls.Add(btnSALIR);
            pnlBOTTOM.Dock = DockStyle.Bottom;
            pnlBOTTOM.Location = new Point(0, 337);
            pnlBOTTOM.Name = "pnlBOTTOM";
            pnlBOTTOM.Size = new Size(800, 113);
            pnlBOTTOM.TabIndex = 1;
            // 
            // btnCargarNotas
            // 
            btnCargarNotas.Location = new Point(211, 33);
            btnCargarNotas.Name = "btnCargarNotas";
            btnCargarNotas.Size = new Size(112, 36);
            btnCargarNotas.TabIndex = 2;
            btnCargarNotas.Text = "Cargar Notas";
            btnCargarNotas.UseVisualStyleBackColor = true;
            btnCargarNotas.Click += btnCargarNotas_Click;
            // 
            // btnCrearExamen
            // 
            btnCrearExamen.Location = new Point(50, 33);
            btnCrearExamen.Name = "btnCrearExamen";
            btnCrearExamen.Size = new Size(112, 36);
            btnCrearExamen.TabIndex = 1;
            btnCrearExamen.Text = "Crear Examen";
            btnCrearExamen.UseVisualStyleBackColor = true;
            btnCrearExamen.Click += btnCrearExamen_Click;
            // 
            // btnSALIR
            // 
            btnSALIR.Location = new Point(611, 33);
            btnSALIR.Name = "btnSALIR";
            btnSALIR.Size = new Size(112, 36);
            btnSALIR.TabIndex = 0;
            btnSALIR.Text = "Salir";
            btnSALIR.UseVisualStyleBackColor = true;
            btnSALIR.Click += btnSALIR_Click;
            // 
            // pnlTOP
            // 
            pnlTOP.Controls.Add(dgvExamens);
            pnlTOP.Dock = DockStyle.Fill;
            pnlTOP.Location = new Point(0, 0);
            pnlTOP.Name = "pnlTOP";
            pnlTOP.Size = new Size(800, 450);
            pnlTOP.TabIndex = 0;
            // 
            // dgvExamens
            // 
            dgvExamens.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExamens.Location = new Point(12, 12);
            dgvExamens.Name = "dgvExamens";
            dgvExamens.Size = new Size(776, 319);
            dgvExamens.TabIndex = 0;
            // 
            // VerExamenes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlVE);
            Name = "VerExamenes";
            Text = "Ver examenes";
            Load += VerExamenes_Load;
            pnlVE.ResumeLayout(false);
            pnlBOTTOM.ResumeLayout(false);
            pnlTOP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvExamens).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlVE;
        private Panel pnlBOTTOM;
        private Panel pnlTOP;
        private Button btnSALIR;
        private DataGridView dgvExamens;
        private Button btnCrearExamen;
        private Button btnCargarNotas;
    }
}