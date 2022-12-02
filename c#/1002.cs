using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace beecrowd_1002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, r;
            string b;

            a = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);  

            r = 3.14159 * (Math.Pow(Convert.ToDouble(a), 2));

            b = r.ToString("F4", CultureInfo.CreateSpecificCulture("en-US"));

            Console.WriteLine($"A={b}");

            Console.ReadKey();
        }
    }
}
