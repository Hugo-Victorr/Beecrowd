using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _1008
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, hrs;
            double salario;

            num = Convert.ToInt32(Console.ReadLine());
            hrs = Convert.ToInt32(Console.ReadLine());
            salario = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"NUMBER = {num}\nSALARY = U$ {(hrs * salario).ToString("F", CultureInfo.InvariantCulture)}");

            Console.ReadKey();
        }
    }
}
