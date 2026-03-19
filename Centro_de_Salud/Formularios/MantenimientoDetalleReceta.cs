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
    public partial class MantenimientoDetalleReceta : Form
    {
        private readonly DetalleRecetaLN detalleServicio = new DetalleRecetaLN();
        private readonly MedicamentoLN medicamentoLN = new MedicamentoLN();
        private int _idReceta;
        private int iddetalle;
        public MantenimientoDetalleReceta(int idReceta)
        {
            InitializeComponent();
            this._idReceta = idReceta;
            dgvDetalles.CellClick += DgvDetalles_CellClick;

            CargarCombos();
            CargarDetallesGrid();
        }

        private void DgvDetalles_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Evitar clic en encabezados o filas inválidas
            {
                DataGridViewRow fila = dgvDetalles.Rows[e.RowIndex];

                // Asignamos el id del detalle de receta a la variable de clase
                iddetalle = Convert.ToInt32(fila.Cells["idDetalleReceta"].Value);

                // Asignamos el id del medicamento al ComboBox
                int idMedicamento = Convert.ToInt32(fila.Cells["idMedicamento"].Value);
                cboMedicamento.SelectedValue = idMedicamento;

                // Asignamos los demás campos a los TextBox
                txtDosis.Text = fila.Cells["dosis"].Value.ToString();
                txtFrecuencia.Text = fila.Cells["frecuencia"].Value.ToString();
                txtDuracion.Text = fila.Cells["duracion"].Value.ToString();
                txtIndicaciones.Text = fila.Cells["indicaciones"].Value.ToString();

                // Activar el grupo de datos y botones
                btnModificar.Enabled = true;
                btnGuardar.Enabled = false;
            }
        }

        private void CargarCombos()
        {
            try
            {
                cboMedicamento.DataSource = medicamentoLN.Listado(); // Ajusta según tu método de Medicamento
                cboMedicamento.DisplayMember = "nombre";
                cboMedicamento.ValueMember = "idMedicamento";
                cboMedicamento.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar medicamentos: " + ex.Message);
            }
        }

        private void CargarDetallesGrid()
        {
            try
            {
                // Usamos el método que creamos en la capa de datos para filtrar por receta
                dgvDetalles.DataSource = detalleServicio.ListarPorReceta(_idReceta);

                // Ocultamos IDs técnicos
                if (dgvDetalles.Columns["idDetalleReceta"] != null) dgvDetalles.Columns["idDetalleReceta"].Visible = false;
                if (dgvDetalles.Columns["idReceta"] != null) dgvDetalles.Columns["idReceta"].Visible = false;
                if (dgvDetalles.Columns["idMedicamento"] != null) dgvDetalles.Columns["idMedicamento"].Visible = false;

                // Ponemos nombres bonitos a las columnas
                dgvDetalles.Columns["nombreMedicamento"].HeaderText = "Medicamento";
                dgvDetalles.Columns["dosis"].HeaderText = "Dosis";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el listado: " + ex.Message);
            }
        }

        private void LimpiarCamposMedicamento()
        {
            cboMedicamento.SelectedIndex = -1;
            txtDosis.Clear();
            txtFrecuencia.Clear();
            txtDuracion.Clear();
            txtIndicaciones.Clear();
            cboMedicamento.Focus();
            txtmedicamento.Text = "";

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                DetalleReceta mod = new DetalleReceta()
                {
                    idDetalleReceta = iddetalle,
                    idReceta = _idReceta, // Usamos la variable de clase
                    idMedicamento = (int)cboMedicamento.SelectedValue,
                    dosis = txtDosis.Text.Trim(),
                    frecuencia = txtFrecuencia.Text.Trim(),
                    duracion = txtDuracion.Text.Trim(),
                    indicaciones = txtIndicaciones.Text.Trim()
                };



                detalleServicio.Modificar(mod);

                MessageBox.Show("¡Modificado con éxito!", "Correcto",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                btnGuardar.Enabled = true;
                btnModificar.Enabled = false;
                CargarDetallesGrid();
                LimpiarCamposMedicamento();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            CargarCombos();
            LimpiarCamposMedicamento();
            btnGuardar.Enabled = true;
            btnModificar.Enabled = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboMedicamento.SelectedValue == null)
                {
                    MessageBox.Show("Por favor, seleccione un medicamento.");
                    return;
                }

                detalleServicio.Agregar(new DetalleReceta()
                {
                    idReceta = _idReceta, // Usamos la variable de clase
                    idMedicamento = (int)cboMedicamento.SelectedValue,
                    dosis = txtDosis.Text.Trim(),
                    frecuencia = txtFrecuencia.Text.Trim(),
                    duracion = txtDuracion.Text.Trim(),
                    indicaciones = txtIndicaciones.Text.Trim()
                });

                MessageBox.Show("Medicamento añadido a la receta.");
                CargarDetallesGrid();
                LimpiarCamposMedicamento();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            int index = cboMedicamento.FindStringExact(txtmedicamento.Text.Trim());
            if (index >= 0)
            {
                cboMedicamento.SelectedIndex = index;
            }
            else
            {
                MessageBox.Show("Medicamento no encontrado en la lista.");
                cboMedicamento.SelectedIndex = -1;

            }
        }
    }
}
