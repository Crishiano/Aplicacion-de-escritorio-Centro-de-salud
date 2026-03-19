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
    public partial class Mantenimiento_Medico : Form
    {
        private MedicoLN servicio = new MedicoLN();
        private int idMedicoSeleccionado = 0;


        public Mantenimiento_Medico()
        {
            InitializeComponent();
            gbxDatos.Enabled = false;
            btnRegistrar.Enabled = false;
            btnModificar.Enabled = false;
            dgvMedicos.CellClick += DgvMedicos_CellClick;
            btnHorarioDisponibles.Enabled = false;
            ListarMedico();
            CargarCombos();
        }

        private void DgvMedicos_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Evitar clic en encabezados o filas inválidas
            {
                DataGridViewRow fila = dgvMedicos.Rows[e.RowIndex];

                idMedicoSeleccionado = Convert.ToInt32(fila.Cells[0].Value);
                txtNombres.Text = fila.Cells[2].Value.ToString();
                txtCMP.Text = fila.Cells[1].Value.ToString();
                txtApellidoPaterno.Text = fila.Cells[3].Value.ToString();
                txtApellidoMaterno.Text = fila.Cells[4].Value.ToString();
                cmbEspecialidad.Text = fila.Cells[6].Value.ToString();
                chkEstado.Checked = Convert.ToBoolean(fila.Cells[5].Value);
                gbxDatos.Enabled = true;
                btnModificar.Enabled = true;
                btnRegistrar.Enabled = false;
                btnHorarioDisponibles.Enabled = true;
            }
        }

        private void ListarMedico()
        {
            dgvMedicos.DataSource = null;
            dgvMedicos.DataSource = servicio.Listado();
            dgvMedicos.Columns["idEspecialidad"].Visible = false;
            dgvMedicos.Columns["nombreCompleto"].Visible = false;
            dgvMedicos.Columns["NombreDisplay"].Visible = false;
            if (dgvMedicos.Columns.Contains("estado"))
                dgvMedicos.Columns["estado"].Visible = false;
            if (dgvMedicos.Columns.Contains("EstadoTexto"))
                dgvMedicos.Columns["EstadoTexto"].HeaderText = "Estado";

        }


        private void MantenimientoMedico_Load(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void LimpiarControles()
        {
            txtNombres.Clear();
            txtApellidoPaterno.Clear();
            txtApellidoMaterno.Clear();
            txtCMP.Clear();
            cmbEspecialidad.SelectedIndex = -1;
            chkEstado.Checked = false;

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            gbxDatos.Enabled = true;
            btnRegistrar.Enabled = true;
            btnModificar.Enabled = false;
            btnHorarioDisponibles.Enabled = false;
            idMedicoSeleccionado = 0;
            LimpiarControles();
        }

        private void FinalizarOperacion()
        {

            LimpiarControles();
            gbxDatos.Enabled = false;
            btnModificar.Enabled = false;
            btnRegistrar.Enabled = false;
            btnHorarioDisponibles.Enabled = false;

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {


        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void CargarCombos()
        {
            EspecialidadLN especialidadLN = new EspecialidadLN();
            cmbEspecialidad.DataSource = especialidadLN.Listado();
            cmbEspecialidad.DisplayMember = "nombre";
            cmbEspecialidad.ValueMember = "idEspecialidad";
            cmbEspecialidad.SelectedIndex = -1;


        }

        private void btnRegistrar_Click_1(object sender, EventArgs e)
        {
            try
            {
                Medico medico = new Medico()
                {
                    cmp = txtCMP.Text,
                    nombres = txtNombres.Text,
                    apellidoPat = txtApellidoPaterno.Text,
                    apellidoMat = txtApellidoMaterno.Text,
                    estado = chkEstado.Checked,

                };

                if (cmbEspecialidad.SelectedValue != null)
                {
                    medico.idEspecialidad = Convert.ToInt32(cmbEspecialidad.SelectedValue);
                }

                servicio.Agregar(medico);

                MessageBox.Show("Guardado exitosamente", "Correcto",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                ListarMedico();
                FinalizarOperacion(); // igual que en Club
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            try
            {
                Medico mod = new Medico()
                {
                    idMedico = idMedicoSeleccionado,
                    cmp = txtCMP.Text,
                    nombres = txtNombres.Text,
                    apellidoPat = txtApellidoPaterno.Text,
                    apellidoMat = txtApellidoMaterno.Text,
                    estado = chkEstado.Checked,
                };

                if (cmbEspecialidad.SelectedValue != null)
                {
                    mod.idEspecialidad = Convert.ToInt32(cmbEspecialidad.SelectedValue);
                }

                servicio.Modificar(mod);

                MessageBox.Show("¡Modificado con éxito!", "Correcto",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                ListarMedico();
                FinalizarOperacion();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnHorarioDisponibles_Click(object sender, EventArgs e)
        {
            MantenimientoHorarioMedico frm = new MantenimientoHorarioMedico(idMedicoSeleccionado);
            frm.ShowDialog();
        }

      
    }
}
