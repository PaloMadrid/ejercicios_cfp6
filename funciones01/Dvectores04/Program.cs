using System.Diagnostics.Metrics;
using System.Numerics;
using System.Reflection.Emit;

namespace Dvectores04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crear un menú de opciones que permita:
            //              Cargar un array de caracteres.Recomendación: utilizar el método toCharArray().
            //              Ordenar vector.
            //              Contar vocales dentro del vector. (Cuantas a, e, i, o y u)
            //              Reemplazar consonantes por el carácter ‘*’ y mostrar

            string opcion;
            string pedido;

            Console.WriteLine("elija una opcion");
            Console.WriteLine("1. Cargar un array de caracteres.");
            Console.WriteLine("2. Ordenar vector.");
            Console.WriteLine("3. Contar vocales dentro del vector. ");
            Console.WriteLine("4. Reemplazar consonantes por el carácter ‘*’ y mostrar");

            opcion = Console.ReadLine();


            switch (opcion)
            {
                case "1":

                    Vector[i] = PedirVector("ingrese una palabra para convertir en array");
                    for (int i = 0; i < .Length; i++)
                    {
                        Console.Write(PedirVector("ingrese una palabra para convertir en array")[i]);

                        if (i < PedirVector("ingrese una palabra para convertir en array").Length - 1)
                        {
                            Console.WriteLine($"{PedirVector("ingrese una palabra para convertir en array")} - ");
                        }
                    }

                case "2":
                    //Console.Write($"el vector ingresado es: { PedirVector("ingrese el vector que quiere ordenar: ")}");

                    //for (int i = 0; int i < length; int i++)
                    //{

                    //}
                    break;
                case "3":

                    break;
                case "4":

                    break;

            }

        }
        public static char[] PedirVector(string pedido)
        {
            string lectura;

            Console.Write(pedido);
            lectura = Console.ReadLine();

            char[] vectorLectura = lectura.ToCharArray();

            //foreach (char item in vectorLectura)
            {
                return vectorLectura;
            }
            
        }

    }
}
