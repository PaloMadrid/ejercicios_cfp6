namespace string02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string palabra;

            Console.Write("ingrese una palabra: ");
            palabra = Console.ReadLine();

            for (int i = 0; i < palabra.Length; i++)
            {
                Console.Write(palabra[i]);

                if (i < palabra.Length - 1)
                {
                    Console.Write(" - ");
                }
            }

        }
    }
}
