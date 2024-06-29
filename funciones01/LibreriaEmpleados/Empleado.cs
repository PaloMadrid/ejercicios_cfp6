using System.Drawing;

namespace LibreriaEmpleados
{
    public abstract class Empleado
    {
        protected string nombre;
        protected double salario;
        protected string departamento;
        protected int antiguedad;

        /*
         Crear la clase Empleado con los atributos Nombre, Salario,Departamento,Antiguedad.
        Declarar el método abstracto Trabajar().
        Implementar el método virtual MostrarInfo() para mostrar la información básica del empleado.
        Implementar el método virtual CalcularBonificacion() para calcular una bonificación base, por defecto es 0.
        Declarar el método abstracto SueldoTotal(), retorna la informacion de la suma del sueldo mas el valor de la bonificacion

         */
        public Empleado(string nombre, string departamento, int antiguedad)
        {
            this.nombre = nombre;
            this.salario = 10000;

                    //Elegir un item de una lista como valor de un atributo
            //if (Departamentos().Contains(departamento))
            //{
            //    this.departamento = departamento;
            //}
            //else
            //{
            //    //throw new ArgumentException("Departamento no válido");
            //}

            this.departamento = departamento;
            this.antiguedad = antiguedad;
        }

        public static List<string> Departamentos ()
        {
            List<string> departamentos= new List<string>()
            {
                "Analisis","Desarrollo"
            };

            return departamentos;
        }

        /*
         
        Declarar el método abstracto Trabajar().
        Implementar el método virtual MostrarInfo() para mostrar la información básica del empleado.
        Implementar el método virtual CalcularBonificacion() para calcular una bonificación base, por defecto es 0.
        Declarar el método abstracto SueldoTotal(), retorna la informacion de la suma del sueldo mas el valor de la bonificacion

         */

        public abstract string Trabajar();

        public virtual string MostrarInfo()
        {
            return $"Nombre: {this.nombre} - Salario: {this.salario} - Departamento: {this.departamento} - Antigüedad: {this.antiguedad}";
        }
        
        public virtual double CalcularBonificacion() 
        {
            return 0;
        }

        public abstract double SueldoTotal();
    }
}
