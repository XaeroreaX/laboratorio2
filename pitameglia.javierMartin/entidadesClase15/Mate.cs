using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mate
{
    public class Numero
    {

        #region Fields


        protected int _numero;


        #endregion

        

        #region Propeties

        public int Number { get { return this._numero; } }

        #endregion

        #region Methods

        public bool Parse(string message, out int number)
        {
            bool returnAux = true;

            try
            {
                number = Int32.Parse(message);
            }

            catch(StackOverflowException miEx)
            {
                number = 0;
                returnAux = false;

                Console.WriteLine(miEx.Message);
            }

            catch (FormatException miEx)
            {
                number = 0;
                returnAux = false;

                Console.WriteLine(miEx.Message);
            }


            catch (Exception miEx)
            {
                number = 0;
                returnAux = false;

                Console.WriteLine(miEx.Message);
            }

            return returnAux;
        }

        #region Constructor

        public Numero(int number)
        {

            this._numero = number;

        }

        public Numero() : this(1) { }

        #endregion

        #endregion

        #region Operators

        public static int operator +(Numero n1, Numero n2)
        {

            int returnAux = 0;

            try
            {

                returnAux = n1._numero + n2._numero;

            }


            catch (NullReferenceException miEx)
            {

                Console.WriteLine(miEx.Message);
                returnAux = 0;

            }

            catch (StackOverflowException miEx)
            {

                Console.WriteLine(miEx.Message);
                returnAux = 0;
            }

            return returnAux;
        }

        public static int operator -(Numero n1, Numero n2)
        {
            int returnAux = 0;

            try
            {
                returnAux = n1._numero - n2._numero;

            }

            #region Catch

            catch (StackOverflowException miEx)
            {

                returnAux = 0;
                Console.WriteLine(miEx.Message);

            }

            catch (NullReferenceException miEx)
            {

                returnAux = 0;
                Console.WriteLine(miEx.Message);

            }

            catch (Exception miEx)
            {

                returnAux = 0;
                Console.WriteLine(miEx.Message);

            }

            #endregion

            return returnAux;
        }


        public static int operator *(Numero n1, Numero n2)
        {
            int returnAux = 0;


            return returnAux;
        }


        public static double operator /(Numero n1, Numero n2)
        {
            double returnAux = 0;

            return returnAux;
        }

        #endregion



    }


    public enum ETipoNumero { Par, Impar, Positivo, Negativo, Cero}

    public class ColectoraDeNumeros
    {


        #region Fields

        protected List<Numero> _numeros;


        #endregion


        #region Propeties

        public ETipoNumero Tipo { get; set; }

        #endregion

        #region Methods

        #region Constructor

        private ColectoraDeNumeros()
        {
            this._numeros = new List<Numero>();
        }


        public ColectoraDeNumeros(ETipoNumero tipo) : this()
        {

            this.Tipo = tipo;

            

        }


        #endregion

        #endregion

        #region Operators

        public static bool operator ==(ColectoraDeNumeros cn, Numero n)
        {
            bool returnAux = false;
            int count = 0;

            
            
            foreach (Numero element in cn._numeros)
            {
                if (n.Number == element.Number) break;
                count++;
            }

            if (cn._numeros.Count > count)
            {
                if (cn._numeros.Count > 0) returnAux = true;
            }

            
            

            return returnAux; 

        }

        public static bool operator !=(ColectoraDeNumeros cn, Numero n)
        {
            

     

            return !(cn == n);

        }

        public static ColectoraDeNumeros operator +(ColectoraDeNumeros cn, Numero n)
        {

            foreach()


            return cn;
        }

        #endregion

    }


}
