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

            char[] vectorCaracter=null;

            switch (opcion)
            {
                case "1":

                    Console.Write("Ingrese una cadena de caracteres: ");
                    string cadena = Console.ReadLine();
                    vectorCaracter = cadena.ToCharArray();
                    break;

                case "2":
                    if (vectorCaracter != null)
                    {
                        Array.Sort(vectorCaracter);
                        string ordenado = new string(vectorCaracter);
                        Console.WriteLine($"Vector ordenado: {ordenado}" );
                    }
                    else
                    {
                        Console.WriteLine("Primero debe cargar un array de caracteres.");
                    }
                    break;
                case "3":
                    if (vectorCaracter != null)
                    {
                        int contadorA = 0;
                        int contadorE = 0;
                        int contadorI = 0;
                        int contadorO = 0;
                        int contadorU = 0;

                        foreach (char c in vectorCaracter)
                        {
                            if (EsVocal)
                            {
                                switch (char.ToLower(c))
                                {
                                    case 'a':
                                        contadorA++;
                                        break;
                                    case 'e':
                                        contadorE++;
                                        break;
                                    case 'i':
                                        contadorI++;
                                        break;
                                    case 'o':
                                        contadorO++;
                                        break;
                                    case 'u':
                                        contadorU++;
                                        break;
                                }
                            }
                            
                        }
                        Console.WriteLine("Cantidad de 'a': " + contadorA);
                        Console.WriteLine("Cantidad de 'e': " + contadorE);
                        Console.WriteLine("Cantidad de 'i': " + contadorI);
                        Console.WriteLine("Cantidad de 'o': " + contadorO);
                        Console.WriteLine("Cantidad de 'u': " + contadorU);
                    }
                        break;
                case "4":
                    if (vectorCaracter != null)
                    {
                        for (int i = 0; i < vectorCaracter.Length; i++)
                        {
                            if (!EsVocal(vectorCaracter[i]) && char.IsLetter(vectorCaracter[i]))
                            {
                                vectorCaracter[i] = '*';
                            }
                        }
                        Console.WriteLine("Consonantes reemplazadas por '*': " + new string(vectorCaracter));
                    }
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
        static bool EsVocal(char c)
        {
            char[] vocales = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            return vocales.Contains(c);
        }
    }
}
