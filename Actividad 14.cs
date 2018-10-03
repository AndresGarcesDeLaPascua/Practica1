using System;

namespace Actividad5
{
    class Program
    {

        static void Main(string[] args)
        {
            int x;
            int y;
            int z;
            float r;
            float m;
            Console.WriteLine("Introduzca 1 para sumar, 2 para restar, 3 para multiplicar y 4 para dividir");
            x = Convert.ToInt32(Console.ReadLine());
            
            switch (x)
            {
                case 1:
                    Console.WriteLine("Introduzca primer número");
                    y = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Introduzca segundo número");
                    z = Convert.ToInt32(Console.ReadLine());
                    r = y + z;
                    Console.WriteLine(r);
                    break;
                case 2:
                    Console.WriteLine("Introduzca primer número");
                    y = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Introduzca segundo número");
                    z = Convert.ToInt32(Console.ReadLine());
                    r = y - z;
                    Console.WriteLine(r);
                    break;
                case 3:
                    Console.WriteLine("Introduzca primer número");
                    y = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Introduzca segundo número");
                    z = Convert.ToInt32(Console.ReadLine());
                    r = y * z;
                    Console.WriteLine(r);
                    break;
                case 4:
                    Console.WriteLine("Introduzca primer número");
                    y = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Introduzca segundo número");
                    z = Convert.ToInt32(Console.ReadLine());
                    r = y / z;
                    m = y % z;
                    Console.WriteLine(r + " resto " + m);
                    break;
            }
            Console.ReadKey();
        }
    }
}