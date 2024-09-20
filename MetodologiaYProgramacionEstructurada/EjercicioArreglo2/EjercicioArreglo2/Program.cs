using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioArreglo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arreglo = new int[1, 5];
            int f, c;
            Console.WriteLine("Bienvenido al programa de arreglos bidimensionales");
            Console.WriteLine("Digite los datos del arreglo");
            for (f = 0; f < 1; f++)
            {
                for (c = 0; c < 5; c++)
                {
                    arreglo[f, c] = int.Parse(Console.ReadLine());
                }
            }
            //Imprimir el arreglo
            Console.WriteLine("Los datos del arreglo son:");
            for (f = 0; f < 1; f++)
            {
                for (c = 0; c < 5; c++)
                {
                    Console.Write(" " +arreglo[f, c] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();

        }
    }
}
  