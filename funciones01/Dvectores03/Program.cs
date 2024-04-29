namespace Dvectores03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Idem punto 2, pero calcular el promedio.

            int[] vectorEnteros = new int[5];
            int acumulador = 0;
            double promedio;

            for (int i = 0; i < vectorEnteros.Length; i++)
            {
                Console.WriteLine($"ingrese el {i + 1}° numero: ");
                vectorEnteros[i] = int.Parse(Console.ReadLine());
                acumulador += vectorEnteros[i];
            }

            promedio=acumulador/vectorEnteros.Length;

            Console.Write($"suma: {acumulador}\n");
            Console.Write($"promedio: {promedio}\n");

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
