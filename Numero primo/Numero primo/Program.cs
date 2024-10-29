using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numero_primo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.WriteLine("Escribe el numero que deseas saber si es primo ");
            numero = int.Parse(Console.ReadLine());

            if (numero <= 1)
            {
                Console.WriteLine("El numero " + numero + " no es primo");
                Console.ReadKey();

            }
            else if (numero <= 3)
            {
                Console.WriteLine("El numero " + numero + " es primo");
                Console.ReadKey();

            }
            else if (numero % 2 == 0 || numero % 3 == 0)
            {
                Console.WriteLine("El numero " + numero + " no es primo");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("El numero " + numero + " es primo");
                Console.ReadKey();
            }
        }
    }
}
