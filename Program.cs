using System;
using System.Net;
// Esta librería sirve para poder hacer peticiones http
using Newtonsoft.Json;
// esta librerira nos ayuda a poder leer los json 

namespace holaMundo
{
    class Program
    {
        static void Main(string[] args)
        {
            string API_URL =  "http://jsonplaceholder.typicode.com/posts?_limit=5";

            var client = new WebClient();
            // creamos una instancia de un cliente web, para poder hacer peticiones http

           var respJson = client.DownloadString(API_URL);
            // hacemos la peticion

            Console.WriteLine( respJson );
        }
    }
}
 