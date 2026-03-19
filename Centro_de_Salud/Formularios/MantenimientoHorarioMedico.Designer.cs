namespace CapaPresentacion.Formularios
{
    partial class MantenimientoHorarioMedico
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
            gbxHorario = new GroupBox();
            dtpHoraFin = new DateTimePicker();
            dtpHoraInicio = new DateTimePicker();
            label8 = new Label();
            label7 = new Label();
            cklDias = new CheckedListBox();
            btnNuevo = new Button();
            btnModificarHorario = new Button();
            btnGuardarHorario = new Button();
            dgvHorarioMedicos = new DataGridView();
            btnAtras = new Button();
            gbxHorario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHorarioMedicos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(143, 225, 151);
            label1.Font = new Font("Verdana", 20F, FontStyle.Bold);
            label1.Location = new Point(44, 9);
            label1.Name = "label1";
            label1.Size = new Size(895, 48);
            label1.TabIndex = 35;
            label1.Text = "MANTENIMIENTO DE HORARIO MEDICOS";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gbxHorario
            // 
            gbxHorario.Controls.Add(dtpHoraFin);
            gbxHorario.Controls.Add(dtpHoraInicio);
            gbxHorario.Controls.Add(label8);
            gbxHorario.Controls.Add(label7);
            gbxHorario.Controls.Add(cklDias);
            gbxHorario.Font = new Font("Arial Rounded MT Bold", 15F);
            gbxHorario.Location = new Point(27, 75);
            gbxHorario.Margin = new Padding(3, 2, 3, 2);
            gbxHorario.Name = "gbxHorario";
            gbxHorario.Padding = new Padding(3, 2, 3, 2);
            gbxHorario.Size = new Size(379, 225);
            gbxHorario.TabIndex = 36;
            gbxHorario.TabStop = false;
            gbxHorario.Text = "Horario";
            // 
            // dtpHoraFin
            // 
            dtpHoraFin.CustomFormat = "hh:mm tt";
            dtpHoraFin.Font = new Font("Arial Rounded MT Bold", 15F);
            dtpHoraFin.Format = DateTimePickerFormat.Custom;
            dtpHoraFin.Location = new Point(193, 147);
            dtpHoraFin.Margin = new Padding(3, 2, 3, 2);
            dtpHoraFin.Name = "dtpHoraFin";
            dtpHoraFin.ShowUpDown = true;
            dtpHoraFin.Size = new Size(154, 31);
            dtpHoraFin.TabIndex = 18;
            // 
            // dtpHoraInicio
            // 
            dtpHoraInicio.CustomFormat = "hh:mm tt";
            dtpHoraInicio.Font = new Font("Arial Rounded MT Bold", 15F);
            dtpHoraInicio.Format = DateTimePickerFormat.Custom;
            dtpHoraInicio.Location = new Point(193, 66);
            dtpHoraInicio.Margin = new Padding(3, 2, 3, 2);
            dtpHoraInicio.Name = "dtpHoraInicio";
            dtpHoraInicio.ShowUpDown = true;
            dtpHoraInicio.Size = new Size(154, 31);
            dtpHoraInicio.TabIndex = 17;
            dtpHoraInicio.Value = new DateTime(2026, 1, 14, 1, 59, 0, 0);
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Rounded MT Bold", 15F);
            label8.Location = new Point(193, 120);
            label8.Name = "label8";
            label8.Size = new Size(87, 23);
            label8.TabIndex = 16;
            label8.Text = "Hora fin";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Rounded MT Bold", 15F);
            label7.Location = new Point(193, 38);
            label7.Name = "label7";
            label7.Size = new Size(114, 23);
            label7.TabIndex = 15;
            label7.Text = "Hora inicio";
            // 
            // cklDias
            // 
            cklDias.BackColor = Color.White;
            cklDias.Font = new Font("Arial Rounded MT Bold", 15F);
            cklDias.FormattingEnabled = true;
            cklDias.Items.AddRange(new object[] { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado", "Domingo" });
            cklDias.Location = new Point(16, 33);
            cklDias.Margin = new Padding(3, 2, 3, 2);
            cklDias.Name = "cklDias";
            cklDias.Size = new Size(131, 179);
            cklDias.TabIndex = 13;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = Color.FromArgb(219, 214, 214);
            btnNuevo.Font = new Font("Arial Rounded MT Bold", 12F);
            btnNuevo.ForeColor = Color.Black;
            btnNuevo.Image = Properties.Resources.nuevo;
            btnNuevo.ImageAlign = ContentAlignment.MiddleRight;
            btnNuevo.Location = new Point(293, 313);
            btnNuevo.Margin = new Padding(3, 2, 3, 2);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(113, 36);
            btnNuevo.TabIndex = 20;
            btnNuevo.Text = "Nuevo";
            btnNuevo.TextAlign = ContentAlignment.MiddleLeft;
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnModificarHorario
            // 
            btnModificarHorario.BackColor = Color.FromArgb(219, 214, 214);
            btnModificarHorario.Font = new Font("Arial Rounded MT Bold", 12F);
            btnModificarHorario.ForeColor = Color.Black;
            btnModificarHorario.Image = Properties.Resources.modificar;
            btnModificarHorario.ImageAlign = ContentAlignment.MiddleRight;
            btnModificarHorario.Location = new Point(163, 313);
            btnModificarHorario.Margin = new Padding(3, 2, 3, 2);
            btnModificarHorario.Name = "btnModificarHorario";
            btnModificarHorario.Size = new Size(113, 36);
            btnModificarHorario.TabIndex = 18;
            btnModificarHorario.Text = "Cambiar";
            btnModificarHorario.TextAlign = ContentAlignment.MiddleLeft;
            btnModificarHorario.UseVisualStyleBackColor = false;
            btnModificarHorario.Click += btnModificarHorario_Click;
            // 
            // btnGuardarHorario
            // 
            btnGuardarHorario.BackColor = Color.FromArgb(219, 214, 214);
            btnGuardarHorario.Font = new Font("Arial Rounded MT Bold", 12F);
            btnGuardarHorario.ForeColor = Color.Black;
            btnGuardarHorario.Image = Properties.Resources.guardar;
            btnGuardarHorario.ImageAlign = ContentAlignment.MiddleRight;
            btnGuardarHorario.Location = new Point(27, 313);
            btnGuardarHorario.Margin = new Padding(3, 2, 3, 2);
            btnGuardarHorario.Name = "btnGuardarHorario";
            btnGuardarHorario.Size = new Size(113, 36);
            btnGuardarHorario.TabIndex = 19;
            btnGuardarHorario.Text = "Guardar";
            btnGuardarHorario.TextAlign = ContentAlignment.MiddleLeft;
            btnGuardarHorario.UseVisualStyleBackColor = false;
            btnGuardarHorario.Click += btnGuardarHorario_Click;
            // 
            // dgvHorarioMedicos
            // 
            dgvHorarioMedicos.BackgroundColor = Color.White;
            dgvHorarioMedicos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHorarioMedicos.Location = new Point(427, 87);
            dgvHorarioMedicos.Name = "dgvHorarioMedicos";
            dgvHorarioMedicos.ReadOnly = true;
            dgvHorarioMedicos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHorarioMedicos.Size = new Size(538, 213);
            dgvHorarioMedicos.TabIndex = 37;
            // 
            // btnAtras
            // 
            btnAtras.BackColor = Color.FromArgb(255, 128, 128);
            btnAtras.Font = new Font("Arial Rounded MT Bold", 12F);
            btnAtras.ForeColor = Color.White;
            btnAtras.Location = new Point(870, 313);
            btnAtras.Margin = new Padding(3, 2, 3, 2);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(95, 36);
            btnAtras.TabIndex = 20;
            btnAtras.Text = "Atras";
            btnAtras.UseVisualStyleBackColor = false;
            btnAtras.Click += btnAtras_Click;
            // 
            // MantenimientoHorarioMedico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(143, 225, 151);
            ClientSize = new Size(996, 389);
            Controls.Add(btnNuevo);
            Controls.Add(btnAtras);
            Controls.Add(btnModificarHorario);
            Controls.Add(dgvHorarioMedicos);
            Controls.Add(btnGuardarHorario);
            Controls.Add(label1);
            Controls.Add(gbxHorario);
            Name = "MantenimientoHorarioMedico";
            Text = "MantenimientoHorarioMedico";
            gbxHorario.ResumeLayout(false);
            gbxHorario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHorarioMedicos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private GroupBox gbxHorario;
        private Button btnModificarHorario;
        private Button btnGuardarHorario;
        private DateTimePicker dtpHoraFin;
        private DateTimePicker dtpHoraInicio;
        private Label label8;
        private Label label7;
        private CheckedListBox cklDias;
        private DataGridView dgvHorarioMedicos;
        private Button btnAtras;
        private Button btnNuevo;
    }
}