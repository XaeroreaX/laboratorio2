using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cosa;

namespace probarCosa
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime fecha = new DateTime(1993, 11, 2);
            
            

            cosa.cosa obj1 = new cosa.cosa(24 , "martin", fecha);

            

            obj1.show();

            


            

            Console.ReadKey();


        }
    }
}
