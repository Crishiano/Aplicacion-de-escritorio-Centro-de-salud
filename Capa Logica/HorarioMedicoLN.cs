using CapaDatos;
using CapaModelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class HorarioMedicoLN
    {
        private readonly HorarioMedicoAD horarioAD;

        public HorarioMedicoLN()
        {
            horarioAD = new HorarioMedicoAD();
        }

        public void Agregar(HorarioMedico medico)
        {
            if (medico.idmedico <= 0)
                throw new Exception("Médico inválido");

            if (medico.DiaSemana < 1 || medico.DiaSemana > 7)
                throw new Exception("El día de la semana debe ser entre 1 y 7");

            if (medico.HoraInicio >= medico.HoraFin)
                throw new Exception("La hora de inicio debe ser menor que la hora de fin");

            // 1. Traemos los horarios que ya existen para este médico
            List<HorarioMedico> horariosExistentes = horarioAD.listarPorMedico(medico.idmedico);

            // 2. Buscamos si alguno choca con el nuevo
            foreach (var existente in horariosExistentes)
            {
                if (existente.DiaSemana == medico.DiaSemana) // Solo si es el mismo día
                {
                    // La fórmula mágica de traslape
                    if (medico.HoraInicio < existente.HoraFin && medico.HoraFin > existente.HoraInicio)
                    {
                        throw new Exception("El horario choca con uno existente");
                    }
                }
            }


                try
            {
                horarioAD.agregar(medico);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            
        }

        public void Modificar(HorarioMedico medico)
        {
            if (medico.idmedico <= 0)
                throw new Exception("Médico inválido");

            if (medico.DiaSemana < 1 || medico.DiaSemana > 7)
                throw new Exception("El día de la semana debe ser entre 1 y 7");

            if (medico.HoraInicio >= medico.HoraFin)
                throw new Exception("La hora de inicio debe ser menor que la hora de fin");

            try
            {
                List<HorarioMedico> existentes = horarioAD.listarPorMedico(medico.idmedico);

                foreach (var ex in existentes)
                {
                    if (ex.idHorarioMedico == medico.idHorarioMedico) continue;

                    if (ex.DiaSemana == medico.DiaSemana)
                    {
                        if (medico.HoraInicio < ex.HoraFin && medico.HoraFin > ex.HoraInicio)
                        {
                            throw new Exception("Error cruce de Horario");
                        }
                    }
                }


                horarioAD.modificar(new HorarioMedico()
                {
                    idHorarioMedico = medico.idHorarioMedico,
                    DiaSemana = medico.DiaSemana,
                    HoraInicio = medico.HoraInicio,
                    HoraFin = medico.HoraFin,
                    idmedico = medico.idmedico

                });
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }



        public List<HorarioMedico> Listado()
        {
           
            try
            {
                return horarioAD.listado();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            
        }


        public List<HorarioMedico> ListarPorMedico(int idMedico)
        {
            try
            {
                // Llamamos al método de la Capa de Datos (AD) que creamos antes
                return horarioAD.listarPorMedico(idMedico);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener horarios del médico: " + ex.Message);
            }
        }

        
    }
}
