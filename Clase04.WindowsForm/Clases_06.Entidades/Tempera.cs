using System;

namespace Clases_06.Entidades
{
    public class Tempera
    {
        private ConsoleColor color;
        private string marca;
        private int cantidad;

        public Tempera()
        {
            this.color = ConsoleColor.Blue;
            this.marca = "Sin valor";
            this.cantidad = -1;
        }
        public Tempera(int valor, string cadena, ConsoleColor colorAux) : this(cadena, colorAux)
        {
            this.cantidad = valor;
        }
        public Tempera(string cadena, ConsoleColor colorAux) : this(colorAux)
        {
            this.marca = cadena;
        }
        public Tempera(ConsoleColor colorAux)
        {
            this.color = colorAux;
        }

        private string Mostrar()
        {
            return "Color " + this.color + "| Cadena: " + this.marca + "|Cantidad: " + this.cantidad;
                
        }

        public static implicit operator string (Tempera ver)
        {
            return ver.Mostrar();
        }

        
        public static bool operator ==(Tempera a, Tempera b)
        {
            bool aux=false;

            if (!Object.Equals(a, null) && !Object.Equals(b, null))
            {
                if (a.color == b.color && a.marca == b.marca)
                {
                    aux = true;
                    
                }

            }
            return aux;
        }
        public static bool operator !=(Tempera a, Tempera b)
        {

            return !(a == b);

            
        }

        public static Tempera operator +(Tempera a, int cantidad)
        {
            a.cantidad = a.cantidad + cantidad;
            return a;
        }

        public static Tempera operator +(Tempera a, Tempera b)
        {
            if(a==b)
            {
                a.cantidad = a.cantidad + b.cantidad;
            }
            return a;
        }
    }
    
}
