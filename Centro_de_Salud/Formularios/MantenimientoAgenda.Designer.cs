namespace CapaPresentacion.Formularios
{
    partial class MantenimientoAgenda
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
            btnNuevo = new Button();
            btnModificar = new Button();
            btnGuardar = new Button();
            cbespecialidad = new ComboBox();
            label4 = new Label();
            txtcupo = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgvAgenda = new DataGridView();
            dtfecha = new DateTimePicker();
            gboDatos = new GroupBox();
            dgvHorario = new DataGridView();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvAgenda).BeginInit();
            gboDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHorario).BeginInit();
            SuspendLayout();
            // 
            // btnNuevo
            // 
            btnNuevo.Anchor = AnchorStyles.None;
            btnNuevo.BackColor = Color.FromArgb(219, 214, 214);
            btnNuevo.Font = new Font("Arial Rounded MT Bold", 12F);
            btnNuevo.ForeColor = Color.Black;
            btnNuevo.Image = Properties.Resources.nuevo;
            btnNuevo.ImageAlign = ContentAlignment.MiddleRight;
            btnNuevo.Location = new Point(416, 213);
            btnNuevo.Margin = new Padding(3, 2, 3, 2);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(116, 44);
            btnNuevo.TabIndex = 28;
            btnNuevo.Text = "Nuevo";
            btnNuevo.TextAlign = ContentAlignment.MiddleLeft;
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnModificar
            // 
            btnModificar.Anchor = AnchorStyles.None;
            btnModificar.BackColor = Color.FromArgb(219, 214, 214);
            btnModificar.Enabled = false;
            btnModificar.Font = new Font("Arial Rounded MT Bold", 12F);
            btnModificar.ForeColor = Color.Black;
            btnModificar.Image = Properties.Resources.modificar;
            btnModificar.ImageAlign = ContentAlignment.MiddleRight;
            btnModificar.Location = new Point(255, 213);
            btnModificar.Margin = new Padding(3, 2, 3, 2);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(116, 44);
            btnModificar.TabIndex = 29;
            btnModificar.Text = "Modificar";
            btnModificar.TextAlign = ContentAlignment.MiddleLeft;
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.None;
            btnGuardar.BackColor = Color.FromArgb(219, 214, 214);
            btnGuardar.Enabled = false;
            btnGuardar.Font = new Font("Arial Rounded MT Bold", 12F);
            btnGuardar.ForeColor = Color.Black;
            btnGuardar.Image = Properties.Resources.guardar;
            btnGuardar.ImageAlign = ContentAlignment.MiddleRight;
            btnGuardar.Location = new Point(73, 213);
            btnGuardar.Margin = new Padding(3, 2, 3, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(122, 44);
            btnGuardar.TabIndex = 27;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextAlign = ContentAlignment.MiddleLeft;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // cbespecialidad
            // 
            cbespecialidad.Anchor = AnchorStyles.None;
            cbespecialidad.DropDownStyle = ComboBoxStyle.DropDownList;
            cbespecialidad.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbespecialidad.FormattingEnabled = true;
            cbespecialidad.Location = new Point(199, 20);
            cbespecialidad.Name = "cbespecialidad";
            cbespecialidad.Size = new Size(339, 28);
            cbespecialidad.TabIndex = 26;
            cbespecialidad.SelectedIndexChanged += cbespecialidad_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label4.Location = new Point(52, 20);
            label4.Name = "label4";
            label4.Size = new Size(130, 25);
            label4.TabIndex = 25;
            label4.Text = "Especialidad :";
            // 
            // txtcupo
            // 
            txtcupo.Anchor = AnchorStyles.None;
            txtcupo.Font = new Font("Consolas", 14F, FontStyle.Bold);
            txtcupo.Location = new Point(485, 72);
            txtcupo.Name = "txtcupo";
            txtcupo.Size = new Size(88, 29);
            txtcupo.TabIndex = 24;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label3.Location = new Point(407, 74);
            label3.Name = "label3";
            label3.Size = new Size(73, 25);
            label3.TabIndex = 23;
            label3.Text = "Cupos:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label2.Location = new Point(19, 72);
            label2.Name = "label2";
            label2.Size = new Size(72, 25);
            label2.TabIndex = 22;
            label2.Text = "Fecha :";
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(0, 88, 255);
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Verdana", 20F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(5, 10);
            label1.Name = "label1";
            label1.Size = new Size(1100, 51);
            label1.TabIndex = 21;
            label1.Text = "AGENDA MEDICA";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvAgenda
            // 
            dgvAgenda.BackgroundColor = Color.White;
            dgvAgenda.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAgenda.Location = new Point(14, 262);
            dgvAgenda.Name = "dgvAgenda";
            dgvAgenda.ReadOnly = true;
            dgvAgenda.RowHeadersWidth = 51;
            dgvAgenda.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAgenda.Size = new Size(596, 229);
            dgvAgenda.TabIndex = 20;
            dgvAgenda.CellContentClick += dgvAgenda_CellContentClick;
            // 
            // dtfecha
            // 
            dtfecha.Anchor = AnchorStyles.None;
            dtfecha.Font = new Font("Consolas", 14F, FontStyle.Bold);
            dtfecha.Location = new Point(99, 72);
            dtfecha.Name = "dtfecha";
            dtfecha.Size = new Size(282, 29);
            dtfecha.TabIndex = 19;
            dtfecha.ValueChanged += dtfecha_ValueChanged;
            // 
            // gboDatos
            // 
            gboDatos.Controls.Add(label4);
            gboDatos.Controls.Add(dtfecha);
            gboDatos.Controls.Add(label2);
            gboDatos.Controls.Add(label3);
            gboDatos.Controls.Add(cbespecialidad);
            gboDatos.Controls.Add(txtcupo);
            gboDatos.Enabled = false;
            gboDatos.Location = new Point(21, 75);
            gboDatos.Name = "gboDatos";
            gboDatos.Size = new Size(589, 133);
            gboDatos.TabIndex = 30;
            gboDatos.TabStop = false;
            gboDatos.Text = "Agenda Médica";
            // 
            // dgvHorario
            // 
            dgvHorario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHorario.Location = new Point(626, 122);
            dgvHorario.Name = "dgvHorario";
            dgvHorario.ReadOnly = true;
            dgvHorario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHorario.Size = new Size(479, 245);
            dgvHorario.TabIndex = 31;
            dgvHorario.CellContentClick += dgvHorario_CellContentClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(700, 94);
            label5.Name = "label5";
            label5.Size = new Size(324, 25);
            label5.TabIndex = 32;
            label5.Text = "Horario de los Médicos disponibles";
            // 
            // MantenimientoAgenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1110, 553);
            Controls.Add(label5);
            Controls.Add(dgvHorario);
            Controls.Add(gboDatos);
            Controls.Add(btnNuevo);
            Controls.Add(label1);
            Controls.Add(dgvAgenda);
            Controls.Add(btnModificar);
            Controls.Add(btnGuardar);
            Name = "MantenimientoAgenda";
            Padding = new Padding(5, 10, 5, 0);
            Text = "MantenimientoAgenda";
            ((System.ComponentModel.ISupportInitialize)dgvAgenda).EndInit();
            gboDatos.ResumeLayout(false);
            gboDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHorario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNuevo;
        private Button btnModificar;
        private Button btnGuardar;
        private ComboBox cbespecialidad;
        private Label label4;
        private TextBox txtcupo;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dgvAgenda;
        private DateTimePicker dtfecha;
        private GroupBox gboDatos;
        private DataGridView dgvHorario;
        private Label label5;
    }
}