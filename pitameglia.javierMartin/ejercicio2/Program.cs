using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero;

            Console.WriteLine("ingrese un numero mayor a 0 que quiera elevar");
            numero = double.Parse(Console.ReadLine());

            while(numero <= 0)
            {
                Console.WriteLine("el numero que ingreso es incorrecto, porfavor ingrese de nuevo");
                numero = double.Parse(Console.ReadLine());

            }

            Console.WriteLine("el cuadrado de este numero es {0:#,###.00} y el cubo de este numero es {1:#,###.00}",Math.Pow(numero,2), Math.Pow(numero,3));


            Console.ReadKey();

        }
    }
}
