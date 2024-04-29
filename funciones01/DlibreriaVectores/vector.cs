namespace DlibreriaVectores
{
    public class vector
    {
        public static int[] PedirVectorEnteros(int[] vectorEnteros)
        {
            for (int i = 0; i < vectorEnteros.Length; i++)
            {
                Console.WriteLine($"ingrese el {i + 1}° numero: ");
                vectorEnteros[i] = int.Parse(Console.ReadLine());
            }
            

            
            return vectorEnteros;
        }

        public static string[] MostrarVectorEnteros(int[] vectorEnteros)
        {
            for (int i = 0; i < vectorEnteros.Length; i++)
            {
               return string.Parse.vectorEnteros[i];

                if (i < vectorEnteros.Length - 1)
                {
                    return " | ";
                }
            }

        }
    }
}
