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
    public partial class MantenimientoEspecialidades : Form
    {

        private EspecialidadLN servicio = new EspecialidadLN();
        private int idEspecialidadSeleccionado = 0;

        public MantenimientoEspecialidades()
        {
            InitializeComponent();
            gbxDatos.Enabled = false;
            btnGuardar.Enabled = false;
            btnModificar.Enabled = false;
            dgvEspecialidades.CellClick += DgvEspecialidades_CellClick;
           
            ListarEspecialidades();
        }

        private void DgvEspecialidades_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Evitar clic en encabezados o filas inválidas
            {
                DataGridViewRow fila = dgvEspecialidades.Rows[e.RowIndex];

                idEspecialidadSeleccionado = Convert.ToInt32(fila.Cells[0].Value);
                txtDescripcion.Text = fila.Cells[1].Value.ToString();
                chkEstado.Checked = Convert.ToBoolean(fila.Cells[2].Value);
                gbxDatos.Enabled = true;
                btnModificar.Enabled = true;
                btnGuardar.Enabled = false;
            }
        }

        

        private void ListarEspecialidades()
        {
            dgvEspecialidades.DataSource = null;
            dgvEspecialidades.DataSource = servicio.Listado();
            dgvEspecialidades.Columns["NombreDisplay"].Visible = false;

            // Evita que el usuario escriba en el grid
            dgvEspecialidades.ReadOnly = true;
            dgvEspecialidades.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEspecialidades.AllowUserToAddRows = false;

            // Ocultar columnas técnicas
            if (dgvEspecialidades.Columns.Contains("estado"))
                dgvEspecialidades.Columns["estado"].Visible = false;

            // Cambiar encabezados para que se vean bien
            if (dgvEspecialidades.Columns.Contains("idEspecialidad"))
                dgvEspecialidades.Columns["idEspecialidad"].HeaderText = "ID";

            if (dgvEspecialidades.Columns.Contains("nombre"))
                dgvEspecialidades.Columns["nombre"].HeaderText = "Especialidad";

            if (dgvEspecialidades.Columns.Contains("EstadoTexto"))
                dgvEspecialidades.Columns["EstadoTexto"].HeaderText = "Estado";
        }


        private void LimpiarControles()
        {
            txtDescripcion.Clear();
            chkEstado.Checked = false;

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Especialidad nuevo = new Especialidad
                {
                    nombre = txtDescripcion.Text,
                    estado = chkEstado.Checked
                };

                servicio.Agregar(nuevo);

                MessageBox.Show("Guardado exitosamente", "Correcto",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                ListarEspecialidades();
                FinalizarOperacion(); // igual que en Club
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FinalizarOperacion()
        {

            LimpiarControles();
            gbxDatos.Enabled = false;
            btnModificar.Enabled = false;
            btnGuardar.Enabled = false;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                Especialidad mod = new Especialidad
                {
                    idEspecialidad = idEspecialidadSeleccionado,
                    nombre = txtDescripcion.Text,
                    estado = chkEstado.Checked
                };



                servicio.Modificar(mod);

                MessageBox.Show("¡Modificado con éxito!", "Correcto",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                ListarEspecialidades();
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
            gbxDatos.Enabled = true;
            btnGuardar.Enabled = true;
            btnModificar.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
