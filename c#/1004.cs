using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beecrowd_1004
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            float PROD;

            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());

            PROD = a * b;

            Console.WriteLine($"PROD = {PROD}");

            Console.ReadKey();
        }
    }
}
