using CapaDatos;
using CapaModelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class UsuarioLN
    {
        private readonly UsuarioAD usuarioAD;

        public UsuarioLN()
        {
            usuarioAD = new UsuarioAD();
        }

        // --- MÉTODO PARA EL LOGIN ---
        public Usuario ValidarLogin(string user, string pass)
        {
            if (string.IsNullOrWhiteSpace(user) || string.IsNullOrWhiteSpace(pass))
                throw new Exception("Debe ingresar sus credenciales.");

            // Aquí podrías añadir encriptación si la usas
            return usuarioAD.ValidarUsuario(user, pass);
        }

        // --- MÉTODO AGREGAR ---
        public void Agregar(Usuario usuario)
        {
            // Ahora validamos el 'Identificador' (DNI/CMP)
            if (string.IsNullOrWhiteSpace(usuario.usuario))
                throw new Exception("El identificador (DNI/CMP) es obligatorio.");

            if (string.IsNullOrWhiteSpace(usuario.contraseña) || usuario.contraseña.Length < 6)
                throw new Exception("La contraseña debe tener al menos 6 caracteres.");

            if (usuario.Rol <= 0)
                throw new Exception("Debe seleccionar un rol válido.");

            // Opcional: Validar que no sea médico y paciente a la vez
            if (usuario.idMedico != null && usuario.idPaciente != null)
                throw new Exception("Error: El usuario no puede ser Médico y Paciente simultáneamente.");

            try
            {
                usuarioAD.agregar(usuario);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // --- MÉTODO MODIFICAR ---
        public void Modificar(Usuario usuario)
        {
            if (usuario.idUsuario <= 0)
                throw new Exception("ID de Usuario no válido.");

            if (string.IsNullOrWhiteSpace(usuario.usuario))
                throw new Exception("El identificador es obligatorio.");

            if (string.IsNullOrWhiteSpace(usuario.contraseña) || usuario.contraseña.Length < 6)
                throw new Exception("La contraseña debe tener al menos 6 caracteres.");

            try
            {
                usuarioAD.modificar(usuario);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // --- MÉTODO LISTADO ---
        public List<Usuario> Listado()
        {
            try
            {
                return usuarioAD.listado();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


    }
}
