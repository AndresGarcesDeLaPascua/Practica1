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
            int k;
            int q;
            int l;
            float r;
            Console.WriteLine("Introduzca primer numero");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduzca segundo numero");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduzca tercer numero");
            z = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduzca cuarto numero");
            k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduzca quinto numero");
            q = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduzca sexto numero");
            l = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduzca septimo numero");
            r = (x + y + z + k + q + l) / 6;
            if (r > 5)
            {
                Console.WriteLine("Felicidades acreditaste la materia con " + r);
            }
            else
            {
                Console.WriteLine("Suerte para la proxima, obtuviste: " + r);
            }
            Console.ReadKey();
        }
    }
}
