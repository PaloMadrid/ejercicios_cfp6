using Libreria_Personajes;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;

namespace testeo_PVP
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* mejorar sistema de peleas
             * limpiar codigo
             * agregar movimiento, 
             * clases: objetos(loot?) , habilidades, jugadores (leveleo),razas
             */


            Personaje personaje1 = new Personaje("fuerte", 10, 8, 14, 4);
            Personaje personaje2 = new Personaje("agil", 10, 4, 8, 14);
            Personaje personaje3 = new Personaje("tanque", 10, 14, 6, 2);
            Personaje personaje4 = new Personaje("caballero", 10, 9, 9, 6);

            int round = 1;
            int danioRealizado;

            List<Personaje> misPersonajes = new List<Personaje>();

            misPersonajes.Add(personaje1);
            misPersonajes.Add(personaje2);
            misPersonajes.Add(personaje3);
            misPersonajes.Add(personaje4);

            // crear otra clase: jugadores
            Personaje p1 = personaje4;
            Personaje p2 = personaje1;

            List<Personaje> misJugadores = new List<Personaje>();

            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("******* Todas las clases *********");

            foreach (Personaje item in misPersonajes)
            {
                Console.WriteLine(item.PersonajeToString());
            }

            Console.WriteLine("Hola, jugador 1.\nComo se llama tu personaje?");
            p1.SetNombre(Console.ReadLine());
            Console.WriteLine($"nombre ingresado: {p1.GetNombre()}");

            Console.WriteLine("Hola, jugador 2.\nComo se llama tu personaje?");
            p2.SetNombre(Console.ReadLine());
            Console.WriteLine($"nombre ingresado: {p2.GetNombre()}");

            do
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"**********   ROUND {round}°   ************");

                Console.WriteLine(p1.PersonajeToString());
                Console.WriteLine(p2.PersonajeToString());

                for (int i = 0; i < 2; i++)
                {
                    if (p1.GetVida() > 0 && p2.GetVida() > 0)
                    {
                        if (((p1.GetAgilidad() > p2.GetAgilidad()) && (i == 0)) || ((p1.GetAgilidad() < p2.GetAgilidad()) && (i == 1)))
                        {
                            Console.ForegroundColor = ConsoleColor.Red;

                            Console.WriteLine("****ataca jugador 1******");

                            p1.Combatir(p2.GetAgilidad(), p2.GetResistencia());

                            p2.RecibirDanio(p1.GetDaño());

                            Console.WriteLine(p1.MostrarMensaje(p2.GetNombre()));
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;

                            Console.WriteLine("****ataca jugador 2******");

                            p2.Combatir(p1.GetAgilidad(), p1.GetResistencia());

                            p1.RecibirDanio(p2.GetDaño());

                            Console.WriteLine(p2.MostrarMensaje(p1.GetNombre()));
                        }
                        Console.WriteLine($"vida {p1.GetNombre()}: {p1.GetVida()}");
                        Console.WriteLine($"vida {p2.GetNombre()}: {p2.GetVida()}");
                    }
                }
                round++;
            } while (p2.GetVida() > 0 && p1.GetVida() > 0);
        }
    }

}