using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaEmpleados
{
    public class Desarrollador: Empleado
    {
        /*Agregar los atributos LenguajeProgramacion y Experiencia.
Implementar el método Trabajar() para que imprima "El desarrollador está escribiendo código."
Sobrescribir CalcularBonificacion() para calcular una bonificación específica para desarrolladores, los desarrolladores reciben una bonificacion del 15% del salario.
Implementar el método DepurarCodigo(), debe informar que esta depurando el codigo escrito en un su lenguaje de programacion.
Implementar el método SalarioTotal().
*/
        string lenguajeProgramacion;
        string experiencia;

        public Desarrollador(string nombre, string departamento, int antiguedad,string lenguajeProgramacion, string experiencia)
            :base(nombre, departamento,antiguedad)
        {
            this.lenguajeProgramacion = lenguajeProgramacion;
            this.experiencia = experiencia;
        }

        public static List<string> Lenguajes()
        {
            List<string> lenguajes = new List<string>()
            {
                "C#","Java","JavaScript","Python","SQL"
            };

            return lenguajes;
        }

        public override string Trabajar()
        {
            return "El desarrollador está escribiendo código.";
        }

        public override double CalcularBonificacion()
        {
            return 1.15;
        }

        public string DepurarCodigo()
        {
            return $"Esta depurando el codigo escrito en {this.lenguajeProgramacion}.";
        }

        public override double SueldoTotal()
        {
            return base.salario*CalcularBonificacion();
        }
    }
}
