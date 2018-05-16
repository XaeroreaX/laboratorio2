using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItemsDeposito;


namespace DepositoGenerico
{
    public class Deposito<T>
    {

        #region Fields

        private int _capacidadMaxima;

        private List<T> _lista;

        #endregion


        #region Methods

        public bool agregar(T that)
        {
            bool returnAux = false;
            int i = 0;


            if ((object)that == null || this._capacidadMaxima <= this._lista.Count) return returnAux;


            for (i = 0; i < this._lista.Count; i++)
            {

                if (this._lista[i].Equals(that) == true) break;

            }

            if (i == this._lista.Count)
            {
                this._lista.Add(that);
                returnAux = true;
            }

            return returnAux;
        }

        private int GetIndice(T that)
        {
            int returnAux = 0;

            foreach(T element in this._lista)
            {

                if(element.Equals(that) == true) break;
                

                returnAux++;
            }

            return returnAux;

        }

        public bool remove(T that)
        {
            bool returnAux = false;
            int index = this.GetIndice(that);

            if (index < this._lista.Count)
            {

                this._lista.RemoveAt(index);
                returnAux = true;
            }

            return returnAux;
        }

        public override string ToString()
        {
            string toString = base.ToString()+"\n";

            foreach(T element in this._lista)
            {
                toString += element.ToString();
            }

            return toString;
        }

        #region Constructor

        public Deposito(int capacidad)
        {
            this._capacidadMaxima = capacidad;

            this._lista = new List<T>();

             
        }

        #endregion

        #endregion

    }
}
