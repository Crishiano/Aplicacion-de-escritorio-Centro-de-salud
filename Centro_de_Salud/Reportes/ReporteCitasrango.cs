using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Reportes
{
    public partial class ReporteCitasrango : Form
    {
        public ReporteCitasrango()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btreporte_Click(object sender, EventArgs e)
        {
            if (dtinicio.Value.Date > dtfin.Value.Date)
            {
                MessageBox.Show("La fecha inicio no puede ser mayor que la fecha fin.");
                return;
            }

            // Obtener las fechas
            DateTime fechaInicio = dtinicio.Value.Date;
            DateTime fechaFin = dtfin.Value.Date;

            // Abrimos el Visor enviándole las fechas
            ReportecitasRangoFecha visor = new ReportecitasRangoFecha(fechaInicio, fechaFin);
            visor.ShowDialog();
        }
    }
}
