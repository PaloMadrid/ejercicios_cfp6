namespace ejercicio05
{
    internal class hospital
    {
        static void Main(string[] args)
        {
            double presupuesto;
            double traumatologia;
            double pediatria;
            double cardiologia;


            Console.Write("ingrese el presupuesto de este año: ");

            presupuesto = double.Parse(Console.ReadLine());

            traumatologia = presupuesto * 0.15;
            pediatria = presupuesto * 0.45;
            cardiologia = presupuesto * 0.4;

            Console.WriteLine($"traumatologia: {traumatologia}");
            Console.WriteLine($"pediatria: {pediatria}");
            Console.WriteLine($"cardiologia: {cardiologia}");
        }
    }
}
