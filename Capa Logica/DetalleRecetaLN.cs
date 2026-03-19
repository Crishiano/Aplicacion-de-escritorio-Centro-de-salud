using CapaDatos;
using CapaModelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class DetalleRecetaLN
    {
        private DetalleRecetaAD capaDatos = new DetalleRecetaAD();

        public bool Agregar(DetalleReceta obj)
        {
            // Regla de negocio: La dosis y frecuencia no pueden estar vacías
            if (string.IsNullOrEmpty(obj.dosis)) throw new Exception("La dosis es obligatoria.");

            return capaDatos.Agregar(obj);
        }

        public List<DetalleReceta> ListarPorReceta(int idReceta)
        {
            return capaDatos.ListarPorReceta(idReceta);
        }

        public bool Eliminar(int idDetalleReceta)
        {
            return capaDatos.Eliminar(idDetalleReceta);
        }

        public void Modificar(DetalleReceta detalle)
        {
            // Validaciones
            if (detalle.idDetalleReceta <= 0)
                throw new Exception("Debe seleccionar un detalle de receta válido.");

            if (detalle.idReceta <= 0)
                throw new Exception("Debe seleccionar una receta válida.");

            if (detalle.idMedicamento <= 0)
                throw new Exception("Debe seleccionar un medicamento válido.");

            if (string.IsNullOrWhiteSpace(detalle.dosis))
                throw new Exception("La dosis es obligatoria.");

            if (string.IsNullOrWhiteSpace(detalle.frecuencia))
                throw new Exception("La frecuencia es obligatoria.");

            if (string.IsNullOrWhiteSpace(detalle.duracion))
                throw new Exception("La duración es obligatoria.");

            if (string.IsNullOrWhiteSpace(detalle.indicaciones))
                throw new Exception("Las indicaciones son obligatorias.");

            try
            {
                // Llamar al método de acceso a datos
                capaDatos.modificar(new DetalleReceta()
                {
                    idDetalleReceta = detalle.idDetalleReceta,
                    idReceta = detalle.idReceta,
                    idMedicamento = detalle.idMedicamento,
                    dosis = detalle.dosis,
                    frecuencia = detalle.frecuencia,
                    duracion = detalle.duracion,
                    indicaciones = detalle.indicaciones
                });
            }
            catch (Exception ex)
            {
                throw new Exception("Error al modificar detalle de receta: " + ex.Message);
            }
        }

        public List<DetalleReceta> ListarPorCita(int idReceta)
        {
            try
            {
                return capaDatos.ListarPorCita(idReceta);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }


    }
}
