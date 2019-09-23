using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio_16Entidades;
namespace Ejercicio_16
{
    class Program
    {
        static void Main(string[] args)
        {
            byte nota1;
            byte nota2;

            Alumno alumno1= new Alumno();
            alumno1.apellido = "Castro";
            alumno1.nombre = "lucia";
            alumno1.legajo = 203421;

            Console.WriteLine("Ingresar Nota: ");
            nota1 = byte.Parse(Console.ReadLine());
            Console.WriteLine("Ingresar Nota: ");
            nota2 = byte.Parse(Console.ReadLine());

            alumno1.Estudiar(nota1, nota2);
            alumno1.CalcularFinal();

            Console.WriteLine(alumno1.mostrar());

            Alumno alumno2 = new Alumno();
            alumno1.apellido = "Castro";
            alumno1.nombre = "Marcos";
            alumno1.legajo = 255341;

            Console.WriteLine("Ingresar Nota: ");
            nota1 = byte.Parse(Console.ReadLine());
            Console.WriteLine("Ingresar Nota: ");
            nota2 = byte.Parse(Console.ReadLine());

            alumno1.Estudiar(nota1, nota2);
            alumno1.CalcularFinal();

            Console.WriteLine(alumno1.mostrar());

        }
    }
}
