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

        public void Atacar(int agilidadDefensor, int resistenciaDefensor)
        {
            this.daño = 0;
            this.habilidadAtaque = 0;

            int ataque = Atacar();
            int esquivada = Esquivar(agilidadDefensor);

            this.habilidadAtaque = ataque - esquivada;

            Console.WriteLine($"ataque {ataque}\nesquivada:{esquivada}\nhabilidad de ataque: {this.habilidadAtaque}\ndaño-------------------------");

            if (AtacarPrimeraFase())
            {
                
                int golpe = Golpear();
                int bloqueo = Bloquear(resistenciaDefensor);

                this.daño = golpe - bloqueo;

                Console.WriteLine($"golpe {golpe}\nbloqueo:{bloqueo}\ndaño: {this.daño}\n------------------------------");

                if (AtacarSegundaFase())
                {

                    //return this.daño;
                }


            }
            //return 0;

        }
        public bool AtacarPrimeraFase()
        {

            if (this.habilidadAtaque> 0)
            {
                return true;
            }
            else
            { return false; }
        }

        public int Atacar()
        {
            
            
            return this.ataque + rng();
        }

        public int Esquivar(int agilidadDefensiva)
        {
            return agilidadDefensiva + rng();
        }

        public bool AtacarSegundaFase()
        {

            if (this.daño > 0)
            {
                return true;

            }
            return false;
        }

        public int Golpear()
        {
            return this.fuerza + rng();
        }

        public int Bloquear(int resistenciaDefensor)
        {
            return rng() + resistenciaDefensor;
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

        public string MostrarMensaje(string nombreDefensor)
        {
            if (AtacarPrimeraFase())
            {
                if (AtacarSegundaFase())
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
