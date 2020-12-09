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
using System.Net;
using System.Text;

namespace AppProcess.Conexion
{
   public class ConexionApi
    {

        public string EnlaceApi(string Url, string _jsonInput, string Metodo, string TipoRetorno = "[]", string Content_Type = "application/json", int Timeout = 60)
        {
            try
            {
                string mensajeAEnviar = _jsonInput;
                byte[] data = UTF8Encoding.UTF8.GetBytes(mensajeAEnviar);
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Url);
                request.Timeout = (Timeout * 1000);
                request.Method = Metodo;
                request.ContentLength = data.Length;
                request.ContentType = Content_Type;
                Stream postStream = request.GetRequestStream();
                postStream.Write(data, 0, data.Length);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                StreamReader reader = new StreamReader(response.GetResponseStream());
                string respuesta = reader.ReadToEnd();
                postStream.Dispose();
                response.Dispose();
                reader.Dispose();
                return respuesta;
            }
            catch (Exception ex)
            {
                if (TipoRetorno == "[]")
                    return "[]";
                else
                    return "{}";
            }
        }

    }
}