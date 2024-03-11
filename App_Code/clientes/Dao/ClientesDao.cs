using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using proyecto1.Model;
using proyecto1.conexion;

/// <summary>
/// Descripción breve de ClientesDao
/// </summary>
namespace proyecto1.DAO
{


    public class ClientesDao
    {


        public List<Clientes> GetListadoClientes(oConsulta dataParameter)
        {

            List<Clientes> datosClientes = new List<Clientes>();

            using (SqlConnection con = Conexion.getConeccion())
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("[dbo].[Procedimiento]", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@Accion", SqlDbType.Char, 3).Value = dataParameter.opcion;
                    cmd.Parameters.Add("@Id", SqlDbType.Int).Value = dataParameter.param1;
                    cmd.Parameters.Add("@Nombre", SqlDbType.Char, 40).Value = dataParameter.param2;
                    cmd.Parameters.Add("@Apellido", SqlDbType.Char, 40).Value = dataParameter.param3;
                    cmd.Parameters.Add("@Correo", SqlDbType.Char, 40).Value = dataParameter.param4;
                    cmd.Parameters.Add("@Telefono", SqlDbType.Char, 40).Value = dataParameter.param5;

                    SqlDataReader _Reader = cmd.ExecuteReader();

                    while (_Reader.Read())
                    {
                        Clientes modLay = new Clientes();
                        /*modLay.opcion = Convert.ToString(_Reader["Accion"]).Trim();*/
                        modLay.idCliente = Convert.ToInt16(_Reader["ClienteID"]);
                        modLay.nombre = Convert.ToString(_Reader["Nombre"]).Trim();
                        modLay.apellido = Convert.ToString(_Reader["Apellido"]).Trim();
                        modLay.correo = Convert.ToString(_Reader["Correo"]).Trim();
                        modLay.telefono = Convert.ToString(_Reader["Teléfono"]).Trim();
                        datosClientes.Add(modLay);
                    }
                }
                con.Close();
            }
            return datosClientes;



        }

        public oConsulta SetListadoClientes(Clientes clienteWeb)
        {
            string fechaHoy = DateTime.Today.ToString("dd/MM/yyyy");
            oConsulta oRespCrud = new oConsulta();

            try
            {

                using (SqlConnection con = Conexion.getConeccion())
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("[dbo].[Procedimiento]", con))
                    {

                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@Accion", SqlDbType.Char, 3).Value = clienteWeb.opcion;
                        cmd.Parameters.Add("@Id", SqlDbType.Int).Value = clienteWeb.idCliente;
                        cmd.Parameters.Add("@Nombre", SqlDbType.Char, 40).Value = clienteWeb.nombre;
                        cmd.Parameters.Add("@Apellido", SqlDbType.Char, 40).Value = clienteWeb.apellido;
                        cmd.Parameters.Add("@Correo", SqlDbType.Char, 40).Value = clienteWeb.correo;
                        cmd.Parameters.Add("@Telefono", SqlDbType.Char, 40).Value = clienteWeb.telefono;
                        cmd.Parameters["@ACCION"].Direction = ParameterDirection.Output;
                        //Revisar si realizo la operacion
                        switch (clienteWeb.opcion)
                        {
                            case "INS": //Insertado

                                oRespCrud.msg = "El usuario fue registrado";
                                break;
                            case "UPD": //Actualziado

                                oRespCrud.msg = "Se actualizo el usuario";
                                break;

                            case "DEL": //Borrado

                                oRespCrud.msg = "El usuario se elimino";

                                break;
                        }

                    }

                    con.Close();
                }
                return oRespCrud;


            }
            catch (Exception ex)
            {

                throw;
            }





        }



        public ClientesDao()
        {
            //
            // TODO: Agregar aquí la lógica del constructor
            //
        }
    }


}