using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using proyecto1.Model;
using proyecto1.DAO;


/// <summary>
/// Descripción breve de ClientesBiz
/// </summary>
namespace proyecto1.BIZ
{
    public class ClientesBiz
    {

        public List<Clientes> getListaClientes(oConsulta oConClientes)
        {


            List<Clientes> ListadoClientes;

            try
            {
                ClientesDao oClientesDao = new ClientesDao();
                ListadoClientes = oClientesDao.GetListadoClientes(oConClientes);

            }
            catch (Exception)
            {

                throw;
            }


            return ListadoClientes;


        }

        public oConsulta setListaClientes(Clientes oParamAddClt)
        {

            oConsulta oRespCrd = null;


            try
            {
                ClientesDao clienteWebDao = new ClientesDao();
                oRespCrd = clienteWebDao.SetListadoClientes(oParamAddClt);
            }
            catch (Exception)
            {

                throw;
            }


            return oRespCrd;



        }



        public ClientesBiz()
        {
            //
            // TODO: Agregar aquí la lógica del constructor
            //
        }
    }
}