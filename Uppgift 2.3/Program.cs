using System;

namespace Uppgift_2._3
{
    class Program
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Hur många dagar vill du hyra bilen?");
            double x = double.Parse(Console.ReadLine());

            Console.WriteLine("Hur många kilometer ska du köra med bilen?");
            double y = double.Parse(Console.ReadLine());

            double z = x * 500 - 500;
            double m = y * 1;

            double summa = z + m + 300;

            Console.WriteLine("Den totala hyran blir " + summa + "kr");
            Console.ReadKey();
        }
    }
}