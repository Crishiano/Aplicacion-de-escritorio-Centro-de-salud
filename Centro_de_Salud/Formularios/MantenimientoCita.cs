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
    public partial class MantenimientoCita : Form
    {
        private CitaLN servicio = new CitaLN();
        private PacienteLN servicioPa = new PacienteLN();
        private EspecialidadLN servicioEsp = new EspecialidadLN();
        private MedicoLN servicioMed = new MedicoLN();
        private AgendaMedicaLN servicioAgenda = new AgendaMedicaLN();

        private int idCitaSeleccionado = 0;
        private int estadoOriginal = 0;
        private DateOnly fechaCitaSeleccionada;
        private Usuario usuarioSesion;
        private Paciente pacienteSeleccionado = null;
        private Especialidad especialidadSeleccionada = null;
        private Medico medicoSeleccionado = null;
        private AgendaMedica agendaSeleccionada = null;

        public MantenimientoCita(Usuario usuario)
        {
            InitializeComponent();
            this.usuarioSesion = usuario;
            CargarCitas();
            CargarComboEstados();
            CargarEspecialidades();
            txtIdUsuario.Text = usuario.usuario;
            txtIdUsuario.Enabled = false;
        }
        private void CancelarCitasVencidasAlInicio()
        {
            try
            {
                servicio.CancelarCitasVencidas();
            }
            catch (Exception ex)
            {
                // No mostrar error al usuario, solo registrar
                Console.WriteLine($"Error al cancelar citas vencidas: {ex.Message}");
            }
        }

        private void CargarCitas()
        {
            try
            {
                var listaCitas = servicio.Listar();

                dgvCitas.DataSource = listaCitas;

                // Configurar encabezados de columnas
                if (dgvCitas.Columns.Count > 0)
                {
                    // Ocultar columnas de IDs originales
                    dgvCitas.Columns["idPaciente"].Visible = false;
                    dgvCitas.Columns["idMedico"].Visible = false;
                    dgvCitas.Columns["idAgenda"].Visible = false;
                    dgvCitas.Columns["idUsuario"].Visible = false;
                    dgvCitas.Columns["hora"].Visible = true;
                    dgvCitas.Columns["fecha"].Visible = true;
                    dgvCitas.Columns["estado"].Visible = false;
                    dgvCitas.Columns["motivo"].Visible = true;
                    dgvCitas.Columns["nombrePaciente"].HeaderText = "Paciente";
                    dgvCitas.Columns["nombreMedico"].HeaderText = "Medico";
                    dgvCitas.Columns["nombreEspecialidad"].HeaderText = "Especialidad";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarComboEstados()
        {
            cboEstado.Items.Clear();
            cboEstado.Items.Add(new { Text = "Pendiente", Value = 0 });
            cboEstado.Items.Add(new { Text = "Atendida", Value = 1 });
            cboEstado.Items.Add(new { Text = "Cancelada", Value = 2 });
            cboEstado.DisplayMember = "Text";
            cboEstado.ValueMember = "Value";
            cboEstado.SelectedIndex = 0;
        }

        private void CargarEspecialidades()
        {
            try
            {
                cboEspecialidad.Items.Clear();
                cboEspecialidad.Items.Add("-- Seleccione Especialidad --");

                var especialidades = servicioEsp.ListarActivas();

                foreach (var esp in especialidades)
                {
                    cboEspecialidad.Items.Add(esp);
                }

                cboEspecialidad.DisplayMember = "nombre";
                cboEspecialidad.ValueMember = "idEspecialidad";
                cboEspecialidad.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar especialidades: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void cboEspecialidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // Limpiar médicos y agendas
                cboMedico.Items.Clear();
                cboMedico.Items.Add("-- Seleccione Médico --");
                cboMedico.SelectedIndex = 0;

                cboAgenda.Items.Clear();
                cboAgenda.Items.Add("-- Seleccione Agenda --");
                cboAgenda.SelectedIndex = 0;

                txtIdAgenda.Clear();

                if (cboEspecialidad.SelectedIndex > 0)
                {
                    especialidadSeleccionada = cboEspecialidad.SelectedItem as Especialidad;

                    if (especialidadSeleccionada != null)
                    {
                        var medicos = servicioMed.ListadoPorEspecialidad(especialidadSeleccionada.idEspecialidad);

                        if (medicos.Count > 0)
                        {
                            foreach (var med in medicos)
                            {
                                cboMedico.Items.Add(med);
                            }
                        }
                        else
                        {
                            MessageBox.Show("No hay médicos disponibles para esta especialidad",
                                "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    especialidadSeleccionada = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar médicos: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboMedico_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // Limpiar agendas
                cboAgenda.Items.Clear();
                cboAgenda.Items.Add("-- Seleccione Agenda --");
                cboAgenda.SelectedIndex = 0;
                txtIdAgenda.Clear();

                if (cboMedico.SelectedIndex > 0)
                {
                    medicoSeleccionado = cboMedico.SelectedItem as Medico;

                    if (medicoSeleccionado != null)
                    {
                        var agendas = servicioAgenda.ListarPorMedico(medicoSeleccionado.idMedico);

                        if (agendas.Count > 0)
                        {
                            foreach (var agenda in agendas)
                            {
                                cboAgenda.Items.Add(agenda);
                            }
                        }
                        else
                        {
                            MessageBox.Show("No hay agendas disponibles para este médico",
                                "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    medicoSeleccionado = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"No hay cupos disponibles: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboAgenda_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboAgenda.SelectedIndex > 0)
            {
                agendaSeleccionada = cboAgenda.SelectedItem as AgendaMedica;

                if (agendaSeleccionada != null)
                {
                    txtIdAgenda.Text = agendaSeleccionada.idAgenda.ToString();
                    dtpFecha.Value = agendaSeleccionada.fecha.ToDateTime(TimeOnly.MinValue);
                }
            }
            else
            {
                agendaSeleccionada = null;
                txtIdAgenda.Clear();
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validaciones
                if (pacienteSeleccionado == null)
                {
                    MessageBox.Show("Debe buscar y seleccionar un paciente válido",
                        "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (especialidadSeleccionada == null || cboEspecialidad.SelectedIndex == 0)
                {
                    MessageBox.Show("Debe seleccionar una especialidad",
                        "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (medicoSeleccionado == null || cboMedico.SelectedIndex == 0)
                {
                    MessageBox.Show("Debe seleccionar un médico",
                        "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (agendaSeleccionada == null || cboAgenda.SelectedIndex == 0)
                {
                    MessageBox.Show("Debe seleccionar una agenda",
                        "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                


                TimeOnly hora;
                if (!TimeOnly.TryParse(dtpHora.Value.ToString("HH:mm"), out hora))
                {
                    MessageBox.Show("La hora no es válida",
                        "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DateOnly fecha = DateOnly.FromDateTime(dtpFecha.Value);
                string mensajeValidacion;
                bool horarioDisponible = servicio.ValidarDisponibilidadHorario(
                    medicoSeleccionado.idMedico,
                    fecha,
                    hora,
                    out mensajeValidacion);

                if (!horarioDisponible)
                {
                    MessageBox.Show(
                        $"⚠️ Conflicto de Horario\n\n{mensajeValidacion}\n\n" +
                        "Por favor, seleccione otra hora con al menos 1 hora de diferencia.",
                        "Horario No Disponible",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                bool horaValida = servicioMed.HoraDentroDeHorario(
                        medicoSeleccionado.idMedico,
                        fecha,
                        hora);

                if (!horaValida)
                {
                    MessageBox.Show(
                        "⛔ La hora seleccionada no está dentro del horario del médico.\n\n" +
                        "Seleccione una hora válida según su horario asignado.",
                        "Horario inválido",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                // Siempre registrar como Pendiente (estado = 0)
                servicio.Agregar(new Cita()
                {
                    idPaciente = pacienteSeleccionado.idPaciente,
                    idAgenda = agendaSeleccionada.idAgenda,
                    idMedico = medicoSeleccionado.idMedico,
                    hora = hora,
                    fecha = fecha,
                    idUsuario = usuarioSesion.idUsuario,
                    estado = 0,  // Siempre Pendiente al registrar
                    motivo = string.IsNullOrWhiteSpace(txtMotivo.Text) ? null : txtMotivo.Text
                });

                MessageBox.Show(
                    "✅ Cita registrada exitosamente\n\n" +
                    $"📅 Fecha: {fecha:dd/MM/yyyy}\n" +
                    $"⏰ Hora: {hora:HH:mm}\n" +
                    $"👨‍⚕️ Médico: {medicoSeleccionado.NombreDisplay}",
                    "Registro Exitoso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                

                CargarCitas();
                LimpiarControles();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (idCitaSeleccionado == 0)
                {
                    MessageBox.Show("Debe seleccionar una cita",
                        "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                int estadoSeleccionado = ((dynamic)cboEstado.SelectedItem).Value;


                servicio.Modificar(new Cita()
                {
                    idCita = idCitaSeleccionado,
                    estado = ((dynamic)cboEstado.SelectedItem).Value,
                    motivo = string.IsNullOrWhiteSpace(txtMotivo.Text) ? null : txtMotivo.Text
                });

                MessageBox.Show("Modificación exitosa",
                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                CargarCitas();
                LimpiarControles();
                btnRegistrar.Enabled = true;
                btnModificar.Enabled = false;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarControles();
            btnModificar.Enabled = false;
            btnRegistrar.Enabled = true;
            gboDatos.Enabled = true;
        }

        private void btnBuscarDNI_Click(object sender, EventArgs e)
        {
            string dni = txtDNI.Text.Trim();

            if (string.IsNullOrEmpty(dni))
            {
                MessageBox.Show("Ingrese un DNI válido",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                pacienteSeleccionado = servicioPa.BuscarPacienteXDNI(dni);

                if (pacienteSeleccionado != null)
                {
                    txtPaciente.Text = $"{pacienteSeleccionado.nombres} {pacienteSeleccionado.apellidoPat} {pacienteSeleccionado.apellidoMat}";
                    MessageBox.Show("Paciente encontrado",
                        "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Paciente no encontrado",
                        "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPaciente.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar paciente: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LimpiarControles()
        {
            txtDNI.Clear();
            txtPaciente.Clear();
            txtIdAgenda.Clear();
            txtMotivo.Clear();

            cboEspecialidad.SelectedIndex = 0;
            cboMedico.Items.Clear();
            cboMedico.Items.Add("-- Seleccione Médico --");
            cboMedico.SelectedIndex = 0;

            cboAgenda.Items.Clear();
            cboAgenda.Items.Add("-- Seleccione Agenda --");
            cboAgenda.SelectedIndex = 0;

            dtpHora.Value = DateTime.Now;
            dtpFecha.Value = DateTime.Now;
            cboEstado.SelectedIndex = 0;

            idCitaSeleccionado = 0;
            pacienteSeleccionado = null;
            especialidadSeleccionada = null;
            medicoSeleccionado = null;
            agendaSeleccionada = null;
        }

        private void dgvCitas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    int fila = e.RowIndex;

                    idCitaSeleccionado = Convert.ToInt32(dgvCitas.Rows[fila].Cells["idCita"].Value);

                    // Cargar datos del paciente
                    txtPaciente.Text = dgvCitas.Rows[fila].Cells["nombrePaciente"].Value?.ToString();

                    // Cargar otros datos
                    txtIdAgenda.Text = dgvCitas.Rows[fila].Cells["idAgenda"].Value?.ToString();

                    // Manejo seguro de TimeOnly
                    var horaCell = dgvCitas.Rows[fila].Cells["hora"].Value;
                    if (horaCell != null && horaCell is TimeOnly horaValue)
                    {
                        dtpHora.Value = DateTime.Today.Add(horaValue.ToTimeSpan());
                    }

                    // Manejo de fecha
                    var fechaCell = dgvCitas.Rows[fila].Cells["fecha"].Value;
                    if (fechaCell != null && fechaCell is DateOnly fechaValue)
                    {
                        dtpFecha.Value = fechaValue.ToDateTime(TimeOnly.MinValue);
                        fechaCitaSeleccionada = fechaValue;
                    }

                    // Cargar estado
                    string estadoValue = dgvCitas.Rows[e.RowIndex]
                            .Cells["nombreEstado"].Value.ToString();

                    // Cargar motivo
                    txtMotivo.Text = dgvCitas.Rows[fila].Cells["motivo"].Value?.ToString() ?? "";

                    btnModificar.Enabled = true;
                    btnRegistrar.Enabled = false;

                    if (estadoValue == "Cancelado" || estadoValue == "Atendido")
                    {
                        btnModificar.Enabled = false;
                        gboDatos.Enabled = false;
                    }
                    else
                    {
                        btnModificar.Enabled = true;
                        gboDatos.Enabled = true;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar datos: {ex.Message}",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void cboEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Solo validar si hay una cita seleccionada
            if (idCitaSeleccionado == 0)
                return;

            int nuevoEstado = ((dynamic)cboEstado.SelectedItem).Value;

            // Si está cambiando a Cancelada (2)
            if (nuevoEstado == 2 && estadoOriginal != 2)
            {
                // Validar que sea al menos 1 día antes
                int diasAntes = (fechaCitaSeleccionada.ToDateTime(TimeOnly.MinValue) - DateTime.Now.Date).Days;

                if (diasAntes < 1)
                {
                    MessageBox.Show(
                        "❌ No se puede cancelar la cita\n\n" +
                        "La cita debe cancelarse al menos 1 día antes de la fecha programada.\n\n" +
                        $"Fecha de la cita: {fechaCitaSeleccionada:dd/MM/yyyy}\n" +
                        $"Días restantes: {diasAntes}",
                        "Cancelación No Permitida",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    // Restaurar el estado original
                    cboEstado.SelectedIndex = estadoOriginal;
                    return;
                }

                // Solicitar confirmación
                DialogResult confirmacion = MessageBox.Show(
                    $"¿Está seguro que desea CANCELAR esta cita?\n\n" +
                    $"📅 Fecha: {fechaCitaSeleccionada:dd/MM/yyyy}\n" +
                    $"⏰ Días de anticipación: {diasAntes}\n\n" +
                    "✓ El cupo se recuperará automáticamente",
                    "Confirmar Cancelación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirmacion == DialogResult.No)
                {
                    // Restaurar estado original
                    cboEstado.SelectedIndex = estadoOriginal;
                    return;
                }
            }
        }
    }
}