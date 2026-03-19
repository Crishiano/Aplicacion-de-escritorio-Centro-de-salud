using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo
{
    public class AgendaMedica
    {
        public int idAgenda { get; set; }
        public DateOnly fecha { get; set; }
        public int cupos { get; set; }
        public int idEspecialidad { get; set; }
        public string? nombreEspecialidad { get; set; }
        public int cuposOcupados { get; set; }
        public int cuposDisponibles { get; set; }
        public string? descripcionAgenda { get; set; }
        public string NombreDisplay => descripcionAgenda ??
            $"{nombreEspecialidad} - {fecha:dd/MM/yyyy} ({cuposDisponibles} disponibles)";

        public override string ToString()
        {
            return NombreDisplay;
        }
    }
}
