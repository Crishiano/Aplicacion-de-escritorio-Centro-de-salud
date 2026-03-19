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
    public partial class MantenimientoHorarioMedico : Form
    {

        private int idMedicoSeleccionado;
        private HorarioMedicoLN horarioMedicoLN = new HorarioMedicoLN();
        private int idHorarioSeleccionado = 0;

        public MantenimientoHorarioMedico(int idMedico)
        {
            InitializeComponent();
            this.idMedicoSeleccionado = idMedico;
            ListarHorarios();
            btnModificarHorario.Enabled = false;
            btnGuardarHorario.Enabled = false;
            dgvHorarioMedicos.CellClick += DgvHorarioMedicos_CellClick;
            gbxHorario.Enabled = false;
            Limpiar();
        }

        private void DgvHorarioMedicos_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var fila = (HorarioMedico)dgvHorarioMedicos.Rows[e.RowIndex].DataBoundItem;

                idHorarioSeleccionado = fila.idHorarioMedico;

                // Convertimos TimeSpan a DateTime para el control
                dtpHoraInicio.Value = DateTime.Today.Add(fila.HoraInicio);
                dtpHoraFin.Value = DateTime.Today.Add(fila.HoraFin);

                // Limpiar Checks y marcar el correcto
                for (int i = 0; i < cklDias.Items.Count; i++) cklDias.SetItemChecked(i, false);

                // Si Lunes es 1, su índice en el CheckedListBox es 0
                cklDias.SetItemChecked(fila.DiaSemana - 1, true);

                btnModificarHorario.Enabled = true;
                gbxHorario.Enabled = true;
            }
        }

        private void ListarHorarios()
        {
            dgvHorarioMedicos.DataSource = horarioMedicoLN.ListarPorMedico(idMedicoSeleccionado);
            dgvHorarioMedicos.Columns["DiaSemana"].Visible = false;
            dgvHorarioMedicos.Columns["nombreMedico"].Visible = false;
           
        }

        private byte ObtenerDiaByte(string dia)
        {
            switch (dia)
            {
                case "Lunes": return 1;
                case "Martes": return 2;
                case "Miercoles": return 3;
                case "Jueves": return 4;
                case "Viernes": return 5;
                case "Sabado": return 6;
                case "Domingo": return 7;
                default: return 0;
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnGuardarHorario_Click(object sender, EventArgs e)
        {
            try
            {
                // Recorremos solo los días marcados en el CheckedListBox
                foreach (var item in cklDias.CheckedItems)
                {
                    HorarioMedico nuevo = new HorarioMedico();
                    nuevo.idmedico = idMedicoSeleccionado;
                    nuevo.DiaSemana = ObtenerDiaByte(item.ToString());

                    // Convertir el valor del DateTimePicker a TimeSpan
                    nuevo.HoraInicio = dtpHoraInicio.Value.TimeOfDay;
                    nuevo.HoraFin = dtpHoraFin.Value.TimeOfDay;

                    horarioMedicoLN.Agregar(nuevo);
                }

                MessageBox.Show("Horarios registrados con éxito");
                ListarHorarios();
                
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
            btnGuardarHorario.Enabled = true;
            gbxHorario.Enabled = true;
        }

        private void Limpiar()
        {
            idHorarioSeleccionado = 0;
            for (int i = 0; i < cklDias.Items.Count; i++)
            {
                cklDias.SetItemChecked(i, false);
            }
            dtpHoraInicio.Value = DateTime.Today.AddHours(8);
            dtpHoraFin.Value = DateTime.Today.AddHours(14);
            btnGuardarHorario.Enabled = false ;
            btnModificarHorario.Enabled = false;
            gbxHorario.Enabled = false ;
            
        }

        private void btnModificarHorario_Click(object sender, EventArgs e)
        {
            try
            {
                if (idHorarioSeleccionado == 0)
                {
                    MessageBox.Show("Por favor, seleccione un horario de la tabla para modificar.");
                    return;
                }

                // 1. Creamos el objeto con los datos de los controles
                HorarioMedico editado = new HorarioMedico();
                editado.idHorarioMedico = idHorarioSeleccionado;
                editado.idmedico = idMedicoSeleccionado; // El ID que recibimos del primer form
                editado.HoraInicio = dtpHoraInicio.Value.TimeOfDay;
                editado.HoraFin = dtpHoraFin.Value.TimeOfDay;

                // Para el día, buscamos cuál está marcado (tomamos elencuentre primero que )
                if (cklDias.CheckedItems.Count > 0)
                {
                    string diaTexto = cklDias.CheckedItems[0].ToString();
                    editado.DiaSemana = ObtenerDiaByte(diaTexto); // El método que traduce "Lunes" a 1
                }

                // 2. Llamamos a la Capa de Negocio
                horarioMedicoLN.Modificar(editado);

                MessageBox.Show("Horario actualizado correctamente");
                ListarHorarios();
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
