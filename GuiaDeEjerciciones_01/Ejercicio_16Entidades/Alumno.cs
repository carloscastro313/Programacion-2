using System;

namespace Ejercicio_16Entidades
{
    public class Alumno
    {
        private byte nota1;
        private byte nota2;
        private float notaFinal;

        public string nombre;
        public string apellido;
        public int legajo;

        public void CalcularFinal()
        {
            this.notaFinal = (float)((this.nota1 + this.nota2) / 2);
            if(this.notaFinal<4)
            {
                this.notaFinal = -1;
            }
        }
        public void Estudiar(byte a, byte b)
        {
            this.nota2 = b;
            this.nota1 = a;
        }
        public string mostrar()
        {
            string aux = "Nombre: " + this.nombre + "Apellido: " + this.apellido + "Nota Final: ";
            if(this.notaFinal!= -1)
            {
                aux += notaFinal;
            }else
            {
                aux += "Desaprobado";
            }

            return aux;
        }

    }
}
