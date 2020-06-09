using System;
using System.Net;
// Esta librería sirve para poder hacer peticiones http
using Newtonsoft.Json;
// esta librerira nos ayuda a poder leer los json 

namespace holaMundo
{
    class Program
    // estos son los identificadores
    // solo usan letras, numero y guiones bajos
    // deben de iniciar con letras y no con numeros
    {
        static void Main(string[] args) {
            string API_URL =  "http://jsonplaceholder.typicode.com/posts?_limit=5";

            // comentarios en C#
            /*
                Invalidamos este bloque de codigo
            
            */

            var client = new WebClient();
            // creamos una instancia de un cliente web, para poder hacer peticiones http

            var respJson = client.DownloadString(API_URL);
            // hacemos la peticion y la guardamos en la variable


            // imprime en la consola la resp
            Console.WriteLine( respJson );
        }
    }
}
 