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
                 *  segun agilidad da mas golpes
                 *  bufo por critico y penalizacion por pifia
             * limpiar codigo
             * agregar movimiento, objetos y habilidades (listas dentro de listas?)
             * cortar la vida en cero
             * mostrar cuando esquiva y cuando no pega
             */


            Personaje personaje1 = new Personaje("fuerte", 10, 8, 14, 1);
            Personaje personaje2 = new Personaje("agil", 10, 1, 8, 14);
            Personaje personaje3 = new Personaje("tanque", 10, 14, 6, 2);
            Personaje personaje4 = new Personaje("caballero", 10, 9, 9, 6);

            int round = 1;
            int danioRealizado;
            //int recibirDanio;


            List<Personaje> misPersonajes = new List<Personaje>();

            misPersonajes.Add(personaje1);
            misPersonajes.Add(personaje2);
            misPersonajes.Add(personaje3);
            misPersonajes.Add(personaje4);

            // crear otra clase: jugadores
            Personaje p1 = personaje2;
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

                            danioRealizado = p1.Atacar(p2.GetAgilidad(), p2.GetResistencia());

                            if (danioRealizado > 0)
                            {

                                p2.RecibirDanio(danioRealizado);
                            }

                            
                            Console.WriteLine(p1.MostrarMensaje( p2.GetNombre()));

                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;

                            Console.WriteLine("****ataca jugador 2******");

                            danioRealizado = p2.Atacar(p1.GetAgilidad(), p1.GetResistencia());

                            if (danioRealizado > 0)
                            {
                                p1.RecibirDanio(danioRealizado);
                            }
                            Console.WriteLine(p2.MostrarMensaje( p1.GetNombre()));

                        }

                        Console.WriteLine($"vida {p1.GetNombre()}: {p1.GetVida()}");
                        Console.WriteLine($"vida {p2.GetNombre()}: {p2.GetVida()}");
                    }




                }

            } while (p2.GetVida() > 0 && p1.GetVida() > 0);
        }
    }

}

//if (p1.GetAgilidad() > p2.GetAgilidad())
//{

//    Console.ForegroundColor = ConsoleColor.Red;

//    Console.WriteLine("****ataca jugador 1******");
//    p1.Atacar(p2.GetAgilidad(), p2.GetResistencia());
//    if (p1.AtacarSegunaFase())
//    {

//        p2.RecibirDanio(p1.GetDaño());
//    }


//    Console.WriteLine(p1.MostrarMensaje(p2.GetAgilidad(), p2.GetNombre()));

//    Console.WriteLine($"vida {p2.GetNombre()}: {p2.GetVida()}");
//    Console.WriteLine($"vida {p1.GetNombre()}: {p1.GetVida()}");
//    //Console.WriteLine(p1.MostrarMensaje2(p2.GetAgilidad(), p2.GetNombre()));


//    //Console.ForegroundColor = ConsoleColor.Blue;
//    //Console.WriteLine("******ataca jugador 2*********");
//    //p2.Combatir(ConsoleColor.Blue, p1.GetAgilidad(), p1.GetResistencia());
//    //Console.WriteLine(p2.MostrarMensaje1(p1.GetAgilidad(), p1.GetNombre()));

//    //Console.WriteLine(p2.MostrarMensaje2(p1.GetAgilidad(), p1.GetNombre()));

//}
//else
//{
//    //    p2.Combatir(ConsoleColor.Red, p1.GetAgilidad(), p1.GetResistencia());

//    //    Console.WriteLine($"{p2.GetNombre()} lanzo un golpe de: {p2.GetDaño()}");

//    //    p1.Combatir(ConsoleColor.Blue, p2.GetAgilidad(), p2.GetResistencia());

//    //    Console.WriteLine($"{p1.GetNombre()} lanzo un golpe de: {p1.GetDaño()}");
//}




//Console.WriteLine($"daño 2 ={p2.GetDaño()} daño 1 ={p1.GetDaño()}");
//Console.WriteLine($"vida 2 ={p2.GetVida()} vida 1= {p1.GetVida()}");
//if (p1.AtacarPrimeraFase(p1.GetAtaque(),))
//{
//    if (p1.AtacarSegunaFase(p2.GetResistencia()))
//    {
//        Console.WriteLine($"{p1.GetNombre()} lanzo un golpe de: {p1.GetDaño()}");
//        p2.RecibirDanio(p1.GetDaño());
//    }
//    else
//    {
//        Console.ForegroundColor = ConsoleColor.Red;
//        Console.WriteLine($"{p2.GetNombre()} bloqueo el golpe!");
//    }
//}
//else
//{
//    Console.ForegroundColor = ConsoleColor.Red;
//    Console.WriteLine($"{p2.GetNombre()} esquivo el golpe!");
//}
//Console.ForegroundColor = ConsoleColor.Blue;
//

//Console.ForegroundColor = ConsoleColor.Red;
//if (p2.AtacarPrimeraFase(p1.GetAgilidad()))
//{
//    danioEmitido = p2.AtacarSegunaFase(p1.GetResistencia());
//    Console.WriteLine($"{p2.GetNombre()} lanzo un golpe de: {danioEmitido}");
//    p1.RecibirDanio(danioEmitido);

//}










//    colorPJ = ConsoleColor.Blue;
//    agilidadDefensor = p2.GetAgilidad();
//    resistenciaDefensor = p2.GetResistencia();
//    nombreAtacante = p1.GetNombre();
//    dañoRecibido = p2.GetDaño();
//    nombreDefensor = p2.GetNombre();
//    vidaDefensor = p2.GetVida();









//if (p2.AtacarPrimeraFase(p1.GetAgilidad()))
//{
//    //p2.AtacarSegunaFase(p1.GetResistencia());

//    //p1.RecibirDanio(danioEmitido);

//    //if (p1.Combatir(ConsoleColor.Red, p1.GetAgilidad(), p1.GetResistencia(), p2.GetNombre(), p1.GetDaño()))
//    //{
//    //    Console.WriteLine($"{p2.GetNombre} lanzo un golpe de: {p1.GetDaño}");
//    //}
//    //else
//    //{
//    //    Console.WriteLine($"{p1.GetNombre()} esquivo el golpe!");

//    //}
//    //Console.WriteLine($"vida {p1.GetNombre()}: {p1.GetVida()}");

//    //if (p1.Combatir(colorPJ, agilidadDefensor, resistenciaDefensor, p1.GetNombre(), p2.GetDaño()))
//    //{
//    //    Console.WriteLine($"{nombreAtacante} lanzo un golpe de: {dañoRecibido}");
//    //}
//    //else
//    //    //{
//    //    Console.WriteLine($"{nombreDefensor} esquivo el golpe!");
//    ////}
//    //p1.Combatir(colorPJ, agilidadDefensor, resistenciaDefensor, dañoRecibido);

//    //Console.ForegroundColor = colorPJ;
//    //if (p1.AtacarPrimeraFase(agilidadDefensor))
//    //{
//    //    if (p1.AtacarSegunaFase(resistenciaDefensor))
//    //    {
//    //        Console.WriteLine($"{nombreAtacante} lanzo un golpe de: {dañoRecibido}");
//    //        p2.RecibirDanio(dañoRecibido);
//    //    }

//    //}
//    //else
//    //{
//    //    Console.WriteLine($"{p1.GetNombre()} esquivo el golpe!");

//}
//Console.WriteLine($"vida {nombreDefensor}: {vidaDefensor}");