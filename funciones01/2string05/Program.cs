namespace string05
{
    internal class mayusculas
    {
        static void Main(string[] args)
        {
            //            5.Pedir el ingreso de nombre y apellido separado por un espacio, guardar cada
            //            dato en una variable diferente y asegurarse de que respete el formato de la
            //            primera letra en mayúscula y el resto en minúsculas, mostrar el apellido
            //            y el nombre por separado.
            //ej: juAN ROBles(primero nombre luego apelido)
            //imprimir:
            //        Apellido: Robles.
            //        Nombre: Juan.

            string apeNom;
            string nombre="";
            string apellido="";


            Console.WriteLine("ingrese su nombre y apellido separado por un espacio");
            apeNom = Console.ReadLine();
                        
            string[] separacion = apeNom.Split(" ");

            char[] vectorNombre = separacion[0].ToLower().ToCharArray();
            char[] vectorApellido = separacion[1].ToLower().ToCharArray();

            vectorNombre[0] = char.ToUpper(vectorNombre[0]);
            vectorApellido[0] = char.ToUpper(vectorApellido[0]);

            foreach (char letra in vectorNombre) 
            {
                
                nombre += letra;
            }

            foreach (char letra in vectorApellido)
            {
                apellido+= letra;
            }

            Console.WriteLine($"Nombre: {nombre}\nApellido: {apellido}");


            //for (int i = 0; i < letras.Length; i++)
            //{
            //    if (letras[i] == ' ')
            //    {
            //        finNombre = i;
            //        inicioApellido = i + 1;
            //    }
            //}

            //char[] nombre = new char[finNombre];
            //char[] apellido = new char[letras.Length];



            //for (int i = 0; i < finNombre; i++)
            //{
            //    if (i == 0)
            //    {
            //        nombre[i] = char.ToUpper(apeNom[i]);
            //    }
            //    else
            //    {
            //        nombre[i] = apeNom[i];
            //    }
            //}

            //for (int i = inicioApellido; i < letras.Length; i++)
            //{
            //    if (i == inicioApellido)
            //    {
            //        apellido[i] = char.ToUpper(apeNom[i]);
            //    }
            //    else
            //    {
            //        apellido[i] = apeNom[i];
            //    }
            //}

            //Console.Write($"nombre: ");
            //foreach (char c in nombre)
            //{
            //    Console.Write(c);
            //}

            //Console.Write($"\napellido: ");
            //foreach (char c in apellido)
            //{
            //    Console.Write(c);
            //}
        }
    }
}
