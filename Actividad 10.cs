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
            int m;
            int n;
            int o;
            int p;
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
            m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduzca octavo numero");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduzca noveno numero");
            o = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduzca décimo numero");
            p = Convert.ToInt32(Console.ReadLine());
            r = ((x + y + z + k + q + l + m + n + o + p) / 10) * 2;
            Console.WriteLine("La media por 2 es " + r);
            Console.ReadKey();
        }
    }
}
