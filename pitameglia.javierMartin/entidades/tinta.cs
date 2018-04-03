using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entidades
{
    public class tinta
    {

        private ConsoleColor color;

        private ETipoTinta tipoTinta;
 

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        //Constructores


        public tinta()
        {
            this.color = ConsoleColor.Yellow;

            //Console.BackgroundColor = this.color;

            this.tipoTinta = ETipoTinta.comun;
            
        }

        public tinta(int n) : this()
        {
            if (n == 1) this.tipoTinta = ETipoTinta.china;

            if (n == 2) this.tipoTinta = ETipoTinta.ConBrillito;
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////////////////////////////////
        //metodos

        private string mostrar()
        {
            
            return this.color+ "-"+this.tipoTinta ;
        }

        public static string mostrar(tinta t)
        {
            return t.mostrar();
        }


        ///////////////////////////////////////////////////////////////////////////////////////////////////


        ///////////////////////////////////////////////////////////////////////////////////////////////////
        //sobrecarga de operadores


        public static bool operator ==(tinta a, tinta b)
        {
            if (a.color == b.color)
            {
                if (a.tipoTinta == b.tipoTinta) return true;
            }

            return false;
        }

        public static bool operator !=(tinta a, tinta b)
        {
            return !(a == b);
        }
        ///////////////////////////////////////////////////////////////////////////////////////////////////

    }
}
