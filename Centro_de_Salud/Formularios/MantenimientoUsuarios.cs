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
using static CapaModelo.Usuario;

namespace CapaPresentacion.Formularios
{
    public partial class MantenimientoUsuarios : Form
    {
        private readonly UsuarioLN servicio = new UsuarioLN();
        private readonly MedicoLN medicoLN = new MedicoLN(); // Movido aquí para eficiencia
        private readonly PacienteLN pacienteLN = new PacienteLN();

        int idSeleccionado = 0;

        public MantenimientoUsuarios()
        {
            InitializeComponent();
            gboDatos.Enabled = false;
            btnRegistrar.Enabled = false;
            btnModificar.Enabled = false;
            cboMedico.Enabled = false;
            cboPaciente.Enabled = false;
            dgvDatos.CellClick += DgvDatos_CellClick;
            cargarUsuarios();
            CargarCombos();
        }

        private void DgvDatos_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int fila = e.RowIndex;
                idSeleccionado = Convert.ToInt32(dgvDatos.Rows[fila].Cells["idUsuario"].Value);

                txtUsuario.Text = dgvDatos.Rows[fila].Cells["usuario"].Value.ToString();
                txtContraseña.Text = dgvDatos.Rows[fila].Cells["contraseña"].Value.ToString();
                chkActivo.Checked = Convert.ToBoolean(dgvDatos.Rows[fila].Cells["estado"].Value);

                // Seteamos el Rol primero para que dispare el evento de mostrar/ocultar combos
                Usuario u = (Usuario)dgvDatos.CurrentRow.DataBoundItem;
                
                cmbRol.SelectedValue = u.Rol;

                // Cargamos los IDs vinculados en los ComboBoxes
                var idM = dgvDatos.Rows[fila].Cells["idMedico"].Value;
                var idP = dgvDatos.Rows[fila].Cells["idPaciente"].Value;

                cboMedico.SelectedValue = idM ?? -1;
                cboPaciente.SelectedValue = idP ?? -1;

