using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using entidades;

namespace testEntidadesClase21
{
    class Program
    {
        static void Main(string[] args)
        {

            DataTable personita = Persona.TraerTodosTabla();



            foreach (DataRow element in personita.Rows)
            {

                Console.WriteLine(element.ToString());

            }

            
            Console.ReadKey();

        }
    }
}
