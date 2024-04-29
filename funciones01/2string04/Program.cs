namespace string04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string palabra = "             000001234000000";

            //elimina un caracter del principio y el final, si usamos arrays [] podemos poner varios caracteres
            //va desde el principio hasta que encuentra un caracter distinto al que pido eliminar

            //Console.WriteLine(palabra.TrimStart([' ','0'] )); <-solo comienzo

            //solo del principio:
            Console.WriteLine(palabra.Trim([' ', '0']));


        }
    }
}
