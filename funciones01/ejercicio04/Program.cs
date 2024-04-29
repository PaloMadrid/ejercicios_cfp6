namespace ejercicio04
{
    internal class promedio
    {
        static void Main(string[] args)
        {
            float numero;
            float promedio;
            float suma = 0;
            int i;
            int repeticiones = 5;

            for (i = 0; i < repeticiones; i++)
            {

                Console.WriteLine($"ingrese el {i+1}° numero: ");
                numero = float.Parse(Console.ReadLine());

                suma += numero;
            }

            promedio = suma / i;

            Console.WriteLine($"suma = {suma}");
            Console.WriteLine($"promedio = {promedio}");

        }
    }
}
