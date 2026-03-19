using CapaDatos;
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
    public partial class MantenimientoAtencionMedica : Form
    {
        private AtencionMedicaLN servicio = new AtencionMedicaLN();
        private CitaLN servicioCita = new CitaLN();
        private int idAtencionSeleccionado = 0;

        public MantenimientoAtencionMedica()
        {


            InitializeComponent();
            CargarAtenciones();
            if (Sesion.UsuarioLogueado.Rol != (int)Usuario.RolUsuario.Medico)
            {
                MessageBox.Show("Acceso denegado. Solo los médicos pueden entrar aquí.");
                this.Close(); // Cerramos el formulario de inmediato
            }
            txtDiagnostico.Enabled = true;
            txtObservaciones.Enabled = true;

            LimpiarControles();
        }

        private void CargarAtenciones()
        {
            try
            {
                var listaAtenciones = servicio.Listar();
                dgvAtenciones.DataSource = listaAtenciones;

                // Configurar encabezados de columnas
                if (dgvAtenciones.Columns.Count > 0)
                {
                    dgvAtenciones.Columns["idAtencion"].HeaderText = "ID";
                    dgvAtenciones.Columns["idCita"].HeaderText = "ID Cita";
                    dgvAtenciones.Columns["diagnostico"].HeaderText = "Diagnóstico";
                    dgvAtenciones.Columns["observaciones"].HeaderText = "Observaciones";
                    dgvAtenciones.Columns["fechaAtencion"].HeaderText = "Fecha Atención";
                    dgvAtenciones.Columns["fechaAtencion"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
                    dgvAtenciones.Columns["nombrePaciente"].HeaderText = "Paciente";
                    dgvAtenciones.Columns["nombreMedico"].HeaderText = "Medico";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validaciones
                if (string.IsNullOrWhiteSpace(txtIdCita.Text))
                {
                    MessageBox.Show("Debe ingresar el ID de la cita", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (dtpFechaAtencion.Value.Date != DateTime.Today)
                {
                    MessageBox.Show("La fecha de atencion no puede ser diferente a hoy", "Validación");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtDiagnostico.Text))
                {
                    MessageBox.Show("Debe ingresar el diagnóstico", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                int idCita = Convert.ToInt32(txtIdCita.Text);
                servicio.Agregar(new AtencionMedica()
                {
                    idCita = idCita,
                    diagnostico = txtDiagnostico.Text.Trim(),
                    observaciones = txtObservaciones.Text.Trim(),
                    fechaAtencion = dtpFechaAtencion.Value
                });

                try
                {
                    servicioCita.CambiarEstadoAtendida(idCita);
                }
                catch (Exception exCita)
                {
                    // Si falla el cambio de estado, mostrar advertencia pero no cancelar el registro
                    MessageBox.Show($"Atención registrada, pero hubo un error al actualizar el estado de la cita: {exCita.Message}",
                        "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                MessageBox.Show("Atención médica registrada exitosamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarAtenciones();
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
                if (idAtencionSeleccionado == 0)
                {
                    MessageBox.Show("Debe seleccionar una atención médica", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (dtpFechaAtencion.Value.Date != DateTime.Today)
                {
                    MessageBox.Show("La fecha de atencion no puede ser diferente a hoy", "Validación");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtDiagnostico.Text))
                {
                    MessageBox.Show("Debe ingresar el diagnóstico", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                servicio.Modificar(new AtencionMedica()
                {
                    idAtencion = idAtencionSeleccionado,
                    idCita = Convert.ToInt32(txtIdCita.Text),
                    diagnostico = txtDiagnostico.Text.Trim(),
                    observaciones = txtObservaciones.Text.Trim(),
                    fechaAtencion = dtpFechaAtencion.Value
                });

                MessageBox.Show("Modificación exitosa", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarAtenciones();
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
            txtIdCita.Enabled = true;
            txtDiagnostico.Enabled = true;
            txtObservaciones.Enabled = true;
        }

        private void LimpiarControles()
        {
            txtIdCita.Clear();
            txtDiagnostico.Clear();
            txtObservaciones.Clear();
            dtpFechaAtencion.Value = DateTime.Now;
            idAtencionSeleccionado = 0;
            txtDiagnostico.Enabled = true;
            txtObservaciones.Enabled = true;
        }

        private void dgvAtenciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Usamos DataBoundItem para evitar el error de "Columna no encontrada"
                var seleccionada = (AtencionMedica)dgvAtenciones.Rows[e.RowIndex].DataBoundItem;

                if (seleccionada != null)
                {
                    idAtencionSeleccionado = seleccionada.idAtencion; // ¡Importante!
                    txtIdCita.Text = seleccionada.idCita.ToString();
                    txtDiagnostico.Text = seleccionada.diagnostico;
                    txtObservaciones.Text = seleccionada.observaciones;
                    txtMedico.Text = seleccionada.nombreMedico;
                    dtpFechaAtencion.Value = seleccionada.fechaAtencion;

                    // Al hacer clic para editar/ver, bloqueamos el registro de nuevas
                    txtIdCita.Enabled = false;
                    btnRegistrar.Enabled = false;

                    // Solo permitimos modificar si la cita está marcada como atendida (estado 1) 
                    // pero el médico quiere corregir algo.
                    btnModificar.Enabled = true;
                }
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtIdCita.Text))
                {
                    MessageBox.Show("Debe ingresar el ID de la cita", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int idCita = Convert.ToInt32(txtIdCita.Text);
                Cita cita = servicioCita.ObtenerDetalle(idCita);

                if (cita == null)
                {
                    MessageBox.Show("No se encontró la cita con el ID especificado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMedico.Text = "";
                    dtpFechaAtencion.Value = DateTime.Now;
                    return;
                }

                // --- BLOQUE DE SEGURIDAD ---
                // Verificamos si la cita le pertenece al médico logueado
                if (Sesion.UsuarioLogueado.idMedico.HasValue)
                {
                    int idMedicoLogueado = Sesion.UsuarioLogueado.idMedico.Value;

                    if (cita.idMedico != idMedicoLogueado)
                    {
                        MessageBox.Show("Acceso denegado: Esta cita está asignada a otro médico.\n" +
                                        "No puede registrar atenciones de pacientes que no le corresponden.",
                                        "Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        LimpiarControles();
                        return; // Cortamos la ejecución aquí
                    }
                }

                // Verificar si la cita ya está atendida
                if (cita.estado == 1)
                {
                    MessageBox.Show("Esta cita ya ha sido atendida", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (cita.estado == 2)
                {
                    MessageBox.Show("Esta cita ha sido cancelada", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Mostrar información del médico
                if (!string.IsNullOrEmpty(cita.nombreMedico))
                {
                    string infoMedico = cita.nombreMedico;
                    if (!string.IsNullOrEmpty(cita.nombreEspecialidad))
                    {
                        infoMedico += $" - {cita.nombreEspecialidad}";
                    }
                    txtMedico.Text = infoMedico;
                }
                else
                {
                    txtMedico.Text = "Sin médico asignado";
                }

                // Cargar la fecha y hora de la cita en el DateTimePicker
                txtMedico.Text = cita.nombreMedico;
                DateTime fechaCita = cita.fecha.ToDateTime(cita.hora);
                dtpFechaAtencion.Value = fechaCita;

                btnRegistrar.Enabled = (cita.estado == 0);
                if (cita.estado != 0) MessageBox.Show("Esta cita ya fue procesada anteriormente.");

                MessageBox.Show($"Cita encontrada:\n" +
                               $"Paciente: {cita.nombrePaciente}\n" +
                               $"Fecha: {cita.fecha:dd/MM/yyyy}\n" +
                               $"Hora: {cita.hora:HH:mm}\n" +
                               $"Médico: {(string.IsNullOrEmpty(cita.nombreMedico) ? "Sin asignar" : cita.nombreMedico)}",
                               "Información de la Cita", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FormatException)
            {
                MessageBox.Show("El ID de la cita debe ser un número válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar la cita: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReceta_Click(object sender, EventArgs e)
        {
            if (idAtencionSeleccionado > 0)
            {
                MantenimientoReceta frmReceta = new MantenimientoReceta(idAtencionSeleccionado, dtpFechaAtencion.Value);
                frmReceta.StartPosition = FormStartPosition.CenterParent;
                frmReceta.ShowDialog(this);
            }
            else
            {
                MessageBox.Show("Seleccione una atención de la lista primero.");
            }
        }

        private void MantenimientoAtencionMedica_Load(object sender, EventArgs e)
        {
            txtMedico.Text = Sesion.UsuarioLogueado.usuario; // O el nombre real si lo tienes en Sesion
            txtMedico.ReadOnly = true;
            RefrescarGrid();
        }

        private void RefrescarGrid()
        {
            try
            {
                if (Sesion.UsuarioLogueado?.idMedico != null)
                {
                    int idMed = Sesion.UsuarioLogueado.idMedico.Value;
                    // Usamos el nuevo método que filtra por médico
                    var lista = servicio.ListarPorMedico(idMed);
                    dgvAtenciones.DataSource = null; // Limpiamos
                    dgvAtenciones.DataSource = lista;

                    if (dgvAtenciones.Columns.Count > 0)
                    {
                        // Ocultamos columnas de IDs que el médico no necesita ver pero el código sí usa
                        if (dgvAtenciones.Columns["idAtencion"] != null) dgvAtenciones.Columns["idAtencion"].Visible = false;
                        if (dgvAtenciones.Columns["idCita"] != null) dgvAtenciones.Columns["idCita"].HeaderText = "N° Cita";
                        // ... el resto de tus cabeceras
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar historial: " + ex.Message);
            }
        }

        private void dgvAtenciones_SelectionChanged(object sender, EventArgs e)
        {
            // Verificamos que haya una fila seleccionada y que el objeto no sea nulo
            //if (dgvAtenciones.CurrentRow != null && dgvAtenciones.CurrentRow.DataBoundItem is AtencionMedica seleccionada)
            //{
            //    // 1. Cargamos los datos en los campos de texto
            //    txtIdCita.Text = seleccionada.idCita.ToString();
            //    txtDiagnostico.Text = seleccionada.diagnostico;
            //    txtObservaciones.Text = seleccionada.observaciones;
            //    txtMedico.Text = seleccionada.nombreMedico;

            //    // 2. Lógica de Seguridad/UX según el estado de la CITA
            //    // 0 = Pendiente, 1 = Atendida, 2 = Cancelada
            //    if (seleccionada.estadoCita != 0)
            //    {
            //        btnRegistrar.Enabled = false; // Ya no se puede crear/modificar
            //        btnModificar.Enabled = false;
            //        btnReceta.Text = "Ver Receta"; // Modo consulta

            //        txtDiagnostico.ReadOnly = true;
            //        txtObservaciones.ReadOnly = true;
            //        dtpFechaAtencion.Enabled = false;
            //    }
            //    else
            //    {
            //        btnRegistrar.Enabled = true;
            //        btnModificar.Enabled = true;
            //        btnReceta.Text = "Generar Receta"; // Modo edición

                    
            //    }
            //}
        }
    }
}
