namespace CapaPresentacion.Formularios
{
    partial class MantenimientoMedicamento
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
            dgvMedicamentos = new DataGridView();
            btnNuevo = new Button();
            btnModificar = new Button();
            btnGuardar = new Button();
            label1 = new Label();
            gbxMedicamento = new GroupBox();
            txtPresentacion = new TextBox();
            label4 = new Label();
            txtMedicamento = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvMedicamentos).BeginInit();
            gbxMedicamento.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvMedicamentos
            // 
            dgvMedicamentos.AllowUserToDeleteRows = false;
            dgvMedicamentos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMedicamentos.BackgroundColor = Color.White;
            dgvMedicamentos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMedicamentos.Dock = DockStyle.Fill;
            dgvMedicamentos.Location = new Point(0, 0);
            dgvMedicamentos.Name = "dgvMedicamentos";
            dgvMedicamentos.ReadOnly = true;
            dgvMedicamentos.RowHeadersWidth = 51;
            dgvMedicamentos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMedicamentos.Size = new Size(943, 355);
            dgvMedicamentos.TabIndex = 24;
            // 
            // btnNuevo
            // 
            btnNuevo.Anchor = AnchorStyles.None;
            btnNuevo.BackColor = Color.FromArgb(219, 214, 214);
            btnNuevo.Font = new Font("Arial Rounded MT Bold", 12F);
            btnNuevo.ForeColor = Color.Black;
            btnNuevo.Image = Properties.Resources.nuevo;
            btnNuevo.ImageAlign = ContentAlignment.MiddleRight;
            btnNuevo.Location = new Point(410, 225);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(127, 60);
            btnNuevo.TabIndex = 22;
            btnNuevo.Text = "Nuevo";
            btnNuevo.TextAlign = ContentAlignment.MiddleLeft;
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnModificar
            // 
            btnModificar.Anchor = AnchorStyles.None;
            btnModificar.BackColor = Color.FromArgb(219, 214, 214);
            btnModificar.Font = new Font("Arial Rounded MT Bold", 12F);
            btnModificar.ForeColor = Color.Black;
            btnModificar.Image = Properties.Resources.modificar;
            btnModificar.ImageAlign = ContentAlignment.MiddleRight;
            btnModificar.Location = new Point(588, 225);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(131, 60);
            btnModificar.TabIndex = 21;
            btnModificar.Text = "Modificar";
            btnModificar.TextAlign = ContentAlignment.MiddleLeft;
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.None;
            btnGuardar.BackColor = Color.FromArgb(219, 214, 214);
            btnGuardar.Font = new Font("Arial Rounded MT Bold", 12F);
            btnGuardar.ForeColor = Color.Black;
            btnGuardar.Image = Properties.Resources.guardar;
            btnGuardar.ImageAlign = ContentAlignment.MiddleRight;
            btnGuardar.Location = new Point(225, 225);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(127, 60);
            btnGuardar.TabIndex = 20;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextAlign = ContentAlignment.MiddleLeft;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(0, 88, 255);
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Verdana", 20F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(6, 13);
            label1.Name = "label1";
            label1.Size = new Size(943, 96);
            label1.TabIndex = 19;
            label1.Text = "MANTENIMIENTO DE MEDICAMENTOS";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gbxMedicamento
            // 
            gbxMedicamento.Anchor = AnchorStyles.None;
            gbxMedicamento.Controls.Add(txtPresentacion);
            gbxMedicamento.Controls.Add(label4);
            gbxMedicamento.Controls.Add(txtMedicamento);
            gbxMedicamento.Controls.Add(label2);
            gbxMedicamento.Font = new Font("Arial Rounded MT Bold", 15F);
            gbxMedicamento.Location = new Point(199, 24);
            gbxMedicamento.Margin = new Padding(3, 4, 3, 4);
            gbxMedicamento.Name = "gbxMedicamento";
            gbxMedicamento.Padding = new Padding(3, 4, 3, 4);
            gbxMedicamento.Size = new Size(551, 173);
            gbxMedicamento.TabIndex = 25;
            gbxMedicamento.TabStop = false;
            gbxMedicamento.Text = "Datos Medicamento";
            gbxMedicamento.Enter += gbxRol_Enter;
            // 
            // txtPresentacion
            // 
            txtPresentacion.Font = new Font("Consolas", 14F, FontStyle.Bold);
            txtPresentacion.Location = new Point(195, 112);
            txtPresentacion.Name = "txtPresentacion";
            txtPresentacion.Size = new Size(325, 35);
            txtPresentacion.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 15F);
            label4.Location = new Point(10, 113);
            label4.Name = "label4";
            label4.Size = new Size(190, 29);
            label4.TabIndex = 18;
            label4.Text = "Presentacion :";
            // 
            // txtMedicamento
            // 
            txtMedicamento.Font = new Font("Consolas", 14F, FontStyle.Bold);
            txtMedicamento.Location = new Point(195, 55);
            txtMedicamento.Name = "txtMedicamento";
            txtMedicamento.Size = new Size(325, 35);
            txtMedicamento.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 15F);
            label2.Location = new Point(8, 56);
            label2.Name = "label2";
            label2.Size = new Size(192, 29);
            label2.TabIndex = 13;
            label2.Text = "Medicamento :";
            // 
            // panel1
            // 
            panel1.Controls.Add(gbxMedicamento);
            panel1.Controls.Add(btnGuardar);
            panel1.Controls.Add(btnNuevo);
            panel1.Controls.Add(btnModificar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(6, 109);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(943, 304);
            panel1.TabIndex = 26;
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvMedicamentos);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(6, 413);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(943, 355);
            panel2.TabIndex = 27;
            // 
            // MantenimientoMedicamento
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(955, 799);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MantenimientoMedicamento";
            Padding = new Padding(6, 13, 6, 0);
            Text = "MantenimientoMedicamento";
            ((System.ComponentModel.ISupportInitialize)dgvMedicamentos).EndInit();
            gbxMedicamento.ResumeLayout(false);
            gbxMedicamento.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgvMedicamentos;
        private Button btnNuevo;
        private Button btnModificar;
        private Button btnGuardar;
        private Label label1;
        private GroupBox gbxMedicamento;
        private TextBox txtPresentacion;
        private Label label4;
        private TextBox txtMedicamento;
        private Label label2;
        private Panel panel1;
        private Panel panel2;
    }
}