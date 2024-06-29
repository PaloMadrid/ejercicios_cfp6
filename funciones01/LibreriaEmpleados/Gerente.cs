using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaEmpleados
{
    public class Gerente : Empleado
    {
        int NumeroEmpleados;

        public Gerente(string nombre,  string departamento, int antiguedad, int numeroEmpleados)
            : base(nombre,  departamento, antiguedad)
        {
            NumeroEmpleados = numeroEmpleados;
        }

        /*Implementar el método Trabajar() para que imprima "El gerente está gestionando el departamento."
Sobrescribir CalcularBonificacion() para calcular una bonificación específica para gerentes, 
        los gerentes reciben una bonificacion del 25% del salario.
Implementar el método Planificar(), es retorna un string que informara que el gerente es creando 
        una planificacion para la cantidad de empleados que tenga a cargo.
Implementar el método SalarioTotal().*/

        public override string Trabajar()
        {
            return "El gerente está gestionando el departamento.";
        }

        public override double CalcularBonificacion()
        {       
            return 1.25;
        }

        public string Planificar()
        {
            return $"El gerente es creando una planificacion para {this.NumeroEmpleados} empleados.";
        }

        public override double SueldoTotal()
        {
            return CalcularBonificacion()  * base.salario;
        }
    }
}
