using CapaDatos;
using CapaModelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class EspecialidadLN
    {
        private readonly EspecialidadAD especialidadAD;

        public EspecialidadLN()
        {
            especialidadAD = new EspecialidadAD();
        }

        public void Agregar(Especialidad esp)
        {
            if (string.IsNullOrWhiteSpace(esp.nombre))
                throw new Exception("El nombre de la especialidad es obligatorio");

            try
            {
                especialidadAD.agregar(esp);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public void Modificar(Especialidad esp)
        {
            if (esp.idEspecialidad <= 0)
                throw new Exception("Debe seleccionar una especialidad válida");

            if (string.IsNullOrWhiteSpace(esp.nombre))
                throw new Exception("El nombre no puede estar vacío");

            try
            {
                especialidadAD.modificar(new Especialidad()
                {
                    idEspecialidad = esp.idEspecialidad,
                    nombre = esp.nombre,
                    estado = esp.estado
                });
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            
        }

        public List<Especialidad> Listado()
        {
            try
            {
                return especialidadAD.listado();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public List<Especialidad> ListarActivas()
        {
            try
            {
                return especialidadAD.ListarActivas();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error en la lógica de negocio: {ex.Message}");
            }
        }

    }
}
