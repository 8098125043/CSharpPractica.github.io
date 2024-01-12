using System;

namespace ejercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            int miInt = 4 + 2;
            double nuDouble = 76.09;
            Console.WriteLine($"Cantidad: {miInt}");
            Console.WriteLine("La suma de 24 + 56 es: " + (24 + 56));
            Console.WriteLine($"Numero es {nuDouble}");
            int x, y, z;
            x = y = z = 50;
            Console.WriteLine(x + y + z);
            double miD = 7.09;
            Console.WriteLine(Convert.ToInt32(miD));

            Operadores op = new Operadores();  // Aquí está la corrección
            op.RealizarOperaciones();
        }
    }
}


