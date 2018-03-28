using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using geometria;

namespace pruebaGeometria
{
    class Program
    {
        static void Main(string[] args)
        {
            //int x, y;
            punto v1 = new punto(3,5);
            punto v3 = new punto(10,10);

            
            rectangulo miRectangulo = new rectangulo(v1, v3);

            Console.WriteLine("el perimetro es:"+miRectangulo.Perimetro());
            Console.WriteLine("el area es:" + miRectangulo.Area());

            Console.ReadKey();

        }
    }
}
