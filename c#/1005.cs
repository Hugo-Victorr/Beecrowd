using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace beecrowd_1005
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            

            a = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            b = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            c = ((3.5 * a) + (7.5 * b)) / 11;

            c.ToString("F5", CultureInfo.CreateSpecificCulture("en-US"));

            Console.WriteLine($"MEDIA = {c.ToString("F5", CultureInfo.CreateSpecificCulture("en-US"))}");

            Console.ReadKey();  

        }
    }
}
