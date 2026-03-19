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
    public class DetalleRecetaAD
    {
        public bool Agregar(DetalleReceta obj)
        {
            bool respuesta = false;
            try
            {
                using (SqlConnection cn = Conexion.GetConexion())
                {
                    SqlCommand cmd = new SqlCommand("pa_insertar_detalle_receta", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idReceta", obj.idReceta);
                    cmd.Parameters.AddWithValue("@idMedicamento", obj.idMedicamento);
                    cmd.Parameters.AddWithValue("@dosis", obj.dosis);
                    cmd.Parameters.AddWithValue("@frecuencia", obj.frecuencia);
                    cmd.Parameters.AddWithValue("@duracion", obj.duracion);
                    cmd.Parameters.AddWithValue("@indicaciones", obj.indicaciones);

                    cn.Open();
                    respuesta = cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex) { throw new Exception("Error al insertar detalle: " + ex.Message); }
            return respuesta;
        }

        public bool Eliminar(int idDetalleReceta)
        {
            bool respuesta = false;
            try
            {
                using (SqlConnection cn = Conexion.GetConexion())
                {
                    string query = "DELETE FROM DetalleReceta WHERE idDetalleReceta = @id";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@id", idDetalleReceta);
                    cn.Open();
                    respuesta = cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex) { throw new Exception("Error al eliminar detalle: " + ex.Message); }
            return respuesta;
        }


        public List<DetalleReceta> ListarPorReceta(int idReceta)
        {
            List<DetalleReceta> lista = new List<DetalleReceta>();
            try
            {
                using (SqlConnection cn = Conexion.GetConexion())
                {
                    // Usamos un query con JOIN para traer el nombre del medicamento
                    string query = @"SELECT d.*, m.nombre as nombreMedicamento, m.presentacion 
                                 FROM DetalleReceta d
                                 INNER JOIN Medicamento m ON d.idMedicamento = m.idMedicamento
                                 WHERE d.idReceta = @idReceta";

                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@idReceta", idReceta);
                    cn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new DetalleReceta
                            {
                                idDetalleReceta = Convert.ToInt32(dr["idDetalleReceta"]),
                                idReceta = Convert.ToInt32(dr["idReceta"]),
                                idMedicamento = Convert.ToInt32(dr["idMedicamento"]),
                                dosis = dr["dosis"].ToString(),
                                frecuencia = dr["frecuencia"].ToString(),
                                duracion = dr["duracion"].ToString(),
                                indicaciones = dr["indicaciones"].ToString(),
                                // Aquí usamos las propiedades auxiliares que agregamos al modelo
                                nombreMedicamento = dr["nombreMedicamento"].ToString(),
                                presentacionMedicamento = dr["presentacion"].ToString()
                            });
                        }
                    }
                }
            }
            catch (Exception ex) { throw new Exception("Error al listar detalle: " + ex.Message); }
            return lista;
        }

        public void modificar(DetalleReceta nuevo)
        {
            try
            {
                using (var cn = Conexion.GetConexion())
                {
                    cn.Open();

                    // Llamar al procedimiento almacenado
                    SqlCommand cmd = new SqlCommand("sp_ModificarDetalleReceta", cn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Enviar parámetros
                    cmd.Parameters.Add("@idDetalleReceta", SqlDbType.Int).Value = nuevo.idDetalleReceta;
                    cmd.Parameters.Add("@idReceta", SqlDbType.Int).Value = nuevo.idReceta;
                    cmd.Parameters.Add("@idMedicamento", SqlDbType.Int).Value = nuevo.idMedicamento;
                    cmd.Parameters.Add("@dosis", SqlDbType.VarChar, 50).Value = nuevo.dosis;
                    cmd.Parameters.Add("@frecuencia", SqlDbType.VarChar, 50).Value = nuevo.frecuencia;
                    cmd.Parameters.Add("@duracion", SqlDbType.VarChar, 50).Value = nuevo.duracion;
                    cmd.Parameters.Add("@indicaciones", SqlDbType.VarChar, 200).Value = nuevo.indicaciones;

                    // Ejecutar el comando
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al modificar detalle de receta: " + ex.Message);
            }
        }

        public List<DetalleReceta> ListarPorCita(int idCita)
        {
            List<DetalleReceta> lista = new List<DetalleReceta>();

            try
            {
                using (SqlConnection cn = Conexion.GetConexion())
                {
                    // Usamos el procedimiento almacenado que definimos anteriormente
                    SqlCommand cmd = new SqlCommand("pa_ListarDetalleRecetaPorCita", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idCita", idCita);

                    cn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new DetalleReceta()
                            {
                                idDetalleReceta = Convert.ToInt32(dr["idDetalleReceta"]),
                                // Propiedad para mostrar el nombre en el Grid
                                nombreMedicamento = dr["nombreMedicamento"].ToString(),
                                dosis = dr["dosis"].ToString(),
                                frecuencia = dr["frecuencia"].ToString(),
                                duracion = dr["duracion"].ToString(),
                                indicaciones = dr["indicaciones"].ToString(),
                                presentacionMedicamento = dr["presentacionMedicamento"].ToString()
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Es mejor relanzar la excepción para que la capa de presentación la capture
                throw new Exception("Error al obtener el detalle de la receta: " + ex.Message);
            }

            return lista;
        }

    }
}
