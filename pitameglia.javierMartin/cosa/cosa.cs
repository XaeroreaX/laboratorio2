using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cosa
{
    public class cosa
    {
        private int entero;
        private string cadena;
        private DateTime fecha;

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///constructores sobrecargados

        public cosa(int a, string b, DateTime c)
        {
            this.entero = a;
            this.cadena = b;
            this.fecha = c;
        }

        public cosa() : this(10, "NO ME ASIGNASTE ;)", DateTime.Now) { }

        public cosa(int a, string b) : this(a)
        {
           
            
            this.cadena = b;
            this.fecha = DateTime.Now;
        }

        public cosa(int a) : this()
        {
            this.entero = a;
            
        }


        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        

        public void show()
        {

            Console.WriteLine("el nombre es:"+this.cadena+ "\nla edad es:"+ this.entero+"\nla fecha de nacimiento es:{0:dd/MM/yyyy}",this.fecha);
            
        }



    }
}
