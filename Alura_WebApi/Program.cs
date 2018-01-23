using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Alura_WebApi
{
    class Program
    {
        static void Main(string[] args)
        {
            TestaGet();

        }

        private static void TestaGet()
        {
            string conteudo;
            //HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://www.mocky.io/v2/52aaf5deee7ba8c70329fb7d");
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://localhost:13435/api/carrinho/1");
            request.Method = "GET";
            request.Accept = "application/json";

            WebResponse response = request.GetResponse();
            using (Stream responseStream = response.GetResponseStream())
            {
                StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);
                conteudo = reader.ReadToEnd();
            }


            Console.Write(conteudo);

            Console.ReadKey();
        }
    }
}
