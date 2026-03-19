using CapaDatos;
using CapaModelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class AgendaMedicaLN
    {
        private readonly AgendaMedicaAD agendaAD;

        public AgendaMedicaLN()
        {
            agendaAD = new AgendaMedicaAD();
        }

        public void Agregar(AgendaMedica agenda)
        {
            if (agenda.fecha == default)
                throw new Exception("La fecha es obligatoria");

            if (agenda.cupos <= 0)
                throw new Exception("Los cupos deben ser mayores a 0");

            if (agenda.idEspecialidad <= 0)
                throw new Exception("Debe seleccionar una especialidad válida");

            try
            {
                agendaAD.agregar(agenda);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Modificar(AgendaMedica agenda)
        {
            if (agenda.idAgenda <= 0)
                throw new Exception("Debe seleccionar una agenda válida");

            if (agenda.fecha == default)
                throw new Exception("La fecha es obligatoria");

            if (agenda.cupos <= 0)
                throw new Exception("Los cupos deben ser mayores a 0");

            if (agenda.idEspecialidad <= 0)
                throw new Exception("Debe seleccionar una especialidad válida");

            try
            {
                agendaAD.modificar(new AgendaMedica()
                {
                    idAgenda = agenda.idAgenda,
                    fecha = agenda.fecha,
                    cupos = agenda.cupos,
                    idEspecialidad = agenda.idEspecialidad
                });
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<AgendaMedica> Listado()
        {
            try
            {
                return agendaAD.listado();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool validacion(int idespecialidad, DateOnly fecha)
        {
            // Traer todos los registros
            List<AgendaMedica> todas = Listado(); // listado() debe devolver List<AgendaMedica>

            // Verificar si hay alguno con la misma especialidad y fecha
            bool existe = todas.Any(a => a.idEspecialidad == idespecialidad && a.fecha == fecha);

            return existe;
        }

        public AgendaMedica ObtenerPorId(int idAgenda)
        {
            try
            {
                return agendaAD.listado().FirstOrDefault(a => a.idAgenda == idAgenda)
                    ?? throw new Exception("Agenda no encontrada");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<AgendaMedica> ListarPorMedico(int idMedico)
        {
            if (idMedico <= 0)
                throw new Exception("Debe seleccionar un médico válido");

            try
            {
                var agendas = agendaAD.ListarPorMedico(idMedico);

                if (agendas == null || agendas.Count == 0)
                {
                    throw new Exception("No hay agendas disponibles para este médico");
                }

                return agendas;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error en la lógica de negocio: {ex.Message}");
            }
        }
    }
}
