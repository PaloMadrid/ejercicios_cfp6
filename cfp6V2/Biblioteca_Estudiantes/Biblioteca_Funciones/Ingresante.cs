using Biblioteca_Estudiantes;
using System.Text;

namespace Ingresantes
{
    public class Ingresante
    {
        string nombre ;
        string apellido ;
        int edad ;
        string genero ;
        string pais ;
        List<string> cursos ;

        public Ingresante(string nombre, string apellido, int edad, string genero,string pais, List<string> cursos)
        {
            this.nombre = nombre; 
            this.apellido = apellido;
            this.edad = edad;
            this.genero = genero;
            this.pais = pais;
            this.cursos = cursos;
        }

        public string Nombre { get => nombre; }
        public string Apellido { get => apellido;  }
        public int Edad { get => edad; }
        public string Genero { get => genero;  }
        public string Pais { get => pais;  }
        public string Cursos 
        {
            get 
            {
            StringBuilder sb = new StringBuilder();

                for (int i = 0;i<cursos.Count; i++)
                {
                    sb.Append(cursos[i]);

                    if (i< cursos.Count - 1)
                    {
                        sb.Append(" - ");
                    }
                }

                return sb.ToString();
            } 
        }

        public static List<string> ListaDePaises()
        {
            return new List<string>
            {
                 new string ("Argentina"),
                 new string ("Peru"),
                 new string ("Bolivia"),
                 new string ("Paraguay"),
                 new string ("Chile"),
                 new string ("Ecuador")
            };
        }

    }
}
