using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_vehiculos
{
    public class Auto: Vehiculo
    {
        int numeroPuertas;
        double capacidadBaul;

        public Auto(string marca,string modelo,int numeroPuertas, double capacidadBaul)
            :base(marca, modelo)
        {
            this.numeroPuertas = numeroPuertas;
            this.capacidadBaul = capacidadBaul;
        }

        public override string Conducir()
        {
            return $"{base.Conducir()} un auto";
        }

        public string AbrirBaul()
        {
            return "El maletero del coche se ha abierto";
        }

        public override string MostrarInfo()
        {
            return $"{base.MostrarInfo()} - Cantidad de puertas: {this.numeroPuertas} - Capacidad de baul: {this.capacidadBaul}";
        }
    }
}
