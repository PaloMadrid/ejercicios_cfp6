using System.Collections.Specialized;
using System.Drawing;
using System.Globalization;
using System.Runtime.Serialization;
using System.Security.Cryptography;

namespace Libreria_Personajes
{
    public class Personaje
    {
        //atributos: clase, ataque, resistencia, fuerza, agilidad, vida

        string nombre;
        string clase;
        int ataque;
        int resistencia;
        int fuerza;
        int agilidad;
        int vida;

        //variables p/operaciones
        int daño = 0;
        public static Random rnd;
        int habilidadAtaque;
        //setters

        //////set no puede tener retornos de valores
        public bool SetNombre(string nombre)
        {
            this.nombre = nombre;
            return true;
        }

        //getters

        public string GetNombre()
        {
            return nombre;
        }
        public string GetClase()
        {
            return clase;
        }

        public int GetAtaque()
        {
            return ataque;
        }

        public int GetResistencia()
        {
            return resistencia;
        }

        public int GetFuerza()
        {
            return fuerza;
        }

        public int GetAgilidad()
        {
            return agilidad;
        }

        public int GetVida()
        {
            return vida;
        }

        public int GetDaño()
        {
            return daño;
        }

        public int GetHabilidadAtaque()
        {
            return habilidadAtaque;
        }

        //constructor
        public Personaje(string clase, int ataque, int resistencia, int fuerza, int agilidad)
        {
            this.nombre = "";
            this.clase = clase;
            this.ataque = ataque;
            this.resistencia = resistencia;
            this.fuerza = fuerza;
            this.agilidad = agilidad;
            this.vida = 20;

        }

        //metodos
        public string PersonajeToString()
        {
            return $"clase: {clase} - ataque: {ataque} - resistencia: {resistencia} - fuerza: {fuerza} - agilidad: {agilidad} - vida: {vida}";
        }


        ///????
        static Personaje()
        {
            Personaje.rnd = new Random();
        }

        public int Atacar(int agilidadDefensor, int resistenciaDefensor)
        {
            this.daño = 0;

            int ataque = Atacar();
            int esquivada = Esquivar(agilidadDefensor);
                       
                        int primeraFase = ataque - esquivada;

            Console.WriteLine($"ataque {ataque}\nesquivada:{esquivada}\npriemera fase: {primeraFase}");

            if (primeraFase>0)
            {
                this.habilidadAtaque = primeraFase;

                int golpe = Golpear();
                int bloqueo = Bloquear(resistenciaDefensor);

                int segundaFase = golpe - bloqueo;

                Console.WriteLine($"golpe {golpe}\nbloqueo:{bloqueo}\nsegunda fase: {segundaFase}");

                if (segundaFase>0)
                {
                    this.daño = segundaFase;

                    return this.daño;
                }


            }
            return 0;

        }
        //public bool AtacarPrimeraFase(int primeraFase)
        //{

        //    if (primeraFase > 0)
        //    {
        //        return true;
        //    }
        //    else
        //    { return false; }
        //}

        public int Atacar()
        {
            return this.ataque + Personaje.rnd.Next(1, 10);
        }

        public int Esquivar(int agilidadDefensiva)
        {
            return agilidadDefensiva + Personaje.rnd.Next(1, 10);
        }

        //public bool AtacarSegunaFase(int segundaFase)
        //{

        //    if (segundaFase > 0)
        //    {
        //        return true;

        //    }
        //    else
        //    {
        //        this.daño = 0;
        //        return false;
        //    }
        //}

        public int Golpear()
        {
            return this.fuerza + Personaje.rnd.Next(1, 10);
        }

        public int Bloquear(int resistenciaDefensor)
        {
            return Personaje.rnd.Next(1, 10) + resistenciaDefensor;
        }

        public int rng()
        {
            return (Personaje.rnd.Next(1, 10));
        }

        public void RecibirDanio(int dañoRealizado)
        {


            if (dañoRealizado > 0)
            {

                this.vida -= dañoRealizado;
            }



            if (this.vida < 0)
            {
                this.vida = 0;
            }
        }

        public string MostrarMensaje( string nombreDefensor)
        {
            if (this.habilidadAtaque>0)
            {
                if (this.daño>0)
                {
                    return $"{this.nombre} lanzo un golpe de: {this.daño}";


                }
                else
                {
                    return $"{nombreDefensor} bloqueo el golpe!";
                }

            }
            else
            {

                return $"{nombreDefensor} esquivo el golpe! ";
            }

        }
    }


}

//public bool AtacarPrimeraFase(int agilidadDefensor)
//{
//    // Generar habilidad de ataque
//    int habilidadAtaque = this.ataque + Personaje.rnd.Next(1, 11); // 11 para incluir el límite superior

//    // Generar habilidad de esquivada del defensor
//    int esquivada = agilidadDefensor + Personaje.rnd.Next(1, 11); // 11 para incluir el límite superior

//    // Comparar habilidad de ataque con habilidad de esquivada
//    return habilidadAtaque > esquivada;
//}
//public bool AtacarPrimeraFase(int agilidadDefensor)
//{

//    this.rng = Personaje.rnd.Next(1, 10);
//    this.habilidadAtaque = this.rng+ this.ataque;

//    this.rng = Personaje.rnd.Next(1, 10);
//    this. esquivada = this.rng + agilidadDefensor;

//    if (this.habilidadAtaque > this.esquivada)
//    {
//        return true;
//    }
//    else
//    {
//        return false;
//    }

//}