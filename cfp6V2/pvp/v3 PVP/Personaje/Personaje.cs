using System;
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

        static Personaje()
        {
            Personaje.rnd = new Random();
        }

        public void Combatir(int agilidadDefensor, int resistenciaDefensor)
        {
            this.daño = 0;
            this.habilidadAtaque = 0;

            int rndAtaque = rng();
            int ataque = Atacar(rndAtaque);

            int rndEsquivada = rng();
            int esquivada = Esquivar(agilidadDefensor, rndEsquivada);

            this.habilidadAtaque = ataque - esquivada;

            if (EsPifia(rndAtaque))
            {
                Console.WriteLine("PIFIA 1 fase: ATAQUE. su vida reduce un 10%. no puede inflingir daño");

                this.vida = Convert.ToInt32((this.vida) * 0.90);

                this.habilidadAtaque = 0;
            }

            if (EsCritico(rndEsquivada))
            {
                Console.WriteLine("CRITICO 1 fase: ESQUIVAR. es ingolpeable ");

                this.habilidadAtaque = 0;
            }

            if (EsPifia(rndEsquivada))
            {
                Console.WriteLine("PIFIA 1 fase: ESQUIVAR. el golpe entra aunque el otro jugador haya sacado numero bajo");

                this.habilidadAtaque = 1;
            }

            Console.WriteLine($"ataque {ataque}\nesquivada:{esquivada}\nhabilidad de ataque: {this.habilidadAtaque}\nrnd ataque: {rndAtaque}\nrnd esquivar: {rndEsquivada}\n-------------------------");
            
            if (AtacarPrimeraFase())
            {
                HacerAtaques(resistenciaDefensor, rndAtaque);
            }
        }
        public void HacerAtaques(int resistenciaDefensor, int rndAtaque)
        {
            int rndGolpe = rng();
            int golpe = Golpear(rndGolpe);

            int rndBloqueo = rng();
            int bloqueo = Bloquear(resistenciaDefensor, rndBloqueo);

            int dañoRealizado = golpe - bloqueo;

            if (AtacarSegundaFase(dañoRealizado))
            {
                if (EsCritico(rndAtaque))
                {
                    Console.WriteLine("CRITICO 1 fase: ATAQUE. este ataque no puede ser bloqueado");

                    dañoRealizado = golpe;
                }

                if (EsCritico(rndBloqueo))
                {
                    Console.WriteLine("BLOQUEO es critico 2 fase. no recibe daño este turno");

                    dañoRealizado = 0;
                }

                if (EsPifia(rndBloqueo))
                {
                    Console.WriteLine("BLOQUEO es PIFIA 2 fase: DEFENSA. reduce armadura 50%");

                    //modificar equipamiento
                }

                if (EsCritico(rndGolpe))
                {
                    Console.WriteLine("es critico 2 fase. +75% de daño con arma");
                    dañoRealizado = Convert.ToInt32((this.daño) * 1.75);
                }

                if (EsPifia(rndGolpe))
                {
                    Console.WriteLine("PIFIA 2 fase:  no puede inflingir daño");
                    dañoRealizado = 0;
                }

                this.daño = dañoRealizado;

                Console.WriteLine($"golpe {golpe}\nbloqueo:{bloqueo}\ndaño: {dañoRealizado}\nrnd golpe{rndGolpe}\nrnd bloqueo {rndBloqueo}\nthis daño: {this.daño}\n------------------------------");
            }
        }

        public bool EsPifia(int rnd)
        {
            bool retorno = false;
            if (rnd == 1)
            {
                retorno= true;
            }
            return retorno;
        }

        public bool EsCritico(int rnd)
        {
            bool retorno = false;
            if (rnd == 9)
            {
                retorno = true;
            }
            return retorno;
        }

        public bool AtacarPrimeraFase()
        {
            bool retorno = false;
            if (this.habilidadAtaque > 0)
            {
                retorno = true;
            }
            return retorno;

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

        public int Atacar(int rnd)
        {

            return rnd + this.ataque;
        }

        public int Esquivar(int agilidadDefensiva, int rnd)
        {
            return agilidadDefensiva + rnd;
        }

        public bool AtacarSegundaFase(int dañoRealizado)
        {
            bool retorno = false;
            if (dañoRealizado > 0)
            {
                retorno= true;
            }
            return retorno;
        }

        public int Golpear(int rnd)
        {
            return rnd + this.fuerza;
        }

        public int Bloquear(int resistenciaDefensor, int rnd)
        {
            return rnd + resistenciaDefensor;
        }

        public int rng()
        {
            return (Personaje.rnd.Next(1, 10));
        }

        public string MostrarMensaje(string nombreDefensor)
        {
            if (AtacarPrimeraFase())
            {
                if (AtacarSegundaFase(this.daño))
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
