using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numero= new int[5];
            int[] cuadrado = new int[5];
            int[] cubo = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Ingresar numero: ");
                numero[i] = int.Parse(Console.ReadLine());

                while (numero[i]<0)
                {
                    Console.Write("Reingresar numero: ");
                    numero[i] = int.Parse(Console.ReadLine());

                }
                cuadrado[i] = Convert.ToInt32(Math.Pow(numero[i], 2));
                cubo[i] = Convert.ToInt32(Math.Pow(numero[i], 3));
            }

            foreach(int aux in cuadrado )
            {
                Console.WriteLine(aux);
            }
            foreach (int aux in cubo)
            {
                Console.WriteLine(aux);
            }
            Console.ReadLine();
        }
    }
}
