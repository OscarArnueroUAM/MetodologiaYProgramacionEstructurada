using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Utilice un arreglo de doble subíndice para resolver el problema siguiente. Una empresa tiene cuatro vendedores (1 a 4) que venden cinco productos diferentes (1 a 5). Una vez al día, cada vendedor emite un volante para cada tipo distinto de producto vendido. Cada volante contiene:
            1.	El número del vendedor.
            2.	El número del producto.
            3.	El valor total en dólares del producto vendido ese día.

            Por lo tanto, cada vendedor entrega por día entre 0 y 5 volantes de ventas. 
            Suponga que está disponible la información de todos los volantes correspondientes al mes anterior. 
            Escriba un programa que lea toda esta información correspondiente a las ventas del mes anterior, 
            y que resuma las ventas totales por vendedor y por producto. Todos los totales deberán almacenarse 
            en un arreglo de doble subíndice sales. Después de procesar toda la información correspondiente al
            mes anterior, imprima los resultados en forma tabular, con cada una de las columnas representando a
            un vendedor en particular y cada uno de los renglones representando un producto en particular. 
            Totalice en forma cruzada cada renglón, para obtener las ventas totales de cada producto del mes pasado;
            totalice cada columna para obtener las ventas totales por vendedor correspondiente al mes pasado. 
            Su impresión en forma tabular deberá incluir estos totales a la derecha de los renglones totalizados
            y en la parte inferior de las columnas totalizadas.

            */
            // Declaración de un arreglo de doble subíndice para almacenar las ventas [productos, vendedores]
            // Inicializar el arreglo de ventas para 5 productos y 4 vendedores
            double[,] ventas = new double[5, 4]; // [productos, vendedores]

            Console.WriteLine("Ingrese los datos de ventas del mes anterior.");
            Console.WriteLine("Para cada boleta de ventas, proporcione la siguiente información:");
            Console.WriteLine("1. Número del vendedor (1-4)");
            Console.WriteLine("2. Número del producto (1-5)");
            Console.WriteLine("3. Valor total vendido (número no negativo)");
            Console.WriteLine("Ingrese -1 como número del vendedor para finalizar la entrada.\n");

            while (true)
            {
                Console.Write("Ingrese el número del vendedor (1-4, o -1 para finalizar): ");
                int vendedor;
                if (!int.TryParse(Console.ReadLine(), out vendedor) || (vendedor != -1 && (vendedor < 1 || vendedor > 4)))
                {
                    Console.WriteLine("Número de vendedor inválido. Por favor, ingrese un número entre 1 y 4, o -1 para finalizar.");
                    continue;
                }
                if (vendedor == -1)
                    break;

                Console.Write("Ingrese el número del producto (1-5): ");
                int producto;
                if (!int.TryParse(Console.ReadLine(), out producto) || producto < 1 || producto > 5)
                {
                    Console.WriteLine("Número de producto inválido. Por favor, ingrese un número entre 1 y 5.");
                    continue;
                }

                Console.Write("Ingrese el valor total vendido: ");
                double valor;
                if (!double.TryParse(Console.ReadLine(), out valor) || valor < 0)
                {
                    Console.WriteLine("Valor inválido. Por favor, ingrese un número no negativo.");
                    continue;
                }

                // Ajustar índices a base cero
                int indiceVendedor = vendedor - 1;
                int indiceProducto = producto - 1;

                // Sumar el valor al arreglo de ventas
                ventas[indiceProducto, indiceVendedor] += valor;
            }

            // Calcular totales
            double[] totalPorProducto = new double[5];      // Ventas totales para cada producto (filas)
            double[] totalPorVendedor = new double[4];      // Ventas totales para cada vendedor (columnas)
            double totalGeneral = 0;

            for (int producto = 0; producto < 5; producto++)
            {
                for (int vendedor = 0; vendedor < 4; vendedor++)
                {
                    double venta = ventas[producto, vendedor];
                    totalPorProducto[producto] += venta;
                    totalPorVendedor[vendedor] += venta;
                    totalGeneral += venta;
                }
            }

            // Imprimir encabezado de la tabla
            Console.WriteLine("\nTotales de Ventas del Mes Anterior:");
            Console.Write("Producto\\Vendedor\t");
            for (int vendedor = 1; vendedor <= 4; vendedor++)
            {
                Console.Write("V{0}\t\t", vendedor);
            }
            Console.WriteLine("Total por Producto");

            // Imprimir filas de la tabla
            for (int producto = 0; producto < 5; producto++)
            {
                Console.Write("Producto {0}\t\t", producto + 1);
                for (int vendedor = 0; vendedor < 4; vendedor++)
                {
                    Console.Write("${0:F2}\t", ventas[producto, vendedor]);
                }
                Console.WriteLine("${0:F2}", totalPorProducto[producto]);
            }

            // Imprimir fila de totales
            Console.Write("Total por Vendedor\t");
            for (int vendedor = 0; vendedor < 4; vendedor++)
            {
                Console.Write("${0:F2}\t", totalPorVendedor[vendedor]);
            }
            Console.WriteLine("${0:F2}", totalGeneral);
            Console.ReadLine();

        }
    }
}
