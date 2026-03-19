using CapaModelo;
using CapaPresentacion.Reportes.reportecitaspormedico;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Reportes.reportecitasatendidas
{
    public partial class reportecitaestado : Form
    {
        public reportecitaestado()
        {
            InitializeComponent();
        }

        private void btreporte1_Click(object sender, EventArgs e)
        {
            ReporteCitaatendidaono visor = new ReporteCitaatendidaono(1);
            visor.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReporteCitaatendidaono visor = new ReporteCitaatendidaono(2);
            visor.ShowDialog();
        }
    }
}
