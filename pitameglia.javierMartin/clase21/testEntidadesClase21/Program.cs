using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using entidades;

namespace testEntidadesClase21
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Persona> personas = new List<Persona>();

            Persona persona = new Persona("12", "dsfsd,", 454);

            personas = persona.TraerTodos();

            

            Console.ReadKey();

        }
    }
}
