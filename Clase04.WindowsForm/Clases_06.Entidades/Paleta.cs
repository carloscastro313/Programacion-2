using System;
using System.Collections.Generic;
using System.Text;

namespace Clases_06.Entidades
{
        public class Paleta
        {
            private Tempera[] colores;
            private int cantidadMaximaColores;


            private Paleta() : this(5) { }

            private Paleta(int auxCantidad)
            {
                this.colores = new Tempera[auxCantidad];
                this.cantidadMaximaColores = auxCantidad;
            }
            public static implicit operator Paleta(int aux)
            {
                return new Paleta(aux);
            }

            private string Mostrar()
            {
                string mensaje = "";

                for (int i = 0; i < this.cantidadMaximaColores; i++)
                {
                    mensaje = mensaje + this.colores[i] + "\n";

                }
                mensaje = mensaje + this.cantidadMaximaColores;

                return mensaje;
            }

            public static explicit operator string(Paleta ver)
            {
                return ver.Mostrar();
            }

            public static bool operator ==(Paleta a, Tempera b)
            {
                bool aux = false;

                if (!Object.Equals(a, null) && !Object.Equals(b, null))
                {
                    for (int i = 0; i < a.cantidadMaximaColores; i++)
                    {
                        if (a.colores[i] == b)
                        {
                            aux = true;

                        }
                    }
                }
                return aux;
            }
            public static bool operator !=(Paleta a, Tempera b)
            {

                return !(a == b);
            }

            public static Paleta operator +(Paleta a, Tempera b)
            {
                int index = a.obtenerLugarLibre();

                if (a != b && index != -1)
                {
                    a.colores[index] = b;
                }
                else if (a == b)
                {
                    index = Array.IndexOf(a.colores, a.cantidadMaximaColores);
                    a.colores[index] = a.colores[index] + b;
                }
                return a;
            }

            private int obtenerLugarLibre()
            {
                int indice = -1;

                for (int i = 0; i < this.cantidadMaximaColores; i++)
                {
                    if (this.colores[i] == null)
                    {
                        indice = i;
                        break;
                    }
                }


                return indice;
            }

        public static int operator |(Paleta a, Tempera b)
        {
            if(a == b)
            {


            }
        }
    }
}
