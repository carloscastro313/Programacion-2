using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numero = new int[5];
            int[] primo = new int[5];
            int contador=0;

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Ingresar numero: ");
                numero[i] = int.Parse(Console.ReadLine());

                if(numero[i] == 3|| numero[i] == 2)
                {
                    primo[contador] = numero[i];
                    contador++;
                }else if(numero[i]%3 != 0 && numero[i] % 2 != 0)
                {
                    primo[contador] = numero[i];
                    contador++; 
                }
            }

            for (int i = 0; i < contador; i++)
            {

                Console.WriteLine(primo[i]);

            }
            Console.ReadLine();
        }
    }
}
