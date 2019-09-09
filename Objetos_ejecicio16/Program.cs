using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alumno;

namespace Objetos_ejecicio16
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 alumnoUno = new Class1();
            byte aux1;
            byte aux2;

            Console.Write("Ingrese nombre: ");
            alumnoUno.nombre = Console.ReadLine();

            Console.Write("Ingrese Apellido: ");
            alumnoUno.Apellido = Console.ReadLine();

            Console.Write("Ingrese legajo: ");
            alumnoUno.legajo = int.Parse(Console.ReadLine());

            Console.Write("Ingrese nota 1: ");
            aux1 = byte.Parse(Console.ReadLine());

            Console.Write("Ingrese nota 2: ");
            aux2 = byte.Parse(Console.ReadLine());

            alumnoUno.Estudiar(aux1, aux2);
            alumnoUno.CalcularFinal();

            Console.Write(alumnoUno.Mostrar());
            Console.ReadLine();

        }
    }
}
