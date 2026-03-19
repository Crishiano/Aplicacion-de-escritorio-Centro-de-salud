namespace interfaz
{
    partial class Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panelmenu = new Panel();
            btcerrarsesion = new Button();
            paneldefecto = new Panel();
            btMiHistorial = new Button();
            btHistorial = new Button();
            panelreporte = new Panel();
            button15 = new Button();
            button16 = new Button();
            button17 = new Button();
            btreporte = new Button();
            panelproceso = new Panel();
            btnAtencionMedica = new Button();
            btnCita = new Button();
            btnAgendaMedica = new Button();
            btproceso = new Button();
            panelMantenimiento = new Panel();
            btusuario = new Button();
            btpaciente = new Button();
            btmedico = new Button();
            btmedicamento = new Button();
            btespecialidad = new Button();
            btMantenimiento = new Button();
            panellogo = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            panel4 = new Panel();
            lblnomUsu = new Label();
            label3 = new Label();
            panel3 = new Panel();
            lblnomRol = new Label();
            label1 = new Label();
            panelpresentacion = new Panel();
            panel1 = new Panel();
            hora = new Label();
            pictureBox2 = new PictureBox();
            Horafecha = new System.Windows.Forms.Timer(components);
            panelmenu.SuspendLayout();
            paneldefecto.SuspendLayout();
            panelreporte.SuspendLayout();
            panelproceso.SuspendLayout();
            panelMantenimiento.SuspendLayout();
            panellogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panelpresentacion.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panelmenu
            // 
            panelmenu.AutoScroll = true;
            panelmenu.BackColor = Color.FromArgb(0, 88, 255);
            panelmenu.Controls.Add(btcerrarsesion);
            panelmenu.Controls.Add(paneldefecto);
            panelmenu.Controls.Add(btHistorial);
            panelmenu.Controls.Add(panelreporte);
            panelmenu.Controls.Add(btreporte);
            panelmenu.Controls.Add(panelproceso);
            panelmenu.Controls.Add(btproceso);
            panelmenu.Controls.Add(panelMantenimiento);
            panelmenu.Controls.Add(btMantenimiento);
            panelmenu.Controls.Add(panellogo);
            panelmenu.Dock = DockStyle.Left;
            panelmenu.Location = new Point(0, 0);
            panelmenu.Name = "panelmenu";
            panelmenu.Size = new Size(191, 597);
            panelmenu.TabIndex = 0;
            // 
            // btcerrarsesion
            // 
            btcerrarsesion.Dock = DockStyle.Bottom;
            btcerrarsesion.FlatAppearance.BorderSize = 0;
            btcerrarsesion.FlatStyle = FlatStyle.Flat;
            btcerrarsesion.Font = new Font("Myanmar Text", 11.25F, FontStyle.Bold);
            btcerrarsesion.ForeColor = SystemColors.Control;
            btcerrarsesion.Location = new Point(0, 835);
            btcerrarsesion.Name = "btcerrarsesion";
            btcerrarsesion.Size = new Size(174, 39);
            btcerrarsesion.TabIndex = 9;
            btcerrarsesion.Text = "Cerrar Sesion";
            btcerrarsesion.UseVisualStyleBackColor = true;
            btcerrarsesion.Click += btcerrarsesion_Click;
            // 
            // paneldefecto
            // 
            paneldefecto.BackColor = Color.FromArgb(0, 40, 145);
            paneldefecto.Controls.Add(btMiHistorial);
            paneldefecto.Dock = DockStyle.Top;
            paneldefecto.Location = new Point(0, 799);
            paneldefecto.Name = "paneldefecto";
            paneldefecto.Size = new Size(174, 36);
            paneldefecto.TabIndex = 8;
            paneldefecto.Visible = false;
            // 
            // btMiHistorial
            // 
            btMiHistorial.Dock = DockStyle.Top;
            btMiHistorial.FlatAppearance.BorderSize = 0;
            btMiHistorial.FlatAppearance.MouseDownBackColor = Color.FromArgb(2, 30, 102);
            btMiHistorial.FlatStyle = FlatStyle.Flat;
            btMiHistorial.ForeColor = SystemColors.ControlLightLight;
            btMiHistorial.Location = new Point(0, 0);
            btMiHistorial.Name = "btMiHistorial";
            btMiHistorial.Padding = new Padding(35, 0, 0, 0);
            btMiHistorial.Size = new Size(174, 32);
            btMiHistorial.TabIndex = 0;
            btMiHistorial.Text = "Mi Historial";
            btMiHistorial.TextAlign = ContentAlignment.MiddleLeft;
            btMiHistorial.UseVisualStyleBackColor = true;
            btMiHistorial.Click += btMiHistorial_Click;
            // 
            // btHistorial
            // 
            btHistorial.Dock = DockStyle.Top;
            btHistorial.FlatAppearance.BorderSize = 0;
            btHistorial.FlatStyle = FlatStyle.Flat;
            btHistorial.Font = new Font("Myanmar Text", 11.25F, FontStyle.Bold);
            btHistorial.ForeColor = SystemColors.Control;
            btHistorial.Location = new Point(0, 742);
            btHistorial.Name = "btHistorial";
            btHistorial.Padding = new Padding(10, 0, 0, 0);
            btHistorial.Size = new Size(174, 57);
            btHistorial.TabIndex = 7;
            btHistorial.Text = "Historial";
            btHistorial.TextAlign = ContentAlignment.MiddleLeft;
            btHistorial.UseVisualStyleBackColor = true;
            btHistorial.Click += btdefecto_Click;
            // 
            // panelreporte
            // 
            panelreporte.BackColor = Color.FromArgb(0, 40, 145);
            panelreporte.Controls.Add(button15);
            panelreporte.Controls.Add(button16);
            panelreporte.Controls.Add(button17);
            panelreporte.Dock = DockStyle.Top;
            panelreporte.Location = new Point(0, 612);
            panelreporte.Name = "panelreporte";
            panelreporte.Size = new Size(174, 130);
            panelreporte.TabIndex = 6;
            panelreporte.Visible = false;
            // 
            // button15
            // 
            button15.Dock = DockStyle.Top;
            button15.FlatAppearance.BorderSize = 0;
            button15.FlatAppearance.MouseDownBackColor = Color.FromArgb(2, 30, 102);
            button15.FlatStyle = FlatStyle.Flat;
            button15.ForeColor = SystemColors.ControlLightLight;
            button15.Location = new Point(0, 85);
            button15.Name = "button15";
            button15.Padding = new Padding(35, 0, 0, 0);
            button15.Size = new Size(174, 35);
            button15.TabIndex = 2;
            button15.Text = "Citas por Medico";
            button15.TextAlign = ContentAlignment.MiddleLeft;
            button15.UseVisualStyleBackColor = true;
            button15.Click += button15_Click;
            // 
            // button16
            // 
            button16.Dock = DockStyle.Top;
            button16.FlatAppearance.BorderSize = 0;
            button16.FlatAppearance.MouseDownBackColor = Color.FromArgb(2, 30, 102);
            button16.FlatStyle = FlatStyle.Flat;
            button16.ForeColor = SystemColors.ControlLightLight;
            button16.Location = new Point(0, 43);
            button16.Name = "button16";
            button16.Padding = new Padding(35, 0, 0, 0);
            button16.Size = new Size(174, 42);
            button16.TabIndex = 1;
            button16.Text = "Citas Atendidas vs Canceladas";
            button16.TextAlign = ContentAlignment.MiddleLeft;
            button16.UseVisualStyleBackColor = true;
            button16.Click += button16_Click;
            // 
            // button17
            // 
            button17.Dock = DockStyle.Top;
            button17.FlatAppearance.BorderSize = 0;
            button17.FlatAppearance.MouseDownBackColor = Color.FromArgb(2, 30, 102);
            button17.FlatStyle = FlatStyle.Flat;
            button17.ForeColor = SystemColors.ControlLightLight;
            button17.Location = new Point(0, 0);
            button17.Name = "button17";
            button17.Padding = new Padding(35, 0, 0, 0);
            button17.Size = new Size(174, 43);
            button17.TabIndex = 0;
            button17.Text = "Citas por Rango de Fechas";
            button17.TextAlign = ContentAlignment.MiddleLeft;
            button17.UseVisualStyleBackColor = true;
            button17.Click += button17_Click;
            // 
            // btreporte
            // 
            btreporte.Dock = DockStyle.Top;
            btreporte.FlatAppearance.BorderSize = 0;
            btreporte.FlatStyle = FlatStyle.Flat;
            btreporte.Font = new Font("Myanmar Text", 11.25F, FontStyle.Bold);
            btreporte.ForeColor = SystemColors.Control;
            btreporte.ImageAlign = ContentAlignment.MiddleLeft;
            btreporte.Location = new Point(0, 552);
            btreporte.Name = "btreporte";
            btreporte.Padding = new Padding(10, 0, 0, 0);
            btreporte.Size = new Size(174, 60);
            btreporte.TabIndex = 5;
            btreporte.Text = "Reportes";
            btreporte.TextAlign = ContentAlignment.MiddleLeft;
            btreporte.UseVisualStyleBackColor = true;
            btreporte.Click += btreporte_Click;
            // 
            // panelproceso
            // 
            panelproceso.BackColor = Color.FromArgb(0, 40, 145);
            panelproceso.Controls.Add(btnAtencionMedica);
            panelproceso.Controls.Add(btnCita);
            panelproceso.Controls.Add(btnAgendaMedica);
            panelproceso.Dock = DockStyle.Top;
            panelproceso.Location = new Point(0, 443);
            panelproceso.Name = "panelproceso";
            panelproceso.Size = new Size(174, 109);
            panelproceso.TabIndex = 4;
            panelproceso.Visible = false;
            // 
            // btnAtencionMedica
            // 
            btnAtencionMedica.Dock = DockStyle.Top;
            btnAtencionMedica.FlatAppearance.BorderSize = 0;
            btnAtencionMedica.FlatAppearance.MouseDownBackColor = Color.FromArgb(2, 30, 102);
            btnAtencionMedica.FlatStyle = FlatStyle.Flat;
            btnAtencionMedica.ForeColor = SystemColors.ControlLightLight;
            btnAtencionMedica.Location = new Point(0, 70);
            btnAtencionMedica.Name = "btnAtencionMedica";
            btnAtencionMedica.Padding = new Padding(35, 0, 0, 0);
            btnAtencionMedica.Size = new Size(174, 35);
            btnAtencionMedica.TabIndex = 2;
            btnAtencionMedica.Text = "Atención Medica";
            btnAtencionMedica.TextAlign = ContentAlignment.MiddleLeft;
            btnAtencionMedica.UseVisualStyleBackColor = true;
            btnAtencionMedica.Click += btnAM_Click;
            // 
            // btnCita
            // 
            btnCita.Dock = DockStyle.Top;
            btnCita.FlatAppearance.BorderSize = 0;
            btnCita.FlatAppearance.MouseDownBackColor = Color.FromArgb(2, 30, 102);
            btnCita.FlatStyle = FlatStyle.Flat;
            btnCita.ForeColor = SystemColors.ControlLightLight;
            btnCita.Location = new Point(0, 35);
            btnCita.Name = "btnCita";
            btnCita.Padding = new Padding(35, 0, 0, 0);
            btnCita.Size = new Size(174, 35);
            btnCita.TabIndex = 1;
            btnCita.Text = "Cita";
            btnCita.TextAlign = ContentAlignment.MiddleLeft;
            btnCita.UseVisualStyleBackColor = true;
            btnCita.Click += btnAtencionMedica_Click;
            // 
            // btnAgendaMedica
            // 
            btnAgendaMedica.Dock = DockStyle.Top;
            btnAgendaMedica.FlatAppearance.BorderSize = 0;
            btnAgendaMedica.FlatAppearance.MouseDownBackColor = Color.FromArgb(2, 30, 102);
            btnAgendaMedica.FlatStyle = FlatStyle.Flat;
            btnAgendaMedica.ForeColor = SystemColors.ControlLightLight;
            btnAgendaMedica.Location = new Point(0, 0);
            btnAgendaMedica.Name = "btnAgendaMedica";
            btnAgendaMedica.Padding = new Padding(35, 0, 0, 0);
            btnAgendaMedica.Size = new Size(174, 35);
            btnAgendaMedica.TabIndex = 0;
            btnAgendaMedica.Text = "Agenda Medica";
            btnAgendaMedica.TextAlign = ContentAlignment.MiddleLeft;
            btnAgendaMedica.UseVisualStyleBackColor = true;
            btnAgendaMedica.Click += button11_Click;
            // 
            // btproceso
            // 
            btproceso.Dock = DockStyle.Top;
            btproceso.FlatAppearance.BorderSize = 0;
            btproceso.FlatStyle = FlatStyle.Flat;
            btproceso.Font = new Font("Myanmar Text", 11.25F, FontStyle.Bold);
            btproceso.ForeColor = SystemColors.Control;
            btproceso.ImageAlign = ContentAlignment.MiddleLeft;
            btproceso.Location = new Point(0, 383);
            btproceso.Name = "btproceso";
            btproceso.Padding = new Padding(10, 0, 0, 0);
            btproceso.Size = new Size(174, 60);
            btproceso.TabIndex = 3;
            btproceso.Text = "Proceso";
            btproceso.TextAlign = ContentAlignment.MiddleLeft;
            btproceso.UseVisualStyleBackColor = true;
            btproceso.Click += btproceso_Click;
            // 
            // panelMantenimiento
            // 
            panelMantenimiento.BackColor = Color.FromArgb(0, 40, 145);
            panelMantenimiento.Controls.Add(btusuario);
            panelMantenimiento.Controls.Add(btpaciente);
            panelMantenimiento.Controls.Add(btmedico);
            panelMantenimiento.Controls.Add(btmedicamento);
            panelMantenimiento.Controls.Add(btespecialidad);
            panelMantenimiento.Dock = DockStyle.Top;
            panelMantenimiento.Location = new Point(0, 201);
            panelMantenimiento.Name = "panelMantenimiento";
            panelMantenimiento.Size = new Size(174, 182);
            panelMantenimiento.TabIndex = 2;
            panelMantenimiento.Visible = false;
            // 
            // btusuario
            // 
            btusuario.Dock = DockStyle.Top;
            btusuario.FlatAppearance.BorderSize = 0;
            btusuario.FlatAppearance.MouseDownBackColor = Color.FromArgb(2, 30, 102);
            btusuario.FlatStyle = FlatStyle.Flat;
            btusuario.ForeColor = SystemColors.ControlLightLight;
            btusuario.Location = new Point(0, 140);
            btusuario.Name = "btusuario";
            btusuario.Padding = new Padding(35, 0, 0, 0);
            btusuario.Size = new Size(174, 35);
            btusuario.TabIndex = 6;
            btusuario.Text = "Usuarios";
            btusuario.TextAlign = ContentAlignment.MiddleLeft;
            btusuario.UseVisualStyleBackColor = true;
            btusuario.Click += btusuario_Click;
            // 
            // btpaciente
            // 
            btpaciente.Dock = DockStyle.Top;
            btpaciente.FlatAppearance.BorderSize = 0;
            btpaciente.FlatAppearance.MouseDownBackColor = Color.FromArgb(2, 30, 102);
            btpaciente.FlatStyle = FlatStyle.Flat;
            btpaciente.ForeColor = SystemColors.ControlLightLight;
            btpaciente.Location = new Point(0, 105);
            btpaciente.Name = "btpaciente";
            btpaciente.Padding = new Padding(35, 0, 0, 0);
            btpaciente.Size = new Size(174, 35);
            btpaciente.TabIndex = 4;
            btpaciente.Text = "Paciente";
            btpaciente.TextAlign = ContentAlignment.MiddleLeft;
            btpaciente.UseVisualStyleBackColor = true;
            btpaciente.Click += btpaciente_Click;
            // 
            // btmedico
            // 
            btmedico.Dock = DockStyle.Top;
            btmedico.FlatAppearance.BorderSize = 0;
            btmedico.FlatAppearance.MouseDownBackColor = Color.FromArgb(2, 30, 102);
            btmedico.FlatStyle = FlatStyle.Flat;
            btmedico.ForeColor = SystemColors.ControlLightLight;
            btmedico.Location = new Point(0, 70);
            btmedico.Name = "btmedico";
            btmedico.Padding = new Padding(35, 0, 0, 0);
            btmedico.Size = new Size(174, 35);
            btmedico.TabIndex = 3;
            btmedico.Text = "Medico";
            btmedico.TextAlign = ContentAlignment.MiddleLeft;
            btmedico.UseVisualStyleBackColor = true;
            btmedico.Click += btmedico_Click;
            // 
            // btmedicamento
            // 
            btmedicamento.Dock = DockStyle.Top;
            btmedicamento.FlatAppearance.BorderSize = 0;
            btmedicamento.FlatAppearance.MouseDownBackColor = Color.FromArgb(2, 30, 102);
            btmedicamento.FlatStyle = FlatStyle.Flat;
            btmedicamento.ForeColor = SystemColors.ControlLightLight;
            btmedicamento.Location = new Point(0, 35);
            btmedicamento.Name = "btmedicamento";
            btmedicamento.Padding = new Padding(35, 0, 0, 0);
            btmedicamento.Size = new Size(174, 35);
            btmedicamento.TabIndex = 2;
            btmedicamento.Text = "Medicamentos";
            btmedicamento.TextAlign = ContentAlignment.MiddleLeft;
            btmedicamento.UseVisualStyleBackColor = true;
            btmedicamento.Click += btmedicamento_Click;
            // 
            // btespecialidad
            // 
            btespecialidad.Dock = DockStyle.Top;
            btespecialidad.FlatAppearance.BorderSize = 0;
            btespecialidad.FlatAppearance.MouseDownBackColor = Color.FromArgb(2, 30, 102);
            btespecialidad.FlatStyle = FlatStyle.Flat;
            btespecialidad.ForeColor = SystemColors.ControlLightLight;
            btespecialidad.Location = new Point(0, 0);
            btespecialidad.Name = "btespecialidad";
            btespecialidad.Padding = new Padding(35, 0, 0, 0);
            btespecialidad.Size = new Size(174, 35);
            btespecialidad.TabIndex = 0;
            btespecialidad.Text = "Especialidades";
            btespecialidad.TextAlign = ContentAlignment.MiddleLeft;
            btespecialidad.UseVisualStyleBackColor = true;
            btespecialidad.Click += btespecialidad_Click;
            // 
            // btMantenimiento
            // 
            btMantenimiento.BackColor = Color.FromArgb(0, 88, 255);
            btMantenimiento.Dock = DockStyle.Top;
            btMantenimiento.FlatAppearance.BorderSize = 0;
            btMantenimiento.FlatStyle = FlatStyle.Flat;
            btMantenimiento.Font = new Font("Myanmar Text", 11.25F, FontStyle.Bold);
            btMantenimiento.ForeColor = SystemColors.ControlLight;
            btMantenimiento.ImageAlign = ContentAlignment.MiddleLeft;
            btMantenimiento.Location = new Point(0, 142);
            btMantenimiento.Name = "btMantenimiento";
            btMantenimiento.Padding = new Padding(10, 0, 0, 0);
            btMantenimiento.Size = new Size(174, 59);
            btMantenimiento.TabIndex = 1;
            btMantenimiento.Text = "Mantenimiento";
            btMantenimiento.TextAlign = ContentAlignment.MiddleLeft;
            btMantenimiento.UseVisualStyleBackColor = false;
            btMantenimiento.Click += btMantenimiento_Click;
            // 
            // panellogo
            // 
            panellogo.Controls.Add(pictureBox1);
            panellogo.Dock = DockStyle.Top;
            panellogo.Location = new Point(0, 0);
            panellogo.Name = "panellogo";
            panellogo.Size = new Size(174, 142);
            panellogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = CapaPresentacion.Properties.Resources.logosaludpequeño;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(174, 142);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(191, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1008, 69);
            panel2.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Right;
            panel4.Controls.Add(lblnomUsu);
            panel4.Controls.Add(label3);
            panel4.Location = new Point(749, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(256, 60);
            panel4.TabIndex = 1;
            // 
            // lblnomUsu
            // 
            lblnomUsu.AutoSize = true;
            lblnomUsu.Font = new Font("Segoe UI", 14.25F);
            lblnomUsu.ForeColor = Color.FromArgb(0, 88, 255);
            lblnomUsu.Location = new Point(97, 21);
            lblnomUsu.Name = "lblnomUsu";
            lblnomUsu.Size = new Size(63, 25);
            lblnomUsu.TabIndex = 2;
            lblnomUsu.Text = "label4";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(0, 88, 255);
            label3.Location = new Point(9, 21);
            label3.Name = "label3";
            label3.Size = new Size(91, 25);
            label3.TabIndex = 1;
            label3.Text = "Usuario :";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Left;
            panel3.Controls.Add(lblnomRol);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(22, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(228, 60);
            panel3.TabIndex = 0;
            // 
            // lblnomRol
            // 
            lblnomRol.AutoSize = true;
            lblnomRol.Font = new Font("Segoe UI", 14.25F);
            lblnomRol.ForeColor = Color.FromArgb(0, 88, 255);
            lblnomRol.Location = new Point(51, 21);
            lblnomRol.Name = "lblnomRol";
            lblnomRol.Size = new Size(63, 25);
            lblnomRol.TabIndex = 1;
            lblnomRol.Text = "label2";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 88, 255);
            label1.Location = new Point(3, 21);
            label1.Name = "label1";
            label1.Size = new Size(51, 25);
            label1.TabIndex = 0;
            label1.Text = "Rol :";
            // 
            // panelpresentacion
            // 
            panelpresentacion.AutoScroll = true;
            panelpresentacion.Controls.Add(panel1);
            panelpresentacion.Dock = DockStyle.Fill;
            panelpresentacion.Location = new Point(191, 69);
            panelpresentacion.Name = "panelpresentacion";
            panelpresentacion.Size = new Size(1008, 528);
            panelpresentacion.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.Controls.Add(hora);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(225, 84);
            panel1.Name = "panel1";
            panel1.Size = new Size(561, 378);
            panel1.TabIndex = 1;
            // 
            // hora
            // 
            hora.Anchor = AnchorStyles.Bottom;
            hora.AutoSize = true;
            hora.Font = new Font("Segoe UI Black", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            hora.ForeColor = Color.FromArgb(30, 103, 186);
            hora.Location = new Point(215, 228);
            hora.Name = "hora";
            hora.Size = new Size(100, 40);
            hora.TabIndex = 1;
            hora.Text = "label1";
            hora.Click += hora_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top;
            pictureBox2.Image = CapaPresentacion.Properties.Resources.logosaludgrande;
            pictureBox2.Location = new Point(108, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(355, 270);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // Horafecha
            // 
            Horafecha.Enabled = true;
            Horafecha.Tick += Horafecha_Tick;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1199, 597);
            Controls.Add(panelpresentacion);
            Controls.Add(panel2);
            Controls.Add(panelmenu);
            MinimumSize = new Size(750, 548);
            Name = "Menu";
            Text = "Form1";
            Resize += Form1_Resize;
            panelmenu.ResumeLayout(false);
            paneldefecto.ResumeLayout(false);
            panelreporte.ResumeLayout(false);
            panelproceso.ResumeLayout(false);
            panelMantenimiento.ResumeLayout(false);
            panellogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panelpresentacion.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelmenu;
        private Button btMantenimiento;
        private Panel panelMantenimiento;
        private Button btpaciente;
        private Button btmedico;
        private Button btmedicamento;
        private Button btespecialidad;
        private Panel panelreporte;
        private Button button15;
        private Button button16;
        private Button button17;
        private Button btreporte;
        private Panel panelproceso;
        private Button btnAtencionMedica;
        private Button btnCita;
        private Button btnAgendaMedica;
        private Button btproceso;
        private Panel paneldefecto;
        private Button btMiHistorial;
        private Button btHistorial;
        private Panel panel2;
        private Panel panelpresentacion;
        private Panel panellogo;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Panel panel1;
        private Label hora;
        private System.Windows.Forms.Timer Horafecha;
        private Panel panel4;
        private Panel panel3;
        private Label label1;
        private Label lblnomRol;
        private Label lblnomUsu;
        private Label label3;
        private Button btusuario;
        private Button btcerrarsesion;
    }
}
