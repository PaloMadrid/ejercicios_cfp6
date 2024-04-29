namespace ejercicio01
{
    internal class nombreYapellido
    {
        static void Main(string[] args)
        {
            string nombre;
            string apellido;

            Console.WriteLine("por favor, ingrese su nombre");

            nombre = Console.ReadLine();

            Console.WriteLine("por favor, ingrese su apellido");

            apellido = Console.ReadLine();

            Console.WriteLine($"Hola, mi nombre es {nombre} {apellido}");
        }
    }
}