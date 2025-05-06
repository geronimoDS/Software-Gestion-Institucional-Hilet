namespace Gestion_Instituto
{
    partial class FormListaAlumnos
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
            pnlLA = new Panel();
            dgvLA = new DataGridView();
            pnlLA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLA).BeginInit();
            SuspendLayout();
            // 
            // pnlLA
            // 
            pnlLA.Controls.Add(dgvLA);
            pnlLA.Dock = DockStyle.Fill;
            pnlLA.Location = new Point(0, 0);
            pnlLA.Name = "pnlLA";
            pnlLA.Size = new Size(334, 311);
            pnlLA.TabIndex = 0;
            // 
            // dgvLA
            // 
            dgvLA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLA.Dock = DockStyle.Fill;
            dgvLA.Location = new Point(0, 0);
            dgvLA.Name = "dgvLA";
            dgvLA.Size = new Size(334, 311);
            dgvLA.TabIndex = 0;
            dgvLA.CellContentClick += dgvLA_CellContentClick;
            dgvLA.CellDoubleClick += dgvLA_CellDoubleClick;
            // 
            // FormListaAlumnos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 311);
            Controls.Add(pnlLA);
            MaximumSize = new Size(350, 350);
            MinimumSize = new Size(350, 350);
            Name = "FormListaAlumnos";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "Lista de alumnos";
            Load += FormListaAlumnos_Load;
            pnlLA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvLA).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlLA;
        private DataGridView dgvLA;
    }
}