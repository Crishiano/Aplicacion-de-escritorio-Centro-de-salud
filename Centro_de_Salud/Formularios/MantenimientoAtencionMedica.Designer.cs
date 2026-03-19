namespace CapaPresentacion.Formularios
{
    partial class MantenimientoAtencionMedica
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
            groupBox1 = new GroupBox();
            btnBuscar = new Button();
            txtMedico = new TextBox();
            label6 = new Label();
            dtpFechaAtencion = new DateTimePicker();
            label5 = new Label();
            txtObservaciones = new TextBox();
            label4 = new Label();
            txtDiagnostico = new TextBox();
            label3 = new Label();
            txtIdCita = new TextBox();
            label2 = new Label();
            btnRegistrar = new Button();
            btnModificar = new Button();
            btnNuevo = new Button();
            groupBox2 = new GroupBox();
            dgvAtenciones = new DataGridView();
            btnCerrar = new Button();
            btnReceta = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAtenciones).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(143, 225, 151);
            label1.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(-6, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(702, 44);
            label1.TabIndex = 0;
            label1.Text = "MANTENIMIENTO DE ATENCIÓN MÉDICA";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(btnBuscar);
            groupBox1.Controls.Add(txtMedico);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(dtpFechaAtencion);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtObservaciones);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtDiagnostico);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtIdCita);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Arial Rounded MT Bold", 12F);
            groupBox1.Location = new Point(12, 56);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(784, 212);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos de la Atención Médica";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(267, 29);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(99, 28);
            btnBuscar.TabIndex = 12;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtMedico
            // 
            txtMedico.Enabled = false;
            txtMedico.Location = new Point(495, 31);
            txtMedico.Name = "txtMedico";
            txtMedico.Size = new Size(268, 26);
            txtMedico.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(419, 34);
            label6.Name = "label6";
            label6.Size = new Size(70, 18);
            label6.TabIndex = 10;
            label6.Text = "Médico:";
            // 
            // dtpFechaAtencion
            // 
            dtpFechaAtencion.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpFechaAtencion.Font = new Font("Consolas", 12F, FontStyle.Bold);
            dtpFechaAtencion.Format = DateTimePickerFormat.Custom;
            dtpFechaAtencion.Location = new Point(245, 166);
            dtpFechaAtencion.Name = "dtpFechaAtencion";
            dtpFechaAtencion.Size = new Size(244, 26);
            dtpFechaAtencion.TabIndex = 7;
            dtpFechaAtencion.Value = new DateTime(2026, 2, 15, 0, 0, 0, 0);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 12F);
            label5.Location = new Point(63, 169);
            label5.Name = "label5";
            label5.Size = new Size(167, 18);
            label5.TabIndex = 6;
            label5.Text = "Fecha de Atención :";
            // 
            // txtObservaciones
            // 
            txtObservaciones.Font = new Font("Consolas", 12F, FontStyle.Bold);
            txtObservaciones.Location = new Point(245, 112);
            txtObservaciones.MaxLength = 1000;
            txtObservaciones.Multiline = true;
            txtObservaciones.Name = "txtObservaciones";
            txtObservaciones.ScrollBars = ScrollBars.Vertical;
            txtObservaciones.Size = new Size(518, 40);
            txtObservaciones.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 12F);
            label4.Location = new Point(91, 115);
            label4.Name = "label4";
            label4.Size = new Size(138, 18);
            label4.TabIndex = 4;
            label4.Text = "Observaciones :";
            // 
            // txtDiagnostico
            // 
            txtDiagnostico.Font = new Font("Consolas", 12F, FontStyle.Bold);
            txtDiagnostico.Location = new Point(245, 66);
            txtDiagnostico.MaxLength = 500;
            txtDiagnostico.Multiline = true;
            txtDiagnostico.Name = "txtDiagnostico";
            txtDiagnostico.ScrollBars = ScrollBars.Vertical;
            txtDiagnostico.Size = new Size(518, 40);
            txtDiagnostico.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 12F);
            label3.Location = new Point(115, 69);
            label3.Name = "label3";
            label3.Size = new Size(112, 18);
            label3.TabIndex = 2;
            label3.Text = "Diagnóstico :";
            // 
            // txtIdCita
            // 
            txtIdCita.Font = new Font("Consolas", 12F, FontStyle.Bold);
            txtIdCita.Location = new Point(115, 31);
            txtIdCita.Name = "txtIdCita";
            txtIdCita.Size = new Size(142, 26);
            txtIdCita.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 12F);
            label2.Location = new Point(43, 34);
            label2.Name = "label2";
            label2.Size = new Size(70, 18);
            label2.TabIndex = 0;
            label2.Text = "ID Cita :";
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.FromArgb(219, 214, 214);
            btnRegistrar.Font = new Font("Arial Rounded MT Bold", 12F);
            btnRegistrar.ForeColor = Color.Black;
            btnRegistrar.Location = new Point(55, 274);
            btnRegistrar.Margin = new Padding(4, 3, 4, 3);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(120, 39);
            btnRegistrar.TabIndex = 2;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.FromArgb(219, 214, 214);
            btnModificar.Enabled = false;
            btnModificar.Font = new Font("Arial Rounded MT Bold", 12F);
            btnModificar.ForeColor = Color.Black;
            btnModificar.Location = new Point(234, 274);
            btnModificar.Margin = new Padding(4, 3, 4, 3);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(120, 39);
            btnModificar.TabIndex = 3;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = Color.FromArgb(219, 214, 214);
            btnNuevo.Font = new Font("Arial Rounded MT Bold", 12F);
            btnNuevo.ForeColor = Color.Black;
            btnNuevo.Location = new Point(407, 274);
            btnNuevo.Margin = new Padding(4, 3, 4, 3);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(120, 39);
            btnNuevo.TabIndex = 4;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(dgvAtenciones);
            groupBox2.Font = new Font("Arial Rounded MT Bold", 12F);
            groupBox2.Location = new Point(12, 319);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(784, 272);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Lista de Atenciones Médicas";
            // 
            // dgvAtenciones
            // 
            dgvAtenciones.AllowUserToAddRows = false;
            dgvAtenciones.AllowUserToDeleteRows = false;
            dgvAtenciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAtenciones.BackgroundColor = Color.White;
            dgvAtenciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAtenciones.Location = new Point(15, 28);
            dgvAtenciones.Name = "dgvAtenciones";
            dgvAtenciones.ReadOnly = true;
            dgvAtenciones.RowHeadersWidth = 51;
            dgvAtenciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAtenciones.Size = new Size(748, 228);
            dgvAtenciones.TabIndex = 0;
            dgvAtenciones.CellClick += dgvAtenciones_CellClick;
            dgvAtenciones.SelectionChanged += dgvAtenciones_SelectionChanged;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.FromArgb(255, 128, 128);
            btnCerrar.Font = new Font("Arial Rounded MT Bold", 12F);
            btnCerrar.Location = new Point(881, 666);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(94, 36);
            btnCerrar.TabIndex = 6;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnReceta
            // 
            btnReceta.BackColor = Color.FromArgb(219, 214, 214);
            btnReceta.Font = new Font("Arial Rounded MT Bold", 12F);
            btnReceta.ForeColor = Color.Black;
            btnReceta.Location = new Point(586, 274);
            btnReceta.Margin = new Padding(4, 3, 4, 3);
            btnReceta.Name = "btnReceta";
            btnReceta.Size = new Size(156, 39);
            btnReceta.TabIndex = 8;
            btnReceta.Text = "Generar Receta";
            btnReceta.UseVisualStyleBackColor = false;
            btnReceta.Click += btnReceta_Click;
            // 
            // MantenimientoAtencionMedica
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(143, 225, 151);
            ClientSize = new Size(836, 673);
            Controls.Add(btnReceta);
            Controls.Add(btnCerrar);
            Controls.Add(groupBox2);
            Controls.Add(btnNuevo);
            Controls.Add(btnModificar);
            Controls.Add(btnRegistrar);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "MantenimientoAtencionMedica";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mantenimiento de Atención Médica";
            Load += MantenimientoAtencionMedica_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAtenciones).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label2;
        private TextBox txtIdCita;
        private TextBox txtDiagnostico;
        private Label label3;
        private TextBox txtObservaciones;
        private Label label4;
        private DateTimePicker dtpFechaAtencion;
        private Label label5;
        private Button btnRegistrar;
        private Button btnModificar;
        private Button btnNuevo;
        private GroupBox groupBox2;
        private DataGridView dgvAtenciones;
        private Button btnCerrar;
        private TextBox txtMedico;
        private Label label6;
        private Button btnBuscar;
        private Button btnReceta;
    }
}
