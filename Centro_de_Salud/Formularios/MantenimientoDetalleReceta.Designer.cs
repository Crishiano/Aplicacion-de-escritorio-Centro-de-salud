namespace CapaPresentacion.Formularios
{
    partial class MantenimientoDetalleReceta
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
            btnGuardar = new Button();
            btnModificar = new Button();
            label1 = new Label();
            label7 = new Label();
            txtmedicamento = new TextBox();
            btBuscar = new Button();
            dgvDetalles = new DataGridView();
            gbxReceta = new GroupBox();
            txtIndicaciones = new TextBox();
            txtDuracion = new TextBox();
            txtFrecuencia = new TextBox();
            txtDosis = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            cboMedicamento = new ComboBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDetalles).BeginInit();
            gbxReceta.SuspendLayout();
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
            btnNuevo.Location = new Point(278, 162);
            btnNuevo.Margin = new Padding(3, 2, 3, 2);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(116, 38);
            btnNuevo.TabIndex = 22;
            btnNuevo.Text = "Nuevo";
            btnNuevo.TextAlign = ContentAlignment.MiddleLeft;
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.None;
            btnGuardar.BackColor = Color.FromArgb(219, 214, 214);
            btnGuardar.Font = new Font("Arial Rounded MT Bold", 12F);
            btnGuardar.ForeColor = Color.Black;
            btnGuardar.Image = Properties.Resources.guardar;
            btnGuardar.ImageAlign = ContentAlignment.MiddleRight;
            btnGuardar.Location = new Point(142, 162);
            btnGuardar.Margin = new Padding(3, 2, 3, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(116, 38);
            btnGuardar.TabIndex = 23;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextAlign = ContentAlignment.MiddleLeft;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Anchor = AnchorStyles.None;
            btnModificar.BackColor = Color.FromArgb(219, 214, 214);
            btnModificar.Font = new Font("Arial Rounded MT Bold", 12F);
            btnModificar.ForeColor = Color.Black;
            btnModificar.Image = Properties.Resources.modificar;
            btnModificar.ImageAlign = ContentAlignment.MiddleRight;
            btnModificar.Location = new Point(400, 162);
            btnModificar.Margin = new Padding(3, 2, 3, 2);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(116, 38);
            btnModificar.TabIndex = 21;
            btnModificar.Text = "Modificar";
            btnModificar.TextAlign = ContentAlignment.MiddleLeft;
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(143, 225, 151);
            label1.Font = new Font("Verdana", 19.8000011F, FontStyle.Bold);
            label1.Location = new Point(13, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(677, 62);
            label1.TabIndex = 24;
            label1.Text = "MANTENIMIENTO DETALLE";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label7.Location = new Point(92, 90);
            label7.Name = "label7";
            label7.Size = new Size(109, 20);
            label7.TabIndex = 27;
            label7.Text = "Medicamento:";
            // 
            // txtmedicamento
            // 
            txtmedicamento.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            txtmedicamento.Location = new Point(207, 87);
            txtmedicamento.Name = "txtmedicamento";
            txtmedicamento.Size = new Size(191, 27);
            txtmedicamento.TabIndex = 26;
            // 
            // btBuscar
            // 
            btBuscar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btBuscar.Location = new Point(407, 88);
            btBuscar.Name = "btBuscar";
            btBuscar.Size = new Size(74, 27);
            btBuscar.TabIndex = 25;
            btBuscar.Text = "Buscar";
            btBuscar.UseVisualStyleBackColor = true;
            btBuscar.Click += btBuscar_Click;
            // 
            // dgvDetalles
            // 
            dgvDetalles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalles.Location = new Point(13, 400);
            dgvDetalles.Name = "dgvDetalles";
            dgvDetalles.ReadOnly = true;
            dgvDetalles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDetalles.Size = new Size(677, 205);
            dgvDetalles.TabIndex = 29;
            // 
            // gbxReceta
            // 
            gbxReceta.Controls.Add(txtIndicaciones);
            gbxReceta.Controls.Add(txtDuracion);
            gbxReceta.Controls.Add(txtFrecuencia);
            gbxReceta.Controls.Add(txtDosis);
            gbxReceta.Controls.Add(label6);
            gbxReceta.Controls.Add(label5);
            gbxReceta.Controls.Add(label4);
            gbxReceta.Controls.Add(btnNuevo);
            gbxReceta.Controls.Add(btnGuardar);
            gbxReceta.Controls.Add(label3);
            gbxReceta.Controls.Add(btnModificar);
            gbxReceta.Controls.Add(cboMedicamento);
            gbxReceta.Controls.Add(label2);
            gbxReceta.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbxReceta.Location = new Point(13, 147);
            gbxReceta.Name = "gbxReceta";
            gbxReceta.Size = new Size(677, 216);
            gbxReceta.TabIndex = 30;
            gbxReceta.TabStop = false;
            gbxReceta.Text = "Datos Detalle";
            // 
            // txtIndicaciones
            // 
            txtIndicaciones.Location = new Point(438, 73);
            txtIndicaciones.Name = "txtIndicaciones";
            txtIndicaciones.Size = new Size(219, 27);
            txtIndicaciones.TabIndex = 17;
            // 
            // txtDuracion
            // 
            txtDuracion.Location = new Point(438, 32);
            txtDuracion.Name = "txtDuracion";
            txtDuracion.Size = new Size(182, 27);
            txtDuracion.TabIndex = 16;
            // 
            // txtFrecuencia
            // 
            txtFrecuencia.Location = new Point(139, 120);
            txtFrecuencia.Name = "txtFrecuencia";
            txtFrecuencia.Size = new Size(182, 27);
            txtFrecuencia.TabIndex = 15;
            // 
            // txtDosis
            // 
            txtDosis.Location = new Point(136, 77);
            txtDosis.Name = "txtDosis";
            txtDosis.Size = new Size(182, 27);
            txtDosis.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(336, 76);
            label6.Name = "label6";
            label6.Size = new Size(99, 20);
            label6.TabIndex = 13;
            label6.Text = "Indicaciones:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(359, 35);
            label5.Name = "label5";
            label5.Size = new Size(76, 20);
            label5.TabIndex = 12;
            label5.Text = "Duracion:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(48, 123);
            label4.Name = "label4";
            label4.Size = new Size(87, 20);
            label4.TabIndex = 11;
            label4.Text = "Frecuencia:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(84, 80);
            label3.Name = "label3";
            label3.Size = new Size(51, 20);
            label3.TabIndex = 10;
            label3.Text = "Dosis:";
            // 
            // cboMedicamento
            // 
            cboMedicamento.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMedicamento.FormattingEnabled = true;
            cboMedicamento.Location = new Point(136, 36);
            cboMedicamento.Name = "cboMedicamento";
            cboMedicamento.Size = new Size(182, 28);
            cboMedicamento.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 39);
            label2.Name = "label2";
            label2.Size = new Size(109, 20);
            label2.TabIndex = 2;
            label2.Text = "Medicamento:";
            // 
            // MantenimientoDetalleReceta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(714, 617);
            Controls.Add(gbxReceta);
            Controls.Add(dgvDetalles);
            Controls.Add(label7);
            Controls.Add(txtmedicamento);
            Controls.Add(btBuscar);
            Controls.Add(label1);
            Name = "MantenimientoDetalleReceta";
            Text = "MantenimientoDetalleReceta";
            ((System.ComponentModel.ISupportInitialize)dgvDetalles).EndInit();
            gbxReceta.ResumeLayout(false);
            gbxReceta.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNuevo;
        private Button btnGuardar;
        private Button btnModificar;
        private Label label1;
        private Label label7;
        private TextBox txtmedicamento;
        private Button btBuscar;
        private DataGridView dgvDetalles;
        private GroupBox gbxReceta;
        private TextBox txtIndicaciones;
        private TextBox txtDuracion;
        private TextBox txtFrecuencia;
        private TextBox txtDosis;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private ComboBox cboMedicamento;
        private Label label2;
    }
}