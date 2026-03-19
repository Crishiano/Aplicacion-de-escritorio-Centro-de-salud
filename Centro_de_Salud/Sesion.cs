using CapaModelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaPresentacion
{
    public static class Sesion
    {
        // Aquí guardamos el objeto completo que acabas de definir
        public static Usuario UsuarioLogueado { get; set; }

        // Propiedad de conveniencia para obtener el ID según el rol
        public static int GetIdAsociado()
        {
            if (UsuarioLogueado == null) return 0;

            // Si es médico, devuelve su idMedico, si es paciente, su idPaciente
            return UsuarioLogueado.idMedico ?? UsuarioLogueado.idPaciente ?? 0;
        }
    }
}
