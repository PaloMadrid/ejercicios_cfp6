namespace C01bibliotecaFunciones
{
    public class cadena
    {


        public static string PedirCadena(string pedido)
        {
            string lectura;

            Console.Write(pedido);
            lectura = Console.ReadLine();

            return lectura;
        }

        public static bool MedirPalabra(int longitud)
        {
            if (longitud >= 8)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public static string MostrarMensaje(string palabra, string salida)
        {
            Console.WriteLine($"la palabra {palabra} es {salida}");
            return salida;
        }

    }
}
