using System;

namespace Actividad5
{
    class Program
    {

        static void Main(string[] args)
        {
            int x;
            int y;
            Console.WriteLine("Introduzca el número del día");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduzca el número del mes");
            y = Convert.ToInt32(Console.ReadLine());
            if (x >= 1 & y >= 3 & x <= 31 & y <= 5)
            {
                Console.WriteLine("Primavera");
            }
            else if (x >= 1 & y >= 6 & x <= 31 & y <= 8)
            {
                Console.WriteLine("verano");
            }
            else if (x >= 1 & y >= 9 & x <= 31 & y <= 11)
            {
                Console.WriteLine("Otoño");
            }
            else if (x >= 1 & y == 12 | y <= 2 & x <= 28)
            {
                Console.WriteLine("Invierno");
            }
                Console.ReadKey();
        }
    }
}
