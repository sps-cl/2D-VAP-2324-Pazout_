using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uvod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("zadek první číslo");
            
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("zadejte druhe číslo");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"vysledek je:{a + b}");
            Console.Read();
        }
    }
}
