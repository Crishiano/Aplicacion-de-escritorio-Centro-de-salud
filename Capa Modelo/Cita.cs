using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo
{
    public class Cita
    {
        public int idCita { get; set; }
        public int idPaciente { get; set; }
        public int idAgenda { get; set; }
        public TimeOnly hora { get; set; }
        public int idUsuario { get; set; }
        public int estado { get; set; }
        public string? motivo { get; set; }
        public DateOnly fecha { get; set; }
        public int idMedico { get; set; }
        public string? nombrePaciente { get; set; }
        public string? nombreUsuario { get; set; }
        public string? nombreMedico { get; set; }
        public string? nombreEspecialidad { get; set; }
        public string? nombreEstado
        {
            get{
                return estado switch
                {
                    0 => "Pendiente",
                    1 => "Atendido",
                    2 => "Cancelado",
                    _ => "Desconocido",
                };
            }
        }
    }
}
