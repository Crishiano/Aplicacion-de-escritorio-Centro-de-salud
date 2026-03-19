using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo
{
    public class DetalleReceta
    {
        public int idDetalleReceta { get; set; }
        public int idReceta { get; set; }
        public int idMedicamento { get; set; }
        public string dosis { get; set; }
        public string frecuencia { get; set; }
        public string duracion { get; set; }
        public string indicaciones { get; set; }

        public string nombreMedicamento { get; set; }
        public string presentacionMedicamento { get; set; }
    }
}
