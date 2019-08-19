
using System;

namespace aplicacion_consola
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaramos variables
            string respuesta;
            Console.WriteLine("Eres mayor de edd? (si/no)");
            respuesta = Console.ReadLine();
            if (respuesta == "si")
            {

                Console.WriteLine("Buenos dias señor(a)");

            }
            if (respuesta == "No")
            {
                Console.WriteLine("Eres menor de edad");
            }
        }
    } 

}


