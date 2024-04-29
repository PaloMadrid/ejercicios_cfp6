using System.Numerics;

namespace Dvectores02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Cargar un vector de enteros de 5 elementos, sumar los valores y mostrarlo.

            int[] vectorEnteros = new int[5];
            int acumulador = 0;

            for (int i = 0; i < vectorEnteros.Length; i++)
            {
                Console.WriteLine($"ingrese el {i + 1}° numero: ");
                vectorEnteros[i] = int.Parse(Console.ReadLine());
                acumulador += vectorEnteros[i];
            }
            
            Console.Write($"suma: {acumulador}\n");

            for (int i = 0; i < vectorEnteros.Length; i++)
            {
                Console.Write(vectorEnteros[i]);

                if (i < vectorEnteros.Length - 1)
                {
                    Console.Write(" | ");
                }
            }
        }
    }
}
