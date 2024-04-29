namespace ejercicio03ES
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float numero1;
            float numero2;
            float suma;

            Console.Write("ingrese un numero: ");

            numero1 = float.Parse(Console.ReadLine());

            Console.Write("ingrese otro numero: ");

            numero2 = float.Parse(Console.ReadLine());

            suma = numero1 + numero2;

            Console.WriteLine($"la suma es {suma}");
        }
    }
}
