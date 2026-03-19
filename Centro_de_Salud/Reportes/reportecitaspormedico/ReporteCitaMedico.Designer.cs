namespace CapaPresentacion.Reportes.reportecitaspormedico
{
    partial class ReporteCitaMedico
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
            cbmedico = new ComboBox();
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
            label1.Size = new Size(790, 90);
            label1.TabIndex = 18;
            label1.Text = "REPORTE DE CITAS POR MEDICO";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(131, 218);
            label2.Name = "label2";
            label2.Size = new Size(113, 32);
            label2.TabIndex = 19;
            label2.Text = "Medico :";
            // 
            // cbmedico
            // 
            cbmedico.DropDownStyle = ComboBoxStyle.DropDownList;
            cbmedico.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbmedico.FormattingEnabled = true;
            cbmedico.Location = new Point(241, 217);
            cbmedico.Name = "cbmedico";
            cbmedico.Size = new Size(433, 38);
            cbmedico.TabIndex = 20;
            cbmedico.SelectedIndexChanged += cbmedico_SelectedIndexChanged;
            // 
            // btreporte
            // 
            btreporte.Anchor = AnchorStyles.None;
            btreporte.BackColor = Color.FromArgb(0, 88, 255);
            btreporte.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btreporte.ForeColor = SystemColors.Control;
            btreporte.Location = new Point(340, 330);
            btreporte.Name = "btreporte";
            btreporte.Size = new Size(121, 45);
            btreporte.TabIndex = 23;
            btreporte.Text = "Reporte";
            btreporte.UseVisualStyleBackColor = false;
            btreporte.Click += btreporte_Click;
            // 
            // ReporteCitaMedico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btreporte);
            Controls.Add(cbmedico);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ReporteCitaMedico";
            Padding = new Padding(5, 10, 5, 0);
            Text = "ReporteCitaMedico";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cbmedico;
        private Button btreporte;
    }
}