using System;
using System.Collections.Generic;
using System.Text;

namespace Clase_10Entidades
{
    public class Catedra
    {
        List<Alumno> alumnos;

        public List<Alumno> Alumnos
        {
            get { return this.alumnos; }
        }
        
        public Catedra()
        {
            this.alumnos = new List<Alumno>();
        }
           
        public static bool operator ==(Catedra c, Alumno a)
        {
            int i;
            bool flag = false;
            for (i = 0; i < c.alumnos.Count; i++)
            {
                if (c.alumnos[i] == a)
                {
                    flag = true;
                }
            }

            return flag;
        }

        public static bool operator !=(Catedra c, Alumno a)
        {
            return !(c == a);
        }

        public static bool operator +(Catedra c, Alumno a)
        {
            bool flag=true;
            if(c==a)
            {
                flag = false;
            }else
            {
                c.alumnos[c.alumnos.Count] = a;
            }

            return flag;
        }
        public static int operator |(Catedra c, Alumno a)
        {
            int indice = -1;

            for (int i = 0; i < c.alumnos.Count; i++)
            {
                if (c.alumnos[i] == a)
                {
                    indice = i;
                }
            }

            return indice;
        }

        public static bool operator -(Catedra c, Alumno a)
        {
            bool flag = false;
            if (c == a)
            {
                flag = true;
                c.alumnos.Remove(a);
            }

            return flag;
        }
    }
}
