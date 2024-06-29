using System.Numerics;

namespace Dvectores02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Cargar un vector de enteros de 5 elementos, sumar los valores y mostrarlo.
            int suma = 0;

            int[] vectorEnteros = new int[5];

            for (int i = 0; i < vectorEnteros.Length; i++)
            {
                Console.WriteLine($"ingrese el {i + 1}° numero: ");
                vectorEnteros[i] = int.Parse(Console.ReadLine());
            }

            foreach (int i in vectorEnteros)
            {
                suma += i;
            }

            Console.WriteLine($"la suma es = {suma}");

        }
    }
}
