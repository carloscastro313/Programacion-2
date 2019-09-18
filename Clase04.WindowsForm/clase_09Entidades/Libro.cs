using System;
using System.Collections.Generic;
using System.Text;

namespace clase_09Entidades
{
    public class Libro
    {
        private string titulo;
        private string autor;
        private List<Capitulo> capitulos;

        public string Titulo
        {
            get { return this.titulo; }
            set { this.titulo = value; }
        }
        public string Autor
        {
            get { return this.autor; }
            set { this.autor = value; }
        }

        public int CantidadDePaginas
        {
            get {
                int paginas=0;
                foreach (Capitulo a in this.capitulos )
                {
                    paginas += a.Paginas;
                }
                return paginas;
            }
        }

        public int CantidadDeCapitulos
        {
            get { return capitulos.Count; }
        }

        public Capitulo this[int i]
        {
            get {
                if (i>=0 || i< this.capitulos.Count)
                {
                    return this.capitulos[i];
                }else
                {
                    return null;
                }
            }

            set
            {
                if (i >= this.capitulos.Count)
                {
                    this.capitulos.Add(value);
                } else if(i<0)
                {
                }else
                {
                    this.capitulos[i] = value;
                }
            }
        }

        public Libro(string autorAux,string tituloAux)
        {
            this.autor = autorAux;
            this.titulo = tituloAux;
            this.capitulos = new List<Capitulo>();
        }

    }
}
