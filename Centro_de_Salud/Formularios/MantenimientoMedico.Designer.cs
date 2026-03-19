namespace CapaPresentacion.Formularios
{
    partial class Mantenimiento_Medico
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
            dgvMedicos = new DataGridView();
            btnRegistrar = new Button();
            btnHorarioDisponibles = new Button();
            btnModificar = new Button();
            btnNuevo = new Button();
            label1 = new Label();
            gbxDatos = new GroupBox();
            txtApellidoMaterno = new TextBox();
            label6 = new Label();
            txtApellidoPaterno = new TextBox();
            txtCMP = new TextBox();
            cmbEspecialidad = new ComboBox();
            chkEstado = new CheckBox();
            txtNombres = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvMedicos).BeginInit();
            gbxDatos.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvMedicos
            // 
            dgvMedicos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMedicos.BackgroundColor = Color.White;
            dgvMedicos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMedicos.Dock = DockStyle.Fill;
            dgvMedicos.Location = new Point(0, 0);
            dgvMedicos.Margin = new Padding(3, 2, 3, 2);
            dgvMedicos.Name = "dgvMedicos";
            dgvMedicos.ReadOnly = true;
            dgvMedicos.RowHeadersWidth = 51;
            dgvMedicos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMedicos.Size = new Size(880, 263);
            dgvMedicos.TabIndex = 41;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Anchor = AnchorStyles.None;
            btnRegistrar.BackColor = Color.FromArgb(219, 214, 214);
            btnRegistrar.Font = new Font("Arial Rounded MT Bold", 12F);
            btnRegistrar.ForeColor = Color.Black;
            btnRegistrar.Image = Properties.Resources.guardar;
            btnRegistrar.ImageAlign = ContentAlignment.MiddleRight;
            btnRegistrar.Location = new Point(641, 38);
            btnRegistrar.Margin = new Padding(3, 2, 3, 2);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(119, 39);
            btnRegistrar.TabIndex = 40;
            btnRegistrar.Text = "Guardar";
            btnRegistrar.TextAlign = ContentAlignment.MiddleLeft;
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click_1;
            // 
            // btnHorarioDisponibles
            // 
            btnHorarioDisponibles.Anchor = AnchorStyles.None;
            btnHorarioDisponibles.BackColor = Color.FromArgb(219, 214, 214);
            btnHorarioDisponibles.Font = new Font("Arial Rounded MT Bold", 12F);
            btnHorarioDisponibles.ForeColor = Color.Black;
            btnHorarioDisponibles.ImageAlign = ContentAlignment.MiddleRight;
            btnHorarioDisponibles.Location = new Point(641, 220);
            btnHorarioDisponibles.Margin = new Padding(3, 2, 3, 2);
            btnHorarioDisponibles.Name = "btnHorarioDisponibles";
            btnHorarioDisponibles.Size = new Size(119, 37);
            btnHorarioDisponibles.TabIndex = 39;
            btnHorarioDisponibles.Text = "Horarios";
            btnHorarioDisponibles.TextAlign = ContentAlignment.MiddleLeft;
            btnHorarioDisponibles.UseVisualStyleBackColor = false;
            btnHorarioDisponibles.Click += btnHorarioDisponibles_Click;
            // 
            // btnModificar
            // 
            btnModificar.Anchor = AnchorStyles.None;
            btnModificar.BackColor = Color.FromArgb(219, 214, 214);
            btnModificar.Font = new Font("Arial Rounded MT Bold", 12F);
            btnModificar.ForeColor = Color.Black;
            btnModificar.Image = Properties.Resources.modificar;
            btnModificar.ImageAlign = ContentAlignment.MiddleRight;
            btnModificar.Location = new Point(641, 155);
            btnModificar.Margin = new Padding(3, 2, 3, 2);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(119, 38);
            btnModificar.TabIndex = 38;
            btnModificar.Text = "Modificar";
            btnModificar.TextAlign = ContentAlignment.MiddleLeft;
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click_1;
            // 
            // btnNuevo
            // 
            btnNuevo.Anchor = AnchorStyles.None;
            btnNuevo.BackColor = Color.FromArgb(219, 214, 214);
            btnNuevo.Font = new Font("Arial Rounded MT Bold", 12F);
            btnNuevo.ForeColor = Color.Black;
            btnNuevo.Image = Properties.Resources.nuevo;
            btnNuevo.ImageAlign = ContentAlignment.MiddleRight;
            btnNuevo.Location = new Point(641, 96);
            btnNuevo.Margin = new Padding(3, 2, 3, 2);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(119, 39);
            btnNuevo.TabIndex = 37;
            btnNuevo.Text = "Nuevo";
            btnNuevo.TextAlign = ContentAlignment.MiddleLeft;
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(0, 88, 255);
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Verdana", 19.8000011F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(5, 10);
            label1.Name = "label1";
            label1.Size = new Size(880, 48);
            label1.TabIndex = 36;
            label1.Text = "MANTENIMIENTO  DE MEDICOS";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gbxDatos
            // 
            gbxDatos.Anchor = AnchorStyles.None;
            gbxDatos.Controls.Add(txtApellidoMaterno);
            gbxDatos.Controls.Add(label6);
            gbxDatos.Controls.Add(txtApellidoPaterno);
            gbxDatos.Controls.Add(txtCMP);
            gbxDatos.Controls.Add(cmbEspecialidad);
            gbxDatos.Controls.Add(chkEstado);
            gbxDatos.Controls.Add(txtNombres);
            gbxDatos.Controls.Add(label5);
            gbxDatos.Controls.Add(label4);
            gbxDatos.Controls.Add(label3);
            gbxDatos.Controls.Add(label2);
            gbxDatos.Font = new Font("Arial Rounded MT Bold", 15F);
            gbxDatos.Location = new Point(121, 19);
            gbxDatos.Margin = new Padding(3, 2, 3, 2);
            gbxDatos.Name = "gbxDatos";
            gbxDatos.Padding = new Padding(3, 2, 3, 2);
            gbxDatos.Size = new Size(455, 259);
            gbxDatos.TabIndex = 43;
            gbxDatos.TabStop = false;
            gbxDatos.Text = "Datos";
            // 
            // txtApellidoMaterno
            // 
            txtApellidoMaterno.Font = new Font("Consolas", 12F, FontStyle.Bold);
            txtApellidoMaterno.Location = new Point(171, 103);
            txtApellidoMaterno.Margin = new Padding(3, 2, 3, 2);
            txtApellidoMaterno.MaxLength = 100;
            txtApellidoMaterno.Name = "txtApellidoMaterno";
            txtApellidoMaterno.Size = new Size(268, 26);
            txtApellidoMaterno.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 15F);
            label6.Location = new Point(34, 69);
            label6.Name = "label6";
            label6.Size = new Size(125, 23);
            label6.TabIndex = 13;
            label6.Text = "Ap Paterno:";
            // 
            // txtApellidoPaterno
            // 
            txtApellidoPaterno.Font = new Font("Consolas", 12F, FontStyle.Bold);
            txtApellidoPaterno.Location = new Point(171, 69);
            txtApellidoPaterno.Margin = new Padding(3, 2, 3, 2);
            txtApellidoPaterno.MaxLength = 100;
            txtApellidoPaterno.Name = "txtApellidoPaterno";
            txtApellidoPaterno.Size = new Size(268, 26);
            txtApellidoPaterno.TabIndex = 12;
            // 
            // txtCMP
            // 
            txtCMP.Font = new Font("Consolas", 12F, FontStyle.Bold);
            txtCMP.Location = new Point(171, 140);
            txtCMP.Margin = new Padding(3, 2, 3, 2);
            txtCMP.MaxLength = 10;
            txtCMP.Name = "txtCMP";
            txtCMP.Size = new Size(268, 26);
            txtCMP.TabIndex = 11;
            // 
            // cmbEspecialidad
            // 
            cmbEspecialidad.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEspecialidad.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbEspecialidad.FormattingEnabled = true;
            cmbEspecialidad.Location = new Point(171, 178);
            cmbEspecialidad.Margin = new Padding(3, 2, 3, 2);
            cmbEspecialidad.Name = "cmbEspecialidad";
            cmbEspecialidad.Size = new Size(268, 27);
            cmbEspecialidad.TabIndex = 10;
            // 
            // chkEstado
            // 
            chkEstado.AutoSize = true;
            chkEstado.Font = new Font("Arial Rounded MT Bold", 15F);
            chkEstado.Location = new Point(171, 219);
            chkEstado.Margin = new Padding(3, 2, 3, 2);
            chkEstado.Name = "chkEstado";
            chkEstado.Size = new Size(90, 27);
            chkEstado.TabIndex = 9;
            chkEstado.Text = "Activo";
            chkEstado.UseVisualStyleBackColor = true;
            // 
            // txtNombres
            // 
            txtNombres.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNombres.Location = new Point(171, 34);
            txtNombres.Margin = new Padding(3, 2, 3, 2);
            txtNombres.MaxLength = 100;
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(268, 26);
            txtNombres.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 15F);
            label5.Location = new Point(10, 180);
            label5.Name = "label5";
            label5.Size = new Size(147, 23);
            label5.TabIndex = 4;
            label5.Text = "Especialidad :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 15F);
            label4.Location = new Point(75, 141);
            label4.Name = "label4";
            label4.Size = new Size(66, 23);
            label4.TabIndex = 3;
            label4.Text = "CMP :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 15F);
            label3.Location = new Point(29, 107);
            label3.Name = "label3";
            label3.Size = new Size(129, 23);
            label3.TabIndex = 2;
            label3.Text = "Ap Materno:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 15F);
            label2.Location = new Point(45, 35);
            label2.Name = "label2";
            label2.Size = new Size(111, 23);
            label2.TabIndex = 1;
            label2.Text = "Nombres :";
            // 
            // panel1
            // 
            panel1.Controls.Add(gbxDatos);
            panel1.Controls.Add(btnRegistrar);
            panel1.Controls.Add(btnNuevo);
            panel1.Controls.Add(btnHorarioDisponibles);
            panel1.Controls.Add(btnModificar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(5, 58);
            panel1.Name = "panel1";
            panel1.Size = new Size(880, 304);
            panel1.TabIndex = 44;
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvMedicos);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(5, 362);
            panel2.Name = "panel2";
            panel2.Size = new Size(880, 263);
            panel2.TabIndex = 45;
            // 
            // Mantenimiento_Medico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(890, 562);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "Mantenimiento_Medico";
            Padding = new Padding(5, 10, 5, 0);
            Text = "Mantenimiento_Medico";
            ((System.ComponentModel.ISupportInitialize)dgvMedicos).EndInit();
            gbxDatos.ResumeLayout(false);
            gbxDatos.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgvMedicos;
        private Button btnRegistrar;
        private Button btnHorarioDisponibles;
        private Button btnModificar;
        private Button btnNuevo;
        private Label label1;
        private GroupBox gbxDatos;
        private TextBox txtApellidoMaterno;
        private Label label6;
        private TextBox txtApellidoPaterno;
        private TextBox txtCMP;
        private ComboBox cmbEspecialidad;
        private CheckBox chkEstado;
        private TextBox txtNombres;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Panel panel1;
        private Panel panel2;
    }
}