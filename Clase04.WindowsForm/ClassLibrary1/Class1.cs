using System;

namespace Clase4
{
    public class Cosa
    {
        public int numero;
        public string cadena;
        public DateTime fecha;

        public void EstablecerValor(int aux)
        {
            this.numero = aux;
        }
        public void EstablecerValor(string aux)
        {
            this.cadena = aux;
        }
        public void EstablecerValor(DateTime aux)
        {
            this.fecha = aux;
        }

        public Cosa()
        {
            this.cadena = "Nulo";
            this.numero = -1;
            this.fecha = DateTime.Now;
        }
        public Cosa(int auxInt)
        {
            this.numero = auxInt;

        }
        public Cosa(string auxString, int auxInt): this(auxInt)
        {
            this.cadena = auxString;

        }
        public Cosa(string auxString, int auxInt, DateTime auxFecha):this(auxString,auxInt)
        {

            this.fecha = auxFecha;
        }

        public string mostrar()
        {
            return this.numero + "-" + this.cadena + " " + this.fecha + " \n";
        }
    }
}
