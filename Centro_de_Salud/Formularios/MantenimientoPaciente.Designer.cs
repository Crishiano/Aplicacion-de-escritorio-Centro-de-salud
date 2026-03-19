namespace CapaPresentacion.Formularios
{
    partial class MantenimientoPaciente
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
            dgvPacientes = new DataGridView();
            txtDNI = new TextBox();
            txtTelefono = new TextBox();
            txtDireccion = new TextBox();
            txtApPat = new TextBox();
            txtNombres = new TextBox();
            btnModificar = new Button();
            btnNuevo = new Button();
            btnRegistrar = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvPacientes).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvPacientes
            // 
            dgvPacientes.AllowUserToDeleteRows = false;
            dgvPacientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPacientes.BackgroundColor = Color.White;
            dgvPacientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPacientes.Dock = DockStyle.Fill;
            dgvPacientes.Location = new Point(0, 0);
            dgvPacientes.Name = "dgvPacientes";
            dgvPacientes.ReadOnly = true;
            dgvPacientes.RowHeadersWidth = 51;
            dgvPacientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPacientes.Size = new Size(913, 265);
            dgvPacientes.TabIndex = 31;
            dgvPacientes.CellClick += dgvPacientes_CellClick_1;
            dgvPacientes.CellContentClick += dgvPacientes_CellContentClick;
            // 
            // txtDNI
            // 
            txtDNI.Anchor = AnchorStyles.None;
            txtDNI.Font = new Font("Consolas", 12F, FontStyle.Bold);
            txtDNI.Location = new Point(578, 84);
            txtDNI.MaxLength = 8;
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(264, 26);
            txtDNI.TabIndex = 29;
            // 
            // txtTelefono
            // 
            txtTelefono.Anchor = AnchorStyles.None;
            txtTelefono.Font = new Font("Consolas", 12F, FontStyle.Bold);
            txtTelefono.Location = new Point(578, 31);
            txtTelefono.MaxLength = 9;
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(264, 26);
            txtTelefono.TabIndex = 28;
            // 
            // txtDireccion
            // 
            txtDireccion.Anchor = AnchorStyles.None;
            txtDireccion.Font = new Font("Consolas", 12F, FontStyle.Bold);
            txtDireccion.Location = new Point(190, 136);
            txtDireccion.MaxLength = 200;
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(244, 26);
            txtDireccion.TabIndex = 27;
            // 
            // txtApPat
            // 
            txtApPat.Anchor = AnchorStyles.None;
            txtApPat.Font = new Font("Consolas", 12F, FontStyle.Bold);
            txtApPat.Location = new Point(190, 84);
            txtApPat.MaxLength = 100;
            txtApPat.Name = "txtApPat";
            txtApPat.Size = new Size(244, 26);
            txtApPat.TabIndex = 26;
            txtApPat.TextChanged += txtApPat_TextChanged;
            // 
            // txtNombres
            // 
            txtNombres.Anchor = AnchorStyles.None;
            txtNombres.Font = new Font("Consolas", 12F, FontStyle.Bold);
            txtNombres.Location = new Point(190, 30);
            txtNombres.MaxLength = 100;
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(244, 26);
            txtNombres.TabIndex = 25;
            // 
            // btnModificar
            // 
            btnModificar.Anchor = AnchorStyles.None;
            btnModificar.BackColor = Color.FromArgb(219, 214, 214);
            btnModificar.Font = new Font("Arial Rounded MT Bold", 12F);
            btnModificar.ForeColor = Color.Black;
            btnModificar.Location = new Point(407, 193);
            btnModificar.Margin = new Padding(4, 3, 4, 3);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(120, 39);
            btnModificar.TabIndex = 24;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click_1;
            // 
            // btnNuevo
            // 
            btnNuevo.Anchor = AnchorStyles.None;
            btnNuevo.BackColor = Color.FromArgb(219, 214, 214);
            btnNuevo.Font = new Font("Arial Rounded MT Bold", 12F);
            btnNuevo.ForeColor = Color.Black;
            btnNuevo.Location = new Point(646, 193);
            btnNuevo.Margin = new Padding(4, 3, 4, 3);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(120, 39);
            btnNuevo.TabIndex = 23;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click_1;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Anchor = AnchorStyles.None;
            btnRegistrar.BackColor = Color.FromArgb(219, 214, 214);
            btnRegistrar.Font = new Font("Arial Rounded MT Bold", 12F);
            btnRegistrar.ForeColor = Color.Black;
            btnRegistrar.Location = new Point(171, 193);
            btnRegistrar.Margin = new Padding(4, 3, 4, 3);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(120, 39);
            btnRegistrar.TabIndex = 22;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click_1;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 15F);
            label6.Location = new Point(514, 84);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(57, 23);
            label6.TabIndex = 21;
            label6.Text = "DNI :";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 15F);
            label5.Location = new Point(470, 31);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(106, 23);
            label5.TabIndex = 20;
            label5.Text = "Teléfono :";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 15F);
            label4.Location = new Point(72, 139);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(115, 23);
            label4.TabIndex = 19;
            label4.Text = "Dirección :";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 15F);
            label3.Location = new Point(72, 84);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(111, 23);
            label3.TabIndex = 18;
            label3.Text = "Apellidos :";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 15F);
            label2.Location = new Point(72, 31);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(111, 23);
            label2.TabIndex = 17;
            label2.Text = "Nombres :";
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(0, 88, 255);
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Verdana", 19.8000011F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(5, 10);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(913, 62);
            label1.TabIndex = 16;
            label1.Text = "MANTENIMIENTO DE PACIENTES";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtDNI);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtTelefono);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtDireccion);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtApPat);
            panel1.Controls.Add(btnRegistrar);
            panel1.Controls.Add(txtNombres);
            panel1.Controls.Add(btnNuevo);
            panel1.Controls.Add(btnModificar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(5, 72);
            panel1.Name = "panel1";
            panel1.Size = new Size(913, 268);
            panel1.TabIndex = 32;
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvPacientes);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(5, 340);
            panel2.Name = "panel2";
            panel2.Size = new Size(913, 265);
            panel2.TabIndex = 33;
            // 
            // MantenimientoPaciente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(923, 629);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "MantenimientoPaciente";
            Padding = new Padding(5, 10, 5, 0);
            Text = "ManteniminentoPaciente";
            ((System.ComponentModel.ISupportInitialize)dgvPacientes).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvPacientes;
        private GroupBox groupBox1;
        private Button btnBuscar;
        private TextBox txtBuscarDNI;
        private TextBox txtDNI;
        private TextBox txtTelefono;
        private TextBox txtDireccion;
        private TextBox txtApPat;
        private TextBox txtNombres;
        private Button btnModificar;
        private Button btnNuevo;
        private Button btnRegistrar;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private Panel panel2;
    }
}