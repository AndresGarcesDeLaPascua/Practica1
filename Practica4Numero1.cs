using System;

namespace Actividad5
{

    class Program
    {
       
        static void Main(string[] args)
        {
            int i = 1;
            int x = 1;
            int z = 1;
            int y = 1;
            int k = 1;
            int l = 1;
            int m = 1;
            int n = 1;
            int o=1;
            int p=1;
            int q=1;
            float r;
            for (i=1; i<12; i++)
            {
                
                switch (i)
                {
                    case 1:
                        Console.WriteLine("Introduzca primer número");
                        x = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 2:
                        Console.WriteLine("Introduzca segundo nímero");
                        y = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 3:
                        Console.WriteLine("Introduzca tercero número");
                        z = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 4:
                        Console.WriteLine("Introduzca cuarto número");
                        k = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 5:
                        Console.WriteLine("Introduzca quinto número");
                        l = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 6:
                        Console.WriteLine("Introduzca sexto número");
                        m = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 7:
                        Console.WriteLine("Introduzca septimo número");
                        n = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 8:
                        Console.WriteLine("Introduzca octavo número");
                        o = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 9:
                        Console.WriteLine("Introduzca noveno número");
                        p = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 10:
                        Console.WriteLine("Introduzca décimo número");
                        q = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 11:
                        r = (x + y + z + k + l + m + n + o + p + q) / 10;
                        Console.WriteLine("El promedio es " + r);
                        
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}