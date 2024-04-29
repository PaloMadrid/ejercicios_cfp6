namespace ejercicio08
{
    internal class pedir_opcion
    {
        static void Main(string[] args)
        {
            int opcion;

            Console.WriteLine("elija una opcion \n 1. Fondo azul y letras rojo \n 2. Fondo verde y letras amarillas \n 3. Fondo amarillo y letras azules\n 4. Fondo blanco y letras negras \n 5. Fondo magenta oscuro y letras amarillas \n 6. Fondo blanco y letras azules");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:

                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("eligio 1. Fondo azul y letras rojas");
                    break;
                case 2:
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("eligio 2. Fondo verde y letras amarillas");
                    break;
                case 3:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("eligio 3. Fondo amarillo y letras azules");
                    break;
                case 4:
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("eligio 4. Fondo blanco y letras negras");
                    break;
                case 5:
                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("eligio 5. Fondo magenta oscuro y letras amarillas");
                    break;
                case 6:
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("eligio 6. Fondo blanco y letras azules");
                    break;
                default:
                    Console.WriteLine("no eligio una opcion valida");
                    break;
            }

        }
    }
}
