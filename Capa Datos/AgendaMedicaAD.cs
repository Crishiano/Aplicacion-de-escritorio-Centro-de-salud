using CapaModelo;
using CapaDatos;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class AgendaMedicaAD
    {
        public void agregar(AgendaMedica nuevo)
        {
            try
            {
                using (var cn = Conexion.GetConexion())
                {
                    cn.Open();

                    // Llamar al procedimiento almacenado correcto
                    SqlCommand cmd = new SqlCommand("registro_agenda", cn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    // Enviar parámetros correctos
                    cmd.Parameters.AddWithValue("@fecha", nuevo.fecha);
                    cmd.Parameters.AddWithValue("@cupo", nuevo.cupos);
                    cmd.Parameters.AddWithValue("@idEspecialidad", nuevo.idEspecialidad);

                    // Ejecutar
                    cmd.ExecuteNonQuery();
                    cn.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void modificar(AgendaMedica nuevo)
        {
            try
            {
                using (var cn = Conexion.GetConexion())
                {
                    cn.Open();

                    // Llamar al procedimiento almacenado correcto
                    SqlCommand cmd = new SqlCommand("modificar_agenda", cn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Enviar parámetros correctos
                    cmd.Parameters.AddWithValue("@idAgenda", nuevo.idAgenda);
                    cmd.Parameters.AddWithValue("@fecha", nuevo.fecha);
                    cmd.Parameters.AddWithValue("@cupo", nuevo.cupos);
                    cmd.Parameters.AddWithValue("@idEspecialidad", nuevo.idEspecialidad);

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

        public List<AgendaMedica> listado()
        {
            var lista = new List<AgendaMedica>();

            try
            {
                using (var cn = Conexion.GetConexion())
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand("pa_listarAgenda", cn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Ejecutar y recuperar los registros
                    SqlDataReader dr = cmd.ExecuteReader();

                    // Convertir las filas en objetos
                    while (dr.Read())
                    {
                        lista.Add(new AgendaMedica()
                        {
                            idAgenda = dr.GetInt32(0),
                            fecha = DateOnly.FromDateTime(dr.GetDateTime(1)),
                            cupos = dr.GetInt32(2),
                            idEspecialidad = dr.GetInt32(3),
                            nombreEspecialidad = dr["nombreEspecialidad"] == DBNull.Value
                        ? null
                        : dr["nombreEspecialidad"].ToString(),

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

        public List<AgendaMedica> ListarPorMedico(int idMedico)
        {
            List<AgendaMedica> lista = new List<AgendaMedica>();

            try
            {
                using (var cn = Conexion.GetConexion())
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand("pa_ListarAgendasPorMedico", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idMedico", idMedico);

                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        lista.Add(new AgendaMedica()
                        {
                            idAgenda = (int)dr["idAgenda"],
                            fecha = DateOnly.FromDateTime((DateTime)dr["fecha"]),
                            cupos = (int)dr["cupos"],
                            idEspecialidad = (int)dr["idEspecialidad"],
                            nombreEspecialidad = dr["nombreEspecialidad"].ToString(),
                            cuposOcupados = (int)dr["cuposOcupados"],
                            cuposDisponibles = (int)dr["cuposDisponibles"],
                            descripcionAgenda = dr["descripcionAgenda"].ToString()
                        });
                    }

                    dr.Close();
                    cn.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al listar agendas: {ex.Message}");
            }

            return lista;
        }
    }
}
