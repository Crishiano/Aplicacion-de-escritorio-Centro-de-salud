using CapaLogica;
using CapaModelo;
using Microsoft.Reporting.WinForms;
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
    public partial class ReporteCitaatendidaono : Form
    {
        private int estado;
        CitaLN citas = new CitaLN();
        private DataTable dt = new DataTable();
        public ReporteCitaatendidaono(int estado)
        {
            InitializeComponent();
            this.estado = estado;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void repcitas_visor_Load(object sender, EventArgs e)
        {

            try
            {
                dt = citas.ReporteCitasPorestado(estado);
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reportes.reportecitasatendidas.CitaAtendida.rdlc";

                ReportDataSource rds = new ReportDataSource("cita", dt);
                reportViewer1.LocalReport.DataSources.Add(rds);
                reportViewer1.RefreshReport();

                // Centrar el ReportViewer en el formulario
                reportViewer1.Left = (this.ClientSize.Width - reportViewer1.Width) / 2;
                reportViewer1.Top = (this.ClientSize.Height - reportViewer1.Height) / 2;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


        }
    }
}
