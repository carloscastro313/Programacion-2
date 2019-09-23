using System;

namespace Ejercicio_05Entidades
{
    public class validar
    {
        public static int min;
        public static int max;
        private static bool flagFirst = true;


        public static bool Validacion(int minAux, int maxAux, int aux)
        {
            bool flag = false;

            if (aux > -100 && aux < 100)
            {
                flag = true;

                if (flagFirst)
                {
                    min = aux;
                    max = aux;
                    flagFirst = false;
                } else if (min > aux)
                {
                    min = aux;
                }
                else if (max < aux)
                {
                    max = aux;
                }
            }

            return flag;
        }

        public static string mostrar()
        {
            return "maximo: " + validar.max + "\nminimo: " + validar.min;
        }
    }
}
