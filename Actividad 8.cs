using System;

namespace Actividad5
{
    class Program
    {

        static void Main(string[] args)
        {
            int x;
            int r;
            Console.WriteLine("Introduzca año");
            x = Convert.ToInt32(Console.ReadLine());
            r = x % 4;
            if (r == 0)
            {
                Console.WriteLine("El año es bisiesto");
            }
            else
            {
                Console.WriteLine("El año no es bisiesto");
            }
            Console.ReadKey();
        }
    }
}
