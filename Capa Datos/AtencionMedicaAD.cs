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
    public class AtencionMedicaAD
    {
        public void agregar(AtencionMedica nuevo)
        {
            try
            {
                using (var cn = Conexion.GetConexion())
                {
                    cn.Open();
                    // llamar al procedimiento almacenado en sql
                    SqlCommand cmd = new SqlCommand("pa_AgregarAtencionMedica", cn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    // Enviar parametros del INSERT INTO
                    cmd.Parameters.AddWithValue("@idCita", nuevo.idCita);
                    cmd.Parameters.AddWithValue("@diagnostico", nuevo.diagnostico);
                    cmd.Parameters.AddWithValue("@observaciones", nuevo.observaciones);
                    cmd.Parameters.AddWithValue("@fechaAtencion", nuevo.fechaAtencion);

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

        public void modificar(AtencionMedica nuevo)
        {
            try
            {
                using (var cn = Conexion.GetConexion())
                {
                    cn.Open();
                    // Llamar al procedimiento almacenado
                    SqlCommand cmd = new SqlCommand("pa_ModificarAtencionMedica", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    // Enviar parámetros
                    cmd.Parameters.AddWithValue("@idAtencion", nuevo.idAtencion);
                    cmd.Parameters.AddWithValue("@idCita", nuevo.idCita);
                    cmd.Parameters.AddWithValue("@diagnostico", nuevo.diagnostico);
                    cmd.Parameters.AddWithValue("@observaciones", nuevo.observaciones);
                    cmd.Parameters.AddWithValue("@fechaAtencion", nuevo.fechaAtencion);
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

        public List<AtencionMedica> lista()
        {
            List<AtencionMedica> lista = new List<AtencionMedica>();
            try
            {
                using (var cn = Conexion.GetConexion())
                {
                    cn.Open();
                    // Llamar al procedimiento almacenado
                    SqlCommand cmd = new SqlCommand("pa_listarAtencionMedica", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    // Ejecutar el comando y obtener el resultado
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        AtencionMedica atencion = new AtencionMedica();
                        atencion.idAtencion = Convert.ToInt32(dr["idAtencion"]);
                        atencion.idCita = Convert.ToInt32(dr["idCita"]);
                        atencion.diagnostico = dr["diagnostico"].ToString();
                        atencion.observaciones = dr["observaciones"].ToString();
                        atencion.fechaAtencion = Convert.ToDateTime(dr["fechaAtencion"]);
                        atencion.nombrePaciente = dr["nombrePaciente"] == DBNull.Value
                        ? null
                        : dr["nombrePaciente"].ToString();
                        atencion.nombreMedico = dr["nombreMedico"] == DBNull.Value
                        ? null
                        : dr["nombreMedico"].ToString();
                        lista.Add(atencion);
                    }
                    cn.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return lista;
        }
        public List<AtencionMedica> ListarPorMedico(int idMedico)
        {
            List<AtencionMedica> lista = new List<AtencionMedica>();
            try
            {
                using (SqlConnection cn = Conexion.GetConexion())
                {
                    // Importante: Asegúrate que pa_listarAtencionMedica devuelva idMedico y estadoCita
                    SqlCommand cmd = new SqlCommand("pa_listarAtencionMedica", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            // Validamos que la columna idMedico exista y no sea nula antes de comparar
                            int idMedBD = dr["idMedico"] != DBNull.Value ? Convert.ToInt32(dr["idMedico"]) : 0;

                            if (idMedBD == idMedico)
                            {
                                lista.Add(new AtencionMedica
                                {
                                    idAtencion = Convert.ToInt32(dr["idAtencion"]),
                                    idCita = Convert.ToInt32(dr["idCita"]),
                                    diagnostico = dr["diagnostico"]?.ToString() ?? "",
                                    observaciones = dr["observaciones"]?.ToString() ?? "",
                                    fechaAtencion = Convert.ToDateTime(dr["fechaAtencion"]),
                                    nombrePaciente = dr["nombrePaciente"]?.ToString() ?? "Sin nombre",
                                    nombreMedico = dr["nombreMedico"]?.ToString() ?? "Sin nombre",
                                    // Asegúrate que esta propiedad exista en tu clase AtencionMedica
                                    estadoCita = dr["estadoCita"] != DBNull.Value ? Convert.ToInt32(dr["estadoCita"]) : 0
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error en Capa de Datos (ListarPorMedico): " + ex.Message);
            }
            return lista;
        }
    }
}
