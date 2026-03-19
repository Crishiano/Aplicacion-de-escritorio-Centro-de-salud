namespace CapaPresentacion.Formularios
{
    partial class MantenimientoCita
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
            gboDatos = new GroupBox();
            cboAgenda = new ComboBox();
            label11 = new Label();
            cboMedico = new ComboBox();
            label10 = new Label();
            cboEspecialidad = new ComboBox();
            label9 = new Label();
            txtMotivo = new TextBox();
            label8 = new Label();
            dtpFecha = new DateTimePicker();
            label12 = new Label();
            btnBuscarDNI = new Button();
            txtDNI = new TextBox();
            label7 = new Label();
            txtIdUsuario = new TextBox();
            label6 = new Label();
            cboEstado = new ComboBox();
            label5 = new Label();
            dtpHora = new DateTimePicker();
            label4 = new Label();
            txtIdAgenda = new TextBox();
            label3 = new Label();
            txtPaciente = new TextBox();
            label2 = new Label();
            btnRegistrar = new Button();
            btnModificar = new Button();
            btnNuevo = new Button();
            groupBox2 = new GroupBox();
            dgvCitas = new DataGridView();
            btnCerrar = new Button();
            gboDatos.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCitas).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(143, 225, 151);
            label1.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(18, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(840, 62);
            label1.TabIndex = 0;
            label1.Text = "MANTENIMIENTO DE CITAS MÉDICAS";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gboDatos
            // 
            gboDatos.BackColor = Color.White;
            gboDatos.Controls.Add(cboAgenda);
            gboDatos.Controls.Add(label11);
            gboDatos.Controls.Add(cboMedico);
            gboDatos.Controls.Add(label10);
            gboDatos.Controls.Add(cboEspecialidad);
            gboDatos.Controls.Add(label9);
            gboDatos.Controls.Add(txtMotivo);
            gboDatos.Controls.Add(label8);
            gboDatos.Controls.Add(dtpFecha);
            gboDatos.Controls.Add(label12);
            gboDatos.Controls.Add(btnBuscarDNI);
            gboDatos.Controls.Add(txtDNI);
            gboDatos.Controls.Add(label7);
            gboDatos.Controls.Add(txtIdUsuario);
            gboDatos.Controls.Add(label6);
            gboDatos.Controls.Add(cboEstado);
            gboDatos.Controls.Add(label5);
            gboDatos.Controls.Add(dtpHora);
            gboDatos.Controls.Add(label4);
            gboDatos.Controls.Add(txtIdAgenda);
            gboDatos.Controls.Add(label3);
            gboDatos.Controls.Add(txtPaciente);
            gboDatos.Controls.Add(label2);
            gboDatos.Enabled = false;
            gboDatos.Font = new Font("Arial Rounded MT Bold", 12F);
            gboDatos.Location = new Point(12, 74);
            gboDatos.Name = "gboDatos";
            gboDatos.Size = new Size(846, 276);
            gboDatos.TabIndex = 1;
            gboDatos.TabStop = false;
            gboDatos.Text = "Datos de la Cita";
            // 
            // cboAgenda
            // 
            cboAgenda.DropDownStyle = ComboBoxStyle.DropDownList;
            cboAgenda.Font = new Font("Consolas", 11F, FontStyle.Bold);
            cboAgenda.FormattingEnabled = true;
            cboAgenda.Location = new Point(523, 120);
            cboAgenda.Name = "cboAgenda";
            cboAgenda.Size = new Size(293, 26);
            cboAgenda.TabIndex = 22;
            cboAgenda.SelectedIndexChanged += cboAgenda_SelectedIndexChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial Rounded MT Bold", 12F);
            label11.Location = new Point(434, 123);
            label11.Name = "label11";
            label11.Size = new Size(79, 18);
            label11.TabIndex = 21;
            label11.Text = "Agenda :";
            // 
            // cboMedico
            // 
            cboMedico.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMedico.Font = new Font("Consolas", 11F, FontStyle.Bold);
            cboMedico.FormattingEnabled = true;
            cboMedico.Location = new Point(523, 82);
            cboMedico.Name = "cboMedico";
            cboMedico.Size = new Size(293, 26);
            cboMedico.TabIndex = 20;
            cboMedico.SelectedIndexChanged += cboMedico_SelectedIndexChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial Rounded MT Bold", 12F);
            label10.Location = new Point(440, 85);
            label10.Name = "label10";
            label10.Size = new Size(74, 18);
            label10.TabIndex = 19;
            label10.Text = "Médico :";
            // 
            // cboEspecialidad
            // 
            cboEspecialidad.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEspecialidad.Font = new Font("Consolas", 11F, FontStyle.Bold);
            cboEspecialidad.FormattingEnabled = true;
            cboEspecialidad.Location = new Point(523, 42);
            cboEspecialidad.Name = "cboEspecialidad";
            cboEspecialidad.Size = new Size(293, 26);
            cboEspecialidad.TabIndex = 18;
            cboEspecialidad.SelectedIndexChanged += cboEspecialidad_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial Rounded MT Bold", 12F);
            label9.Location = new Point(393, 45);
            label9.Name = "label9";
            label9.Size = new Size(119, 18);
            label9.TabIndex = 17;
            label9.Text = "Especialidad :";
            // 
            // txtMotivo
            // 
            txtMotivo.Font = new Font("Consolas", 11F, FontStyle.Bold);
            txtMotivo.Location = new Point(106, 242);
            txtMotivo.Multiline = true;
            txtMotivo.Name = "txtMotivo";
            txtMotivo.Size = new Size(481, 23);
            txtMotivo.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Rounded MT Bold", 12F);
            label8.Location = new Point(22, 247);
            label8.Name = "label8";
            label8.Size = new Size(69, 18);
            label8.TabIndex = 15;
            label8.Text = "Motivo :";
            // 
            // dtpFecha
            // 
            dtpFecha.Enabled = false;
            dtpFecha.Font = new Font("Consolas", 11F, FontStyle.Bold);
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(106, 204);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(244, 25);
            dtpFecha.TabIndex = 14;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial Rounded MT Bold", 12F);
            label12.Location = new Point(24, 207);
            label12.Name = "label12";
            label12.Size = new Size(67, 18);
            label12.TabIndex = 13;
            label12.Text = "Fecha :";
            // 
            // btnBuscarDNI
            // 
            btnBuscarDNI.Location = new Point(277, 38);
            btnBuscarDNI.Name = "btnBuscarDNI";
            btnBuscarDNI.Size = new Size(95, 25);
            btnBuscarDNI.TabIndex = 12;
            btnBuscarDNI.Text = "Buscar";
            btnBuscarDNI.UseVisualStyleBackColor = true;
            btnBuscarDNI.Click += btnBuscarDNI_Click;
            // 
            // txtDNI
            // 
            txtDNI.Font = new Font("Consolas", 11F, FontStyle.Bold);
            txtDNI.Location = new Point(105, 38);
            txtDNI.MaxLength = 8;
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(166, 25);
            txtDNI.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(56, 40);
            label7.Name = "label7";
            label7.Size = new Size(37, 18);
            label7.TabIndex = 10;
            label7.Text = "DNI";
            // 
            // txtIdUsuario
            // 
            txtIdUsuario.Font = new Font("Consolas", 11F, FontStyle.Bold);
            txtIdUsuario.Location = new Point(106, 166);
            txtIdUsuario.Name = "txtIdUsuario";
            txtIdUsuario.Size = new Size(244, 25);
            txtIdUsuario.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 12F);
            label6.Location = new Point(12, 168);
            label6.Name = "label6";
            label6.Size = new Size(79, 18);
            label6.TabIndex = 8;
            label6.Text = "Usuario :";
            // 
            // cboEstado
            // 
            cboEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEstado.Font = new Font("Consolas", 11F, FontStyle.Bold);
            cboEstado.FormattingEnabled = true;
            cboEstado.Location = new Point(523, 205);
            cboEstado.Name = "cboEstado";
            cboEstado.Size = new Size(165, 26);
            cboEstado.TabIndex = 7;
            cboEstado.SelectedIndexChanged += cboEstado_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 12F);
            label5.Location = new Point(444, 211);
            label5.Name = "label5";
            label5.Size = new Size(73, 18);
            label5.TabIndex = 6;
            label5.Text = "Estado :";
            // 
            // dtpHora
            // 
            dtpHora.CustomFormat = "HH:mm";
            dtpHora.Font = new Font("Consolas", 11F, FontStyle.Bold);
            dtpHora.Format = DateTimePickerFormat.Custom;
            dtpHora.Location = new Point(523, 170);
            dtpHora.Name = "dtpHora";
            dtpHora.ShowUpDown = true;
            dtpHora.Size = new Size(87, 25);
            dtpHora.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 12F);
            label4.Location = new Point(461, 173);
            label4.Name = "label4";
            label4.Size = new Size(56, 18);
            label4.TabIndex = 4;
            label4.Text = "Hora :";
            // 
            // txtIdAgenda
            // 
            txtIdAgenda.Enabled = false;
            txtIdAgenda.Font = new Font("Consolas", 11F, FontStyle.Bold);
            txtIdAgenda.Location = new Point(105, 119);
            txtIdAgenda.Name = "txtIdAgenda";
            txtIdAgenda.Size = new Size(227, 25);
            txtIdAgenda.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 12F);
            label3.Location = new Point(6, 121);
            label3.Name = "label3";
            label3.Size = new Size(100, 18);
            label3.TabIndex = 2;
            label3.Text = "ID Agenda :";
            // 
            // txtPaciente
            // 
            txtPaciente.Enabled = false;
            txtPaciente.Font = new Font("Consolas", 11F, FontStyle.Bold);
            txtPaciente.Location = new Point(105, 81);
            txtPaciente.Name = "txtPaciente";
            txtPaciente.Size = new Size(249, 25);
            txtPaciente.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 12F);
            label2.Location = new Point(6, 81);
            label2.Name = "label2";
            label2.Size = new Size(88, 18);
            label2.TabIndex = 0;
            label2.Text = "Paciente :";
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.FromArgb(144, 238, 144);
            btnRegistrar.Enabled = false;
            btnRegistrar.Font = new Font("Arial Rounded MT Bold", 12F);
            btnRegistrar.ForeColor = Color.Black;
            btnRegistrar.Location = new Point(68, 356);
            btnRegistrar.Margin = new Padding(4, 3, 4, 3);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(140, 45);
            btnRegistrar.TabIndex = 2;
            btnRegistrar.Text = "✓ Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.FromArgb(255, 215, 0);
            btnModificar.Enabled = false;
            btnModificar.Font = new Font("Arial Rounded MT Bold", 12F);
            btnModificar.ForeColor = Color.Black;
            btnModificar.Location = new Point(327, 356);
            btnModificar.Margin = new Padding(4, 3, 4, 3);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(140, 45);
            btnModificar.TabIndex = 3;
            btnModificar.Text = "✎ Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = Color.FromArgb(173, 216, 230);
            btnNuevo.Font = new Font("Arial Rounded MT Bold", 12F);
            btnNuevo.ForeColor = Color.Black;
            btnNuevo.Location = new Point(658, 356);
            btnNuevo.Margin = new Padding(4, 3, 4, 3);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(140, 45);
            btnNuevo.TabIndex = 4;
            btnNuevo.Text = "+ Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(dgvCitas);
            groupBox2.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(12, 407);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(846, 295);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "📋 Lista de Citas Registradas";
            // 
            // dgvCitas
            // 
            dgvCitas.AllowUserToAddRows = false;
            dgvCitas.AllowUserToDeleteRows = false;
            dgvCitas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCitas.BackgroundColor = Color.White;
            dgvCitas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCitas.Location = new Point(15, 28);
            dgvCitas.Name = "dgvCitas";
            dgvCitas.ReadOnly = true;
            dgvCitas.RowHeadersWidth = 51;
            dgvCitas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCitas.Size = new Size(801, 235);
            dgvCitas.TabIndex = 0;
            dgvCitas.CellClick += dgvCitas_CellClick;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.FromArgb(255, 128, 128);
            btnCerrar.Font = new Font("Arial Rounded MT Bold", 12F);
            btnCerrar.Location = new Point(1146, 765);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(94, 40);
            btnCerrar.TabIndex = 6;
            btnCerrar.Text = "✖ Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // MantenimientoCita
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(143, 225, 151);
            ClientSize = new Size(890, 749);
            Controls.Add(btnCerrar);
            Controls.Add(groupBox2);
            Controls.Add(btnNuevo);
            Controls.Add(btnModificar);
            Controls.Add(btnRegistrar);
            Controls.Add(gboDatos);
            Controls.Add(label1);
            Name = "MantenimientoCita";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Gestión de Citas Médicas";
            gboDatos.ResumeLayout(false);
            gboDatos.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCitas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private GroupBox gboDatos;
        private Label label2;
        private TextBox txtPaciente;
        private TextBox txtIdAgenda;
        private Label label3;
        private DateTimePicker dtpHora;
        private Label label4;
        private ComboBox cboEstado;
        private Label label5;
        private TextBox txtIdUsuario;
        private Label label6;
        private Button btnRegistrar;
        private Button btnModificar;
        private Button btnNuevo;
        private GroupBox groupBox2;
        private DataGridView dgvCitas;
        private Button btnCerrar;
        private Label label7;
        private Button btnBuscarDNI;
        private TextBox txtDNI;
        private DateTimePicker dtpFecha;
        private Label label12;
        private TextBox txtMotivo;
        private Label label8;
        private ComboBox cboEspecialidad;
        private Label label9;
        private ComboBox cboMedico;
        private Label label10;
        private ComboBox cboAgenda;
        private Label label11;
    }
}