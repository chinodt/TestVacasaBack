using System;
using System.Collections.Generic;
using System.Text;
using Vacasa.API.Test.DAL.Implementation;
using System.Net;
using System.IO;
using Newtonsoft.Json;

namespace Vacasa.API.Test.DAL.Common
{
    public static class Utils
    {
        public static TResultado InvocaServicioRest<TResultado>
                                            (string url)
        {
            TResultado resultado = default(TResultado);

            //Evitar error de https sin certificado
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            var responses = (HttpWebResponse)request.GetResponse();
            var response = new StreamReader(responses.GetResponseStream()).ReadToEnd();
            var obj = JsonConvert.DeserializeObject<dynamic>(response);
            resultado = obj.ToObject<TResultado>();
            return resultado;
        }

        public static List<TResultado> InvocaServicioListRest<TResultado>
                                            (string url, string element)
        {
            List<TResultado> resultadoLst = new List<TResultado>();

            //Evitar error de https sin certificado
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            var responses = (HttpWebResponse)request.GetResponse();
            var response = new StreamReader(responses.GetResponseStream()).ReadToEnd();
            dynamic resul = JsonConvert.DeserializeObject<dynamic>(response);
            resultadoLst = resul[element].ToObject<List<TResultado>>();
            return resultadoLst;
        }
    }
}
