using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entidadesClases6
{
    public class paleta
    {
        private tempera[] colores;
        private int cantidadMaximaColores;
 
        /**-----------------------------------------------------------------------------------------*////CONSTRUCTORES

        private paleta(int element)
        {
            
            this.colores = new tempera[element];
            //for (int i = 0; i < element; i++)
            //{
            //    this.colores[i] = new tempera();
            //}

            this.cantidadMaximaColores = element;

        }

        private paleta() : this(5) { }

        /**-------------------------------------------------------------------------------------------*/

        /**-----------------------------------------------------------------------------------------*////METODOS

        private int getIndexNull()
        {
            int element;

            for (element = 0; element < this.cantidadMaximaColores; element++)
            {
                if ((object)this.colores[element] == null) break;
            }



            return element;
        }

        private string show()
        {
            string cadena = "";
            int element;


            for (element = 0; element < this.cantidadMaximaColores; element++)
            {
                if ((object)this.colores[element] != null)
                    cadena += "tempera " + (element + 1) + "\n" + tempera.show(this.colores[element]) + "\n";
            }


            return cadena;
        }

        public static string show(paleta a)
        {
            return a.show();
        }

        /**-----------------------------------------------------------------------------------------*/

        /**-------------------------------------------------------------------------------------------*////SOBRECARGA DE OPERADORES
                                                                                                        
        public static implicit operator paleta(int a)
        {
            paleta objeto = new paleta(a);

            return objeto;
        }

        public static bool operator ==(paleta a, tempera b)
        {

            bool returnAux = false;
           
            if ((object)a == null || (object)b == null) return returnAux;

            foreach(int element in a.colores)
            {
                if (tempera.show(a.colores[element]) == tempera.show(b)) returnAux = true;
            }

            return returnAux;
        }

        public static bool operator !=(paleta a, tempera b)
        {
            return !(a == b);
        }

        public static paleta operator +(paleta a, tempera b)
        {
            int element;
            for (element = 0; element < a.cantidadMaximaColores; element++)
            {
                if (a.colores[element] == b) break;
            }

            if (element == a.cantidadMaximaColores) element = a.getIndexNull();

            a.colores[element] += b;


            return a;
        }

        public static paleta operator -(paleta a, tempera b)
        {
            if ((object)b == null) return a;
            int i;

            for (i = 0; i < a.cantidadMaximaColores; i++)
            {
                if(a.colores[i] == b) 
            }
        }

        /**-------------------------------------------------------------------------------------------*/
    }
}
