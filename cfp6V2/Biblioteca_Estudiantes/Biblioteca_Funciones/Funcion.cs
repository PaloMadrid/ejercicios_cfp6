namespace Biblioteca_Funciones
{
    public class Funcion
    {
        public static bool EsSoloLetras(string cadena)
        {
            bool soloLetras = false;

            foreach (char c in cadena)
            {
                if (char.IsLetter(c))
                {
                    soloLetras = true;
                    break;
                }
            }

            return soloLetras;
        }
    }
}
