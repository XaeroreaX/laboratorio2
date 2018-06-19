using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Alumnos;
using Entidades.Externa;
using Entidades.Externa.Sellada;


namespace clase25
{
    class Program
    {
        static void Main(string[] args)
        {

            Persona person = new Persona("tincho", "pity", 24, Entidades.Alumnos.ESexo.Masculino);

            PersonaExternaSellada persona = new PersonaExternaSellada("Elphe", "ninfomana", 25, Entidades.Externa.Sellada.ESexo.Femenino);

            Console.WriteLine(persona.Apellido);

            

            Console.ReadKey();

        }
    }


    public static class Extensora
    {


        public static string ObtenerInfo(this Persona p)
        {
            string toString = "";

            toString = p.Nombre + "---" + p.Apellido + "---" + p.Edad + "---" + p.Sexo.ToString();

            return toString;
        }

        public static string ObtenerInfoPersonaExternaSellada(this PersonaExternaSellada p)
        {
            string toString;

            toString = p.Apellido;


            return toString;
        }


    }

    
}
