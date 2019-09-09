using System;

namespace Clase_05_Entidades
{
    public class Tinta
    {
        private ConsoleColor _color;
        private EltipoTinta _tipo;

        public Tinta()
        {
            this._color = ConsoleColor.Blue;
            this._tipo = EltipoTinta.Comun;
        }
        public Tinta(ConsoleColor color) : this()
        {
            this._color = color;
        }
        public Tinta(EltipoTinta tipo, ConsoleColor color) : this(color)
        {
            this._tipo = tipo;
        }

        private string Mostrar()
        {
            return "Tinta: " + this._tipo + "  color: " + this._color ;
        }

        public static string Mostrar(Tinta ver)
        {

            return ver.Mostrar();
        }

        public static bool operator ==(Tinta a, Tinta b)
        {

            if (!Object.Equals(a, null) && !Object.Equals(b, null))
            {
                return (a._tipo == b._tipo && a._color == b._color);
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(Tinta a, Tinta b)
        {
            if (!Object.Equals(a, null) && !Object.Equals(b, null))
            {
                return !(a == b);
            }
            else
            {
                return false;
            }
        }
        public static bool operator ==(Tinta a, ConsoleColor b)
        {

            if (!Object.Equals(a, null) && !Object.Equals(b, null))
            {
                return (a._color == b);
            }
            else
            {
                return false;
            }

            
        }
        public static bool operator !=(Tinta a, ConsoleColor b)
        {

            if (!Object.Equals(a, null) && !Object.Equals(b, null))
            {
                return !(a == b);
            }
            else
            {
                return false;
            }
        }

        public static explicit operator string(Tinta a)
        {
            
            return a.Mostrar();
        }
    }
    public class Pluma
    {
        private string _marca;
        private Tinta _tinta;
        private int _cantidad;

        public Pluma()
        {
            this._marca = "sin marca ";
            this._tinta = null;
            this._cantidad = -1;
        }
        public Pluma(Tinta auxTinta)
        {
            this._tinta = auxTinta;
        }
        public Pluma(Tinta auxTinta, string auxString) : this(auxTinta)
        {
            this._marca = auxString;
        }
        public Pluma(int auxInt, string auxString, Tinta auxTinta) : this(auxTinta,auxString)
        {
            this._cantidad = auxInt;
        }
        private string Mostrar()
        {
            return  Tinta.Mostrar(this._tinta)  + "   " + this._marca + "  cantidad: " + this._cantidad ;
        }

        public static string Mostrar(Pluma ver)
        {

            return ver.Mostrar();
        }

        public static implicit operator string(Pluma a)
        {

            return a.Mostrar();
        }

        public static bool operator ==(Pluma a, Tinta b)
        {
            if (!Object.Equals(a, null) && !Object.Equals(b, null))
            {
                return (a._tinta == b);
            }
            else
            {
                return false;
            }
            
        }
        public static bool operator !=(Pluma a, Tinta b)
        {
            if (!Object.Equals(a, null) && !Object.Equals(b, null))
            {
                return (a._tinta == b);
            }
            else
            {
                return false;
            }
        }
        public static Pluma operator +(Pluma a, Tinta b)
        {
            if(a!=null&&(a==b&&a._cantidad==100))
            {
                a._cantidad++;
            }
            return a;

        }
    }
}
