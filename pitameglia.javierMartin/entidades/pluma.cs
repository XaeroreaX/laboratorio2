using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entidades
{
    public class pluma
    {
        private string marcar;
        private tinta tinta;
        private int cantidad;

        /////////////////////////////////////////////////////////////////////////////////////////////
        //constructores

        public pluma()
        {
            this.marcar = "sin marcar";
            this.tinta = null;
            this.cantidad = 0;
        }

        public pluma(string m) : this()
        {
            this.marcar = m;
        }

        public pluma(tinta m) : this()
        {
            this.tinta = m;
        }

        public pluma(int m): this()
        {
            this.cantidad = m;
        }

        public pluma(string n, tinta m): this()
        {
            this.marcar = n;
            this.tinta = m;
        }

        public pluma(string n, tinta m, int b)
        {
            this.marcar = n;
            this.tinta = m;
            this.cantidad = b;
        }


        /////////////////////////////////////////////////////////////////////////////////////////////


        public string show()
        {
            return "la marca:" + this.marcar + "\nla tinta" + tinta.mostrar(this.tinta) + "\nla cantidad:" + this.cantidad;
        }

        /////////////////////////////////////////////////////////////////////////////////////////////
        //sobrecarga de operadores

        public static pluma operator +(pluma A, tinta B)
        {
            if(A.cantidad != 100)
                if (A == B) A.cantidad++;

            return A;

        }

        public static pluma operator -(pluma A, tinta B)
        {

            if(A.cantidad != 0)
                if (A == B) A.cantidad--;

            return A;

        }

        public static implicit operator string(pluma d)
        {
            return d.marcar;
        }

        public static implicit operator tinta(pluma d)
        {
            return d.tinta;
        }

        public static implicit operator int(pluma d)
        {
            return d.cantidad;
        }

        public static bool operator ==(pluma A, tinta B)
        {
            return (A.tinta == B);
        }

        public static bool operator !=(pluma A, tinta B)
        {
            return !(A.tinta == B);
        }

        public static bool operator ==(tinta A, pluma B)
        {
            return (A == B.tinta);
        }

        public static bool operator !=(tinta A, pluma B)
        {
            return !(A == B.tinta);
        }

        /////////////////////////////////////////////////////////////////////////////////////////////
        

    }

    
}
