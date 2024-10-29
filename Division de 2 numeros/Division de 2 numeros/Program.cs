using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Division_de_2_numeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2; 
            int resultado;
            Console.WriteLine("Ingrese un número Entero: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un número Entero: ");
            num2 = int.Parse(Console.ReadLine());
            resultado = num1 / num2;
            Console.WriteLine("El resultados es: " + resultado);
            Console.ReadLine();
        }
    }
}
