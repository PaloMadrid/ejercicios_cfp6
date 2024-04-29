using System.Numerics;
using System.Runtime.ConstrainedExecution;
using C03bibliotecaFunciones;

namespace _3_03funciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            Se requiere la creación de una función que cumpla con los siguientes requisitos:
            //            La función debe recibir tres parámetros: 'valor'(numérico), 'porcentaje'(numérico) y 'esAumento'(booleano).
            //Si el parámetro 'esAumento' es verdadero, la función debe aumentar el 'valor' original aplicando el 'porcentaje' dado.
            //Si el parámetro 'esAumento' es falso, la función debe disminuir el 'valor' original aplicando el 'porcentaje' dado.
            //El resultado obtenido después de aplicar el porcentaje al 'valor' original debe ser retornado por la función.

            int valor=1000;
            int porcentaje=50;
            bool esAumento=false;

            Console.WriteLine($"valor = {valor} \nporcentaje = {porcentaje}% \nValor con variacion = {variacion.Incrementar(valor, porcentaje, esAumento)}");

        }
    }
}
