using CapaDatos;
using CapaModelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class MedicoLN
    {
        private readonly MedicoAD medicoAD;

        public MedicoLN()
        {
            medicoAD = new MedicoAD();
        }

        public void Agregar(Medico medico)
        {
            if (string.IsNullOrWhiteSpace(medico.nombres))
                throw new Exception("El nombre del médico es obligatorio");

            if (string.IsNullOrWhiteSpace(medico.apellidoPat))
                throw new Exception("El apellido paterno es obligatorio");

            if (string.IsNullOrWhiteSpace(medico.apellidoMat))
                throw new Exception("El apellido materno es obligatorio");

            if (medico.cmp.Length < 5)
                throw new Exception("El CMP no es válido");

            if (string.IsNullOrWhiteSpace(medico.cmp))
                throw new Exception("El CMP del Medico es obligatorio");


            if (medico.idEspecialidad <= 0)
                throw new Exception("Debe seleccionar una especialidad válida");

            try
            {
                medicoAD.agregar(medico);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            
        }

        public void Modificar(Medico medico)
        {
            if (medico.idMedico <= 0)
                throw new Exception("Debe seleccionar un médico válido");

            if (string.IsNullOrWhiteSpace(medico.nombres))
                throw new Exception("El nombre del médico es obligatorio");

            if (string.IsNullOrWhiteSpace(medico.apellidoPat))
                throw new Exception("El apellido paterno es obligatorio");

            if (string.IsNullOrWhiteSpace(medico.apellidoMat))
                throw new Exception("El apellido materno es obligatorio");

            if (medico.cmp.ToString().Length < 5)
                throw new Exception("El CMP no es válido");


            if (string.IsNullOrWhiteSpace(medico.cmp))
                throw new Exception("El CMP del Medico es obligatorio");


            if (medico.idEspecialidad <= 0)
                throw new Exception("Debe seleccionar una especialidad válida");

            try
            {
                medicoAD.modificar(new Medico()
                {
                    idMedico = medico.idMedico,
                    cmp = medico.cmp,
                    nombres = medico.nombres,
                    apellidoPat = medico.apellidoPat,
                    apellidoMat = medico.apellidoMat,
                    estado = medico.estado,
                    idEspecialidad = medico.idEspecialidad
                });
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            
        }

        public List<Medico> Listado()
        {
            try
            {
                return medicoAD.listado();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            
        }
        public List<Medico> ListadoPorEspecialidad(int idEspecialidad)
        {
            try
            {
                return medicoAD.ListarPorEspecialidad(idEspecialidad);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<HorarioMedico> ListarTodo(int idEspecialidad)
        {
            try
            {
                return medicoAD.listadoTodosHorarios(idEspecialidad);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener horarios del médico: " + ex.Message);
            }
        }

        public bool ExisteMedicoDisponible(int idEspecialidad, int diaSemana)
        {
            return medicoAD.ExisteMedicoDisponible(idEspecialidad, diaSemana);
        }

        public bool HoraDentroDeHorario(int idMedico, DateOnly fecha, TimeOnly hora)
        {
            return medicoAD.HoraDentroDeHorario(idMedico, fecha, hora);
        }

        
    }
}
