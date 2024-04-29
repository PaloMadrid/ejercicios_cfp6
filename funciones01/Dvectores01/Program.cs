using System.Numerics;
using DlibreriaVectores;

namespace Dvectores01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Cargar un vector de enteros de 5 elementos y mostrarlo.

            int[] vectorEnteros = new int[5];

            //vector.PedirVectorEnteros(vectorEnteros);

            //Console.Write(vector.MostrarVectorEnteros(vectorEnteros));

            for (int i = 0; i < vectorEnteros.Length; i++)
            {
                Console.WriteLine($"ingrese el {i + 1}° numero: ");
                vectorEnteros[i] = int.Parse(Console.ReadLine());
            }

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
