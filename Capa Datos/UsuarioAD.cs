using CapaModelo;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class UsuarioAD
    {
        public void agregar(Usuario nuevo)
        {
            try
            {
                using (var cn = Conexion.GetConexion())
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand("pa_registro_Usuario", cn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@usuario", nuevo.usuario);
                    cmd.Parameters.AddWithValue("@contraseña", nuevo.contraseña);
                    cmd.Parameters.AddWithValue("@estado", nuevo.estado);
                    cmd.Parameters.AddWithValue("@rol", nuevo.Rol);

                    // Lógica para manejar los nulos de las llaves foráneas
                    cmd.Parameters.AddWithValue("@idmedico", (object)nuevo.idMedico ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@idpaciente", (object)nuevo.idPaciente ?? DBNull.Value);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar usuario: " + ex.Message);
            }
        }

        public void modificar(Usuario nuevo)
        {
            try
            {
                using (var cn = Conexion.GetConexion())
                {
                    cn.Open();

                    // Llamar al procedimiento almacenado
                    SqlCommand cmd = new SqlCommand("pa_actualizar_usuario", cn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Enviar parámetros
                    cmd.Parameters.AddWithValue("@idUsuario", nuevo.idUsuario);
                    cmd.Parameters.AddWithValue("@usuario", nuevo.usuario);
                    cmd.Parameters.AddWithValue("@contraseña", nuevo.contraseña);
                    cmd.Parameters.AddWithValue("@estado", nuevo.estado);
                    cmd.Parameters.AddWithValue("@rol", nuevo.Rol);

                    // Lógica para manejar los nulos de las llaves foráneas
                    cmd.Parameters.AddWithValue("@idmedico", (object)nuevo.idMedico ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@idpaciente", (object)nuevo.idPaciente ?? DBNull.Value);

                    // Ejecutar el comando
                    cmd.ExecuteNonQuery();
                    cn.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Usuario> listado()
        {
            var lista = new List<Usuario>();

            try
            {
                using (var cn = Conexion.GetConexion())
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(
                        "SELECT u.*" +
                        "FROM Usuario u ", cn);

                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        lista.Add(new Usuario()
                        {
                            idUsuario = (int)dr["idUsuario"],
                            usuario = dr["usuario"].ToString(),
                            contraseña = dr["contraseña"].ToString(),
                            estado = (bool)dr["estado"],
                            Rol = (int)dr["rol"],
                           
                            // Manejo de nulos para las FKs (Usa el tipo int? del modelo)
                            idMedico = dr["idMedico"] == DBNull.Value ? (int?)null : (int)dr["idMedico"],
                            idPaciente = dr["idPaciente"] == DBNull.Value ? (int?)null : (int)dr["idPaciente"]
                        });
                    }
                    dr.Close();
                    cn.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return lista;
        }

        public Usuario ValidarUsuario(string user, string pass)
        {
            Usuario usuarioLogueado = null;
            try
            {
                using (var cn = Conexion.GetConexion())
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand("pa_validar_login", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@usuario", user);
                    cmd.Parameters.AddWithValue("@contraseña", pass);

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            usuarioLogueado = new Usuario()
                            {
                                idUsuario = (int)dr["idUsuario"],
                                usuario = dr["usuario"].ToString(),
                                Rol = (int)dr["rol"],
                                // Manejo de nulos para los vínculos
                                idMedico = dr["idMedico"] == DBNull.Value ? (int?)null : (int)dr["idMedico"],
                                idPaciente = dr["idPaciente"] == DBNull.Value ? (int?)null : (int)dr["idPaciente"]
                            };
                        }
                    }
                }
            }
            catch (Exception ex) { throw new Exception("Error en Login: " + ex.Message); }
            return usuarioLogueado;
        }

    }
}
