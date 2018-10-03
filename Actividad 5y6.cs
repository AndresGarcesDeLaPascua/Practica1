using System;

namespace Actividad5
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int x;
            int y;
            Console.WriteLine("Introduzca primer número");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduzca segundo número");
            y = Convert.ToInt32(Console.ReadLine());
            if (x > y)
            {
                Console.WriteLine("El orden es descendente");  
            }
            else
            {
                Console.WriteLine("El orden es ascendente");
            }
            Console.ReadKey();
        }
    }
}
