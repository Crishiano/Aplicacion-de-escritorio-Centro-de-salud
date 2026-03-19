using CapaDatos;
using CapaLogica;
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

namespace CapaPresentacion.Reportes
{
    public partial class ReportecitasRangoFecha : Form
    {
        private DateTime inicio;
        private DateTime fin;
        CitaLN citas = new CitaLN();
        private DataTable dt = new DataTable();
        public ReportecitasRangoFecha( DateTime inicio, DateTime fin)
        {
            InitializeComponent();
            this.inicio = inicio;
            this.fin = fin;
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void repMembresias_club_visor_Load(object sender, EventArgs e)
        {

                try
                {
                dt = citas.ReporteCitasPorRango(inicio, fin);
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reportes.citasfiltro.rdlc";

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
