using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio03
{
    class Program
    {
        static void Main(string[] args)
        {


            int i,j;
            int cont = 0;
            int numero;
            int modulo;

            Console.WriteLine("ingrese el numero que hasta donde quiere ver numeros primos");
            numero = int.Parse(Console.ReadLine());
            while (numero <= 0)
            {
                Console.WriteLine("el numero que ingreso esta mal, por favor ingrese de nuevo");
                numero = int.Parse(Console.ReadLine());
            }


            Console.Write("los numero primos son:");

            for (i = 0; i <= numero; i++)
            {

                for (j = 0; j <= i; j++)
                {
                    modulo = i % j;
                    if (modulo == 0) cont++;
                }

                if (cont <= 2) Console.Write(" " + i);


            }

            Console.ReadKey();
        }
    }
}
