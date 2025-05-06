namespace Gestion_Instituto
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            btnAcceder = new Button();
            lblUsuario = new Label();
            lblContrasena = new Label();
            txtUsuario = new TextBox();
            txtContrasena = new TextBox();
            btnSalir = new Button();
            errorProviderLogin = new ErrorProvider(components);
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)errorProviderLogin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnAcceder
            // 
            btnAcceder.Location = new Point(259, 263);
            btnAcceder.Name = "btnAcceder";
            btnAcceder.Size = new Size(140, 60);
            btnAcceder.TabIndex = 3;
            btnAcceder.Tag = "";
            btnAcceder.Text = "Acceder";
            btnAcceder.UseVisualStyleBackColor = true;
            btnAcceder.Click += btnAcceder_Click;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Arial", 12F);
            lblUsuario.Location = new Point(85, 119);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(62, 18);
            lblUsuario.TabIndex = 2;
            lblUsuario.Text = "Usuario";
            // 
            // lblContrasena
            // 
            lblContrasena.AutoSize = true;
            lblContrasena.Font = new Font("Arial", 12F);
            lblContrasena.Location = new Point(85, 184);
            lblContrasena.Name = "lblContrasena";
            lblContrasena.Size = new Size(89, 18);
            lblContrasena.TabIndex = 3;
            lblContrasena.Text = "Contraseña";
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Arial", 12F);
            txtUsuario.Location = new Point(85, 140);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(314, 26);
            txtUsuario.TabIndex = 1;
            txtUsuario.KeyDown += txtUsuario_KeyDown;
            // 
            // txtContrasena
            // 
            txtContrasena.Font = new Font("Arial", 12F);
            txtContrasena.Location = new Point(85, 205);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.PasswordChar = '•';
            txtContrasena.Size = new Size(314, 26);
            txtContrasena.TabIndex = 2;
            txtContrasena.KeyDown += txtContrasena_KeyDown;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(85, 263);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(140, 60);
            btnSalir.TabIndex = 4;
            btnSalir.Tag = "";
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // errorProviderLogin
            // 
            errorProviderLogin.ContainerControl = this;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(85, 40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(314, 56);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 361);
            Controls.Add(btnSalir);
            Controls.Add(txtContrasena);
            Controls.Add(txtUsuario);
            Controls.Add(lblContrasena);
            Controls.Add(lblUsuario);
            Controls.Add(btnAcceder);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FormLogin";
            Text = "Gestion Instituto";
            Load += FormLogin_Load;
            ((System.ComponentModel.ISupportInitialize)errorProviderLogin).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAcceder;
        private Label lblUsuario;
        private Label lblContrasena;
        private TextBox txtUsuario;
        private TextBox txtContrasena;
        private Button btnSalir;
        private ErrorProvider errorProviderLogin;
        private PictureBox pictureBox1;
    }
}
