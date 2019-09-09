using System;

namespace Objeto_01
{
    public class Persona
    {
        public string nombre;
        public string apellidio;
        public int dni;


        public string Mostrar()
        {

            return this.nombre + this.apellidio + this.dni + "\n";
        }

        public Persona(string nombreAux, string apelledioAux, int dniAux)
        {
            this.nombre = nombreAux;
            this.apellidio = apelledioAux;
            this.dni = dniAux;
        }



    }
}
