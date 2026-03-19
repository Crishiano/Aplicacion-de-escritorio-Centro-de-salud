using CapaModelo;
using CapaPresentacion.Formularios;
using CapaPresentacion.Reportes;
using CapaPresentacion.Reportes.reportecitasatendidas;
using CapaPresentacion.Reportes.reportecitaspormedico;
using Microsoft.VisualBasic.ApplicationServices;

namespace interfaz
{
    public partial class Menu : Form
    {
        private Size tamañoInicialForm;
        private Size tamañoInicialPanel;
        private Usuario usuarioSesion;
        public Menu(Usuario user)
        {
            InitializeComponent();
            tamañoInicialForm = this.Size;
            tamañoInicialPanel = panelpresentacion.Size;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Resize += Form1_Resize;
            this.usuarioSesion = user;
            ConfigurarMenu();
        }

        private void ConfigurarMenu()
        {
            // 1 = Admin, 2 = Medico, 3 = Paciente
            if (usuarioSesion.Rol == 2) // MÉDICO
            {
                btMantenimiento.Visible = false;
                btreporte.Visible = false;
                btHistorial.Visible = false;
                btnCita.Visible = false;
                btnAgendaMedica.Visible = false;

            }
            else if (usuarioSesion.Rol == 3) // PACIENTE
            {
                btMantenimiento.Visible = false;
                btproceso.Visible = false;
                btreporte.Visible = false;
                btHistorial.Visible = true;
            }
            else if (usuarioSesion.Rol == 1) // ADMIN
            {
                btHistorial.Visible = false;
                btnCita.Visible = false;
                btnAtencionMedica.Visible = false;
            }
            else if (usuarioSesion.Rol == 4) // RECEPCIONISTA
            {
                btHistorial.Visible = false;
                btMantenimiento.Visible = false;
                btreporte.Visible = false;
                btnCita.Visible = true;
                btnAgendaMedica.Visible = false;
                btnAtencionMedica.Visible = false;
            }
            // El Admin (Rol 1) suele ver todo por defecto

            // Mostrar nombre y rol en la barra de estado
            lblnomUsu.Text = usuarioSesion.usuario;
            lblnomRol.Text = usuarioSesion.RolNombre;
        }

        private void hideMenu()
        {
            if (panelMantenimiento.Visible == true)
                panelMantenimiento.Visible = false;
            if (panelproceso.Visible == true)
                panelproceso.Visible = false;
            if (panelreporte.Visible == true)
                panelreporte.Visible = false;
            if (paneldefecto.Visible == true)
                paneldefecto.Visible = false;

        }

