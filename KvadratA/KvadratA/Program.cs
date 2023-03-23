using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KvadratA
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ange sidan på kvadraten: ");
            double sida = double.Parse(Console.ReadLine());

            double area = sida * sida;

            Console.WriteLine("Arean av kvadraten är: " + area);
            Console.ReadKey();
        }
    }
}
