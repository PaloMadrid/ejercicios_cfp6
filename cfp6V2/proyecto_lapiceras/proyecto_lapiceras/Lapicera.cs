using mis_clases;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace Mis_clases
{
    public class Lapicera
    {
        //Crear la clase lapicera, esta debe tener los atributos: color, precio, marca, nivelDeTinta.
        //crear propiedades todas las propiedad de lectura.
        //        Un constructor que inicialice color, precio, marca.
        //        Todas las lapiceras se crean con el nivel de tinta al 100.

        Color color;
        int precio;
        string marca;
        int nivelDeTinta;

        public Lapicera(Color color, int precio, string marca)
        {
            this.color = color;
            this.precio = precio;
            this.marca = marca;
            this.nivelDeTinta = 100;
        }

        public string Marca { get => marca; }
        public Color Color { get => color; }
        public int Precio { get => precio; }
        
        public int NivelDeTinta { get => nivelDeTinta; set => nivelDeTinta = value; }

        public static List<Lapicera> ListaDeLapiceras()
        {
            return new List<Lapicera>
            {
                new Lapicera(Color.Red,50,"Bic"),
                new Lapicera(Color.Black,50,"Bic"),
                new Lapicera(Color.Purple,50,"Filgo"),
                new Lapicera(Color.Green,50,"Filgo"),
                new Lapicera(Color.Blue,50,"Faber Castle")
            };
        }

        //Sobreescribir el metodo ToString() para que muestre todos sus valores.
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Color: {this.color} - Marca: {this.marca} - Precio: ${this.precio} - Tinta: {this.nivelDeTinta}");


            return sb.ToString();
        }

        //Crear el metodo publicv bool Escribir(int cantLetras), donde cada letra consume un nivel de tinta,
        ///el metodo debe verificar si tiene tinta
        //para escribir la cantidad de letas solicitadas por parametro en informara con un true o false si le alcanzo.

        public bool Escribir(string textoIngresado)
        {
            bool retorno=true;
            int cantLetras=Funcion.ContarCaracteres(textoIngresado);
            int tintaActual= this.nivelDeTinta;
            tintaActual -= cantLetras;

            if (tintaActual <= 0)
            {
                retorno=false;
            }            

            return retorno;
        }


        //El metodo public void Recargar() que colocara el nivel a 100 nuevamente.

        public void Recargar()
        {
            this.nivelDeTinta = 100;
        }

        public static List<Color> ListaDeColores()
        {
            List<Color> colores = new List<Color>()
            {
                Color.Blue,
                Color.Red,
                Color.Black,
                Color.Purple,
                Color.Green
                
            };

            return colores;
        }

    }
}
