using System;
using System.Collections.Generic;
using System.Web.Script.Serialization;
using System.Web;
using System.IO;


/// <summary>
/// Descripción breve de JsonToObject
/// </summary>
namespace proyecto1.genericos
{
    public class JsonToObject
    {
        public T Deserialize<T>(HttpContext context)
        {
            //read the json string
            string jsonData = new StreamReader(context.Request.InputStream).ReadToEnd();

            //cast to specified objectType
            var obj = (T)new JavaScriptSerializer().Deserialize<T>(jsonData);
            //return the object
            return obj;
        }


        public JsonToObject()
        {

        }
    }

}