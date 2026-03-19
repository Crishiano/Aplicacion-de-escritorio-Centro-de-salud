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
    public class HorarioMedicoAD
    {
        public void agregar(HorarioMedico nuevo)
        {
            try
            {
                using (var cn = Conexion.GetConexion())
                {
                    cn.Open();
                    // llamar al procedimiento almacenado en sql
                    SqlCommand cmd = new SqlCommand("pa_registro_horarioMedico", cn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    // Enviar parametros del INSERT INTO
                    cmd.Parameters.AddWithValue("@diasemana", nuevo.DiaSemana);
                    cmd.Parameters.AddWithValue("@horainicio", nuevo.HoraInicio);
                    cmd.Parameters.AddWithValue("@horafin", nuevo.HoraFin);
                    cmd.Parameters.AddWithValue("@idmedico", nuevo.idmedico);
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

        public void modificar(HorarioMedico nuevo)
        {
            try
            {
                using (var cn = Conexion.GetConexion())
                {
                    cn.Open();

                    // Llamar al procedimiento almacenado
                    SqlCommand cmd = new SqlCommand("pa_actualizar_horarioMedico", cn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Enviar parámetros
                    cmd.Parameters.AddWithValue("@idHorarioMedico", nuevo.idHorarioMedico);
                    cmd.Parameters.AddWithValue("@diaSemana", nuevo.DiaSemana);
                    cmd.Parameters.AddWithValue("@horaInicio", nuevo.HoraInicio);
                    cmd.Parameters.AddWithValue("@horaFin", nuevo.HoraFin);
                    cmd.Parameters.AddWithValue("@idMedico", nuevo.idmedico);

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
        public List<HorarioMedico> listado()
        {
            var lista = new List<HorarioMedico>();

            try
            {
                using (var cn = Conexion.GetConexion())
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand("select * from HorarioMedico", cn);

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


        public List<HorarioMedico> listarPorMedico(int idMedico)
        {
            var lista = new List<HorarioMedico>();
            try
            {
                using (var cn = Conexion.GetConexion())
                {
                    cn.Open();
                    // Filtramos por idMedico para no cargar datos que no corresponden
                    SqlCommand cmd = new SqlCommand("SELECT * FROM HorarioMedico WHERE idmedico = @id", cn);
                    cmd.Parameters.AddWithValue("@id", idMedico);

                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        lista.Add(new HorarioMedico()
                        {
                            idHorarioMedico = dr.GetInt32(0),
                            DiaSemana = dr.GetByte(1),
                            HoraInicio = dr.GetTimeSpan(2),
                            HoraFin = dr.GetTimeSpan(3),
                            idmedico = dr.GetInt32(4),
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar horarios por médico: " + ex.Message);
            }
            return lista;
        }

        /*public bool HoraDentroDeHorario(int idMedico, DateOnly fecha, TimeOnly hora)
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
        }*/
    }

}
