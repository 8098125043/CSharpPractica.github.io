using System;

namespace ejercicios{

   public  class Operadores
    {
        public void RealizarOperaciones()
        {
            Console.WriteLine("Esta es la clase opeadores");
            Console.WriteLine("Maximo es: " + Math.Max(5, 10));
            Console.WriteLine("Minimo es: " + Math.Min(3, 19));
            Console.WriteLine("Raiz cuadrada de 25 es: " + Math.Sqrt(25));
            Console.WriteLine("Valor absoluto de -16: " + Math.Abs(-16.8));
            Console.WriteLine("Redondeando " + Math.Round(12.3455));


            if(6 == 2){
                Console.WriteLine("Es verdadeo");
            }
            else
            {
                Console.WriteLine("Falso");
            }

            string numeo = (5==2) ? ("Es verdadeo") : ("Es falso");
            Console.WriteLine(numeo);

            for (int i = 0; i <= 10; i = i + 2) 
{
  Console.WriteLine(i);
}
        }
    }
}