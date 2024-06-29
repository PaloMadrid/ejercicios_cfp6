using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libreriaVehiculos
{
    internal class Auto : Vehiculo
    {
        int numeroPuertas;
        double capacidadMaletero;

        public Auto(int numeroPuertas, double capacidadMaletero)
            : base(marca, modelo)
        {
            this.numeroPuertas = numeroPuertas;
            this.capacidadMaletero = capacidadMaletero;
        }


        public string Conducir()
        {
            return "Estoy conduciendo un coche";
        }

        public string AbrirMaletero()
        {
            return "el maletero de ha abierto";
        }
    }
}
