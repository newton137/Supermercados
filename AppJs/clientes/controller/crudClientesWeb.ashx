<%@ WebHandler Language="C#" Class="crudClientesWeb" %>

using System;
using System.Web;
using System.IO;
using System.Collections.Generic;
using System.Web.Script.Serialization;
using proyecto1.Model;
using proyecto1.genericos;
using proyecto1.BIZ;

public class crudClientesWeb : IHttpHandler
{

    public void ProcessRequest(HttpContext context)
    {

        var jsonSerializer = new JavaScriptSerializer();
        JsonToObject objSelCon = new JsonToObject();
        oConsulta oRespuestaCrd;

        try
        {
            Clientes clienteWeb = objSelCon.Deserialize<Clientes>(context);
            ClientesBiz clienteWserv = new ClientesBiz();
            oRespuestaCrd = clienteWserv.setListaClientes(clienteWeb);


        }
        catch (Exception)
        {

            throw;
        }


        var datdev = jsonSerializer.Serialize(oRespuestaCrd);
        context.Response.Write(datdev);

    }

    public bool IsReusable
    {
        get
        {
            return false;
        }
    }

}