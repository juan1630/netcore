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


            //  TIPOS DE DATOS 
            // POR VALOR 
            /**
            Los tiposde datos por valor, el mismo valor
            de la variable te da el tipo de dato 
            
                hay 3 tipos:
                primitivos, estrucutrados, enumerados
                los primitivos se subdividen en
                enteros, booleanos,  reales

                los valores numericos se subdividen en 
                sin signo y con signo:
                con  signo      sin signo
                sbyte           byte        -127, 127
                shortint        unshort       
                int             unint       
                long            ulong 
                
                REALES:

                float    una parte decimal muy larga
                double  
                decimal parte decimal muy larga, ideales para transaciones bancarias
            
                BOOLEAN:
                true 
                false

                UTF16
                Caracteres especiales


            */

            // POR REFERENCIA
            // inidca el lugar en memoria donde se guardo el 
            // valor de la variable 

            /**
            
                Las variables almacenan en la memoria RAM un valor
                la varibale ocupa un tamanio en bytes
                el tipo entre más exacto, más optimizado
            **/

            int edad =24;
            // declaracion y asignacion de la variable
            Console.WriteLine( "La edad es: " + edad );   


            // Operadores aritmeticos
            // suma +
            // resta  -
            // multiplicacion *
            //division /
            // residuo o modulo %
            // estos operadores No se puden usar en valores de texto
            // solo se puede cooncatenar las cadenas de texto

            // incrementos y decrementos 
            //      ++          --

            //  incrementos de más valor 
            // += 5,            -=5


            Console.WriteLine( 5*5 );


            Console.WriteLine(  5/2  );
            // en esta parte nos da un resultado con valores de tipo entero, debemos convertir 
            // estos valores de tipo entero a decimal



            Console.WriteLine(  5.0/2.0 );
            // ahora son de tipo double



            Console.WriteLine(  9%3   );



            // concatenación de strings 
            int edadDos = 24;

            Console.WriteLine("Tienes la edad de: " + edadDos + "años" );


            // interpolacion de los strings 

            Console.WriteLine( $"Tienes una edad de: {edadDos} años" );
            



            edadDos += 9;

            edadDos++;



            
            Console.WriteLine( $"Tienes una edad de: {edadDos} años" );
            

            --edadDos;

            
            Console.WriteLine( $"Tienes una edad de: {edadDos} años" );
            


        }
    }
}
 