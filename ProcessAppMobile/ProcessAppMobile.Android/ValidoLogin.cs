using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Xamarin.Forms;
using ProcessAppMobile.Models;

[assembly:Dependency(typeof(ProcessAppMobile.Droid.ValidoLogin))]

namespace ProcessAppMobile.Droid
{
    public class ValidoLogin : IValidar
    {
        public string EsValidoLogin(string usu, string pass)
        {
            string resultado = "";
            //try
            //{
                WS_Process.ServiceProcess servicio = new WS_Process.ServiceProcess();

            try

                
            {
                //resultado = servicio.Login(usu, pass);
                XmlSerializer seria = new XmlSerializer(typeof(Usuario));
                FileStream myFileStream = new FileStream(servicio.Login(usu,pass), FileMode.Open);

                Usuario myObject = (Usuario)seria.Deserialize(myFileStream);

               
                
                //resultado = servicio.Login(usu, pass);
            }
            catch (Exception ex)
            {

                new Exception("Usuario o Contraseña incorrecta " + ex.Message);
            }
          
            //}
            //catch (Exception ex)
            //{

            //    new Exception("Usuario o Contraseña incorrecta " + ex.Message);

            //}


            return resultado;
        }
    }
    
}