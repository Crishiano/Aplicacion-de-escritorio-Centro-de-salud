namespace CapaPresentacion.Formularios
{
    partial class MantenimientoUsuarios
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
            label1 = new Label();
            dgvDatos = new DataGridView();
            btnRegistrar = new Button();
            btnModificar = new Button();
            btnNuevo = new Button();
            gboDatos = new GroupBox();
            cboPaciente = new ComboBox();
            cboMedico = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            btnOjo2 = new Button();
            txtContraseñaValidacion = new TextBox();
            label8 = new Label();
            btnOjo = new Button();
            chkActivo = new CheckBox();
            label7 = new Label();
            cmbRol = new ComboBox();
            txtContraseña = new TextBox();
            label5 = new Label();
            txtUsuario = new TextBox();
            label6 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            gboDatos.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(0, 88, 255);
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Verdana", 19.8000011F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(6, 13);
            label1.Name = "label1";
            label1.Size = new Size(1124, 77);
            label1.TabIndex = 14;
            label1.Text = "REGISTRAR USUARIO";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvDatos
            // 
            dgvDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDatos.BackgroundColor = Color.White;
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Dock = DockStyle.Fill;
            dgvDatos.Location = new Point(0, 0);
            dgvDatos.Margin = new Padding(3, 4, 3, 4);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.ReadOnly = true;
            dgvDatos.RowHeadersWidth = 51;
            dgvDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDatos.Size = new Size(1124, 383);
            dgvDatos.TabIndex = 37;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.FromArgb(219, 214, 214);
            btnRegistrar.Font = new Font("Arial Rounded MT Bold", 12F);
            btnRegistrar.ForeColor = Color.Black;
            btnRegistrar.Location = new Point(19, 99);
            btnRegistrar.Margin = new Padding(5, 4, 5, 4);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(137, 64);
            btnRegistrar.TabIndex = 36;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click_1;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.FromArgb(219, 214, 214);
            btnModificar.Font = new Font("Arial Rounded MT Bold", 12F);
            btnModificar.ForeColor = Color.Black;
            btnModificar.Location = new Point(18, 171);
            btnModificar.Margin = new Padding(5, 4, 5, 4);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(137, 63);
            btnModificar.TabIndex = 35;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click_1;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = Color.FromArgb(219, 214, 214);
            btnNuevo.Font = new Font("Arial Rounded MT Bold", 12F);
            btnNuevo.ForeColor = Color.Black;
            btnNuevo.Location = new Point(19, 27);
            btnNuevo.Margin = new Padding(5, 4, 5, 4);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(137, 64);
            btnNuevo.TabIndex = 34;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click_1;
            // 
            // gboDatos
            // 
            gboDatos.Anchor = AnchorStyles.None;
            gboDatos.Controls.Add(cboPaciente);
            gboDatos.Controls.Add(cboMedico);
            gboDatos.Controls.Add(label2);
            gboDatos.Controls.Add(label3);
            gboDatos.Controls.Add(btnOjo2);
            gboDatos.Controls.Add(txtContraseñaValidacion);
            gboDatos.Controls.Add(label8);
            gboDatos.Controls.Add(btnOjo);
            gboDatos.Controls.Add(chkActivo);
            gboDatos.Controls.Add(label7);
            gboDatos.Controls.Add(cmbRol);
            gboDatos.Controls.Add(txtContraseña);
            gboDatos.Controls.Add(label5);
            gboDatos.Controls.Add(txtUsuario);
            gboDatos.Controls.Add(label6);
            gboDatos.Font = new Font("Arial Rounded MT Bold", 15F);
            gboDatos.Location = new Point(95, 19);
            gboDatos.Margin = new Padding(3, 4, 3, 4);
            gboDatos.Name = "gboDatos";
            gboDatos.Padding = new Padding(3, 4, 3, 4);
            gboDatos.Size = new Size(963, 289);
            gboDatos.TabIndex = 39;
            gboDatos.TabStop = false;
            gboDatos.Text = "Registro de usuario";
            // 
            // cboPaciente
            // 
            cboPaciente.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPaciente.FormattingEnabled = true;
            cboPaciente.Location = new Point(713, 171);
            cboPaciente.Margin = new Padding(3, 4, 3, 4);
            cboPaciente.Name = "cboPaciente";
            cboPaciente.Size = new Size(237, 37);
            cboPaciente.TabIndex = 36;
            cboPaciente.SelectedIndexChanged += cboPaciente_SelectedIndexChanged;
            // 
            // cboMedico
            // 
            cboMedico.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMedico.FormattingEnabled = true;
            cboMedico.Location = new Point(713, 115);
            cboMedico.Margin = new Padding(3, 4, 3, 4);
            cboMedico.Name = "cboMedico";
            cboMedico.Size = new Size(237, 37);
            cboMedico.TabIndex = 35;
            cboMedico.SelectedIndexChanged += cboMedico_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 15F);
            label2.Location = new Point(591, 176);
            label2.Name = "label2";
            label2.Size = new Size(129, 29);
            label2.TabIndex = 34;
            label2.Text = "Paciente:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 15F);
            label3.Location = new Point(607, 120);
            label3.Name = "label3";
            label3.Size = new Size(110, 29);
            label3.TabIndex = 32;
            label3.Text = "Medico:";
            // 
            // btnOjo2
            // 
            btnOjo2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOjo2.Location = new Point(446, 165);
            btnOjo2.Margin = new Padding(3, 4, 3, 4);
            btnOjo2.Name = "btnOjo2";
            btnOjo2.Size = new Size(55, 39);
            btnOjo2.TabIndex = 31;
            btnOjo2.Text = "O";
            btnOjo2.UseVisualStyleBackColor = true;
            btnOjo2.Click += btnOjo2_Click;
            // 
            // txtContraseñaValidacion
            // 
            txtContraseñaValidacion.Font = new Font("Consolas", 14F, FontStyle.Bold);
            txtContraseñaValidacion.Location = new Point(201, 167);
            txtContraseñaValidacion.MaxLength = 25;
            txtContraseñaValidacion.Name = "txtContraseñaValidacion";
            txtContraseñaValidacion.PasswordChar = '*';
            txtContraseñaValidacion.Size = new Size(237, 35);
            txtContraseñaValidacion.TabIndex = 30;
            txtContraseñaValidacion.TextChanged += txtContraseñaValidacion_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Rounded MT Bold", 15F);
            label8.Location = new Point(15, 168);
            label8.Name = "label8";
            label8.Size = new Size(186, 29);
            label8.TabIndex = 29;
            label8.Text = "Comprobar C:";
            // 
            // btnOjo
            // 
            btnOjo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOjo.Location = new Point(446, 113);
            btnOjo.Margin = new Padding(3, 4, 3, 4);
            btnOjo.Name = "btnOjo";
            btnOjo.Size = new Size(55, 39);
            btnOjo.TabIndex = 28;
            btnOjo.Text = "O";
            btnOjo.UseVisualStyleBackColor = true;
            btnOjo.Click += btnOjo_Click;
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Font = new Font("Arial Rounded MT Bold", 15F);
            chkActivo.Location = new Point(201, 229);
            chkActivo.Margin = new Padding(3, 4, 3, 4);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(113, 33);
            chkActivo.TabIndex = 27;
            chkActivo.Text = "Activo";
            chkActivo.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Rounded MT Bold", 15F);
            label7.Location = new Point(647, 63);
            label7.Name = "label7";
            label7.Size = new Size(67, 29);
            label7.TabIndex = 26;
            label7.Text = "Rol :";
            // 
            // cmbRol
            // 
            cmbRol.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRol.Font = new Font("Consolas", 14F, FontStyle.Bold);
            cmbRol.FormattingEnabled = true;
            cmbRol.Location = new Point(713, 57);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(237, 35);
            cmbRol.TabIndex = 25;
            cmbRol.SelectedIndexChanged += cmbRol_SelectedIndexChanged;
            // 
            // txtContraseña
            // 
            txtContraseña.Font = new Font("Consolas", 14F, FontStyle.Bold);
            txtContraseña.Location = new Point(201, 112);
            txtContraseña.MaxLength = 25;
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '*';
            txtContraseña.Size = new Size(237, 35);
            txtContraseña.TabIndex = 24;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 15F);
            label5.Location = new Point(82, 57);
            label5.Name = "label5";
            label5.Size = new Size(117, 29);
            label5.TabIndex = 18;
            label5.Text = "Usuario:";
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Consolas", 14F, FontStyle.Bold);
            txtUsuario.Location = new Point(201, 56);
            txtUsuario.MaxLength = 50;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(237, 35);
            txtUsuario.TabIndex = 23;
            txtUsuario.TextChanged += txtUsuario_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 15F);
            label6.Location = new Point(30, 113);
            label6.Name = "label6";
            label6.Size = new Size(170, 29);
            label6.TabIndex = 19;
            label6.Text = "Contraseña :";
            // 
            // panel1
            // 
            panel1.Controls.Add(gboDatos);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(6, 90);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1124, 337);
            panel1.TabIndex = 40;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(dgvDatos);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(6, 427);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1124, 383);
            panel2.TabIndex = 41;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnNuevo);
            panel3.Controls.Add(btnModificar);
            panel3.Controls.Add(btnRegistrar);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(949, 0);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(175, 383);
            panel3.TabIndex = 0;
            // 
            // MantenimientoUsuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(1136, 833);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MantenimientoUsuarios";
            Padding = new Padding(6, 13, 6, 0);
            Text = "MantenimientoUsuarios";
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            gboDatos.ResumeLayout(false);
            gboDatos.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private DataGridView dgvDatos;
        private Button btnRegistrar;
        private Button btnModificar;
        private Button btnNuevo;
        private GroupBox gboDatos;
        private CheckBox chkActivo;
        private Label label7;
        private ComboBox cmbRol;
        private TextBox txtContraseña;
        private Label label5;
        private TextBox txtUsuario;
        private Label label6;
        private Button btnOjo;
        private Button btnOjo2;
        private TextBox txtContraseñaValidacion;
        private Label label8;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label2;
        private Label label3;
        private ComboBox cboPaciente;
        private ComboBox cboMedico;
    }
}