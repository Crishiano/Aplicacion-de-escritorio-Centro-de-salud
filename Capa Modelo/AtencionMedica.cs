using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo
{
    public class AtencionMedica
    {
        public int idAtencion { get; set; }
        public int idCita { get; set; }
        public string? diagnostico { get; set; }
        public string? observaciones { get; set; }
        public DateTime fechaAtencion { get; set; }
        public string? nombrePaciente { get; set; }
        public string? nombreMedico { get; set; }

        public int estadoCita { get; set; }
    }
}
