using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entidadesClases6
{
    public class tempera
    {
        private ConsoleColor color;
        private string marca;
        private int cantidad;

        /**----------------------------------------------------------------------------------------------*////CONSTRUCTORES

        public tempera(ConsoleColor a, string b, int c)
        {
            this.color = a;
            this.marca = b;
            this.cantidad = c;


        }


        public tempera() : this(ConsoleColor.Black, "sin asignar", 0) { }

        /**----------------------------------------------------------------------------------------------*/
        

        /**----------------------------------------------------------------------------------------------*////METODOS

        private string show()
        {
            return "color de tempera" + this.color + "\nmarca de la tempera:" +this.marca+ "\nla cantidad es:"+this.cantidad;
        }


        public static string show(tempera b)
        {
            if ((object)b == null) return "";
            return b.show();
        }

        /**----------------------------------------------------------------------------------------------*/
       


        /**----------------------------------------------------------------------------------------------*////SOBRECARGA DE OPERADORES

        public static bool operator ==(tempera a , tempera b)
        {
            if ((object)a == null || (object)b == null) return false;

            if(a.color == b.color && a.marca == b.marca) return true;

            return false;
        }

        public static bool operator !=(tempera a , tempera b)
         {
             return !(a == b);
         }

        public static implicit operator int(tempera a)
        {

            if ((object)a == null) return 0;
            return a.cantidad;
        }

        public static explicit operator string(tempera a)
        {
            return a.marca;
        }

        public static tempera operator +(tempera a, int b)
        {
            a.cantidad += b;
            return a;
        }

        public static tempera operator +(tempera a, tempera b)
        {
            if ((object)a == null) a = b;
            if (a.color == b.color && a.marca == b.marca) a.cantidad += b.cantidad;

            return a;
        }

        public static tempera operator -(tempera a, tempera b)
        {
            if (b == null) return a;

            if (a == b) a.cantidad -= b.cantidad;

            if (a.cantidad < 0) return null;

            return a;

        }

        /**----------------------------------------------------------------------------------------------*/
    }
}
