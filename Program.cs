using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Введите число: ");

            double x = double.Parse(Console.ReadLine());

            double result = 8 * Math.Sin(2 * x) - Math.Cos(2 * x);

            Console.WriteLine($"ответ: {result:F4}");
        }
    }
}
