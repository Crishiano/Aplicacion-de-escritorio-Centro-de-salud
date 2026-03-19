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
    public partial class MantenimientoAgenda : Form
    {
        AgendaMedicaLN servicio = new AgendaMedicaLN();
        HorarioMedicoLN servicioHorario = new HorarioMedicoLN();
        MedicoLN sericioMedico = new MedicoLN();
        private int idagendamedica;
        //private int idEspecialidad;
        public MantenimientoAgenda()
        {
            InitializeComponent();
            btnGuardar.Enabled = false;
            btnModificar.Enabled = false;
            CargarCombos();
            ListarAgenda();
            CargarDatos();
            dgvAgenda.CellClick += DgvAgenda_CellClick;
        }
        private void CargarDatos()
        {
            try
            {
                var listaCitas = servicio.Listado();
                dgvAgenda.DataSource = listaCitas;

                // Configurar encabezados de columnas
                if (dgvAgenda.Columns.Count > 0)
                {
                    dgvAgenda.Columns["idEspecialidad"].Visible = false;
                    dgvAgenda.Columns["cuposOcupados"].Visible = false;
                    dgvAgenda.Columns["cuposDisponibles"].Visible = false;
                    dgvAgenda.Columns["descripcionAgenda"].Visible = false;
                    dgvAgenda.Columns["NombreDisplay"].Visible = false;
                    dgvAgenda.Columns["idAgenda"].HeaderText = "ID";
                    dgvAgenda.Columns["fecha"].HeaderText = "Fecha";
                    dgvAgenda.Columns["cupos"].HeaderText = "Cupos";
                    dgvAgenda.Columns["nombreEspecialidad"].HeaderText = "Especialidad";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DgvAgenda_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                DataGridViewRow fila = dgvAgenda.Rows[e.RowIndex];
                idagendamedica = Convert.ToInt32(fila.Cells[0].Value);
                DateOnly fecha = (DateOnly)fila.Cells[1].Value;
                dtfecha.Value = fecha.ToDateTime(TimeOnly.MinValue);
                txtcupo.Text = fila.Cells[2].Value.ToString();
                cbespecialidad.SelectedValue = Convert.ToInt32(fila.Cells[3].Value);

                btnModificar.Enabled = true;
                btnGuardar.Enabled = false;
            }
        }

        private void CargarCombos()
        {
            EspecialidadLN especialidadLN = new EspecialidadLN();
            cbespecialidad.DataSource = especialidadLN.ListarActivas();
            cbespecialidad.DisplayMember = "nombre";
            cbespecialidad.ValueMember = "idEspecialidad";
            if (cbespecialidad.Items.Count > 0)
                cbespecialidad.SelectedIndex = -1;


        }

        private void ListarAgenda()
        {
            dgvAgenda.DataSource = null;
            dgvAgenda.DataSource = servicio.Listado();

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!servicio.validacion(Convert.ToInt32(cbespecialidad.SelectedValue), DateOnly.FromDateTime(dtfecha.Value)))
                {
                    if (dtfecha.Value.Date < DateTime.Today)
                    {
                        MessageBox.Show("No puede registrar una fecha pasada.",
                            "Validación",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;
                    }
                    if (cbespecialidad.SelectedItem is not Especialidad esp)
                    {
                        MessageBox.Show("Seleccione una especialidad.");
                        return;
                    }

                    bool existeAgenda = servicio.validacion(
                        esp.idEspecialidad,
                        DateOnly.FromDateTime(dtfecha.Value));

                    if (existeAgenda)
                    {
                        MessageBox.Show("La especialidad ya está registrada en esa fecha.");
                        return;
                    }

                    int diaSemana = (int)dtfecha.Value.DayOfWeek;

                    if (diaSemana == 0)
                        diaSemana = 7;

                    bool hayMedico = sericioMedico.ExisteMedicoDisponible(
                        esp.idEspecialidad,
                        diaSemana);

                    if (!hayMedico)
                    {
                        MessageBox.Show("No hay médicos disponibles ese día para esta especialidad.",
                            "Validación",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;
                    }
                    AgendaMedica nuevo = new AgendaMedica
                    {
                        fecha = DateOnly.FromDateTime(dtfecha.Value),
                        cupos = int.Parse(txtcupo.Text),
                        idEspecialidad = Convert.ToInt32(cbespecialidad.SelectedValue)
                    };

                    servicio.Agregar(nuevo);

                    MessageBox.Show("Guardado exitosamente", "Correcto",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ListarAgenda(); 
                    FinalizarOperacion();
                }
                else
                {
                    MessageBox.Show("especilidad ya registrada en esa fecha");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void FinalizarOperacion()
        {
            btnModificar.Enabled = false;
            btnGuardar.Enabled = false;
        }
        private void LimpiarControles()
        {
            txtcupo.Clear();               
            dtfecha.Value = DateTime.Today; 
            if (cbespecialidad.Items.Count > 0)
                cbespecialidad.SelectedIndex = -1;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                AgendaMedica mod = new AgendaMedica
                {
                    idAgenda = idagendamedica,
                    fecha = DateOnly.FromDateTime(dtfecha.Value),
                    cupos = Convert.ToInt32(txtcupo.Text),
                    idEspecialidad = Convert.ToInt32(cbespecialidad.SelectedValue)
                };

                servicio.Modificar(mod);

                MessageBox.Show("¡Modificado con éxito!", "Correcto",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                ListarAgenda();  
                FinalizarOperacion(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarControles();
            btnGuardar.Enabled = true;
            btnModificar.Enabled = false;
            gboDatos.Enabled = true;
        }

        private void dtfecha_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dgvAgenda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvHorario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void cargarHorario()
        {
            try
            {
                if (cbespecialidad.SelectedItem is Especialidad esp)
                {
                    var listaH = sericioMedico.ListarTodo(esp.idEspecialidad);
                    dgvHorario.DataSource = listaH;

                    if (dgvHorario.Columns.Count > 0)
                    {
                        dgvHorario.Columns["idmedico"].Visible = false;
                        dgvHorario.Columns["HoraInicio"].Visible = false;
                        dgvHorario.Columns["HoraFin"].Visible = false;
                        dgvHorario.Columns["idHorarioMedico"].HeaderText = "ID";
                        dgvHorario.Columns["DiaSemana"].HeaderText = "Día";
                        dgvHorario.Columns["nombreMedico"].HeaderText = "Medico";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbespecialidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarHorario();
        }
    }
}
