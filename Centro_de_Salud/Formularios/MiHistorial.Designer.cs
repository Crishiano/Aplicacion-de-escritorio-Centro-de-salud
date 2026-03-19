namespace CapaPresentacion.Formularios
{
    partial class MiHistorial
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
            label5 = new Label();
            dgvRecetas = new DataGridView();
            label1 = new Label();
            dgvCitas = new DataGridView();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvRecetas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCitas).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(501, 75);
            label5.Name = "label5";
            label5.Size = new Size(154, 25);
            label5.TabIndex = 40;
            label5.Text = "Recetas por Cita";
            // 
            // dgvRecetas
            // 
            dgvRecetas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecetas.Location = new Point(501, 119);
            dgvRecetas.Name = "dgvRecetas";
            dgvRecetas.ReadOnly = true;
            dgvRecetas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRecetas.Size = new Size(396, 245);
            dgvRecetas.TabIndex = 39;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(0, 88, 255);
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Verdana", 20F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(906, 51);
            label1.TabIndex = 34;
            label1.Text = "MI HISTORIAL";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvCitas
            // 
            dgvCitas.BackgroundColor = Color.White;
            dgvCitas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCitas.Location = new Point(12, 115);
            dgvCitas.Name = "dgvCitas";
            dgvCitas.ReadOnly = true;
            dgvCitas.RowHeadersWidth = 51;
            dgvCitas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCitas.Size = new Size(463, 378);
            dgvCitas.TabIndex = 33;
            dgvCitas.SelectionChanged += dgvCitas_SelectionChanged_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 75);
            label2.Name = "label2";
            label2.Size = new Size(161, 25);
            label2.TabIndex = 41;
            label2.Text = "Historial de Citas";
            // 
            // MiHistorial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(906, 505);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(dgvRecetas);
            Controls.Add(label1);
            Controls.Add(dgvCitas);
            Name = "MiHistorial";
            Text = "MiHistorial";
            Load += MiHistorial_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRecetas).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCitas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private DataGridView dgvRecetas;
        private Label label1;
        private DataGridView dgvCitas;
        private Label label2;
    }
}