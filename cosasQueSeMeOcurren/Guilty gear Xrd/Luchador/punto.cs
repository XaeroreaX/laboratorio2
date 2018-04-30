using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometria
{
    public class Punto
    {
        #region Fields
        private int _x;
        private int _y;

        #endregion


        #region Propeties
        public int Y
        {

            get
            {
                return this._y;

            }

            set
            {
                this._y = value;

            }

        }


        public int X
        {

            get
            {
                return this._x;

            }

            set
            {
                this._x = value;

            }

        }
        #endregion


        #region Methods
        public Punto(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }
        #endregion


        #region Operator

        public static Punto operator +(Punto somado, Punto sumador)
        {

            somado.Y += sumador.Y;

            somado.X += somado.X;

            return somado;

        }

        #endregion

    }
}
