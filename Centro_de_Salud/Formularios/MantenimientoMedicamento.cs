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
    public partial class MantenimientoMedicamento : Form
    {
        private MedicamentoLN servicio = new MedicamentoLN();
        private int idMedicamentoSeleccionado = 0;
        public MantenimientoMedicamento()
        {
            InitializeComponent();
            gbxMedicamento.Enabled = false;
            btnGuardar.Enabled = false;
            btnModificar.Enabled = false;
            dgvMedicamentos.CellClick += DgvMedicamentos_CellClick;
            ListarMedicamentos();

        }

        private void DgvMedicamentos_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Evitar clic en encabezados o filas inválidas
            {
                DataGridViewRow fila = dgvMedicamentos.Rows[e.RowIndex];

                idMedicamentoSeleccionado = Convert.ToInt32(fila.Cells[0].Value);
                txtMedicamento.Text = fila.Cells[1].Value.ToString();
                txtPresentacion.Text = fila.Cells[2].Value.ToString();

                gbxMedicamento.Enabled = true;
                btnModificar.Enabled = true;
                btnGuardar.Enabled = false;
            }
        }

        private void ListarMedicamentos()
        {
            dgvMedicamentos.DataSource = null;
            dgvMedicamentos.DataSource = servicio.Listado();
        }


        private void gbxRol_Enter(object sender, EventArgs e)
        {

        }


        private void LimpiarControles()
        {
            txtMedicamento.Clear();
            txtPresentacion.Clear();
        }

        private void FinalizarOperacion()
        {

            LimpiarControles();
            gbxMedicamento.Enabled = false;
            btnModificar.Enabled = false;
            btnGuardar.Enabled = false;
        }

      
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarControles();
            gbxMedicamento.Enabled = true;
            btnGuardar.Enabled = true;
            btnModificar.Enabled = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Medicamento nuevo = new Medicamento
                {
                    nombre = txtMedicamento.Text,
                    presentacion = txtPresentacion.Text

                };

                servicio.Agregar(nuevo);

                MessageBox.Show("Guardado exitosamente", "Correcto",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                ListarMedicamentos();
                FinalizarOperacion(); // igual que en Club
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                Medicamento mod = new Medicamento
                {
                    idMedicamento = idMedicamentoSeleccionado,
                    nombre = txtMedicamento.Text,
                    presentacion = txtPresentacion.Text
                };
                servicio.Modificar(mod);

                MessageBox.Show("¡Modificado con éxito!", "Correcto",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                ListarMedicamentos();
                FinalizarOperacion();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
