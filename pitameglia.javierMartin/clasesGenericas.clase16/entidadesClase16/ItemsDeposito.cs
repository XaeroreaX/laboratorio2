using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemsDeposito
{

    public class Auto
    {

        #region Fields

        private string _color;
        private string _marca;

        #endregion


        #region Propeties

        public string Color
        {
            get
            { return this._color; }
        }

        public string Marca
        {
            get { return this._marca; }
        }

        #endregion

        #region Methods

        public override bool Equals(object obj)
        {
            bool returnAux = base.Equals(obj);

            if(obj == null) return returnAux;

            if(this == (Auto)obj) returnAux = true;


            return returnAux;
        }

        public override string ToString()
        {
            

            return "MARCA:"+this._marca+"\nCOLOR:"+this._color;
        }

        #region Construct

        public Auto(string color, string marca)
        {
            this._color = color;
            this._marca = marca;

        }


        #endregion

        #endregion

        #region Operator

        public static bool operator ==(Auto A1, Auto A2)
        {
            bool returnAux = false;

            if ((object)A1 == null && (object)A2 == null) return true;

            try
            {
                if (A1._color == A2._color && A1._marca == A2._marca) returnAux = true;
            }

            catch (NullReferenceException miEx)
            {
                returnAux = false;
                
            }

            return returnAux; 
        }

        public static bool operator !=(Auto A1, Auto A2)
        {
            bool returnAux = !(A1 == A2);


            return returnAux;
        }

        #endregion


    }

}
