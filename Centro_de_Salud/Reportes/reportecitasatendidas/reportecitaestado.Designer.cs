namespace CapaPresentacion.Reportes.reportecitasatendidas
{
    partial class reportecitaestado
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
            btreporte1 = new Button();
            button1 = new Button();
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
            label1.Text = "REPORTE DE CITAS POR ESTADO";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            label2.Location = new Point(211, 191);
            label2.Name = "label2";
            label2.Size = new Size(230, 37);
            label2.TabIndex = 19;
            label2.Text = "Citas Atendidas :";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            label3.Location = new Point(197, 271);
            label3.Name = "label3";
            label3.Size = new Size(244, 37);
            label3.TabIndex = 20;
            label3.Text = "Citas Canceladas :";
            // 
            // btreporte1
            // 
            btreporte1.Anchor = AnchorStyles.None;
            btreporte1.BackColor = Color.FromArgb(0, 88, 255);
            btreporte1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btreporte1.ForeColor = SystemColors.Control;
            btreporte1.Location = new Point(461, 191);
            btreporte1.Name = "btreporte1";
            btreporte1.Size = new Size(121, 45);
            btreporte1.TabIndex = 23;
            btreporte1.Text = "Reporte";
            btreporte1.UseVisualStyleBackColor = false;
            btreporte1.Click += btreporte1_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.FromArgb(0, 88, 255);
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(461, 270);
            button1.Name = "button1";
            button1.Size = new Size(121, 45);
            button1.TabIndex = 24;
            button1.Text = "Reporte";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // reportecitaestado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(btreporte1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "reportecitaestado";
            Padding = new Padding(5, 10, 5, 0);
            Text = "reportecitaestado";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btreporte1;
        private Button button1;
    }
}