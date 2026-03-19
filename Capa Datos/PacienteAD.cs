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
    public class PacienteAD
    {
        public void agregar(Paciente nuevo)
        {
            try
            {
                using (var cn = Conexion.GetConexion())
                {
                    cn.Open();
                    // llamar al procedimiento almacenado en sql
                    SqlCommand cmd = new SqlCommand("pa_registro_Paciente", cn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    // Enviar parametros del INSERT INTO
                    cmd.Parameters.AddWithValue("@DNI", nuevo.DNI);
                    cmd.Parameters.AddWithValue("@nombres", nuevo.nombres);
                    cmd.Parameters.AddWithValue("@apellidoPat", nuevo.apellidoPat);
                    cmd.Parameters.AddWithValue("@apellidoMat", nuevo.apellidoMat);
                    cmd.Parameters.AddWithValue("@telefono", nuevo.telefono);
                    cmd.Parameters.AddWithValue("@direccion", nuevo.direccion);
                    //Ejecutar el comando
                    cmd.ExecuteNonQuery();
                    cn.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public void modificar(Paciente nuevo)
        {
            try
            {
                using (var cn = Conexion.GetConexion())
                {
                    cn.Open();

                    // Llamar al procedimiento almacenado
                    SqlCommand cmd = new SqlCommand("pa_actualizar_paciente", cn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Enviar parámetros
                    cmd.Parameters.AddWithValue("@idPaciente", nuevo.idPaciente);
                    cmd.Parameters.AddWithValue("@DNI", nuevo.DNI);
                    cmd.Parameters.AddWithValue("@nombres", nuevo.nombres);
                    cmd.Parameters.AddWithValue("@apellidoPat", nuevo.apellidoPat);
                    cmd.Parameters.AddWithValue("@apellidoMat", nuevo.apellidoMat);
                    cmd.Parameters.AddWithValue("@telefono", nuevo.telefono);
                    cmd.Parameters.AddWithValue("@direccion", nuevo.direccion);

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
        public List<Paciente> listado()
        {
            var lista = new List<Paciente>();

            try
            {
                using (var cn = Conexion.GetConexion())
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand("select * from Paciente", cn);

                    //ejecutar y recuperar los regisstros de la tabla
                    SqlDataReader dr = cmd.ExecuteReader();
                    //convertir las tuplas a objetos
                    while (dr.Read())
                    {
                        lista.Add(new Paciente()
                        {
                            idPaciente = dr.GetInt32(0),
                            DNI = dr.GetString(1),
                            nombres = dr.GetString(2),
                            apellidoPat = dr.GetString(3),
                            apellidoMat = dr.GetString(4),
                            telefono = dr.GetString(5),
                            direccion = dr.GetString(6),
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

        public Paciente BuscarPaciente(string DNI)
        {
            try
            {
                using (var cn = Conexion.GetConexion())
                {
                    cn.Open();

                    SqlCommand cmd = new SqlCommand("SELECT s.* " +
                        "FROM Paciente s " +
                        "WHERE s.DNI = @DNI", cn);

                    cmd.Parameters.AddWithValue("@DNI", DNI);

                    SqlDataReader dr = cmd.ExecuteReader();

                    Paciente paciente = null;

                    if (dr.Read())
                    {
                        paciente = new Paciente
                        {
                            idPaciente = dr.GetInt32(0),
                            DNI = dr.GetString(1),
                            nombres = dr.GetString(2),
                            apellidoPat = dr.GetString(3),
                            apellidoMat = dr.GetString(4),
                            telefono = dr.GetString(5),
                            direccion = dr.GetString(6)
                        };
                    }

                    dr.Close();
                    cn.Close();

                    return paciente;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
