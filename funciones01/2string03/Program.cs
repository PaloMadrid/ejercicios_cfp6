namespace string03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string palabra;
            string palabraModificada = "";

            Console.Write("ingrese una palabra: ");
            palabra = Console.ReadLine();

            foreach (char unaLetra in palabra)
            {

                if (unaLetra == 'a')
                {
                    palabraModificada += '*';
                }
                else
                {
                    palabraModificada += unaLetra;
                }


            }

            char[] caracteres = palabraModificada.ToArray();

            caracteres.Reverse();

            Console.Write(caracteres);

        }
    }
}