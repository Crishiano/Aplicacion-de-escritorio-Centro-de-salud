using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;


namespace CapaDatos
{
    public class Conexion
    {
        public static SqlConnection GetConexion()
        {
            //string cadenaConexion = "Data Source=localhost\\SQLEXPRESS; Initial Catalog=BD_CentroSalud; " +
            //    "Integrated Security=true; TrustServerCertificate=True";

            string cadenaConexion = "Data Source=JURY\\SQLEXPRESS; Initial Catalog=BD_CentroSalud; " +
                 "Integrated Security=true; TrustServerCertificate=True";


            return new SqlConnection(cadenaConexion);
        }
    }
}
