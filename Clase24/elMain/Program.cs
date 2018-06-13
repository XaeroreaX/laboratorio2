using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Empleado;

namespace elMain
{
    class Program
    {
        static void Main(string[] args)
        {

            Empleado.Empleado elEmpleado = new Empleado.Empleado("tincho", "pity", 37948093);

            

            try
            {
                elEmpleado.Sueldo = 10000000;

            }

            catch (SueldoNegativoException e)
            {

                Console.WriteLine(e.ToString());

            }


            Console.ReadKey();

        }
    }



}
