using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AppProcess.Conexion;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static AppProcess.Business.Entidades;

namespace AppProcess.Business
{
    public class Metodos
    {

        ConexionApi con;
        public Metodos()
        {
            con = new ConexionApi();

        }

        public void Login( string usuario, string password)
        {
            PeticionLogin peti = new PeticionLogin { usu = usuario ,pass = password};
            
            var url = "http://desarrollo.wisetrack.cl/cl/api/apiresttest1/";
           var respuestaLog = JsonConvert.DeserializeObject<RespuestaLogin>(con.EnlaceApi(url+"API/Login", JsonConvert.SerializeObject(peti), "POST","{}"));

        }
    }
}