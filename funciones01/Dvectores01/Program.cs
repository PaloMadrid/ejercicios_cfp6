namespace Dvectores01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vectorEnteros = new int[5];

            for (int i = 0; i < vectorEnteros.Length; i++)
            {
                Console.WriteLine($"ingrese el {i + 1}° numero: ");
                vectorEnteros[i] = int.Parse(Console.ReadLine());
            }

            foreach (int i in vectorEnteros)
            {
                Console.Write($"{i} ");

            }
        }
    }
}
