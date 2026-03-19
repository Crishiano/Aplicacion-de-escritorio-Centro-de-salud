using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo
{
    public class Paciente
    {
        public int idPaciente { get; set; }
        public string? DNI { get; set; }
        public String? nombres { get; set; }
        public String? apellidoPat { get; set; }
        public String? apellidoMat { get; set; }
        public string? telefono { get; set; }
        public String? direccion { get; set; }
    }
}
