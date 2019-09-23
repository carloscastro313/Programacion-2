using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio_05Entidades;

namespace Ejercicio_04
{
    class Program
    {
        static void Main(string[] args)
        {
            int ingresar;

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Ingresar numero: ");
                ingresar = int.Parse(Console.ReadLine());
                while(validar.Validacion(validar.min, validar.max,ingresar)!=true)
                {
                    Console.Write("Reingresar numero: ");
                    ingresar = int.Parse(Console.ReadLine());

                }

            }

            Console.Write(validar.mostrar());
            Console.ReadLine();
        }
    }
}
