using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numeros_fibonacci_del_1_al_50
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Formula para numero fibonacci = F(n)=F(n−1)+F(n−2) para n > 1

            //n1 y n2 son los primeros valores de la series fibonacci para si porder continuar con la secuencia.
            long n1 = 0, n2 = 1, n3 = 0;

            for (int i = 0; i < 51; i++)
            {
                Console.WriteLine(n1);
                n3 = n1 + n2;
                n1 = n2;
                n2 = n3;
            }
            Console.ReadKey();

            


        }
    }
}
