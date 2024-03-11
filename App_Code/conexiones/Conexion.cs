using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;

/// <summary>
/// Descripción breve de Conexion
/// </summary>
/// 

namespace proyecto1.conexion
{
    public class Conexion
    {


        public static SqlConnection getConeccion()
        {

            SqlConnection conn = null;

            try
            {
                conn = new SqlConnection(oconexcion);

            }
            catch (Exception)
            {

                throw;
            }

            return conn;

        }


        private static string oconexcion
        {
            get { return ConfigurationManager.ConnectionStrings["Srfconnect1"].ConnectionString; }
        }


        public Conexion()
        {
            //
            // TODO: Agregar aquí la lógica del constructor
            //
        }
    }
}