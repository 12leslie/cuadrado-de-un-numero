using System;

namespace Ejercicios // <--- en otros ejercicios me olvide de ponerlo, pero igualmente por el momento no son necesarios.
{
    class Ejercicio2
    {
        static void Main()
        {
            float num;

            Console.Write("Ingrese un número:");
            num = float.Parse(Console.ReadLine());

            while (num < 1)
            {
                Console.Write("ERROR.Reingrese número:");
                num = float.Parse(Console.ReadLine());
            }

            Console.Write("El cuadrado de {0} es {1}", num, num * num);
            Console.Read();
        }

    }
}