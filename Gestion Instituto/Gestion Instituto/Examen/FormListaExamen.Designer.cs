namespace Gestion_Instituto
{
    partial class FormListaExamen
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
            pnlFLE = new Panel();
            dgvLE = new DataGridView();
            pnlFLE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLE).BeginInit();
            SuspendLayout();
            // 
            // pnlFLE
            // 
            pnlFLE.Controls.Add(dgvLE);
            pnlFLE.Dock = DockStyle.Fill;
            pnlFLE.Location = new Point(0, 0);
            pnlFLE.Name = "pnlFLE";
            pnlFLE.Size = new Size(434, 411);
            pnlFLE.TabIndex = 0;
            // 
            // dgvLE
            // 
            dgvLE.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLE.Dock = DockStyle.Fill;
            dgvLE.Location = new Point(0, 0);
            dgvLE.Name = "dgvLE";
            dgvLE.Size = new Size(434, 411);
            dgvLE.TabIndex = 0;
            dgvLE.CellContentClick += dgvLE_CellContentClick;
            dgvLE.CellDoubleClick += dgvLE_CellDoubleClick;
            // 
            // FormListaExamen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 411);
            Controls.Add(pnlFLE);
            MaximizeBox = false;
            MaximumSize = new Size(450, 450);
            MinimizeBox = false;
            MinimumSize = new Size(450, 450);
            Name = "FormListaExamen";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Lista examenes";
            Load += FormListaExamen_Load;
            pnlFLE.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvLE).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlFLE;
        private DataGridView dgvLE;
    }
}