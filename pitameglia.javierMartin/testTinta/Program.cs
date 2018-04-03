using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using entidades;


namespace testTinta
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            tinta slash = new tinta(2);

            pluma birome = new pluma("pic", slash, 20);

            for (i = 0; i < 19; i++)
                birome += slash;
            

            Console.WriteLine(birome.show());
            
            Console.ReadKey();

        }
    }
}
