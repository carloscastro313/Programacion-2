using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaDeEjerciciones_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int minimo=0;
            int maximo=0;
            float suma = 0;
            float promedio = 0;

            for(int i=0;i<5;i++)
            {
                Console.Write("Ingresar numero: ");
                numero = int.Parse(Console.ReadLine());
                if(i==0)
                {
                    minimo = numero;
                    maximo = numero;
                }
                else if(numero> maximo)
                {
                    maximo = numero;
                }
                else if (numero < minimo)
                {
                    minimo = numero;
                }
                suma = suma + numero;
            }

            promedio = (float)(suma / 5);

            Console.WriteLine("Promedio: {0}", promedio);
            Console.WriteLine("Minimo: {0}", minimo);
            Console.WriteLine("Maximo: {0}", maximo);
            Console.ReadLine();
        }
    }
}
