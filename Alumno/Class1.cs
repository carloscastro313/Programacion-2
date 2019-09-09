using System;

namespace Alumno
{
    public class Class1
    {
        private byte nota1;
        private byte nota2;
        private float notaFinal;

        public string Apellido;
        public int legajo;
        public string nombre;


        public void CalcularFinal()
        {
            Random r= new Random();

            this.notaFinal = (float)((this.nota1 + this.nota2) / 2.0);

            if(this.notaFinal<4)
            {
                this.notaFinal = -1;
            }else if(this.notaFinal <= 4)
            {
               
                this.notaFinal = r.Next(1, 10);
            }
        }

        public void Estudiar(byte nota1Aux, byte nota2Aux)
        {
            this.nota1 = nota1Aux;
            this.nota2 = nota2Aux;

        }

        public string Mostrar()
        {
            string aux;

            if(this.notaFinal==-1)
            {
                aux = "Desaprobado";
            }
            else
            {
                aux= this.nombre + " |" + this.Apellido + " |" + this.legajo + " |" + this.notaFinal + "\n";
            }
            return aux;
        }

    }
}
