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
            for (x = 1; x < 7; x++)
            {
                System.Threading.Thread.Sleep(1000);
                switch (x)
                {
                    case 1:
                        Console.WriteLine("Sal de la clase");
                        break;
                    case 2:
                        Console.WriteLine("Girar a la derecha");
                        break;
                    case 3:
                        Console.WriteLine("Girar a la izquierda");
                        break;
                    case 4:
                        Console.WriteLine("Subir escalera");
                        break;
                    case 5:
                        Console.WriteLine("Girar izquierda");
                        break;
                    case 6:
                        Console.WriteLine("Primera puerta a la derecha");
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}
