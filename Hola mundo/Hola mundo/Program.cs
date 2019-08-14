using System;

namespace Hola_mundo
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor1, valor2, respuesta;

            Console.WriteLine("Vamos a sumar dos numeros:");
            Console.WriteLine("inserta el valor 1 ");
            valor1 = int.Parse(Console.ReadLine());
            Console.WriteLine("inserta el valor 2 ");
            valor2 = int.Parse(Console.ReadLine());
            respuesta = valor1 + valor2;
            
        }
    }
}
