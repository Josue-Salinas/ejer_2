using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Divisores que son divisibles entre 3 del 1 al 1000:");

            for (int i = 1; i <= 1000; i++)
            {
                if (i % 3 == 0)
                {

                    Console.WriteLine($"Divisor de Omar Orlandini {i / 3}: {i}");
                }
            }
            Console.ReadKey();
        }
    }
}
