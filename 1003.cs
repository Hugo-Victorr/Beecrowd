using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beecrowd_1003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());

            c = a + b;

            Console.WriteLine($"SOMA = {c}");

            Console.ReadKey();
        }
    }
}
