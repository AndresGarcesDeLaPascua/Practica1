using System;

namespace Actividad5
{

    class Program
    {

        static void Main(string[] args)
        {
            int i = 1;
            for (i = 0; i < 100; i = i + 2)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}

