using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Objeto_01;

namespace Clase_03
{
    class Program
    {
        static void Main(string[] args)
        {

            Persona personaUno = new Persona("carlos ", " castro ", 42313959);


            Console.Write(personaUno.Mostrar());

            Persona personaDos = new Persona("Lucia ", "castro ", 38944482);

            Console.Write(personaDos.Mostrar());

            Persona personaTres;

            personaTres = personaUno;

            Console.Write(personaTres.Mostrar());

            Console.ReadLine();

        }
    }
}
