using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplicacion_de_2_numeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int resultado;

            Console.WriteLine("Íngrese primer numero a multiplicar");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Íngrese segundo numero a multiplicar");
            num2 = int.Parse(Console.ReadLine());

            resultado = num1 * num2;
            Console.WriteLine("el resultado de multiplicar " + num1 + " X " + num2 + " = " + resultado);
            Console.ReadKey();

        }
    }
}
