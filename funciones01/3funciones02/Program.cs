using static System.Runtime.InteropServices.JavaScript.JSType;
using C02bibliotecaFunciones;
using System.Drawing;

namespace Cfunciones02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crear una función que determine si el número recibido por parámetro es primo o no.

            bool bandera;
            int numeroValido;

            do
            {
                bandera = false;
                Console.BackgroundColor = ConsoleColor.Black;

                Console.WriteLine("**************************\nIngrese un numero");

                //    if (numero.PedirNumero("ingrese un numero"))
                //    {
                //        numeroValido=int.Parse( Console.ReadLine());

                //        Console.WriteLine("es un numero valido");

                //        if (numero.EsPrimo(numerovalido))
                //        {
                //            console.writeline($"el numero {numerovalido} es primo");
                //        }
                //        else
                //        {
                //            console.writeline($"el numero {numerovalido} no es primo");
                //        }
                //    }
                //}


                if (int.TryParse(Console.ReadLine(), out numeroValido))
                {
                    bandera = true;

                    Console.WriteLine("es un numero valido");
                    if (numero.EsPrimo(numeroValido))
                    {
                        Console.BackgroundColor = ConsoleColor.Magenta;
                        Console.WriteLine($"el numero {numeroValido} es primo");
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine($"el numero {numeroValido} no es primo");
                    }
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("no es un numero valido");

                }

                Console.BackgroundColor = ConsoleColor.Black;
            } while (bandera == false);





        }
    }
}
