using System.Drawing;
using System;

namespace ejercicio09
{
    internal class cajero
    {
        static void Main(string[] args)
        {
            //Cajero Automático. A partir del ingreso de un monto en pesos(valor entero) debemos indicar
            //cuántos billetes de cada valor deberá entregar nuestro cajero automático.
            //Tener en cuenta que tenemos que entregar la menor cantidad de billetes posibles.
            //Deberán utilizar colores en consola.
            //Por ejemplo:
            //Importe $2825
            //Billetes de $1000: 2
            //Billetes de $500: 1
            //Billetes de $200: 1
            //Billetes de $100: 1
            //Billetes de $50: 0
            //Billetes de $20: 1
            //Billetes de $10: 0
            //Sobran $5

            int resto;
            int contadorMil = 0;
            int contadorQuinientos = 0;
            int contadorDoscientos = 0;
            int contadorCien = 0;
            int contadorCincuenta = 0;
            int contadorVeinte = 0;
            int contadorDiez = 0;

            Console.WriteLine("ingrese cuanto desea extraer");
            resto = int.Parse(Console.ReadLine());

            do
            {

                if (resto - 1000 > 0)
                {
                    resto -= 1000;
                    contadorMil++;
                }
                else
                {
                    if (resto - 500 > 0)
                    {
                        resto -= 500;
                        contadorQuinientos++;
                    }
                    else
                    {
                        if (resto - 200 > 0)
                        {
                            resto -= 200;
                            contadorDoscientos++;
                        }
                        else
                        {
                            if (resto - 100 > 0)
                            {
                                resto -= 100;
                                contadorCien++;
                            }
                            else
                            {
                                if (resto - 50 > 0)
                                {
                                    resto -= 50;
                                    contadorCincuenta++;
                                }
                                else
                                {
                                    if (resto - 20 > 0)
                                    {
                                        resto -= 20;
                                        contadorVeinte++;
                                    }
                                    else
                                    {
                                        if (resto - 10 > 0)
                                        {
                                            resto -= 10;
                                            contadorDiez++;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            } while (resto > 9);

            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"1000 = {contadorMil}");

            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine($"500 = {contadorQuinientos}");

            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine($"200 = {contadorDoscientos}");

            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"100 = {contadorCien}");

            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($"50 = {contadorCincuenta}");

            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"20 = {contadorVeinte}");

            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.WriteLine($"10 = {contadorDiez}");

            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine($"resto = {resto}");

        }
    }
}
