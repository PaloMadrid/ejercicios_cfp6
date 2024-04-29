namespace string01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Pedir el ingreso de una palabra, verificar que por lo menos tenga 5 caracteres de no ser así informar, luego mostrar los primeros 3 caracteres.
            //ej: zapallo->zap

            string palabra;
            //int cantidadLetras=0;
            //ingrese una palabra y leer lo que ingreso


            do
            {
                Console.Write("ingrese una palabra de 5 caracteres o mas: ");
                palabra = Console.ReadLine();


                //medir longitud de palabra
                //cantidadLetras = palabra.Length;

                if (palabra.Length < 5)
                {
                    Console.WriteLine("la palabra es muy corta");
                }

            } while (palabra.Length < 5);

            for (int i = 0; i < 3; i++)
            {
                Console.Write(palabra[i]);
            }

        }
    }
}
