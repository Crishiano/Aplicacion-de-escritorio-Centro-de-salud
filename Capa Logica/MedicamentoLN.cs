using CapaDatos;
using CapaModelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class MedicamentoLN
    {
        private readonly MedicamentoAD medicamentoAD;

        public MedicamentoLN()
        {
            medicamentoAD = new MedicamentoAD();
        }

        public void Agregar(Medicamento med)
        {
            if (string.IsNullOrWhiteSpace(med.nombre))
                throw new Exception("El nombre del medicamento es obligatorio");

            try
            {
                medicamentoAD.agregar(med);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            
        }

        public void Modificar(Medicamento med)
        {

            if (string.IsNullOrWhiteSpace(med.nombre))
                throw new Exception("El nombre del medicamento es obligatorio");

            try
            {
                medicamentoAD.modificar(new Medicamento()
                {
                    idMedicamento = med.idMedicamento,
                    nombre = med.nombre,
                    presentacion = med.presentacion
                });
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            
        }

        public List<Medicamento> Listado()
        {
            try
            {
                return medicamentoAD.listado();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            
        }

    }
}
