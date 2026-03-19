namespace CapaPresentacion.Formularios
{
    partial class MantenimientoEspecialidades
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
            btnModificar = new Button();
            btnGuardar = new Button();
            btnNuevo = new Button();
            label1 = new Label();
            gbxDatos = new GroupBox();
            chkEstado = new CheckBox();
            txtDescripcion = new TextBox();
            label2 = new Label();
            dgvEspecialidades = new DataGridView();
            panel1 = new Panel();
            panel2 = new Panel();
            gbxDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEspecialidades).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnModificar
            // 
            btnModificar.Anchor = AnchorStyles.None;
            btnModificar.BackColor = Color.FromArgb(219, 214, 214);
            btnModificar.Font = new Font("Arial Rounded MT Bold", 12F);
            btnModificar.ForeColor = Color.Black;
            btnModificar.Image = Properties.Resources.modificar;
            btnModificar.ImageAlign = ContentAlignment.MiddleRight;
            btnModificar.Location = new Point(320, 149);
            btnModificar.Margin = new Padding(3, 2, 3, 2);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(116, 38);
            btnModificar.TabIndex = 16;
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
            btnGuardar.Location = new Point(178, 149);
            btnGuardar.Margin = new Padding(3, 2, 3, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(116, 38);
            btnGuardar.TabIndex = 15;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextAlign = ContentAlignment.MiddleLeft;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.Anchor = AnchorStyles.None;
            btnNuevo.BackColor = Color.FromArgb(219, 214, 214);
            btnNuevo.Font = new Font("Arial Rounded MT Bold", 12F);
            btnNuevo.ForeColor = Color.Black;
            btnNuevo.Image = Properties.Resources.nuevo;
            btnNuevo.ImageAlign = ContentAlignment.MiddleRight;
            btnNuevo.Location = new Point(460, 149);
            btnNuevo.Margin = new Padding(3, 2, 3, 2);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(116, 38);
            btnNuevo.TabIndex = 14;
            btnNuevo.Text = "Nuevo";
            btnNuevo.TextAlign = ContentAlignment.MiddleLeft;
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(0, 88, 255);
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Verdana", 20F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(5, 10);
            label1.Name = "label1";
            label1.Size = new Size(756, 76);
            label1.TabIndex = 9;
            label1.Text = "MANTENIMIENTO DE ESPECIALIDADES";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // gbxDatos
            // 
            gbxDatos.Anchor = AnchorStyles.None;
            gbxDatos.Controls.Add(chkEstado);
            gbxDatos.Controls.Add(txtDescripcion);
            gbxDatos.Controls.Add(label2);
            gbxDatos.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbxDatos.Location = new Point(178, 21);
            gbxDatos.Name = "gbxDatos";
            gbxDatos.Size = new Size(398, 105);
            gbxDatos.TabIndex = 18;
            gbxDatos.TabStop = false;
            gbxDatos.Text = "Datos Especialidad";
            // 
            // chkEstado
            // 
            chkEstado.AutoSize = true;
            chkEstado.Font = new Font("Arial Rounded MT Bold", 15F);
            chkEstado.Location = new Point(153, 74);
            chkEstado.Margin = new Padding(3, 2, 3, 2);
            chkEstado.Name = "chkEstado";
            chkEstado.Size = new Size(90, 27);
            chkEstado.TabIndex = 15;
            chkEstado.Text = "Activo";
            chkEstado.UseVisualStyleBackColor = true;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Font = new Font("Consolas", 14F, FontStyle.Bold);
            txtDescripcion.Location = new Point(127, 38);
            txtDescripcion.Margin = new Padding(3, 2, 3, 2);
            txtDescripcion.MaxLength = 100;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(251, 29);
            txtDescripcion.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 15F);
            label2.Location = new Point(9, 39);
            label2.Name = "label2";
            label2.Size = new Size(95, 23);
            label2.TabIndex = 13;
            label2.Text = "Nombre:";
            // 
            // dgvEspecialidades
            // 
            dgvEspecialidades.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEspecialidades.BackgroundColor = Color.White;
            dgvEspecialidades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEspecialidades.Dock = DockStyle.Fill;
            dgvEspecialidades.Location = new Point(10, 0);
            dgvEspecialidades.Name = "dgvEspecialidades";
            dgvEspecialidades.ReadOnly = true;
            dgvEspecialidades.RowHeadersWidth = 51;
            dgvEspecialidades.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEspecialidades.Size = new Size(736, 266);
            dgvEspecialidades.TabIndex = 19;
            // 
            // panel1
            // 
            panel1.Controls.Add(gbxDatos);
            panel1.Controls.Add(btnNuevo);
            panel1.Controls.Add(btnGuardar);
            panel1.Controls.Add(btnModificar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(5, 86);
            panel1.Name = "panel1";
            panel1.Size = new Size(756, 215);
            panel1.TabIndex = 20;
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvEspecialidades);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(5, 301);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(10, 0, 10, 0);
            panel2.Size = new Size(756, 266);
            panel2.TabIndex = 21;
            // 
            // MantenimientoEspecialidades
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(766, 589);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "MantenimientoEspecialidades";
            Padding = new Padding(5, 10, 5, 0);
            Text = "MantenimientoEspecialidades";
            gbxDatos.ResumeLayout(false);
            gbxDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEspecialidades).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button btnModificar;
        private Button btnGuardar;
        private Button btnNuevo;
        private Label label1;
        private GroupBox gbxDatos;
        private CheckBox chkEstado;
        private TextBox txtDescripcion;
        private Label label2;
        private DataGridView dgvEspecialidades;
        private Panel panel1;
        private Panel panel2;
    }
}