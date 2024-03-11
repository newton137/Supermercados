<%@ WebHandler Language="C#" Class="Handler" %>

using System;
using System.Web;
using System.IO;
using System.Collections.Generic;
using System.Web.Script.Serialization;
using proyecto1.Model;
using proyecto1.genericos;
using proyecto1.BIZ;

public class getClientesList : IHttpHandler
{

    public void ProcessRequest(HttpContext context)
    {

        JavaScriptSerializer jsonSerializerUnidadTarifa = new JavaScriptSerializer();
        JsonToObject objListaUnidadTarifa = new JsonToObject();
        List<Clientes> listaClientesWb = null;

        try
        {
            oConsulta oPerConCltW = objListaUnidadTarifa.Deserialize<oConsulta>(context);
            ClientesBiz clienteWbbCoServ = new ClientesBiz();
            listaClientesWb = clienteWbbCoServ.getListaClientes(oPerConCltW);

        }
        catch (Exception)
        {

            throw;
        }

        var devUsrWb = jsonSerializerUnidadTarifa.Serialize(listaClientesWb);
        context.Response.Write(devUsrWb);



    }

    public bool IsReusable
    {
        get
        {
            return false;
        }
    }

}