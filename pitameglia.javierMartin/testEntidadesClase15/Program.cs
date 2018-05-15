using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mate;

namespace testEntidadesClase15
{
    class Program
    {
        static void Main(string[] args)
        {
            string message;

            int number;

            Numero obj;

            obj = new Numero();

            message = Console.ReadLine();

            if (obj.Parse(message: message, number: out number) == true)
            {
                Console.WriteLine(number);

            }

            Console.ReadKey();

        }
    }
}
