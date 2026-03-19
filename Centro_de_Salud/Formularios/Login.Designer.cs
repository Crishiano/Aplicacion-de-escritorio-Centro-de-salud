namespace CapaPresentacion.Formularios
{
    partial class Login
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
            btnVerContraseña = new Button();
            txtContraseña = new TextBox();
            txtUsuario = new TextBox();
            btnIniciarSesion = new Button();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnVerContraseña
            // 
            btnVerContraseña.Anchor = AnchorStyles.None;
            btnVerContraseña.BackgroundImageLayout = ImageLayout.Zoom;
            btnVerContraseña.Location = new Point(962, 244);
            btnVerContraseña.Margin = new Padding(3, 2, 3, 2);
            btnVerContraseña.Name = "btnVerContraseña";
            btnVerContraseña.Size = new Size(43, 29);
            btnVerContraseña.TabIndex = 23;
            btnVerContraseña.UseVisualStyleBackColor = true;
            btnVerContraseña.Click += btnVerContraseña_Click;
            // 
            // txtContraseña
            // 
            txtContraseña.Anchor = AnchorStyles.None;
            txtContraseña.Font = new Font("Consolas", 16.2F, FontStyle.Bold);
            txtContraseña.Location = new Point(708, 243);
            txtContraseña.Margin = new Padding(3, 2, 3, 2);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '*';
            txtContraseña.Size = new Size(239, 33);
            txtContraseña.TabIndex = 22;
            // 
            // txtUsuario
            // 
            txtUsuario.Anchor = AnchorStyles.None;
            txtUsuario.Font = new Font("Consolas", 16.2F, FontStyle.Bold);
            txtUsuario.Location = new Point(708, 196);
            txtUsuario.Margin = new Padding(3, 2, 3, 2);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(239, 33);
            txtUsuario.TabIndex = 21;
            // 
            // btnIniciarSesion
            // 
            btnIniciarSesion.Anchor = AnchorStyles.None;
            btnIniciarSesion.BackColor = Color.FromArgb(0, 40, 145);
            btnIniciarSesion.Font = new Font("Calisto MT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIniciarSesion.ForeColor = Color.White;
            btnIniciarSesion.Location = new Point(708, 313);
            btnIniciarSesion.Margin = new Padding(3, 2, 3, 2);
            btnIniciarSesion.Name = "btnIniciarSesion";
            btnIniciarSesion.Size = new Size(142, 33);
            btnIniciarSesion.TabIndex = 19;
            btnIniciarSesion.Text = "Iniciar Sesión";
            btnIniciarSesion.UseVisualStyleBackColor = false;
            btnIniciarSesion.Click += btnIniciarSesion_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Calisto MT", 16.2F, FontStyle.Bold);
            label2.Location = new Point(553, 244);
            label2.Name = "label2";
            label2.Size = new Size(141, 25);
            label2.TabIndex = 18;
            label2.Text = "Contraseña :";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Calisto MT", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(589, 200);
            label1.Name = "label1";
            label1.Size = new Size(105, 25);
            label1.TabIndex = 17;
            label1.Text = "Usuario :";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.BackColor = Color.FromArgb(0, 40, 145);
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(553, 116);
            label3.Name = "label3";
            label3.Size = new Size(452, 38);
            label3.TabIndex = 24;
            label3.Text = "BIENVENIDO";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = Properties.Resources.logosaludgrande;
            pictureBox1.Location = new Point(49, 45);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(451, 295);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(30, 103, 186);
            label4.Font = new Font("Arial Rounded MT Bold", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(50, 340);
            label4.Name = "label4";
            label4.Size = new Size(446, 44);
            label4.TabIndex = 26;
            label4.Text = "Tu centro de confianza";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1024, 476);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(btnVerContraseña);
            Controls.Add(txtContraseña);
            Controls.Add(txtUsuario);
            Controls.Add(btnIniciarSesion);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Login";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVerContraseña;
        private TextBox txtContraseña;
        private TextBox txtUsuario;
        private Button btnIniciarSesion;
        private Label label2;
        private Label label1;
        private Label label3;
        private PictureBox pictureBox1;
        private Label label4;
    }
}