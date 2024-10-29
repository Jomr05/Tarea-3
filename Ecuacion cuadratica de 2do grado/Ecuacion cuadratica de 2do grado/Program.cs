using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecuacion_cuadratica_de_2do_grado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el coeficiente a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el coeficiente b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el coeficiente c: ");
            double c = double.Parse(Console.ReadLine());

            double discriminante = b * b - 4 * a * c;

            if (discriminante > 0)
            {
                Console.WriteLine("Las soluciones son: x1 = " + (-b + Math.Sqrt(discriminante)) / (2 * a) +
                                  " y x2 = " + (-b - Math.Sqrt(discriminante)) / (2 * a));
            }
            else if (discriminante == 0)
            {
                Console.WriteLine("La solución es: x = " + -b / (2 * a));
            }
            else
            {
                double realPart = -b / (2 * a);
                double imaginaryPart = Math.Sqrt(-discriminante) / (2 * a);
                Console.WriteLine("Las soluciones complejas son: x1 = " + realPart + " + " + imaginaryPart + "i y x2 = " +
                                  realPart + " - " + imaginaryPart + "i");
            }
            Console.ReadKey();  
        }
    }
}
