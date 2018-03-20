using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = false;
            int i = 0;
            int max = 0;
            int min = 0;
            double promedio;
            int num1;
            //int num2;
            int acumulador = 0;


            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("ingrese el numero:");
                num1 = int.Parse(Console.ReadLine());
                /*
                Console.WriteLine("ingrese el numero 2:");
                num2 = int.Parse(Console.ReadLine());*/

                if (flag == false || max < num1)
                {
                    max = num1;
                }


                if (flag == false || min > num1)
                {
                    min = num1;
                    flag = true;
                }

                acumulador += num1;


            }


            promedio = (double) acumulador/i;


            Console.WriteLine("promedio {0:#,###.00}",promedio);
            Console.WriteLine("max"+max);
            Console.WriteLine("min"+min);

            Console.ReadKey();
        }
    }
}
