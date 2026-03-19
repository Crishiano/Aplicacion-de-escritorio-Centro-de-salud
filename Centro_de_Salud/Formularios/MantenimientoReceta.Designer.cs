namespace CapaPresentacion.Formularios
{
    partial class MantenimientoReceta
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
            dgreceta = new DataGridView();
            gbxReceta = new GroupBox();
            btnDetalle = new Button();
            btnEliminar = new Button();
            btnGuardar = new Button();
            btnNuevo = new Button();
            dtpFecha = new DateTimePicker();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgreceta).BeginInit();
            gbxReceta.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(143, 225, 151);
            label1.Font = new Font("Verdana", 19.8000011F, FontStyle.Bold);
            label1.Location = new Point(34, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(503, 62);
            label1.TabIndex = 1;
            label1.Text = "MANTENIMIENTO RECETA";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgreceta
            // 
            dgreceta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgreceta.Location = new Point(120, 232);
            dgreceta.Name = "dgreceta";
            dgreceta.ReadOnly = true;
            dgreceta.Size = new Size(328, 205);
            dgreceta.TabIndex = 7;
            // 
            // gbxReceta
            // 
            gbxReceta.Controls.Add(btnDetalle);
            gbxReceta.Controls.Add(btnEliminar);
            gbxReceta.Controls.Add(btnGuardar);
            gbxReceta.Controls.Add(btnNuevo);
            gbxReceta.Controls.Add(dtpFecha);
            gbxReceta.Controls.Add(label2);
            gbxReceta.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbxReceta.Location = new Point(34, 83);
            gbxReceta.Name = "gbxReceta";
            gbxReceta.Size = new Size(506, 143);
            gbxReceta.TabIndex = 8;
            gbxReceta.TabStop = false;
            gbxReceta.Text = "Datos Receta";
            // 
            // btnDetalle
            // 
            btnDetalle.Enabled = false;
            btnDetalle.Location = new Point(371, 95);
            btnDetalle.Name = "btnDetalle";
            btnDetalle.Size = new Size(85, 27);
            btnDetalle.TabIndex = 8;
            btnDetalle.Text = "Detalle";
            btnDetalle.UseVisualStyleBackColor = true;
            btnDetalle.Click += btnDetalle_Click_1;
            // 
            // btnEliminar
            // 
            btnEliminar.Enabled = false;
            btnEliminar.Location = new Point(260, 95);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(77, 27);
            btnEliminar.TabIndex = 7;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(150, 95);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(80, 27);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click_1;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(44, 95);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(80, 27);
            btnNuevo.TabIndex = 5;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click_1;
            // 
            // dtpFecha
            // 
            dtpFecha.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(137, 43);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(200, 27);
            dtpFecha.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label2.Location = new Point(70, 49);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 2;
            label2.Text = "Fecha:";
            // 
            // MantenimientoReceta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(566, 450);
            Controls.Add(dgreceta);
            Controls.Add(gbxReceta);
            Controls.Add(label1);
            Name = "MantenimientoReceta";
            Text = "MantenimientoReceta";
            ((System.ComponentModel.ISupportInitialize)dgreceta).EndInit();
            gbxReceta.ResumeLayout(false);
            gbxReceta.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private DataGridView dgreceta;
        private GroupBox gbxReceta;
        private Button btnDetalle;
        private Button btnEliminar;
        private Button btnGuardar;
        private Button btnNuevo;
        private DateTimePicker dtpFecha;
        private Label label2;
    }
}