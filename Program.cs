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

        // se inicializan las variables como ambito de la clase y no de la funcion

            int numero = 5;
            int numero2 = 7;
        static void Main(string[] args) {
            // esta clase principal no retorna ningun valor en la llamada
            // siempre se ejecuta con el metdo main

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
            

        
        // OPERADORASIGNACION

        // int edadPersona1;
        // int edadPersona2;
        // int edadPersona3;
        // int edadPersona4;


        // edadPersona1=edadPersona2=edadPersona3=edadPersona4=27;

        // Console.WriteLine( edadPersona2 );


// declaracion implicita de las variables
// se asigna el valor a las variable como en js


    var edadPerson = 24;


    Console.WriteLine( edadPerson );

    mensajeEnPantalla();


    // en c# no se pude reasignar este tipo de dato

    var persona = "Juan";


    Console.WriteLine( persona );

        persona = "Carlos";


            Console.WriteLine( persona );
    
    double temperatura = 34.5;
    int temperaturaCuatla;

        // Haremos un casting de los valores
        // conveersion explicita 

            temperaturaCuatla =(int) temperatura;

            Console.WriteLine(  temperatura);


        //  Conserviosn implicita 
        
        int habitantes = 10000000; 
        long habitantesCiudad2020 = habitantes;

        Console.WriteLine( habitantesCiudad2020 );

        float pesoMaterial = 5.78F;
        // siempre debe de llevar la F en caso de que sea de tipo float

        double pesoMaterialPre = pesoMaterial;


        Console.WriteLine( pesoMaterialPre );


        Console.WriteLine("Ingresa el primer numero");
        // se genera la instruccion para que el usuario ingrese los numeros
        
        string num1 = Console.ReadLine();
        // le ingresa el primer numero por consola

        int nume1Parse = int.Parse(num1);
        // convertimos el valor que el usuario haya ingresado


        Console.WriteLine("Ingresa el segundo numero");
        int num2 = int.Parse( Console.ReadLine() );
        // convertimos el valor que el usuario haya ingresado de string a int
        // le ingresa el segundo numero por consola, por medio del metodo readLine

        int resultado = nume1Parse + num2;  

        Console.WriteLine(resultado);
        //sumaDeDosNumeros(20,30);
       // int res = suma(20,100);
       // System.Console.WriteLine(res);

                // para que haya sobrecarga de metodos se necesita diferente numero de paramteros
                // y que sean de diferente  tipo
        // constantes 

        // las constantes se  deben de declarar desde el principio
        // const int VALOR = 20;

        // const int VALOR2 = 15;

        // Console.WriteLine( VALOR );

        // Console.WriteLine("El valor de la constante es: {0}" , VALOR2, VALOR);


        // const double PI = 3.1416;

        // System.Console.WriteLine("Ingresa el area de un circulo");
        // double radio =    double.Parse( Console.ReadLine());

        // double res = radio * radio * PI;

        // double res = Math.Pow( radio, 2 ) * PI;

        // System.Console.WriteLine( $"El area es :  {res}" );


         //   Console.WriteLine( Suma( 25, 25.0)  );
        // Los metodos son un conjunto de instrucciones agrupadas dentro de un nombre
        // los metodos nos ayudan a ahorrar lineas de codigo y solo se ejecutan cuando se
        // les llama

    }


    static void mensajeEnPantalla() {
        // creando nuestro pimer metodo

        System.Console.WriteLine("mensaje desde el metodo");
    }


    // static void sumaDeDosNumeros(int num1, int num2){

        // int resultado = num1 + num2;
    //    System.Console.WriteLine("Resultado" +  (num1+ num2)  );
    // }

    // las funciones con void no devuelven nigun valor
  //  static int suma(int n1, int n2){
    //    return  n1+ n2;
    // }
    void primerMetodo (){
        // esta ambito es local


        System.Console.WriteLine(numero + numero2); 

    }


    void segundoMetodo() {

//contexto, ambito o alcance es sinonimo del scope

        Console.WriteLine(this.numero + this.numero2);
       

            // sobre cargar de metodos
            // es un exceso en la llamda de los metodos
    }

    
    }

    
            //static int Suma(int operador1,int operador2) => operador1 + operador2;

            //static int Suma (int numero1, double numero2) => numero1 + numero2;
           // static int Suma (int numero1, int numero2) => numero1 + numero2;
}
 