using System;

namespace Clase_10Entidades
{
    public class Alumno
    {
        protected string apelldio;
        protected ETipoExamen examen;
        protected int legajo;
        protected string nombre;

        public string Apellido
        {
            get { return this.apelldio; }
        }
        public ETipoExamen Examen
        {
            get { return this.examen; }
        }
        public int Legajo
        {
            get { return this.legajo; }
        }
        public string Nombre
        {
            get { return this.nombre; }
        }

        public Alumno(string nombreAux, string apellidoAux, int legajo, ETipoExamen examenAux)
        {
            this.nombre = nombreAux;
            this.apelldio = apellidoAux;
            this.legajo = legajo;
            this.examen = examenAux;

        }
        public static string Mostrar(Alumno a)
        {
            return "Nombre: " + a.nombre + "\nApelldio: " + a.apelldio + "\nLegajo: " + a.legajo + "\nExamen: " + a.examen;
        }
        public static bool operator ==(Alumno a, Alumno b)
        {
            bool aux = false;
            if(a.legajo==b.legajo)
            {
                aux = true;
            }

            return aux;
        }
        public static bool operator !=(Alumno a, Alumno b)
        {
            return !(a==b);
        }
        public static int OrdenarPorApellidoAsc(Alumno a, Alumno b)
        {
            return string.Compare(a.apelldio, b.apelldio);
        }
        public static int OrdenarPorApellidoDesc(Alumno a, Alumno b)
        {
            return OrdenarPorApellidoAsc(b, a);
        }
        public static int OrdenarPorLegajoAsc(Alumno a, Alumno b)
        {
            int retorno=0;

            if(a.legajo>b.legajo)
            {
                retorno = 1;
            }else if(a.legajo > b.legajo)
            {
                retorno = -1;
            }

            return retorno;
        }
        public static int OrdenarPorLegajoDesc(Alumno a, Alumno b)
        {

            return OrdenarPorLegajoAsc(b,a);
        }
    }
}
