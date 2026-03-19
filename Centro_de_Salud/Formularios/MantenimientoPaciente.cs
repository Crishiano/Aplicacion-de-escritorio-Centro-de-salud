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
    public partial class MantenimientoPaciente : Form
    {
        private PacienteLN servicio = new PacienteLN();
        private int idpacienteSeleccionado = 0;
        public MantenimientoPaciente()
        {
            InitializeComponent();
            cargarPacientes();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

        }

        private void cargarPacientes()
        {
            try
            {
                dgvPacientes.DataSource = servicio.listado();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void dgvPacientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {


        }





        private void LimpiarControles()
        {
            txtNombres.Clear();
            txtTelefono.Clear();
            txtApPat.Clear();
            txtDireccion.Clear();
            txtDNI.Clear();

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click_1(object sender, EventArgs e)
        {
            string apellidos = txtApPat.Text.Trim();
            string[] partes = apellidos.Split(' ');

            string apellidoPat = partes.Length > 0 ? partes[0] : "";
            string apellidoMat = partes.Length > 1 ? partes[1] : "";
            try
            {
                servicio.Agregar(new Paciente()
                {
                    idPaciente = 0,
                    DNI = txtDNI.Text,
                    nombres = txtNombres.Text,
                    apellidoPat = apellidoPat,
                    apellidoMat = apellidoMat,
                    telefono = txtTelefono.Text,
                    direccion = txtDireccion.Text,
                }

                    );
                MessageBox.Show("Tipo de Paciente registrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Limpiar controles 
                cargarPacientes();
                LimpiarControles();
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            LimpiarControles();
            btnModificar.Enabled = false;
            btnRegistrar.Enabled = true;
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            string apellidos = txtApPat.Text.Trim();
            string[] partes = apellidos.Split(' ');

            string apellidoPat = partes.Length > 0 ? partes[0] : "";
            string apellidoMat = partes.Length > 1 ? partes[1] : "";
            try
            {
                servicio.Modificar(new Paciente()
                {
                    idPaciente = idpacienteSeleccionado,
                    DNI = txtDNI.Text,
                    nombres = txtNombres.Text,
                    apellidoPat = apellidoPat,
                    apellidoMat = apellidoMat,
                    telefono = txtTelefono.Text,
                    direccion = txtDireccion.Text,
                }

                    );
                MessageBox.Show("Modificacion exitosa", "mensaje", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                cargarPacientes();
                LimpiarControles();
                btnRegistrar.Enabled = true;
                btnModificar.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtApPat_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvPacientes_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Obtenemos la fila seleccionada
                int fila = e.RowIndex;
                idpacienteSeleccionado = Convert.ToInt32(dgvPacientes.Rows[fila].Cells[0].Value);
                txtDNI.Text = dgvPacientes.Rows[fila].Cells[1].Value.ToString();
                txtNombres.Text = dgvPacientes.Rows[fila].Cells[2].Value.ToString();
                txtApPat.Text = dgvPacientes.Rows[fila].Cells[3].Value.ToString() + " " +
                                     dgvPacientes.Rows[fila].Cells[4].Value.ToString();
                txtTelefono.Text = dgvPacientes.Rows[fila].Cells[5].Value.ToString();
                txtDireccion.Text = dgvPacientes.Rows[fila].Cells[6].Value.ToString();
                btnModificar.Enabled = true;
                btnRegistrar.Enabled = false;
            }
        }

        private void dgvPacientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
