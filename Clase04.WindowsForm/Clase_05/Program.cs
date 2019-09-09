using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase_05_Entidades;

namespace Clase_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Tinta a = new Tinta();
            string b = (string)a;

            Pluma c = new Pluma(3,"hola",a);

            Console.WriteLine(Tinta.Mostrar(a));
            Console.WriteLine(Pluma.Mostrar(c));
            Console.ReadLine();
        }
    }
}
