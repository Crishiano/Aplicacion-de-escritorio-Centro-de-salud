using CapaDatos;
using CapaModelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class CitaLN
    {
        private readonly CitaAD citaAD;

        public CitaLN()
        {
            citaAD = new CitaAD();
        }

        public void Agregar(Cita cita)
        {
            if (cita.idPaciente <= 0)
                throw new Exception("Debe seleccionar un paciente válido");
            if (cita.idAgenda <= 0)
                throw new Exception("Debe seleccionar una agenda válida");
            if (cita.idMedico <= 0)
                throw new Exception("Debe seleccionar un médico válido");

            // ⭐ VALIDAR INTERVALO DE 1 HORA
            string mensaje;
            bool disponible = citaAD.ValidarDisponibilidadHorario(
                cita.idMedico, 
                cita.fecha, 
                cita.hora, 
                out mensaje);

            if (!disponible)
            {
                throw new Exception(mensaje);
            }

            try
            {
                citaAD.agregar(cita);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Modificar(Cita cita)
        {
            try
            {
                citaAD.modificar(new Cita()
                {
                    idCita = cita.idCita,
                    estado = cita.estado,
                    motivo = cita.motivo
                });
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool ValidarDisponibilidadHorario(int idMedico, DateOnly fecha, TimeOnly hora, out string mensaje, int? idCitaActual = null)
        {
            if (idMedico <= 0)
            {
                mensaje = "Debe seleccionar un médico válido";
                return false;
            }

            return citaAD.ValidarDisponibilidadHorario(idMedico, fecha, hora, out mensaje, idCitaActual);
        }

        public List<HoraDisponible> ObtenerHorasDisponibles(int idMedico, DateOnly fecha, TimeOnly horaInicio, TimeOnly horaFin)
        {
            if (idMedico <= 0)
                throw new Exception("Debe seleccionar un médico válido");

            try
            {
                return citaAD.ObtenerHorasDisponibles(idMedico, fecha, horaInicio, horaFin);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void CancelarManual(int idCita, int idUsuario, string motivoCancelacion = null)
        {
            if (idCita <= 0)
                throw new Exception("ID de cita inválido");

            if (idUsuario <= 0)
                throw new Exception("ID de usuario inválido");

            try
            {
                citaAD.CancelarManual(idCita, idUsuario, motivoCancelacion);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void CancelarCitasVencidas()
        {
            try
            {
                citaAD.CancelarCitasVencidas();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al cancelar citas vencidas: {ex.Message}");
            }
        }

        public bool PuedeCancelarCita(int idCita, out string mensaje)
        {
            if (idCita <= 0)
            {
                mensaje = "ID de cita inválido";
                return false;
            }

            return citaAD.PuedeCancelarCita(idCita, out mensaje);
        }

        public List<Cita> Listar()
        {
            try
            {
                return citaAD.lista();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Cita ObtenerDetalle(int idCita)
        {
            if (idCita <= 0)
                throw new Exception("ID de cita inválido");

            try
            {
                return citaAD.ObtenerDetalle(idCita);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void CambiarEstadoAtendida(int idCita)
        {
            try
            {
                citaAD.modificarEstado(new Cita()
                {
                    idCita = idCita,
                    estado = 1, 
                });
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al cambiar estado de la cita: {ex.Message}");
            }
        }


        public List<Cita> ObtenerHistorial(int idPaciente)
        {
            return citaAD.ObtenerHistorial(idPaciente);
        }

        public DataTable ReporteCitasPorRango(DateTime fechaInicio, DateTime fechaFin)
        {
            try
            {
                return citaAD.ListadoCitasPorRango(fechaInicio, fechaFin);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable ReporteCitasPormedico(int idmedico)
        {
            try
            {
                return citaAD.citapormedico(idmedico);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable ReporteCitasPorestado(int estado)
        {
            try
            {
                return citaAD.citaporestado(estado);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
