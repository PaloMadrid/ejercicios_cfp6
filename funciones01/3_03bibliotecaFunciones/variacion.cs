using System.ComponentModel.Design;

namespace C03bibliotecaFunciones
{
    public class variacion
    {
        //            La función debe recibir tres parámetros: 'valor'(numérico), 'porcentaje'(numérico) y 'esAumento'(booleano).
        //Si el parámetro 'esAumento' es verdadero, la función debe aumentar el 'valor' original aplicando el 'porcentaje' dado.
        //Si el parámetro 'esAumento' es falso, la función debe disminuir el 'valor' original aplicando el 'porcentaje' dado.
        //El resultado obtenido después de aplicar el porcentaje al 'valor' original debe ser retornado por la función.

        public static double Incrementar (int numero,int porcentaje, bool esAumento)
        {
            double variacion;

            variacion=(numero*porcentaje/ 100);
            
            if (esAumento)
            {
                return numero+variacion;
            }

            return numero-variacion;
        }
    }
}
