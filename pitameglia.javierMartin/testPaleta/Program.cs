using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using entidadesClases6;


namespace testPaleta
{
    class Program
    {
        static void Main(string[] args)
        {

            paleta miPaleta;

            miPaleta = 4;

            tempera miTempera = new tempera(ConsoleColor.Cyan, "pic", 2);

            miPaleta += miTempera;

            Console.Write(paleta.show(miPaleta));

            Console.ReadKey();

        }
    }
}
