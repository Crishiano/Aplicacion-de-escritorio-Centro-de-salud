using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo
{
    public class HorarioMedico
    {
        public int idHorarioMedico { get; set; }
        public byte DiaSemana { get; set; }
        public TimeSpan HoraInicio { get; set; }
        public TimeSpan HoraFin { get; set; }
        public int idmedico { get; set; }

        // Esta propiedad no está en la DB, pero el DataGridView la verá
        public string NombreDia
        {
            get
            {
                string[] dias = { "", "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo" };
                return (DiaSemana >= 1 && DiaSemana <= 7) ? dias[DiaSemana] : "---";
            }
        }

        public string? nombreMedico { get; set; }

    }
}
