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
    public class MedicamentoAD
    {
        public void agregar(Medicamento nuevo)
        {
            try
            {
                using (var cn = Conexion.GetConexion())
                {
                    cn.Open();
                    // llamar al procedimiento almacenado en sql
                    SqlCommand cmd = new SqlCommand("pa_registro_Medicamento", cn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    // Enviar parametros del INSERT INTO
                    cmd.Parameters.AddWithValue("@nombre", nuevo.nombre);
                    cmd.Parameters.AddWithValue("@presentacion", nuevo.presentacion);
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

        public void modificar(Medicamento nuevo)
        {
            try
            {
                using (var cn = Conexion.GetConexion())
                {
                    cn.Open();

                    // Llamar al procedimiento almacenado
                    SqlCommand cmd = new SqlCommand("pa_actualizar_medicamento", cn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Enviar parámetros
                    cmd.Parameters.AddWithValue("@idMedicamento", nuevo.idMedicamento);
                    cmd.Parameters.AddWithValue("@nombre", nuevo.nombre);
                    cmd.Parameters.AddWithValue("@presentacion", nuevo.presentacion);

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

        public List<Medicamento> listado()
        {
            var lista = new List<Medicamento>();

            try
            {
                using (var cn = Conexion.GetConexion())
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand("select * from Medicamento", cn);

                    //ejecutar y recuperar los regisstros de la tabla
                    SqlDataReader dr = cmd.ExecuteReader();
                    //convertir las tuplas a objetos
                    while (dr.Read())
                    {
                        lista.Add(new Medicamento()
                        {
                            idMedicamento = dr.GetInt32(0),
                            nombre = dr.GetString(1),
                            presentacion = dr.GetString(2)
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

    }
}