                gboDatos.Enabled = true;
                btnModificar.Enabled = true;
                btnRegistrar.Enabled = false;
                cboMedico.Enabled = false;
                cboPaciente.Enabled = false;
                cmbRol.Enabled = false;


            }
        }

        private void cargarUsuarios()
        {
            try
            {
                dgvDatos.DataSource = servicio.Listado();
                // Ocultamos columnas que el usuario no necesita ver
                if (dgvDatos.Columns["idMedico"] != null) dgvDatos.Columns["idMedico"].Visible = false;
                if (dgvDatos.Columns["idPaciente"] != null) dgvDatos.Columns["idPaciente"].Visible = false;
                if (dgvDatos.Columns["contraseña"] != null) dgvDatos.Columns["contraseña"].Visible = false; // Por seguridad
                dgvDatos.Columns["usuario"].HeaderText = "Identificador (DNI/CMP)";
                txtUsuario.Enabled = (Convert.ToInt32(cmbRol.SelectedValue) == 1);

                if (dgvDatos.Columns.Contains("estado"))
                    dgvDatos.Columns["estado"].Visible = false;
                if (dgvDatos.Columns.Contains("EstadoTexto"))
                    dgvDatos.Columns["EstadoTexto"].HeaderText = "Estado";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LimpiarControles()
        {

            txtUsuario.Clear();
            txtContraseña.Clear();
            txtContraseñaValidacion.Clear();
            cboMedico.SelectedIndex = -1;
            cboPaciente.SelectedIndex = -1;
            cmbRol.SelectedIndex = -1;
            idSeleccionado = 0;
            gboDatos.Enabled = false;
        }

        private void CargarCombos()
        {
            cmbRol.DataSource = Enum.GetValues(typeof(RolUsuario))
            .Cast<RolUsuario>()
            .Select(r => new { ID = (int)r, Nombre = r.ToString() })
            .ToList();

            cmbRol.DisplayMember = "Nombre";
            cmbRol.ValueMember = "ID";
            cmbRol.SelectedIndex = -1;

            MedicoLN medicoLN = new MedicoLN();
            cboMedico.DataSource = medicoLN.Listado();
            cboMedico.DisplayMember = "nombres";
            cboMedico.ValueMember = "idMedico";
            cboMedico.SelectedIndex = -1;

            PacienteLN pacienteLN = new PacienteLN();
            cboPaciente.DataSource = pacienteLN.listado();
            cboPaciente.DisplayMember = "nombres";
            cboPaciente.ValueMember = "idPaciente";
            cboPaciente.SelectedIndex = -1;


        }


        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            LimpiarControles();
            gboDatos.Enabled = true;
            txtUsuario.Enabled = true;
            btnRegistrar.Enabled = true;
            btnModificar.Enabled = false;
            cmbRol.Enabled = true;
            cboPaciente.Enabled = true;
            cboMedico.Enabled = true;
        }

        private void btnRegistrar_Click_1(object sender, EventArgs e)
        {


            if (string.IsNullOrWhiteSpace(txtContraseña.Text))
            {
                MessageBox.Show("Por favor, ingresa una contraseña.");
                return;
            }


            if (txtContraseña.Text != txtContraseñaValidacion.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden. Por favor, verifica.");
                txtContraseñaValidacion.Focus();
                return;
            }
            try
            {
                servicio.Agregar(new Usuario()
                {

                    usuario = txtUsuario.Text.Trim(),
                    contraseña = txtContraseña.Text.Trim(),
                    estado = chkActivo.Checked,
                    Rol = (int)cmbRol.SelectedValue,
                    idMedico = (cboMedico.Enabled && cboMedico.SelectedValue != null) ? (int)cboMedico.SelectedValue : (int?)null,
                    idPaciente = (cboPaciente.Enabled && cboPaciente.SelectedValue != null) ? (int)cboPaciente.SelectedValue : (int?)null
                });
                MessageBox.Show("Usuario registrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Limpiar controles 
                cargarUsuarios();
                LimpiarControles();
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {


            if (string.IsNullOrWhiteSpace(txtContraseña.Text))
            {
                MessageBox.Show("Por favor, ingresa una contraseña.");
                return;
            }


            if (txtContraseña.Text != txtContraseñaValidacion.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden. Por favor, verifica.");
                txtContraseñaValidacion.Focus();
                return;
            }
            try
            {
                servicio.Modificar(new Usuario()
                {
                    idUsuario = idSeleccionado,
                    usuario = txtUsuario.Text.Trim(),
                    contraseña = txtContraseña.Text.Trim(),
                    estado = chkActivo.Checked,
                    Rol = (int)cmbRol.SelectedValue,
                    idMedico = (cboMedico.Enabled && cboMedico.SelectedValue != null) ? (int)cboMedico.SelectedValue : (int?)null,
                    idPaciente = (cboPaciente.Enabled && cboPaciente.SelectedValue != null) ? (int)cboPaciente.SelectedValue : (int?)null
                }

                    );
                MessageBox.Show("Modificacion exitosa", "mensaje", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                cargarUsuarios();
                LimpiarControles();
                btnRegistrar.Enabled = true;
                btnModificar.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btnOjo_Click(object sender, EventArgs e)
        {
            if (txtContraseña.PasswordChar == '*')
            {
                txtContraseña.PasswordChar = '\0'; // Muestra la contraseña real
            }
            else
            {
                // Si no hay máscara, volvemos a poner el asterisco
                txtContraseña.PasswordChar = '*';
            }
        }

        private void btnOjo2_Click(object sender, EventArgs e)
        {
            if (txtContraseñaValidacion.PasswordChar == '*')
            {
                txtContraseñaValidacion.PasswordChar = '\0'; // Muestra la contraseña real
            }
            else
            {
                // Si no hay máscara, volvemos a poner el asterisco
                txtContraseñaValidacion.PasswordChar = '*';
            }
        }

        private void txtContraseñaValidacion_TextChanged(object sender, EventArgs e)
        {
            // Comparamos los textos de ambos campos
            if (txtContraseñaValidacion.Text == txtContraseña.Text)
            {
                // Coinciden: podrías poner el texto en negro o mostrar un check verde
                txtContraseñaValidacion.ForeColor = Color.Black;
            }
            else
            {
                // No coinciden: lo ponemos en rojo para alertar
                txtContraseñaValidacion.ForeColor = Color.Red;
            }
        }

        private void cmbRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRol.SelectedValue == null || !(cmbRol.SelectedValue is int)) return;

            int rol = (int)cmbRol.SelectedValue;

            // Resetear valores
            cboMedico.SelectedIndex = -1;
            cboPaciente.SelectedIndex = -1;
            txtUsuario.Clear();

            if (rol == 1) // Administrador
            {
                cboMedico.Enabled = false;
                cboPaciente.Enabled = false;
                txtUsuario.Enabled = true; // El admin sí puede escribir su nombre de usuario
            }
            else if (rol == 2) // Médico
            {
                cboMedico.Enabled = true;
                cboPaciente.Enabled = false;
                txtUsuario.Enabled = false; // Se llenará solo al elegir médico
            }
            else if (rol == 3) // Paciente
            {
                cboMedico.Enabled = false;
                cboPaciente.Enabled = true;
                txtUsuario.Enabled = false; // Se llenará solo al elegir paciente
            }
        }

        private void cboMedico_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMedico.SelectedIndex != -1 && cboMedico.SelectedItem is Medico medicoSeleccionado)
            {
                // Supongamos que tu clase Medico tiene la propiedad 'cmp'
                txtUsuario.Text = medicoSeleccionado.cmp;
                txtUsuario.Enabled = false; // Bloqueamos para evitar errores
            }
        }

        private void cboPaciente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPaciente.SelectedIndex != -1 && cboPaciente.SelectedItem is Paciente pacienteSeleccionado)
            {
                // Supongamos que tu clase Paciente tiene la propiedad 'dni'
                txtUsuario.Text = pacienteSeleccionado.DNI;
                txtUsuario.Enabled = false; // Bloqueamos
            }
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