        private void showsubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hideMenu();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }
        }

        private void btMantenimiento_Click(object sender, EventArgs e)
        {
            showsubmenu(panelMantenimiento);
        }

        private void btespecialidad_Click(object sender, EventArgs e)
        {
            //abrirformResponsive(new nuevo());
            abrirformResponsive(new MantenimientoEspecialidades());
            hideMenu();
        }

        private void btproceso_Click(object sender, EventArgs e)
        {
            showsubmenu(panelproceso);
        }

        private void btreporte_Click(object sender, EventArgs e)
        {
            showsubmenu(panelreporte);
        }

        private void btdefecto_Click(object sender, EventArgs e)
        {
            showsubmenu(paneldefecto);
        }
        private Form activeform = null;
        private void abrirformResponsive(Form nuevo)
        {
            // Cerrar form activo si existe
            if (activeform != null)
                activeform.Close();

            activeform = nuevo;
            nuevo.TopLevel = false;
            nuevo.FormBorderStyle = FormBorderStyle.None;

            // Limpiar panel y agregar nuevo form
            panelpresentacion.Controls.Add(nuevo);
            panelpresentacion.Tag = nuevo;

            // Mostrar form hijo
            nuevo.BringToFront();
            nuevo.Show();

            // Ajustar tamaño del panel y del form padre
            AjustarTamanoFormPadre(nuevo);
        }

        // Ajusta el tamaño del Form padre según el tamaño del hijo
        private void AjustarTamanoFormPadre(Form hijo)
        {
            // Tamaño real del form hijo
            int anchoHijo = hijo.Width;
            int altoHijo = hijo.Height;

            // Tamaño extra del Form padre (bordes, menús, barra de título)
            int anchoExtra = this.Width - panelpresentacion.Width;
            int altoExtra = this.Height - panelpresentacion.Height;

            // Nuevo tamaño del panel
            panelpresentacion.Width = anchoHijo;
            panelpresentacion.Height = altoHijo;

            // Nuevo tamaño del Form padre
            int nuevoAnchoPadre = anchoHijo + anchoExtra;
            int nuevoAltoPadre = altoHijo + altoExtra;

            // Limitar tamaño máximo a la pantalla
            int maxAncho = Screen.PrimaryScreen.WorkingArea.Width;
            int maxAlto = Screen.PrimaryScreen.WorkingArea.Height;

            if (nuevoAnchoPadre > maxAncho) nuevoAnchoPadre = maxAncho;
            if (nuevoAltoPadre > maxAlto) nuevoAltoPadre = maxAlto;

            this.Width = nuevoAnchoPadre;
            this.Height = nuevoAltoPadre;

            // Recentrar el form padre en pantalla
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (activeform != null)
            {
                // Ajustar tamaño del panel al tamaño del form padre
                panelpresentacion.Width = this.ClientSize.Width;
                panelpresentacion.Height = this.ClientSize.Height;
                // El hijo siempre llena el panel
                activeform.Dock = DockStyle.Fill;

            }
        }
        private void CentrarFormHijo()
        {
            if (activeform != null)
            {
                int x = Math.Max(0, (panelpresentacion.Width - activeform.Width) / 2);
                int y = Math.Max(0, (panelpresentacion.Height - activeform.Height) / 2);
                activeform.Location = new Point(x, y);
            }
        }

        private void hora_Click(object sender, EventArgs e)
        {

        }

        private void Horafecha_Tick(object sender, EventArgs e)
        {
            hora.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (activeform != null)
            {
                activeform.Close();
                activeform = null;
            }

            // 2. Cerramos submenús abiertos
            hideMenu();

            // 3. Restauramos el tamaño original
            this.Size = tamañoInicialForm;
            panelpresentacion.Size = tamañoInicialPanel;

            // 4. Centramos la ventana
            this.CenterToScreen();
        }

        private void btmedicamento_Click(object sender, EventArgs e)
        {
            abrirformResponsive(new MantenimientoMedicamento());
            hideMenu();
        }

        private void btmedico_Click(object sender, EventArgs e)
        {
            abrirformResponsive(new Mantenimiento_Medico());
            hideMenu();
        }

        private void btpaciente_Click(object sender, EventArgs e)
        {
            abrirformResponsive(new MantenimientoPaciente());
            hideMenu();
        }



        private void btusuario_Click(object sender, EventArgs e)
        {
            abrirformResponsive(new MantenimientoUsuarios());
            hideMenu();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            abrirformResponsive(new MantenimientoAgenda());
            hideMenu();
        }

        private void btnAtencionMedica_Click(object sender, EventArgs e)
        {
            abrirformResponsive(new MantenimientoCita(usuarioSesion));
            hideMenu();
        }

        private void btnAM_Click(object sender, EventArgs e)
        {
            abrirformResponsive(new MantenimientoAtencionMedica());
            hideMenu();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btMiHistorial_Click(object sender, EventArgs e)
        {
            abrirformResponsive(new MiHistorial());
            hideMenu();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            abrirformResponsive(new ReporteCitasrango());
            hideMenu();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            abrirformResponsive(new ReporteCitaMedico());
            hideMenu();
        }

        private void btcerrarsesion_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            abrirformResponsive(new reportecitaestado());
            hideMenu();
        }
    }
}
