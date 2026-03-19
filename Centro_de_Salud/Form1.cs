using CapaPresentacion.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void especialidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenimientoEspecialidades frm = new MantenimientoEspecialidades();
            frm.ShowDialog();
        }

        private void medicamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenimientoMedicamento frm = new MantenimientoMedicamento();
            frm.ShowDialog();
        }

        private void medicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mantenimiento_Medico frm = new Mantenimiento_Medico();
            frm.ShowDialog();


        }

        private void rolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenimientoUsuarios frm = new MantenimientoUsuarios();
            frm.ShowDialog();
        }

        private void pacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenimientoPaciente frm = new MantenimientoPaciente();
            frm.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
