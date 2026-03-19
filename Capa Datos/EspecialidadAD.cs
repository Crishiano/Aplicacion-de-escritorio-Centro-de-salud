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
    public class EspecialidadAD
    {
        public void agregar(Especialidad nuevo)
        {
            try
            {
                using (var cn = Conexion.GetConexion())
                {
                    cn.Open();
                    // llamar al procedimiento almacenado en sql
                    SqlCommand cmd = new SqlCommand("pa_registro_especialidad", cn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    // Enviar parametros del INSERT INTO
                    cmd.Parameters.AddWithValue("@nombre", nuevo.nombre);
                    cmd.Parameters.AddWithValue("@estado", nuevo.estado);

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

        public void modificar(Especialidad nuevo)
        {
            try
            {
                using (var cn = Conexion.GetConexion())
                {
                    cn.Open();

                    // Llamar al procedimiento almacenado
                    SqlCommand cmd = new SqlCommand("pa_actualizar_especialidad", cn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Enviar parámetros
                    cmd.Parameters.AddWithValue("@idEspecialidad", nuevo.idEspecialidad);
                    cmd.Parameters.AddWithValue("@nombre", nuevo.nombre);
                    cmd.Parameters.AddWithValue("@estado", nuevo.estado);

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
        public List<Especialidad> listado()
        {
            var lista = new List<Especialidad>();

            try
            {
                using (var cn = Conexion.GetConexion())
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand("select * from Especialidad", cn);

                    //ejecutar y recuperar los regisstros de la tabla
                    SqlDataReader dr = cmd.ExecuteReader();
                    //convertir las tuplas a objetos
                    while (dr.Read())
                    {
                        lista.Add(new Especialidad()
                        {
                            idEspecialidad = dr.GetInt32(0),
                            nombre = dr.GetString(1),
                            estado = dr.GetBoolean(2)
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

        public List<Especialidad> ListarActivas()
        {
            List<Especialidad> lista = new List<Especialidad>();

            try
            {
                using (var cn = Conexion.GetConexion())
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand("pa_ListarEspecialidades", cn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        lista.Add(new Especialidad()
                        {
                            idEspecialidad = (int)dr["idEspecialidad"],
                            nombre = dr["nombre"].ToString(),
                            estado = Convert.ToBoolean(dr["estado"]),
                        });
                    }

                    dr.Close();
                    cn.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al listar especialidades: {ex.Message}");
            }

            return lista;
        }
    }
}
