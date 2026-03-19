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
    public partial class MantenimientoReceta : Form
    {
        private RecetaLN servicioReceta = new RecetaLN();
        private int idAtencionRecibido;
        private int idRecetaGenerada = 0;
        public MantenimientoReceta(int idAtencion, DateTime fecha)
        {
            InitializeComponent();
            this.idAtencionRecibido = idAtencion;
            dgreceta.CellClick += Dgreceta_CellClick;
            ConfigurarFechaReceta();
            
            lista();
        }

        private void ConfigurarFechaReceta()
        {
            dtpFecha.Value = DateTime.Now; // Fecha y hora actual
            dtpFecha.Enabled = false;      // Bloqueado para que el médico no la cambie
        }

        private void Dgreceta_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Obtenemos la fila seleccionada
                int fila = e.RowIndex;

                // Solo tenemos una columna visible: Fecha
                idRecetaGenerada = Convert.ToInt32(dgreceta.Rows[fila].Cells[0].Value);
                DateTime fechaSeleccionada = Convert.ToDateTime(dgreceta.Rows[fila].Cells[2].Value);

                // Asignamos al DateTimePicker
                dtpFecha.Value = fechaSeleccionada;

                // Si necesitas activar/desactivar botones
                btnDetalle.Enabled = true;
                btnEliminar.Enabled = true;
                btnGuardar.Enabled = false;
            }
            btnDetalle.Enabled = true;
        }

        private void CargarRecetasDeLaAtencion()
        {
            // Aquí podrías listar las recetas vinculadas a esta atención 
            // dgvRecetasAtencion.DataSource = servicioReceta.ListarPorAtencion(idAtencionRecibido);
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            try
            {
                Receta nuevaReceta = new Receta()
                {
                    idAtencion = idAtencionRecibido,
                    fecha = dtpFecha.Value
                };

                // El método Agregar debe devolver el ID generado (SCOPE_IDENTITY)
                idRecetaGenerada = servicioReceta.Agregar(nuevaReceta);

                if (idRecetaGenerada > 0)
                {
                    MessageBox.Show("Cabecera de Receta creada. Ahora agregue los medicamentos.", "Éxito");
                    MantenimientoDetalleReceta frmDetalle = new MantenimientoDetalleReceta(idRecetaGenerada);
                    frmDetalle.StartPosition = FormStartPosition.CenterParent;
                    frmDetalle.ShowDialog(this);
                    btnDetalle.Enabled = true;
                    btnGuardar.Enabled = false; // Evitamos duplicar cabeceras
                }
                lista();
                borrar();
                btnGuardar.Enabled = true;
                btnNuevo.Enabled = true;
                btnEliminar.Enabled = false;
                btnDetalle.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            borrar();
            btnGuardar.Enabled = true;
            btnEliminar.Enabled = false;
            btnDetalle.Enabled = false;
            ConfigurarFechaReceta();
        }
        private void borrar()
        {
            ConfigurarFechaReceta();
            idRecetaGenerada = 0;
        }

        private void lista()
        {
            try
            {
                dgreceta.DataSource = servicioReceta.ListarPorAtencion(idAtencionRecibido);
                dgreceta.Columns[0].Visible = false;
                dgreceta.Columns[1].Visible = false;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnDetalle_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (idRecetaGenerada > 0)
                {
                    MantenimientoDetalleReceta frmDetalle = new MantenimientoDetalleReceta(idRecetaGenerada);
                    frmDetalle.StartPosition = FormStartPosition.CenterParent;
                    frmDetalle.ShowDialog(this);

                }
                else
                {
                    MessageBox.Show("seleccione de la lista una fecha");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (idRecetaGenerada > 0)
                {
                    bool eliminado = servicioReceta.Eliminar(idRecetaGenerada);
                    if (eliminado)
                    {
                        lista();   // refrescar lista
                        borrar();  // limpiar formulario
                        MessageBox.Show("Receta eliminada correctamente.");
                    }
                    else
                    {
                        MessageBox.Show("No se puede eliminar esta receta porque tiene detalles asociados.");
                    }
                }
                btnEliminar.Enabled = false;
                btnDetalle.Enabled = false;
                btnGuardar.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
