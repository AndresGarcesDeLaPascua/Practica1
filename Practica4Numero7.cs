using System;

namespace Actividad5
{

    class Program
    {

        static void Main(string[] args)
        {
            
            int x;
            int z = 1;
            int i = 1;
            Console.WriteLine("Introduzca el número a factorizar");
            x = Convert.ToInt32(Console.ReadLine());
            for (i = x; i > 1; i--)
            {
                System.Threading.Thread.Sleep(1000);
                z *= i;
            }
            Console.WriteLine(z);
            Console.ReadKey();
        }
    }
}
