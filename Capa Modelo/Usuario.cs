using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo
{
    public class Usuario
    {

        public int idUsuario { get; set; }
        public string? usuario { get; set; }
        public string? contraseña { get; set; }
        public bool estado { get; set; }
        public int Rol { get; set; }
        public int? idMedico { get; set; }
        public int? idPaciente { get; set; }

        public enum RolUsuario
        {
            Administrador = 1,
            Medico = 2,
            Paciente = 3,
            Recepcionista = 4
        }

        public string RolNombre => ((RolUsuario)Rol).ToString();

        public string EstadoTexto => estado ? "Activo" : "Inactivo";
    }
}
