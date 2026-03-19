using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo
{
    public class Medico
    {
        public int idMedico { get; set; }
        public String? cmp {  get; set; }
        public String? nombres { get; set; }
        public String? apellidoPat { get; set; }
        public String? apellidoMat { get; set; }
        public bool estado { get; set; }
        public int idEspecialidad { get; set; }
        public string? nombreEspecialidad { get; set; }
        public string? nombreCompleto { get; set; }

        public string EstadoTexto => estado ? "Activo" : "Inactivo";

        public string NombreDisplay => $"Dr. {nombres} {apellidoPat} {apellidoMat}";

        public override string ToString()
        {
            return NombreDisplay;
        }
    }
}
