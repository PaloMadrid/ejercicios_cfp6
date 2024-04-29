using System.Diagnostics.CodeAnalysis;

namespace bienvenida
{
    internal class apenomEdad
    {
        static void Main(string[] args)
        {
            string nombre;
            string apellido;
            string edadTexto;
            int edad;

            Console.Write("Por favor, ingrese su nombre: ");

            nombre = Console.ReadLine();

            Console.Write("Por favor, ingrese su apellido: ");

            apellido = Console.ReadLine();

            Console.Write("Por favor, ingrese su edad: ");

            edadTexto = Console.ReadLine();

            //convertir string a nro, funciona con cualquier tipo numerico

            edad = int.Parse(edadTexto);

            //metodos de concatenar:

            //Console.WriteLine("Bienvenido/a " + nombre + " " + apellido + ", su edad es: " + edad + ".");
            //Console.WriteLine("Bienvenido/a {0} {1}, su edad es: {2}.", nombre, apellido, edad);
            ///concatenacion interpolada. clave el $ xq indica que es concatenacion interpolada
            Console.WriteLine($"Bienvenido/a {nombre} {apellido} su edad es: {edad}.");
        }

    }
}