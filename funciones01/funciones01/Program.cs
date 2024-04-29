using C01bibliotecaFunciones;

namespace funciones01
{
    internal class medirPalabra
    {
        static void Main(string[] args)
        {
            //            Crear una función que evalúe si una palabra es corta o larga. Se considera larga
            //            si tiene más de 8 caracteres.
            //La función debe recibir un parámetro de tipo cadena(string) y su retorno debe ser booleano.
            string palabra;
            int largo;
            string mensaje;

            palabra = cadena.PedirCadena("ingrese una palabra: ");
            Console.WriteLine($"La palabra ingresada es {palabra}");

            largo = palabra.Length;
            Console.WriteLine($"El largo de la palabra {palabra} es {largo}");

            if (cadena.MedirPalabra(largo))
            {
                cadena.MostrarMensaje(palabra,"larga");
            }
            else
            {
                cadena.MostrarMensaje(palabra,"corta");
            }

            
        }
    }
}
