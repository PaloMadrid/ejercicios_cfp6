using Libreria_vehiculos;
using System.Data;

namespace testeos_generales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehiculo vehiculo1=new Vehiculo("Fiat","2020");
            Vehiculo moto1 = new Moto("yamaha", "2015", "deportiva", 200);
            Vehiculo auto1 = new Auto("BMW", "2021", 4, 50);

            List<Vehiculo> misVehiculos = new List<Vehiculo>() 
            { 
                vehiculo1,moto1,auto1
            };

            foreach (Vehiculo item in misVehiculos)
            {
                Console.WriteLine(item.MostrarInfo());
                Console.WriteLine(item.Conducir()); 

                if (item.GetType()== typeof(Moto))
                {
                    Console.WriteLine(((Moto)item).HacerCaballito());

                } else if(item.GetType()== typeof(Auto))
                {
                    Console.WriteLine(((Auto)item).AbrirBaul());
                }
            }
            
            

        }
    }
}
