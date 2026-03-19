namespace CapaPresentacion.Reportes
{
    partial class ReporteCitasrango
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
            label2 = new Label();
            label3 = new Label();
            dtinicio = new DateTimePicker();
            dtfin = new DateTimePicker();
            btreporte = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(0, 88, 255);
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Verdana", 19.8000011F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(5, 10);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(742, 90);
            label1.TabIndex = 17;
            label1.Text = "REPORTE DE CITAS POR RANGO DE FECHA";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            label2.Location = new Point(218, 171);
            label2.Name = "label2";
            label2.Size = new Size(102, 37);
            label2.TabIndex = 18;
            label2.Text = "Inicio :";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            label3.Location = new Point(251, 234);
            label3.Name = "label3";
            label3.Size = new Size(69, 37);
            label3.TabIndex = 19;
            label3.Text = "Fin :";
            // 
            // dtinicio
            // 
            dtinicio.Anchor = AnchorStyles.None;
            dtinicio.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            dtinicio.Format = DateTimePickerFormat.Short;
            dtinicio.Location = new Point(340, 175);
            dtinicio.Name = "dtinicio";
            dtinicio.Size = new Size(200, 33);
            dtinicio.TabIndex = 20;
            // 
            // dtfin
            // 
            dtfin.Anchor = AnchorStyles.None;
            dtfin.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            dtfin.Format = DateTimePickerFormat.Short;
            dtfin.Location = new Point(340, 238);
            dtfin.Name = "dtfin";
            dtfin.Size = new Size(200, 33);
            dtfin.TabIndex = 21;
            // 
            // btreporte
            // 
            btreporte.Anchor = AnchorStyles.None;
            btreporte.BackColor = Color.FromArgb(0, 88, 255);
            btreporte.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btreporte.ForeColor = SystemColors.Control;
            btreporte.Location = new Point(325, 311);
            btreporte.Name = "btreporte";
            btreporte.Size = new Size(121, 45);
            btreporte.TabIndex = 22;
            btreporte.Text = "Reporte";
            btreporte.UseVisualStyleBackColor = false;
            btreporte.Click += btreporte_Click;
            // 
            // ReporteCitasrango
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(752, 400);
            Controls.Add(btreporte);
            Controls.Add(dtfin);
            Controls.Add(dtinicio);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ReporteCitasrango";
            Padding = new Padding(5, 10, 5, 0);
            Text = "ReporteCitasrango";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private DateTimePicker dtinicio;
        private DateTimePicker dtfin;
        private Button btreporte;
    }
}