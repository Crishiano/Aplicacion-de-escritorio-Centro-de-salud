using CapaLogica;
using CapaModelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Formularios
{
    public partial class MiHistorial : Form
    {
        private CitaLN citaLN = new CitaLN();
        private DetalleRecetaLN detalleLN = new DetalleRecetaLN();
        public MiHistorial()
        {
            InitializeComponent();
            ConfigurarEstiloGrids();
        }

        private void MiHistorial_Load(object sender, EventArgs e)
        {
            CargarCitas();
        }

        private void ConfigurarEstiloGrids()
        {
            // Configuración común para ambos grids
            foreach (var dgv in new[] { dgvCitas, dgvRecetas })
            {
                dgv.ReadOnly = true;
                dgv.MultiSelect = false;
                dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgv.AllowUserToAddRows = false;
                dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void CargarCitas()
        {
            // Usamos el ID del paciente que guardamos en la Sesión al hacer Login
            if (Sesion.UsuarioLogueado?.idPaciente != null)
            {
                int idPac = Sesion.UsuarioLogueado.idPaciente.Value;
                dgvCitas.DataSource = citaLN.ObtenerHistorial(idPac);

                // Ocultar columnas innecesarias de Cita
                OcultarColumnasCita();
            }
        }

        private void OcultarColumnasCita()
        {
            string[] ocultar = { "idCita", "idPaciente", "idAgenda", "idUsuario", "idMedico", "estado", "nombrePaciente", "nombreUsuario" };
            foreach (string col in ocultar)
                if (dgvCitas.Columns.Contains(col)) dgvCitas.Columns[col].Visible = false;

            dgvCitas.Columns["nombreEstado"].HeaderText = "Estado";
            dgvCitas.Columns["nombreMedico"].HeaderText = "Médico";

        }

        

        private void CargarDetalleReceta(int idCita)
        {
            var listaDetalle = detalleLN.ListarPorCita(idCita);
            dgvRecetas.DataSource = listaDetalle;

            if (dgvRecetas.Columns.Contains("idDetalleReceta")) dgvRecetas.Columns["idDetalleReceta"].Visible = false;
            if (dgvRecetas.Columns.Contains("idReceta")) dgvRecetas.Columns["idReceta"].Visible = false;
            if (dgvRecetas.Columns.Contains("idMedicamento")) dgvRecetas.Columns["idMedicamento"].Visible = false;

            dgvRecetas.Columns["nombreMedicamento"].HeaderText = "Medicamento";
        }

        private void dgvCitas_SelectionChanged_1(object sender, EventArgs e)
        {
            // Cada vez que el usuario hace clic o se mueve con las flechas en el grid de citas
            if (dgvCitas.CurrentRow != null)
            {
                Cita citaSeleccionada = (Cita)dgvCitas.CurrentRow.DataBoundItem;
                CargarDetalleReceta(citaSeleccionada.idCita);
            }
        }
    }
}
