using System;

namespace clase_09Entidades
{
    public class Capitulo
    {
        private int numero;
        private string titulo;
        private int paginas;
        private static Random generadorDeNumero;
        private static Random generadorDePaginas;

        public int Numero
        {
            get { return this.numero; }
            set { this.numero = value; }
        }
        public string Titulo
        {
            get { return this.titulo; }
            set { this.titulo = value; }
        }
        public int Paginas
        {
            get { return this.paginas; }
            set { this.paginas = value; }
        }

        static Capitulo()
        {
            /*generadorDeNumero.Next(1, 65);
            generadorDePaginas.Next(15, 233);*/
            Capitulo.generadorDeNumero = new Random();
            Capitulo.generadorDePaginas = new Random();
        }
        public Capitulo()
        {

        }
        private Capitulo(int numeroAux, string tituloAux, int paginaAux)
        {
            this.titulo = tituloAux;
            this.paginas = paginaAux;
            this.numero = numeroAux;
        }

        public static implicit operator Capitulo(string capitulo)
        {
            Capitulo aux= new Capitulo(Capitulo.generadorDeNumero.Next(1,65),capitulo,Capitulo.generadorDePaginas.Next(15, 233));

            return aux;
        }

        public static bool operator ==(Capitulo a, Capitulo b)
        {
            bool aux=false;
            if(a==b)
            {
                aux = true;
            }
            return aux;
        }

        public static bool operator !=(Capitulo a, Capitulo b)
        {
            return !(a == b);
        }
    }
}
