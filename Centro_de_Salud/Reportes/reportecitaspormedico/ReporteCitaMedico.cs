using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Reportes.reportecitaspormedico
{
    public partial class ReporteCitaMedico : Form
    {

        private MedicoLN medicoLN = new MedicoLN();
        public ReporteCitaMedico()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            cargarcombo();
        }

        private void cbmedico_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cargarcombo()
        {

            cbmedico.DataSource = medicoLN.Listado();
            cbmedico.DisplayMember = "nombres";
            cbmedico.ValueMember = "idMedico";
            cbmedico.SelectedIndex = -1;

        }

        private void btreporte_Click(object sender, EventArgs e)
        {
            // Validar que se haya seleccionado un médico
            if (cbmedico.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, seleccione un médico.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Salir del evento si no hay selección
            }

            // Si pasó la validación, obtengo el id del médico
            int idMedico = Convert.ToInt32(cbmedico.SelectedValue);

            // Aquí llamas a tu método para generar el reporte
            // Por ejemplo:
            Reportecitasmedico visor = new Reportecitasmedico(idMedico);
            visor.ShowDialog();
        }
    }
}
