using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 31; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }

            }
            Console.ReadKey();
        }
    }
}
