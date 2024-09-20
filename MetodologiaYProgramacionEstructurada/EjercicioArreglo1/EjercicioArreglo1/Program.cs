using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioArreglo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[10];
            int cpp = 0;
            int cpi = 1;

            Console.WriteLine("Digite los datos del arreglo");
            Console.WriteLine();
            for (int i = 0; i < 10; i++)
            {
                //Lectura
                Console.Write("Ingresa numero: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine("Datos del arreglo:");
            Console.WriteLine();
            for (int i = 0; i < 10; i++)
            {
                //Muestra en pantalla
                Console.Write(numeros[i] + ", ");

                //Muestra cuales numeros son pares e impares
                if (numeros[i] % 2 == 0)
                {
                    Console.WriteLine("El numero " + numeros[i] + " es par");
                }
                else
                {
                    Console.WriteLine("El numero " + numeros[i] + " es impar");
                }
            }

            //Muestra el total de numeros pares e impares
            int pares = 0;
            int impares = 0;

            for (int i = 0; i < 10; i++)
            {
                if (numeros[i] % 2 == 0)
                {
                    pares++;
                }
                else
                {
                    impares++;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Total de numeros pares: " + pares);
            Console.WriteLine("Total de numeros impares: " + impares);

            Console.ReadKey();
        }
    }
}

