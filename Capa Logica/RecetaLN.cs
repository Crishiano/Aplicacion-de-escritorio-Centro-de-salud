using CapaDatos;
using CapaModelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class RecetaLN
    {
        private RecetaAD recetaad = new RecetaAD();

        public int Agregar(Receta obj)
        {
            // Podrías validar que la fecha no sea mayor a hoy
            return recetaad.Agregar(obj);
        }

        public void Modificar(Receta rec)
        {

            try
            {
                recetaad.modificar(new Receta()
                {
                    idReceta = rec.idReceta,
                    idAtencion = rec.idAtencion,
                    fecha = rec.fecha
                });
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Receta> listado()
        {
            try
            {
                return recetaad.listado();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public List<Receta> ListarPorAtencion(int idAtencion)
        {
            try
            {
                // Obtener todas las recetas
                var todasRecetas = listado();

                // Filtrar por idAtencion
                var filtradas = todasRecetas
                    .Where(r => r.idAtencion == idAtencion)
                    .ToList();

                return filtradas;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al filtrar recetas por atención: " + ex.Message);
            }
        }

        public bool Eliminar(int idReceta)
        {
            return recetaad.Eliminar(idReceta);
        }
    }
}
