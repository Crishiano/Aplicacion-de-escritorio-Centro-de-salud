using CapaDatos;
using CapaModelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class PacienteLN
    {
        private readonly PacienteAD pacienteAD;

        public PacienteLN()
        {
            pacienteAD = new PacienteAD();
        }

        public void Agregar(Paciente pac)
        {
            if (string.IsNullOrWhiteSpace(pac.nombres))
                throw new Exception("El nombre del paciente es obligatorio");

            if (string.IsNullOrWhiteSpace(pac.apellidoPat))
                throw new Exception("El apellido paterno es obligatorio");

            if (pac.DNI.ToString().Length != 8)
                throw new Exception("El DNI debe ser válido (8 dígitos)");

            if (string.IsNullOrWhiteSpace(pac.telefono))
                throw new Exception("El teléfono es obligatorio");

            if (!Regex.IsMatch(pac.telefono, @"^\d{9}$"))
                throw new Exception("El teléfono debe contener exactamente 9 dígitos");

            try
            {
                pacienteAD.agregar(pac);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            
        }

        public void Modificar(Paciente pac)
        {
            if (pac.idPaciente <= 0)
                throw new Exception("Paciente inválido");

            if (string.IsNullOrWhiteSpace(pac.nombres))
                throw new Exception("El nombre del paciente es obligatorio");

            if (string.IsNullOrWhiteSpace(pac.apellidoPat))
                throw new Exception("El apellido paterno es obligatorio");

            if (pac.DNI.ToString().Length != 8)
                throw new Exception("El DNI debe ser válido (8 dígitos)");

            if (string.IsNullOrWhiteSpace(pac.DNI))
                throw new Exception("El DNI del paciente es obligatorio");


            if (string.IsNullOrWhiteSpace(pac.telefono))
                throw new Exception("El teléfono es obligatorio");

            if (pac.telefono.Length != 9 || !pac.telefono.All(char.IsDigit))
                throw new Exception("El teléfono debe contener exactamente 9 dígitos numéricos");

            try
            {
                pacienteAD.modificar(new Paciente()
                {
                    idPaciente = pac.idPaciente,
                    DNI = pac.DNI,
                    nombres = pac.nombres,
                    apellidoPat = pac.apellidoPat,
                    apellidoMat = pac.apellidoMat,
                    telefono = pac.telefono,
                    direccion = pac.direccion
                });
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public List<Paciente> listado()
        {
            try
            {
                return pacienteAD.listado();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public Paciente BuscarPacienteXDNI(string DNI)
        {
            try
            {
                return pacienteAD.BuscarPaciente(DNI);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

    }
}
