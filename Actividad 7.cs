using System;

namespace Actividad5
{
    class Program
    {

        static void Main(string[] args)
        {
            int x;
            
            Console.WriteLine("Introduzca número");
            x = Convert.ToInt32(Console.ReadLine());
            if (x < 100)
            {
                Console.WriteLine("El número es menor que 100");
            }
            else
            {
                Console.WriteLine("El número es igual o mayor que 100");
            }
            Console.ReadKey();
        }
    }
}
