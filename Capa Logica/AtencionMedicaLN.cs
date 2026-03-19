using CapaDatos;
using CapaModelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class AtencionMedicaLN
    {
        private readonly AtencionMedicaAD atencionMedicaAD;

        public AtencionMedicaLN()
        {
            atencionMedicaAD = new AtencionMedicaAD();
        }

        public void Agregar(AtencionMedica atencion)
        {
            if (atencion.idCita <= 0)
                throw new Exception("Debe seleccionar una cita válida");
            if (string.IsNullOrWhiteSpace(atencion.diagnostico))
                throw new Exception("El diagnóstico es obligatorio");
            if (atencion.fechaAtencion == default)
                throw new Exception("La fecha de atención es obligatoria");
            try
            {
                atencionMedicaAD.agregar(atencion);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Modificar(AtencionMedica atencion)
        {
            if (atencion.idAtencion <= 0)
                throw new Exception("Debe seleccionar una atención médica válida");
            if (atencion.idCita <= 0)
                throw new Exception("Debe seleccionar una cita válida");
            if (string.IsNullOrWhiteSpace(atencion.diagnostico))
                throw new Exception("El diagnóstico es obligatorio");
            if (atencion.fechaAtencion == default)
                throw new Exception("La fecha de atención es obligatoria");
            try
            {
                atencionMedicaAD.modificar(new AtencionMedica()
                {
                    idAtencion = atencion.idAtencion,
                    idCita = atencion.idCita,
                    diagnostico = atencion.diagnostico,
                    observaciones = atencion.observaciones,
                    fechaAtencion = atencion.fechaAtencion
                });
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<AtencionMedica> Listar()
        {
            try
            {
                return atencionMedicaAD.lista();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public List<AtencionMedica> ListarPorMedico(int idMedico)
        {
            return atencionMedicaAD.ListarPorMedico(idMedico);
        }
    }
}
