using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mis_clases
{
    public class Funcion
    {
        
        public static int ContarCaracteres(string dato)
        {
            int cantidad = 0;
            
            foreach (char c in dato)
            {
                if (!char.IsWhiteSpace(c))
                {
                    cantidad++;

                }
            }
            return cantidad;
        }
        public static bool EsNumerico(string dato)
        {
            bool esNumerico = true;
            foreach (char c in dato)
            {
                if (char.IsDigit(c))
                {
                    esNumerico = false;
                    break;
                }
            }
            return esNumerico;
        }

        public static bool EsSoloLetras(string dato)
        {
            bool esSoloLetras = true;

            foreach(char c in dato)
            {
                if (!char.IsLetter(c))
                {
                esSoloLetras = false;
                break;
                }
            }
            return esSoloLetras;
        }

    }
}
