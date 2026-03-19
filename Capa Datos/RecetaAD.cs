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
    public class RecetaAD
    {
        public int Agregar(Receta obj)
        {
            int idGenerado = 0;
            try
            {
                using (SqlConnection cn = Conexion.GetConexion())
                {
                    SqlCommand cmd = new SqlCommand("pa_insertar_receta", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idAtencion", obj.idAtencion);
                    cmd.Parameters.AddWithValue("@fecha", obj.fecha);
                    cn.Open();

                    // ExecuteScalar devuelve la primera columna de la primera fila (el ID)
                    idGenerado = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            catch (Exception ex) { throw new Exception("Error RecetaAD: " + ex.Message); }
            return idGenerado;
        }

        public void modificar(Receta nueva)
        {
            try
            {
                using (var cn = Conexion.GetConexion())
                {
                    cn.Open();

                    SqlCommand cmd = new SqlCommand("sp_ModificarReceta", cn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Parámetros
                    cmd.Parameters.AddWithValue("@idreceta", nueva.idReceta);
                    cmd.Parameters.AddWithValue("@idatencion", nueva.idAtencion);
                    cmd.Parameters.AddWithValue("@fecha", nueva.fecha);

                    cmd.ExecuteNonQuery();
                    cn.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Receta> listado()
        {
            var lista = new List<Receta>();

            try
            {
                using (var cn = Conexion.GetConexion())
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Receta", cn);

                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        lista.Add(new Receta()
                        {
                            idReceta = dr.GetInt32(0),
                            idAtencion = dr.GetInt32(1),
                            fecha = dr.GetDateTime(2)
                        });
                    }

                    dr.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return lista;
        }

        public bool Eliminar(int idReceta)
        {
            try
            {
                // Verificar si existen detalles
                int count = 0;
                using (SqlConnection cn = Conexion.GetConexion())
                {
                    SqlCommand cmd = new SqlCommand(
                        "SELECT COUNT(*) FROM DetalleReceta WHERE idReceta = @idReceta", cn);
                    cmd.Parameters.AddWithValue("@idReceta", idReceta);
                    cn.Open();
                    count = (int)cmd.ExecuteScalar();
                }

                if (count > 0)
                {
                    // No se puede eliminar porque tiene detalles asociados
                    return false;
                }

                // Si no tiene detalles, eliminar la receta
                using (SqlConnection cn = Conexion.GetConexion())
                {
                    SqlCommand cmd = new SqlCommand(
                        "DELETE FROM Receta WHERE idReceta = @idReceta", cn);
                    cmd.Parameters.AddWithValue("@idReceta", idReceta);
                    cn.Open();
                    cmd.ExecuteNonQuery();
                }

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar receta: " + ex.Message);
            }
        }
    }
}
