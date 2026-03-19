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
    public class CitaAD
    {
        public void agregar(Cita nuevo)
        {
            try
            {
                using (var cn = Conexion.GetConexion())
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand("pa_AgregarCita", cn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idPaciente", nuevo.idPaciente);
                    cmd.Parameters.AddWithValue("@idAgenda", nuevo.idAgenda);
                    cmd.Parameters.AddWithValue("@hora", nuevo.hora);
                    cmd.Parameters.AddWithValue("@idUsuario", nuevo.idUsuario);
                    cmd.Parameters.AddWithValue("@estado", nuevo.estado);
                    cmd.Parameters.AddWithValue("@motivo", nuevo.motivo);
                    cmd.Parameters.AddWithValue("@fecha", nuevo.fecha);
                    cmd.Parameters.AddWithValue("@idMedico", nuevo.idMedico > 0 ? nuevo.idMedico : (object)DBNull.Value);
                    cmd.ExecuteNonQuery();
                    cn.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void modificar(Cita nuevo)
        {
            try
            {
                using (var cn = Conexion.GetConexion())
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand("pa_ModificarCita", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idCita", nuevo.idCita);
                    cmd.Parameters.AddWithValue("@estado", nuevo.estado);
                    cmd.Parameters.AddWithValue("@motivo", nuevo.motivo);
                    cmd.ExecuteNonQuery();
                    cn.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void modificarEstado(Cita nuevo)
        {
            try
            {
                using (var cn = Conexion.GetConexion())
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand("pa_modificarEstado", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idCita", nuevo.idCita);
                    cmd.Parameters.AddWithValue("@estado", nuevo.estado);
                    cmd.ExecuteNonQuery();
                    cn.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool ValidarDisponibilidadHorario(int idMedico, DateOnly fecha, TimeOnly hora, out string mensaje, int? idCitaActual = null)
        {
            mensaje = "";
            bool disponible = true;

            try
            {
                using (var cn = Conexion.GetConexion())
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand("pa_ValidarDisponibilidadHorario", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idMedico", idMedico);
                    cmd.Parameters.AddWithValue("@fecha", fecha);
                    cmd.Parameters.AddWithValue("@hora", hora);
                    cmd.Parameters.AddWithValue("@idCitaActual", idCitaActual ?? (object)DBNull.Value);

                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        bool existeConflicto = dr["ExisteConflicto"] != DBNull.Value && Convert.ToBoolean(dr["ExisteConflicto"]);
                        mensaje = dr["Mensaje"].ToString();
                        disponible = !existeConflicto;
                    }

                    dr.Close();
                    cn.Close();
                }
            }
            catch (Exception ex)
            {
                mensaje = $"Error al validar disponibilidad: {ex.Message}";
                disponible = false;
            }

            return disponible;
        }

        
        public List<HoraDisponible> ObtenerHorasDisponibles(int idMedico, DateOnly fecha, TimeOnly horaInicio, TimeOnly horaFin)
        {
            List<HoraDisponible> horas = new List<HoraDisponible>();

            try
            {
                using (var cn = Conexion.GetConexion())
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand("pa_ObtenerHorasDisponibles", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idMedico", idMedico);
                    cmd.Parameters.AddWithValue("@fecha", fecha);
                    cmd.Parameters.AddWithValue("@horaInicio", horaInicio);
                    cmd.Parameters.AddWithValue("@horaFin", horaFin);

                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        horas.Add(new HoraDisponible()
                        {
                            Hora = TimeOnly.FromTimeSpan((TimeSpan)dr["Hora"]),
                            Disponible = Convert.ToBoolean(dr["Disponible"]),
                            MotivoNoDisponible = dr["MotivoNoDisponible"] == DBNull.Value ? null : dr["MotivoNoDisponible"].ToString(),
                            HoraFormato = dr["HoraFormato"].ToString(),
                            HoraDescripcion = dr["HoraDescripcion"].ToString()
                        });
                    }

                    dr.Close();
                    cn.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener horas disponibles: {ex.Message}");
            }

            return horas;
        }

        public void CancelarManual(int idCita, int idUsuario, string motivoCancelacion = null)
        {
            try
            {
                using (var cn = Conexion.GetConexion())
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand("pa_CancelarCitaManual", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idCita", idCita);
                    cmd.Parameters.AddWithValue("@idUsuario", idUsuario);
                    cmd.Parameters.AddWithValue("@motivoCancelacion", motivoCancelacion ?? (object)DBNull.Value);
                    cmd.ExecuteNonQuery();
                    cn.Close();
                }
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
                using (var cn = Conexion.GetConexion())
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand("pa_CancelarCitasVencidas", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();
                    cn.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool PuedeCancelarCita(int idCita, out string mensaje)
        {
            mensaje = "";
            bool puedeCancelar = false;

            try
            {
                using (var cn = Conexion.GetConexion())
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand("pa_PuedeCancelarCita", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idCita", idCita);

                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        puedeCancelar = dr["PuedeCancelar"] != DBNull.Value && (bool)dr["PuedeCancelar"];
                        mensaje = dr["Mensaje"].ToString();
                    }

                    dr.Close();
                    cn.Close();
                }
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
                puedeCancelar = false;
            }

            return puedeCancelar;
        }

        public List<Cita> lista()
        {
            List<Cita> lista = new List<Cita>();

            try
            {
                using (var cn = Conexion.GetConexion())
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand("pa_listarCita", cn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        lista.Add(new Cita()
                        {
                            idCita = (int)dr["idCita"],
                            idPaciente = (int)dr["idPaciente"],
                            idAgenda = (int)dr["idAgenda"],
                            hora = TimeOnly.FromTimeSpan((TimeSpan)dr["hora"]),
                            idUsuario = (int)dr["idUsuario"],
                            estado = (int)dr["estado"],
                            motivo = dr["motivo"] == DBNull.Value 
                                ? null 
                                : dr["motivo"].ToString(),
                            fecha = DateOnly.FromDateTime((DateTime)dr["fecha"]),
                            idMedico = dr["idMedico"] == DBNull.Value 
                                ? 0 
                                : (int)dr["idMedico"],

                            nombrePaciente = dr["nombrePaciente"] == DBNull.Value
                                ? null
                                : dr["nombrePaciente"].ToString(),

                            nombreUsuario = dr["nombreUsuario"] == DBNull.Value
                                ? null
                                : dr["nombreUsuario"].ToString(),

                            nombreMedico = dr["nombreMedico"] == DBNull.Value
                                ? null
                                : dr["nombreMedico"].ToString(),

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

        public Cita ObtenerDetalle(int idCita)
        {
            Cita cita = null;

            try
            {
                using (var cn = Conexion.GetConexion())
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand("pa_ObtenerDetalleCita", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idCita", idCita);

                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        cita = new Cita()
                        {
                            idCita = (int)dr["idCita"],
                            idPaciente = (int)dr["idPaciente"],
                            nombrePaciente = dr["nombrePaciente"].ToString(),
                            idMedico = dr["idMedico"] == DBNull.Value ? 0 : (int)dr["idMedico"],
                            nombreMedico = dr["nombreMedico"] == DBNull.Value ? null : dr["nombreMedico"].ToString(),
                            nombreEspecialidad = dr["nombreEspecialidad"] == DBNull.Value ? null : dr["nombreEspecialidad"].ToString(),
                            idAgenda = (int)dr["idAgenda"],
                            hora = TimeOnly.FromTimeSpan((TimeSpan)dr["hora"]),
                            fecha = DateOnly.FromDateTime((DateTime)dr["fecha"]),
                            idUsuario = (int)dr["idUsuario"],
                            nombreUsuario = dr["nombreUsuario"].ToString(),
                            estado = (int)dr["estado"],
                            motivo = dr["motivo"] == DBNull.Value ? null : dr["motivo"].ToString()
                        };
                    }

                    dr.Close();
                    cn.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener detalle: {ex.Message}");
            }

            return cita;
        }

        public List<Cita> ObtenerHistorial(int idPaciente)
        {
            List<Cita> lista = new List<Cita>();
            try
            {
                using (SqlConnection cn = Conexion.GetConexion())
                {
                    SqlCommand cmd = new SqlCommand("pa_HistorialPaciente", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idPaciente", idPaciente);
                    cn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Cita
                            {
                                idCita = (int)dr["idCita"],
                                fecha = DateOnly.FromDateTime((DateTime)dr["fecha"]),
                                hora = TimeOnly.FromTimeSpan((TimeSpan)dr["hora"]),
                                nombreMedico = dr["nombreMedico"].ToString(),
                                nombreEspecialidad = dr["nombreEspecialidad"].ToString(),
                                motivo = dr["motivo"].ToString(),
                                estado = (int)dr["estado"] // El get de 'nombreEstado' funcionará solo
                            });
                        }
                    }
                }
            }
            catch (Exception ex) { throw new Exception("Error en datos: " + ex.Message); }
            return lista;
        }

        public DataTable ListadoCitasPorRango(DateTime fechaInicio, DateTime fechaFin)
        {
            DataTable dt = new DataTable();

            try
            {
                using (var cn = Conexion.GetConexion())
                {
                    cn.Open();

                    // Llamar al procedimiento almacenado
                    SqlCommand cmd = new SqlCommand("pa_CitasPorRangoFechas", cn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    // Enviar parámetros
                    cmd.Parameters.Add("@FechaInicio", SqlDbType.Date).Value = fechaInicio.Date;
                    cmd.Parameters.Add("@FechaFin", SqlDbType.Date).Value = fechaFin.Date;

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);

                    cn.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return dt;
        }

        public DataTable citapormedico(int idmedico)
        {
            DataTable dt = new DataTable();

            try
            {
                using (var cn = Conexion.GetConexion())
                {
                    cn.Open();

                    // Llamar al procedimiento almacenado
                    SqlCommand cmd = new SqlCommand("pa_CitasPorMedico", cn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    // Enviar parámetros
                    cmd.Parameters.Add("@idmedico", SqlDbType.Int).Value = idmedico;

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);

                    cn.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return dt;
        }

        public DataTable citaporestado(int estado)
        {
            DataTable dt = new DataTable();

            try
            {
                using (var cn = Conexion.GetConexion())
                {
                    cn.Open();

                    // Llamar al procedimiento almacenado
                    SqlCommand cmd = new SqlCommand("pa_CitasPorestado", cn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    // Enviar parámetros
                    cmd.Parameters.Add("@estado", SqlDbType.Int).Value = estado;

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);

                    cn.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return dt;
        }
    }

    public class HoraDisponible
    {
        public TimeOnly Hora { get; set; }
        public bool Disponible { get; set; }
        public string MotivoNoDisponible { get; set; }
        public string HoraFormato { get; set; }
        public string HoraDescripcion { get; set; }

        public override string ToString()
        {
            return HoraDescripcion;
        }

    }






}
