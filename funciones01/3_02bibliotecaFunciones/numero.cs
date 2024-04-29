namespace C02bibliotecaFunciones
{
    public class numero
    {
        //public static bool PedirNumero(string mensaje)
        //{
        //    int numeroValido;

        //    Console.WriteLine(mensaje);


        //    if (int.TryParse(Console.ReadLine(), out numeroValido))
        //    {


        //        return true;
        //    }
        //    else
        //    {

        //        return false;
        //    }
        //}

        public static bool EsPrimo(int numeroValido)
        {
             for (int i = 2; i < numeroValido; i++)
            {
                if ((numeroValido % i) == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
