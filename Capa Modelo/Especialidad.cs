using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo
{
    public class Especialidad
    {
        public int idEspecialidad { get; set; }
        public String? nombre { get; set; }
        public bool estado { get; set; }

        public string EstadoTexto => estado ? "Activo" : "Inactivo";

        public string NombreDisplay => nombre;

        public override string ToString()
        {
            return nombre;
        }
    }
}
