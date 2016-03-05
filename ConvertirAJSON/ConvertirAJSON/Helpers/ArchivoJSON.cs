using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Web.Script.Serialization;
using ConvertirAJSON.Models;
using System.Net;


namespace ConvertirAJSON.Helpers
{
    public class ArchivoJSON
    {
        public void creaArchivoJSON(List<Persona> personas)
        {
            var Jpersonas = new JavaScriptSerializer().Serialize(personas);
            File.WriteAllText(@"C:\Personas.json", Jpersonas);
        }
    }
}