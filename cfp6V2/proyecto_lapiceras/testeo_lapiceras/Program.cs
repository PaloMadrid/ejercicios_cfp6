using mis_clases;
using Mis_clases;
using System.Drawing;

namespace testeo_lapiceras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            foreach (Lapicera n in Lapicera.ListaDeLapiceras())
            {
                Console.WriteLine(n.ToString());
            }

            Console.WriteLine("escribir: ");
            string texto=Console.ReadLine();

            Funcion.ContarCaracteres(texto);

            Console.WriteLine($"caracteres: {Funcion.ContarCaracteres(texto)}");

            
        }
    }
}
