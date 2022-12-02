using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace beecrowd_1006
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float a, b, c, d;

            a = Convert.ToSingle(Console.ReadLine(), CultureInfo.InvariantCulture);
            b = Convert.ToSingle(Console.ReadLine(), CultureInfo.InvariantCulture);
            c = Convert.ToSingle(Console.ReadLine(), CultureInfo.InvariantCulture);

            d = ((a * 2) + (b * 3) + (c * 5)) / 10;

            Console.WriteLine($"MEDIA = {d.ToString("F1", CultureInfo.InvariantCulture)}");

            Console.ReadKey();
        }
    }
}
