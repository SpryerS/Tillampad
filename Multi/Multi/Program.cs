using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multi
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Ange det första talet: ");
            double tal1 = double.Parse(Console.ReadLine());

            Console.Write("Ange det andra talet: ");
            double tal2 = double.Parse(Console.ReadLine());

            Console.Write("Ange det tredje talet: ");
            double tal3 = double.Parse(Console.ReadLine());

            double produkt = tal1 * tal2 * tal3;

            Console.WriteLine("Produkten av de tre talen är: " + produkt);
            Console.ReadKey();

        }
    }
}
