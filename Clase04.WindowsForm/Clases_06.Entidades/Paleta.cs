using System;
using System.Collections.Generic;
using System.Text;

namespace Clases_06.Entidades
{
    public class Paleta
    {
            private Tempera[] colores;
            private int cantidadMaximaColores;
            
            public Tempera this[int index]
            {
                get { return this.colores[index]; }

                set { this.colores[index] = value; }
            }
            public int indexMax
            {
                get { return this.cantidadMaximaColores; }
            }

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
                int i = 0;

                foreach(Tempera aux in this.colores)
                {
                    if (aux == null)
                    {
                        return i;                       
                    }
                i++;
                }


                return -1;
            }

        public static int operator |(Paleta a, Tempera b)
        {
            return Array.IndexOf(a.colores, b);   
        }
    }
}
