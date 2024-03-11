using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using proyecto1.Model;
using proyecto1.BIZ;

public partial class Sample : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Unnamed1_Click(object sender, EventArgs e)
    {




    }
    protected void bt1_Click(object sender, EventArgs e)
    {
        




    }
    protected void datos1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void Bt1_Click(object sender, EventArgs e)
    {
        oConsulta ObjDatCons = new oConsulta();
        ObjDatCons.opcion = "ALL";
        ObjDatCons.param1 = 5;
        ObjDatCons.param2 = "Pancho";
        ObjDatCons.param3 = "Villa";
        ObjDatCons.param4 = "pv@gmail.com";
        ObjDatCons.param5 = "9515648690";

        List<Clientes> ListaClientesWeb;

        ClientesBiz ListaClientesBiz = new ClientesBiz();
        ListaClientesWeb = ListaClientesBiz.getListaClientes(ObjDatCons);
        Tabla2.DataSource = ListaClientesWeb;
        Tabla2.DataBind();
    }
    protected void Tabla2_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}