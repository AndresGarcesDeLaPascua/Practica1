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
            r = (x + y + z + k + q) /5   ;
            Console.WriteLine("La media es " + r);
            Console.ReadKey();
        }
    }
}
