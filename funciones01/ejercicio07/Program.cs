using System.Runtime.ConstrainedExecution;

namespace ejercicio07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ingresar 15 números y determinar:
            //Suma de los negativos.
            //Suma de los positivos.
            //Cantidad de positivos.
            //Cantidad de negativos.
            //Cantidad de ceros.
            //Cantidad de números pares.
            //Promedio de positivos.
            //Promedio de negativos.
            //Diferencia entre positivos y negativos, (positivos - negativos).
            //El número máximo
            //De los negativos el mínimo

            int numero;
            int ceros = 0;
            int cantidadPositivos = 0;
            int cantidadNegativos = 0;
            int pares = 0;
            int sumaPositivos = 0;
            int sumaNegativos = 0;
            double promedioPositivos;
            double promedioNegativos;
            double diferencia;
            int maximo = 0;
            int minimo = 0;

            for (int i = 0; i < 15; i++)
            {
                Console.Write($"ingrese el {i+1} numero: ");
                numero = int.Parse(Console.ReadLine());

                if (i == 0 || numero > maximo)
                {
                    maximo = numero;

                }

                if (numero == 0)
                {
                    ceros += 1;
                }
                else
                {
                    if (numero > 0)
                    {
                        cantidadPositivos++;
                        sumaPositivos += numero;
                    }
                    else
                    {
                        cantidadNegativos++;
                        sumaNegativos += numero;

                        if (numero < minimo)
                        {
                            minimo = numero;

                        }

                    }
                }
                if (numero % 2 == 0)
                {
                    pares++;
                }

            }

            diferencia = sumaPositivos - sumaNegativos;

            Console.WriteLine($"cantidad ceros = {ceros}");
            Console.WriteLine($"cantidad negativos = {cantidadNegativos}");
            Console.WriteLine($"cantidad positivos = {cantidadPositivos}");

            if (cantidadNegativos == 0)
            {
                Console.WriteLine("no se ingresaron valores negativos por lo que no se puede calcular el promedio ni el minimo de los mismos");
            }
            else
            {
                promedioNegativos = sumaNegativos / cantidadNegativos;
                Console.WriteLine($"promedio negativos = {promedioNegativos}");
                Console.WriteLine($"minimo de los negativos = {minimo}");
            }

            if (cantidadPositivos == 0)
            {
                Console.WriteLine("no se ingresaron valores positivos, por lo que no se puede calcular el promedio de los mismos");
            }
            else
            {
                promedioPositivos = sumaPositivos / cantidadPositivos;
                Console.WriteLine($"promedio positivos = {promedioPositivos}");
            }

            Console.WriteLine($"numero maximo = {maximo}");
            Console.WriteLine($"diferencia (positivos - negativos) = {diferencia}");
            Console.WriteLine($"cantidad pares = {pares}");



        }
    }
}
