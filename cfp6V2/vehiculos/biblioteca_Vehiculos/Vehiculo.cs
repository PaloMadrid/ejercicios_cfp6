namespace biblioteca_Vehiculos
{
    public class Vehiculo
    {
        protected string marca;
        protected string modelo;

        public Vehiculo(string marca, string modelo)
        {
            this.marca = marca;
            this.modelo = modelo;
        }

        public string Conducir()
        {
            return "estoy conduciendo";
        }

        public string MostrarInfo()
        {
            return $"Marca: {marca} - Modelo: {modelo}";
        }
    }
}
