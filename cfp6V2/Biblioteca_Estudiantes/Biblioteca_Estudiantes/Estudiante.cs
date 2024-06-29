using System.Text;

namespace Biblioteca_Estudiantes
{
    public class Estudiante
    {
        private string apellido;
        private string legajo;
        private string nombre;
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        private static Random notaFinal;

        
        public string Legajo { get => legajo; set => legajo = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int NotaPrimerParcial { get => notaPrimerParcial; set => notaPrimerParcial = value; }
        public int NotaSegundoParcial { get => notaSegundoParcial; set => notaSegundoParcial = value; }
        

        public double NotaFinal
        {
            get
            {
                return this.CalcularNotaFinal();
            }
        }

        public double Promedio
        {
            get
            {
                return this.CalcularPromedio();
            }
        }



        static Estudiante()
        {
            Estudiante.notaFinal = new Random();       
        }

        public Estudiante(string apellido, string legajo, string nombre)
        {
            this.apellido = apellido;
            this.legajo = legajo;
            this.nombre = nombre;
            
        }

        public void  SetNotaPrimerParcial(int nota)
        {
           this.notaPrimerParcial = nota;
        }

        public void SetNotaSegundoParcial(int nota)
        {
            this.notaSegundoParcial = nota;
        }

        private double CalcularPromedio()
        {
            double promedio;

            promedio = (double)notaPrimerParcial + notaSegundoParcial / 2;

            return promedio;
        }
         
        public double CalcularNotaFinal()
        {
            double retorno = -1;
            if (CalcularPromedio()>=6 )
            {
                retorno =Estudiante.notaFinal.Next(6,10) ;
            }

            return retorno;
        }
        
        public static List<Estudiante> ListaDeAlumnos()
        {
            return new List<Estudiante>
            {
                 new Estudiante("Garcia", "1", "Roberto"),
                 new Estudiante("Perez", "2", "Gabriel"),
                 new Estudiante("Fernandez", "3", "Maria")
            };
        }
        
        public string Mostrar()
        {
            StringBuilder mensaje = new StringBuilder();

            mensaje.AppendLine($"Nombre: {this.nombre}");
            mensaje.AppendLine($"Apellido: {this.apellido}");
            mensaje.AppendLine($"Legajo: {this.legajo}");

            double notaFinal=this.CalcularNotaFinal();

            if (notaFinal != -1)
            {
                
                mensaje.AppendLine();
            }
            else
            {
                mensaje.AppendLine();
            }

            return mensaje.ToString();
        }

        public override string? ToString()
        {
            return $"{apellido}, {nombre}";
        }
    }
}
