using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _1009
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double salario, vendas, total;

            nome = Console.ReadLine();

            salario = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture );
            vendas = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture )*0.15;

            total = salario + vendas;

            Console.WriteLine($"TOTAL = R$ {total.ToString("F2", CultureInfo.InvariantCulture)}");

            Console.ReadKey();
            
        }
    }
}
