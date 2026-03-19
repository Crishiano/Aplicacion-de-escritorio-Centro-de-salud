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
    public class MedicoAD
    {
        public void agregar(Medico nuevo)
        {
            try
            {
                using (var cn = Conexion.GetConexion())
                {
                    cn.Open();
                    // llamar al procedimiento almacenado en sql
                    SqlCommand cmd = new SqlCommand("pa_registro_Medico", cn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    // Enviar parametros del INSERT INTO
                    cmd.Parameters.AddWithValue("@CMP", nuevo.cmp);
                    cmd.Parameters.AddWithValue("@nombres", nuevo.nombres);
                    cmd.Parameters.AddWithValue("@apellidoPat", nuevo.apellidoPat);
                    cmd.Parameters.AddWithValue("@apellidoMat", nuevo.apellidoMat);
                    cmd.Parameters.AddWithValue("@estado", nuevo.estado);
                    cmd.Parameters.AddWithValue("@idespecialidad", nuevo.idEspecialidad);
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
        public void modificar(Medico nuevo)
        {
            try
            {
                using (var cn = Conexion.GetConexion())
                {
                    cn.Open();

                    // Llamar al procedimiento almacenado
                    SqlCommand cmd = new SqlCommand("pa_actualizar_medico", cn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Enviar parámetros
                    cmd.Parameters.AddWithValue("@idMedico", nuevo.idMedico);
                    cmd.Parameters.AddWithValue("@CMP", nuevo.cmp);
                    cmd.Parameters.AddWithValue("@nombres", nuevo.nombres);
                    cmd.Parameters.AddWithValue("@apellidoPat", nuevo.apellidoPat);
                    cmd.Parameters.AddWithValue("@apellidoMat", nuevo.apellidoMat);
                    cmd.Parameters.AddWithValue("@estado", nuevo.estado);
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
        public List<Medico> listado()
        {
            var lista = new List<Medico>();

            try
            {
                using (var cn = Conexion.GetConexion())
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand("select *, e.nombre as nombreEspecialidad " +
                                    "   from Medico m INNER JOIN Especialidad e ON m.idEspecialidad = e.idEspecialidad ", cn);
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        lista.Add(new Medico()
                        {
                            idMedico = dr.GetInt32(0),
                            cmp = dr.GetString(1),
                            nombres = dr.GetString(2),
                            apellidoPat = dr.GetString(3),
                            apellidoMat = dr.GetString(4),
                            estado = dr.GetBoolean(5),
                            idEspecialidad = dr.GetInt32(6),
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

        public List<Medico> ListarPorEspecialidad(int idEspecialidad)
        {
            List<Medico> lista = new List<Medico>();

            try
            {
                using (var cn = Conexion.GetConexion())
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand("pa_ListarMedicosPorEspecialidad", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idEspecialidad", idEspecialidad);

                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        lista.Add(new Medico()
                        {
                            idMedico = (int)dr["idMedico"],
                            cmp = dr["CMP"].ToString(),
                            nombres = dr["nombres"].ToString(),
                            apellidoPat = dr["apellidoPat"].ToString(),
                            apellidoMat = dr["apellidoMat"].ToString(),
                            estado = Convert.ToBoolean(dr["estado"]),
                            idEspecialidad = (int)dr["idEspecialidad"],
                            nombreEspecialidad = dr["nombreEspecialidad"].ToString(),
                            nombreCompleto = dr["nombreCompleto"].ToString()
                        });
                    }

                    dr.Close();
                    cn.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al listar médicos: {ex.Message}");
            }

            return lista;
        }

        public List<HorarioMedico> listadoTodosHorarios(int idEspecialidad)
        {
            var lista = new List<HorarioMedico>();

            try
            {
                using (var cn = Conexion.GetConexion())
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand("pa_listarHorariosMedicosXEspecialidad", cn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idEspecialidad", idEspecialidad);

                    //ejecutar y recuperar los regisstros de la tabla
                    SqlDataReader dr = cmd.ExecuteReader();
                    //convertir las tuplas a objetos
                    while (dr.Read())
                    {
                        lista.Add(new HorarioMedico()
                        {
                            idHorarioMedico = dr.GetInt32(0),
                            DiaSemana = dr.GetByte(1),
                            HoraInicio = dr.GetTimeSpan(2),
                            HoraFin = dr.GetTimeSpan(3),
                            idmedico = dr.GetInt32(4),
                            nombreMedico = dr["nombreMedico"] == DBNull.Value
                        ? null
                        : dr["nombreMedico"].ToString(),
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

        public bool ExisteMedicoDisponible(int idEspecialidad, int diaSemana)
        {
            bool existe = false;

            using (SqlConnection cn = Conexion.GetConexion())
            {
                cn.Open();

                string query = @"
                                    SELECT COUNT(*)
                                    FROM Medico m
                                    INNER JOIN HorarioMedico h ON m.idMedico = h.idMedico
                                    WHERE m.idEspecialidad = @idEspecialidad
                                    AND h.DiaSemana = @diaSemana AND m.estado = 1";

                using (SqlCommand cmd = new SqlCommand(query, cn))
                {
                    cmd.Parameters.AddWithValue("@idEspecialidad", idEspecialidad);
                    cmd.Parameters.AddWithValue("@diaSemana", diaSemana);

                    int cantidad = Convert.ToInt32(cmd.ExecuteScalar());
                    existe = cantidad > 0;
                }
            }

            return existe;
        }

        public bool HoraDentroDeHorario(int idMedico, DateOnly fecha, TimeOnly hora)
        {
            using (SqlConnection cn = Conexion.GetConexion())
            {
                cn.Open();

                int diaSemana = (int)fecha.DayOfWeek;
                if (diaSemana == 0)
                    diaSemana = 7;

                string query = @"SELECT COUNT(*)
                                FROM HorarioMedico
                                WHERE idMedico = @idMedico
                                AND DiaSemana = @diaSemana
                                AND @hora >= HoraInicio
                                AND @hora < HoraFin";

                using (SqlCommand cmd = new SqlCommand(query, cn))
                {
                    cmd.Parameters.AddWithValue("@idMedico", idMedico);
                    cmd.Parameters.AddWithValue("@diaSemana", diaSemana);
                    cmd.Parameters.AddWithValue("@hora", hora);

                    int cantidad = Convert.ToInt32(cmd.ExecuteScalar());
                    return cantidad > 0;
                }
            }
        }

        
    }
}
